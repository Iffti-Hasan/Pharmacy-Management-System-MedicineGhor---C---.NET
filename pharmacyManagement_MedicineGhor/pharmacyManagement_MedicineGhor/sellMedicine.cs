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
using System.Drawing.Printing;
using System.Windows.Forms.DataVisualization.Charting;
using pharmacyManagement_MedicineGhor.Properties;
using System.Reflection;
using System.Web;

namespace pharmacyManagement_MedicineGhor
{
    public partial class sellMedicine : UserControl
    {
      
        string connectionString = @"Data Source=DESKTOP-EESOC6N\SQLEXPRESS;Initial Catalog=pharmacyManagement;Integrated Security=True;Encrypt=False";
        private CustomerManager customerManager;

        
        public sellMedicine()
        {
            InitializeComponent();
            medicnesGrid_View.AllowUserToAddRows = false;
            quantityNumUpDown.Minimum = 1;
            customerManager = new CustomerManager(connectionString);
            cartItemsGridView.Rows.Clear();

            cartItemsGridView.Columns.Add("MedicineId", "Medicine ID");
            cartItemsGridView.Columns.Add("MedicineName", "Medicine Name");
            cartItemsGridView.Columns.Add("Category", "Category");
            cartItemsGridView.Columns.Add("PricePerUnit", "Price Per Unit");
            cartItemsGridView.Columns.Add("Quantity", "Quantity");
            cartItemsGridView.Columns.Add("Status", "Status");
            cartItemsGridView.Columns.Add("ManufacturingDate", "Manufacturing Date");
            cartItemsGridView.Columns.Add("ExpiryDate", "Expiry Date");
            cartItemsGridView.Columns.Add("TotalPrice", "Total Price");
            cartItemsGridView.AllowUserToAddRows = false;
            cartItemsGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;


            printDocs = new PrintDocument();
            printDocs.PrintPage += new PrintPageEventHandler(printDocs_PrintPage);



        }



