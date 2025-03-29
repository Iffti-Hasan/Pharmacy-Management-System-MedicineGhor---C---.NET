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
    public partial class allOrders : UserControl
    {
        string connectionString = @"Data Source=DESKTOP-EESOC6N\SQLEXPRESS;Initial Catalog=pharmacyManagement;Integrated Security=True;Encrypt=False";
        DataTable transactionsDataTable;

        public allOrders()
        {
            InitializeComponent();
            allOrderGridview.AllowUserToAddRows = false;
            transactionsDataTable = new DataTable();
            DisplayAllTransactions();
        }

        private void searchOrdName_txt_TextChanged(object sender, EventArgs e)
        {
            FilterTransactions(searchOrdName_txt.Text);
        }

        private void FilterTransactions(string searchTerm)
        {
            if (transactionsDataTable != null && transactionsDataTable.Rows.Count > 0)
            {
                DataTable filteredTable = transactionsDataTable.Clone();
                string searchTermLower = searchTerm.ToLower();

                foreach (DataRow row in transactionsDataTable.Rows)
                {
                    string customerName = row["customerName"].ToString().ToLower();
                    string customerId = row["customerId"].ToString();
                    string mobileNo = row["mobileNo"].ToString();

                    if (customerName.Contains(searchTermLower) || customerId.Contains(searchTerm) || mobileNo.Contains(searchTerm))
                    {
                        filteredTable.ImportRow(row);
                    }
                }
                allOrderGridview.DataSource = filteredTable;
            }
        }

        public void DisplayAllTransactions()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string selectQuery = "SELECT * FROM Transactions";

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

            allOrderGridview.DataSource = transactionsDataTable;

            if (allOrderGridview.Columns.Count > 0)
            {
                allOrderGridview.Columns["transactionId"].HeaderText = "TransactionID";
                allOrderGridview.Columns["customerId"].HeaderText = "CustomerID";
                allOrderGridview.Columns["totalTransactionAmount"].HeaderText = "TotalTransactionAmount";
                allOrderGridview.Columns["purchaseDate"].HeaderText = "PurchaseDate";
                allOrderGridview.Columns["status"].HeaderText = "Status";
                allOrderGridview.Columns["customerName"].HeaderText = "CustomerName";
                allOrderGridview.Columns["mobileNo"].HeaderText = "MobileNo";
            }
        }
    }
}
