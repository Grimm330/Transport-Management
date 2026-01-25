using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Transport_Management.Fourms
{
    public partial class showFourm : Form
    {
        public showFourm()
        {
            InitializeComponent();
           
        }
        
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            ShowPanel.Controls.Clear();
            Customer customer = new Customer();
            customer.TopLevel=false;
            ShowPanel.Controls.Add(customer);
            customer.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ShowPanel.Controls.Clear();
            Drivers drivers = new Drivers();
            drivers.TopLevel=false;
            ShowPanel.Controls.Add(drivers);
            drivers.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            ShowPanel.Controls.Clear();
            Vehicles vehicles = new Vehicles();
            vehicles.TopLevel = false;
            ShowPanel.Controls.Add(vehicles);
            vehicles.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            ShowPanel.Controls.Clear();
            Booking booking = new Booking();
            booking.TopLevel=false;
            ShowPanel.Controls.Add(booking);
            booking.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            ShowPanel.Controls.Clear();
            Dashbord dash = new Dashbord();
            dash.TopLevel=false;
            ShowPanel.Controls.Add(dash);
            dash.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ShowPanel.Controls.Clear();
            Profile pro = new Profile();
            pro.TopLevel = false;
            ShowPanel.Controls.Add(pro);
            pro.Show();

        }

        private void ShowPanel_Paint(object sender, PaintEventArgs e)
        {
            Profile profile = new Profile();
            profile.TopLevel = false; 
            ShowPanel.Controls.Add(profile);
            profile.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginFourm loginFourm = new LoginFourm();
            loginFourm.Show();
            this.Hide();
        }
    }
}
