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
                // If Admin → load all feedbacks
                if (User.CurrentUser.Role == "admin")
                {
                    currentFeedbacks = feedbackRepository.GetAllFeedback();
                }
                else
                {
                    // Normal users only see their own feedbacks
                    currentFeedbacks = feedbackRepository.GetFeedbacksByUser(User.CurrentUser.UserId);
                }

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

    }
}
