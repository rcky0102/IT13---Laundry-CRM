using IT13___Laundry_CRM.Repositories;
using Microsoft.Data.SqlClient;
using PdfSharp.Drawing;
using PdfSharp.Drawing.Layout;
using PdfSharp.Fonts;
using PdfSharp.Pdf;
using System.Drawing.Drawing2D;
using System.Windows.Forms.DataVisualization.Charting;


namespace IT13___Laundry_CRM.Admin
{
    public partial class admin_reports : SIdebarTemplate
    {
        private readonly string connectionString =
    @"Data Source=LAPTOP-NGRORR8P\SQLEXPRESS;Initial Catalog=LaundryDb;Integrated Security=True;Connect Timeout=30; TrustServerCertificate=True";

        private readonly UserRepository userRepository = new UserRepository();

        public admin_reports()
        {
            InitializeComponent();

            MakeRounded(panel3);
            MakeRounded(dtpStart);
            MakeRounded(dtpEnd);
            MakeRounded(btnGenerateReport);
            MakeRounded(btnExportPDF);
            MakeRounded(label5);
            MakeRounded(dgvRoles);
            MakeRounded(label1);
            MakeRounded(dgvMonthlyUsers);
            MakeRounded(label2);
            MakeRounded(dgvArchived);
            MakeRounded(label3);
            MakeRounded(dgvGrowth);
            MakeRounded(label4);
            MakeRounded(dgvAddress);

        }

        private void admin_reports_Load(object sender, EventArgs e)
        {
            dtpStart.Value = DateTime.Today.AddMonths(-1);
            dtpEnd.Value = DateTime.Today;
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

        private void dgvArchived_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Your code here. If you don't need anything, leave it empty
        }

        private void dgvGrowth_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Code to handle the click, or leave empty if nothing needed
        }



        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            GenerateReport();

            // ===== Load Chart =====
            DateTime from = dtpStart.Value.Date;
            DateTime to = dtpEnd.Value.Date;

            string groupBy = DetermineGrouping(from, to);
            ShowCustomerCounts(groupBy, from, to);
        }

        private string DetermineGrouping(DateTime from, DateTime to)
        {
            TimeSpan span = to - from;

            if (span.TotalDays <= 1)
                return "Day";
            else if (span.TotalDays <= 7)
                return "Week";
            else if (span.TotalDays <= 30)
                return "Month";
            else
                return "Custom";
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
            lblSummary1.Text =
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

        private void ShowCustomerCounts(string groupBy, DateTime from, DateTime to)
        {
            try
            {
                var customers = userRepository.GetCustomersByRegistrationDateRange(from, to.AddDays(1).AddSeconds(-1));

                Dictionary<string, int> groupedData = new Dictionary<string, int>();

                switch (groupBy)
                {
                    case "Day":
                        for (int hour = 0; hour < 24; hour++)
                        {
                            string hourLabel = $"{hour:00}:00";
                            int count = customers.Count(c => c.created_at.Hour == hour);
                            groupedData[hourLabel] = count;
                        }
                        break;

                    case "Week":
                        for (int i = 6; i >= 0; i--)
                        {
                            DateTime day = DateTime.Today.AddDays(-i);
                            string dayLabel = day.ToString("MMM dd");
                            int count = customers.Count(c => c.created_at.Date == day.Date);
                            groupedData[dayLabel] = count;
                        }
                        break;

                    case "Month":
                        for (int i = 29; i >= 0; i--)
                        {
                            DateTime day = DateTime.Today.AddDays(-i);
                            string dayLabel = day.ToString("MMM dd");
                            int count = customers.Count(c => c.created_at.Date == day.Date);
                            groupedData[dayLabel] = count;
                        }
                        break;

                    case "Custom":
                        for (DateTime day = from.Date; day <= to.Date; day = day.AddDays(1))
                        {
                            string dayLabel = day.ToString("MMM dd");
                            int count = customers.Count(c => c.created_at.Date == day.Date);
                            groupedData[dayLabel] = count;
                        }
                        break;
                }

                UpdateChart(groupedData, groupBy, from, to);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error displaying customer counts: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateChart(Dictionary<string, int> data, string chartType, DateTime from, DateTime to)
        {
            if (chart1 == null) return;

            try
            {
                chart1.Series.Clear();

                Series series = new Series("Number of Customers")
                {
                    ChartType = SeriesChartType.Column,
                    Color = Color.SteelBlue,
                    BorderColor = Color.DarkBlue,
                    BorderWidth = 1,
                    IsValueShownAsLabel = true,
                    LabelFormat = "0",
                    Font = new Font("Segoe UI", 8, FontStyle.Bold),
                    ["PointWidth"] = "0.6",
                    IsXValueIndexed = true
                };

                int index = 0;
                foreach (var item in data)
                {
                    DataPoint point = new DataPoint
                    {
                        AxisLabel = item.Key,
                        Label = item.Value > 0 ? item.Value.ToString() : ""
                    };
                    point.SetValueXY(index, item.Value);
                    series.Points.Add(point);
                    index++;
                }

                chart1.Series.Add(series);

                if (chart1.Titles.Count > 0)
                {
                    chart1.Titles[0].Text = chartType switch
                    {
                        "Day" => "Number of Customers - Today (24 Hours)",
                        "Week" => "Number of Customers - Last 7 Days",
                        "Month" => "Number of Customers - Last 30 Days",
                        "Custom" => $"Number of Customers ({from:MMM dd, yyyy} - {to:MMM dd, yyyy})",
                        _ => "Number of Customers"
                    };
                }

                if (chart1.ChartAreas.Count > 0)
                {
                    ChartArea area = chart1.ChartAreas[0];
                    area.AxisY.Minimum = 0;
                    area.AxisY.Maximum = data.Values.Any() ? data.Values.Max() + 1 : 10;
                    area.AxisX.Interval = data.Count > 10 ? Math.Ceiling(data.Count / 10.0) : 1;
                }

                chart1.Invalidate();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating chart: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void dgvAddress_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
  
