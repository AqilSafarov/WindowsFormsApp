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
    public partial class Types : Form
    {
        string path = @"Data Source=LAPTOP-CGJ9IEH7;Initial Catalog=HotelDbase;Integrated Security=True";
        SqlConnection con;
        SqlCommand cmd;
        public Types()
        {
            InitializeComponent();
            Populate();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Populate()
        {
            con = new SqlConnection(path);

            DataTable dt = new DataTable();
            SqlDataAdapter adpt = new SqlDataAdapter("SELECT * FROM Type", con);
            adpt.Fill(dt);
            TypeDGV.DataSource = dt;


        }

        private void InsertCategories()
        {

            if (TypeNameTb.Text == "" || CostTb.Text =="")
            {
                MessageBox.Show("Enter Infromation!");
            }
            else
            {

                try
                {

                    string sqlQuery = "INSERT INTO Type(TypeName,TypeCost) VALUES(@typeName,@typeCost)";

                    SqlParameter[] parameters =
                    {
                        new SqlParameter("@typeName",SqlDbType.VarChar,50){ Value=TypeNameTb.Text},
                        new SqlParameter("@typeCost",SqlDbType.Float){ Value=CostTb.Text},
                    };
                    CRUDsql.MethExecCommand(path, sqlQuery, parameters);
                    MessageBox.Show("Category Insreted");
                    Populate();

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }


        }
        private void EditCeategory()
        {

            if (TypeNameTb.Text == "" || CostTb.Text == "")
            {
                MessageBox.Show("Enter Infromation!");
            }
            else
            {

                try
                {

                    string sqlQuery = "UPDATE Type SET TypeName=@typeName,TypeCost=@typeCost WHERE TypeNum=@Tkey";
                    SqlParameter[] parameters =
                   {
                        new SqlParameter("@typeName",SqlDbType.VarChar,50){ Value=TypeNameTb.Text},
                        new SqlParameter("@typeCost",SqlDbType.Float){ Value=CostTb.Text},
                        new SqlParameter("@Tkey",SqlDbType.Int){ Value=key},
                    };
                    CRUDsql.MethExecCommand(path, sqlQuery, parameters);

                    MessageBox.Show("Category Updated");
                    Populate();

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            InsertCategories();
        }
        int key = 0;
        private void TpesDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

           
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Rooms rooms = new Rooms();
            rooms.Show();
            this.Hide();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            EditCeategory();
        }

        private void DeleteCategory()
        {
            if (key == 0)
            {
                MessageBox.Show("You must select category!");
            }
            else
            {

                try
                {

                    con = new SqlConnection(path);
                    con.Open();
                    cmd = new SqlCommand("DELETE FROM Type WHERE TypeNum=@Tkey", con);
                    cmd.Parameters.Add("@Tkey", key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category Deleted");
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
            TypeNameTb.Text = "";
            CostTb.Text = "";
           
        }
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            DeleteCategory();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            //Login login = new Login();
            //login.Show();
            //this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Users user = new Users();
            user.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Customers customer= new Customers();
            customer.Show();
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

        private void TypeDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TypeNameTb.Text = TypeDGV.SelectedRows[0].Cells[1].Value.ToString();
            CostTb.Text = TypeDGV.SelectedRows[0].Cells[2].Value.ToString();
            if (TypeNameTb.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(TypeDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }
    }
}
