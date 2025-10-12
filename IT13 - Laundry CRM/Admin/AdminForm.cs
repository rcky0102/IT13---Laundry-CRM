using IT13___Laundry_CRM.Models;
using IT13___Laundry_CRM.Repositories;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace IT13___Laundry_CRM
{
    public partial class AdminForm : Form
    {
        private readonly string connectionString =
            @"Data Source=LAPTOP-NGRORR8P\SQLEXPRESS;Initial Catalog=LaundryDb;Integrated Security=True;Connect Timeout=30; TrustServerCertificate=True";


        private readonly FeedbackRepository feedbackRepository = new FeedbackRepository();
        private readonly MessageRepository messageRepository = new MessageRepository();
        private readonly UserRepository userRepository = new UserRepository();

        public AdminForm()
        {
            InitializeComponent();
            ShowWelcomeMessage();
            LoadDashboardData();
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

        }

        private void ShowWelcomeMessage()
        {
            if (User.CurrentUser.User != null)
            {
                label_welcome.Text = $"Welcome, {User.CurrentUser.User.first_name}!";
            }
        }

        private void LoadDashboardData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Total users
                lblTotalUsers.Text = new SqlCommand("SELECT COUNT(*) FROM Users", conn).ExecuteScalar().ToString();

                // Active vs archived
                lblActiveUsers.Text = new SqlCommand("SELECT COUNT(*) FROM Users WHERE is_archived = 0", conn).ExecuteScalar().ToString();
                lblArchivedUsers.Text = new SqlCommand("SELECT COUNT(*) FROM Users WHERE is_archived = 1", conn).ExecuteScalar().ToString();

                // Roles
                lblAdminCount.Text = new SqlCommand("SELECT COUNT(*) FROM Users WHERE role = 'admin'", conn).ExecuteScalar().ToString();
                lblAttendantCount.Text = new SqlCommand("SELECT COUNT(*) FROM Users WHERE role = 'laundry_attendant'", conn).ExecuteScalar().ToString();
                lblCustomerCount.Text = new SqlCommand("SELECT COUNT(*) FROM Users WHERE role = 'customer'", conn).ExecuteScalar().ToString();

                // New users this month
                lblNewUsersMonth.Text = new SqlCommand("SELECT COUNT(*) FROM Users WHERE MONTH(created_at) = MONTH(GETDATE()) AND YEAR(created_at) = YEAR(GETDATE())", conn).ExecuteScalar().ToString();

                // New users last month
                lblNewUsersLastMonth.Text = new SqlCommand("SELECT COUNT(*) FROM Users WHERE MONTH(created_at) = MONTH(DATEADD(MONTH, -1, GETDATE())) AND YEAR(created_at) = YEAR(DATEADD(MONTH, -1, GETDATE()))", conn).ExecuteScalar().ToString();

                // Latest user
                using (SqlCommand cmd = new SqlCommand("SELECT TOP 1 first_name, last_name, role, created_at FROM Users ORDER BY created_at DESC", conn))
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        lblLatestUser.Text = $"{dr["first_name"]} {dr["last_name"]} ({dr["role"]})";
                        lblLatestUserDate.Text = Convert.ToDateTime(dr["created_at"]).ToString("MMMM dd, yyyy");
                    }
                }

                // Optional: Calculate growth rate
                double thisMonth = Convert.ToDouble(lblNewUsersMonth.Text);
                double lastMonth = Convert.ToDouble(lblNewUsersLastMonth.Text);
                double growth = lastMonth == 0 ? 100 : ((thisMonth - lastMonth) / lastMonth) * 100;
                lblGrowthRate.Text = $"{growth:F1}%";
            }
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
