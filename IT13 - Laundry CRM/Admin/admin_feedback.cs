using IT13___Laundry_CRM.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IT13___Laundry_CRM.Models;
using Feedback = IT13___Laundry_CRM.Models.Feedback;

namespace IT13___Laundry_CRM.Admin
{
    public partial class admin_feedback : SIdebarTemplate
    {
        private readonly FeedbackRepository feedbackRepository = new FeedbackRepository();

        private List<Feedback> currentFeedbacks = new List<Feedback>();

        public admin_feedback()
        {
            InitializeComponent();
            LoadFeedbacks();
        }

        private void admin_feedback_Load(object sender, EventArgs e)
        {

        }

        private void LoadFeedbacks()
        {
            try
            {
                // Retrieve feedbacks based on user role
                if (User.CurrentUser.Role == "admin")
                {
                    currentFeedbacks = feedbackRepository.GetAllFeedback();
                }
                else
                {
                    currentFeedbacks = feedbackRepository.GetFeedbacksByUser(User.CurrentUser.UserId);
                }

                // Clear the panel before adding new feedback items
                feedbackPanel.Controls.Clear();

                int yOffset = 10; // Vertical space between labels

                foreach (var fb in currentFeedbacks)
                {
                    string user = fb.User != null
                        ? $"{fb.User.first_name} {fb.User.last_name}"
                        : $"User {fb.user_id}";

                    // Create a label for each feedback
                    Label feedbackLabel = new Label
                    {
                        AutoSize = false,
                        Width = feedbackPanel.Width - 40, // Leave some padding from panel edge
                        Location = new Point(10, yOffset),
                        BorderStyle = BorderStyle.FixedSingle,
                        Font = new Font("Cascadia Code", 10, FontStyle.Regular), // 👈 Cascadia Code font
                        TextAlign = ContentAlignment.TopLeft,
                        Padding = new Padding(10),
                        BackColor = Color.White,
                        ForeColor = Color.Black,
                        Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right
                    };

                    // Construct the display text
                    feedbackLabel.Text =
                        $"📌 Subject: {fb.subject}\n" +
                        $"👤 Submitted by: {user}\n" +
                        $"💬 Feedback:\n{fb.feedback}\n\n" +
                        $"🕒 Date and Time: {fb.created_at:MMMM dd, yyyy hh:mm tt}";

                    // Auto-adjust label height to fit text
                    feedbackLabel.Height = TextRenderer.MeasureText(
                        feedbackLabel.Text,
                        feedbackLabel.Font,
                        new Size(feedbackLabel.Width, int.MaxValue),
                        TextFormatFlags.WordBreak
                    ).Height + 20;

                    // Add label to the panel
                    feedbackPanel.Controls.Add(feedbackLabel);

                    // Move down for next feedback
                    yOffset += feedbackLabel.Height + 10;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error loading feedback: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void feedbackPanel_Resize(object sender, EventArgs e)
        {
            foreach (Control ctrl in feedbackPanel.Controls)
            {
                if (ctrl is Label lbl)
                {
                    lbl.Width = feedbackPanel.Width - 40;

                    // Recalculate height on resize for proper text wrapping
                    lbl.Height = TextRenderer.MeasureText(
                        lbl.Text,
                        lbl.Font,
                        new Size(lbl.Width, int.MaxValue),
                        TextFormatFlags.WordBreak
                    ).Height + 20;
                }
            }
        }


        private void ApplySearchFilter()
        {
            try
            {
                string searchText = textbox_search.Text.Trim().ToLower();

                var filtered = currentFeedbacks.Where(fb =>
                    (fb.subject ?? "").ToLower().Contains(searchText) ||
                    (fb.User?.first_name ?? "").ToLower().Contains(searchText) ||
                    (fb.User?.last_name ?? "").ToLower().Contains(searchText) ||
                    fb.created_at.ToString("yyyy-MM-dd").Contains(searchText) ||       // date search
                    fb.created_at.ToString("hh:mm tt").ToLower().Contains(searchText)  // time search
                ).ToList();

                // Clear panel
                feedbackPanel.Controls.Clear();

                int yOffset = 10;

                foreach (var fb in filtered)
                {
                    string user = fb.User != null
                        ? $"{fb.User.first_name} {fb.User.last_name}"
                        : $"User {fb.user_id}";

                    Label feedbackLabel = new Label
                    {
                        AutoSize = false,
                        Width = feedbackPanel.Width - 40,
                        Location = new Point(10, yOffset),
                        BorderStyle = BorderStyle.FixedSingle,
                        Font = new Font("Cascadia Code", 10, FontStyle.Regular),
                        TextAlign = ContentAlignment.TopLeft,
                        Padding = new Padding(10),
                        BackColor = Color.White,
                        ForeColor = Color.Black,
                        Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right
                    };

                    feedbackLabel.Text =
                        $"📌 Subject: {fb.subject}\n" +
                        $"👤 Submitted by: {user}\n" +
                        $"💬 Feedback:\n{fb.feedback}\n\n" +
                        $"🕒 Date and Time: {fb.created_at:MMMM dd, yyyy hh:mm tt}";

                    feedbackLabel.Height = TextRenderer.MeasureText(
                        feedbackLabel.Text,
                        feedbackLabel.Font,
                        new Size(feedbackLabel.Width, int.MaxValue),
                        TextFormatFlags.WordBreak
                    ).Height + 20;

                    feedbackPanel.Controls.Add(feedbackLabel);

                    yOffset += feedbackLabel.Height + 10;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error filtering feedback: " + ex.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textbox_search_TextChanged(object sender, EventArgs e)
        {
            ApplySearchFilter();
        }
    }
}
