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
using System.Windows.Forms.DataVisualization.Charting;

namespace IT13___Laundry_CRM
{
    public partial class Laundry_Attendant_Dashboard : Laundry_Attendant_Template
    {
        private readonly FeedbackRepository feedbackRepository = new FeedbackRepository();
        private readonly StatusRepository statusRepository = new StatusRepository();
        private readonly MessageRepository messageRepository = new MessageRepository();
        private readonly UserRepository userRepository = new UserRepository();

        public Laundry_Attendant_Dashboard()
        {
            InitializeComponent();

            MakeRounded(label_welcome);
            MakeRounded(pictureBox1);
            MakeRounded(panel3);
            MakeRounded(panel8);
            MakeRounded(panel4);
            MakeRounded(panel9);
            MakeRounded(panel6);
            MakeRounded(panel7);
            MakeRounded(panel5);
            MakeRounded(panel11);
            MakeRounded(panel2);
            MakeRounded(dateTimePickerFrom);
            MakeRounded(dateTimePickerTo);
            MakeRounded(buttonLoadGraph);
            MakeRounded(buttonLoadGraphToday);
            MakeRounded(buttonLoadGraphWeek);
            MakeRounded(buttonLoadGraphMonth);

        }

        private void Laundry_Attendant_Dashboard_Load(object sender, EventArgs e)
        {
            LoadStatusCounts();
            ShowWelcomeMessage();

            // Initialize chart
            InitializeChart();

            // Set default dates to today
            dateTimePickerFrom.Value = DateTime.Today;
            dateTimePickerTo.Value = DateTime.Today;

            // Remove comboBoxGrouping initialization
            // comboBoxGrouping.Items.AddRange(new string[] { "Day", "Week", "Month" });
            // comboBoxGrouping.SelectedIndex = 0;

            // Load Today's data by default
            LoadMonthData();
        }

