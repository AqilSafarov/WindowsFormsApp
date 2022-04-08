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
    public partial class Users : Form
    {
        string path = @"Data Source=LAPTOP-CGJ9IEH7;Initial Catalog=HotelDbase;Integrated Security=True";
        SqlConnection con;
        SqlCommand cmd;
        public Users()
        {
            InitializeComponent();
            Populate();
        }

        private void Populate()
        {
            con = new SqlConnection(path);

            DataTable dt = new DataTable();
            SqlDataAdapter adpt = new SqlDataAdapter("SELECT * FROM UserTb", con);
            adpt.Fill(dt);
            UsersDGV.DataSource = dt;


        }
        int key = 0;

        private void EditUser()
        {

            if (UName.Text == "" || UGenderCb.SelectedIndex == -1 || UPassword.Text ==""  || UPhone.Text=="")
            {
                MessageBox.Show("Enter Infromation!");
            }
            else
            {

                try
                {

                    string sqlQuery = "UPDATE UserTb SET UName=@uName,UPhone=@uPhone,UGender=@uGender,UPassword=@uPassword WHERE UNum=@Rkey";
                    SqlParameter[] parameters =
                   {
                        new SqlParameter("@uName",SqlDbType.VarChar,50){ Value=UName.Text},
                        new SqlParameter("@uPhone",SqlDbType.VarChar,50){ Value=UPhone.Text},
                        new SqlParameter("@uGender",SqlDbType.VarChar,10){ Value=UGenderCb.SelectedItem.ToString()},
                        new SqlParameter("@uPassword",SqlDbType.VarChar,50){ Value=UPassword.Text},
                        new SqlParameter("@Rkey",SqlDbType.Int){ Value=key},

                    };
                    CRUDsql.MethExecCommand(path, sqlQuery, parameters);
                    MessageBox.Show("User Updated");
                    Populate();
                    Clear();


                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }


        }

        private void SavetUser()
        {
            if (UName.Text == "" || UGenderCb.SelectedIndex == -1 || UPassword.Text == "" || UPhone.Text == "")
            {
                MessageBox.Show("Enter Infromation!");
            }
            else
            {

                try
                {

                    string sqlQuery = "INSERT INTO UserTb(UName,UPhone,UGender,UPassword) VALUES(@uName,@uPhone,@uGender,@uPassword)";
                    SqlParameter[] parameters =
                 {
                        new SqlParameter("@uName",SqlDbType.VarChar,50){ Value=UName.Text},
                        new SqlParameter("@uPhone",SqlDbType.VarChar,50){ Value=UPhone.Text},
                        new SqlParameter("@uGender",SqlDbType.VarChar,10){ Value=UGenderCb.SelectedItem.ToString()},
                        new SqlParameter("@uPassword",SqlDbType.VarChar,50){ Value=UPassword.Text},
                        new SqlParameter("@Rkey",SqlDbType.Int){ Value=key},

                    };
                    CRUDsql.MethExecCommand(path, sqlQuery, parameters);

                    MessageBox.Show("User Added");
                    con.Close();
                    Populate();
                    Clear();

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void DeleteUser()
        {
            if (key == 0)
            {
                MessageBox.Show("You must select user!");
            }
            else
            {

                try
                {

                    con = new SqlConnection(path);
                    con.Open();
                    cmd = new SqlCommand("DELETE FROM UserTb WHERE UNum=@Ukey", con);
                    cmd.Parameters.Add("@Ukey", key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User Deleted");
                    con.Close();
                    Populate();
                    Clear();


                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }

        }
        public void Clear()
        {
            UName.Text = "";
            UPhone.Text = "";
            UPassword.Text = "";
            UGenderCb.Text = "";

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
        private void UsersDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            UName.Text = UsersDGV.SelectedRows[0].Cells[1].Value.ToString();
            UPhone.Text = UsersDGV.SelectedRows[0].Cells[2].Value.ToString();
            UGenderCb.Text = UsersDGV.SelectedRows[0].Cells[3].Value.ToString();
            UPassword.Text = UsersDGV.SelectedRows[0].Cells[4].Value.ToString();
            if (UName.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(UsersDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            DeleteUser();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            SavetUser();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            EditUser();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void panel3_MouseClick(object sender, MouseEventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Customers customer = new Customers();
            customer.Show();
            this.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Types type = new Types();
            type.Show();
            this.Show();
        }
    }
}
