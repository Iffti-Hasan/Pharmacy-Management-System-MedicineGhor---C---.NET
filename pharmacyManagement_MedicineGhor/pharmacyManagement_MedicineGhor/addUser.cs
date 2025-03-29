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
    public partial class addUser : UserControl
    {
        string connectionString = @"Data Source=DESKTOP-EESOC6N\SQLEXPRESS;Initial Catalog=pharmacyManagement;Integrated Security=True;Encrypt=False";
        public addUser()
        {
            InitializeComponent();
            displayAddUsers();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void displayAddUsers()
        {
            adminAddUserData aauData = new adminAddUserData();
            List<adminAddUserData> listData = aauData. listAddUserData();

            userdataGridView.DataSource = listData;
        }

        private void addUserBtn_Click(object sender, EventArgs e)
        {
            if(addUsers_userName.Text=="" || addUsers_userPass.Text=="" || addUsers_userEmail.Text=="" || addUsers_userRole.SelectedIndex==-1 || addUsers_userStatus.SelectedIndex==-1) 
            {
                MessageBox.Show("Empty fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using(SqlConnection connect = new SqlConnection(connectionString))
                {
                    connect.Open();

                    string checkEmail = "SELECT * FROM users WHERE email= @email";

                    using(SqlCommand checkemail=new SqlCommand(checkEmail,connect))
                    {
                        checkemail.Parameters.AddWithValue("@email", addUsers_userEmail.Text.Trim());

                        SqlDataAdapter adapter=new SqlDataAdapter(checkemail);
                        DataTable table= new DataTable();
                        adapter.Fill(table);

                        if(table.Rows.Count>0) 
                        {
                            string tempemail = addUsers_userEmail.Text.Substring(0, 1).ToUpper() + addUsers_userEmail.Text.Substring(1);
                            MessageBox.Show(tempemail + " is existing already", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            string insertData =" INSERT INTO users(userRole,status,userName,pass,email,date_register) VALUES (@userRole,@status,@userName,@pass,@email,@date)";

                            using(SqlCommand cmd=new SqlCommand(insertData,connect))
                            {
                                cmd.Parameters.AddWithValue("@userRole", addUsers_userRole.SelectedItem.ToString());
                                cmd.Parameters.AddWithValue("@status", addUsers_userStatus.SelectedItem.ToString());
                                cmd.Parameters.AddWithValue("@userName", addUsers_userName.Text.Trim());
                                cmd.Parameters.AddWithValue("@pass", addUsers_userPass.Text.Trim());
                                cmd.Parameters.AddWithValue("@email", addUsers_userEmail.Text.Trim());


                                DateTime today = DateTime.Today;
                                cmd.Parameters.AddWithValue("@date", today);
                                


                                cmd.ExecuteNonQuery();
                                clearFields();

                                MessageBox.Show("Added Successfully!","Information Message",MessageBoxButtons.OK, MessageBoxIcon.Information);



                            }
                        }
                    }

                }
            }
            displayAddUsers();
        }

        public void clearFields()
        {
            addUsers_userName.Text = "";
            addUsers_userPass.Text = "";
            addUsers_userEmail.Text = "";
            addUsers_userRole.SelectedIndex = -1;
            addUsers_userStatus.SelectedIndex = -1;
        }

        private void resetUserBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void updateUserBtn_Click(object sender, EventArgs e)
        {
            if (addUsers_userName.Text == "" || addUsers_userPass.Text == "" || addUsers_userEmail.Text == "" || addUsers_userRole.SelectedIndex == -1 || addUsers_userStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select Item First", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to Update: " + getID + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (SqlConnection connect = new SqlConnection(connectionString))
                    {
                        connect.Open();

                        string updateData = "UPDATE users SET userRole=@userRole,status=@status,userName=@userName,pass=@pass,email=@email WHERE id=@id";

                        using (SqlCommand cmd = new SqlCommand(updateData, connect))
                        {
                            cmd.Parameters.AddWithValue("@userRole", addUsers_userRole.SelectedItem.ToString());
                            cmd.Parameters.AddWithValue("@status", addUsers_userStatus.SelectedItem.ToString());
                            cmd.Parameters.AddWithValue("@userName", addUsers_userName.Text.Trim());
                            cmd.Parameters.AddWithValue("@pass", addUsers_userPass.Text.Trim());
                            cmd.Parameters.AddWithValue("@email", addUsers_userEmail.Text.Trim());
                            cmd.Parameters.AddWithValue("@id", getID);

                            cmd.ExecuteNonQuery();
                            clearFields();

                            MessageBox.Show("Updated Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);




                        }
                    }
                }
            }
            displayAddUsers();
        }
        private int getID = 0;
        private void userdataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex !=-1) 
            {
                DataGridViewRow row = userdataGridView.Rows[e.RowIndex];

                getID = Convert.ToInt32(row.Cells[0].Value);
                addUsers_userName.Text = row.Cells[3].Value.ToString();
                addUsers_userPass.Text = row.Cells[4].Value.ToString();
                addUsers_userEmail.Text = row.Cells[5].Value.ToString();
                addUsers_userRole.SelectedItem = row.Cells[1].Value.ToString();
                addUsers_userStatus.SelectedItem = row.Cells[2].Value.ToString();

            }
        }

        private void deleteUserBtn_Click(object sender, EventArgs e)
        {
            if (addUsers_userName.Text == "" || addUsers_userPass.Text == "" || addUsers_userEmail.Text == "" || addUsers_userRole.SelectedIndex == -1 || addUsers_userStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select Item First", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to Delete: " + getID + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (SqlConnection connect = new SqlConnection(connectionString))
                    {
                        connect.Open();

                        string updateData = "DELETE FROM users WHERE id=@id";

                        using (SqlCommand cmd = new SqlCommand(updateData, connect))
                        {
                            
                            cmd.Parameters.AddWithValue("@id", getID);

                            cmd.ExecuteNonQuery();
                            clearFields();

                            MessageBox.Show("Deleted Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);




                        }
                    }
                }
            }
            displayAddUsers();
        }

        private void userdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
