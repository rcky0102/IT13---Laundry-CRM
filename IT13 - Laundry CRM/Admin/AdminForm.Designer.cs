namespace IT13___Laundry_CRM
{
    partial class AdminForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            label3 = new Label();
            label4 = new Label();
            label_welcome = new Label();
            lblTotalUsers = new Label();
            lblActiveUsers = new Label();
            lblArchivedUsers = new Label();
            lblAdminCount = new Label();
            lblAttendantCount = new Label();
            lblCustomerCount = new Label();
            lblNewUsersMonth = new Label();
            lblNewUsersLastMonth = new Label();
            lblLatestUser = new Label();
            lblLatestUserDate = new Label();
            lblGrowthRate = new Label();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            dateTimePickerTo = new DateTimePicker();
            dateTimePickerFrom = new DateTimePicker();
            buttonLoadGraph = new Button();
            buttonLoadGraphMonth = new Button();
            buttonLoadGraphWeek = new Button();
            buttonLoadGraphToday = new Button();
            panel3 = new Panel();
            label13 = new Label();
            label1 = new Label();
            panel4 = new Panel();
            label14 = new Label();
            label2 = new Label();
            panel5 = new Panel();
            label19 = new Label();
            label5 = new Label();
            panel6 = new Panel();
            label20 = new Label();
            label6 = new Label();
            panel7 = new Panel();
            label18 = new Label();
            label7 = new Label();
            panel8 = new Panel();
            label15 = new Label();
            label8 = new Label();
            panel9 = new Panel();
            label16 = new Label();
            label9 = new Label();
            panel10 = new Panel();
            label21 = new Label();
            label10 = new Label();
            panel11 = new Panel();
            label22 = new Label();
            label11 = new Label();
            panel12 = new Panel();
            label17 = new Label();
            label12 = new Label();
            panel13 = new Panel();
            label23 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            panel9.SuspendLayout();
            panel10.SuspendLayout();
            panel11.SuspendLayout();
            panel12.SuspendLayout();
            panel13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(567, 22);
            label3.Name = "label3";
            label3.Size = new Size(30, 22);
            label3.TabIndex = 9;
            label3.Text = "—>";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cascadia Code SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(2, 3);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(204, 27);
            label4.TabIndex = 5;
            label4.Text = "Latest Feedback:";
            // 
            // label_welcome
            // 
            label_welcome.AutoSize = true;
            label_welcome.BackColor = SystemColors.ButtonHighlight;
            label_welcome.Font = new Font("Gadugi", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_welcome.ForeColor = SystemColors.ActiveCaptionText;
            label_welcome.Location = new Point(247, 81);
            label_welcome.Margin = new Padding(2, 0, 2, 0);
            label_welcome.Name = "label_welcome";
            label_welcome.Size = new Size(155, 36);
            label_welcome.TabIndex = 28;
            label_welcome.Text = "Welcome!";
            label_welcome.Click += label_welcome_Click;
            // 
            // lblTotalUsers
            // 
            lblTotalUsers.AutoSize = true;
            lblTotalUsers.Font = new Font("Gadugi", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalUsers.Location = new Point(115, 35);
            lblTotalUsers.Margin = new Padding(2, 0, 2, 0);
            lblTotalUsers.Name = "lblTotalUsers";
            lblTotalUsers.Size = new Size(31, 34);
            lblTotalUsers.TabIndex = 29;
            lblTotalUsers.Text = "1";
            lblTotalUsers.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblActiveUsers
            // 
            lblActiveUsers.AutoSize = true;
            lblActiveUsers.Font = new Font("Gadugi", 16.2F, FontStyle.Bold);
            lblActiveUsers.Location = new Point(116, 39);
            lblActiveUsers.Margin = new Padding(2, 0, 2, 0);
            lblActiveUsers.Name = "lblActiveUsers";
            lblActiveUsers.Size = new Size(31, 34);
            lblActiveUsers.TabIndex = 30;
            lblActiveUsers.Text = "1";
            lblActiveUsers.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblArchivedUsers
            // 
            lblArchivedUsers.AutoSize = true;
            lblArchivedUsers.Font = new Font("Gadugi", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblArchivedUsers.Location = new Point(115, 39);
            lblArchivedUsers.Margin = new Padding(2, 0, 2, 0);
            lblArchivedUsers.Name = "lblArchivedUsers";
            lblArchivedUsers.Size = new Size(31, 34);
            lblArchivedUsers.TabIndex = 31;
            lblArchivedUsers.Text = "1";
            lblArchivedUsers.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAdminCount
            // 
            lblAdminCount.AutoSize = true;
            lblAdminCount.Font = new Font("Gadugi", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAdminCount.Location = new Point(113, 38);
            lblAdminCount.Margin = new Padding(2, 0, 2, 0);
            lblAdminCount.Name = "lblAdminCount";
            lblAdminCount.Size = new Size(31, 34);
            lblAdminCount.TabIndex = 32;
            lblAdminCount.Text = "1";
            lblAdminCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAttendantCount
            // 
            lblAttendantCount.AutoSize = true;
            lblAttendantCount.Font = new Font("Gadugi", 16.2F, FontStyle.Bold);
            lblAttendantCount.Location = new Point(113, 35);
            lblAttendantCount.Margin = new Padding(2, 0, 2, 0);
            lblAttendantCount.Name = "lblAttendantCount";
            lblAttendantCount.Size = new Size(31, 34);
            lblAttendantCount.TabIndex = 33;
            lblAttendantCount.Text = "1";
            lblAttendantCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCustomerCount
            // 
            lblCustomerCount.AutoSize = true;
            lblCustomerCount.Font = new Font("Gadugi", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCustomerCount.Location = new Point(116, 35);
            lblCustomerCount.Margin = new Padding(2, 0, 2, 0);
            lblCustomerCount.Name = "lblCustomerCount";
            lblCustomerCount.Size = new Size(31, 34);
            lblCustomerCount.TabIndex = 34;
            lblCustomerCount.Text = "1";
            lblCustomerCount.TextAlign = ContentAlignment.MiddleCenter;
            lblCustomerCount.Click += lblCustomerCount_Click;
            // 
            // lblNewUsersMonth
            // 
            lblNewUsersMonth.AutoSize = true;
            lblNewUsersMonth.Font = new Font("Gadugi", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNewUsersMonth.Location = new Point(113, 35);
            lblNewUsersMonth.Margin = new Padding(2, 0, 2, 0);
            lblNewUsersMonth.Name = "lblNewUsersMonth";
            lblNewUsersMonth.Size = new Size(31, 34);
            lblNewUsersMonth.TabIndex = 35;
            lblNewUsersMonth.Text = "1";
            lblNewUsersMonth.TextAlign = ContentAlignment.MiddleCenter;
            lblNewUsersMonth.Click += lblNewUsersMonth_Click;
            // 
            // lblNewUsersLastMonth
            // 
            lblNewUsersLastMonth.AutoSize = true;
            lblNewUsersLastMonth.Font = new Font("Gadugi", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNewUsersLastMonth.Location = new Point(113, 35);
            lblNewUsersLastMonth.Margin = new Padding(2, 0, 2, 0);
            lblNewUsersLastMonth.Name = "lblNewUsersLastMonth";
            lblNewUsersLastMonth.Size = new Size(31, 34);
            lblNewUsersLastMonth.TabIndex = 36;
            lblNewUsersLastMonth.Text = "1";
            lblNewUsersLastMonth.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblLatestUser
            // 
            lblLatestUser.AutoSize = true;
            lblLatestUser.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLatestUser.ForeColor = SystemColors.ActiveCaptionText;
            lblLatestUser.Location = new Point(35, 11);
            lblLatestUser.Margin = new Padding(2, 0, 2, 0);
            lblLatestUser.Name = "lblLatestUser";
            lblLatestUser.Size = new Size(158, 19);
            lblLatestUser.TabIndex = 37;
            lblLatestUser.Text = "Latest  Registered user";
            // 
            // lblLatestUserDate
            // 
            lblLatestUserDate.AutoSize = true;
            lblLatestUserDate.Font = new Font("Gadugi", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLatestUserDate.ForeColor = SystemColors.ActiveCaptionText;
            lblLatestUserDate.Location = new Point(42, 35);
            lblLatestUserDate.Margin = new Padding(2, 0, 2, 0);
            lblLatestUserDate.Name = "lblLatestUserDate";
            lblLatestUserDate.Size = new Size(97, 16);
            lblLatestUserDate.TabIndex = 38;
            lblLatestUserDate.Text = "latest user date";
            // 
            // lblGrowthRate
            // 
            lblGrowthRate.AutoSize = true;
            lblGrowthRate.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGrowthRate.ForeColor = SystemColors.ActiveCaptionText;
            lblGrowthRate.Location = new Point(42, 30);
            lblGrowthRate.Margin = new Padding(2, 0, 2, 0);
            lblGrowthRate.Name = "lblGrowthRate";
            lblGrowthRate.Size = new Size(104, 19);
            lblGrowthRate.TabIndex = 39;
            lblGrowthRate.Text = "lblGrowthRate";
            // 
            // chart1
            // 
            chart1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(224, 514);
            chart1.Margin = new Padding(2, 4, 2, 4);
            chart1.Name = "chart1";
            chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series1.ChartArea = "ChartArea1";
            series1.IsXValueIndexed = true;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.YValuesPerPoint = 2;
            chart1.Series.Add(series1);
            chart1.Size = new Size(1676, 328);
            chart1.TabIndex = 40;
            chart1.Text = "chart1";
            title1.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Top;
            title1.Name = "Title1";
            title1.Text = "Customer";
            chart1.Titles.Add(title1);
            chart1.Click += chart1_Click;
            // 
            // dateTimePickerTo
            // 
            dateTimePickerTo.Font = new Font("Gadugi", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePickerTo.Format = DateTimePickerFormat.Short;
            dateTimePickerTo.Location = new Point(191, 15);
            dateTimePickerTo.Margin = new Padding(4, 2, 4, 2);
            dateTimePickerTo.Name = "dateTimePickerTo";
            dateTimePickerTo.Size = new Size(124, 30);
            dateTimePickerTo.TabIndex = 43;
            // 
            // dateTimePickerFrom
            // 
            dateTimePickerFrom.CalendarMonthBackground = SystemColors.GradientActiveCaption;
            dateTimePickerFrom.CalendarTitleBackColor = SystemColors.GradientActiveCaption;
            dateTimePickerFrom.Font = new Font("Gadugi", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePickerFrom.Format = DateTimePickerFormat.Short;
            dateTimePickerFrom.Location = new Point(21, 15);
            dateTimePickerFrom.Margin = new Padding(4, 2, 4, 2);
            dateTimePickerFrom.Name = "dateTimePickerFrom";
            dateTimePickerFrom.Size = new Size(124, 30);
            dateTimePickerFrom.TabIndex = 42;
            dateTimePickerFrom.ValueChanged += dateTimePickerFrom_ValueChanged;
            // 
            // buttonLoadGraph
            // 
            buttonLoadGraph.BackColor = SystemColors.Highlight;
            buttonLoadGraph.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonLoadGraph.ForeColor = SystemColors.ButtonHighlight;
            buttonLoadGraph.Location = new Point(323, 15);
            buttonLoadGraph.Margin = new Padding(4, 2, 4, 2);
            buttonLoadGraph.Name = "buttonLoadGraph";
            buttonLoadGraph.Size = new Size(112, 33);
            buttonLoadGraph.TabIndex = 41;
            buttonLoadGraph.Text = "Load";
            buttonLoadGraph.UseVisualStyleBackColor = false;
            buttonLoadGraph.Click += buttonLoadGraph_Click;
            // 
            // buttonLoadGraphMonth
            // 
            buttonLoadGraphMonth.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonLoadGraphMonth.Font = new Font("Gadugi", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonLoadGraphMonth.Location = new Point(1556, 15);
            buttonLoadGraphMonth.Margin = new Padding(4);
            buttonLoadGraphMonth.Name = "buttonLoadGraphMonth";
            buttonLoadGraphMonth.Size = new Size(104, 33);
            buttonLoadGraphMonth.TabIndex = 46;
            buttonLoadGraphMonth.Text = "Month";
            buttonLoadGraphMonth.UseVisualStyleBackColor = true;
            buttonLoadGraphMonth.Click += buttonLoadGraphMonth_Click;
            // 
            // buttonLoadGraphWeek
            // 
            buttonLoadGraphWeek.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonLoadGraphWeek.Font = new Font("Gadugi", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonLoadGraphWeek.Location = new Point(1434, 15);
            buttonLoadGraphWeek.Margin = new Padding(4);
            buttonLoadGraphWeek.Name = "buttonLoadGraphWeek";
            buttonLoadGraphWeek.Size = new Size(112, 33);
            buttonLoadGraphWeek.TabIndex = 45;
            buttonLoadGraphWeek.Text = "Week";
            buttonLoadGraphWeek.UseVisualStyleBackColor = true;
            buttonLoadGraphWeek.Click += buttonLoadGraphWeek_Click;
            // 
            // buttonLoadGraphToday
            // 
            buttonLoadGraphToday.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonLoadGraphToday.Font = new Font("Gadugi", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonLoadGraphToday.Location = new Point(1342, 16);
            buttonLoadGraphToday.Margin = new Padding(4);
            buttonLoadGraphToday.Name = "buttonLoadGraphToday";
            buttonLoadGraphToday.Size = new Size(85, 33);
            buttonLoadGraphToday.TabIndex = 44;
            buttonLoadGraphToday.Text = "Today";
            buttonLoadGraphToday.UseVisualStyleBackColor = true;
            buttonLoadGraphToday.Click += buttonLoadGraphToday_Click;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.Highlight;
            panel3.Controls.Add(label13);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(lblTotalUsers);
            panel3.Font = new Font("Gadugi", 8F);
            panel3.ForeColor = SystemColors.ButtonHighlight;
            panel3.Location = new Point(291, 146);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(294, 114);
            panel3.TabIndex = 47;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Gadugi", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(228, 69);
            label13.Margin = new Padding(2, 0, 2, 0);
            label13.Name = "label13";
            label13.Size = new Size(48, 33);
            label13.TabIndex = 58;
            label13.Text = "👥";
            label13.Click += label13_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gadugi", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(2, 2);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(97, 20);
            label1.TabIndex = 52;
            label1.Text = "Total Users:";
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.Highlight;
            panel4.Controls.Add(label14);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(lblCustomerCount);
            panel4.Font = new Font("Gadugi", 8F);
            panel4.ForeColor = SystemColors.ButtonHighlight;
            panel4.Location = new Point(610, 146);
            panel4.Margin = new Padding(2);
            panel4.Name = "panel4";
            panel4.Size = new Size(294, 114);
            panel4.TabIndex = 48;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Gadugi", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.Location = new Point(232, 69);
            label14.Margin = new Padding(2, 0, 2, 0);
            label14.Name = "label14";
            label14.Size = new Size(48, 33);
            label14.TabIndex = 54;
            label14.Text = "\U0001f9d1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Gadugi", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(2, 2);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(94, 20);
            label2.TabIndex = 53;
            label2.Text = "Customers:";
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.Highlight;
            panel5.Controls.Add(label19);
            panel5.Controls.Add(label5);
            panel5.Controls.Add(lblActiveUsers);
            panel5.Font = new Font("Gadugi", 8F);
            panel5.ForeColor = SystemColors.ButtonHighlight;
            panel5.Location = new Point(610, 284);
            panel5.Margin = new Padding(2);
            panel5.Name = "panel5";
            panel5.Size = new Size(294, 114);
            panel5.TabIndex = 49;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Gadugi", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label19.ForeColor = Color.Lime;
            label19.Location = new Point(232, 66);
            label19.Margin = new Padding(2, 0, 2, 0);
            label19.Name = "label19";
            label19.Size = new Size(48, 33);
            label19.TabIndex = 58;
            label19.Text = "\U0001f7e2";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Gadugi", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(2, 2);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(105, 20);
            label5.TabIndex = 53;
            label5.Text = "Active Users:";
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.Highlight;
            panel6.Controls.Add(label20);
            panel6.Controls.Add(label6);
            panel6.Controls.Add(lblArchivedUsers);
            panel6.Font = new Font("Gadugi", 8F);
            panel6.ForeColor = SystemColors.ButtonHighlight;
            panel6.Location = new Point(291, 284);
            panel6.Margin = new Padding(2);
            panel6.Name = "panel6";
            panel6.Size = new Size(294, 114);
            panel6.TabIndex = 50;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Gadugi", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label20.ForeColor = Color.Red;
            label20.Location = new Point(232, 65);
            label20.Margin = new Padding(2, 0, 2, 0);
            label20.Name = "label20";
            label20.Size = new Size(48, 33);
            label20.TabIndex = 58;
            label20.Text = "\U0001f7e2";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Gadugi", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(2, 6);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(118, 20);
            label6.TabIndex = 53;
            label6.Text = "Inactive Users:";
            // 
            // panel7
            // 
            panel7.BackColor = SystemColors.Highlight;
            panel7.Controls.Add(label18);
            panel7.Controls.Add(label7);
            panel7.Controls.Add(lblAttendantCount);
            panel7.Font = new Font("Gadugi", 8F);
            panel7.ForeColor = SystemColors.ButtonHighlight;
            panel7.Location = new Point(926, 146);
            panel7.Margin = new Padding(2);
            panel7.Name = "panel7";
            panel7.Size = new Size(294, 114);
            panel7.TabIndex = 51;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Gadugi", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label18.Location = new Point(228, 68);
            label18.Margin = new Padding(2, 0, 2, 0);
            label18.Name = "label18";
            label18.Size = new Size(48, 33);
            label18.TabIndex = 59;
            label18.Text = "🙋";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Gadugi", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(0, 2);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(163, 20);
            label7.TabIndex = 53;
            label7.Text = "Laundry Attendants:";
            // 
            // panel8
            // 
            panel8.BackColor = SystemColors.GradientActiveCaption;
            panel8.Controls.Add(label15);
            panel8.Controls.Add(lblLatestUser);
            panel8.Controls.Add(lblLatestUserDate);
            panel8.Font = new Font("Gadugi", 8F);
            panel8.ForeColor = SystemColors.ButtonHighlight;
            panel8.Location = new Point(1618, 163);
            panel8.Margin = new Padding(2);
            panel8.Name = "panel8";
            panel8.Size = new Size(264, 69);
            panel8.TabIndex = 52;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.ForeColor = SystemColors.ActiveCaptionText;
            label15.Location = new Point(14, 13);
            label15.Margin = new Padding(2, 0, 2, 0);
            label15.Name = "label15";
            label15.Size = new Size(24, 17);
            label15.TabIndex = 58;
            label15.Text = "👤";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Gadugi", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(1634, 148);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(97, 20);
            label8.TabIndex = 53;
            label8.Text = "Latest User:";
            label8.Click += label8_Click;
            // 
            // panel9
            // 
            panel9.BackColor = SystemColors.GradientActiveCaption;
            panel9.Controls.Add(lblGrowthRate);
            panel9.Controls.Add(label16);
            panel9.Font = new Font("Gadugi", 8F);
            panel9.ForeColor = SystemColors.ButtonHighlight;
            panel9.Location = new Point(1618, 293);
            panel9.Margin = new Padding(2);
            panel9.Name = "panel9";
            panel9.Size = new Size(195, 74);
            panel9.TabIndex = 53;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.ForeColor = SystemColors.ActiveCaptionText;
            label16.Location = new Point(14, 32);
            label16.Margin = new Padding(2, 0, 2, 0);
            label16.Name = "label16";
            label16.Size = new Size(24, 17);
            label16.TabIndex = 59;
            label16.Text = "📈";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Gadugi", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(1634, 287);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(108, 20);
            label9.TabIndex = 58;
            label9.Text = "Growth Rate:";
            // 
            // panel10
            // 
            panel10.BackColor = SystemColors.Highlight;
            panel10.Controls.Add(label21);
            panel10.Controls.Add(label10);
            panel10.Controls.Add(lblNewUsersMonth);
            panel10.Font = new Font("Gadugi", 8F);
            panel10.ForeColor = SystemColors.ButtonHighlight;
            panel10.Location = new Point(1244, 284);
            panel10.Margin = new Padding(2);
            panel10.Name = "panel10";
            panel10.Size = new Size(294, 114);
            panel10.TabIndex = 54;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Gadugi", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label21.Location = new Point(178, 66);
            label21.Margin = new Padding(2, 0, 2, 0);
            label21.Name = "label21";
            label21.Size = new Size(114, 33);
            label21.TabIndex = 58;
            label21.Text = "👤👤👤";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Gadugi", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(2, 0);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(224, 20);
            label10.TabIndex = 58;
            label10.Text = "New Customers This Month:";
            // 
            // panel11
            // 
            panel11.BackColor = SystemColors.Highlight;
            panel11.Controls.Add(label22);
            panel11.Controls.Add(label11);
            panel11.Controls.Add(lblNewUsersLastMonth);
            panel11.Font = new Font("Gadugi", 8F);
            panel11.ForeColor = SystemColors.ButtonHighlight;
            panel11.Location = new Point(926, 284);
            panel11.Margin = new Padding(2);
            panel11.Name = "panel11";
            panel11.Size = new Size(294, 114);
            panel11.TabIndex = 55;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Gadugi", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label22.Location = new Point(174, 66);
            label22.Margin = new Padding(2, 0, 2, 0);
            label22.Name = "label22";
            label22.Size = new Size(114, 33);
            label22.TabIndex = 59;
            label22.Text = "👤👤👤";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Gadugi", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(-2, 0);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(185, 20);
            label11.TabIndex = 58;
            label11.Text = "Last Month Customers:";
            // 
            // panel12
            // 
            panel12.BackColor = SystemColors.Highlight;
            panel12.Controls.Add(label17);
            panel12.Controls.Add(label12);
            panel12.Controls.Add(lblAdminCount);
            panel12.Font = new Font("Gadugi", 8F);
            panel12.ForeColor = SystemColors.ButtonHighlight;
            panel12.Location = new Point(1244, 146);
            panel12.Margin = new Padding(2);
            panel12.Name = "panel12";
            panel12.Size = new Size(294, 114);
            panel12.TabIndex = 56;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Gadugi", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label17.Location = new Point(240, 72);
            label17.Margin = new Padding(2, 0, 2, 0);
            label17.Name = "label17";
            label17.Size = new Size(48, 33);
            label17.TabIndex = 58;
            label17.Text = "\U0001f9d1‍💼";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Gadugi", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(2, 0);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(70, 20);
            label12.TabIndex = 58;
            label12.Text = "Admins:";
            // 
            // panel13
            // 
            panel13.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel13.BackColor = SystemColors.GradientActiveCaption;
            panel13.Controls.Add(label23);
            panel13.Controls.Add(dateTimePickerTo);
            panel13.Controls.Add(dateTimePickerFrom);
            panel13.Controls.Add(buttonLoadGraph);
            panel13.Controls.Add(buttonLoadGraphToday);
            panel13.Controls.Add(buttonLoadGraphWeek);
            panel13.Controls.Add(buttonLoadGraphMonth);
            panel13.Location = new Point(224, 441);
            panel13.Margin = new Padding(2);
            panel13.Name = "panel13";
            panel13.Size = new Size(1675, 66);
            panel13.TabIndex = 57;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Gadugi", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label23.Location = new Point(154, 15);
            label23.Margin = new Padding(4, 0, 4, 0);
            label23.Name = "label23";
            label23.Size = new Size(31, 27);
            label23.TabIndex = 59;
            label23.Text = "➜";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BackColor = SystemColors.GradientActiveCaption;
            pictureBox1.Location = new Point(224, 108);
            pictureBox1.Margin = new Padding(2, 3, 2, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1679, 23);
            pictureBox1.TabIndex = 58;
            pictureBox1.TabStop = false;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 856);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(label_welcome);
            Controls.Add(pictureBox1);
            Controls.Add(panel12);
            Controls.Add(panel9);
            Controls.Add(panel11);
            Controls.Add(panel10);
            Controls.Add(panel8);
            Controls.Add(panel7);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(chart1);
            Controls.Add(panel3);
            Controls.Add(panel13);
            Margin = new Padding(5, 3, 5, 3);
            Name = "AdminForm";
            Text = "Admin | Dashboard";
            Load += AdminForm_Load;
            Controls.SetChildIndex(panel13, 0);
            Controls.SetChildIndex(panel3, 0);
            Controls.SetChildIndex(chart1, 0);
            Controls.SetChildIndex(panel4, 0);
            Controls.SetChildIndex(panel5, 0);
            Controls.SetChildIndex(panel6, 0);
            Controls.SetChildIndex(panel7, 0);
            Controls.SetChildIndex(panel8, 0);
            Controls.SetChildIndex(panel10, 0);
            Controls.SetChildIndex(panel11, 0);
            Controls.SetChildIndex(panel9, 0);
            Controls.SetChildIndex(panel12, 0);
            Controls.SetChildIndex(pictureBox1, 0);
            Controls.SetChildIndex(label_welcome, 0);
            Controls.SetChildIndex(label9, 0);
            Controls.SetChildIndex(label8, 0);
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            panel12.ResumeLayout(false);
            panel12.PerformLayout();
            panel13.ResumeLayout(false);
            panel13.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private Label label4;
        private Label label_welcome;
        private Label lblTotalUsers;
        private Label lblActiveUsers;
        private Label lblArchivedUsers;
        private Label lblAdminCount;
        private Label lblAttendantCount;
        private Label lblCustomerCount;
        private Label lblNewUsersMonth;
        private Label lblNewUsersLastMonth;
        private Label lblLatestUser;
        private Label lblLatestUserDate;
        private Label lblGrowthRate;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private DateTimePicker dateTimePickerTo;
        private DateTimePicker dateTimePickerFrom;
        private Button buttonLoadGraph;
        private Button buttonLoadGraphMonth;
        private Button buttonLoadGraphWeek;
        private Button buttonLoadGraphToday;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Panel panel7;
        private Label label1;
        private Label label2;
        private Label label5;
        private Label label6;
        private Label label7;
        private Panel panel8;
        private Label label8;
        private Panel panel9;
        private Label label9;
        private Panel panel10;
        private Label label10;
        private Panel panel11;
        private Label label11;
        private Panel panel12;
        private Panel panel13;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label19;
        private Label label20;
        private Label label18;
        private Label label21;
        private Label label22;
        private PictureBox pictureBox1;
        private Label label23;
    }
}