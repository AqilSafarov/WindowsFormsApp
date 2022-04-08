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
    public partial class Dashboard : Form
    {
        string path = @"Data Source=LAPTOP-CGJ9IEH7;Initial Catalog=HotelDbase;Integrated Security=True";
        SqlConnection con;
        SqlCommand cmd;
        public Dashboard()
        {
            InitializeComponent();
            RoomCount();
            CountCustomers();
            BookingSum();
            DailySum();
            GetCutomer();
        }
        private void RoomCount()
        {
            con = new SqlConnection(path);
            DataTable dt = new DataTable();
            SqlDataAdapter adpt = new SqlDataAdapter("SELECT COUNT(*) FROM Room", con);
            adpt.Fill(dt);
            Roomlbl.Text = dt.Rows[0][0].ToString()+" Rooms";
        }
        private void CountCustomers()
        {
            con = new SqlConnection(path);
            DataTable dt = new DataTable();
            SqlDataAdapter adpt = new SqlDataAdapter("SELECT COUNT(*) FROM Customer", con);
            adpt.Fill(dt);
            Customerlbl.Text = dt.Rows[0][0].ToString() + " Customers";
        }
        private void BookingSum()
        {
            con = new SqlConnection(path);
            DataTable dt = new DataTable();
            SqlDataAdapter adpt = new SqlDataAdapter("SELECT SUM(Cost) FROM Booking", con);
            adpt.Fill(dt);
            Bookinglbl.Text = dt.Rows[0][0].ToString() + " $";
        }
        private void DailySum()
        {
            con = new SqlConnection(path);
            DataTable dt = new DataTable();
            SqlDataAdapter adpt = new SqlDataAdapter("SELECT SUM(Cost) FROM Booking WHERE BookDate='"+Bdate.Value.Date+"'", con);
            adpt.Fill(dt);
            DailyIncomelbl.Text = dt.Rows[0][0].ToString() + " $";
        }
        private void SumByCustomer()
        {
            try
            {
                con = new SqlConnection(path);
                DataTable dt = new DataTable();
                SqlDataAdapter adpt = new SqlDataAdapter("SELECT SUM(Cost) FROM Booking WHERE CustomerColumn=" + CustomerCb.SelectedValue.ToString() + "", con);
                adpt.Fill(dt);
                CustomerByIncome.Text = dt.Rows[0][0].ToString() + " $";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
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
            CustomerCb.ValueMember = "CustNum";
            CustomerCb.DataSource = dt;
            con.Close();

        }
        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Bdate_ValueChanged(object sender, EventArgs e)
        {
            DailySum();
        }

        private void CustomerCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            SumByCustomer();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Bookings booking = new Bookings();
            booking.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Types type = new Types();
            type.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Users user = new Users();
            user.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Customers customer = new Customers();
            customer.Show();
            this.Hide();
        }
    }
}
