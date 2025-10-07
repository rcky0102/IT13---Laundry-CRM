using IT13___Laundry_CRM.Repositories;
using IT13___Laundry_CRM.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IT13___Laundry_CRM
{
    public partial class customer_dashboard : customer_template
    {
        private readonly StatusRepository statusRepository = new StatusRepository();
        private readonly MessageRepository messageRepository = new MessageRepository();

        private readonly string[] stages =
        {
            "Pending",
            "Washing",
            "Drying",
            "Ironing/Folding",
            "Ready for Pickup",
            "Completed/Picked Up"
        };

        // 🧩 Special statuses (non-sequential)
        private readonly string[] specialStatuses =
        {
            "Cancelled",
            "On Hold"
        };


        public customer_dashboard()
        {
            InitializeComponent();

        }

        private void customer_dashboard_Load(object sender, EventArgs e)
        {
            LoadMyStatuses();
            ShowWelcomeMessage();
            LoadLatestMessageSender();
        }

        private void ShowWelcomeMessage()
        {
            if (User.CurrentUser.User != null)
            {
                label_welcome.Text = $"Welcome, {User.CurrentUser.User.first_name}!";
            }
        }

        private void LoadMyStatuses()
        {
            int currentUserId = User.CurrentUser.UserId;

            if (currentUserId == 0)
            {
                MessageBox.Show("No user logged in.");
                return;
            }

            flowlayoutpanel_status.Controls.Clear();

            // 1️⃣ Get status history
            var history = statusRepository.GetStatusHistoryByUserId(currentUserId);

            // 2️⃣ Get current status
            var currentStatuses = statusRepository.GetStatusesByUserId(currentUserId);

            // 3️⃣ Merge them
            var allStatuses = new List<(DateTime created_at, string status)>();
            allStatuses.AddRange(history.Select(h => (h.created_at, h.status)));
            allStatuses.AddRange(currentStatuses.Select(s => (s.created_at, s.status)));

            // Sort by timestamp ascending (oldest first)
            allStatuses = allStatuses.OrderBy(a => a.created_at).ToList();

            // 🎯 Determine latest status
            string latestStatus = allStatuses.LastOrDefault().status ?? "Pending";

            // ✅ Define the timeline stages
            string[] stages = {
                "Pending",
                "Washing",
                "Drying",
                "Ironing/Folding",
                "Ready for Pickup",
                "Completed/Picked Up"
            };

            // Handle special cases
            bool isCancelled = latestStatus == "Cancelled";
            bool isOnHold = latestStatus == "On Hold";

            // Configure panel layout
            flowlayoutpanel_status.AutoScroll = true;
            flowlayoutpanel_status.WrapContents = false;
            flowlayoutpanel_status.FlowDirection = FlowDirection.TopDown;
            flowlayoutpanel_status.Padding = new Padding(15);
            flowlayoutpanel_status.BackColor = Color.White;

            // --- 🔷 TIMELINE PANEL ---
            FlowLayoutPanel timelinePanel = new FlowLayoutPanel();
            timelinePanel.AutoScroll = false;
            timelinePanel.WrapContents = false;
            timelinePanel.FlowDirection = FlowDirection.LeftToRight;
            timelinePanel.Height = 120;
            timelinePanel.Width = flowlayoutpanel_status.Width - 40;
            timelinePanel.Margin = new Padding(0, 0, 0, 15);
            timelinePanel.Padding = new Padding(10);

            // Handle special cases (Cancelled / On Hold)
            if (isCancelled || isOnHold)
            {
                Label special = new Label();
                special.AutoSize = false;
                special.Width = 300;
                special.Height = 50;
                special.TextAlign = ContentAlignment.MiddleCenter;
                special.Font = new Font("Segoe UI", 12, FontStyle.Bold);
                special.ForeColor = Color.White;
                special.Margin = new Padding(10);
                special.Text = isCancelled ? "❌ Laundry Cancelled" : "⏸ Laundry On Hold";
                special.BackColor = isCancelled ? Color.Firebrick : Color.DarkOrange;
                timelinePanel.Controls.Add(special);
                flowlayoutpanel_status.Controls.Add(timelinePanel);
            }
            else
            {
                int currentStageIndex = Array.IndexOf(stages, latestStatus);
                if (currentStageIndex == -1) currentStageIndex = 0;

                for (int i = 0; i < stages.Length; i++)
                {
                    // container for each stage (label + circle)
                    Panel stagePanel = new Panel();
                    stagePanel.Width = 120;
                    stagePanel.Height = 80;
                    stagePanel.Margin = new Padding(0, 0, 0, 0);

                    // label (on top)
                    Label lbl = new Label();
                    lbl.Text = stages[i];
                    lbl.TextAlign = ContentAlignment.MiddleCenter;
                    lbl.Dock = DockStyle.Top;
                    lbl.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                    lbl.Height = 25;

                    // circle/check mark (below)
                    Label circle = new Label();
                    circle.Width = 25;
                    circle.Height = 25;
                    circle.TextAlign = ContentAlignment.MiddleCenter;
                    circle.Font = new Font("Segoe UI Emoji", 12);
                    circle.Top = 35;
                    circle.Left = (stagePanel.Width - circle.Width) / 2;

                    if (i < currentStageIndex)
                    {
                        circle.Text = "✔️";
                        circle.ForeColor = Color.SeaGreen;
                    }
                    else if (i == currentStageIndex)
                    {
                        circle.Text = "●";
                        circle.ForeColor = Color.DodgerBlue;
                    }
                    else
                    {
                        circle.Text = "○";
                        circle.ForeColor = Color.Gray;
                    }

                    stagePanel.Controls.Add(lbl);
                    stagePanel.Controls.Add(circle);

                    // add to timeline
                    timelinePanel.Controls.Add(stagePanel);

                    // connector line (between stages)
                    if (i < stages.Length - 1)
                    {
                        Label connector = new Label();
                        connector.AutoSize = false;
                        connector.Width = 40;
                        connector.Height = 2;
                        connector.BackColor = (i < currentStageIndex) ? Color.SeaGreen : Color.LightGray;
                        connector.Margin = new Padding(0, 25, 0, 0);
                        timelinePanel.Controls.Add(connector);
                    }
                }

                flowlayoutpanel_status.Controls.Add(timelinePanel);
            }
        }

        private void LoadLatestMessageSender()
        {
            if (User.CurrentUser.User == null) return;

            var latestMessage = messageRepository.GetLatestMessageForUser(User.CurrentUser.UserId);

            if (latestMessage != null && latestMessage.User != null)
            {
                string fullName = $"{latestMessage.User.first_name} " +
                                  $"{(string.IsNullOrEmpty(latestMessage.User.middle_name) ? "" : latestMessage.User.middle_name + " ")}" +
                                  $"{latestMessage.User.last_name}";

                label_message.Text = $"Latest message from: {fullName}";
            }
            else
            {
                label_message.Text = "No messages yet.";
            }
        }

        private void Luandry_Status_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
