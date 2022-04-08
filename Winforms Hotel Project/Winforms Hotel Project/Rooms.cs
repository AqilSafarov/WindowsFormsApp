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
    public partial class Rooms : Form
    {
        string path = @"Data Source=LAPTOP-CGJ9IEH7;Initial Catalog=HotelDbase;Integrated Security=True";
        SqlConnection con;
        SqlCommand cmd;

        public Rooms()
        {
            InitializeComponent();
            Populate();
            GetCategory();
        }

        private void Populate()
        {
            con = new SqlConnection(path);
            DataTable dt = new DataTable();
            SqlDataAdapter adpt = new SqlDataAdapter("SELECT * FROM Room", con);
            adpt.Fill(dt);
            RoomDGV.DataSource = dt;


        }
        int key = 0;

        private void EditRooms()
        {
            if (RnameTb.Text == "" || RTypeCb.SelectedIndex == -1 || RStatusCb.SelectedIndex == -1)
            {
                MessageBox.Show("Enter Infromation!");
            }
            else
            {
                try
                {

                    string sqlQuery = "UPDATE Room SET RName=@rName,RType=@rType,RStatus=@rStatus WHERE RNum=@Rkey";
                    SqlParameter[] parameters =
                   {
                        new SqlParameter("@rName",SqlDbType.VarChar,50){ Value=RnameTb.Text},
                        new SqlParameter("@rType",SqlDbType.Int){ Value=RTypeCb.SelectedValue.ToString()},
                        new SqlParameter("@rStatus", SqlDbType.VarChar,50){ Value=RStatusCb.SelectedItem.ToString()},
                        new SqlParameter("@Rkey",SqlDbType.Int){ Value=key},
                    };
                    CRUDsql.MethExecCommand(path, sqlQuery, parameters);
                    MessageBox.Show("Room Added");
                    Populate();
                    Clear();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }


        }

        private void InsertRooms()
        {
            if (RnameTb.Text == "" || RTypeCb.SelectedIndex == -1 || RStatusCb.SelectedIndex == -1)
            {
                MessageBox.Show("Enter Infromation!");
            }
            else
            {
                try
                {

                    string sqlQuery = "INSERT INTO Room(RName,RType,RStatus) VALUES(@rName,@rType,@rStatus)";
                    SqlParameter[] parameters =
                 {
                        new SqlParameter("@rName",SqlDbType.VarChar,50){ Value=RnameTb.Text},
                        new SqlParameter("@rType",SqlDbType.Int){ Value=RTypeCb.SelectedValue.ToString()},
                        new SqlParameter("@rStatus", SqlDbType.VarChar,50){ Value="Available"},
                        //new SqlParameter("@rStatus", SqlDbType.VarChar,50){Value=RStatusCb.SelectedItem.ToString()},

                    };
                    CRUDsql.MethExecCommand(path, sqlQuery, parameters);
                    MessageBox.Show("Room Added");
                    Populate();
                    Clear();

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void DeleteRooms()
        {
            if (key==0)
            {
                MessageBox.Show("You must select room!");
            }
            else
            {

                try
                {

                    con = new SqlConnection(path);
                    con.Open();
                    cmd = new SqlCommand("DELETE FROM Room WHERE Rnum=@Rkey", con);
                    cmd.Parameters.Add("@Rkey",key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Room Deleted");
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
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            Bookings booking = new Bookings();
            booking.Show();
            this.Hide();
        }

        private void GetCategory()
        {

            con = new SqlConnection(path);
            con.Open();
            cmd = new SqlCommand("SELECT * FROM Type", con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("TypeNum", typeof(int));
            dt.Load(rdr);
            RTypeCb.ValueMember = "TypeNum";
            RTypeCb.DataSource = dt;
            con.Close();

            //con = new SqlConnection(path);
            //con.Open();
            //cmd = new SqlCommand("SELECT * FROM Type", con);
            //SqlDataReader rdr;
            //rdr = cmd.ExecuteReader();
            //DataTable dt = new DataTable();
            //dt.Columns.Add("TypeName", typeof(string));
            //dt.Load(rdr);
            //RTypeCb.ValueMember = "TypeName";
            //RTypeCb.DataSource = dt;
            //con.Close();

            //con = new SqlConnection(path);
            //con.Open();
            //cmd = new SqlCommand("SELECT * FROM Customer", con);
            //SqlDataReader rdr;
            //rdr = cmd.ExecuteReader();
            //DataTable dt = new DataTable();
            //dt.Columns.Add("CustNum", typeof(int));
            //dt.Load(rdr);
            //BCutomercb.ValueMember = "CustNum";
            //BCutomercb.DataSource = dt;
            //con.Close();

            //con = new SqlConnection(path);
            //DataTable dt = new DataTable();
            //SqlDataAdapter adpt = new SqlDataAdapter("SELECT * FROM Room", con);
            //adpt.Fill(dt);
            //RoomDGV.DataSource = dt;
        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            InsertRooms();
        }

        public void Clear()
        {
            RnameTb.Text = "";
            RStatusCb.Text = "";
            RTypeCb.Text = "";
        }
        private void RoomDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

          
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            EditRooms();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            DeleteRooms();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Types types = new Types();
            types.Show();
            this.Hide();
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
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }

        private void RTypeCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RoomDGV_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            RnameTb.Text = RoomDGV.SelectedRows[0].Cells[1].Value.ToString();
            RTypeCb.Text = RoomDGV.SelectedRows[0].Cells[2].Value.ToString();
            RStatusCb.Text = RoomDGV.SelectedRows[0].Cells[3].Value.ToString();
            if (RnameTb.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(RoomDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }
    }
}
