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
    public partial class Customers : Form
    {
        string path = @"Data Source=LAPTOP-CGJ9IEH7;Initial Catalog=HotelDbase;Integrated Security=True";
        SqlConnection con;
        SqlCommand cmd;
        public Customers()
        {
            InitializeComponent();
            Populate();
        }

        private void Populate()
        {
            con = new SqlConnection(path);

            DataTable dt = new DataTable();
            SqlDataAdapter adpt = new SqlDataAdapter("SELECT * FROM Customer", con);
            adpt.Fill(dt);
            CustomersDGV.DataSource = dt;


        }

        private void EditCustomer()
        {

            if (CName.Text == "" || CPhone.Text == "" || CGendercb.SelectedIndex == -1)
            {
                MessageBox.Show("Enter Infromation!");
            }
            else
            {

                try
                {

                    string sqlQuery = "UPDATE Customer SET CustName=@custName,CustPhone=@custPhone,CustGender=@custGender WHERE CustNum=@Ckey";
                    SqlParameter[] parameters =
                  {
                        new SqlParameter("@custName",SqlDbType.VarChar,50){ Value=CName.Text},
                        new SqlParameter("@custPhone",SqlDbType.VarChar,50){ Value=CPhone.Text},
                        new SqlParameter("@custGender",SqlDbType.VarChar,540){ Value=CGendercb.SelectedItem.ToString()},
                        new SqlParameter("@Ckey",SqlDbType.Int){ Value=key},

                    };
                    CRUDsql.MethExecCommand(path, sqlQuery, parameters);

                    MessageBox.Show("Customer Updated");
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

        private void SavetCustomer()
        {

            if (CName.Text == "" || CPhone.Text == "" || CGendercb.SelectedIndex == -1)
            {
                MessageBox.Show("Enter Infromation!");
            }
            else
            {

                try
                {

                    string sqlQuery = "INSERT INTO Customer(CustName,CustPhone,CustGender) VALUES(@custName,@custPhone,@custGender)";
                    SqlParameter[] parameters =
                    {
                        new SqlParameter("@custName",SqlDbType.VarChar,50){ Value=CName.Text},
                        new SqlParameter("@custPhone",SqlDbType.VarChar,50){ Value=CPhone.Text},
                        new SqlParameter("@custGender",SqlDbType.VarChar,540){ Value=CGendercb.SelectedItem.ToString()},
                        new SqlParameter("@Ckey",SqlDbType.Int){ Value=key},

                    };
                    CRUDsql.MethExecCommand(path, sqlQuery, parameters);
                    MessageBox.Show("Customer Added");
                    Populate();
                    Clear();

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }

        }
        int key = 0;

        private void DeleteCustomer()
        {
            if (key == 0)
            {
                MessageBox.Show("You must select customer!");
            }
            else
            {

                try
                {

                    con = new SqlConnection(path);
                    con.Open();
                    cmd = new SqlCommand("DELETE FROM Customer WHERE CustNum=@Ckey", con);
                    cmd.Parameters.Add("@Ckey", key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer Deleted");
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
            CName.Text = "";
            CPhone.Text = "";
            CGendercb.Text = "";

        }
        
        private void EmpIds_TextChanged(object sender, EventArgs e)
        {

        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            SavetCustomer();
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            DeleteCustomer();
        }

        private void Editbtn_Click(object sender, EventArgs e)
        {
            EditCustomer();
        }

        private void CustomersDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void CustomersDGV_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            CName.Text = CustomersDGV.SelectedRows[0].Cells[1].Value.ToString();
            CPhone.Text = CustomersDGV.SelectedRows[0].Cells[2].Value.ToString();
            CGendercb.Text = CustomersDGV.SelectedRows[0].Cells[3].Value.ToString();
            if (CName.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(CustomersDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void CPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Rooms rooms = new Rooms();
            rooms.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Users user = new Users();
            user.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

            Types type = new Types();
            type.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Bookings booking = new Bookings();
            booking.Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }
    }
}
