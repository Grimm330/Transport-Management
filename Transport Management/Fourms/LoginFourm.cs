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
using Transport_Management.Fourms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Transport_Management
{
    public partial class LoginFourm : Form
    {
        public LoginFourm()
        {
            InitializeComponent();
        }
        private ErrorProvider errorProvider1 = new ErrorProvider();

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

        private void LoginFourm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Signup signup = new Signup();
            signup.Show();
            this.Hide();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\Documents\TransportDB.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False");


        private void button1_Click(object sender, EventArgs e)
        {
            if (!Validatelog())
                return;

            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand( "SELECT UType FROM UserTB WHERE UserEmail=@E AND Pass=@P", con);

                cmd.Parameters.AddWithValue("@E", Lemail.Text);
                cmd.Parameters.AddWithValue("@P", Lpass.Text);

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    string userType = dr["UType"].ToString();

                    MessageBox.Show("Login Successful ✅");
                    this.Hide();

                    if (userType == "Admin")
                    {
                        showFourm showFourm = new showFourm();
                        showFourm.Show();
                        this.Hide();


                    }
                        
                    else

                    {
                        UserBook userBook = new UserBook();
                        userBook.Show();
                        this.Hide();
                    }
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
            finally
            {
                con.Close();
            }
        }

    }
}