        private void searchCustoName_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchCustoNumber_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchCustoName_btn_Click(object sender, EventArgs e)
        {
            string mobileNumber = searchCustoNumber_txt.Text.Trim();


            if (string.IsNullOrEmpty(mobileNumber) || mobileNumber.Length != 11)
            {
                MessageBox.Show("Please enter a valid mobile number (11 digits).", "Invalid Mobile Number", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            string customerName = GetCustomerNameByMobileNumber(mobileNumber);

            if (customerName != null)
            {

                searchCustoName_txt.Text = customerName;
            }
            else
            {

                MessageBox.Show("No customer found with the provided mobile number.", "Customer Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        public string GetCustomerNameByMobileNumber(string mobileNumber)
        {
            string customerName = null;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT customerName FROM customers WHERE mobileNo = @MobileNumber";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MobileNumber", mobileNumber);

                    try
                    {
                        connection.Open();
                        customerName = (string)command.ExecuteScalar();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error retrieving customer name: " + ex.Message);
                    }
                }
            }

            return customerName;
        }

        private void searchMedName_txt_TextChanged(object sender, EventArgs e)
        {
            string searchQuery = searchMedName_txt.Text.Trim();

            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                connect.Open();

                string searchDataQuery = @"SELECT id, 
                                   mname AS [Name], 
                                   mcategory AS [Category], 
                                   perUnit AS [Per Unit], 
                                   quantity AS [Quantity], 
                                   status AS [Status], 
                                   manufacturingDate AS [ManufacturingDate], 
                                   expiryDate AS [ExpiryDate] 
                               FROM medicine 
                               WHERE (mname LIKE @searchQuery OR mcategory LIKE @searchQuery) 
                               AND expiryDate >= GETDATE()
                               AND status = 'Active'";

                using (SqlCommand cmd = new SqlCommand(searchDataQuery, connect))
                {
                    cmd.Parameters.AddWithValue("@searchQuery", "%" + searchQuery + "%");

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    medicnesGrid_View.DataSource = null;

                    if (dataTable.Rows.Count > 0)
                    {
                        medicnesGrid_View.DataSource = dataTable;
                    }
                }
            }
        }



        private void sellComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void quantityNumUpDown_ValueChanged(object sender, EventArgs e)
        {
            UpdateTotalPriceLabel();
        }



        private void UpdateTotalPriceLabel()
        {
            decimal totalPrice = 0;

            foreach (DataGridViewRow row in cartItemsGridView.Rows)
            {
                totalPrice += Convert.ToDecimal(row.Cells["TotalPrice"].Value);
            }


            totalPriceAmount_label.Text = totalPrice.ToString();
        }

        private void removeFromCart_btn_Click(object sender, EventArgs e)
        {
            if (cartItemsGridView.SelectedRows.Count > 0)
            {

                int selectedIndex = cartItemsGridView.SelectedRows[0].Index;


                cartItemsGridView.Rows.RemoveAt(selectedIndex);


                UpdateTotalPriceLabel();
            }
            else
            {
                MessageBox.Show("Please select an item to remove from the cart.", "No Item Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }














        private void selleMedicineReset_btn_Click(object sender, EventArgs e)
        {
            searchCustoName_txt.Clear();
            searchCustoNumber_txt.Clear();

        }

        private void medicnesGrid_View_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = medicnesGrid_View.Rows[e.RowIndex];
                string fullName = row.Cells["Name"].Value.ToString();
                searchMedName_txt.Text = fullName;
            }
        }

        private void totalPriceAmount_label_Click(object sender, EventArgs e)
        {

        }

        private void changePriceAmount_label_Click(object sender, EventArgs e)
        {

        }

        private void amountPaind_txt_TextChanged(object sender, EventArgs e)
        {
            CalculateChangeAmount();
        }
        private void CalculateChangeAmount()
        {

            if (decimal.TryParse(amountPaind_txt.Text, out decimal amountPaid))
            {

                if (decimal.TryParse(totalPriceAmount_label.Text, out decimal totalPrice))
                {

                    decimal changeAmount = amountPaid - totalPrice;


                    changePriceAmount_label.Text = changeAmount.ToString();
                }
                else
                {

                    changePriceAmount_label.Text = "Invalid";
                }
            }
            else
            {

                changePriceAmount_label.Text = "Invalid";
            }
        }
        private void cartItemsGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void statusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void searchmedicinereset_Click(object sender, EventArgs e)
        {
            searchMedName_txt.Clear();
            quantityNumUpDown.Value = 1;
        }

        private void addCa_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = null;


            if (medicnesGrid_View.SelectedRows.Count > 0)
            {
                selectedRow = medicnesGrid_View.SelectedRows[0];
            }

            else if (medicnesGrid_View.SelectedCells.Count == 1)
            {
                selectedRow = medicnesGrid_View.Rows[medicnesGrid_View.SelectedCells[0].RowIndex];
            }

            if (selectedRow != null)
            {
                int medicineId = Convert.ToInt32(selectedRow.Cells["id"].Value);
                string medicineName = Convert.ToString(selectedRow.Cells["Name"].Value);
                string category = Convert.ToString(selectedRow.Cells["Category"].Value);
                long pricePerUnit = Convert.ToInt64(selectedRow.Cells["Per Unit"].Value);
                long quantity = Convert.ToInt64(quantityNumUpDown.Value);
                string status = Convert.ToString(selectedRow.Cells["Status"].Value);
                DateTime manufacturingDate = Convert.ToDateTime(selectedRow.Cells["ManufacturingDate"].Value);
                DateTime expiryDate = Convert.ToDateTime(selectedRow.Cells["ExpiryDate"].Value);
                decimal totalPrice = pricePerUnit * quantity;
                string formattedManufacturingDate = manufacturingDate.ToString("MM-dd-yyyy");
                string formattedExpiryDate = expiryDate.ToString("MM-dd-yyyy");
                long availableQuantity = Convert.ToInt64(selectedRow.Cells["Quantity"].Value);
                if (quantity > availableQuantity)
                {
                    MessageBox.Show("The requested quantity exceeds the available stock. Please enter a valid quantity.", "Insufficient Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }



                cartItemsGridView.Rows.Add(medicineId, medicineName, category, pricePerUnit, quantity, status, formattedManufacturingDate, formattedExpiryDate, totalPrice);

                
                UpdateTotalPriceLabel();
            }
            else
            {
                MessageBox.Show("Please select a medicine from the list.", "No Medicine Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }







        private void clearCartBtn_Click(object sender, EventArgs e)
        {
            cartItemsGridView.Rows.Clear();


            UpdateTotalPriceLabel();
        }

        private void purchaseAndPrint_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(searchCustoNumber_txt.Text) || cartItemsGridView.Rows.Count == 0)
            {
                MessageBox.Show("Please provide a customer number and add items to the cart.", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string customerName = searchCustoName_txt.Text.Trim();
            if (string.IsNullOrWhiteSpace(customerName))
            {
                MessageBox.Show("Please provide a customer name.", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string mobileNumber = searchCustoNumber_txt.Text.Trim();
            int customerId = GetCustomerIdByMobileNumber(mobileNumber);

            if (customerId == -1)
            {
                InsertCustomerIntoDatabase(customerName, mobileNumber);
                customerId = GetCustomerIdByMobileNumber(mobileNumber);
            }

            decimal totalTransactionAmount = CalculateTotalTransactionAmount();
            int transactionId = CreateTransaction(customerId, totalTransactionAmount, customerName, mobileNumber);

            foreach (DataGridViewRow row in cartItemsGridView.Rows)
            {
                int medicineId = Convert.ToInt32(row.Cells["MedicineId"].Value);
                string medicineName = Convert.ToString(row.Cells["MedicineName"].Value);
                string category = Convert.ToString(row.Cells["Category"].Value);
                long pricePerUnit = Convert.ToInt64(row.Cells["PricePerUnit"].Value);
                int quantity = Convert.ToInt32(row.Cells["Quantity"].Value);
                DateTime manufacturingDate = Convert.ToDateTime(row.Cells["ManufacturingDate"].Value);
                DateTime expiryDate = Convert.ToDateTime(row.Cells["ExpiryDate"].Value);
                decimal totalPrice = Convert.ToDecimal(row.Cells["TotalPrice"].Value);

                InsertTransactionDetail(transactionId, medicineId, medicineName, category, pricePerUnit, quantity, manufacturingDate, expiryDate, totalPrice, customerName, mobileNumber);

                UpdateMedicineQuantity(medicineId, quantity);
            }

            MessageBox.Show("Transaction completed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            try
            {
                printDocs.Print();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while printing: " + ex.Message, "Printing Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private int GetCustomerIdByMobileNumber(string mobileNumber)
        {
            int customerId = -1;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT customerId FROM customers WHERE mobileNo = @MobileNumber";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MobileNumber", mobileNumber);

                    try
                    {
                        connection.Open();
                        var result = command.ExecuteScalar();
                        if (result != null)
                        {
                            customerId = Convert.ToInt32(result);
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error retrieving customer ID: " + ex.Message);
                    }
                }
            }

            return customerId;
        }

        private void InsertCustomerIntoDatabase(string customerName, string mobileNumber)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO customers (customerName, mobileNo) VALUES (@CustomerName, @MobileNumber)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CustomerName", customerName);
                    command.Parameters.AddWithValue("@MobileNumber", mobileNumber);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error inserting customer: " + ex.Message);
                    }
                }
            }
        }

       

        private decimal CalculateTotalTransactionAmount()
        {
            decimal totalAmount = 0;

            foreach (DataGridViewRow row in cartItemsGridView.Rows)
            {
                decimal totalPrice = Convert.ToDecimal(row.Cells["TotalPrice"].Value);
                totalAmount += totalPrice;
            }

            return totalAmount;
        }

        private int CreateTransaction(int customerId, decimal totalTransactionAmount, string customerName, string mobileNumber)
        {
            int transactionId = -1;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO transactions (customerId, totalTransactionAmount, purchaseDate, customerName, mobileNo, status) " +
                               "VALUES (@CustomerId, @TotalTransactionAmount, @PurchaseDate, @CustomerName, @MobileNo, @Status);" +
                               "SELECT SCOPE_IDENTITY();";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CustomerId", customerId);
                    command.Parameters.AddWithValue("@TotalTransactionAmount", totalTransactionAmount);
                    command.Parameters.AddWithValue("@PurchaseDate", DateTime.Now);
                    command.Parameters.AddWithValue("@CustomerName", customerName);
                    command.Parameters.AddWithValue("@MobileNo", mobileNumber);
                    command.Parameters.AddWithValue("@Status", "Completed"); // Assuming default status is Completed

                    try
                    {
                        connection.Open();
                        transactionId = Convert.ToInt32(command.ExecuteScalar());
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error creating transaction: " + ex.Message);
                    }
                }
            }

            return transactionId;
        }


        private void InsertTransactionDetail(int transactionId, int medicineId, string medicineName, string category, long pricePerUnit, int quantity, DateTime manufacturingDate, DateTime expiryDate, decimal totalPrice, string customerName, string mobileNo)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string selectMedicineQuery = "SELECT mname AS [MedicineName], mcategory AS [Category], perUnit AS [PricePerUnit], manufacturingDate AS [ManufacturingDate], expiryDate AS [ExpiryDate] FROM medicine WHERE id = @MedicineId";

                string insertTransactionDetailQuery = "INSERT INTO transaction_details (transactionId, medicineId, medicineName, category, pricePerUnit, quantity, manufacturingDate, expiryDate, totalPrice, customerName, mobileNo, status) " +
                                                      "VALUES (@TransactionId, @MedicineId, @MedicineName, @Category, @PricePerUnit, @Quantity, @ManufacturingDate, @ExpiryDate, @TotalPrice, @CustomerName, @MobileNo, @Status)";

                using (SqlCommand selectCommand = new SqlCommand(selectMedicineQuery, connection))
                using (SqlCommand insertCommand = new SqlCommand(insertTransactionDetailQuery, connection))
                {
                    selectCommand.Parameters.AddWithValue("@MedicineId", medicineId);
                    insertCommand.Parameters.AddWithValue("@TransactionId", transactionId);
                    insertCommand.Parameters.AddWithValue("@MedicineId", medicineId);
                    insertCommand.Parameters.AddWithValue("@Quantity", quantity);
                    insertCommand.Parameters.AddWithValue("@TotalPrice", totalPrice);
                    insertCommand.Parameters.AddWithValue("@CustomerName", customerName);
                    insertCommand.Parameters.AddWithValue("@MobileNo", mobileNo);
                    insertCommand.Parameters.AddWithValue("@Status", "Completed"); // Assuming default status is Completed

                    try
                    {
                        connection.Open();

                        
                        using (SqlDataReader reader = selectCommand.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                insertCommand.Parameters.AddWithValue("@MedicineName", reader["MedicineName"]);
                                insertCommand.Parameters.AddWithValue("@Category", reader["Category"]);
                                insertCommand.Parameters.AddWithValue("@PricePerUnit", reader["PricePerUnit"]);
                                insertCommand.Parameters.AddWithValue("@ManufacturingDate", reader["ManufacturingDate"]);
                                insertCommand.Parameters.AddWithValue("@ExpiryDate", reader["ExpiryDate"]);

                                reader.Close();
                            }
                            else
                            {
                                Console.WriteLine("Medicine with ID {0} not found.", medicineId);
                                return;
                            }
                        }

                      
                        insertCommand.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error inserting transaction detail: " + ex.Message);
                    }
                }
            }
        }




