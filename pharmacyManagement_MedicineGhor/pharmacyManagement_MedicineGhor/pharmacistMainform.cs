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
    public partial class pharmacistMainform : Form
    {

        private Point offset;
        public pharmacistMainform()
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


       

     

        private void pnTopbar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void crossbtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void minibtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

       

        private void vCheck_btn_Click(object sender, EventArgs e)
        {
            validityCheck validityCheckControl = new validityCheck();

            // Add the user control to the panel 
            pnlbehind.Controls.Clear(); 
            pnlbehind.Controls.Add(validityCheckControl); 

            //  user control's visibility to true
            validityCheckControl.Visible = true;
        }

        private void dash_btn_Click(object sender, EventArgs e)
        {
            pharmacistDashboard dashboardControl = new pharmacistDashboard();

            
            pnlbehind.Controls.Clear(); 
            pnlbehind.Controls.Add(dashboardControl); 

            
            dashboardControl.Visible = true;

        }

        private void addM_btn_Click(object sender, EventArgs e)
        {
            addMedicine addMedicineControl = new addMedicine();

            
            pnlbehind.Controls.Clear(); 
            pnlbehind.Controls.Add(addMedicineControl); 

            // Set the user control's visibility to true
            addMedicineControl.Visible = true;
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
