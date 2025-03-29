using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace pharmacyManagement_MedicineGhor
{
    internal class adminAddUserData
    {
        string connectionString = @"Data Source=DESKTOP-EESOC6N\SQLEXPRESS;Initial Catalog=pharmacyManagement;Integrated Security=True;Encrypt=False";
        public int ID { set; get; }
        
        public string Role { set; get; }

        public string Status { set; get; }

        public string UserName { set; get; }

        public string Password { set; get; }

        public string Email { set; get; }

        public string Date {  set; get; }





        public List<adminAddUserData> listAddUserData()
        {
            List<adminAddUserData> listData = new List<adminAddUserData>();

            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                connect.Open();
                string selectData = "SELECT * FROM users";
                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        adminAddUserData aauData = new adminAddUserData();

                        aauData.ID = (int)reader["id"];
                        aauData.Role = reader["userRole"].ToString();
                        aauData.Status = reader["status"].ToString();
                        aauData.UserName = reader["userName"].ToString();
                        aauData.Password = reader["pass"].ToString();
                        aauData.Email = reader["email"].ToString();
                        aauData.Date = ((DateTime)reader["date_register"]).ToString("MM-dd-yyyy");
                       
                            
                        
                        

                        listData.Add(aauData);


                    }
                }
            }
            return listData;
        }
      




    }
}
