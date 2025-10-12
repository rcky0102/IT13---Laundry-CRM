using Microsoft.Data.SqlClient;
using PdfSharp.Drawing;
using PdfSharp.Fonts;
using PdfSharp.Pdf;


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
            dtpStart.Value = DateTime.Today.AddMonths(-1);
            dtpEnd.Value = DateTime.Today;
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            GenerateReport();
        }

        private void GenerateReport()
        {
            DateTime start = dtpStart.Value.Date;
            DateTime end = dtpEnd.Value.Date.AddDays(1).AddSeconds(-1);

            var userSummary = new UserSummary();
            var monthlyUsers = new List<MonthlyUser>();
            var roleDistribution = new List<RoleCount>();
            var archivedStatus = new List<ArchiveCount>();
            var addressDistribution = new List<AddressCount>();
            var growthTrend = new List<UserGrowth>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // 1️⃣ User Count by Role
                var roleCmd = new SqlCommand(@"
                    SELECT 
                        SUM(CASE WHEN role = 'admin' THEN 1 ELSE 0 END) AS Admins,
                        SUM(CASE WHEN role = 'laundry_attendant' THEN 1 ELSE 0 END) AS LaundryAttendants,
                        SUM(CASE WHEN role = 'customer' THEN 1 ELSE 0 END) AS Customers,
                        COUNT(*) AS Total
                    FROM Users", conn);

                using (var reader = roleCmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        userSummary.Admins = reader.GetInt32(0);
                        userSummary.LaundryAttendants = reader.GetInt32(1);
                        userSummary.Customers = reader.GetInt32(2);
                        userSummary.TotalUsers = reader.GetInt32(3);
                    }
                }

                // 2️⃣ New Users per Month
                var monthCmd = new SqlCommand(@"
                    SELECT FORMAT(created_at, 'yyyy-MM') AS Month, COUNT(*) AS Count
                    FROM Users
                    WHERE created_at BETWEEN @start AND @end
                    GROUP BY FORMAT(created_at, 'yyyy-MM')
                    ORDER BY Month", conn);
                monthCmd.Parameters.AddWithValue("@start", start);
                monthCmd.Parameters.AddWithValue("@end", end);

                using (var reader = monthCmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        monthlyUsers.Add(new MonthlyUser
                        {
                            Month = reader["Month"].ToString(),
                            Count = (int)reader["Count"]
                        });
                    }
                }

                // 3️⃣ Active vs Archived Users
                var archivedCmd = new SqlCommand(@"
                    SELECT 
                        CASE WHEN is_archived = 0 THEN 'Active' ELSE 'Archived' END AS Status,
                        COUNT(*) AS Count
                    FROM Users
                    GROUP BY is_archived", conn);

                using (var reader = archivedCmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        archivedStatus.Add(new ArchiveCount
                        {
                            Status = reader["Status"].ToString(),
                            Count = (int)reader["Count"]
                        });
                    }
                }

                // 4️⃣ Role Distribution Chart (same data as #1)
                roleDistribution.Add(new RoleCount { Role = "Admin", Count = userSummary.Admins });
                roleDistribution.Add(new RoleCount { Role = "Laundry Attendant", Count = userSummary.LaundryAttendants });
                roleDistribution.Add(new RoleCount { Role = "Customer", Count = userSummary.Customers });

                // 5️⃣ User Growth Over Time (cumulative)
                var growthCmd = new SqlCommand(@"
                    SELECT FORMAT(created_at, 'yyyy-MM') AS Month, COUNT(*) AS NewUsers
                    FROM Users
                    WHERE created_at <= @end
                    GROUP BY FORMAT(created_at, 'yyyy-MM')
                    ORDER BY Month", conn);
                growthCmd.Parameters.AddWithValue("@end", end);

                int cumulative = 0;
                using (var reader = growthCmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        cumulative += (int)reader["NewUsers"];
                        growthTrend.Add(new UserGrowth
                        {
                            Month = reader["Month"].ToString(),
                            TotalUsers = cumulative
                        });
                    }
                }

                // 6️⃣ Address-based Distribution
                var addressCmd = new SqlCommand(@"
                    SELECT address, COUNT(*) AS Count
                    FROM Users
                    WHERE address IS NOT NULL AND address <> ''
                    GROUP BY address
                    ORDER BY Count DESC", conn);

                using (var reader = addressCmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        addressDistribution.Add(new AddressCount
                        {
                            Address = reader["address"].ToString(),
                            Count = (int)reader["Count"]
                        });
                    }
                }
            }

            // ====== Update UI or Summary Label ======
            lblSummary.Text =
                $"User Report | Period: {start:yyyy-MM-dd} - {end:yyyy-MM-dd}\n" +
                $"Total Users: {userSummary.TotalUsers} | Admins: {userSummary.Admins} | " +
                $"Attendants: {userSummary.LaundryAttendants} | Customers: {userSummary.Customers}";

            dgvRoles.DataSource = roleDistribution;
            dgvMonthlyUsers.DataSource = monthlyUsers;
            dgvArchived.DataSource = archivedStatus;
            dgvGrowth.DataSource = growthTrend;
            dgvAddress.DataSource = addressDistribution;
        }

        private void dgvRecentChanges_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnExportPDF_Click(object sender, EventArgs e)
        {
            ExportToPDF();
        }

        private void ExportToPDF()
        {
            GlobalFontSettings.FontResolver = new FontResolver();
            var pdf = new PdfDocument();
            var page = pdf.AddPage();
            var gfx = XGraphics.FromPdfPage(page);
            int y = 20;

            gfx.DrawString("User Reports", new XFont("Arial", 16, XFontStyleEx.Bold), XBrushes.Black,
                new XRect(20, y, page.Width - 40, page.Height), XStringFormats.TopLeft);
            y += 40;

            gfx.DrawString(lblSummary.Text, new XFont("Arial", 10), XBrushes.Black,
                new XRect(20, y, page.Width - 40, page.Height), XStringFormats.TopLeft);
            y += 80;

            DrawTable(gfx, ref y, "1. User Count by Role", dgvRoles);
            DrawTable(gfx, ref y, "2. New Users per Month", dgvMonthlyUsers);
            DrawTable(gfx, ref y, "3. Active vs Archived Users", dgvArchived);
            DrawTable(gfx, ref y, "4. Role Distribution", dgvRoles);
            DrawTable(gfx, ref y, "5. User Growth Over Time", dgvGrowth);
            DrawTable(gfx, ref y, "6. Address-based Distribution", dgvAddress);

            string downloads = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads");
            string filePath = Path.Combine(downloads, "UserReports.pdf");
            pdf.Save(filePath);
            MessageBox.Show($"PDF exported successfully!\nSaved to: {filePath}");
        }

        private void DrawTable(XGraphics gfx, ref int y, string title, DataGridView dgv)
        {
            gfx.DrawString(title, new XFont("Arial", 12, XFontStyleEx.Bold), XBrushes.Black, new XPoint(20, y));
            y += 20;

            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (row.IsNewRow) continue;
                string line = string.Join(" | ", row.Cells.Cast<DataGridViewCell>().Select(c => c.Value?.ToString()));
                gfx.DrawString(line, new XFont("Arial", 9), XBrushes.Black, new XPoint(30, y));
                y += 15;
            }
            y += 30;
        }
    }


       
   // ==================== MODEL CLASSES ====================

    public class UserSummary
    {
        public int TotalUsers { get; set; }
        public int Admins { get; set; }
        public int LaundryAttendants { get; set; }
        public int Customers { get; set; }
    }

    public class MonthlyUser
    {
        public string Month { get; set; }
        public int Count { get; set; }
    }

    public class RoleCount
    {
        public string Role { get; set; }
        public int Count { get; set; }
    }

    public class ArchiveCount
    {
        public string Status { get; set; }
        public int Count { get; set; }
    }

    public class UserGrowth
    {
        public string Month { get; set; }
        public int TotalUsers { get; set; }
    }

    public class AddressCount
    {
        public string Address { get; set; }
        public int Count { get; set; }
    }

    public class FontResolver : IFontResolver
    {
        public byte[] GetFont(string faceName)
        {
            if (faceName == "Arial#")
            {
                return File.ReadAllBytes(@"C:\Windows\Fonts\arial.ttf");
            }
            return null;
        }

        public FontResolverInfo ResolveTypeface(string familyName, bool isBold, bool isItalic)
        {
            if (familyName.Equals("Arial", StringComparison.OrdinalIgnoreCase))
                return new FontResolverInfo("Arial#");

            return null;
        }
    }

}
