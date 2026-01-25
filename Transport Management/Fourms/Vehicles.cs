using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Transport_Management
{
    public partial class Vehicles : Form
    {
        DataAccess db = new DataAccess();

        public Vehicles()
        {
            InitializeComponent();
            ShowV();
            Clear();
        }

        private void Clear()
        {
            VName.Text = "";
            Vmile.Text = "";
            VYear.Text = "";
            VLEtype.SelectedIndex = -1;
            VLp.Text = "";
            VStatus.SelectedIndex = -1;
            Amount.Text = "";
        }

        private void ShowV()
        {
            VeGV.DataSource = db.GetData("SELECT * FROM VehiclesTB");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(VName.Text) || string.IsNullOrWhiteSpace(Vmile.Text) || string.IsNullOrWhiteSpace(VYear.Text) || VLEtype.SelectedIndex == -1 || string.IsNullOrWhiteSpace(VLp.Text) || VStatus.SelectedIndex == -1 || string.IsNullOrWhiteSpace(Amount.Text))
            {
                MessageBox.Show("Missing Information");
                return;
            }

            string query = "INSERT INTO VehiclesTB (VLName, VLMile, VLEtype, VLYear, VLSt, VlLp, Amount) VALUES (@VN, @VM, @VT, @VY, @VS, @VLp, @VA)";
            SqlParameter[] param = {
                new SqlParameter("@VN", VName.Text),
                new SqlParameter("@VM", Vmile.Text),
                new SqlParameter("@VT", VLEtype.SelectedItem.ToString()),
                new SqlParameter("@VY", VYear.Text),
                new SqlParameter("@VS", VStatus.SelectedItem.ToString()),
                new SqlParameter("@VLp", VLp.Text),
                new SqlParameter("@VA", Amount.Text)
            };
            db.Execute(query, param);
            MessageBox.Show("Vehicle Added Successfully");
            Clear();
            ShowV();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(VName.Text) || string.IsNullOrWhiteSpace(Vmile.Text) || string.IsNullOrWhiteSpace(VYear.Text) || VLEtype.SelectedIndex == -1 || string.IsNullOrWhiteSpace(VLp.Text) || VStatus.SelectedIndex == -1 || string.IsNullOrWhiteSpace(Amount.Text))
            {
                MessageBox.Show("Missing Information");
                return;
            }

            string query = "UPDATE VehiclesTB SET VLName=@VN, VLMile=@VM, VLEtype=@VT, VLYear=@VY, VLSt=@VS, Amount=@VA WHERE VlLp=@VLp";
            SqlParameter[] param = {
                new SqlParameter("@VN", VName.Text),
                new SqlParameter("@VM", Vmile.Text),
                new SqlParameter("@VT", VLEtype.SelectedItem.ToString()),
                new SqlParameter("@VY", VYear.Text),
                new SqlParameter("@VS", VStatus.SelectedItem.ToString()),
                new SqlParameter("@VLp", VLp.Text),
                new SqlParameter("@VA", Amount.Text)
            };
            db.Execute(query, param);
            MessageBox.Show("Vehicle Updated Successfully");
            Clear();
            ShowV();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(VLp.Text))
            {
                MessageBox.Show("Select a Vehicle");
                return;
            }

            string query = "DELETE FROM VehiclesTB WHERE VlLp=@VLp";
            SqlParameter[] param = { new SqlParameter("@VLp", VLp.Text) };
            db.Execute(query, param);
            MessageBox.Show("Vehicle Deleted Successfully");
            Clear();
            ShowV();
        }

        private void VeGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = VeGV.Rows[e.RowIndex];
            VLp.Text = row.Cells["VlLp"].Value.ToString();
            VName.Text = row.Cells["VLName"].Value.ToString();
            Vmile.Text = row.Cells["VLMile"].Value.ToString();
            VYear.Text = row.Cells["VLYear"].Value.ToString();
            VLEtype.Text = row.Cells["VLEtype"].Value.ToString();
            VStatus.Text = row.Cells["VLSt"].Value.ToString();
            Amount.Text = row.Cells["Amount"].Value.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(VLp.Text))
            {
                MessageBox.Show("Please enter License Plate to search");
                return;
            }

            string query = "SELECT * FROM VehiclesTB WHERE VlLp LIKE @VLp";
            SqlParameter[] param = { new SqlParameter("@VLp", "%" + VLp.Text + "%") };
            VeGV.DataSource = db.GetData(query, param);

            if (VeGV.Rows.Count == 0)
                MessageBox.Show("No vehicle found");
        }

        private void VLp_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(VLp.Text))
                ShowV();
        }
    }
}
