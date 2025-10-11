using IT13___Laundry_CRM.Customer;
using IT13___Laundry_CRM.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static IT13___Laundry_CRM.Models.User;

namespace IT13___Laundry_CRM
{
    public partial class customer_template : Form
    {

        private readonly UserRepository userRepository = new UserRepository();
        private readonly StatusRepository statusRepository = new StatusRepository();
        private readonly MessageRepository messageRepository = new MessageRepository();

        private Panel panelNotifications;
        private bool notifPanelVisible = false;

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


        private void button_dashboard_Click(object sender, EventArgs e)
        {
            customer_dashboard dashboard = new customer_dashboard();
            dashboard.Show();

            this.Hide();
        }

        private void customer_template_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            SetupNotificationPanel();
        }

        private void button_profile_Resize(object sender, EventArgs e)
        {

        }

        private void button_notif_Click(object sender, EventArgs e)
        {
            notifPanelVisible = !notifPanelVisible;

            if (notifPanelVisible)
            {
                PopulateNotifications();
                panelNotifications.BringToFront();
                panelNotifications.Visible = true;
            }
            else
            {
                panelNotifications.Visible = false;
            }
        }

        private void PopulateNotifications()
        {
            if (CurrentUser.User == null || panelNotifications == null) return;

            panelNotifications.Controls.Clear();

            int padding = 15;
            int yOffset = 0;

            // --- Latest Message ---
            var latestMessage = messageRepository.GetLatestMessageForUser(CurrentUser.User.user_id);
            if (latestMessage != null && latestMessage.User != null)
            {
                string fullName = $"{latestMessage.User.first_name} " +
                                  $"{(string.IsNullOrEmpty(latestMessage.User.middle_name) ? "" : latestMessage.User.middle_name + " ")}" +
                                  $"{latestMessage.User.last_name}";

                Panel messagePanel = new Panel
                {
                    Size = new Size(panelNotifications.Width - 2, 80), // bigger card
                    Location = new Point(1, yOffset),
                    BackColor = Color.White,
                    Cursor = Cursors.Hand
                };

                messagePanel.MouseEnter += (s, e) => messagePanel.BackColor = Color.FromArgb(230, 240, 255);
                messagePanel.MouseLeave += (s, e) => messagePanel.BackColor = Color.White;

                RichTextBox lblMessage = new RichTextBox
                {
                    BorderStyle = BorderStyle.None,
                    BackColor = Color.White,
                    ReadOnly = true,
                    Font = new Font("Cascadia Code", 14),
                    Location = new Point(padding, 10),
                    Width = panelNotifications.Width - 40,
                    Height = 50,
                    ScrollBars = RichTextBoxScrollBars.None
                };

                // Add regular text
                lblMessage.AppendText("📩 Latest message from:\n");

                // Apply bold style for fullName
                lblMessage.SelectionFont = new Font("Cascadia Code", 12, FontStyle.Bold);
                lblMessage.AppendText(fullName);

                // Reset style
                lblMessage.SelectionFont = new Font("Cascadia Code", 10, FontStyle.Regular);

                messagePanel.Controls.Add(lblMessage);

                messagePanel.Click += (s, e) =>
                {
                    MessageBox.Show($"Open messages from {fullName}");
                    customer_messages message = new customer_messages();
                    message.Show();

                    this.Hide();
                };

                panelNotifications.Controls.Add(messagePanel);
                yOffset += messagePanel.Height + 10; // spacing
            }

            // --- Latest Laundry Status ---
            var statuses = statusRepository.GetStatusesByUserId(CurrentUser.User.user_id);
            var latestStatus = statuses.FirstOrDefault();

            if (latestStatus != null)
            {
                string fullName = $"{latestStatus.User.first_name} " +
                                  $"{(string.IsNullOrEmpty(latestStatus.User.middle_name) ? "" : latestStatus.User.middle_name + " ")}" +
                                  $"{latestStatus.User.last_name}";

                Panel statusPanel = new Panel
                {
                    Size = new Size(panelNotifications.Width - 2, 120), // bigger card for laundry info
                    Location = new Point(1, yOffset),
                    BackColor = Color.White,
                    Cursor = Cursors.Hand
                };

                statusPanel.MouseEnter += (s, e) => statusPanel.BackColor = Color.FromArgb(230, 240, 255);
                statusPanel.MouseLeave += (s, e) => statusPanel.BackColor = Color.White;

                RichTextBox lblStatus = new RichTextBox
                {
                    ReadOnly = true,
                    BorderStyle = BorderStyle.None,
                    BackColor = this.BackColor,
                    Font = new Font("Cascadia Code", 10),
                    Location = new Point(padding, 15),
                    Width = 380,
                    Height = 60
                };

                lblStatus.Text = $"🧺 Laundry Status Update:\n{latestStatus.status}\nDate: {latestStatus.created_at:g}";

                // Apply bold only to the status line
                int start = lblStatus.Text.IndexOf(latestStatus.status);
                if (start >= 0)
                {
                    lblStatus.Select(start, latestStatus.status.Length);
                    lblStatus.SelectionFont = new Font("Cascadia Code", 10, FontStyle.Bold);
                }

                lblStatus.Select(0, 0); // reset selection
                panelNotifications.Controls.Add(lblStatus);

                statusPanel.Controls.Add(lblStatus);

                statusPanel.Click += (s, e) =>
                {
                    MessageBox.Show($"View full laundry status");
                    customer_status status = new customer_status();
                    status.Show();

                    this.Hide();
                };

                panelNotifications.Controls.Add(statusPanel);
                yOffset += statusPanel.Height + 10;
            }

            // Adjust panel height dynamically to fit content
            panelNotifications.Height = Math.Min(yOffset + 10, 400); // make panel bigger
        }



        private void SetupNotificationPanel()
        {
            panelNotifications = new Panel
            {
                Size = new Size(300, 120), // Adjust height for message + status
                BackColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle,
                Visible = false
            };

            MakeRounded(panelNotifications, 15);
            this.Controls.Add(panelNotifications);

            // Position near notification button
            panelNotifications.Location = new Point(button_notif.Right - panelNotifications.Width, button_notif.Bottom + 5);
        }

        private void MakeRounded(Control control, int radius = 20)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(new Rectangle(0, 0, radius, radius), 180, 90); // Top-left
            path.AddArc(new Rectangle(control.Width - radius, 0, radius, radius), 270, 90); // Top-right
            path.AddArc(new Rectangle(control.Width - radius, control.Height - radius, radius, radius), 0, 90); // Bottom-right
            path.AddArc(new Rectangle(0, control.Height - radius, radius, radius), 90, 90); // Bottom-left
            path.CloseFigure();

            control.Region = new Region(path);

            // Optional: handle resizing to keep corners rounded
            control.SizeChanged += (s, e) => MakeRounded(control, radius);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button_profile_Click(object sender, EventArgs e)
        {
            customer_profile profile = new customer_profile();
            profile.ShowDialog();

        }

        private void button_logout_Click(object sender, EventArgs e)
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
