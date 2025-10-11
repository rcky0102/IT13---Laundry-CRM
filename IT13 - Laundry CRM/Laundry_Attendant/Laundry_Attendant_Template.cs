using IT13___Laundry_CRM.Laundry_Attendant;
using System;
using System.Drawing;
using System.Windows.Forms;
using static IT13___Laundry_CRM.Models.User;

namespace IT13___Laundry_CRM
{
    public partial class Laundry_Attendant_Template : Form
    {
        private Button activeButton;                // currently active button
        private Panel indicator;                    // small moving indicator on the left
        public static string LastActiveButtonName;  // persists last active when hiding/showing

        public Laundry_Attendant_Template()
        {
            InitializeComponent();
        }

        private void Laundry_Attendant_Template_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            // make profile circular (your existing code)
            var gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, profile.Width, profile.Height);
            profile.Region = new Region(gp);

            // create the indicator panel
            indicator = new Panel();
            indicator.Size = new Size(6, button_dashboard.Height);
            indicator.BackColor = Color.White;
            indicator.Visible = false;
            indicator.Location = new Point(0, button_dashboard.Top);
            panel1.Controls.Add(indicator);
            indicator.BringToFront();

            // initialize all buttons to default style
            foreach (Control c in panel1.Controls)
            {
                if (c is Button btn && btn != profile)
                {
                    btn.BackColor = panel1.BackColor;
                    btn.ForeColor = Color.White;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;
                    btn.UseVisualStyleBackColor = false;
                }
            }

            // restore last active button
            if (!string.IsNullOrEmpty(LastActiveButtonName))
            {
                var found = panel1.Controls.Find(LastActiveButtonName, true);
                if (found.Length > 0 && found[0] is Button saved)
                {
                    ActivateButton(saved);
                }
            }
        }

        // activate a clicked button
        private void ActivateButton(Button clickedButton)
        {
            // reset old
            if (activeButton != null)
            {
                activeButton.BackColor = panel1.BackColor;
                activeButton.ForeColor = Color.White;
            }

            // apply active style
            activeButton = clickedButton;
            LastActiveButtonName = clickedButton.Name;
            activeButton.BackColor = Color.White;
            activeButton.ForeColor = Color.FromArgb(0, 51, 102);

            // show & move indicator
            indicator.Visible = true;
            indicator.Height = activeButton.Height;
            indicator.Top = activeButton.Top;
            indicator.Left = 0;
        }

        private void button_dashboard_Click(object sender, EventArgs e)
        {
            ActivateButton(button_dashboard);
            // show dashboard and hide this form
            var dashboard = new Laundry_Attendant_Dashboard();
            dashboard.Show();
            this.Hide();
        }

        private void button_customers_Click(object sender, EventArgs e)
        {
            ActivateButton(button_customers);
            var customers = new Laundry_Attendant_CustomersForm();
            customers.Show();
            this.Hide();
        }

        private void button_status_Click(object sender, EventArgs e)
        {
            ActivateButton(button_status);
            var status = new laundry_attendant_status();
            status.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ActivateButton(button3);
            var messages = new laundry_attendant_messages();
            messages.Show();
            this.Hide();
        }

        private void button_feedback_Click(object sender, EventArgs e)
        {
            ActivateButton(button_feedback);
            var feedback = new laundry_attendant_feedback();
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

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}
