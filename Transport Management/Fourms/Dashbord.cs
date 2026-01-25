using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Transport_Management
{
    public partial class Dashbord : Form
    {
        DataAccess db = new DataAccess();

        public Dashbord()
        {
            InitializeComponent();
            LoadCounts();
            LoadGrid("CustomerTB");
        }

        private void LoadGrid(string tableName)
        {
            DGV.DataSource = db.GetData($"SELECT * FROM {tableName}");
        }

        private void LoadCounts()
        {
            label12.Text = db.ExecuteScalar("SELECT COUNT(*) FROM CustomerTB").ToString();
            label13.Text = db.ExecuteScalar("SELECT COUNT(*) FROM VehiclesTB").ToString();
            label14.Text = db.ExecuteScalar("SELECT COUNT(*) FROM DriverTb").ToString();

            object total = db.ExecuteScalar("SELECT SUM(Amount) FROM BookingTB");
            label15.Text = total != DBNull.Value ? Convert.ToDecimal(total).ToString("C") : "0";
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            LoadGrid("CustomerTB");
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            LoadGrid("BookingTB");
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {
            LoadGrid("VehiclesTB");
        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {
            LoadGrid("DriverTb");
        }
    }
}
