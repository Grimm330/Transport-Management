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
            LoadCustomers();
            LoadVehicles();
            LoadDrivers();
            ClearAll();
            ShowBookings();
        }

        void ClearAll()
        {
            CusBook.SelectedIndex = -1;
            VeBook.SelectedIndex = -1;
            VeDriver.SelectedIndex = -1;
            Pdate.Value = DateTime.Now;
            Rdate.Value = DateTime.Now;
        }

        void ShowBookings()
        {
            
            BGV.DataSource = db.GetData("SELECT * FROM BookingTB");
        }

        void LoadCustomers()
        {
            DataTable dt = db.GetData("SELECT CusID FROM CustomerTB");
            CusBook.DataSource = dt;
            CusBook.DisplayMember = "CusID";
            CusBook.ValueMember = "CusID";
            CusBook.SelectedIndex = -1;
        }

        void LoadVehicles()
        {
            DataTable dt = db.GetData("SELECT VLLp FROM VehiclesTB WHERE VLSt='Available'");
            VeBook.DataSource = dt;
            VeBook.DisplayMember = "VLLp";
            VeBook.ValueMember = "VLLp";
            VeBook.SelectedIndex = -1;
        }

        void LoadDrivers()
        {
            DataTable dt = db.GetData("SELECT DrID FROM DriverTB WHERE DrStatus='Available'");
            VeDriver.DataSource = dt;
            VeDriver.DisplayMember = "DrID";
            VeDriver.ValueMember = "DrID";
            VeDriver.SelectedIndex = -1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            if (CusBook.SelectedIndex == -1 || VeBook.SelectedIndex == -1 || VeDriver.SelectedIndex == -1)
            {
                MessageBox.Show("Select all fields");
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
                string cusEmail = db.ExecuteScalar(
                    "SELECT CusEmail FROM CustomerTB WHERE CusID=@ID",
                    new[] { new SqlParameter("@ID", CusBook.SelectedValue) }
                ).ToString();

                DataTable vdt = db.GetData(
                    "SELECT VLName, Amount FROM VehiclesTB WHERE VLLp=@VL",
                    new[] { new SqlParameter("@VL", VeBook.SelectedValue) }
                );

                string vName = vdt.Rows[0]["VLName"].ToString();
                decimal vCharge = Convert.ToDecimal(vdt.Rows[0]["Amount"]);

                
                DataTable ddt = db.GetData(
                    "SELECT DrName, DWage FROM DriverTB WHERE DrID=@ID",
                    new[] { new SqlParameter("@ID", VeDriver.SelectedValue) }
                );

                string drName = ddt.Rows[0]["DrName"].ToString();
                decimal drWage = Convert.ToDecimal(ddt.Rows[0]["DWage"]);

                decimal totalAmount = (vCharge + drWage) * days;
                totalAmount += totalAmount * 0.05m;


                db.Execute( "INSERT INTO BookingTB(CusID, CusEmail, VLp, VName, Did, DrN, BAt, Amount, PDate, RDate) VALUES(@CI,@CE,@VL,@VN,@DI,@DN,@BA,@AM,@PD,@RD)",
                new[]
                {
                  new SqlParameter("@CI", CusBook.SelectedValue),
                  new SqlParameter("@CE", cusEmail),
                  new SqlParameter("@VL", VeBook.SelectedValue),
                  new SqlParameter("@VN", vName),
                  new SqlParameter("@DI", VeDriver.SelectedValue),
                  new SqlParameter("@DN", drName),
                  new SqlParameter("@BA", vCharge),       // <-- FIX: BAt
                  new SqlParameter("@AM", totalAmount),
                  new SqlParameter("@PD", Pdate.Value),
                 new SqlParameter("@RD", Rdate.Value)
                }
              );


                db.Execute(
                    "UPDATE VehiclesTB SET VLSt='Booked' WHERE VLLp=@VL",
                    new[] { new SqlParameter("@VL", VeBook.SelectedValue) }
                );

               
                db.Execute(
                    "UPDATE DriverTB SET DrStatus='In-Trip' WHERE DrID=@ID",
                    new[] { new SqlParameter("@ID", VeDriver.SelectedValue) }
                );

                MessageBox.Show("Booking Done\nTotal: " + totalAmount);

                ClearAll();
                ShowBookings();
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
                MessageBox.Show("Select booking");
                return;
            }

            int id = Convert.ToInt32(BGV.SelectedRows[0].Cells["BID"].Value);

            db.Execute("DELETE FROM BookingTB WHERE BID=@ID", new[] { new SqlParameter("@ID", id) });

            ShowBookings();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
