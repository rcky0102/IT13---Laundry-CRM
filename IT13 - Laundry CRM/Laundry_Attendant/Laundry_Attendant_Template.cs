using IT13___Laundry_CRM.Customer;
using IT13___Laundry_CRM.Laundry_Attendant;
using IT13___Laundry_CRM.Repositories;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using static IT13___Laundry_CRM.Models.User;

namespace IT13___Laundry_CRM
{
    public partial class Laundry_Attendant_Template : Form
    {
        private readonly MessageRepository messageRepository = new MessageRepository();

        private Button activeButton;                // currently active button
        private Panel indicator;                    // small moving indicator on the left
        public static string LastActiveButtonName;  // persists last active when hiding/showing

        private Panel panelNotifications;
        private bool notifPanelVisible = false;

        public Laundry_Attendant_Template()
        {
            InitializeComponent();
        }

        private void Laundry_Attendant_Template_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            SetupNotificationPanel();

            // create the indicator panel
            indicator = new Panel();
            indicator.Size = new Size(6, button_dashboard.Height);
            indicator.BackColor = Color.White;
            indicator.Visible = false;
            indicator.Location = new Point(0, button_dashboard.Top);
            panel1.Controls.Add(indicator);
            indicator.BringToFront();

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


        private void panel3_Paint(object sender, PaintEventArgs e)
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_logout_Click_1(object sender, EventArgs e)
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
