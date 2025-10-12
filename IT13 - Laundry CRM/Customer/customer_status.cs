using IT13___Laundry_CRM.Repositories;
using IT13___Laundry_CRM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace IT13___Laundry_CRM.Customer
{
    public partial class customer_status : customer_template
    {
        private readonly StatusRepository statusRepository = new StatusRepository();

        private readonly string[] stages =
        {
            "Pending", "Washing", "Drying", "Ironing/Folding", "Ready for Pickup", "Completed/Picked Up"
        };

        public customer_status()
        {
            InitializeComponent();
        }

        private void customer_status_Load(object sender, EventArgs e)
        {
            LoadMyStatuses();
            ShowWelcomeMessage();
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
            if (currentUserId == 0) return;

            // Clear panels
            flowlayoutpanel_status.Controls.Clear();
            panel3.Controls.Clear();

            // Get data
            var history = statusRepository.GetStatusHistoryByUserId(currentUserId);
            var currentStatuses = statusRepository.GetStatusesByUserId(currentUserId);

            // Merge and sort
            var allStatuses = history.Select(h => (h.created_at, h.status))
                                   .Concat(currentStatuses.Select(s => (s.created_at, s.status)))
                                   .OrderBy(a => a.created_at)
                                   .ToList();

            string latestStatus = allStatuses.LastOrDefault().status ?? "Pending";
            bool isCancelled = latestStatus == "Cancelled";
            bool isOnHold = latestStatus == "On Hold";

            CreateTimeline(latestStatus, isCancelled, isOnHold);
            CreateHistory(allStatuses);
        }

        private void CreateTimeline(string latestStatus, bool isCancelled, bool isOnHold)
        {
            if (isCancelled || isOnHold)
            {
                var special = new Label
                {
                    AutoSize = false,
                    Width = 300,
                    Height = 50,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Font = new Font("Segoe UI", 12, FontStyle.Bold),
                    ForeColor = Color.White,
                    Margin = new Padding(10),
                    Text = isCancelled ? "❌ Laundry Cancelled" : "⏸ Laundry On Hold",
                    BackColor = isCancelled ? Color.Firebrick : Color.DarkOrange
                };
                flowlayoutpanel_status.Controls.Add(special);
            }
            else
            {
                int currentStageIndex = Array.IndexOf(stages, latestStatus);
                if (currentStageIndex == -1) currentStageIndex = 0;

                for (int i = 0; i < stages.Length; i++)
                {
                    // Stage panel
                    var stagePanel = new Panel { Width = 120, Height = 80, Margin = new Padding(0) };

                    // Stage label
                    var lbl = new Label
                    {
                        Text = stages[i],
                        TextAlign = ContentAlignment.MiddleCenter,
                        Dock = DockStyle.Top,
                        Font = new Font("Segoe UI", 9, FontStyle.Bold),
                        Height = 25
                    };

                    // Status circle
                    var circle = new Label
                    {
                        Width = 25,
                        Height = 25,
                        TextAlign = ContentAlignment.MiddleCenter,
                        Font = new Font("Segoe UI Emoji", 12),
                        Top = 35,
                        Left = 47
                    };

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
                    flowlayoutpanel_status.Controls.Add(stagePanel);

                    // Connector
                    if (i < stages.Length - 1)
                    {
                        var connector = new Label
                        {
                            AutoSize = false,
                            Width = 40,
                            Height = 2,
                            BackColor = (i < currentStageIndex) ? Color.SeaGreen : Color.LightGray,
                            Margin = new Padding(0, 25, 0, 0)
                        };
                        flowlayoutpanel_status.Controls.Add(connector);
                    }
                }
            }
        }

        private void CreateHistory(List<(DateTime created_at, string status)> allStatuses)
        {
            var historyTitle = new Label
            {
                Text = "🕒 Status History",
                Font = new Font("Cascadia Code", 11, FontStyle.Bold),
                AutoSize = true,
                Location = new Point(10, 10),
                ForeColor = Color.Black
            };
            panel3.Controls.Add(historyTitle);

            int y = 40;
            foreach (var s in allStatuses)
            {
                var lbl = new Label
                {
                    AutoSize = false,
                    Width = panel3.Width - 40,
                    Height = 25,
                    Text = $"{s.created_at:G}  →  {s.status}",
                    Font = new Font("Cascadia Code", 9),
                    ForeColor = Color.Black,
                    Location = new Point(10, y)
                };
                panel3.Controls.Add(lbl);
                y += 30;
            }
        }
    }
}