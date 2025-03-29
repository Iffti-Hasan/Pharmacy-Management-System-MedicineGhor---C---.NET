using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace pharmacyManagement_MedicineGhor
{
    public partial class addMedicine : UserControl
    {
        string connectionString = @"Data Source=DESKTOP-EESOC6N\SQLEXPRESS;Initial Catalog=pharmacyManagement;Integrated Security=True;Encrypt=False";
        public addMedicine()
        {
            InitializeComponent();
            dataGridView1.AllowUserToAddRows = false;
            displayMedicineData();
        }

        public void displayMedicineData()
        {
            medicineData medData = new medicineData();
            List<medicineData> listData = medData.GetMedicineData();

            dataGridView1.DataSource = listData;
        }

        private void addMed_btn_Click(object sender, EventArgs e)
        {

            if (addManufaD.Value > addExpD.Value)
            {
                MessageBox.Show("Expiry date cannot be before manufacturing date.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }

            if (addMedName.Text == "" || addCategory.Text == "" || addPerUnit.Text == "" || addQuan.Text == "" || addMedStatus.SelectedIndex == -1 || addManufaD.Text == "" || addExpD.Text == "")
            {
                MessageBox.Show("Empty fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (Convert.ToInt64(addQuan.Text.Trim()) < 0)
                {
                    MessageBox.Show("Quantity cannot be less than zero.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                using (SqlConnection connect = new SqlConnection(connectionString))
                {
                    connect.Open();

                    
                    string checkDuplicateQuery = "SELECT COUNT(*) FROM medicine WHERE mname = @mname AND mcategory = @mcategory";
                    using (SqlCommand checkCmd = new SqlCommand(checkDuplicateQuery, connect))
                    {
                        checkCmd.Parameters.AddWithValue("@mname", addMedName.Text.Trim());
                        checkCmd.Parameters.AddWithValue("@mcategory", addCategory.Text.Trim());
                        int count = (int)checkCmd.ExecuteScalar();

                        if (count > 0)
                        {
                            MessageBox.Show("Medicine with the same name and category already exists in the database.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return; 
                        }
                    }

                    
                    string insertData = "INSERT INTO medicine(mname, mcategory, perUnit, quantity, status, manufacturingDate , expiryDate ) VALUES (@mname, @mcategory, @perUnit, @quantity, @status, @manufacturingDate, @expiryDate )";

                    using (SqlCommand cmd = new SqlCommand(insertData, connect))
                    {
                        cmd.Parameters.AddWithValue("@mname", addMedName.Text.Trim());
                        cmd.Parameters.AddWithValue("@mcategory", addCategory.Text.Trim());
                        cmd.Parameters.AddWithValue("@perUnit", Convert.ToInt64(addPerUnit.Text.Trim()));
                        cmd.Parameters.AddWithValue("@quantity", Convert.ToInt64(addQuan.Text.Trim()));
                        cmd.Parameters.AddWithValue("@status", addMedStatus.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@manufacturingDate", addManufaD.Value.ToShortDateString());
                        cmd.Parameters.AddWithValue("@expiryDate", addExpD.Value.ToShortDateString());

                        cmd.ExecuteNonQuery();
                        clearFields();

                        MessageBox.Show("Medicine Added Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            displayMedicineData();
        }

        private void clearFields()
        {
            addMedName.Text = "";
            addCategory.Text = "";
            addPerUnit.Text = "";
            addQuan.Text = "";
            addMedStatus.SelectedIndex = -1;
            addManufaD.Value = DateTime.Today;
            addExpD.Value = DateTime.Today;
        }

        private void updMed_btn_Click(object sender, EventArgs e)
        {

            if (addManufaD.Value > addExpD.Value)
            {
                MessageBox.Show("Expiry date cannot be before manufacturing date.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }
            if (addMedName.Text == "" || addCategory.Text == "" || addPerUnit.Text == "" || addQuan.Text == "" || addMedStatus.SelectedIndex == -1 || addManufaD.Text == "" || addExpD.Text == "")
            {
                MessageBox.Show("Please Select Item First", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (Convert.ToInt64(addQuan.Text.Trim()) < 0)
                {
                    MessageBox.Show("Quantity cannot be less than zero.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (MessageBox.Show("Are you sure you want to Update?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (SqlConnection connect = new SqlConnection(connectionString))
                    {
                        connect.Open();

                        string updateData = "UPDATE medicine SET mname=@mname, mcategory=@mcategory, perUnit=@perUnit, quantity=@quantity, status=@status, manufacturingDate=@manufacturingDate, expiryDate =@expiryDate  WHERE id=@id";

                        using (SqlCommand cmd = new SqlCommand(updateData, connect))
                        {
                            cmd.Parameters.AddWithValue("@mname", addMedName.Text.Trim());
                            cmd.Parameters.AddWithValue("@mcategory", addCategory.Text.Trim());
                            cmd.Parameters.AddWithValue("@perUnit", Convert.ToInt64(addPerUnit.Text.Trim()));
                            cmd.Parameters.AddWithValue("@quantity", Convert.ToInt64(addQuan.Text.Trim()));
                            cmd.Parameters.AddWithValue("@status", addMedStatus.SelectedItem.ToString());
                            cmd.Parameters.AddWithValue("@manufacturingDate", addManufaD.Value.ToShortDateString());
                            cmd.Parameters.AddWithValue("@expiryDate", addExpD.Value.ToShortDateString());
                            cmd.Parameters.AddWithValue("@id", getID);

                            cmd.ExecuteNonQuery();
                            clearFields();

                            MessageBox.Show("Medicine Updated Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            displayMedicineData();
        }



        private void dltMed_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Delete : " + getID + " ? ", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (SqlConnection connect = new SqlConnection(connectionString))
                {
                    connect.Open();

                    string checkRelatedRecordsQuery = "SELECT COUNT(*) FROM transaction_details WHERE medicineId = @id";
                    using (SqlCommand checkCmd = new SqlCommand(checkRelatedRecordsQuery, connect))
                    {
                        checkCmd.Parameters.AddWithValue("@id", getID);
                        int count = (int)checkCmd.ExecuteScalar();

                        if (count > 0)
                        {
                            MessageBox.Show("There are related records in the transaction_details table. Delete them first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    
                    string deleteData = "DELETE FROM medicine WHERE id=@id";

                    using (SqlCommand cmd = new SqlCommand(deleteData, connect))
                    {
                        cmd.Parameters.AddWithValue("@id", getID);

                        cmd.ExecuteNonQuery();
                        clearFields();

                        MessageBox.Show("Medicine Deleted Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            displayMedicineData();
        }




        private void resetMed_btn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private int getID = 0;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                getID = Convert.ToInt32(row.Cells[0].Value);
                addMedName.Text = row.Cells[1].Value.ToString();
                addCategory.Text = row.Cells[2].Value.ToString();
                addPerUnit.Text = row.Cells[3].Value.ToString();
                addQuan.Text = row.Cells[4].Value.ToString();
                addMedStatus.SelectedItem = row.Cells[5].Value.ToString();
                addManufaD.Text = row.Cells[6].Value.ToString();
                addExpD.Text = row.Cells[7].Value.ToString();
            }
        }

        
        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            string searchQuery = searchBox.Text.Trim();

            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                connect.Open();

                string searchDataQuery = "SELECT id, mname AS [Name], mcategory AS [Category], perUnit AS [Per Unit], quantity AS [Quantity], status AS [Status], manufacturingDate AS [ManufacturingDate], expiryDate AS [ExpiryDate] FROM medicine WHERE mname LIKE @searchQuery OR mcategory LIKE @searchQuery OR CAST(perUnit AS NVARCHAR) LIKE @searchQuery OR quantity LIKE @searchQuery OR status LIKE @searchQuery OR manufacturingDate LIKE @searchQuery OR expiryDate LIKE @searchQuery OR CAST(id AS NVARCHAR) LIKE @searchQuery";

                using (SqlCommand cmd = new SqlCommand(searchDataQuery, connect))
                {
                    cmd.Parameters.AddWithValue("@searchQuery", "%" + searchQuery + "%");

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridView1.DataSource = null;

                    if (dataTable.Rows.Count > 0)
                    {
                        dataGridView1.DataSource = dataTable;
                    }
                }
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}   


