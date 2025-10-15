using IT13___Laundry_CRM.Laundry_Attendant;
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

namespace IT13___Laundry_CRM.Admin
{
    public partial class admin_feedback : SIdebarTemplate
    {
        private readonly FeedbackRepository feedbackRepository = new FeedbackRepository();

        private List<Feedback> currentFeedbacks = new List<Feedback>();
        private List<Feedback> allFeedbacks = new List<Feedback>();
        private List<Rectangle> archiveButtonBounds = new List<Rectangle>();

        public admin_feedback()
        {
            InitializeComponent();
            LoadFeedbacks();

            listbox_feedback.SelectedIndexChanged += listbox_feedback_SelectedIndexChanged;
            textbox_search.TextChanged += textbox_search_TextChanged;
            listbox_feedback.MouseDown += listbox_feedback_MouseDown;

            MakeRounded(panel4);
            MakeRounded(textbox_search);
            MakeRounded(button_archives);
            MakeRounded(listbox_feedback);

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

        private void LoadFeedbacks(bool archived = false)
        {
            List<Feedback> feedbacks;

            if (CurrentUser.Role == "admin")
                feedbacks = archived
                    ? feedbackRepository.GetArchivedFeedbacks()
                    : feedbackRepository.GetUnarchivedFeedbacks();
            else
                feedbacks = archived
                    ? feedbackRepository.GetArchivedFeedbacksByUser(CurrentUser.UserId)
                    : feedbackRepository.GetUnarchivedFeedbacksByUser(CurrentUser.UserId);

            // Apply search as before
            string searchQuery = textbox_search.Text.Trim().ToLower();
            if (!string.IsNullOrWhiteSpace(searchQuery))
            {
                feedbacks = feedbacks.Where(fb =>
                    (fb.subject ?? "").ToLower().Contains(searchQuery) ||
                    (fb.User?.first_name ?? "").ToLower().Contains(searchQuery) ||
                    (fb.User?.last_name ?? "").ToLower().Contains(searchQuery) ||
                    fb.created_at.ToString("MMMM dd, yyyy").ToLower().Contains(searchQuery) ||
                    fb.created_at.ToString("hh:mm tt").ToLower().Contains(searchQuery)
                ).ToList();
            }

            currentFeedbacks = feedbacks;

            listbox_feedback.Items.Clear();
            archiveButtonBounds.Clear();

            if (currentFeedbacks.Count == 0)
            {
                listbox_feedback.Items.Add("No feedback found.");
                return;
            }

            foreach (var fb in currentFeedbacks)
            {
                string user = fb.User != null ? $"{fb.User.first_name} {fb.User.last_name}" : $"User {fb.user_id}";
                listbox_feedback.Items.Add($"📌 {fb.subject} — by {user} ({fb.created_at:MMM dd, yyyy})");
            }
        }





        private void textbox_search_TextChanged(object sender, EventArgs e)
        {
            string query = textbox_search.Text.Trim().ToLower();

            // If search box is empty, reload all feedbacks
            if (string.IsNullOrWhiteSpace(query))
            {
                LoadFeedbacks();
                return;
            }

            try
            {
                // Filter feedbacks by subject, name, date, or time
                var filtered = currentFeedbacks.Where(fb =>
                    (fb.subject != null && fb.subject.ToLower().Contains(query)) ||
                    (fb.User != null && fb.User.first_name.ToLower().Contains(query)) ||
                    (fb.User != null && fb.User.last_name.ToLower().Contains(query)) ||
                    (fb.created_at.ToString("MMMM dd, yyyy").ToLower().Contains(query)) ||
                    (fb.created_at.ToString("hh:mm tt").ToLower().Contains(query))
                ).ToList();

                listbox_feedback.Items.Clear();

                if (filtered.Count == 0)
                {
                    listbox_feedback.Items.Add("No feedback found.");
                    return;
                }

                foreach (var fb in filtered)
                {
                    string user = fb.User != null
                        ? $"{fb.User.first_name} {fb.User.last_name}"
                        : $"User {fb.user_id}";

                    listbox_feedback.Items.Add($"📌 {fb.subject} — by {user} ({fb.created_at:MMM dd, yyyy})");
                }

                // Keep the filtered list for selection details
                currentFeedbacks = filtered;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching feedback: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listbox_feedback_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listbox_feedback.SelectedIndex;
            if (index < 0 || index >= currentFeedbacks.Count) return;

            // 🧠 Prevent opening details when clicking the Archive button
            Point cursorPos = listbox_feedback.PointToClient(Cursor.Position);
            if (archiveButtonBounds.Any(rect => rect.Contains(cursorPos)))
                return;

            var selectedFeedback = currentFeedbacks[index];
            using (var detailsForm = new FeedbackDetailsForm(selectedFeedback))
                detailsForm.ShowDialog();

            listbox_feedback.ClearSelected();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            // Optional: leave empty if you don’t need to draw anything
        }

        private void listbox_feedback_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0 || e.Index >= currentFeedbacks.Count) return;
            e.DrawBackground();

            Feedback fb = currentFeedbacks[e.Index];
            Graphics g = e.Graphics;
            Rectangle bounds = e.Bounds;
            bool isSelected = (e.State & DrawItemState.Selected) == DrawItemState.Selected;

            Color backColor = isSelected ? Color.FromArgb(52, 152, 219) : Color.White;
            using (SolidBrush bgBrush = new SolidBrush(backColor))
                g.FillRectangle(bgBrush, bounds);

            int padding = 10;
            using (Font subjectFont = new Font("Gadugi", 10, FontStyle.Bold))
            using (SolidBrush subjectBrush = new SolidBrush(isSelected ? Color.White : Color.Black))
                g.DrawString(fb.subject, subjectFont, subjectBrush, bounds.Left + padding, bounds.Top + 5);

            string user = fb.User != null ? $"{fb.User.first_name} {fb.User.last_name}" : $"User {fb.user_id}";
            string details = $"by {user} — {fb.created_at:MMM dd, yyyy hh:mm tt}";
            using (Font detailsFont = new Font("Gadugi", 8))
            using (SolidBrush detailsBrush = new SolidBrush(isSelected ? Color.WhiteSmoke : Color.Gray))
                g.DrawString(details, detailsFont, detailsBrush, bounds.Left + padding, bounds.Top + 25);

            // 🗂 Archive button (right side)
            int buttonWidth = 80;
            int buttonHeight = 25;
            Rectangle archiveRect = new Rectangle(bounds.Right - buttonWidth - 10, bounds.Top + 12, buttonWidth, buttonHeight);
            using (SolidBrush buttonBrush = new SolidBrush(Color.FromArgb(231, 76, 60)))
                g.FillRectangle(buttonBrush, archiveRect);
            using (Font buttonFont = new Font("Gadugi", 8, FontStyle.Bold))
            using (SolidBrush textBrush = new SolidBrush(Color.White))
                g.DrawString("Archive", buttonFont, textBrush, archiveRect, new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center });

