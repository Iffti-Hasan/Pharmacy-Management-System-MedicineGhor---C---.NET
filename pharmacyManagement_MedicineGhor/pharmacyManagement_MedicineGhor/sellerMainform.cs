using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pharmacyManagement_MedicineGhor
{
    public partial class sellerMainform : Form
    {
        private Point offset;
        public sellerMainform()
        {
            InitializeComponent();
            pnTopbar.MouseDown += PanelMove_MouseDown;
            pnTopbar.MouseMove += PanelMove_MouseMove;
            pnTopbar.MouseUp += PanelMove_MouseUp;
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
        private void minB_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void crossB_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void dashBoard_btn_Click(object sender, EventArgs e)
        {
            sellerDashboard dashboardForm = new sellerDashboard();

            
            pnlbehind.Controls.Clear(); 
            pnlbehind.Controls.Add(dashboardForm); 

            
            dashboardForm.Visible = true;
        }

        private void adduser_btn_Click(object sender, EventArgs e)
        {
            sellMedicine sellMedicineForm = new sellMedicine();

            
            pnlbehind.Controls.Clear(); 
            pnlbehind.Controls.Add(sellMedicineForm); 

            
            sellMedicineForm.Visible = true;
        }

        private void return_med_Click(object sender, EventArgs e)
        {

        }

        private void customerDetails_btn_Click(object sender, EventArgs e)
        {
            customerDetails customerDetailsForm = new customerDetails();

            
            pnlbehind.Controls.Clear(); 
            pnlbehind.Controls.Add(customerDetailsForm); 

            customerDetailsForm.Visible = true;
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
    }
}
