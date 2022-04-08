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
    public partial class Bookings : Form
    {
        string path = @"Data Source=LAPTOP-CGJ9IEH7;Initial Catalog=HotelDbase;Integrated Security=True";
        SqlConnection con;
        SqlCommand cmd;
        public Bookings()
        {
            InitializeComponent();

            

            Populate();
            GetRoom();
            GetCutomer();

            BookingDGV.SelectionChanged += BookingDGV_SelectionChanged;
            BookingDGV.CellContentClick -= BookingDGV_CellContentClick_1;
        }

        private void BookingDGV_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (BookingDGV.SelectedRows.Count == 1)
                {
                    BRoomcb.Text = BookingDGV.SelectedRows[0].Cells[1].Value.ToString();
                    BCutomercb.Text = BookingDGV.SelectedRows[0].Cells[2].Value.ToString();
                    BDate.Text = BookingDGV.SelectedRows[0].Cells[3].Value.ToString();
                    BDuration.Text = BookingDGV.SelectedRows[0].Cells[4].Value.ToString();
                    BAmount.Text = BookingDGV.SelectedRows[0].Cells[5].Value.ToString();
                    if (BAmount.Text == "")
                    {
                        key = 0;
                    }
                    else
                    {
                        key = Convert.ToInt32(BookingDGV.SelectedRows[0].Cells[0].Value.ToString());
                    }
                }
                   // BRoomcb.Text = BookingDGV.SelectedRows[0].Cells["RoomColumn"].Value.ToString();
            }
            catch (Exception ex)
            {
                string err = ex.Message;
            }
            
        }

        private void Populate()
        {
            //con = new SqlConnection(path);
            //DataTable dt = new DataTable();
            //SqlDataAdapter adpt = new SqlDataAdapter("SELECT * FROM Booking", con);
            //adpt.Fill(dt);
            //BookingDGV.DataSource = dt;

            con = new SqlConnection(path);
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Booking", con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            BookingDGV.DataSource = ds.Tables[0];
            con.Close();



        }
        private void GetRoom()
        {

            con = new SqlConnection(path);
            con.Open();
            cmd = new SqlCommand("SELECT * FROM Room WHERE RStatus='Available'", con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("RNum", typeof(int));
            dt.Load(rdr);
            BRoomcb.ValueMember = "RNum";
            BRoomcb.DataSource = dt;
            con.Close();



        }
        private void GetCutomer()
        {
            con = new SqlConnection(path);
            con.Open();
            cmd = new SqlCommand("SELECT * FROM Customer", con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("CustNum", typeof(int));
            dt.Load(rdr);
            BCutomercb.ValueMember = "CustNum";
            BCutomercb.DataSource = dt;
            con.Close();
        }
        int price = 1;
        private void ftCost()
        {
            con = new SqlConnection(path);
            cmd = new SqlCommand("SELECT TypeCost FROM Room JOIN Type ON RType=TypeNum WHERE RNum=" + BRoomcb.SelectedValue.ToString() + "", con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                price = Convert.ToInt32(dr["TypeCost"].ToString());
            }

        }
     
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {

            if (BRoomcb.SelectedIndex == -1 || BCutomercb.SelectedIndex == -1 || BDuration.Text=="" ||  BAmount.Text == "")
            {
                MessageBox.Show("Enter Infromation!");
            }
            else
            {

                try
                {

                    con = new SqlConnection(path);
                    con.Open();
                    cmd = new SqlCommand("INSERT INTO Booking(RoomColumn,CustomerColumn,BookDate,Duration,Cost) VALUES(@rColumn,@cColumn,@bDate,@duration,@cost)", con);
                    cmd.Parameters.AddWithValue("@rColumn", BRoomcb.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@cColumn", BCutomercb.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@bDate", BDate.Value.Date);
                    cmd.Parameters.AddWithValue("@duration", BDuration.Text);
                    cmd.Parameters.AddWithValue("@cost", BAmount.Text);


                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Room Booked");
                    con.Close();
                    Populate();
                    setBooked();
                    GetRoom();
                    //Clear();
                   


                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void BRoomcb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ftCost();
        }

        private void BAmount_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void BDuration_TextChanged(object sender, EventArgs e)
        {
            if (BDuration.Text== "")
            {
                BAmount.Text = "0";
            }
            else
            {
                try
                {
                    int total = price * Convert.ToInt32(BDuration.Text);
                    BAmount.Text =total.ToString();
                }
                catch (Exception ex)
                {

                    //MessageBox.Show(ex.Message);
                }
               
            }
            
        }
        public void Clear()
        {
            BRoomcb.Text = "";
            BCutomercb.Text = "";
            BDuration.Text = "";
            BAmount.Text = "";

        }
        int key = 0;
        

        private void Cancelbtn_Click(object sender, EventArgs e)
        {
            CancelBooking();
            setAvailable();
            GetRoom();
        }

        private void CancelBooking()
        {
           

            if (key == 0)
            {
                MessageBox.Show("You must select booking!");
            }
            else
            {

                try
                {

                    con = new SqlConnection(path);
                    con.Open();
                    cmd = new SqlCommand("DELETE FROM Booking WHERE BookNum=@Bkey", con);
                    cmd.Parameters.AddWithValue("@Bkey", key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Booking Cancelled");
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
        private void setBooked()
        {
           
            try
            {

                con = new SqlConnection(path);
                con.Open();
                cmd = new SqlCommand("UPDATE Room SET RStatus=@rStatus WHERE RNum=@Rkey", con);
                cmd.Parameters.AddWithValue("@rStatus","Booked");
                cmd.Parameters.AddWithValue("@Rkey", BRoomcb.SelectedValue.ToString());

                cmd.ExecuteNonQuery();
                MessageBox.Show("Room Added");
                con.Close();
                Populate();
                Clear();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void setAvailable()
        {
            try
            {

                con = new SqlConnection(path);
                con.Open();
                cmd = new SqlCommand("UPDATE Room SET RStatus=@rStatus WHERE RNum=@Rkey", con);
                cmd.Parameters.AddWithValue("@rStatus", "Available");
                cmd.Parameters.AddWithValue("@Rkey", BRoomcb.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Room Added");
                con.Close();
                Populate();
                Clear();


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        
      
        private void panel3_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Rooms room = new Rooms();
            room.Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {

            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
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

        private void BookingDGV_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            BRoomcb.Text = BookingDGV.SelectedRows[0].Cells[1].Value.ToString();
            BCutomercb.Text = BookingDGV.SelectedRows[0].Cells[2].Value.ToString();
            BDate.Text = BookingDGV.SelectedRows[0].Cells[3].Value.ToString();
            BDuration.Text = BookingDGV.SelectedRows[0].Cells[4].Value.ToString();
            BAmount.Text = BookingDGV.SelectedRows[0].Cells[5].Value.ToString();
            if (BAmount.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(BookingDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Customers customers = new Customers();
            customers.Show();
            this.Hide();
        }
    }
}
