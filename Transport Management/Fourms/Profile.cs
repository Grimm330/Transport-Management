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
using System.Xml.Linq;

namespace Transport_Management.Fourms
{
    public partial class Profile : Form
    {
        public Profile()
        {
            InitializeComponent();
        }
        private int _userID;
        DataAccess db = new DataAccess();

        public Profile(int userID)
        {
            InitializeComponent();
            _userID = userID;
        }
        private void Profile_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM UserTB WHERE UserID=@ID";
            var parameters = new[]
            {
                new SqlParameter("@ID", _userID)
            };
            DataTable dt = db.ExecuteQuery(query, parameters);

            if (dt.Rows.Count > 0)
            {
                Pname.Text = dt.Rows[0]["Uname"].ToString();
                Pphone.Text = dt.Rows[0]["Uphone"].ToString();
                pemail.Text = dt.Rows[0]["UserEmail"].ToString();
               
                ppass.Text = dt.Rows[0]["Pass"].ToString();
            }
        }



        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Pname.Text) || string.IsNullOrWhiteSpace(Pphone.Text) ||string.IsNullOrWhiteSpace(pemail.Text) ||string.IsNullOrWhiteSpace(ppass.Text))
            {
                MessageBox.Show("All fields are required");
                return;
            }

            string query = "UPDATE UserTB SET Uname=@N, Uphone=@P, UserEmail=@E, Pass=@PW WHERE UserID=@ID";
            var parameters = new[]
            {
                new SqlParameter("@N", Pname.Text),
                new SqlParameter("@P", Pphone.Text),
                new SqlParameter("@E", pemail.Text),
                new SqlParameter("@PW", ppass.Text),
                new SqlParameter("@ID", _userID)
            };

            int rows = db.Execute(query, parameters);

            if (rows > 0)
                MessageBox.Show("Profile updated successfully");
            else
                MessageBox.Show("Update failed");
        }

        private void label16_Click(object sender, EventArgs e)
        {
            string query = "SELECT Uname FROM UserTB WHERE UserID=@ID";
            var parameters = new[]
            {
              new SqlParameter("@ID", _userID) 
            };

            DataTable dt = db.ExecuteQuery(query, parameters);

            if (dt.Rows.Count > 0)
                label16.Text = dt.Rows[0]["Uname"].ToString();
            else
                label16.Text = "Unknown User";
        }

        private void label17_Click(object sender, EventArgs e)
        {
            string query = "SELECT Uphone FROM UserTB WHERE UserID=@ID";
            var parameters = new[]
            {
             new SqlParameter("@ID", _userID)
            };

            DataTable dt = db.ExecuteQuery(query, parameters);

            if (dt.Rows.Count > 0)
                label16.Text = dt.Rows[0]["Uphone"].ToString();
            else
                label16.Text = "Unknown User";
        }

        private void label18_Click(object sender, EventArgs e)
        {
            string query = "SELECT UserEmail FROM UserTB WHERE UserID=@ID";
            var parameters = new[]
            {
               new SqlParameter("@ID", _userID)
            };

            DataTable dt = db.ExecuteQuery(query, parameters);

            if (dt.Rows.Count > 0)
                label16.Text = dt.Rows[0]["UserEmail"].ToString();
            else
                label16.Text = "Unknown User";
        }

        private void label19_Click(object sender, EventArgs e)
        {
            string query = "SELECT Pass FROM UserTB WHERE UserID=@ID";
            var parameters = new[]
            {
             new SqlParameter("@ID", _userID) 
            };

            DataTable dt = db.ExecuteQuery(query, parameters);

            if (dt.Rows.Count > 0)
                label16.Text = dt.Rows[0]["Pass"].ToString();
            else
                label16.Text = "Unknown User";
        }
    }
}
    

