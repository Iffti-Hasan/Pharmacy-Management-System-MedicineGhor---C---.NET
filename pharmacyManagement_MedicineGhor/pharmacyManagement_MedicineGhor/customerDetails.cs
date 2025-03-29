using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace pharmacyManagement_MedicineGhor
{
    public partial class customerDetails : UserControl
    {
        string connectionString = @"Data Source=DESKTOP-EESOC6N\SQLEXPRESS;Initial Catalog=pharmacyManagement;Integrated Security=True;Encrypt=False";
        DataTable customerDataTable;

        public customerDetails()
        {
            InitializeComponent();
            customerData.AllowUserToAddRows = false;
            customerDataTable = new DataTable();
            DisplayAllCustomers();
            searchBox.TextChanged += searchBox_TextChanged; 
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            FilterCustomers(searchBox.Text);
        }

        private void FilterCustomers(string searchTerm)
        {
            if (customerDataTable != null && customerDataTable.Rows.Count > 0)
            {
                DataTable filteredTable = customerDataTable.Clone();
                string searchTermLower = searchTerm.ToLower(); 

                foreach (DataRow row in customerDataTable.Rows)
                {
                    string customerName = row["customerName"].ToString().ToLower(); 
                    string mobileNo = row["mobileNo"].ToString(); // Get mobile number

                    if (customerName.Contains(searchTermLower) || mobileNo.Contains(searchTerm))
                    {
                        filteredTable.ImportRow(row);
                    }
                }
                customerData.DataSource = filteredTable;
            }
        }

        public void DisplayAllCustomers()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string selectQuery = "SELECT customerID, customerName, mobileNo FROM customers"; 

                using (SqlCommand command = new SqlCommand(selectQuery, connection))
                {
                    try
                    {
                        connection.Open();

                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        adapter.Fill(customerDataTable);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error fetching customer data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            customerData.DataSource = customerDataTable;

            if (customerData.Columns.Count > 0)
            {
                customerData.Columns["customerID"].HeaderText = "Customer ID";
                customerData.Columns["customerName"].HeaderText = "Customer Name";
                customerData.Columns["mobileNo"].HeaderText = "Mobile No";
            }
        }
    }
}
