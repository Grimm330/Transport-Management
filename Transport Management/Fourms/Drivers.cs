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
    public partial class Drivers : Form
    {
        public Drivers()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\Documents\TransportDB.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False");
        private void ShowDriver()
        {
            try
            {
                con.Open();

                string query = "SELECT * FROM DriverTb";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);

                DataSet ds = new DataSet();
                sda.Fill(ds);

                DGV.DataSource = ds.Tables[0];
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

        private void Clear()
        {
            DEmail.Text = "";
            Dname.Text = "";
            Dphone.Text = "";
            DAddress.Text = "";
            DLic.Text = "";
            DWage.Text = "";

            DGen.SelectedIndex = -1;
            DStatus.SelectedIndex = -1;

            Ddate.Value = DateTime.Today;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(DEmail.Text) || string.IsNullOrWhiteSpace(Dname.Text) || string.IsNullOrWhiteSpace(Dphone.Text) || DGen.SelectedIndex == -1 || DStatus.SelectedIndex == -1 || string.IsNullOrWhiteSpace(DLic.Text) || string.IsNullOrWhiteSpace(DAddress.Text) ||string.IsNullOrWhiteSpace(DWage.Text))
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand(
                        "INSERT INTO DriverTb " +
                        "(DrEmail, DrPhone, DrName, DrAddress, DrGender, DrStatus, DrLic, DrWage, DrJoin) " +
                        "VALUES (@DE, @DP, @DN, @DA, @DG, @DS, @DL, @DW, @DJ)", con);

                    cmd.Parameters.AddWithValue("@DE", DEmail.Text);
                    cmd.Parameters.AddWithValue("@DP", Dphone.Text);
                    cmd.Parameters.AddWithValue("@DN", Dname.Text);
                    cmd.Parameters.AddWithValue("@DA", DAddress.Text);
                    cmd.Parameters.AddWithValue("@DG", DGen.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@DS", DStatus.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@DL", DLic.Text);
                    cmd.Parameters.AddWithValue("@DW", Convert.ToDecimal(DWage.Text));
                    cmd.Parameters.AddWithValue("@DJ", Ddate.Value.Date);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Driver Added Successfully");

                    clear();
                    ShowDriver();
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

        }


        private void Drivers_Load(object sender, EventArgs e)
        {

        }
    }
}
