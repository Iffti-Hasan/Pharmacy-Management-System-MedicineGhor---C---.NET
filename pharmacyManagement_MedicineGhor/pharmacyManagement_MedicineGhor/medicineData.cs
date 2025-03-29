using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace pharmacyManagement_MedicineGhor
{
    
    internal class medicineData
    {
        string connectionString = @"Data Source=DESKTOP-EESOC6N\SQLEXPRESS;Initial Catalog=pharmacyManagement;Integrated Security=True;Encrypt=False";
        public int ID { set; get; }
        public string Name { set; get; }
        public string Category { set; get; }
        public long PerUnit { set; get; }
        public long Quantity { set; get; }
        public string Status { set; get; }
        public string ManufacturingDate { set; get; }
        public string ExpiryDate { set; get; }
       
        public List<medicineData> GetMedicineData()
        {
            List<medicineData> medicineList = new List<medicineData>();

            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                connect.Open();
                string selectData = "SELECT * FROM medicine";
                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        medicineData medicine = new medicineData();

                        medicine.ID = (int)reader["id"];
                        medicine.Name = reader["mname"].ToString();
                        medicine.Category = reader["mcategory"].ToString();
                        medicine.PerUnit = (long)reader["perUnit"];
                        medicine.Quantity = (long)reader["quantity"];
                        medicine.Status = reader["status"].ToString();
                        medicine.ManufacturingDate = ((DateTime)reader["manufacturingDate"]).ToString("MM-dd-yyyy");
                        medicine.ExpiryDate = ((DateTime)reader["expiryDate"]).ToString("MM-dd-yyyy");

                        medicineList.Add(medicine);
                    }
                }
            }
            return medicineList;
        }

        
    }
}

