using IT13___Laundry_CRM.Admin;
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
    public partial class SIdebarTemplate : Form
    {
        private readonly MessageRepository messageRepository = new MessageRepository();

        private Panel panelNotifications;
        private bool notifPanelVisible = false;

        public SIdebarTemplate()
        {
            InitializeComponent();
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void button_users_Click(object sender, EventArgs e)
        {
            admin_user user = new admin_user();
            user.Show();

            this.Hide();
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


        private void SIdebarTemplate_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            SetupNotificationPanel();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminForm adminForm = new AdminForm();
            adminForm.Show();

            this.Hide();
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            admin_reports reports = new admin_reports();
            reports.Show();

            this.Hide();
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

        private void SetupNotificationPanel()
        {
            panelNotifications = new Panel
            {
                Size = new Size(300, 120),
                BackColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle,
                Visible = false
            };

            MakeRounded(panelNotifications, 15);
            this.Controls.Add(panelNotifications);

            panelNotifications.Location = new Point(button_notif.Right - panelNotifications.Width, button_notif.Bottom + 5);
        }

        private void MakeRounded(Control control, int radius = 20)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(new Rectangle(0, 0, radius, radius), 180, 90);
            path.AddArc(new Rectangle(control.Width - radius, 0, radius, radius), 270, 90);
            path.AddArc(new Rectangle(control.Width - radius, control.Height - radius, radius, radius), 0, 90);
            path.AddArc(new Rectangle(0, control.Height - radius, radius, radius), 90, 90);
            path.CloseFigure();

            control.Region = new Region(path);
            control.SizeChanged += (s, e) => MakeRounded(control, radius);
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
                    Size = new Size(panelNotifications.Width - 2, 80),
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
                    Font = new Font("Cascadia Code", 12),
                    Location = new Point(padding, 10),
                    Width = panelNotifications.Width - 40,
                    Height = 50,
                    ScrollBars = RichTextBoxScrollBars.None
                };

                lblMessage.AppendText("📩 Latest message from:\n");
                lblMessage.SelectionFont = new Font("Cascadia Code", 11, FontStyle.Bold);
                lblMessage.AppendText(fullName);

                messagePanel.Controls.Add(lblMessage);

                messagePanel.Click += (s, e) =>
                {
                    customer_messages msg = new customer_messages();
                    msg.Show();
                    this.Hide();
                };

                panelNotifications.Controls.Add(messagePanel);
                yOffset += messagePanel.Height + 10;
            }

            // --- Latest Laundry Status ---
            //var statuses = statusRepository.GetStatusesByUserId(CurrentUser.User.user_id);
            //var latestStatus = statuses.FirstOrDefault();

            //if (latestStatus != null)
            //{
            //    Panel statusPanel = new Panel
            //    {
            //        Size = new Size(panelNotifications.Width - 2, 120),
            //        Location = new Point(1, yOffset),
            //        BackColor = Color.White,
            //        Cursor = Cursors.Hand
            //    };

            //    statusPanel.MouseEnter += (s, e) => statusPanel.BackColor = Color.FromArgb(230, 240, 255);
            //    statusPanel.MouseLeave += (s, e) => statusPanel.BackColor = Color.White;

            //    RichTextBox lblStatus = new RichTextBox
            //    {
            //        ReadOnly = true,
            //        BorderStyle = BorderStyle.None,
            //        BackColor = this.BackColor,
            //        Font = new Font("Cascadia Code", 10),
            //        Location = new Point(padding, 15),
            //        Width = 380,
            //        Height = 60
            //    };

            //    lblStatus.Text = $"🧺 Laundry Status Update:\n{latestStatus.status}\nDate: {latestStatus.created_at:g}";
            //    statusPanel.Controls.Add(lblStatus);

            //    statusPanel.Click += (s, e) =>
            //    {
            //        customer_status status = new customer_status();
            //        status.Show();
            //        this.Hide();
            //    };

            //    panelNotifications.Controls.Add(statusPanel);
            //    yOffset += statusPanel.Height + 10;
            //}

            panelNotifications.Height = Math.Min(yOffset + 10, 400);
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
