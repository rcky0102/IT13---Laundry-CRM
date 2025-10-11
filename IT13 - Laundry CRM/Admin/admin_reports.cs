using Microsoft.Data.SqlClient;
using PdfSharp.Drawing;
using PdfSharp.Fonts;


namespace IT13___Laundry_CRM.Admin
{
    public partial class admin_reports : SIdebarTemplate
    {
        private readonly string connectionString =
    @"Data Source=LAPTOP-NGRORR8P\SQLEXPRESS;Initial Catalog=LaundryDb;Integrated Security=True;Connect Timeout=30; TrustServerCertificate=True";

        public admin_reports()
        {
            InitializeComponent();
        }

        private void admin_reports_Load(object sender, EventArgs e)
        {
            dtpStart.Value = DateTime.Today.AddDays(-7); // default last 7 days
            dtpEnd.Value = DateTime.Today;
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            GenerateReport();
        }

        private void GenerateReport()
        {
            DateTime startPeriod = dtpStart.Value.Date;
            DateTime endPeriod = dtpEnd.Value.Date.AddDays(1).AddSeconds(-1); // include full day

            UserSummary userSummary = null;
            StatusSummary statusSummary = null;
            List<TopUserStatus> topUsers = new List<TopUserStatus>();
            List<RecentStatusChange> recentChanges = new List<RecentStatusChange>();
            List<StatusCount> statusCounts = new List<StatusCount>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // =======================
                // User Summary
                // =======================
                var userSummaryCmd = new SqlCommand(@"
                    SELECT 
                        COUNT(*) AS TotalUsers,
                        SUM(CASE WHEN role = 'admin' THEN 1 ELSE 0 END) AS Admins,
                        SUM(CASE WHEN role = 'laundry_attendant' THEN 1 ELSE 0 END) AS LaundryAttendants,
                        SUM(CASE WHEN role = 'customer' THEN 1 ELSE 0 END) AS Customers,
                        SUM(CASE WHEN created_at BETWEEN @start AND @end THEN 1 ELSE 0 END) AS NewUsers
                    FROM Users", conn);
                userSummaryCmd.Parameters.AddWithValue("@start", startPeriod);
                userSummaryCmd.Parameters.AddWithValue("@end", endPeriod);

                using (var reader = userSummaryCmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        userSummary = new UserSummary
                        {
                            TotalUsers = (int)reader["TotalUsers"],
                            Admins = (int)reader["Admins"],
                            LaundryAttendants = (int)reader["LaundryAttendants"],
                            Customers = (int)reader["Customers"],
                            NewUsers = (int)reader["NewUsers"]
                        };
                    }
                }

                // =======================
                // Status Summary
                // =======================
                var statusSummaryCmd = new SqlCommand(@"
                    SELECT 
                        COUNT(*) AS TotalStatuses,
                        SUM(CASE WHEN status = 'Active' THEN 1 ELSE 0 END) AS ActiveStatuses,
                        SUM(CASE WHEN status = 'Archived' THEN 1 ELSE 0 END) AS ArchivedStatuses
                    FROM StatusHistory
                    WHERE created_at BETWEEN @start AND @end", conn);
                statusSummaryCmd.Parameters.AddWithValue("@start", startPeriod);
                statusSummaryCmd.Parameters.AddWithValue("@end", endPeriod);

                using (var reader = statusSummaryCmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        statusSummary = new StatusSummary
                        {
                            TotalStatuses = (int)reader["TotalStatuses"],
                            ActiveStatuses = (int)reader["ActiveStatuses"],
                            ArchivedStatuses = (int)reader["ArchivedStatuses"]
                        };
                    }
                }

                // =======================
                // Status Counts by Type
                // =======================
                var statusCountCmd = new SqlCommand(@"
                    SELECT status, COUNT(*) AS Count
                    FROM StatusHistory
                    WHERE created_at BETWEEN @start AND @end
                    GROUP BY status", conn);
                statusCountCmd.Parameters.AddWithValue("@start", startPeriod);
                statusCountCmd.Parameters.AddWithValue("@end", endPeriod);

                using (var reader = statusCountCmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        statusCounts.Add(new StatusCount
                        {
                            Status = reader["status"].ToString(),
                            Count = (int)reader["Count"]
                        });
                    }
                }

                // =======================
                // Top Users
                // =======================
                var topUsersCmd = new SqlCommand(@"
                    SELECT TOP 5 u.username, COUNT(*) AS StatusUpdates
                    FROM StatusHistory sh
                    INNER JOIN Users u ON sh.user_id = u.user_id
                    WHERE sh.created_at BETWEEN @start AND @end
                    GROUP BY u.username
                    ORDER BY StatusUpdates DESC", conn);
                topUsersCmd.Parameters.AddWithValue("@start", startPeriod);
                topUsersCmd.Parameters.AddWithValue("@end", endPeriod);

                using (var reader = topUsersCmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        topUsers.Add(new TopUserStatus
                        {
                            Username = reader["username"].ToString(),
                            StatusUpdates = (int)reader["StatusUpdates"]
                        });
                    }
                }

                // =======================
                // Recent Status Changes
                // =======================
                var recentChangesCmd = new SqlCommand(@"
                    SELECT TOP 10 u.username, sh.status, sh.created_at AS Date
                    FROM StatusHistory sh
                    INNER JOIN Users u ON sh.user_id = u.user_id
                    WHERE sh.created_at BETWEEN @start AND @end
                    ORDER BY sh.created_at DESC", conn);
                recentChangesCmd.Parameters.AddWithValue("@start", startPeriod);
                recentChangesCmd.Parameters.AddWithValue("@end", endPeriod);

                using (var reader = recentChangesCmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        recentChanges.Add(new RecentStatusChange
                        {
                            Username = reader["username"].ToString(),
                            Status = reader["status"].ToString(),
                            Date = (DateTime)reader["Date"]
                        });
                    }
                }

                // =======================
                // Optional Insights
                // =======================
                var avgStatusCmd = new SqlCommand(@"
                    SELECT AVG(StatusCount) AS AvgStatusPerUser FROM 
                    (
                        SELECT COUNT(*) AS StatusCount
                        FROM StatusHistory
                        GROUP BY user_id
                    ) t", conn);

                double avgStatusPerUser = Convert.ToDouble(avgStatusCmd.ExecuteScalar());
                lblAverageStatus.Text = $"Average Statuses per User: {avgStatusPerUser:F2}";
            }

            // =======================
            // Update UI
            // =======================
            lblSummary.Text = $"User & Status Activity Report | Period: {startPeriod:yyyy-MM-dd} - {endPeriod:yyyy-MM-dd}\n" +
                              $"Total Users: {userSummary.TotalUsers} | Admins: {userSummary.Admins} | Laundry Attendants: {userSummary.LaundryAttendants} | Customers: {userSummary.Customers}\n" +
                              $"New Users: {userSummary.NewUsers} | Total Statuses: {statusSummary.TotalStatuses} | Active: {statusSummary.ActiveStatuses} | Archived: {statusSummary.ArchivedStatuses}";

            dgvTopUsers.DataSource = topUsers;
            dgvRecentChanges.DataSource = recentChanges;
            dgvStatusCounts.DataSource = statusCounts;
        }

