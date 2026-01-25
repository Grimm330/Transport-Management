using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace Transport_Management
{
    public partial class Drivers : Form
    {
        DataAccess db = new DataAccess();
        int DriverId = 0;

        public Drivers()
        {
            InitializeComponent();
            ShowDriver();
            Clear();
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
            DriverId = 0;
        }

        private void ShowDriver()
        {
            DGV.DataSource = db.GetData("SELECT * FROM DriverTb");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(DEmail.Text) || string.IsNullOrWhiteSpace(Dname.Text) || string.IsNullOrWhiteSpace(Dphone.Text) || string.IsNullOrWhiteSpace(DAddress.Text) || string.IsNullOrWhiteSpace(DLic.Text) || string.IsNullOrWhiteSpace(DWage.Text) || DGen.SelectedIndex == -1 || DStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
                return;
            }

            string query = "INSERT INTO DriverTb (DrEmail, DrPhone, DrName, DrAdress, DrGen, DrStatus, DrLic, DWage, DrJoin) VALUES (@DE, @DP, @DN, @DA, @DG, @DS, @DL, @DW, @DJ)";
            SqlParameter[] param = {
                new SqlParameter("@DE", DEmail.Text),
                new SqlParameter("@DP", Convert.ToInt64(Dphone.Text)),
                new SqlParameter("@DN", Dname.Text),
                new SqlParameter("@DA", DAddress.Text),
                new SqlParameter("@DG", DGen.SelectedItem.ToString()),
                new SqlParameter("@DS", DStatus.SelectedItem.ToString()),
                new SqlParameter("@DL", Convert.ToInt64(DLic.Text)),
                new SqlParameter("@DW", Convert.ToInt64(DWage.Text)),
                new SqlParameter("@DJ", Ddate.Value.Date)
            };
            db.Execute(query, param);
            MessageBox.Show("Driver Added Successfully");
            Clear();
            ShowDriver();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (DriverId == 0 || string.IsNullOrWhiteSpace(DEmail.Text) || string.IsNullOrWhiteSpace(Dname.Text) || string.IsNullOrWhiteSpace(Dphone.Text) || string.IsNullOrWhiteSpace(DAddress.Text) || string.IsNullOrWhiteSpace(DLic.Text) || string.IsNullOrWhiteSpace(DWage.Text) || DGen.SelectedIndex == -1 || DStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
                return;
            }

            string query = "UPDATE DriverTb SET DrEmail=@DE, DrPhone=@DP, DrName=@DN, DrAdress=@DA, DrGen=@DG, DrStatus=@DS, DrLic=@DL, DWage=@DW, DrJoin=@DJ WHERE DrID=@DID";
            SqlParameter[] param = {
                new SqlParameter("@DE", DEmail.Text),
                new SqlParameter("@DP", Dphone.Text),
                new SqlParameter("@DN", Dname.Text),
                new SqlParameter("@DA", DAddress.Text),
                new SqlParameter("@DG", DGen.SelectedItem.ToString()),
                new SqlParameter("@DS", DStatus.SelectedItem.ToString()),
                new SqlParameter("@DL", DLic.Text),
                new SqlParameter("@DW", Convert.ToDecimal(DWage.Text)),
                new SqlParameter("@DJ", Ddate.Value.Date),
                new SqlParameter("@DID", DriverId)
            };
            db.Execute(query, param);
            MessageBox.Show("Driver Updated Successfully");
            Clear();
            ShowDriver();
        }

        private void DGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
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
            Ddate.Value = Convert.ToDateTime(row.Cells["DrJoin"].Value);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (DriverId == 0)
            {
                MessageBox.Show("Select a driver to delete");
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this driver?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                string query = "DELETE FROM DriverTb WHERE DrID=@DID";
                SqlParameter[] param = { new SqlParameter("@DID", DriverId) };
                db.Execute(query, param);
                MessageBox.Show("Driver Deleted Successfully");
                Clear();
                ShowDriver();
            }
        }

        private void Drivers_Load(object sender, EventArgs e)
        {
            ShowDriver();
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
            try
            {
                StringBuilder query = new StringBuilder("SELECT * FROM DriverTb WHERE 1=1");
                var paramList = new List<SqlParameter>();

                if (!string.IsNullOrEmpty(Dname.Text))
                {
                    query.Append(" AND DrName LIKE @Name");
                    paramList.Add(new SqlParameter("@Name", "%" + Dname.Text + "%"));
                }

                if (!string.IsNullOrEmpty(DEmail.Text))
                {
                    query.Append(" AND DrEmail LIKE @Email");
                    paramList.Add(new SqlParameter("@Email", "%" + DEmail.Text + "%"));
                }

                if (!string.IsNullOrEmpty(Dphone.Text))
                {
                    query.Append(" AND DrPhone LIKE @Phone");
                    paramList.Add(new SqlParameter("@Phone", "%" + Dphone.Text + "%"));
                }

                if (!string.IsNullOrEmpty(DAddress.Text))
                {
                    query.Append(" AND DrAdress LIKE @Address");
                    paramList.Add(new SqlParameter("@Address", "%" + DAddress.Text + "%"));
                }

                if (DGen.SelectedIndex != -1)
                {
                    query.Append(" AND DrGen = @Gen");
                    paramList.Add(new SqlParameter("@Gen", DGen.SelectedItem.ToString()));
                }

                if (DStatus.SelectedIndex != -1)
                {
                    query.Append(" AND DrStatus = @Status");
                    paramList.Add(new SqlParameter("@Status", DStatus.SelectedItem.ToString()));
                }

                DataTable dt = db.GetData(query.ToString(), paramList.ToArray());
                DGV.DataSource = dt;

                if (dt.Rows.Count == 0)
                    MessageBox.Show("No driver found");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

    }

}
