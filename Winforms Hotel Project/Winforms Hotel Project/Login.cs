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

namespace Winforms_Hotel_Project
{
    public partial class Login : Form
    {
        string path = @"Data Source=LAPTOP-CGJ9IEH7;Initial Catalog=HotelDbase;Integrated Security=True";
        SqlConnection con;
        SqlCommand cmd;
        public Login()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            if (UserNameTxt.Text=="" || UserPasswordTxt.Text=="")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    con = new SqlConnection(path);
                    con.Open();
                    SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT (*) FROM UserTb WHERE UName='"+UserNameTxt.Text+"' and UPassword='"+ UserPasswordTxt.Text+"'",con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows[0][0].ToString()=="1")
                    {
                        Rooms rooms = new Rooms();
                        rooms.Show();
                        this.Hide();
                        con.Close();
                    }
                    else
                    {
                        MessageBox.Show("Wrong user name and password");
                    }
                    con.Close();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void CloseLog_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LContinue_Click(object sender, EventArgs e)
        {
            AdminLogin adminlogin = new AdminLogin();
            adminlogin.Show();
            this.Hide();
        }

        private void UserNameTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
