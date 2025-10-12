using IT13___Laundry_CRM.Admin;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;
using static IT13___Laundry_CRM.Models.User;

namespace IT13___Laundry_CRM
{
    public partial class SIdebarTemplate : Form
    {
        private Button activeButton;                 // Currently active button
        private Panel indicator;                     // Left indicator bar
        public static string LastActiveButtonName;  // Remember last active button across forms

        public SIdebarTemplate()
        {
            InitializeComponent();
        }

        private void SIdebarTemplate_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            // Circle profile pic
            var path = new GraphicsPath();
            path.AddEllipse(0, 0, profile.Width, profile.Height);
            profile.Region = new Region(path);

            // Create indicator panel
            indicator = new Panel
            {
                Size = new Size(6, button1.Height),
                BackColor = Color.White,
                Visible = false,
                Location = new Point(0, button1.Top)
            };
            panel1.Controls.Add(indicator);
            indicator.BringToFront();

            // Initialize button styles
            foreach (Control c in panel1.Controls)
            {
                if (c is Button btn)
                {
                    btn.BackColor = panel1.BackColor;
                    btn.ForeColor = Color.White;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;
                    btn.UseVisualStyleBackColor = false;
                }
            }

            // Restore last active button
            if (!string.IsNullOrEmpty(LastActiveButtonName))
            {
                var found = panel1.Controls.Find(LastActiveButtonName, true);
                if (found.Length > 0 && found[0] is Button saved)
                    ActivateButton(saved);
            }
            else
            {
                ActivateButton(button1); // Default dashboard
            }
        }

        private void ActivateButton(Button clickedButton)
        {
            // Reset previous
            if (activeButton != null)
            {
                activeButton.BackColor = panel1.BackColor;
                activeButton.ForeColor = Color.White;
            }

            // Set new active
            activeButton = clickedButton;
            LastActiveButtonName = clickedButton.Name;

            activeButton.BackColor = Color.White;
            activeButton.ForeColor = Color.RoyalBlue;

            // Move indicator
            indicator.Visible = true;
            indicator.Height = activeButton.Height;
            indicator.Top = activeButton.Top;
            indicator.Left = 0;
        }

        private void OpenForm(Form form, Button clickedButton)
        {
            ActivateButton(clickedButton);
            form.Show();
            this.Hide();
        }

        // --- NAVIGATION BUTTONS ---

        private void button1_Click(object sender, EventArgs e)
        {
            OpenForm(new AdminForm(), button1);
        }

        private void button_users_Click(object sender, EventArgs e)
        {
            OpenForm(new admin_user(), button_users);
        }

        private void button_messages_Click(object sender, EventArgs e)
        {
            OpenForm(new admin_messages(), button_messages);
        }

        private void button_feedback_Click(object sender, EventArgs e)
        {
            OpenForm(new admin_feedback(), button_feedback);
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            OpenForm(new admin_reports(), button2);
        }

        // Profile click
        private void profile_Click(object sender, EventArgs e)
        {
            contextmenustrip_profile.Show(profile, 0, profile.Height);
        }

        // Logout
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
    }
}
