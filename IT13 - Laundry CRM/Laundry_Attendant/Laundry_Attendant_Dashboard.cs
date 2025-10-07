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

            ShowCustomerCounts("Day", dateTimePickerFrom.Value.Date, dateTimePickerTo.Value.Date);


            comboBoxGrouping.Items.AddRange(new string[] { "Day", "Week", "Month" });
            comboBoxGrouping.SelectedIndex = 0;
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
