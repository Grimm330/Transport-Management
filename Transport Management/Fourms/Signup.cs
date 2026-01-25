using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Transport_Management
{
    public partial class Signup : Form
    {
        DataAccess db = new DataAccess();
        ErrorProvider errorProvider1 = new ErrorProvider();

        public Signup()
        {
            InitializeComponent();
            ClearSignup();
        }

        private void ClearSignup()
        {
            SName.Clear();
            SPhone.Clear();
            SEmail.Clear();
            Spass.Clear();
            SType.SelectedIndex = -1;
        }

        private bool ValidateSignup()
        {
            bool isValid = true;
            errorProvider1.Clear();

            if (string.IsNullOrWhiteSpace(SName.Text))
            {
                errorProvider1.SetError(SName, "Name is required");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(SPhone.Text))
            {
                errorProvider1.SetError(SPhone, "Phone number is required");
                isValid = false;
            }
            else if (!long.TryParse(SPhone.Text, out _))
            {
                errorProvider1.SetError(SPhone, "Phone number must be digits only");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(SEmail.Text))
            {
                errorProvider1.SetError(SEmail, "Email is required");
                isValid = false;
            }

            if (SType.SelectedIndex == -1)
            {
                errorProvider1.SetError(SType, "Select user type");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(Spass.Text))
            {
                errorProvider1.SetError(Spass, "Password is required");
                isValid = false;
            }

            return isValid;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!ValidateSignup())
                return;

            try
            {
                string query = "INSERT INTO UserTB (Uname, Uphone, UserEmail, UType, Pass) " +
                               "VALUES (@N, @P, @E, @T, @PW)";

                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@N", SName.Text),
                    new SqlParameter("@P", SPhone.Text),
                    new SqlParameter("@E", SEmail.Text),
                    new SqlParameter("@T", SType.SelectedItem.ToString()),
                    new SqlParameter("@PW", Spass.Text)
                };

                db.ExecuteNonQuery(query, parameters);
                MessageBox.Show("Signup Successful ✅");
                ClearSignup();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoginFourm loginFourm = new LoginFourm();
            loginFourm.Show();
            this.Hide();
        }
    }
}
