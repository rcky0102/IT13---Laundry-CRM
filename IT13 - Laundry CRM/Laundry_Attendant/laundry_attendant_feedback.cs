using IT13___Laundry_CRM.Customer;
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

namespace IT13___Laundry_CRM.Laundry_Attendant
{
    public partial class laundry_attendant_feedback : Laundry_Attendant_Template
    {

        private readonly FeedbackRepository feedbackRepository = new FeedbackRepository();
        private List<Feedback> currentFeedbacks = new List<Feedback>(); // All feedbacks for filter
        private List<Feedback> displayFeedbacks = new List<Feedback>();
        private List<Rectangle> archiveButtonBounds = new List<Rectangle>();

        public laundry_attendant_feedback()
        {
            InitializeComponent();

            comboBoxFilter.Items.Add("Unarchived");
            comboBoxFilter.Items.Add("Archived");
            comboBoxFilter.SelectedIndex = 0;
            comboBoxFilter.SelectedIndexChanged += comboBoxFilter_SelectedIndexChanged;

            listbox_feedback.SelectedIndexChanged += listbox_feedback_SelectedIndexChanged;
            listbox_feedback.MouseDown += listbox_feedback_MouseDown;
            textbox_search.TextChanged += textbox_search_TextChanged;

            MakeRounded(listbox_feedback);

            listbox_feedback.DrawMode = DrawMode.OwnerDrawFixed;
            listbox_feedback.ItemHeight = 50;
            listbox_feedback.BorderStyle = BorderStyle.None;
            listbox_feedback.DrawItem += listbox_feedback_DrawItem;

            LoadFeedbacks();
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
                bool showArchived = comboBoxFilter.SelectedItem?.ToString() == "Archived";

                if (CurrentUser.Role == "laundry_attendant")
                {
                    currentFeedbacks = showArchived
                        ? feedbackRepository.GetArchivedFeedbacks().ToList()
                        : feedbackRepository.GetUnarchivedFeedbacks().ToList();
                }
                else
                {
                    currentFeedbacks = showArchived
                        ? feedbackRepository.GetArchivedFeedbacksByUser(CurrentUser.UserId).ToList()
                        : feedbackRepository.GetUnarchivedFeedbacksByUser(CurrentUser.UserId).ToList();
                }

                ApplySearch();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading feedback: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ApplySearch()
        {
            string searchQuery = textbox_search.Text.Trim().ToLower();

            displayFeedbacks = currentFeedbacks
                .Where(fb =>
                    string.IsNullOrWhiteSpace(searchQuery) ||
                    (fb.subject != null && fb.subject.ToLower().Contains(searchQuery)) ||
                    (fb.User != null && fb.User.first_name.ToLower().Contains(searchQuery)) ||
                    (fb.User != null && fb.User.last_name.ToLower().Contains(searchQuery)) ||
                    fb.created_at.ToString("MMMM dd, yyyy").ToLower().Contains(searchQuery) ||
                    fb.created_at.ToString("hh:mm tt").ToLower().Contains(searchQuery)
                )
                .ToList();

            listbox_feedback.Items.Clear();
            archiveButtonBounds.Clear();

            if (displayFeedbacks.Count == 0)
            {
                listbox_feedback.Items.Add("No feedback found.");
                return;
            }

            foreach (var fb in displayFeedbacks)
            {
                string user = fb.User != null ? $"{fb.User.first_name} {fb.User.last_name}" : $"User {fb.user_id}";
                listbox_feedback.Items.Add($"📌 {fb.subject} — by {user} ({fb.created_at:MMM dd, yyyy})");
            }
        }






        private void laundry_attendant_feedback_Load(object sender, EventArgs e)
        {

        }



        private void listbox_feedback_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listbox_feedback.SelectedIndex;
            if (index < 0 || index >= displayFeedbacks.Count) return; // use displayFeedbacks

            Point cursorPos = listbox_feedback.PointToClient(Cursor.Position);
            if (archiveButtonBounds.Any(rect => rect.Contains(cursorPos))) return;

            var selectedFeedback = displayFeedbacks[index]; // use displayFeedbacks
            using (var detailsForm = new FeedbackDetailsForm(selectedFeedback))
                detailsForm.ShowDialog();

            listbox_feedback.ClearSelected();
        }

        private void listbox_feedback_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0 || e.Index >= displayFeedbacks.Count) return; // use displayFeedbacks

            e.DrawBackground();
            Feedback fb = displayFeedbacks[e.Index]; // use displayFeedbacks
            Graphics g = e.Graphics;
            Rectangle bounds = e.Bounds;
            bool isSelected = (e.State & DrawItemState.Selected) == DrawItemState.Selected;

            Color backColor = isSelected ? Color.FromArgb(52, 152, 219) : Color.White;
            using (SolidBrush bgBrush = new SolidBrush(backColor))
                g.FillRectangle(bgBrush, bounds);

            int padding = 10;
            using (Font subjectFont = new Font("Cascadia Code", 10, FontStyle.Bold))
            using (SolidBrush subjectBrush = new SolidBrush(isSelected ? Color.White : Color.Black))
                g.DrawString(fb.subject, subjectFont, subjectBrush, bounds.Left + padding, bounds.Top + 5);

            string user = fb.User != null ? $"{fb.User.first_name} {fb.User.last_name}" : $"User {fb.user_id}";
            string details = $"by {user} — {fb.created_at:MMM dd, yyyy hh:mm tt}";
            using (Font detailsFont = new Font("Cascadia Code", 8, FontStyle.Italic))
            using (SolidBrush detailsBrush = new SolidBrush(isSelected ? Color.WhiteSmoke : Color.Gray))
                g.DrawString(details, detailsFont, detailsBrush, bounds.Left + padding, bounds.Top + 25);

            // Archive button
            int buttonWidth = 80;
            int buttonHeight = 25;
            Rectangle archiveRect = new Rectangle(bounds.Right - buttonWidth - 10, bounds.Top + 12, buttonWidth, buttonHeight);
            using (SolidBrush buttonBrush = new SolidBrush(Color.FromArgb(231, 76, 60)))
                g.FillRectangle(buttonBrush, archiveRect);
            using (Font buttonFont = new Font("Cascadia Code", 8, FontStyle.Bold))
            using (SolidBrush textBrush = new SolidBrush(Color.White))
                g.DrawString("Archive", buttonFont, textBrush, archiveRect, new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center });

            if (archiveButtonBounds.Count <= e.Index)
                archiveButtonBounds.Add(archiveRect);
            else
                archiveButtonBounds[e.Index] = archiveRect;

            e.DrawFocusRectangle();
        }
      

        private void textbox_search_TextChanged(object sender, EventArgs e)
        {
            ApplySearch();
        }

        private void listbox_feedback_MouseDown(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < archiveButtonBounds.Count; i++)
            {
                if (archiveButtonBounds[i].Contains(e.Location))
                {
                    var fb = displayFeedbacks[i]; // use displayFeedbacks
                    DialogResult result = MessageBox.Show($"Archive feedback \"{fb.subject}\"?", "Confirm Archive",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        if (feedbackRepository.ArchiveFeedback(fb.feedback_id))
                        {
                            MessageBox.Show("Feedback archived successfully!", "Archived", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadFeedbacks(); // reload based on current filter
                        }
                    }
                    return;
                }
            }
        }


        private void comboBoxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadFeedbacks();
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
