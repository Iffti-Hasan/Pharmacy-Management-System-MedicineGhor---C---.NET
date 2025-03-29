using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Drawing.Printing;

namespace pharmacyManagement_MedicineGhor
{
        internal class CustomerManager
    {
        private string connectionString;

        public CustomerManager(string connectionString)
        {
            this.connectionString = connectionString;
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

        
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string MobileNo { get; set; }
    }
}

