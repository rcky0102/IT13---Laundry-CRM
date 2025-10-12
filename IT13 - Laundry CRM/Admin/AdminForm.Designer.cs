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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
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
            label1 = new Label();
            panel4 = new Panel();
            label2 = new Label();
            panel5 = new Panel();
            label5 = new Label();
            panel6 = new Panel();
            label6 = new Label();
            panel7 = new Panel();
            label7 = new Label();
            panel8 = new Panel();
            label8 = new Label();
            panel9 = new Panel();
            label9 = new Label();
            panel10 = new Panel();
            label10 = new Label();
            panel11 = new Panel();
            label11 = new Label();
            panel12 = new Panel();
            label12 = new Label();
            panel13 = new Panel();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            label19 = new Label();
            label20 = new Label();
            label21 = new Label();
            label22 = new Label();
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
            label_welcome.Font = new Font("Gadugi", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_welcome.ForeColor = SystemColors.ActiveCaptionText;
            label_welcome.Location = new Point(290, 97);
            label_welcome.Margin = new Padding(2, 0, 2, 0);
            label_welcome.Name = "label_welcome";
            label_welcome.Size = new Size(179, 43);
            label_welcome.TabIndex = 28;
            label_welcome.Text = "Welcome!";
            // 
            // lblTotalUsers
            // 
            lblTotalUsers.AutoSize = true;
            lblTotalUsers.Location = new Point(84, 44);
            lblTotalUsers.Margin = new Padding(2, 0, 2, 0);
            lblTotalUsers.Name = "lblTotalUsers";
            lblTotalUsers.Size = new Size(84, 19);
            lblTotalUsers.TabIndex = 29;
            lblTotalUsers.Text = "Total users";
            // 
            // lblActiveUsers
            // 
            lblActiveUsers.AutoSize = true;
            lblActiveUsers.Font = new Font("Gadugi", 8F);
            lblActiveUsers.Location = new Point(91, 43);
            lblActiveUsers.Margin = new Padding(2, 0, 2, 0);
            lblActiveUsers.Name = "lblActiveUsers";
            lblActiveUsers.Size = new Size(51, 19);
            lblActiveUsers.TabIndex = 30;
            lblActiveUsers.Text = "Active";
            // 
            // lblArchivedUsers
            // 
            lblArchivedUsers.AutoSize = true;
            lblArchivedUsers.Font = new Font("Gadugi", 8F);
            lblArchivedUsers.Location = new Point(81, 43);
            lblArchivedUsers.Margin = new Padding(2, 0, 2, 0);
            lblArchivedUsers.Name = "lblArchivedUsers";
            lblArchivedUsers.Size = new Size(62, 19);
            lblArchivedUsers.TabIndex = 31;
            lblArchivedUsers.Text = "Inactive";
            // 
            // lblAdminCount
            // 
            lblAdminCount.AutoSize = true;
            lblAdminCount.Font = new Font("Gadugi", 8F);
            lblAdminCount.Location = new Point(91, 48);
            lblAdminCount.Margin = new Padding(2, 0, 2, 0);
            lblAdminCount.Name = "lblAdminCount";
            lblAdminCount.Size = new Size(55, 19);
            lblAdminCount.TabIndex = 32;
            lblAdminCount.Text = "Admin";
            // 
            // lblAttendantCount
            // 
            lblAttendantCount.AutoSize = true;
            lblAttendantCount.Font = new Font("Gadugi", 8F);
            lblAttendantCount.Location = new Point(86, 43);
            lblAttendantCount.Margin = new Padding(2, 0, 2, 0);
            lblAttendantCount.Name = "lblAttendantCount";
            lblAttendantCount.Size = new Size(77, 38);
            lblAttendantCount.TabIndex = 33;
            lblAttendantCount.Text = "Laundry \r\nAttendant";
            // 
            // lblCustomerCount
            // 
            lblCustomerCount.AutoSize = true;
            lblCustomerCount.Font = new Font("Gadugi", 8F);
            lblCustomerCount.Location = new Point(81, 43);
            lblCustomerCount.Margin = new Padding(2, 0, 2, 0);
            lblCustomerCount.Name = "lblCustomerCount";
            lblCustomerCount.Size = new Size(77, 19);
            lblCustomerCount.TabIndex = 34;
            lblCustomerCount.Text = "Customer";
            // 
            // lblNewUsersMonth
            // 
            lblNewUsersMonth.AutoSize = true;
            lblNewUsersMonth.Font = new Font("Gadugi", 8F);
            lblNewUsersMonth.Location = new Point(63, 48);
            lblNewUsersMonth.Margin = new Padding(2, 0, 2, 0);
            lblNewUsersMonth.Name = "lblNewUsersMonth";
            lblNewUsersMonth.Size = new Size(143, 19);
            lblNewUsersMonth.TabIndex = 35;
            lblNewUsersMonth.Text = "lblNewUsersMonth";
            // 
            // lblNewUsersLastMonth
            // 
            lblNewUsersLastMonth.AutoSize = true;
            lblNewUsersLastMonth.Font = new Font("Gadugi", 8F);
            lblNewUsersLastMonth.Location = new Point(44, 48);
            lblNewUsersLastMonth.Margin = new Padding(2, 0, 2, 0);
            lblNewUsersLastMonth.Name = "lblNewUsersLastMonth";
            lblNewUsersLastMonth.Size = new Size(171, 19);
            lblNewUsersLastMonth.TabIndex = 36;
            lblNewUsersLastMonth.Text = "lblNewUsersLastMonth";
            // 
            // lblLatestUser
            // 
            lblLatestUser.AutoSize = true;
            lblLatestUser.Font = new Font("Gadugi", 8F);
            lblLatestUser.Location = new Point(34, 48);
            lblLatestUser.Margin = new Padding(2, 0, 2, 0);
            lblLatestUser.Name = "lblLatestUser";
            lblLatestUser.Size = new Size(166, 19);
            lblLatestUser.TabIndex = 37;
            lblLatestUser.Text = "Latest  Registered user";
            // 
            // lblLatestUserDate
            // 
            lblLatestUserDate.AutoSize = true;
            lblLatestUserDate.Font = new Font("Gadugi", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLatestUserDate.Location = new Point(347, 444);
            lblLatestUserDate.Margin = new Padding(2, 0, 2, 0);
            lblLatestUserDate.Name = "lblLatestUserDate";
            lblLatestUserDate.Size = new Size(142, 24);
            lblLatestUserDate.TabIndex = 38;
            lblLatestUserDate.Text = "latest user date";
            // 
            // lblGrowthRate
            // 
            lblGrowthRate.AutoSize = true;
            lblGrowthRate.Font = new Font("Gadugi", 8F);
            lblGrowthRate.Location = new Point(58, 48);
            lblGrowthRate.Margin = new Padding(2, 0, 2, 0);
            lblGrowthRate.Name = "lblGrowthRate";
            lblGrowthRate.Size = new Size(109, 19);
            lblGrowthRate.TabIndex = 39;
            lblGrowthRate.Text = "lblGrowthRate";
            // 
            // chart1
            // 
            chart1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            chartArea2.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea2);
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend2.Name = "Legend1";
            chart1.Legends.Add(legend2);
            chart1.Location = new Point(269, 579);
            chart1.Margin = new Padding(2, 5, 2, 5);
            chart1.Name = "chart1";
            chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series2.ChartArea = "ChartArea1";
            series2.IsXValueIndexed = true;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            series2.YValuesPerPoint = 2;
            chart1.Series.Add(series2);
            chart1.Size = new Size(1500, 471);
            chart1.TabIndex = 40;
            chart1.Text = "chart1";
            title2.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Top;
            title2.Name = "Title1";
            title2.Text = "Customer";
            chart1.Titles.Add(title2);
            chart1.Click += chart1_Click;
            // 
            // dateTimePickerTo
            // 
            dateTimePickerTo.Font = new Font("Gadugi", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePickerTo.Location = new Point(389, 23);
            dateTimePickerTo.Margin = new Padding(5, 2, 5, 2);
            dateTimePickerTo.Name = "dateTimePickerTo";
            dateTimePickerTo.Size = new Size(375, 34);
            dateTimePickerTo.TabIndex = 43;
            // 
            // dateTimePickerFrom
            // 
            dateTimePickerFrom.CalendarMonthBackground = SystemColors.GradientActiveCaption;
            dateTimePickerFrom.CalendarTitleBackColor = SystemColors.GradientActiveCaption;
            dateTimePickerFrom.Font = new Font("Gadugi", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePickerFrom.Location = new Point(14, 22);
            dateTimePickerFrom.Margin = new Padding(5, 2, 5, 2);
            dateTimePickerFrom.Name = "dateTimePickerFrom";
            dateTimePickerFrom.Size = new Size(365, 34);
            dateTimePickerFrom.TabIndex = 42;
            // 
            // buttonLoadGraph
            // 
            buttonLoadGraph.BackColor = SystemColors.Highlight;
            buttonLoadGraph.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonLoadGraph.ForeColor = SystemColors.ButtonHighlight;
            buttonLoadGraph.Location = new Point(812, 21);
            buttonLoadGraph.Margin = new Padding(5, 2, 5, 2);
            buttonLoadGraph.Name = "buttonLoadGraph";
            buttonLoadGraph.Size = new Size(134, 40);
            buttonLoadGraph.TabIndex = 41;
            buttonLoadGraph.Text = "Custom";
            buttonLoadGraph.UseVisualStyleBackColor = false;
            buttonLoadGraph.Click += buttonLoadGraph_Click;
            // 
            // buttonLoadGraphMonth
            // 
            buttonLoadGraphMonth.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonLoadGraphMonth.Font = new Font("Gadugi", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonLoadGraphMonth.Location = new Point(1311, 22);
            buttonLoadGraphMonth.Margin = new Padding(5);
            buttonLoadGraphMonth.Name = "buttonLoadGraphMonth";
            buttonLoadGraphMonth.Size = new Size(125, 40);
            buttonLoadGraphMonth.TabIndex = 46;
            buttonLoadGraphMonth.Text = "Month";
            buttonLoadGraphMonth.UseVisualStyleBackColor = true;
            buttonLoadGraphMonth.Click += buttonLoadGraphMonth_Click;
            // 
            // buttonLoadGraphWeek
            // 
            buttonLoadGraphWeek.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonLoadGraphWeek.Font = new Font("Gadugi", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonLoadGraphWeek.Location = new Point(1167, 22);
            buttonLoadGraphWeek.Margin = new Padding(5);
            buttonLoadGraphWeek.Name = "buttonLoadGraphWeek";
            buttonLoadGraphWeek.Size = new Size(134, 40);
            buttonLoadGraphWeek.TabIndex = 45;
            buttonLoadGraphWeek.Text = "Week";
            buttonLoadGraphWeek.UseVisualStyleBackColor = true;
            buttonLoadGraphWeek.Click += buttonLoadGraphWeek_Click;
            // 
            // buttonLoadGraphToday
            // 
            buttonLoadGraphToday.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonLoadGraphToday.Font = new Font("Gadugi", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonLoadGraphToday.Location = new Point(1055, 21);
            buttonLoadGraphToday.Margin = new Padding(5);
            buttonLoadGraphToday.Name = "buttonLoadGraphToday";
            buttonLoadGraphToday.Size = new Size(102, 40);
            buttonLoadGraphToday.TabIndex = 44;
            buttonLoadGraphToday.Text = "Today";
            buttonLoadGraphToday.UseVisualStyleBackColor = true;
            buttonLoadGraphToday.Click += buttonLoadGraphToday_Click;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.Highlight;
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(label13);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(lblTotalUsers);
            panel3.Font = new Font("Gadugi", 8F);
            panel3.ForeColor = SystemColors.ButtonHighlight;
            panel3.Location = new Point(347, 179);
            panel3.Name = "panel3";
            panel3.Size = new Size(240, 103);
            panel3.TabIndex = 47;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gadugi", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 7);
            label1.Name = "label1";
            label1.Size = new Size(147, 24);
            label1.TabIndex = 52;
            label1.Text = "Total Customer:";
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.Highlight;
            panel4.BorderStyle = BorderStyle.Fixed3D;
            panel4.Controls.Add(label14);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(lblCustomerCount);
            panel4.Font = new Font("Gadugi", 8F);
            panel4.ForeColor = SystemColors.ButtonHighlight;
            panel4.Location = new Point(621, 179);
            panel4.Name = "panel4";
            panel4.Size = new Size(240, 103);
            panel4.TabIndex = 48;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Gadugi", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 2);
            label2.Name = "label2";
            label2.Size = new Size(98, 24);
            label2.TabIndex = 53;
            label2.Text = "Customer:";
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel5.BackColor = SystemColors.Highlight;
            panel5.BorderStyle = BorderStyle.Fixed3D;
            panel5.Controls.Add(label19);
            panel5.Controls.Add(label5);
            panel5.Controls.Add(lblActiveUsers);
            panel5.Font = new Font("Gadugi", 8F);
            panel5.ForeColor = SystemColors.ButtonHighlight;
            panel5.Location = new Point(895, 179);
            panel5.Name = "panel5";
            panel5.Size = new Size(240, 103);
            panel5.TabIndex = 49;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Gadugi", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(3, 2);
            label5.Name = "label5";
            label5.Size = new Size(108, 24);
            label5.TabIndex = 53;
            label5.Text = "Active User";
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.Highlight;
            panel6.BorderStyle = BorderStyle.Fixed3D;
            panel6.Controls.Add(label20);
            panel6.Controls.Add(label6);
            panel6.Controls.Add(lblArchivedUsers);
            panel6.Font = new Font("Gadugi", 8F);
            panel6.ForeColor = SystemColors.ButtonHighlight;
            panel6.Location = new Point(1169, 179);
            panel6.Name = "panel6";
            panel6.Size = new Size(240, 103);
            panel6.TabIndex = 50;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Gadugi", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(3, 7);
            label6.Name = "label6";
            label6.Size = new Size(125, 24);
            label6.TabIndex = 53;
            label6.Text = "Inactive User:";
            // 
            // panel7
            // 
            panel7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel7.BackColor = SystemColors.Highlight;
            panel7.BorderStyle = BorderStyle.Fixed3D;
            panel7.Controls.Add(label18);
            panel7.Controls.Add(label7);
            panel7.Controls.Add(lblAttendantCount);
            panel7.Font = new Font("Gadugi", 8F);
            panel7.ForeColor = SystemColors.ButtonHighlight;
            panel7.Location = new Point(1445, 179);
            panel7.Name = "panel7";
            panel7.Size = new Size(240, 103);
            panel7.TabIndex = 51;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Gadugi", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(0, 2);
            label7.Name = "label7";
            label7.Size = new Size(202, 24);
            label7.TabIndex = 53;
            label7.Text = "Number Of attendant:";
            // 
            // panel8
            // 
            panel8.BackColor = SystemColors.Highlight;
            panel8.BorderStyle = BorderStyle.Fixed3D;
            panel8.Controls.Add(label15);
            panel8.Controls.Add(label8);
            panel8.Controls.Add(lblLatestUser);
            panel8.Font = new Font("Gadugi", 8F);
            panel8.ForeColor = SystemColors.ButtonHighlight;
            panel8.Location = new Point(347, 305);
            panel8.Name = "panel8";
            panel8.Size = new Size(240, 103);
            panel8.TabIndex = 52;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Gadugi", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(3, 8);
            label8.Name = "label8";
            label8.Size = new Size(154, 24);
            label8.TabIndex = 53;
            label8.Text = "Latest Customer:";
            // 
            // panel9
            // 
            panel9.BackColor = SystemColors.Highlight;
            panel9.BorderStyle = BorderStyle.Fixed3D;
            panel9.Controls.Add(label16);
            panel9.Controls.Add(label9);
            panel9.Controls.Add(lblGrowthRate);
            panel9.Font = new Font("Gadugi", 8F);
            panel9.ForeColor = SystemColors.ButtonHighlight;
            panel9.Location = new Point(621, 305);
            panel9.Name = "panel9";
            panel9.Size = new Size(240, 103);
            panel9.TabIndex = 53;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Gadugi", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(3, 8);
            label9.Name = "label9";
            label9.Size = new Size(123, 24);
            label9.TabIndex = 58;
            label9.Text = "Growth Rate:";
            // 
            // panel10
            // 
            panel10.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel10.BackColor = SystemColors.Highlight;
            panel10.BorderStyle = BorderStyle.Fixed3D;
            panel10.Controls.Add(label21);
            panel10.Controls.Add(label10);
            panel10.Controls.Add(lblNewUsersMonth);
            panel10.Font = new Font("Gadugi", 8F);
            panel10.ForeColor = SystemColors.ButtonHighlight;
            panel10.Location = new Point(895, 305);
            panel10.Name = "panel10";
            panel10.Size = new Size(240, 103);
            panel10.TabIndex = 54;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Gadugi", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(3, 0);
            label10.Name = "label10";
            label10.Size = new Size(169, 24);
            label10.TabIndex = 58;
            label10.Text = "New Users Month:";
            // 
            // panel11
            // 
            panel11.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel11.BackColor = SystemColors.Highlight;
            panel11.BorderStyle = BorderStyle.Fixed3D;
            panel11.Controls.Add(label22);
            panel11.Controls.Add(label11);
            panel11.Controls.Add(lblNewUsersLastMonth);
            panel11.Font = new Font("Gadugi", 8F);
            panel11.ForeColor = SystemColors.ButtonHighlight;
            panel11.Location = new Point(1169, 305);
            panel11.Name = "panel11";
            panel11.Size = new Size(240, 103);
            panel11.TabIndex = 55;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Gadugi", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(-2, 0);
            label11.Name = "label11";
            label11.Size = new Size(201, 24);
            label11.TabIndex = 58;
            label11.Text = "Last Month Customer:";
            // 
            // panel12
            // 
            panel12.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel12.BackColor = SystemColors.Highlight;
            panel12.BorderStyle = BorderStyle.Fixed3D;
            panel12.Controls.Add(label17);
            panel12.Controls.Add(label12);
            panel12.Controls.Add(lblAdminCount);
            panel12.Font = new Font("Gadugi", 8F);
            panel12.ForeColor = SystemColors.ButtonHighlight;
            panel12.Location = new Point(1445, 305);
            panel12.Name = "panel12";
            panel12.Size = new Size(240, 103);
            panel12.TabIndex = 56;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Gadugi", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(3, 0);
            label12.Name = "label12";
            label12.Size = new Size(72, 24);
            label12.TabIndex = 58;
            label12.Text = "Admin:";
            // 
            // panel13
            // 
            panel13.BackColor = SystemColors.GradientActiveCaption;
            panel13.BorderStyle = BorderStyle.Fixed3D;
            panel13.Controls.Add(dateTimePickerTo);
            panel13.Controls.Add(dateTimePickerFrom);
            panel13.Controls.Add(buttonLoadGraph);
            panel13.Controls.Add(buttonLoadGraphToday);
            panel13.Controls.Add(buttonLoadGraphWeek);
            panel13.Controls.Add(buttonLoadGraphMonth);
            panel13.Location = new Point(290, 493);
            panel13.Name = "panel13";
            panel13.Size = new Size(1479, 80);
            panel13.TabIndex = 57;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(208, 80);
            label13.Name = "label13";
            label13.Size = new Size(25, 19);
            label13.TabIndex = 58;
            label13.Text = "👥";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(208, 80);
            label14.Name = "label14";
            label14.Size = new Size(25, 19);
            label14.TabIndex = 54;
            label14.Text = "\U0001f9d1";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(208, 80);
            label15.Name = "label15";
            label15.Size = new Size(25, 19);
            label15.TabIndex = 58;
            label15.Text = "👤";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(208, 80);
            label16.Name = "label16";
            label16.Size = new Size(25, 19);
            label16.TabIndex = 59;
            label16.Text = "👥";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(208, 80);
            label17.Name = "label17";
            label17.Size = new Size(25, 19);
            label17.TabIndex = 58;
            label17.Text = "\U0001f9d1‍💼";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(208, 80);
            label18.Name = "label18";
            label18.Size = new Size(25, 19);
            label18.TabIndex = 59;
            label18.Text = "🙋";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.ForeColor = Color.Lime;
            label19.Location = new Point(207, 80);
            label19.Name = "label19";
            label19.Size = new Size(25, 19);
            label19.TabIndex = 58;
            label19.Text = "\U0001f7e2";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.ForeColor = Color.Red;
            label20.Location = new Point(208, 80);
            label20.Name = "label20";
            label20.Size = new Size(25, 19);
            label20.TabIndex = 58;
            label20.Text = "\U0001f7e2";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(175, 80);
            label21.Name = "label21";
            label21.Size = new Size(57, 19);
            label21.TabIndex = 58;
            label21.Text = "👤👤👤";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(176, 80);
            label22.Name = "label22";
            label22.Size = new Size(57, 19);
            label22.TabIndex = 59;
            label22.Text = "👤👤👤";
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(12F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1798, 1050);
            Controls.Add(panel12);
            Controls.Add(panel11);
            Controls.Add(panel10);
            Controls.Add(panel8);
            Controls.Add(panel7);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(chart1);
            Controls.Add(lblLatestUserDate);
            Controls.Add(label_welcome);
            Controls.Add(panel3);
            Controls.Add(panel9);
            Controls.Add(panel13);
            Margin = new Padding(6, 4, 6, 4);
            Name = "AdminForm";
            Text = "Admin | Dashboard";
            Load += AdminForm_Load;
            Controls.SetChildIndex(panel13, 0);
            Controls.SetChildIndex(panel9, 0);
            Controls.SetChildIndex(panel3, 0);
            Controls.SetChildIndex(label_welcome, 0);
            Controls.SetChildIndex(lblLatestUserDate, 0);
            Controls.SetChildIndex(chart1, 0);
            Controls.SetChildIndex(panel4, 0);
            Controls.SetChildIndex(panel5, 0);
            Controls.SetChildIndex(panel6, 0);
            Controls.SetChildIndex(panel7, 0);
            Controls.SetChildIndex(panel8, 0);
            Controls.SetChildIndex(panel10, 0);
            Controls.SetChildIndex(panel11, 0);
            Controls.SetChildIndex(panel12, 0);
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
    }
}