using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace pharmacyManagement_MedicineGhor
{
    public partial class splashScreen : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);
        public splashScreen()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 23, 23));
            circularProgressBar1.Value = 0;
            
        }
       
        
        private void circularProgressBar1_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            circularProgressBar1.Value += 1;
            circularProgressBar1.Text=circularProgressBar1.Value.ToString() + "%";

            if(circularProgressBar1.Value ==100)
            {
                timer1.Enabled = false;
                signIn signIn = new signIn();
                signIn.Show();
                this.Hide();
            }
        }
    }
}
