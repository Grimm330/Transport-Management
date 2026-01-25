using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Transport_Management
{
    public partial class Booking : Form
    {
        DataAccess db = new DataAccess();

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
            string query = "SELECT * FROM BookingTB";
            BGV.DataSource = db.GetData(query);
        }
        private void GetCustomers()
        {
            string query = "SELECT CusID FROM CustomerTB";
            DataTable dt = db.GetData(query);

            CusBook.DataSource = null;
            CusBook.Items.Clear();
            CusBook.DisplayMember = "CusID";
            CusBook.ValueMember = "CusID";
            CusBook.DataSource = dt;
        }
        private void GetVeHicles()
        {
            string query = "SELECT VLLp FROM VehiclesTB WHERE VLSt='Available'";
            DataTable dt = db.GetData(query);

            VeBook.DataSource = null;
            VeBook.Items.Clear();
            VeBook.DisplayMember = "VLLp";
            VeBook.ValueMember = "VLLp";
            VeBook.DataSource = dt;
        }
        private void GetDrivers()
        {
            string query = "SELECT DrID FROM DriverTB WHERE DrStatus='Available'";
            DataTable dt = db.GetData(query);

            VeDriver.DataSource = null;
            VeDriver.Items.Clear();
            VeDriver.DisplayMember = "DrID";
            VeDriver.ValueMember = "DrID";
            VeDriver.DataSource = dt;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (CusBook.SelectedIndex == -1 || VeBook.SelectedIndex == -1 ||
                VeDriver.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
                return;
            }

            int days = (Rdate.Value - Pdate.Value).Days;
            if (days <= 0)
            {
                MessageBox.Show("Return date must be after pickup date");
                return;
            }

            try
            {
                string cusEmail = db.ExecuteScalar( "SELECT CusEmail FROM CustomerTB WHERE CusID=@ID",
                    new[] 
                    {
                        new SqlParameter("@ID", CusBook.SelectedValue) 
                    }
                ).ToString();
                DataTable vdt = db.GetData( "SELECT VName, Amount FROM VehiclesTB WHERE VLLp=@VL",
                    new[]
                    { 
                        new SqlParameter("@VL", VeBook.SelectedValue)
                    }
                );

                string vName = vdt.Rows[0]["VName"].ToString();
                decimal vCharge = Convert.ToDecimal(vdt.Rows[0]["Amount"]);

            
                DataTable ddt = db.GetData( "SELECT DrName, DWage FROM DriverTB WHERE DrID=@ID",
                    new[] 
                    { 
                        new SqlParameter("@ID", VeDriver.SelectedValue)
                    }
                );

                string drName = ddt.Rows[0]["DrName"].ToString();
                decimal drWage = Convert.ToDecimal(ddt.Rows[0]["DWage"]);

              
                decimal baseAmount = (vCharge + drWage) * days;
                decimal totalAmount = baseAmount + (baseAmount * 0.05m);
                string insertQuery =  @"INSERT INTO BookingTB(CusID, CusEmail, VLp, VName, Did, DrN, Amount, PDate, RDate) VALUES (@CI,@CE,@VL,@VN,@DI,@DN,@AM,@PD,@RD)";

                SqlParameter[] insertParams =
                {
                    new SqlParameter("@CI", CusBook.SelectedValue),
                    new SqlParameter("@CE", cusEmail),
                    new SqlParameter("@VL", VeBook.SelectedValue),
                    new SqlParameter("@VN", vName),
                    new SqlParameter("@DI", VeDriver.SelectedValue),
                    new SqlParameter("@DN", drName),
                    new SqlParameter("@AM", totalAmount),
                    new SqlParameter("@PD", Pdate.Value),
                    new SqlParameter("@RD", Rdate.Value)
                };

                db.Execute(insertQuery, insertParams);
                db.Execute("UPDATE VehiclesTB SET VLSt='Booked' WHERE VLLp=@VL",
                    new[] { new SqlParameter("@VL", VeBook.SelectedValue) });

                db.Execute("UPDATE DriverTB SET DrStatus='In-Trip' WHERE DrID=@ID",
                    new[] { new SqlParameter("@ID", VeDriver.SelectedValue) });

                MessageBox.Show("Booking Added!\nTotal Amount: " + totalAmount);

                clear();
                showb();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (BGV.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a booking first");
                return;
            }

            int bookingID = Convert.ToInt32(BGV.SelectedRows[0].Cells["BookingID"].Value);

            if (MessageBox.Show("Delete this booking?", "Confirm",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                db.Execute(
                    "DELETE FROM BookingTB WHERE BookingID=@ID",
                    new[] { new SqlParameter("@ID", bookingID) }
                );

                showb();
            }
        }
        private void BGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = BGV.Rows[e.RowIndex];
                VeDriver.SelectedValue = row.Cells["Did"].Value;
                VeBook.SelectedValue = row.Cells["VLp"].Value;
                CusBook.SelectedValue = row.Cells["CusID"].Value;
                Pdate.Value = Convert.ToDateTime(row.Cells["PDate"].Value);
                Rdate.Value = Convert.ToDateTime(row.Cells["RDate"].Value);
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM BookingTB WHERE 1=1";
            var list = new System.Collections.Generic.List<SqlParameter>();

            if (CusBook.SelectedIndex != -1)
            {
                query += " AND CusID=@C";
                list.Add(new SqlParameter("@C", CusBook.SelectedValue));
            }

            if (VeBook.SelectedIndex != -1)
            {
                query += " AND VLp=@V";
                list.Add(new SqlParameter("@V", VeBook.SelectedValue));
            }

            if (VeDriver.SelectedIndex != -1)
            {
                query += " AND Did=@D";
                list.Add(new SqlParameter("@D", VeDriver.SelectedValue));
            }

            BGV.DataSource = db.GetData(query, list.ToArray());
        }
    }
}
