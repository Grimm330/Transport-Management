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
        private bool ValidateSignup()
        {
            
            if (string.IsNullOrWhiteSpace(SName.Text))
            {
                MessageBox.Show("Name is required");
                SName.Focus();
                return false;
            }

            
            if (string.IsNullOrWhiteSpace(SPhone.Text))
            {
                MessageBox.Show("Enter a phone number");
                SPhone.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(SEmail.Text))
            {
                MessageBox.Show("Enter a email address");
                SEmail.Focus();
                return false;
            }
            if (SType.SelectedIndex == -1)
            {
                MessageBox.Show("Select user type");
                SType.DroppedDown = true;
                return false;
            }
            if (string.IsNullOrWhiteSpace(Spass.Text) || Spass.Text.Length < 6)
            {
                MessageBox.Show("Password must be at least 6 characters");
                Spass.Focus();
                return false;
            }

            return true;
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