            // Save clickable bounds
            if (archiveButtonBounds.Count <= e.Index)
                archiveButtonBounds.Add(archiveRect);
            else
                archiveButtonBounds[e.Index] = archiveRect;

            e.DrawFocusRectangle();
        }


        private void listbox_feedback_MouseDown(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < archiveButtonBounds.Count; i++)
            {
                if (archiveButtonBounds[i].Contains(e.Location))
                {
                    var fb = currentFeedbacks[i];
                    DialogResult result = MessageBox.Show($"Archive feedback \"{fb.subject}\"?", "Confirm Archive",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        if (feedbackRepository.ArchiveFeedback(fb.feedback_id))
                        {
                            //MessageBox.Show("Feedback archived successfully!", "Archived", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadFeedbacks(); // reload only unarchived feedbacks
                        }


                    }
                    return;
                }
            }
        }

        private void button_archives_Click(object sender, EventArgs e)
        {
            archived_feedback archives = new archived_feedback();
            archives.FormClosed += (s, args) => LoadFeedbacks();
            archives.ShowDialog();
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
                Font = new Font("Gadugi", 11, FontStyle.Bold),
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
                Font = new Font("Gadugi", 10, FontStyle.Regular),
                Dock = DockStyle.Top,
                Height = 40,
                Padding = new Padding(10)
            };

            Label lblDate = new Label()
            {
                Text = $"🕒 Date: {feedback.created_at:MMMM dd, yyyy hh:mm tt}",
                Font = new Font("Gadugi", 9, FontStyle.Italic),
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
                Font = new Font("Gadugi", 10, FontStyle.Regular),
                BackColor = Color.WhiteSmoke,
                ForeColor = Color.Black,
                Padding = new Padding(10)
            };

            //Button btnClose = new Button()
            //{
            //    Text = "Close",
            //    Dock = DockStyle.Bottom,
            //    Height = 40,
            //    Font = new Font("Gadugi", 10, FontStyle.Bold),
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
