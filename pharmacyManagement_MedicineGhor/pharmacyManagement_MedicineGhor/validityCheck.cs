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
   

        public partial class validityCheck : UserControl
        {
            string connectionString = @"Data Source=DESKTOP-EESOC6N\SQLEXPRESS;Initial Catalog=pharmacyManagement;Integrated Security=True;Encrypt=False";

            public validityCheck()
            {
                InitializeComponent();
                medicineValidityGridview.AllowUserToAddRows = false;

                
                validityCheckCombo.SelectedIndex = 2;

                
                LoadMedicineData();

                
                validityCheckCombo.SelectedIndexChanged += new EventHandler(validityCheckCombo_SelectedIndexChanged);
                medicineValidityGridview.CellClick += new DataGridViewCellEventHandler(medicineValidityGridview_CellClick);
            }

            private void validityCheckCombo_SelectedIndexChanged(object sender, EventArgs e)
            {
                LoadMedicineData();
            }

            private void LoadMedicineData()
            {
                

                string validityFilter = GetValidityFilter();

                using (SqlConnection connect = new SqlConnection(connectionString))
                {
                    connect.Open();

                    string selectQuery = "SELECT id, mname AS [Name], mcategory AS [Category], perUnit AS [Per Unit], quantity AS [Quantity], status AS [Status], manufacturingDate AS [ManufacturingDate], expiryDate AS [ExpiryDate] FROM medicine " + validityFilter;

                    using (SqlCommand cmd = new SqlCommand(selectQuery, connect))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        medicineValidityGridview.DataSource = dataTable;
                    }
                }
            }

            private string GetValidityFilter()
            {
                DateTime today = DateTime.Today;
                string validityFilter = "";

                switch (validityCheckCombo.SelectedIndex)
                {
                    case 0: 
                        validityFilter = $"WHERE expiryDate >= '{today.ToShortDateString()}'";
                        break;
                    case 1: 
                        validityFilter = $"WHERE expiryDate < '{today.ToShortDateString()}'";
                        break;
                    default: 
                        break;
                }

                return validityFilter;
            }

            private void medicineValidityGridview_CellClick(object sender, DataGridViewCellEventArgs e)
            {
               
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    
                    object cellValue = medicineValidityGridview.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

                    
                    MessageBox.Show("Clicked cell value: " + cellValue.ToString(), "Cell Clicked", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        
    }
    

}


    

