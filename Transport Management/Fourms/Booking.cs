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
            GetDrivers();
            clear();
            showb();
        }
        private void clear()
        {
            CusBook.SelectedIndex = -1;
            VeBook.SelectedIndex = -1;
            VeDriver.SelectedIndex = -1;
            Pdate.Value = DateTime.Now;
            Rdate.Value = DateTime.Now;
        }
        private void showb()
        {
            con.Open();
            string Quray = "SELECT * FROM BookingTB";
            SqlDataAdapter sda = new SqlDataAdapter(Quray, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            BGV.DataSource = ds.Tables[0];

            con.Close();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\Documents\TransportDB.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False");
        private void GetVeHicles()
        {
            try
            {
                using (SqlConnection c = new SqlConnection(con.ConnectionString))
                {
                    SqlDataAdapter da = new SqlDataAdapter( "SELECT VLLp FROM VehiclesTB WHERE VLSt = 'Available'", c);

                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    VeBook.DataSource = null;
                    VeBook.Items.Clear();

                    VeBook.DisplayMember = "VLLp";
                    VeBook.ValueMember = "VLLp";
                    VeBook.DataSource = dt;
              
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
                using (SqlConnection c = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\Documents\TransportDB.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False"))
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
        private void GetDrivers()
        {
            try
            {
                using (SqlConnection c = new SqlConnection(con.ConnectionString))
                {
                    SqlDataAdapter da = new SqlDataAdapter(
                        "SELECT DrID FROM DriverTb WHERE DrStatus = 'Available'", c);

                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    VeDriver.DataSource = null;
                    VeDriver.Items.Clear();

                    VeDriver.DisplayMember = "DrID";
                    VeDriver.ValueMember = "DrID";
                    VeDriver.DataSource = dt;
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
           private void button2_Click(object sender, EventArgs e)
           {
            if (CusBook.SelectedIndex == -1 || VeBook.SelectedIndex == -1 || VeDriver.SelectedIndex == -1 || Pdate.Value == null || Rdate.Value == null)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    
                    int days = (Rdate.Value - Pdate.Value).Days;
                    if (days <= 0)
                    {
                        MessageBox.Show("Return date must be after pickup date.");
                        return;
                    }

                    con.Open();

                   
                    SqlCommand cmdCus = new SqlCommand("SELECT CusEmail FROM CustomerTB WHERE CusID=@ID", con);
                    cmdCus.Parameters.AddWithValue("@ID", CusBook.SelectedItem.ToString()); 
                    SqlDataReader drCus = cmdCus.ExecuteReader();
                    string cusEmail = "";
                    if (drCus.Read())
                    {
                       
                        cusEmail = drCus["CusEmail"].ToString();
                    }
                    drCus.Close();

             
                    SqlCommand cmdVe = new SqlCommand("SELECT VName,Charge FROM VehiclesTB WHERE VLp=@VLp", con);
                    cmdVe.Parameters.AddWithValue("@VLp", VeBook.SelectedItem.ToString()); 
                    SqlDataReader drVe = cmdVe.ExecuteReader();
                    string vName = "";
                    decimal vCharge = 0;
                    if (drVe.Read())
                    {
                        vName = drVe["VName"].ToString();
                        vCharge = Convert.ToDecimal(drVe["Amount"]);
                    }
                    drVe.Close();

                    
                    SqlCommand cmdDr = new SqlCommand("SELECT DrName,DWage FROM DriverTB WHERE DrID=@ID", con);
                    cmdDr.Parameters.AddWithValue("@ID", VeDriver.SelectedItem.ToString()); 
                    SqlDataReader drDr = cmdDr.ExecuteReader();
                    string drName = "";
                    decimal drWage = 0;
                    if (drDr.Read())
                    {
                        drName = drDr["DrName"].ToString();
                        drWage = Convert.ToDecimal(drDr["DWage"]);
                    }
                    drDr.Close();

                    decimal amount = (vCharge + drWage) * days;
                    decimal totalAmount = amount + (amount * 0.05m); 

                    
                    SqlCommand cmdBooking = new SqlCommand(
                        "INSERT INTO BookingTB(CusID,CusEmail,VLp,VName,Did,DrN,Amount,PDate,RDate) " +
                        "VALUES(@CI,@CE,@VL,@VN,@DI,@DN,@AM,@PD,@RD)", con);

                    cmdBooking.Parameters.AddWithValue("@CI", CusBook.SelectedItem.ToString());
                    cmdBooking.Parameters.AddWithValue("@CE", cusEmail);
                    cmdBooking.Parameters.AddWithValue("@VL", VeBook.SelectedItem.ToString());
                    cmdBooking.Parameters.AddWithValue("@VN", vName);
                    cmdBooking.Parameters.AddWithValue("@DI", VeDriver.SelectedItem.ToString());
                    cmdBooking.Parameters.AddWithValue("@DN", drName);
                    cmdBooking.Parameters.AddWithValue("@AM", totalAmount);
                    cmdBooking.Parameters.AddWithValue("@PD", Pdate.Value);
                    cmdBooking.Parameters.AddWithValue("@RD", Rdate.Value);

                    cmdBooking.ExecuteNonQuery();

                    MessageBox.Show("Booking Added Successfully! Total Amount: " + totalAmount.ToString("C"));

                    con.Close();

                    clear();    
                    Show();  
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    con.Close();
                }
            }
           }

        private void VeBook_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetVeHicles();
        }

        private void CusBook_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetCustomers();
        }

        private void VeDriver_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetDrivers();
        }
    }
}
