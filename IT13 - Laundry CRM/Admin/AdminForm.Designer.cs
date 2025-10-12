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
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
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
            label_welcome.Font = new Font("Cascadia Code SemiBold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_welcome.ForeColor = SystemColors.ActiveCaptionText;
            label_welcome.Location = new Point(194, 72);
            label_welcome.Margin = new Padding(2, 0, 2, 0);
            label_welcome.Name = "label_welcome";
            label_welcome.Size = new Size(161, 40);
            label_welcome.TabIndex = 28;
            label_welcome.Text = "Welcome!";
            // 
            // lblTotalUsers
            // 
            lblTotalUsers.AutoSize = true;
            lblTotalUsers.Location = new Point(194, 127);
            lblTotalUsers.Margin = new Padding(2, 0, 2, 0);
            lblTotalUsers.Name = "lblTotalUsers";
            lblTotalUsers.Size = new Size(79, 20);
            lblTotalUsers.TabIndex = 29;
            lblTotalUsers.Text = "Total users";
            // 
            // lblActiveUsers
            // 
            lblActiveUsers.AutoSize = true;
            lblActiveUsers.Location = new Point(634, 127);
            lblActiveUsers.Margin = new Padding(2, 0, 2, 0);
            lblActiveUsers.Name = "lblActiveUsers";
            lblActiveUsers.Size = new Size(50, 20);
            lblActiveUsers.TabIndex = 30;
            lblActiveUsers.Text = "Active";
            // 
            // lblArchivedUsers
            // 
            lblArchivedUsers.AutoSize = true;
            lblArchivedUsers.Location = new Point(618, 165);
            lblArchivedUsers.Margin = new Padding(2, 0, 2, 0);
            lblArchivedUsers.Name = "lblArchivedUsers";
            lblArchivedUsers.Size = new Size(60, 20);
            lblArchivedUsers.TabIndex = 31;
            lblArchivedUsers.Text = "Inactive";
            // 
            // lblAdminCount
            // 
            lblAdminCount.AutoSize = true;
            lblAdminCount.Location = new Point(533, 132);
            lblAdminCount.Margin = new Padding(2, 0, 2, 0);
            lblAdminCount.Name = "lblAdminCount";
            lblAdminCount.Size = new Size(53, 20);
            lblAdminCount.TabIndex = 32;
            lblAdminCount.Text = "Admin";
            // 
            // lblAttendantCount
            // 
            lblAttendantCount.AutoSize = true;
            lblAttendantCount.Location = new Point(419, 127);
            lblAttendantCount.Margin = new Padding(2, 0, 2, 0);
            lblAttendantCount.Name = "lblAttendantCount";
            lblAttendantCount.Size = new Size(75, 40);
            lblAttendantCount.TabIndex = 33;
            lblAttendantCount.Text = "Laundry \r\nAttendant";
            // 
            // lblCustomerCount
            // 
            lblCustomerCount.AutoSize = true;
            lblCustomerCount.Location = new Point(322, 127);
            lblCustomerCount.Margin = new Padding(2, 0, 2, 0);
            lblCustomerCount.Name = "lblCustomerCount";
            lblCustomerCount.Size = new Size(72, 20);
            lblCustomerCount.TabIndex = 34;
            lblCustomerCount.Text = "Customer";
            // 
            // lblNewUsersMonth
            // 
            lblNewUsersMonth.AutoSize = true;
            lblNewUsersMonth.Location = new Point(505, 235);
            lblNewUsersMonth.Margin = new Padding(2, 0, 2, 0);
            lblNewUsersMonth.Name = "lblNewUsersMonth";
            lblNewUsersMonth.Size = new Size(50, 20);
            lblNewUsersMonth.TabIndex = 35;
            lblNewUsersMonth.Text = "label9";
            // 
            // lblNewUsersLastMonth
            // 
            lblNewUsersLastMonth.AutoSize = true;
            lblNewUsersLastMonth.Location = new Point(582, 235);
            lblNewUsersLastMonth.Margin = new Padding(2, 0, 2, 0);
            lblNewUsersLastMonth.Name = "lblNewUsersLastMonth";
            lblNewUsersLastMonth.Size = new Size(58, 20);
            lblNewUsersLastMonth.TabIndex = 36;
            lblNewUsersLastMonth.Text = "label10";
            // 
            // lblLatestUser
            // 
            lblLatestUser.AutoSize = true;
            lblLatestUser.Location = new Point(180, 223);
            lblLatestUser.Margin = new Padding(2, 0, 2, 0);
            lblLatestUser.Name = "lblLatestUser";
            lblLatestUser.Size = new Size(158, 20);
            lblLatestUser.TabIndex = 37;
            lblLatestUser.Text = "Latest  Registered user";
            // 
            // lblLatestUserDate
            // 
            lblLatestUserDate.AutoSize = true;
            lblLatestUserDate.Location = new Point(194, 254);
            lblLatestUserDate.Margin = new Padding(2, 0, 2, 0);
            lblLatestUserDate.Name = "lblLatestUserDate";
            lblLatestUserDate.Size = new Size(110, 20);
            lblLatestUserDate.TabIndex = 38;
            lblLatestUserDate.Text = "latest user date";
            // 
            // lblGrowthRate
            // 
            lblGrowthRate.AutoSize = true;
            lblGrowthRate.Location = new Point(410, 254);
            lblGrowthRate.Margin = new Padding(2, 0, 2, 0);
            lblGrowthRate.Name = "lblGrowthRate";
            lblGrowthRate.Size = new Size(50, 20);
            lblGrowthRate.TabIndex = 39;
            lblGrowthRate.Text = "label1";
            // 
            // chart1
            // 
            chart1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(187, 348);
            chart1.Margin = new Padding(2, 4, 2, 4);
            chart1.Name = "chart1";
            chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series1.ChartArea = "ChartArea1";
            series1.IsXValueIndexed = true;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.YValuesPerPoint = 2;
            chart1.Series.Add(series1);
            chart1.Size = new Size(1000, 349);
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
            dateTimePickerTo.Location = new Point(480, 304);
            dateTimePickerTo.Margin = new Padding(3, 2, 3, 2);
            dateTimePickerTo.Name = "dateTimePickerTo";
            dateTimePickerTo.Size = new Size(251, 27);
            dateTimePickerTo.TabIndex = 43;
            // 
            // dateTimePickerFrom
            // 
            dateTimePickerFrom.CalendarMonthBackground = SystemColors.GradientActiveCaption;
            dateTimePickerFrom.CalendarTitleBackColor = SystemColors.GradientActiveCaption;
            dateTimePickerFrom.Location = new Point(215, 304);
            dateTimePickerFrom.Margin = new Padding(3, 2, 3, 2);
            dateTimePickerFrom.Name = "dateTimePickerFrom";
            dateTimePickerFrom.Size = new Size(245, 27);
            dateTimePickerFrom.TabIndex = 42;
            // 
            // buttonLoadGraph
            // 
            buttonLoadGraph.BackColor = SystemColors.Highlight;
            buttonLoadGraph.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonLoadGraph.ForeColor = SystemColors.ButtonHighlight;
            buttonLoadGraph.Location = new Point(748, 303);
            buttonLoadGraph.Margin = new Padding(3, 2, 3, 2);
            buttonLoadGraph.Name = "buttonLoadGraph";
            buttonLoadGraph.Size = new Size(90, 30);
            buttonLoadGraph.TabIndex = 41;
            buttonLoadGraph.Text = "Custom";
            buttonLoadGraph.UseVisualStyleBackColor = false;
            // 
            // buttonLoadGraphMonth
            // 
            buttonLoadGraphMonth.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonLoadGraphMonth.Location = new Point(1081, 302);
            buttonLoadGraphMonth.Margin = new Padding(3, 4, 3, 4);
            buttonLoadGraphMonth.Name = "buttonLoadGraphMonth";
            buttonLoadGraphMonth.Size = new Size(83, 30);
            buttonLoadGraphMonth.TabIndex = 46;
            buttonLoadGraphMonth.Text = "Month";
            buttonLoadGraphMonth.UseVisualStyleBackColor = true;
            // 
            // buttonLoadGraphWeek
            // 
            buttonLoadGraphWeek.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonLoadGraphWeek.Location = new Point(985, 303);
            buttonLoadGraphWeek.Margin = new Padding(3, 4, 3, 4);
            buttonLoadGraphWeek.Name = "buttonLoadGraphWeek";
            buttonLoadGraphWeek.Size = new Size(90, 30);
            buttonLoadGraphWeek.TabIndex = 45;
            buttonLoadGraphWeek.Text = "Week";
            buttonLoadGraphWeek.UseVisualStyleBackColor = true;
            // 
            // buttonLoadGraphToday
            // 
            buttonLoadGraphToday.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonLoadGraphToday.Location = new Point(911, 303);
            buttonLoadGraphToday.Margin = new Padding(3, 4, 3, 4);
            buttonLoadGraphToday.Name = "buttonLoadGraphToday";
            buttonLoadGraphToday.Size = new Size(68, 30);
            buttonLoadGraphToday.TabIndex = 44;
            buttonLoadGraphToday.Text = "Today";
            buttonLoadGraphToday.UseVisualStyleBackColor = true;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1198, 915);
            Controls.Add(buttonLoadGraphMonth);
            Controls.Add(buttonLoadGraphWeek);
            Controls.Add(buttonLoadGraphToday);
            Controls.Add(dateTimePickerTo);
            Controls.Add(dateTimePickerFrom);
            Controls.Add(buttonLoadGraph);
            Controls.Add(chart1);
            Controls.Add(lblGrowthRate);
            Controls.Add(lblLatestUserDate);
            Controls.Add(lblLatestUser);
            Controls.Add(lblNewUsersLastMonth);
            Controls.Add(lblNewUsersMonth);
            Controls.Add(lblCustomerCount);
            Controls.Add(lblAttendantCount);
            Controls.Add(lblAdminCount);
            Controls.Add(lblArchivedUsers);
            Controls.Add(lblActiveUsers);
            Controls.Add(lblTotalUsers);
            Controls.Add(label_welcome);
            Margin = new Padding(4, 3, 4, 3);
            Name = "AdminForm";
            Text = "Admin | Dashboard";
            Load += AdminForm_Load;
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
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
    }
}