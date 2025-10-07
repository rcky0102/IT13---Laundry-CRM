using IT13___Laundry_CRM.Laundry_Attendant;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static IT13___Laundry_CRM.Models.User;

namespace IT13___Laundry_CRM
{
    public partial class Laundry_Attendant_Template : Form
    {
        public Laundry_Attendant_Template()
        {
            InitializeComponent();
        }

        private void button_customers_Click(object sender, EventArgs e)
        {
            Laundry_Attendant_CustomersForm customers = new Laundry_Attendant_CustomersForm();
            customers.Show();

            this.Hide();
        }

        private void button_status_Click(object sender, EventArgs e)
        {
            laundry_attendant_status status = new laundry_attendant_status();
            status.Show();

            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            laundry_attendant_messages messages = new laundry_attendant_messages();
            messages.Show();

            this.Hide();
        }

        private void button_feedback_Click(object sender, EventArgs e)
        {
            laundry_attendant_feedback feedback = new laundry_attendant_feedback();
            feedback.Show();

            this.Hide();
        }

        private void profile_Click(object sender, EventArgs e)
        {
            contextmenustrip_profile.Show(profile, 0, profile.Height);
        }

        private void logout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Logout",
                                          MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                CurrentUser.User = null;


                Form1 loginForm = new Form1();
                loginForm.Show();

                this.Close();
            }
        }

        private void Laundry_Attendant_Template_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void button_dashboard_Click(object sender, EventArgs e)
        {
            Laundry_Attendant_Dashboard dashboard = new Laundry_Attendant_Dashboard();
            dashboard.Show();

            this.Hide();
        }
    }
}
