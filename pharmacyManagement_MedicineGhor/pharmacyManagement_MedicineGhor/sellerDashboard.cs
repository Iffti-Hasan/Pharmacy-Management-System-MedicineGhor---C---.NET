using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace pharmacyManagement_MedicineGhor
{
    public partial class sellerDashboard : UserControl
    {
        string connectionString = @"Data Source=DESKTOP-EESOC6N\SQLEXPRESS;Initial Catalog=pharmacyManagement;Integrated Security=True;Encrypt=False";
        
        public sellerDashboard()
        {
            InitializeComponent();
            displaytodays_revenue();
            displayavailable_medicine();
            displaytodays_order();
            DisplayAllTransactions();
            todayorderlist_gridview.AllowUserToAddRows = false;
        }

        public void displaytodays_revenue()
        {
            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                connect.Open();
                DateTime today = DateTime.Today;

                string selectData = "SELECT SUM(totalTransactionAmount) as todays_revenue FROM transactions WHERE CAST(purchaseDate AS DATE) = @today";
                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    cmd.Parameters.AddWithValue("@today", today);
                    SqlDataReader reader = cmd.ExecuteReader();
                    {
                        if (reader.Read())
                        {
                            if (reader["todays_revenue"] != DBNull.Value)
                            {
                                long todaysRev = Convert.ToInt64(reader["todays_revenue"]);
                                todays_revenue.Text = "৳" + todaysRev.ToString();
                            }
                        }
                    }
                }
            }
        }

        public void displayavailable_medicine()
        {
            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                connect.Open();

                string selectData = "SELECT COUNT(id) as available_medicine FROM medicine";
                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {

                    SqlDataReader reader = cmd.ExecuteReader();
                    {
                        if (reader.Read())
                        {
                            if (reader["available_medicine"] != DBNull.Value)
                            {
                                int availM = (int)reader["available_medicine"];
                                available_medicine.Text = availM.ToString();
                            }
                        }
                    }
                }
            }
        }

        public void displaytodays_order()
        {
            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                connect.Open();
                DateTime today = DateTime.Today;

                string selectData = "SELECT COUNT(transactionId) as todays_order  FROM transactions WHERE CAST(purchaseDate AS DATE) = @today";
                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    cmd.Parameters.AddWithValue("@today", today);
                    SqlDataReader reader = cmd.ExecuteReader();
                    {
                        if (reader.Read())
                        {
                            if (reader["todays_order"] != DBNull.Value)
                            {
                                int todaO = (int)reader["todays_order"];
                                todays_order.Text = todaO.ToString();
                            }
                        }
                    }
                }
            }
        }

        private void todayorderlist_gridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void DisplayAllTransactions()
        {
            DataTable transactionsDataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string selectQuery = "SELECT * FROM Transactions"; // Modify this query if needed

                using (SqlCommand command = new SqlCommand(selectQuery, connection))
                {
                    try
                    {
                        connection.Open();

                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        adapter.Fill(transactionsDataTable);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error fetching transactions: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            
            todayorderlist_gridview.DataSource = transactionsDataTable;

            
            if (todayorderlist_gridview.Columns.Count > 0)
            {
                todayorderlist_gridview.Columns["transactionId"].HeaderText = "TransactionID";
                todayorderlist_gridview.Columns["customerId"].HeaderText = "CustomerID";
                todayorderlist_gridview.Columns["totalTransactionAmount"].HeaderText = "TotalTransactionAmount";
                todayorderlist_gridview.Columns["purchaseDate"].HeaderText = "PurchaseDate";
                todayorderlist_gridview.Columns["status"].HeaderText = "Status";
                todayorderlist_gridview.Columns["customerName"].HeaderText = "CustomerName";
                todayorderlist_gridview.Columns["mobileNo"].HeaderText = "MobileNo";
                
            }
        }
        
    }
}
