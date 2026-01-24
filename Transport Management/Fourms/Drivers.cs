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
        int DriverId = 0;
        public Drivers()
        {
            InitializeComponent();
            ShowDriver();
            Clear();
        }
        SqlConnection con = new SqlConnection(
    @"Data Source=(LocalDB)\MSSQLLocalDB;
      AttachDbFilename=C:\Users\hp\Documents\TransportDB.mdf;
      Integrated Security=True;");

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
                        "(DrEmail, DrPhone, DrName, DrAdress, DrGen, DrStatus, DrLic, DWage, Drjoin) " +
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

                    Clear();
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
            try
            {
                con.Open();
                if (string.IsNullOrWhiteSpace(Dname.Text) &&
                    string.IsNullOrWhiteSpace(DEmail.Text) &&
                    string.IsNullOrWhiteSpace(Dphone.Text) &&
                    string.IsNullOrWhiteSpace(DAddress.Text) &&
                    DGen.SelectedIndex == -1 &&
                    DStatus.SelectedIndex == -1 &&
                    string.IsNullOrWhiteSpace(DLic.Text))
                {
                    ShowDriver();
                    return;
                }

                StringBuilder query = new StringBuilder("SELECT * FROM DriverTb WHERE 1=1");
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                if (!string.IsNullOrWhiteSpace(Dname.Text))
                {
                    query.Append(" AND DrName LIKE @Name");
                    cmd.Parameters.AddWithValue("@Name", "%" + Dname.Text + "%");
                }

                if (!string.IsNullOrWhiteSpace(DEmail.Text))
                {
                    query.Append(" AND DrEmail LIKE @Email");
                    cmd.Parameters.AddWithValue("@Email", "%" + DEmail.Text + "%");
                }

                if (!string.IsNullOrWhiteSpace(Dphone.Text))
                {
                    query.Append(" AND DrPhone LIKE @Phone");
                    cmd.Parameters.AddWithValue("@Phone", "%" + Dphone.Text + "%");
                }

                if (!string.IsNullOrWhiteSpace(DAddress.Text))
                {
                    query.Append(" AND DrAdress LIKE @Address");
                    cmd.Parameters.AddWithValue("@Address", "%" + DAddress.Text + "%");
                }

                if (DGen.SelectedIndex != -1)
                {
                    query.Append(" AND DrGen = @Gen");
                    cmd.Parameters.AddWithValue("@Gen", DGen.SelectedItem.ToString());
                }

                if (DStatus.SelectedIndex != -1)
                {
                    query.Append(" AND DrStatus = @Status");
                    cmd.Parameters.AddWithValue("@Status", DStatus.SelectedItem.ToString());
                }

                if (!string.IsNullOrWhiteSpace(DLic.Text))
                {
                    query.Append(" AND DrLic LIKE @Lic");
                    cmd.Parameters.AddWithValue("@Lic", "%" + DLic.Text + "%");
                }

                cmd.CommandText = query.ToString();

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

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


       

        private void button3_Click(object sender, EventArgs e)
        {
            
            if (DriverId == 0 ||
                string.IsNullOrWhiteSpace(DEmail.Text) ||
                string.IsNullOrWhiteSpace(Dname.Text) ||
                string.IsNullOrWhiteSpace(Dphone.Text) ||
                DGen.SelectedIndex == -1 ||
                DStatus.SelectedIndex == -1 ||
                string.IsNullOrWhiteSpace(DLic.Text) ||
                string.IsNullOrWhiteSpace(DAddress.Text) ||
                string.IsNullOrWhiteSpace(DWage.Text))
            {
                MessageBox.Show("Missing Information");
                return;
            }

            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand(
                    "UPDATE DriverTb SET " +
                    "DrEmail=@DE, DrPhone=@DP, DrName=@DN, DrAddress=@DA, " +
                    "DrGen=@DG, DrStatus=@DS, DrLic=@DL, DWage=@DW, DrJoin=@DJ " +
                    "WHERE DrID=@DID", con);

                cmd.Parameters.AddWithValue("@DE", DEmail.Text);
                cmd.Parameters.AddWithValue("@DP", Dphone.Text);
                cmd.Parameters.AddWithValue("@DN", Dname.Text);
                cmd.Parameters.AddWithValue("@DA", DAddress.Text);
                cmd.Parameters.AddWithValue("@DG", DGen.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@DS", DStatus.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@DL", DLic.Text);
                cmd.Parameters.AddWithValue("@DW", Convert.ToDecimal(DWage.Text));
                cmd.Parameters.AddWithValue("@DJ", Ddate.Value.Date);
                cmd.Parameters.AddWithValue("@DID", DriverId);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Driver Updated Successfully");

                Clear();
                ShowDriver();
                DriverId = 0;
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
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = DGV.Rows[e.RowIndex];

                DriverId = Convert.ToInt32(row.Cells["DrID"].Value);

                DEmail.Text = row.Cells["DrEmail"].Value.ToString();
                Dphone.Text = row.Cells["DrPhone"].Value.ToString();
                Dname.Text = row.Cells["DrName"].Value.ToString();
                DAddress.Text = row.Cells["DrAdress"].Value.ToString();
                DGen.Text = row.Cells["DrGen"].Value.ToString();
                DStatus.Text = row.Cells["DrStatus"].Value.ToString();
                DLic.Text = row.Cells["DrLic"].Value.ToString();
                DWage.Text = row.Cells["DWage"].Value.ToString();
                Ddate.Value = Convert.ToDateTime(row.Cells["Drjoin"].Value);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
            if (DGV.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a driver from the list to delete.");
                return;
            }
            int selectedDriverId = Convert.ToInt32(DGV.SelectedRows[0].Cells["DrID"].Value);
            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this driver?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand(
                        "DELETE FROM DriverTb WHERE DrID=@DID", con);
                    cmd.Parameters.AddWithValue("@DID", selectedDriverId);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Driver deleted successfully.");
                    Clear();
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

    }
}
