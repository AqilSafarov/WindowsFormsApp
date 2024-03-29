﻿using System;
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
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void LContinue_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void CloseLog_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            if (UserPasswordTxt.Text=="")
            {
                MessageBox.Show("Enter Admin Password");
            }
            else
            {
                if (UserPasswordTxt.Text=="admin")
                {
                    Users users = new Users();
                    users.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong Password!!!");
                }

            }
        }
    }
}
