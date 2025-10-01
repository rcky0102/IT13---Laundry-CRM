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
    public partial class AdminForm : SIdebarTemplate
    {
        private readonly FeedbackRepository feedbackRepository = new FeedbackRepository();
        private readonly MessageRepository messageRepository = new MessageRepository();

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
    }
}
