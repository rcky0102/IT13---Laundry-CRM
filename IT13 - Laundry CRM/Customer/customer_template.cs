using IT13___Laundry_CRM.Customer;
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
    public partial class customer_template : Form
    {
        public customer_template()
        {
            InitializeComponent();
        }

        private void button_status_Click(object sender, EventArgs e)
        {
            customer_status status = new customer_status();
            status.Show();

            this.Hide();
        }

        private void button_message_Click(object sender, EventArgs e)
        {
            customer_messages message = new customer_messages();
            message.Show();

            this.Hide();
        }

        private void button_feedback_Click(object sender, EventArgs e)
        {
            customer_feedback feedback = new customer_feedback();
            feedback.Show();

            this.Hide();
        }

        private void button_profile_Click(object sender, EventArgs e)
        {
            contextmenustrip_profile.Show(button_profile, 0, button_profile.Height);
        }

        private void profile_Click(object sender, EventArgs e)
        {
            customer_profile profile = new customer_profile();
            profile.ShowDialog();

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

        private void button_dashboard_Click(object sender, EventArgs e)
        {
            customer_dashboard dashboard = new customer_dashboard();
            dashboard.Show();

            this.Hide();
        }

        private void customer_template_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            System.Drawing.Drawing2D.GraphicsPath buttonPath = new System.Drawing.Drawing2D.GraphicsPath();
            buttonPath.AddEllipse(0, 0, button_profile.Width, button_profile.Height);
            button_profile.Region = new Region(buttonPath);
        }

        private void button_profile_Resize(object sender, EventArgs e)
        {

        }
    }
}
