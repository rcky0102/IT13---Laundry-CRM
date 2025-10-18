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

namespace IT13___Laundry_CRM.Laundry_Attendant
{
    public partial class archived_feedback : Form
    {
        private readonly FeedbackRepository feedbackRepository = new FeedbackRepository();

        public archived_feedback()
        {
            InitializeComponent();

            MakeRounded(dataGridView_archived);
            MakeRounded(button_unarchive);
            MakeRounded(txtSearch);
        }

        private void archived_feedback_Load(object sender, EventArgs e)
        {
            LoadArchivedFeedbacks();
            txtSearch.TextChanged += txtSearch_TextChanged;
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

        private void LoadArchivedFeedbacks()
        {
            try
            {
                var feedbacks = feedbackRepository.GetArchivedFeedbacks();

                if (feedbacks != null && feedbacks.Any())
                {
                    var displayList = feedbacks.Select(fb => new
                    {
                        fb.feedback_id,
                        Sender = fb.User != null
                            ? $"{fb.User.first_name} {(string.IsNullOrEmpty(fb.User.middle_name) ? "" : fb.User.middle_name + " ")}{fb.User.last_name}"
                            : $"User {fb.user_id}",
                        fb.subject,
                        fb.feedback,
                        Date = fb.created_at.ToString("g")
                    }).ToList();

                    dataGridView_archived.DataSource = displayList;
                }
                else
                {
                    dataGridView_archived.DataSource = null;
                    MessageBox.Show("No archived feedback found.", "Info",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading archived feedback: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_unarchive_Click(object sender, EventArgs e)
        {
            if (dataGridView_archived.SelectedRows.Count > 0)
            {
                int feedbackId = (int)dataGridView_archived.SelectedRows[0].Cells["feedback_id"].Value;

                feedbackRepository.UnarchiveFeedback(feedbackId);

                MessageBox.Show("Feedback successfully unarchived.", "Success",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadArchivedFeedbacks(); // Refresh list
            }
            else
            {
                MessageBox.Show("Please select a feedback to unarchive.", "Warning",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            SearchArchivedFeedbacks(txtSearch.Text.Trim());
        }

        private void SearchArchivedFeedbacks(string searchText)
        {
            var feedbacks = feedbackRepository.GetArchivedFeedbacks();

            if (!string.IsNullOrWhiteSpace(searchText))
            {
                searchText = searchText.ToLower();

                feedbacks = feedbacks.Where(fb =>
                    (!string.IsNullOrEmpty(fb.subject) && fb.subject.ToLower().Contains(searchText)) ||
                    (fb.User != null && !string.IsNullOrEmpty(fb.User.first_name) && fb.User.first_name.ToLower().Contains(searchText)) ||
                    (fb.User != null && !string.IsNullOrEmpty(fb.User.last_name) && fb.User.last_name.ToLower().Contains(searchText)) ||
                    // Search by month name, day, or year
                    fb.created_at.ToString("MMMM d, yyyy").ToLower().Contains(searchText) ||
                    fb.created_at.ToString("MMMM").ToLower().Contains(searchText) ||
                    fb.created_at.ToString("d").Contains(searchText) ||
                    fb.created_at.ToString("yyyy").Contains(searchText)
                ).ToList();
            }

            if (feedbacks.Any())
            {
                var displayList = feedbacks.Select(fb => new
                {
                    fb.feedback_id,
                    Sender = fb.User != null
                        ? $"{fb.User.first_name} {(string.IsNullOrEmpty(fb.User.middle_name) ? "" : fb.User.middle_name + " ")}{fb.User.last_name}"
                        : $"User {fb.user_id}",
                    fb.subject,
                    fb.feedback,
                    Date = fb.created_at.ToString("g")
                }).ToList();

                dataGridView_archived.DataSource = displayList;
            }
            else
            {
                dataGridView_archived.DataSource = null;
            }
        }

    }
}
