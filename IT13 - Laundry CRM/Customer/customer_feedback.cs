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

            listbox_feedback.SelectedIndexChanged += listbox_feedback_SelectedIndexChanged;
        }

        private void LoadFeedbacks()
        {
            try
            {
                // Get feedbacks for the current logged-in user
                currentFeedbacks = feedbackRepository.GetFeedbacksByUser(CurrentUser.UserId);

                listbox_feedback.Items.Clear();

                if (currentFeedbacks.Count == 0)
                {
                    listbox_feedback.Items.Add("No feedback found.");
                    return;
                }

                foreach (var fb in currentFeedbacks)
                {
                    string user = fb.User != null
                        ? $"{fb.User.first_name} {fb.User.last_name}"
                        : $"User {fb.user_id}";

                    // Display summary info only (subject, sender, date)
                    listbox_feedback.Items.Add($"📌 {fb.subject} — by {user} ({fb.created_at:MMM dd, yyyy})");
                }

                // Attach event handler if not already attached
                listbox_feedback.SelectedIndexChanged -= listbox_feedback_SelectedIndexChanged;
                listbox_feedback.SelectedIndexChanged += listbox_feedback_SelectedIndexChanged;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading feedback: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void listbox_feedback_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listbox_feedback.SelectedIndex;
            if (index < 0 || index >= currentFeedbacks.Count)
                return;

            var selectedFeedback = currentFeedbacks[index];

            using (var detailsForm = new FeedbackDetailsForm(selectedFeedback))
            {
                detailsForm.ShowDialog();
            }

            // 👇 Clear the selection to prevent re-triggering
            listbox_feedback.ClearSelected();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }

    public class FeedbackDetailsForm : Form
    {
        public FeedbackDetailsForm(Feedback feedback)
        {
            this.Text = "Feedback Details";
            this.Size = new Size(700, 600);
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.BackColor = Color.White;

            Label lblSubject = new Label()
            {
                Text = $"📌 Subject: {feedback.subject}",
                Font = new Font("Cascadia Code", 11, FontStyle.Bold),
                Dock = DockStyle.Top,
                Height = 50,
                Padding = new Padding(10)
            };

            string user = feedback.User != null
                ? $"{feedback.User.first_name} {feedback.User.last_name}"
                : $"User {feedback.user_id}";

            Label lblUser = new Label()
            {
                Text = $"👤 Submitted by: {user}",
                Font = new Font("Cascadia Code", 10, FontStyle.Regular),
                Dock = DockStyle.Top,
                Height = 40,
                Padding = new Padding(10)
            };

            Label lblDate = new Label()
            {
                Text = $"🕒 Date: {feedback.created_at:MMMM dd, yyyy hh:mm tt}",
                Font = new Font("Cascadia Code", 9, FontStyle.Italic),
                Dock = DockStyle.Top,
                Height = 40,
                Padding = new Padding(10)
            };

            TextBox txtFeedback = new TextBox()
            {
                Text = feedback.feedback,
                Multiline = true,
                ReadOnly = true,
                ScrollBars = ScrollBars.Vertical,
                Dock = DockStyle.Fill,
                Font = new Font("Cascadia Code", 10, FontStyle.Regular),
                BackColor = Color.WhiteSmoke,
                ForeColor = Color.Black,
                Padding = new Padding(10)
            };

            //Button btnClose = new Button()
            //{
            //    Text = "Close",
            //    Dock = DockStyle.Bottom,
            //    Height = 40,
            //    Font = new Font("Cascadia Code", 10, FontStyle.Bold),
            //    BackColor = Color.FromArgb(52, 152, 219),
            //    ForeColor = Color.White,
            //    FlatStyle = FlatStyle.Flat
            //};
            //btnClose.Click += (s, e) => this.Close();

            this.Controls.Add(txtFeedback);
            //this.Controls.Add(btnClose);
            this.Controls.Add(lblDate);
            this.Controls.Add(lblUser);
            this.Controls.Add(lblSubject);
        }
    }
}

