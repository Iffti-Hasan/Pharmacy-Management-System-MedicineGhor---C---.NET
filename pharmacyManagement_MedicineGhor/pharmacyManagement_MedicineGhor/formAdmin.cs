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

namespace pharmacyManagement_MedicineGhor
{
    
    public partial class formAdmin : Form
    { 
        private Point offset;
        public formAdmin()
        {
            InitializeComponent();
            panel_move.MouseDown += PanelMove_MouseDown;
            panel_move.MouseMove += PanelMove_MouseMove;
            panel_move.MouseUp += PanelMove_MouseUp;
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



        private void projName_Click(object sender, EventArgs e)
        {

        }

        

        

        

        private void FormAdmin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to Log Out?", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                signIn signInForm = new signIn();
                signInForm.Show();
                this.Close();
            }
        }

       

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            adminDashboard dashboardForm = new adminDashboard();
             

            pnlbehind.Controls.Clear(); 
            pnlbehind.Controls.Add(dashboardForm); 

            // Set the form's visibility to true
            dashboardForm.Visible = true;
           
            
        }

        private void btnAdduser_Click(object sender, EventArgs e)
        {
            addUser addUserForm = new addUser();
            


            pnlbehind.Controls.Clear(); 
            pnlbehind.Controls.Add(addUserForm); 

            
            addUserForm.Visible = true;
        }


        private void pnlsidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void adminDashboard1_Load(object sender, EventArgs e)
        {

        }

        private void Button_1_Click(object sender, EventArgs e)
        {

        }

        private void pnlbehind_Paint(object sender, PaintEventArgs e)
        {

        }

        private void allOrderBtn_Click(object sender, EventArgs e)
        {
            allOrders allOrdersForm = new allOrders();

            
            pnlbehind.Controls.Clear(); 
            pnlbehind.Controls.Add(allOrdersForm); 

            
            allOrdersForm.Visible = true;
        }

        private void panel_move_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mini_btn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void cross_btn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void cusD_btn_Click(object sender, EventArgs e)
        {
            customerDetails customerDetailsForm = new customerDetails();

            
            pnlbehind.Controls.Clear();
            pnlbehind.Controls.Add(customerDetailsForm);

            // Set the form's visibility to true
            customerDetailsForm.Visible = true;
        }

        private void adminDashboard1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
