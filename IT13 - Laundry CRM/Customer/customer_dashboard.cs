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


        public customer_dashboard()
        {
            InitializeComponent();

        }

        private void customer_dashboard_Load(object sender, EventArgs e)
        {
            LoadLatestStatus();
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

        private void LoadLatestStatus()
        {
            if (User.CurrentUser.User == null) return;

            var statuses = statusRepository.GetStatusesByUserId(User.CurrentUser.UserId);

            var latest = statuses.FirstOrDefault();
            if (latest != null)
            {
                string fullName = $"{latest.User.first_name} {(string.IsNullOrEmpty(latest.User.middle_name) ? "" : latest.User.middle_name + " ")}{latest.User.last_name}";
                label_status.Text = $"Status: {latest.status}\nDate: {latest.created_at:g}";
            }
            else
            {
                label_status.Text = "No status available yet.";
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
