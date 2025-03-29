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
    public partial class signIn : Form
    {
        private Point offset;

        string connectionString = @"Data Source=DESKTOP-EESOC6N\SQLEXPRESS;Initial Catalog=pharmacyManagement;Integrated Security=True;Encrypt=False";
        public signIn()
        {
            InitializeComponent();
            panel_bar.MouseDown += PanelMove_MouseDown;
            panel_bar.MouseMove += PanelMove_MouseMove;
            panel_bar.MouseUp += PanelMove_MouseUp;
        }

        private void PanelMove_MouseDown(object sender, MouseEventArgs e)
        {
            offset = e.Location;
        }

        private void PanelMove_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point newLocation = this.Location;
                newLocation.X += e.X - offset.X;
                newLocation.Y += e.Y - offset.Y;
                this.Location = newLocation;
            }
        }

        private void PanelMove_MouseUp(object sender, MouseEventArgs e)
        {
            offset = Point.Empty;
        }

        private void signinSignin_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Please enter email and password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string selectData = "SELECT * FROM users WHERE email = @email AND pass = @pass AND status = 'Active'";
                    using (SqlCommand cmd = new SqlCommand(selectData, connection))
                    {
                        cmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim());
                        cmd.Parameters.AddWithValue("@pass", txtPassword.Text.Trim());

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count > 0)
                            {
                                DataRow row = table.Rows[0];
                                string userRole = row["userRole"].ToString();

                                
                                switch (userRole.ToLower())
                                {
                                    case "admin":
                                        formAdmin adminForm = new formAdmin();
                                        adminForm.Show();
                                        break;
                                    case "pharmacist":
                                        pharmacistMainform pharmacistForm = new pharmacistMainform();
                                        pharmacistForm.Show();
                                        break;
                                    case "seller":
                                        sellerMainform sellerForm = new sellerMainform();
                                        sellerForm.Show();
                                        break;
                                    default:
                                        MessageBox.Show("Invalid user role: " + userRole, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        break;
                                }

                                Hide();
                            }
                            else
                            {
                                MessageBox.Show("Incorrect email/password or user is not active", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void signinReset_btn_Click(object sender, EventArgs e)
        {
            txtEmail.Clear();
            txtPassword.Clear();
        }

        private void showPass_check_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = showPass_check.Checked ? '\0' : '*';
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void crss_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void minn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

      
    }
}
