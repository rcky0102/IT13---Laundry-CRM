using IT13___Laundry_CRM.Models;
using IT13___Laundry_CRM.Repositories;
using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
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

            MakeRounded(flowlayoutpanel_status);
            MakeRounded(panel3);
            MakeRounded(label_welcome);
            MakeRounded(label1);
            MakeRounded(pictureBox1);
        }

        private void customer_status_Load(object sender, EventArgs e)
        {
            LoadMyStatuses();
            ShowWelcomeMessage();
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
                    Font = new Font("Gadugi", 12, FontStyle.Bold),
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
                        Font = new Font("Gadugi", 9, FontStyle.Bold),
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
            panel3.Controls.Clear();
            panel3.AutoScroll = true; // Enable scrolling if content overflows

            int y = 10; // Starting Y position

            // Latest notifications at the top
            foreach (var s in allStatuses.OrderByDescending(x => x.created_at))
            {
                // Card panel
                var card = new Panel
                {
                    Width = panel3.Width - 20,
                    Height = 70,
                    BackColor = Color.FromArgb(245, 245, 245),
                    Location = new Point(10, y)
                };
                MakeRounded(card, 15);

                // Panel for timestamp (date + time) on the left
                var timePanel = new Panel
                {
                    Width = 100,
                    Height = card.Height,
                    Location = new Point(10, 0)
                };

                var lblTime = new Label
                {
                    AutoSize = false,
                    Width = timePanel.Width,
                    Height = 25,
                    Text = s.created_at.ToString("h:mm tt"), // e.g., 1:00 PM
                    Font = new Font("Gadugi", 9, FontStyle.Italic),
                    ForeColor = Color.Gray,
                    TextAlign = ContentAlignment.MiddleLeft,
                    Location = new Point(0, 5)
                };

                var lblDate = new Label
                {
                    AutoSize = false,
                    Width = timePanel.Width,
                    Height = 20,
                    Text = s.created_at.ToString("MMM dd, yyyy"), // e.g., Oct 13, 2025
                    Font = new Font("Gadugi", 8, FontStyle.Italic),
                    ForeColor = Color.Gray,
                    TextAlign = ContentAlignment.MiddleLeft,
                    Location = new Point(0, lblTime.Bottom + 2)
                };

                timePanel.Controls.Add(lblTime);
                timePanel.Controls.Add(lblDate);
                card.Controls.Add(timePanel);

                // Status text on the right
                var lblStatus = new Label
                {
                    AutoSize = false,
                    Width = card.Width - timePanel.Width - 30,
                    Height = card.Height - 10,
                    Text = s.status,
                    Font = new Font("Gadugi", 10, FontStyle.Regular),
                    ForeColor = Color.Black,
                    Location = new Point(timePanel.Right + 10, 10),
                    TextAlign = ContentAlignment.MiddleLeft
                };

                card.Controls.Add(lblStatus);

                // Hover effect
                card.MouseEnter += (s1, e1) => card.BackColor = Color.FromArgb(220, 220, 220);
                card.MouseLeave += (s1, e1) => card.BackColor = Color.FromArgb(245, 245, 245);

                panel3.Controls.Add(card);

                y += card.Height + 10; // Space for next notification
            }
        }

    }
}