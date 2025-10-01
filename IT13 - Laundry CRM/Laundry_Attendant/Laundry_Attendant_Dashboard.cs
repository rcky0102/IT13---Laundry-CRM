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
        public Laundry_Attendant_Dashboard()
        {
            InitializeComponent();
        }

        private void Laundry_Attendant_Dashboard_Load(object sender, EventArgs e)
        {
            LoadStatusCounts();
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

        private void LoadStatusCounts()
        {
            var counts = statusRepository.GetStatusCounts();

            label_pending.Text = $"Pending: {counts.GetValueOrDefault("Pending", 0)}";
            label_washing.Text = $"Washing: {counts.GetValueOrDefault("Washing", 0)}";
            label_drying.Text = $"Drying: {counts.GetValueOrDefault("Drying", 0)}";
            label_ironing.Text = $"Ironing/Folding: {counts.GetValueOrDefault("Ironing/Folding", 0)}";
            label_ready.Text = $"Ready for Pickup: {counts.GetValueOrDefault("Ready for Pickup", 0)}";
            label_completed.Text = $"Completed/Picked Up: {counts.GetValueOrDefault("Completed/Picked Up", 0)}";
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
    }
}