        private void btnExportPDF_Click(object sender, EventArgs e)
        {
            ExportToPDF();
        }

        private void ExportToPDF()
        {
            GlobalFontSettings.FontResolver = new FontResolver();

            var pdf = new PdfSharp.Pdf.PdfDocument();
            var page = pdf.AddPage();
            var gfx = XGraphics.FromPdfPage(page);
            int y = 20;

            // Header / Summary
            gfx.DrawString(lblSummary.Text, new XFont("Arial", 12, XFontStyleEx.Bold), XBrushes.Black,
                new XRect(20, y, page.Width - 40, page.Height), XStringFormats.TopLeft);
            y += 100;

            // Top Users table
            gfx.DrawString("Top Users:", new XFont("Arial", 12, XFontStyleEx.Bold), XBrushes.Black, new XPoint(20, y));
            y += 20;
            foreach (DataGridViewRow row in dgvTopUsers.Rows)
            {
                if (row.IsNewRow) continue;
                gfx.DrawString($"{row.Cells[0].Value} - {row.Cells[1].Value} updates",
                    new XFont("Arial", 10), XBrushes.Black, new XPoint(20, y));
                y += 20;
            }

            // Recent Status Changes table
            y += 20;
            gfx.DrawString("Recent Status Changes:", new XFont("Arial", 12, XFontStyleEx.Bold), XBrushes.Black, new XPoint(20, y));
            y += 20;
            foreach (DataGridViewRow row in dgvRecentChanges.Rows)
            {
                if (row.IsNewRow) continue;
                gfx.DrawString($"{row.Cells[0].Value} - {row.Cells[1].Value} - {row.Cells[2].Value}",
                    new XFont("Arial", 10), XBrushes.Black, new XPoint(20, y));
                y += 20;
            }

            string downloadsPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads");
            string filePath = Path.Combine(downloadsPath, "UserStatusReport.pdf");

            pdf.Save(filePath);
            MessageBox.Show($"PDF exported successfully!\nSaved to: {filePath}");

        }


        private void dgvRecentChanges_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

    public class UserSummary
    {
        public int TotalUsers { get; set; }
        public int Admins { get; set; }
        public int LaundryAttendants { get; set; }
        public int Customers { get; set; }
        public int NewUsers { get; set; }
    }

    public class StatusSummary
    {
        public int TotalStatuses { get; set; }
        public int ActiveStatuses { get; set; }
        public int ArchivedStatuses { get; set; }
    }

    public class TopUserStatus
    {
        public string Username { get; set; }
        public int StatusUpdates { get; set; }
    }

    public class RecentStatusChange
    {
        public string Username { get; set; }
        public string Status { get; set; }
        public DateTime Date { get; set; }
    }

    public class StatusCount
    {
        public string Status { get; set; }
        public int Count { get; set; }
    }
    public class FontResolver : IFontResolver
    {
        // Provide font bytes from file or embedded resource
        public byte[] GetFont(string faceName)
        {
            if (faceName == "Arial#") // custom identifier
            {
                return File.ReadAllBytes(@"C:\Windows\Fonts\arial.ttf"); // path to ttf file
            }

            return null;
        }

        public FontResolverInfo ResolveTypeface(string familyName, bool isBold, bool isItalic)
        {
            if (familyName.Equals("Arial", StringComparison.OrdinalIgnoreCase))
            {
                return new FontResolverInfo("Arial#");
            }

            return null;
        }
    }

}
