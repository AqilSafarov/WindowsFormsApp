using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winforms_Hotel_Project
{
    public partial class Reload : Form
    {
        public Reload()
        {
            InitializeComponent();
        }

        int StartPoint;
        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }
        private void Reload_Load(object sender, EventArgs e)
        {
            timer1.Start();

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            StartPoint += 2;
            MyProgress.Value = StartPoint;
            if (MyProgress.Value == 100)
            {
                MyProgress.Value = 0;
                timer1.Stop();
                this.Hide();
                Login login = new Login();
                login.Show();
            }
        }
    }
}
