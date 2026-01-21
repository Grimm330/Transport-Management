using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Transport_Management
{
    public partial class Vehicles : Form
    {
        public Vehicles()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-8W4J1L5\SQLEXPRESS;Initial Catalog=Transport_Management_System;Integrated Security=True");
        private void button2_Click(object sender, EventArgs e)
        {
          if(VName.Text=="" || Vmile.Text=="" || VYear.Text=="" || VEtype.SelectedIndex== -1 || VLp.Text== "" || VStatus.SelectedIndex == -1 || Amount.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into VehiclesTB(VLName,VLMile,VLEype,VLYear,VLSt,VlLp,Amount) values(@VN,@VM,@VT,@VY,@VS,@VLp,@VA)", con);
                    cmd.Parameters.AddWithValue("@VN", VName.Text);
                    cmd.Parameters.AddWithValue("@VM", Vmile.Text);
                    cmd.Parameters.AddWithValue("@VT", VEtype.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@VY", VYear.Text);
                    cmd.Parameters.AddWithValue("@VS", VStatus.SelectedIndex.ToString());
                    cmd.Parameters.AddWithValue("@VLp", VLp.Text);
                    cmd.Parameters.AddWithValue("@VA", Amount.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Vehicle Added Successfully");
                    con.Close();
                    
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
    }
}
