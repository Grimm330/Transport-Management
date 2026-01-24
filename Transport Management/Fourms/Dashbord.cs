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
    public partial class Dashbord : Form
    {
        public Dashbord()
        {
            InitializeComponent();
            
        }
        private void LoadGrid(string tableName)
        {
            try
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter($"SELECT * FROM {tableName}", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DGV.DataSource = dt; 
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

        SqlConnection con = new SqlConnection(
    @"Data Source=(LocalDB)\MSSQLLocalDB;
      AttachDbFilename=C:\Users\hp\Documents\TransportDB.mdf;
      Integrated Security=True;");
        private void label12_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open(); 
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM CustomerTB", con); 
                int customerCount = (int)cmd.ExecuteScalar(); 
                label12.Text = customerCount.ToString(); 
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

        private void label13_Click(object sender, EventArgs e)
        {

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM VehiclesTB", con);
                int customerCount = (int)cmd.ExecuteScalar();
                label13.Text = customerCount.ToString();
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

        private void panel9_Paint(object sender, PaintEventArgs e)
        {
            LoadGrid("DriverTb");
        }

        private void label14_Click(object sender, EventArgs e)
        {

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM DriverTb", con);
                int customerCount = (int)cmd.ExecuteScalar();
                label14.Text = customerCount.ToString();
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

        private void label15_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open(); 
                SqlCommand cmd = new SqlCommand("SELECT SUM(Amount) FROM BookingTB", con); 
                object result = cmd.ExecuteScalar(); 

                if (result != DBNull.Value) 
                {
                    decimal totalAmount = Convert.ToDecimal(result);
                    label15.Text = totalAmount.ToString("C"); 
                }
                else
                {
                    label15.Text = "0";
                }
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

        private void DGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            LoadGrid("CustomerTB");
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {
            LoadGrid("VehiclesTB");
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            LoadGrid("BookingTB");
        }
    }
}
