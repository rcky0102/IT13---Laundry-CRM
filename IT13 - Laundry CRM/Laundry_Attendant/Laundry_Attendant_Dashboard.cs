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
    public partial class Laundry_Attendant_Dashboard : Laundry_Attendant_Template
    {
        private readonly FeedbackRepository feedbackRepository = new FeedbackRepository();
        private readonly StatusRepository statusRepository = new StatusRepository();
        private readonly MessageRepository messageRepository = new MessageRepository();
        private readonly UserRepository userRepository = new UserRepository();

        public Laundry_Attendant_Dashboard()
        {
            InitializeComponent();
        }

        private void Laundry_Attendant_Dashboard_Load(object sender, EventArgs e)
        {
            LoadStatusCounts();
            ShowWelcomeMessage();
            LoadLatestMessageSender();
            LoadLatestFeedback();

            ShowCustomerCounts("Day", dateTimePickerFrom.Value.Date, dateTimePickerTo.Value.Date);


            comboBoxGrouping.Items.AddRange(new string[] { "Day", "Week", "Month" });
            comboBoxGrouping.SelectedIndex = 0;

            // Panel setup (scrollable area)
            panelCustomerGraph.AutoScroll = true;
            panelCustomerGraph.BorderStyle = BorderStyle.FixedSingle;

            // Ensure label is inside panel
            if (labelCustomerGraph.Parent != panelCustomerGraph)
            {
                if (labelCustomerGraph.Parent != null)
                    labelCustomerGraph.Parent.Controls.Remove(labelCustomerGraph);

                panelCustomerGraph.Controls.Add(labelCustomerGraph);
            }

            // Label visual setup
            labelCustomerGraph.AutoSize = true;
            labelCustomerGraph.Location = new Point(6, 6); // Padding inside panel
            labelCustomerGraph.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            labelCustomerGraph.Font = new Font("Consolas", 10, FontStyle.Regular);

            // Set label width relative to the panel
            labelCustomerGraph.MaximumSize = new Size(
                Math.Max(10, panelCustomerGraph.ClientSize.Width - 20), 0
            );

            // Adjust label width dynamically on resize
            panelCustomerGraph.SizeChanged += (s, ev) =>
            {
                labelCustomerGraph.MaximumSize = new Size(
                    Math.Max(10, panelCustomerGraph.ClientSize.Width - 20), 0
                );
                labelCustomerGraph.PerformLayout();
            };

            // Load other data AFTER the layout setup is complete
            LoadLatestFeedback();
            LoadLatestMessageSender();

            // Populate the graph after label/panel are ready
            ShowCustomerCounts("Day", dateTimePickerFrom.Value.Date, dateTimePickerTo.Value.Date);
        }

        private void ShowWelcomeMessage()
        {
            if (User.CurrentUser.User != null)
            {
                label_welcome.Text = $"Welcome, {User.CurrentUser.User.first_name}!";
            }
        }

        private void LoadStatusCounts()
        {
            var counts = statusRepository.GetStatusCounts();

            label_pending.Text = $"Pending: {counts.GetValueOrDefault("Pending", 0)}";
            label_washing.Text = $"Washing: {counts.GetValueOrDefault("Washing", 0)}";
            label_drying.Text = $"Drying: {counts.GetValueOrDefault("Drying", 0)}";
            label_ironing.Text = $"Ironing/Folding: {counts.GetValueOrDefault("Ironing/Folding", 0)}";
            label_ready.Text = $"Ready for Pickup: {counts.GetValueOrDefault("Ready for Pickup", 0)}";
            label_completed.Text = $"Completed: {counts.GetValueOrDefault("Completed/Picked Up", 0)}";
            label_cancelled.Text = $"Cancelled: {counts.GetValueOrDefault("Cancelled", 0)}";
            label_onhold.Text = $"On Hold: {counts.GetValueOrDefault("On Hold", 0)}";
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

        private void LoadLatestFeedback()
        {
            var latestFeedback = feedbackRepository.GetLatestFeedback();

            if (latestFeedback != null)
            {
                string fullName = $"{latestFeedback.User.first_name} {(string.IsNullOrEmpty(latestFeedback.User.middle_name) ? "" : latestFeedback.User.middle_name + " ")}{latestFeedback.User.last_name}";

                label_feedback.Text = $"Latest Feedback from {fullName}\n" +
                                      $"Subject: {latestFeedback.subject}\n" 
                                      //$"Message: {latestFeedback.feedback}\n" +
                                      //$"Date: {latestFeedback.created_at:g}"
                                      ;
            }
            else
            {
                label_feedback.Text = "No feedback available yet.";
            }
        }

        public void ShowCustomerCounts(string groupBy, DateTime from, DateTime to)
        {
            try
            {
                // Retrieve all customers
                List<User> customers = userRepository.GetUsers()
                    .Where(u => u.role.Equals("customer", StringComparison.OrdinalIgnoreCase))
                    .ToList();

                // Filter by date range
                customers = customers
                    .Where(c => c.created_at >= from && c.created_at <= to.AddDays(1).AddSeconds(-1))
                    .ToList();

                // Grouping logic
                Dictionary<string, int> groupedData = new Dictionary<string, int>();

                switch (groupBy)
                {
                    case "Day":
                        groupedData = customers
                            .GroupBy(c => c.created_at.Date)
                            .OrderBy(g => g.Key)
                            .ToDictionary(g => g.Key.ToString("yyyy-MM-dd"), g => g.Count());
                        break;

                    case "Week":
                        groupedData = customers
                            .GroupBy(c => System.Globalization.CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(
                                c.created_at, System.Globalization.CalendarWeekRule.FirstDay, DayOfWeek.Monday))
                            .OrderBy(g => g.Key)
                            .ToDictionary(g => "Week " + g.Key, g => g.Count());
                        break;

                    case "Month":
                        groupedData = customers
                            .GroupBy(c => new { c.created_at.Year, c.created_at.Month })
                            .OrderBy(g => g.Key.Year).ThenBy(g => g.Key.Month)
                            .ToDictionary(g => $"{g.Key.Year}-{g.Key.Month:00}", g => g.Count());
                        break;
                }

                // 🧹 Clear existing items before adding new ones
                panelCustomerGraph.Controls.Clear();

                int yOffset = 10; // Spacing between bars
                int maxBarWidth = panelCustomerGraph.Width - 60; // Padding inside the panel
                int maxValue = groupedData.Count > 0 ? groupedData.Values.Max() : 1; // For scaling

                foreach (var kvp in groupedData)
                {
                    // Create a label for each grouped result (like a horizontal bar)
                    Label barLabel = new Label
                    {
                        AutoSize = false,
                        Width = maxBarWidth,
                        Location = new Point(10, yOffset),
                        BorderStyle = BorderStyle.FixedSingle,
                        Font = new Font("Cascadia Code", 10, FontStyle.Regular),
                        Padding = new Padding(10),
                        BackColor = Color.White,
                        ForeColor = Color.Black,
                        TextAlign = ContentAlignment.MiddleLeft,
                        Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right
                    };

                    // Build the text-based "bar"
                    int scaledLength = (int)((kvp.Value / (double)maxValue) * 30); // Adjust "30" for bar length
                    string bar = new string('█', scaledLength);

                    barLabel.Text = $"{kvp.Key}  |  {bar} ({kvp.Value})";

                    // Measure and auto-adjust height
                    barLabel.Height = TextRenderer.MeasureText(
                        barLabel.Text,
                        barLabel.Font,
                        new Size(barLabel.Width, int.MaxValue),
                        TextFormatFlags.WordBreak
                    ).Height + 30;

                    // Add to panel
                    panelCustomerGraph.Controls.Add(barLabel);

                    // Increment for next item
                    yOffset += barLabel.Height + 10;
                }

                // Scroll always starts at top
                panelCustomerGraph.AutoScrollPosition = new Point(0, 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error displaying customer counts: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonLoadGraph_Click(object sender, EventArgs e)
        {
            if (comboBoxGrouping.SelectedItem == null)
            {
                MessageBox.Show("Please select a grouping option.");
                return;
            }

            string groupBy = comboBoxGrouping.SelectedItem.ToString();
            DateTime from = dateTimePickerFrom.Value.Date;
            DateTime to = dateTimePickerTo.Value.Date;

            ShowCustomerCounts(groupBy, from, to);
        }
    }
}
