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
using System.Windows.Forms.DataVisualization.Charting;

namespace IT13___Laundry_CRM
{
    public partial class AdminForm : SIdebarTemplate
    {
        private readonly FeedbackRepository feedbackRepository = new FeedbackRepository();
        private readonly MessageRepository messageRepository = new MessageRepository();
        private readonly UserRepository userRepository = new UserRepository();

        public AdminForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button_laundry_attendant_Click(object sender, EventArgs e)
        {
            //UserForm userform = new UserForm();
            //userform.Show();

            //this.Hide();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            LoadLatestFeedback();
            LoadLatestMessageSender();

            ShowCustomerCounts("Day", dateTimePickerFrom.Value.Date, dateTimePickerTo.Value.Date);


            comboBoxGrouping.Items.AddRange(new string[] { "Day", "Week", "Month" });
            comboBoxGrouping.SelectedIndex = 0;

        }


        private void LoadLatestFeedback()
        {
            var latestFeedback = feedbackRepository.GetLatestFeedback();

            if (latestFeedback != null)
            {
                string fullName = $"{latestFeedback.User.first_name} {(string.IsNullOrEmpty(latestFeedback.User.middle_name) ? "" : latestFeedback.User.middle_name + " ")}{latestFeedback.User.last_name}";

                label_feedback.Text = $"Latest Feedback from {fullName}\n" +
                                      $"Subject: {latestFeedback.subject}\n" +
                                      $"Message: {latestFeedback.feedback}\n" +
                                      $"Date: {latestFeedback.created_at:g}";
            }
            else
            {
                label_feedback.Text = "No feedback available yet.";
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


        public void ShowCustomerCounts(string groupBy, DateTime from, DateTime to)
        {
            List<User> customers = userRepository.GetUsers()
                .Where(u => u.role.Equals("customer", StringComparison.OrdinalIgnoreCase))
                .ToList();

            // Filter by date range
            customers = customers.Where(c => c.created_at >= from && c.created_at <= to.AddDays(1).AddSeconds(-1)).ToList();

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

            // Build text-based "graph"
            string displayText = "";
            foreach (var kvp in groupedData)
            {
                displayText += $"{kvp.Key}: {new string('█', kvp.Value)} ({kvp.Value})\n";
            }

            labelCustomerGraph.Text = displayText;
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
