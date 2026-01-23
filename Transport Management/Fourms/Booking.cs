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

namespace Transport_Management
{
    public partial class Booking : Form
    {
        public Booking()
        {
            InitializeComponent();
            GetCustomers();
            GetVeHicles();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\Documents\TransportDB.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False");
        private void GetVeHicles()
        {
            try
            {
                using (SqlConnection c = new SqlConnection(con.ConnectionString))
                {
                    SqlDataAdapter da = new SqlDataAdapter(
                        "SELECT VLLp FROM VehiclesTB WHERE VLSt = 'Available'", c);

                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    VeBook.DataSource = null;
                    VeBook.Items.Clear();

                    VeBook.DisplayMember = "VLLp";
                    VeBook.ValueMember = "VLLp";
                    VeBook.DataSource = dt;
                    VeBook.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void GetCustomers()
        {
            try
            {
                using (SqlConnection c = new SqlConnection(
                    @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\Documents\TransportDB.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False"))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter("SELECT CusID FROM CustomerTB", c))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        CusBook.DataSource = null;
                        CusBook.Items.Clear();

                        CusBook.DisplayMember = "CusID";
                        CusBook.ValueMember = "CusID";
                        CusBook.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }




        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void VeBook_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetVeHicles();
        }

        private void CusBook_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetCustomers();
        }
    }
}
