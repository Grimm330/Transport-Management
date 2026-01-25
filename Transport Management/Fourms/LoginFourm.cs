using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Transport_Management.Fourms;

namespace Transport_Management
{
    public partial class LoginFourm : Form
    {
        DataAccess db = new DataAccess();
        ErrorProvider errorProvider1 = new ErrorProvider();

        public LoginFourm()
        {
            InitializeComponent();
        }

        private bool Validatelog()
        {
            bool isValid = true;
            errorProvider1.Clear();

            if (string.IsNullOrWhiteSpace(Lemail.Text))
            {
                errorProvider1.SetError(Lemail, "Email is required");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(Lpass.Text))
            {
                errorProvider1.SetError(Lpass, "Password is required");
                isValid = false;
            }

            return isValid;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Signup signup = new Signup();
            signup.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!Validatelog())
                return;

            try
            {
                string query = "SELECT UserID, UType FROM UserTB WHERE UserEmail=@E AND Pass=@P";
                var parameters = new[]
                {
                    new SqlParameter("@E", Lemail.Text),
                    new SqlParameter("@P", Lpass.Text)
                };

                DataTable dt = db.ExecuteQuery(query, parameters);

                if (dt.Rows.Count > 0)
                {
                    int userID = Convert.ToInt32(dt.Rows[0]["UserID"]);
                    string userType = dt.Rows[0]["UType"].ToString();

                    MessageBox.Show("Login Successful ✅");
                    this.Hide();

                    if (userType == "Admin")
                    {
                        new showFourm().Show();
                        Profile profileForm = new Profile(userID);
                    }
                    else
                        new UserBook().Show();
                }
                else
                {
                    MessageBox.Show("Invalid email or password ❌");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
