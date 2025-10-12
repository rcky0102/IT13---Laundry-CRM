using Microsoft.Data.SqlClient;
using PdfSharp.Drawing;
using PdfSharp.Drawing.Layout;
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
            var tf = new XTextFormatter(gfx);

            int margin = 50;
            int y = margin;

            XFont headerFont = new XFont("Arial", 18, XFontStyleEx.Bold);
            XFont subHeaderFont = new XFont("Arial", 12, XFontStyleEx.Bold);
            XFont bodyFont = new XFont("Arial", 10);
            XFont footerFont = new XFont("Arial", 9, XFontStyleEx.Italic);

            // ===== Report Header =====
            gfx.DrawString("LAUNDRY CRM SYSTEM", headerFont, XBrushes.Black,
                new XRect(0, y, page.Width, 30), XStringFormats.TopCenter);
            y += 30;

            gfx.DrawString("User Report Summary", subHeaderFont, XBrushes.Black,
                new XRect(0, y, page.Width, 20), XStringFormats.TopCenter);
            y += 30;

            // Date & generated by
            string dateStr = $"Generated on: {DateTime.Now:MMMM dd, yyyy | hh:mm tt}";
            gfx.DrawString(dateStr, bodyFont, XBrushes.Gray,
                new XRect(margin, y, page.Width - margin * 2, 20), XStringFormats.TopLeft);
            y += 30;

            // ===== Report Summary =====
            gfx.DrawString("Executive Summary", subHeaderFont, XBrushes.Black, new XPoint(margin, y));
            y += 20;

            double summaryHeight = DrawWrappedText(tf, lblSummary.Text, bodyFont, XBrushes.Black, margin, y, page.Width - margin * 2);
            y += (int)summaryHeight + 30;

            // ===== Report Sections =====
            y = DrawTableWithPagination(pdf, ref gfx, ref page, ref y, "1. User Count by Role", dgvRoles, margin, bodyFont, subHeaderFont);
            y = DrawTableWithPagination(pdf, ref gfx, ref page, ref y, "2. New Users per Month", dgvMonthlyUsers, margin, bodyFont, subHeaderFont);
            y = DrawTableWithPagination(pdf, ref gfx, ref page, ref y, "3. Active vs Archived Users", dgvArchived, margin, bodyFont, subHeaderFont);
            y = DrawTableWithPagination(pdf, ref gfx, ref page, ref y, "4. Role Distribution", dgvRoles, margin, bodyFont, subHeaderFont);
            y = DrawTableWithPagination(pdf, ref gfx, ref page, ref y, "5. User Growth Over Time", dgvGrowth, margin, bodyFont, subHeaderFont);
            y = DrawTableWithPagination(pdf, ref gfx, ref page, ref y, "6. Address-based Distribution", dgvAddress, margin, bodyFont, subHeaderFont);

            // ===== Footer =====
            DrawFooter(gfx, page, margin, footerFont);

            // ===== Save File =====
            string downloads = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads");
            string filePath = Path.Combine(downloads, $"UserReport_{DateTime.Now:yyyyMMdd_HHmm}.pdf");
            pdf.Save(filePath);
            MessageBox.Show($"PDF exported successfully!\nSaved to: {filePath}");
        }

        // ========================= HELPERS =========================

        private double DrawWrappedText(XTextFormatter tf, string text, XFont font, XBrush brush, int margin, int y, double width)
        {
            // Estimate height dynamically
            double lineHeight = font.GetHeight();
            int lines = text.Split(new[] { "\r\n", "\n" }, StringSplitOptions.None).Length;
            double height = lines * lineHeight + 10;

            tf.DrawString(text, font, brush, new XRect(margin, y, width, height), XStringFormats.TopLeft);
            return height;
        }

        private int DrawTableWithPagination(PdfDocument pdf, ref XGraphics gfx, ref PdfPage page, ref int y,
                                            string title, DataGridView dgv, int margin, XFont bodyFont, XFont titleFont)
        {
            int bottomMargin = 100;
            int rowHeight = 18;
            int colSpacing = 150;

            // Section title
            gfx.DrawString(title, titleFont, XBrushes.Black, new XPoint(margin, y));
            y += 20;

            // Draw column headers
            int x = margin + 10;
            foreach (DataGridViewColumn col in dgv.Columns)
            {
                gfx.DrawString(col.HeaderText, new XFont("Arial", 9, XFontStyleEx.Bold), XBrushes.DarkBlue, new XPoint(x, y));
                x += colSpacing;
            }
            y += rowHeight;

            // Draw rows
            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (row.IsNewRow) continue;

                // Check page overflow
                if (y + rowHeight > page.Height - bottomMargin)
                {
                    DrawFooter(gfx, page, margin, new XFont("Arial", 9, XFontStyleEx.Italic));
                    page = pdf.AddPage();
                    gfx = XGraphics.FromPdfPage(page);
                    y = margin;
                }

                x = margin + 10;
                foreach (DataGridViewCell cell in row.Cells)
                {
                    string value = cell.Value?.ToString() ?? "";
                    gfx.DrawString(value, bodyFont, XBrushes.Black, new XPoint(x, y));
                    x += colSpacing;
                }
                y += rowHeight;
            }

            y += 30;
            return y;
        }

        private void DrawFooter(XGraphics gfx, PdfPage page, int margin, XFont footerFont)
        {
            gfx.DrawLine(XPens.Black, margin, page.Height - 60, page.Width - margin, page.Height - 60);
            gfx.DrawString("Laundry CRM Reporting System", footerFont, XBrushes.Gray,
                new XRect(margin, page.Height - 50, page.Width - margin * 2, 20), XStringFormats.TopLeft);
            gfx.DrawString("© " + DateTime.Now.Year + " Laundry CRM. All Rights Reserved.", footerFont, XBrushes.Gray,
                new XRect(margin, page.Height - 35, page.Width - margin * 2, 20), XStringFormats.TopLeft);
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
}
  