        private void InitializeChart()
        {
            if (chart1 == null) return;

            // Don't clear everything - work with the existing chart from designer
            // Just configure it properly

            if (chart1.ChartAreas.Count > 0)
            {
                ChartArea chartArea = chart1.ChartAreas[0];

                // X-axis configuration
                chartArea.AxisX.LabelStyle.Angle = -45;
                chartArea.AxisX.Interval = 1;
                chartArea.AxisX.MajorGrid.Enabled = false;
                chartArea.AxisX.IsMarginVisible = true;
                chartArea.AxisX.LabelStyle.Font = new Font("Segoe UI", 8);

                // Y-axis configuration
                chartArea.AxisY.MajorGrid.Enabled = true;
                chartArea.AxisY.MajorGrid.LineColor = Color.LightGray;
                chartArea.AxisY.LabelStyle.Font = new Font("Segoe UI", 8);
                chartArea.AxisY.Minimum = 0;

                // Enable scrolling and zooming if needed
                chartArea.CursorX.IsUserEnabled = true;
                chartArea.CursorX.IsUserSelectionEnabled = true;
                chartArea.AxisX.ScaleView.Zoomable = true;
            }

            // Set chart title
            if (chart1.Titles.Count > 0)
            {
                chart1.Titles[0].Text = "Number of Customers";
                chart1.Titles[0].Font = new Font("Segoe UI", 12, FontStyle.Bold);
            }

            // Set default dates to today
            dateTimePickerFrom.Value = DateTime.Today;
            dateTimePickerTo.Value = DateTime.Today;

            // Load Today's data by default
            LoadTodayData();
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

        private void ShowWelcomeMessage()
        {
            if (User.CurrentUser.User != null)
            {
                label_welcome.Text = $"Welcome, {User.CurrentUser.User.first_name}!";
            }
        }

        private void LoadStatusCounts()
        {
            try
            {
                var counts = statusRepository.GetStatusCounts();

                // Update labels safely
                if (label_pending != null)
                    label_pending.Text = $"Pending: {counts.GetValueOrDefault("Pending", 0)}";
                if (label_washing != null)
                    label_washing.Text = $"Washing: {counts.GetValueOrDefault("Washing", 0)}";
                if (label_drying != null)
                    label_drying.Text = $"Drying: {counts.GetValueOrDefault("Drying", 0)}";
                if (label_ironing != null)
                    label_ironing.Text = $"Ironing/Folding: {counts.GetValueOrDefault("Ironing/Folding", 0)}";
                if (label_ready != null)
                    label_ready.Text = $"Ready for Pickup: {counts.GetValueOrDefault("Ready for Pickup", 0)}";
                if (label_completed != null)
                    label_completed.Text = $"Completed: {counts.GetValueOrDefault("Completed", 0)}";
                if (label_cancelled != null)
                    label_cancelled.Text = $"Cancelled: {counts.GetValueOrDefault("Cancelled", 0)}";
                if (label_onhold != null)
                    label_onhold.Text = $"On Hold: {counts.GetValueOrDefault("On Hold", 0)}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading status counts: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ShowCustomerCounts(string groupBy, DateTime from, DateTime to)
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

            // Debug the data
            DebugChartData(data);

            try
            {
                // Clear only the series, keep chart areas and titles from designer
                chart1.Series.Clear();

                // Create a new series
                Series series = new Series("Number of Customers");

                // Use Column chart type as requested
                series.ChartType = SeriesChartType.Column;
                series.Color = Color.SteelBlue;
                series.BorderColor = Color.DarkBlue;
                series.BorderWidth = 1;
                series.IsValueShownAsLabel = true;
                series.LabelFormat = "0";
                series.Font = new Font("Segoe UI", 8, FontStyle.Bold);
                series["PointWidth"] = "0.6";
                series.IsXValueIndexed = true; // This helps with proper spacing

                // Add data points
                int dataIndex = 0;
                foreach (var item in data)
                {
                    DataPoint point = new DataPoint();

                    // Use numeric X values for proper spacing, but show text labels
                    point.SetValueXY(dataIndex, item.Value);
                    point.AxisLabel = item.Key; // This sets the X-axis label
                    point.Label = item.Value > 0 ? item.Value.ToString() : "";

                    series.Points.Add(point);
                    dataIndex++;
                }

                // Add the series to the chart
                chart1.Series.Add(series);

                // Update chart title based on grouping
                if (chart1.Titles.Count > 0)
                {
                    string titleText = chartType switch
                    {
                        "Day" => "Number of Customers - Today (24 Hours)",
                        "Week" => "Number of Customers - Last 7 Days",
                        "Month" => "Number of Customers - Last 30 Days",
                        "Custom" => $"Number of Customerss ({from:MMM dd, yyyy} - {to:MMM dd, yyyy})",
                        _ => "Number of Customers"
                    };

                    chart1.Titles[0].Text = titleText;
                }

                // Configure chart area if it exists
                if (chart1.ChartAreas.Count > 0)
                {
                    ChartArea area = chart1.ChartAreas[0];

                    // Ensure proper Y-axis scaling
                    if (data.Count > 0 && data.Values.Max() > 0)
                    {
                        int maxValue = data.Values.Max();
                        area.AxisY.Maximum = maxValue + 1;
                    }
                    else
                    {
                        area.AxisY.Maximum = 10;
                    }

                    area.AxisY.Minimum = 0;

                    // Set X-axis interval based on data count
                    if (data.Count > 10)
                    {
                        area.AxisX.Interval = Math.Ceiling(data.Count / 10.0);
                    }
                    else
                    {
                        area.AxisX.Interval = 1;
                    }
                }

                // Refresh the chart
                chart1.Invalidate();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating chart: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Color GetColorForValue(int value, int maxValue)
        {
            if (maxValue == 0) return Color.SteelBlue;

            // Create a gradient from light blue to dark blue based on value
            float ratio = (float)value / maxValue;
            int red = (int)(105 + (ratio * 50));   // 105-155
            int green = (int)(150 + (ratio * 50)); // 150-200
            int blue = (int)(200 + (ratio * 55));  // 200-255

            return Color.FromArgb(red, green, blue);
        }

        private void buttonLoadGraph_Click(object sender, EventArgs e)
        {
            DateTime from = dateTimePickerFrom.Value.Date;
            DateTime to = dateTimePickerTo.Value.Date;

            if (from > to)
            {
                MessageBox.Show("Start date cannot be after end date.", "Warning",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Automatically determine grouping based on date range
            string groupBy = DetermineGrouping(from, to);

            ShowCustomerCounts(groupBy, from, to);

            // Update button appearance for custom range
            UpdateButtonAppearance(buttonLoadGraph);
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

        private void LoadTodayData()
        {
            DateTime today = DateTime.Today;
            DateTime startOfToday = today;
            DateTime endOfToday = today.AddDays(1).AddSeconds(-1);

            if (dateTimePickerFrom != null) dateTimePickerFrom.Value = startOfToday;
            if (dateTimePickerTo != null) dateTimePickerTo.Value = endOfToday;

            // Use "Day" grouping for today
            ShowCustomerCounts("Day", startOfToday, endOfToday);
            UpdateButtonAppearance(buttonLoadGraphToday);
        }

        private void LoadWeekData()
        {
            DateTime today = DateTime.Today;
            DateTime startOfWeek = today.AddDays(-6); // Last 7 days including today
            DateTime endOfWeek = today.AddDays(1).AddSeconds(-1);

            if (dateTimePickerFrom != null) dateTimePickerFrom.Value = startOfWeek;
            if (dateTimePickerTo != null) dateTimePickerTo.Value = endOfWeek;

            // Use "Week" grouping for week view
            ShowCustomerCounts("Week", startOfWeek, endOfWeek);
            UpdateButtonAppearance(buttonLoadGraphWeek);
        }

        private void LoadMonthData()
        {
            DateTime today = DateTime.Today;
            DateTime startOfMonth = today.AddDays(-29); // Last 30 days including today
            DateTime endOfMonth = today.AddDays(1).AddSeconds(-1);

            if (dateTimePickerFrom != null) dateTimePickerFrom.Value = startOfMonth;
            if (dateTimePickerTo != null) dateTimePickerTo.Value = endOfMonth;

            // Use "Month" grouping for month view
            ShowCustomerCounts("Month", startOfMonth, endOfMonth);
            UpdateButtonAppearance(buttonLoadGraphMonth);
        }

        private void UpdateButtonAppearance(Button activeButton)
        {
            if (activeButton == null) return;

            // Reset all buttons to default appearance
            var buttons = new[] { buttonLoadGraphToday, buttonLoadGraphWeek, buttonLoadGraphMonth, buttonLoadGraph };

            foreach (var button in buttons)
            {
                if (button != null)
                {
                    button.BackColor = SystemColors.Control;
                    button.ForeColor = SystemColors.ControlText;
                    button.Font = new Font(button.Font, FontStyle.Regular);
                }
            }

            // Set active button appearance
            activeButton.BackColor = SystemColors.MenuHighlight;
            activeButton.ForeColor = SystemColors.HighlightText;
            activeButton.Font = new Font(activeButton.Font, FontStyle.Bold);
        }

        // Button click event handlers
        private void buttonLoadGraphToday_Click(object sender, EventArgs e)
        {
            LoadTodayData();
        }

        private void buttonLoadGraphWeek_Click(object sender, EventArgs e)
        {
            LoadWeekData();
        }

        private void buttonLoadGraphMonth_Click(object sender, EventArgs e)
        {
            LoadMonthData();
        }

        // Refresh status counts
        private void btnRefreshStatus_Click(object sender, EventArgs e)
        {
            LoadStatusCounts();
        }

        private void DebugChartData(Dictionary<string, int> data)
        {
            Console.WriteLine("=== CHART DATA DEBUG ===");
            Console.WriteLine($"Total data points: {data.Count}");

            if (data.Count == 0)    
            {
                Console.WriteLine("NO DATA POINTS!");
                return;
            }

            foreach (var item in data.Take(5)) // Show first 5 items
            {
                Console.WriteLine($"'{item.Key}': {item.Value}");
            }

            if (data.Count > 5)
            {
                Console.WriteLine($"... and {data.Count - 5} more");
            }

            Console.WriteLine($"Min value: {data.Values.Min()}, Max value: {data.Values.Max()}");
            Console.WriteLine("========================");
        }

        // Optional: Add method to show status distribution as a pie chart
        private void ShowStatusDistribution()
        {
            try
            {
                var counts = statusRepository.GetStatusCounts();

                // Create a new chart or clear existing one
                Chart statusChart = new Chart();
                ChartArea chartArea = new ChartArea();
                statusChart.ChartAreas.Add(chartArea);

                Series series = new Series("Status Distribution");
                series.ChartType = SeriesChartType.Pie;

                foreach (var status in counts)
                {
                    if (status.Value > 0)
                    {
                        series.Points.AddXY(status.Key, status.Value);
                    }
                }

                statusChart.Series.Add(series);
                // Add this chart to your form or show in a separate container
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading status distribution: " + ex.Message, "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}