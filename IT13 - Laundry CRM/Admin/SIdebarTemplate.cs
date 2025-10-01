using IT13___Laundry_CRM.Admin;
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
    public partial class SIdebarTemplate : Form
    {
        public SIdebarTemplate()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_laundry_attendant_Click(object sender, EventArgs e)
        {
            //UserForm userform = new UserForm();
            //userform.Show();

            //this.Hide();
        }

        private void button_users_Click(object sender, EventArgs e)
        {
            admin_user user = new admin_user();
            user.Show();

            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void button_messages_Click(object sender, EventArgs e)
        {
            admin_messages messages = new admin_messages();
            messages.Show();

            this.Hide();
        }

        private void button_feedback_Click(object sender, EventArgs e)
        {
            admin_feedback feedback = new admin_feedback();
            feedback.Show();

            this.Hide();
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

        private void profile_Click(object sender, EventArgs e)
        {
            contextmenustrip_profile.Show(profile, 0, profile.Height);
        }
    }
}
