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
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\Documents\TransportDB.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False");
        private void GetVeHicles()
        {
           
            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand( "SELECT VLName FROM VehiclesTB WHERE VLSt = 'Available'", con);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                VeBook.DataSource = dt;
                VeBook.DisplayMember = "VLName";
                VeBook.ValueMember = "VLName";
                VeBook.SelectedIndex = -1; // optional: no default selection
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }


        
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void VeBook_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetVeHicles();
        }
    }
}
