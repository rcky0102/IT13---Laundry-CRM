using IT13___Laundry_CRM.Models;
using IT13___Laundry_CRM.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
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

            MakeRounded(textbox_subject);
            MakeRounded(textbox_feedback);
            MakeRounded(button_send);
            MakeRounded(button_send);
            MakeRounded(listbox_feedback);
            MakeRounded(label5);
            MakeRounded(label6);
            MakeRounded(label1);

            listbox_feedback.DrawMode = DrawMode.OwnerDrawFixed;
            listbox_feedback.ItemHeight = 50; // Adjust based on font size
            listbox_feedback.BorderStyle = BorderStyle.None; // Rounded corners handled separately
            listbox_feedback.DrawItem += listbox_feedback_DrawItem;
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

        private void listbox_feedback_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0 || e.Index >= currentFeedbacks.Count) return;

            e.DrawBackground();
            Feedback fb = currentFeedbacks[e.Index];

            Graphics g = e.Graphics;
            Rectangle bounds = e.Bounds;
            bool isSelected = (e.State & DrawItemState.Selected) == DrawItemState.Selected;

            int padding = 10;

            // Background
            Color backColor = isSelected ? Color.FromArgb(52, 152, 219) : Color.White;
            using (SolidBrush bgBrush = new SolidBrush(backColor))
            {
                g.FillRectangle(bgBrush, bounds);
            }

            // Subject (acts as "Name") - bold, larger font
            using (Font subjectFont = new Font("Cascadia Code", 10, FontStyle.Bold))
            using (SolidBrush subjectBrush = new SolidBrush(isSelected ? Color.White : Color.Black))
            {
                g.DrawString(fb.subject, subjectFont, subjectBrush, bounds.Left + padding, bounds.Top + 5);
            }

            // Sender and date/time - smaller, gray font
            string user = fb.User != null
                ? $"{fb.User.first_name} {fb.User.last_name}"
                : $"User {fb.user_id}";
            string details = $"by {user} — {fb.created_at:MMM dd, yyyy hh:mm tt}";

            using (Font detailsFont = new Font("Cascadia Code", 8, FontStyle.Italic))
            using (SolidBrush detailsBrush = new SolidBrush(isSelected ? Color.WhiteSmoke : Color.Gray))
            {
                g.DrawString(details, detailsFont, detailsBrush, bounds.Left + padding, bounds.Top + 25);
            }

            // Optional: border around each item
            using (Pen borderPen = new Pen(Color.LightGray, 1))
            {
                Rectangle borderRect = new Rectangle(bounds.Left, bounds.Top, bounds.Width - 1, bounds.Height - 1);
                g.DrawRectangle(borderPen, borderRect);
            }

            e.DrawFocusRectangle();
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