        private void UpdateMedicineQuantity(int medicineId, int quantity)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE medicine SET quantity = quantity - @Quantity WHERE id = @MedicineId";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Quantity", quantity);
                    command.Parameters.AddWithValue("@MedicineID", medicineId);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error updating medicine quantity: " + ex.Message);
                    }
                }
            }
        }

        private void printDocs_PrintPage(object sender, PrintPageEventArgs e)
        {
           
            string dashLine = "------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------";
            Bitmap bitmap = Properties.Resources.logo_with_add;
            Image image = bitmap;

         
            e.Graphics.DrawImage(image, 23, 23, 800, 190);

           
            e.Graphics.DrawString("Customer Name: " + searchCustoName_txt.Text, new Font("Times New Roman", 10, FontStyle.Regular), Brushes.Black, new PointF(25, 250));
            e.Graphics.DrawString("Date: " + DateTime.Now.ToString("MM/dd/yyyy"), new Font("Times New Roman", 10, FontStyle.Regular), Brushes.Black, new PointF(630, 250));
            e.Graphics.DrawString("Customer Mobile No: " + searchCustoNumber_txt.Text, new Font("Times New Roman", 10, FontStyle.Regular), Brushes.Black, new PointF(25, 275));

         
            e.Graphics.DrawString(dashLine, new Font("Times New Roman", 10, FontStyle.Regular), Brushes.Black, new PointF(25, 300));

            
            e.Graphics.DrawString("Medicine Name", new Font("Times New Roman", 10, FontStyle.Regular), Brushes.Black, new PointF(25, 325));
            e.Graphics.DrawString("Category", new Font("Times New Roman", 10, FontStyle.Regular), Brushes.Black, new PointF(180, 325));
            e.Graphics.DrawString("Price Per Unit", new Font("Times New Roman", 10, FontStyle.Regular), Brushes.Black, new PointF(300, 325));
            e.Graphics.DrawString("Quantity", new Font("Times New Roman", 10, FontStyle.Regular), Brushes.Black, new PointF(420, 325));
            e.Graphics.DrawString("Total Price", new Font("Times New Roman", 10, FontStyle.Regular), Brushes.Black, new PointF(530, 325));
            e.Graphics.DrawString("Manufacturing Date", new Font("Times New Roman", 10, FontStyle.Regular), Brushes.Black, new PointF(630, 325));
            e.Graphics.DrawString("Expiry Date", new Font("Times New Roman", 10, FontStyle.Regular), Brushes.Black, new PointF(760, 325));

          
            e.Graphics.DrawString(dashLine, new Font("Times New Roman", 10, FontStyle.Regular), Brushes.Black, new PointF(25, 350));

            
            int yPosition = 375; 
            foreach (DataGridViewRow row in cartItemsGridView.Rows)
            {
                string medicineName = row.Cells["MedicineName"].Value.ToString();
                string category = row.Cells["Category"].Value.ToString();
                string pricePerUnit = row.Cells["PricePerUnit"].Value.ToString();
                string quantity = row.Cells["Quantity"].Value.ToString();
                string totalPrice = row.Cells["TotalPrice"].Value.ToString();
                string manufacturingDate = Convert.ToDateTime(row.Cells["ManufacturingDate"].Value).ToString("MM/dd/yyyy");
                string expiryDate = Convert.ToDateTime(row.Cells["ExpiryDate"].Value).ToString("MM/dd/yyyy");

                e.Graphics.DrawString(medicineName, new Font("Times New Roman", 10, FontStyle.Regular), Brushes.Black, new PointF(25, yPosition));
                e.Graphics.DrawString(category, new Font("Times New Roman", 10, FontStyle.Regular), Brushes.Black, new PointF(180, yPosition));
                e.Graphics.DrawString(pricePerUnit, new Font("Times New Roman", 11, FontStyle.Regular), Brushes.Black, new PointF(300, yPosition));
                e.Graphics.DrawString(quantity, new Font("Times New Roman", 10, FontStyle.Regular), Brushes.Black, new PointF(420, yPosition));
                e.Graphics.DrawString(totalPrice, new Font("Times New Roman", 10, FontStyle.Regular), Brushes.Black, new PointF(530, yPosition));
                e.Graphics.DrawString(manufacturingDate, new Font("Times New Roman", 10, FontStyle.Regular), Brushes.Black, new PointF(630, yPosition));
                e.Graphics.DrawString(expiryDate, new Font("Times New Roman", 10, FontStyle.Regular), Brushes.Black, new PointF(760, yPosition));

                yPosition += 25; 
            }

           
            e.Graphics.DrawString(dashLine, new Font("Times New Roman", 10, FontStyle.Regular), Brushes.Black, new PointF(25, yPosition+80));
            yPosition += 25; 

           
            e.Graphics.DrawString("Total Price:৳ " + totalPriceAmount_label.Text, new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(445, yPosition+80));

            yPosition += 50;

            
            e.Graphics.DrawString("\"All sales are final. Medicines cannot be returned or exchanged\"", new Font("Times New Roman", 12, FontStyle.Bold), Brushes.Red, new PointF(210, yPosition+180));
        }

    }
}



