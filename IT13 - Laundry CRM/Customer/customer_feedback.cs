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
using static IT13___Laundry_CRM.Models.User;
using Feedback = IT13___Laundry_CRM.Models.Feedback;

namespace IT13___Laundry_CRM.Customer
{
    public partial class customer_feedback : customer_template
    {
        private readonly FeedbackRepository feedbackRepository = new FeedbackRepository();

        private List<Feedback> currentFeedbacks = new List<Feedback>();

        public customer_feedback()
        {
            InitializeComponent();
            LoadFeedbacks();
        }

        private void LoadFeedbacks()
        {
            try
            {
                currentFeedbacks = feedbackRepository.GetFeedbacksByUser(CurrentUser.UserId);

                listbox_feedback.Items.Clear();

                foreach (var fb in currentFeedbacks)
                {
                    string user = fb.User != null
                        ? $"{fb.User.first_name} {fb.User.last_name}"
                        : $"User {fb.user_id}";

                    listbox_feedback.Items.Add(
                        $"[{fb.created_at:MM/dd/yyyy HH:mm}] {user}: {fb.subject} → {fb.feedback}"
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading feedback: " + ex.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void customer_feedback_Load(object sender, EventArgs e)
        {

        }

        private void button_send_Click(object sender, EventArgs e)
        {
            try
            {
                string subject = textbox_subject.Text.Trim();
                string feedbackText = textbox_feedback.Text.Trim();

                if (string.IsNullOrEmpty(subject))
                {
                    MessageBox.Show("Please enter a subject.", "Warning",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrEmpty(feedbackText))
                {
                    MessageBox.Show("Please enter your feedback.", "Warning",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Feedback feedback = new Feedback
                {
                    user_id = CurrentUser.UserId,
                    subject = subject,
                    feedback = feedbackText,
                    created_at = DateTime.Now,
                    updated_at = DateTime.Now
                };

                bool success = feedbackRepository.AddFeedback(feedback);

                if (success)
                {
                    MessageBox.Show("Feedback sent successfully to all laundry attendants and admin!",
                                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    textbox_subject.Clear();
                    textbox_feedback.Clear();
                    LoadFeedbacks();
                }
                else
                {
                    MessageBox.Show("Failed to send feedback.", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error sending feedback: " + ex.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_edit_Click(object sender, EventArgs e)
        {

        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (listbox_feedback.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select a feedback to delete.", "Warning",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var selectedFeedback = currentFeedbacks[listbox_feedback.SelectedIndex];

                if (selectedFeedback.user_id != CurrentUser.UserId)
                {
                    MessageBox.Show("You can only delete your own feedback.", "Warning",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var confirm = MessageBox.Show("Are you sure you want to delete this feedback?",
                                              "Confirm Delete",
                                              MessageBoxButtons.YesNo,
                                              MessageBoxIcon.Question);

                if (confirm == DialogResult.Yes)
                {
                    bool success = feedbackRepository.DeleteFeedback(selectedFeedback.feedback_id);

                    if (success)
                    {
                        MessageBox.Show("Feedback deleted successfully!", "Success",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadFeedbacks();
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete feedback.", "Error",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting feedback: " + ex.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

