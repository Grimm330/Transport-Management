using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace Transport_Management
{
    public partial class Customer : Form
    {
        DataAccess db = new DataAccess();
        int Key = 0;

        public Customer()
        {
            InitializeComponent();
            ShowCus();
        }

        private void clear()
        {
            CusEmail1.Text = "";
            CusName1.Text = "";
            CusPhone1.Text = "";
            CusGen.SelectedIndex = -1;
            CusAddress.Text = "";
            Key = 0;
        }

        private void ShowCus()
        {
            CusGV.DataSource = db.GetData("SELECT * FROM CustomerTB");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (CusEmail1.Text == "" || CusName1.Text == "" || CusPhone1.Text == "" || CusAddress.Text == "" || CusGen.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
                return;
            }

            string query = "INSERT INTO CustomerTB (CusEmail, CusPhone, CusName, CusAdd, CusGen) VALUES (@CE, @CP, @CN, @CA, @CG)";
            SqlParameter[] param = {
                new SqlParameter("@CE", CusEmail1.Text),
                new SqlParameter("@CP", CusPhone1.Text),
                new SqlParameter("@CN", CusName1.Text),
                new SqlParameter("@CA", CusAddress.Text),
                new SqlParameter("@CG", CusGen.SelectedItem.ToString())
            };
            db.Execute(query, param);
            MessageBox.Show("Customer Added Successfully");
            clear();
            ShowCus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Select a Customer");
                return;
            }

            string query = "DELETE FROM CustomerTB WHERE CusID = @Cid";
            SqlParameter[] param = { new SqlParameter("@Cid", Key) };
            db.Execute(query, param);
            MessageBox.Show("Customer Deleted Successfully");
            clear();
            ShowCus();
        }

        private void CusGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow row = CusGV.Rows[e.RowIndex];
            CusEmail1.Text = row.Cells["CusEmail"].Value.ToString();
            CusName1.Text = row.Cells["CusName"].Value.ToString();
            CusPhone1.Text = row.Cells["CusPhone"].Value.ToString();
            CusAddress.Text = row.Cells["CusAdd"].Value.ToString();
            CusGen.Text = row.Cells["CusGen"].Value.ToString();
            Key = (int)row.Cells["CusID"].Value;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Select a Customer to update");
                return;
            }

            if (CusEmail1.Text == "" || CusName1.Text == "" || CusPhone1.Text == "" || CusAddress.Text == "" || CusGen.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
                return;
            }

            string query = "UPDATE CustomerTB SET CusEmail=@CE, CusPhone=@CP, CusName=@CN, CusAdd=@CA, CusGen=@CG WHERE CusID=@Cid";
            SqlParameter[] param = {
                new SqlParameter("@CE", CusEmail1.Text),
                new SqlParameter("@CP", CusPhone1.Text),
                new SqlParameter("@CN", CusName1.Text),
                new SqlParameter("@CA", CusAddress.Text),
                new SqlParameter("@CG", CusGen.SelectedItem.ToString()),
                new SqlParameter("@Cid", Key)
            };
            db.Execute(query, param);
            MessageBox.Show("Customer Updated Successfully");
            clear();
            ShowCus();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            StringBuilder query = new StringBuilder("SELECT * FROM CustomerTB WHERE 1=1");
            var paramList = new List<SqlParameter>();

            if (CusName1.Text != "")
            {
                query.Append(" AND CusName LIKE @Name");
                paramList.Add(new SqlParameter("@Name", "%" + CusName1.Text + "%"));
            }
            if (CusEmail1.Text != "")
            {
                query.Append(" AND CusEmail LIKE @Email");
                paramList.Add(new SqlParameter("@Email", "%" + CusEmail1.Text + "%"));
            }
            if (CusPhone1.Text != "")
            {
                query.Append(" AND CusPhone LIKE @Phone");
                paramList.Add(new SqlParameter("@Phone", "%" + CusPhone1.Text + "%"));
            }
            if (CusAddress.Text != "")
            {
                query.Append(" AND CusAdd LIKE @Address");
                paramList.Add(new SqlParameter("@Address", "%" + CusAddress.Text + "%"));
            }
            if (CusGen.SelectedIndex != -1)
            {
                query.Append(" AND CusGen=@Gen");
                paramList.Add(new SqlParameter("@Gen", CusGen.SelectedItem.ToString()));
            }

            DataTable dt = db.GetData(query.ToString(), paramList.ToArray());
            CusGV.DataSource = dt;

            if (dt.Rows.Count == 0)
                MessageBox.Show("No customer found");
        }

        private void Customer_Load(object sender, EventArgs e)
        {
        }
    }
}
