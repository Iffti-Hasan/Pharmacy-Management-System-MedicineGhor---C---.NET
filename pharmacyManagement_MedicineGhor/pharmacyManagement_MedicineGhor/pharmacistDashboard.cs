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
using System.Windows.Forms.DataVisualization.Charting;

namespace pharmacyManagement_MedicineGhor
{
    public partial class pharmacistDashboard : UserControl
    {
        string connectionString = @"Data Source=DESKTOP-EESOC6N\SQLEXPRESS;Initial Catalog=pharmacyManagement;Integrated Security=True;Encrypt=False";
        private DataTable users;
        public pharmacistDashboard()
        {
            InitializeComponent();
            displaytodays_revenue();
            displaytotal_seller();
            displayavailable_medicine();
            LoadMedicineStatusChart();
            displayoutOfStock();




        }

       

        public static implicit operator Form(pharmacistDashboard v)
        {
            throw new NotImplementedException();
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

        public void displaytotal_seller()
        {
            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                connect.Open();

                string selectData = "SELECT COUNT(id) as total_seller FROM users WHERE userRole ='Seller' ";
                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    {
                        if (reader.Read())
                        {
                            if (reader["total_seller"] != DBNull.Value)
                            {
                                int totalseller = (int)reader["total_seller"];
                                total_seller.Text = totalseller.ToString();
                            }
                        }
                    }
                }
            }
        }

        public void LoadMedicineStatusChart()
        {
            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                connect.Open();


                string query = @"
            SELECT 
                SUM(CASE WHEN status = 'Active' AND expiryDate > GETDATE() THEN 1 ELSE 0 END) AS ActiveCount,
                SUM(CASE WHEN status = 'Inactive' THEN 1 ELSE 0 END) AS InactiveCount,
                SUM(CASE WHEN expiryDate <= GETDATE() THEN 1 ELSE 0 END) AS ExpiredCount
            FROM medicine";

                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int activeCount = reader["ActiveCount"] != DBNull.Value ? Convert.ToInt32(reader["ActiveCount"]) : 0;
                            int inactiveCount = reader["InactiveCount"] != DBNull.Value ? Convert.ToInt32(reader["InactiveCount"]) : 0;
                            int expiredCount = reader["ExpiredCount"] != DBNull.Value ? Convert.ToInt32(reader["ExpiredCount"]) : 0;


                            load_chart.Series.Clear();


                            Series series = new Series("MedicineStatus");
                            series.ChartType = SeriesChartType.Pie;


                            series.Points.AddXY($"Active ({activeCount})", activeCount);
                            series.Points.AddXY($"Inactive ({inactiveCount})", inactiveCount);
                            series.Points.AddXY($"Expired ({expiredCount})", expiredCount);

                            series.Font = new Font("Times New Roman", 7f);


                            load_chart.Series.Add(series);

                            series.Points[0].Color = Color.Coral;
                            series.Points[1].Color = Color.PaleGreen;
                            series.Points[2].Color = Color.LightSkyBlue;
                        }
                    }
                }
            }




        }

        public void displayoutOfStock()
        {
            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                connect.Open();

                string selectData = "SELECT COUNT(id) as out_of_stock FROM medicine WHERE quantity = 0";
                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        int outOfStockCount = reader["out_of_stock"] != DBNull.Value ? (int)reader["out_of_stock"] : 0;
                        out_of_stock.Text = outOfStockCount.ToString();
                    }
                }
            }
        }
    }
}
