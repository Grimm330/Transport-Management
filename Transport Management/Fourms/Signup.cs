using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Transport_Management
{
    public partial class Signup : Form
    {
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
        private ErrorProvider errorProvider1 = new ErrorProvider();
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
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\Documents\TransportDB.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False");


        private void button1_Click(object sender, EventArgs e)
        {
            if (!ValidateSignup())
                return;

            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO UserTB (Uname, Uphone, UserEmail, UType, Pass) " +
                    "VALUES (@N, @P, @E, @T, @PW)", con);

                cmd.Parameters.AddWithValue("@N", SName.Text.ToString());
                cmd.Parameters.AddWithValue("@P", SPhone.Text.ToString());
                cmd.Parameters.AddWithValue("@E", SEmail.Text.ToString());
                cmd.Parameters.AddWithValue("@T", SType.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@PW", Spass.Text); 

                cmd.ExecuteNonQuery();

                MessageBox.Show("Signup Successful ✅");

                ClearSignup();
            }
            catch (SqlException ex)
            {
                    MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
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
