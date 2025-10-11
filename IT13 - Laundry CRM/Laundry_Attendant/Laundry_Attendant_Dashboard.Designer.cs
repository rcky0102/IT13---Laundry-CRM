namespace IT13___Laundry_CRM
{
    partial class Laundry_Attendant_Dashboard
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
            label_pending = new Label();
            label_washing = new Label();
            label_drying = new Label();
            label_ironing = new Label();
            label_ready = new Label();
            label_completed = new Label();
            label_cancelled = new Label();
            label_onhold = new Label();
            label_welcome = new Label();
            panel3 = new Panel();
            label4 = new Label();
            panel4 = new Panel();
            label5 = new Label();
            panel5 = new Panel();
            label7 = new Label();
            panel6 = new Panel();
            label6 = new Label();
            panel7 = new Panel();
            label10 = new Label();
            panel8 = new Panel();
            label9 = new Label();
            panel9 = new Panel();
            label8 = new Label();
            panel11 = new Panel();
            label11 = new Label();
            label3 = new Label();
            buttonLoadGraph = new Button();
            dateTimePickerFrom = new DateTimePicker();
            dateTimePickerTo = new DateTimePicker();
            buttonLoadGraphToday = new Button();
            buttonLoadGraphWeek = new Button();
            buttonLoadGraphMonth = new Button();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panel2 = new Panel();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            panel9.SuspendLayout();
            panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label_pending
            // 
            label_pending.AutoSize = true;
            label_pending.Font = new Font("Gadugi", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_pending.ForeColor = SystemColors.ButtonHighlight;
            label_pending.Location = new Point(4, 0);
            label_pending.Margin = new Padding(4, 0, 4, 0);
            label_pending.Name = "label_pending";
            label_pending.Size = new Size(91, 26);
            label_pending.TabIndex = 3;
            label_pending.Text = "Pending";
            // 
            // label_washing
            // 
            label_washing.AutoSize = true;
            label_washing.Location = new Point(-1, 0);
            label_washing.Margin = new Padding(4, 0, 4, 0);
            label_washing.Name = "label_washing";
            label_washing.Size = new Size(95, 26);
            label_washing.TabIndex = 4;
            label_washing.Text = "Washing";
            // 
            // label_drying
            // 
            label_drying.AutoSize = true;
            label_drying.Location = new Point(-1, 0);
            label_drying.Margin = new Padding(4, 0, 4, 0);
            label_drying.Name = "label_drying";
            label_drying.Size = new Size(76, 26);
            label_drying.TabIndex = 5;
            label_drying.Text = "Drying";
            // 
            // label_ironing
            // 
            label_ironing.AutoSize = true;
            label_ironing.Location = new Point(-1, -2);
            label_ironing.Margin = new Padding(4, 0, 4, 0);
            label_ironing.Name = "label_ironing";
            label_ironing.Size = new Size(81, 26);
            label_ironing.TabIndex = 6;
            label_ironing.Text = "Ironing";
            // 
            // label_ready
            // 
            label_ready.AutoSize = true;
            label_ready.Location = new Point(4, 9);
            label_ready.Margin = new Padding(4, 0, 4, 0);
            label_ready.Name = "label_ready";
            label_ready.Size = new Size(72, 26);
            label_ready.TabIndex = 7;
            label_ready.Text = "Ready";
            // 
            // label_completed
            // 
            label_completed.AutoSize = true;
            label_completed.Location = new Point(-1, -2);
            label_completed.Margin = new Padding(4, 0, 4, 0);
            label_completed.Name = "label_completed";
            label_completed.Size = new Size(107, 26);
            label_completed.TabIndex = 8;
            label_completed.Text = "Complete";
            // 
            // label_cancelled
            // 
            label_cancelled.AutoSize = true;
            label_cancelled.Location = new Point(-1, 0);
            label_cancelled.Margin = new Padding(4, 0, 4, 0);
            label_cancelled.Name = "label_cancelled";
            label_cancelled.Size = new Size(106, 26);
            label_cancelled.TabIndex = 9;
            label_cancelled.Text = "Cancelled";
            // 
            // label_onhold
            // 
            label_onhold.AutoSize = true;
            label_onhold.Location = new Point(-1, 0);
            label_onhold.Margin = new Padding(4, 0, 4, 0);
            label_onhold.Name = "label_onhold";
            label_onhold.Size = new Size(84, 26);
            label_onhold.TabIndex = 10;
            label_onhold.Text = "Onhold";
            // 
            // label_welcome
            // 
            label_welcome.AutoSize = true;
            label_welcome.BackColor = SystemColors.ButtonHighlight;
            label_welcome.Font = new Font("Gadugi", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_welcome.ForeColor = SystemColors.ActiveCaptionText;
            label_welcome.Location = new Point(366, 124);
            label_welcome.Margin = new Padding(4, 0, 4, 0);
            label_welcome.Name = "label_welcome";
            label_welcome.Size = new Size(187, 43);
            label_welcome.TabIndex = 11;
            label_welcome.Text = "Welcome!";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.HotTrack;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label_pending);
            panel3.Font = new Font("Gadugi", 11F);
            panel3.ForeColor = SystemColors.ButtonHighlight;
            panel3.Location = new Point(481, 201);
            panel3.Margin = new Padding(1, 2, 1, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(294, 129);
            panel3.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(206, 109);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(40, 27);
            label4.TabIndex = 19;
            label4.Text = "⏳";
            // 
            // panel4
            // 
            panel4.BackColor = Color.RoyalBlue;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(label5);
            panel4.Controls.Add(label_ready);
            panel4.Font = new Font("Gadugi", 11F);
            panel4.ForeColor = SystemColors.ButtonHighlight;
            panel4.Location = new Point(804, 202);
            panel4.Margin = new Padding(1, 2, 1, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(296, 129);
            panel4.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(256, 97);
            label5.Margin = new Padding(1, 0, 1, 0);
            label5.Name = "label5";
            label5.Size = new Size(37, 26);
            label5.TabIndex = 20;
            label5.Text = "✅";
            // 
            // panel5
            // 
            panel5.BackColor = Color.RoyalBlue;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(label7);
            panel5.Controls.Add(label_drying);
            panel5.Font = new Font("Gadugi", 11F);
            panel5.ForeColor = SystemColors.ButtonHighlight;
            panel5.Location = new Point(1459, 201);
            panel5.Margin = new Padding(1, 2, 1, 2);
            panel5.Name = "panel5";
            panel5.Size = new Size(294, 133);
            panel5.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(259, 137);
            label7.Margin = new Padding(1, 0, 1, 0);
            label7.Name = "label7";
            label7.Size = new Size(37, 26);
            label7.TabIndex = 20;
            label7.Text = "💨";
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.HotTrack;
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(label6);
            panel6.Controls.Add(label_washing);
            panel6.Font = new Font("Gadugi", 11F);
            panel6.ForeColor = SystemColors.ButtonHighlight;
            panel6.Location = new Point(1130, 201);
            panel6.Margin = new Padding(1, 2, 1, 2);
            panel6.Name = "panel6";
            panel6.Size = new Size(298, 130);
            panel6.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(258, 98);
            label6.Margin = new Padding(1, 0, 1, 0);
            label6.Name = "label6";
            label6.Size = new Size(37, 26);
            label6.TabIndex = 20;
            label6.Text = "\U0001f9fc";
            // 
            // panel7
            // 
            panel7.BackColor = Color.RoyalBlue;
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Controls.Add(label10);
            panel7.Controls.Add(label_onhold);
            panel7.Font = new Font("Gadugi", 11F);
            panel7.ForeColor = SystemColors.ButtonHighlight;
            panel7.Location = new Point(1130, 357);
            panel7.Margin = new Padding(1, 2, 1, 2);
            panel7.Name = "panel7";
            panel7.Size = new Size(298, 133);
            panel7.TabIndex = 16;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(258, 99);
            label10.Margin = new Padding(1, 0, 1, 0);
            label10.Name = "label10";
            label10.Size = new Size(37, 26);
            label10.TabIndex = 20;
            label10.Text = "⏸️";
            // 
            // panel8
            // 
            panel8.BackColor = SystemColors.HotTrack;
            panel8.BorderStyle = BorderStyle.FixedSingle;
            panel8.Controls.Add(label9);
            panel8.Controls.Add(label_completed);
            panel8.Font = new Font("Gadugi", 11F);
            panel8.ForeColor = SystemColors.ButtonHighlight;
            panel8.Location = new Point(481, 360);
            panel8.Margin = new Padding(1, 2, 1, 2);
            panel8.Name = "panel8";
            panel8.Size = new Size(294, 130);
            panel8.TabIndex = 16;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(256, 102);
            label9.Margin = new Padding(1, 0, 1, 0);
            label9.Name = "label9";
            label9.Size = new Size(37, 26);
            label9.TabIndex = 20;
            label9.Text = "✨";
            // 
            // panel9
            // 
            panel9.BackColor = Color.RoyalBlue;
            panel9.BorderStyle = BorderStyle.FixedSingle;
            panel9.Controls.Add(label8);
            panel9.Controls.Add(label_ironing);
            panel9.Font = new Font("Gadugi", 11F);
            panel9.ForeColor = SystemColors.ButtonHighlight;
            panel9.Location = new Point(804, 358);
            panel9.Margin = new Padding(1, 2, 1, 2);
            panel9.Name = "panel9";
            panel9.Size = new Size(296, 132);
            panel9.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(256, 98);
            label8.Margin = new Padding(1, 0, 1, 0);
            label8.Name = "label8";
            label8.Size = new Size(37, 26);
            label8.TabIndex = 20;
            label8.Text = "👔";
            // 
            // panel11
            // 
            panel11.BackColor = SystemColors.HotTrack;
            panel11.BorderStyle = BorderStyle.FixedSingle;
            panel11.Controls.Add(label11);
            panel11.Controls.Add(label_cancelled);
            panel11.Font = new Font("Gadugi", 11F);
            panel11.ForeColor = SystemColors.ButtonHighlight;
            panel11.Location = new Point(1459, 357);
            panel11.Margin = new Padding(1, 2, 1, 2);
            panel11.Name = "panel11";
            panel11.Size = new Size(296, 132);
            panel11.TabIndex = 16;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(245, 86);
            label11.Margin = new Padding(1, 0, 1, 0);
            label11.Name = "label11";
            label11.Size = new Size(37, 26);
            label11.TabIndex = 20;
            label11.Text = "❌";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Gadugi", 8F);
            label3.Location = new Point(430, 164);
            label3.Margin = new Padding(1, 0, 1, 0);
            label3.Name = "label3";
            label3.Size = new Size(123, 19);
            label3.TabIndex = 18;
            label3.Text = "Order Overview:";
            // 
            // buttonLoadGraph
            // 
            buttonLoadGraph.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonLoadGraph.BackColor = SystemColors.Highlight;
            buttonLoadGraph.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonLoadGraph.ForeColor = SystemColors.ButtonHighlight;
            buttonLoadGraph.Location = new Point(671, 11);
            buttonLoadGraph.Margin = new Padding(4, 3, 4, 3);
            buttonLoadGraph.Name = "buttonLoadGraph";
            buttonLoadGraph.Size = new Size(112, 38);
            buttonLoadGraph.TabIndex = 21;
            buttonLoadGraph.Text = "Custom";
            buttonLoadGraph.UseVisualStyleBackColor = false;
            buttonLoadGraph.Click += buttonLoadGraph_Click;
            // 
            // dateTimePickerFrom
            // 
            dateTimePickerFrom.CalendarMonthBackground = SystemColors.GradientActiveCaption;
            dateTimePickerFrom.CalendarTitleBackColor = SystemColors.GradientActiveCaption;
            dateTimePickerFrom.Location = new Point(9, 13);
            dateTimePickerFrom.Margin = new Padding(4, 3, 4, 3);
            dateTimePickerFrom.Name = "dateTimePickerFrom";
            dateTimePickerFrom.Size = new Size(305, 31);
            dateTimePickerFrom.TabIndex = 23;
            // 
            // dateTimePickerTo
            // 
            dateTimePickerTo.Location = new Point(340, 13);
            dateTimePickerTo.Margin = new Padding(4, 3, 4, 3);
            dateTimePickerTo.Name = "dateTimePickerTo";
            dateTimePickerTo.Size = new Size(313, 31);
            dateTimePickerTo.TabIndex = 24;
            // 
            // buttonLoadGraphToday
            // 
            buttonLoadGraphToday.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonLoadGraphToday.Location = new Point(1296, 11);
            buttonLoadGraphToday.Margin = new Padding(4, 5, 4, 5);
            buttonLoadGraphToday.Name = "buttonLoadGraphToday";
            buttonLoadGraphToday.Size = new Size(85, 38);
            buttonLoadGraphToday.TabIndex = 26;
            buttonLoadGraphToday.Text = "Today";
            buttonLoadGraphToday.UseVisualStyleBackColor = true;
            buttonLoadGraphToday.Click += buttonLoadGraphToday_Click;
            // 
            // buttonLoadGraphWeek
            // 
            buttonLoadGraphWeek.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonLoadGraphWeek.Location = new Point(1389, 11);
            buttonLoadGraphWeek.Margin = new Padding(4, 5, 4, 5);
            buttonLoadGraphWeek.Name = "buttonLoadGraphWeek";
            buttonLoadGraphWeek.Size = new Size(112, 38);
            buttonLoadGraphWeek.TabIndex = 27;
            buttonLoadGraphWeek.Text = "Week";
            buttonLoadGraphWeek.UseVisualStyleBackColor = true;
            buttonLoadGraphWeek.Click += buttonLoadGraphWeek_Click;
            // 
            // buttonLoadGraphMonth
            // 
            buttonLoadGraphMonth.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonLoadGraphMonth.Location = new Point(1509, 10);
            buttonLoadGraphMonth.Margin = new Padding(4, 5, 4, 5);
            buttonLoadGraphMonth.Name = "buttonLoadGraphMonth";
            buttonLoadGraphMonth.Size = new Size(104, 38);
            buttonLoadGraphMonth.TabIndex = 28;
            buttonLoadGraphMonth.Text = "Month";
            buttonLoadGraphMonth.UseVisualStyleBackColor = true;
            buttonLoadGraphMonth.Click += buttonLoadGraphMonth_Click;
            // 
            // chart1
            // 
            chart1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(268, 579);
            chart1.Margin = new Padding(4, 5, 4, 5);
            chart1.Name = "chart1";
            chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series1.ChartArea = "ChartArea1";
            series1.IsXValueIndexed = true;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.YValuesPerPoint = 2;
            chart1.Series.Add(series1);
            chart1.Size = new Size(1632, 480);
            chart1.TabIndex = 29;
            chart1.Text = "chart1";
            title1.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Top;
            title1.Name = "Title1";
            title1.Text = "Customer";
            chart1.Titles.Add(title1);
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(buttonLoadGraphMonth);
            panel2.Controls.Add(buttonLoadGraphWeek);
            panel2.Controls.Add(dateTimePickerTo);
            panel2.Controls.Add(buttonLoadGraphToday);
            panel2.Controls.Add(dateTimePickerFrom);
            panel2.Controls.Add(buttonLoadGraph);
            panel2.Location = new Point(257, 503);
            panel2.Name = "panel2";
            panel2.Size = new Size(1643, 68);
            panel2.TabIndex = 30;
            // 
            // Laundry_Attendant_Dashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1924, 1050);
            Controls.Add(chart1);
            Controls.Add(panel6);
            Controls.Add(panel11);
            Controls.Add(panel9);
            Controls.Add(panel3);
            Controls.Add(panel4);
            Controls.Add(label3);
            Controls.Add(panel8);
            Controls.Add(panel7);
            Controls.Add(panel5);
            Controls.Add(label_welcome);
            Controls.Add(panel2);
            Margin = new Padding(6, 5, 6, 5);
            Name = "Laundry_Attendant_Dashboard";
            Text = "Laundry Attendant | Dashboard";
            Load += Laundry_Attendant_Dashboard_Load;
            Controls.SetChildIndex(panel2, 0);
            Controls.SetChildIndex(label_welcome, 0);
            Controls.SetChildIndex(panel5, 0);
            Controls.SetChildIndex(panel7, 0);
            Controls.SetChildIndex(panel8, 0);
            Controls.SetChildIndex(label3, 0);
            Controls.SetChildIndex(panel4, 0);
            Controls.SetChildIndex(panel3, 0);
            Controls.SetChildIndex(panel9, 0);
            Controls.SetChildIndex(panel11, 0);
            Controls.SetChildIndex(panel6, 0);
            Controls.SetChildIndex(chart1, 0);
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
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_pending;
        private Label label_washing;
        private Label label_drying;
        private Label label_ironing;
        private Label label_ready;
        private Label label_completed;
        private Label label_cancelled;
        private Label label_onhold;
        private Label label_welcome;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Panel panel7;
        private Panel panel8;
        private Panel panel9;
        private Panel panel11;
        private Label label4;
        private Label label3;
        private Label label5;
        private Label label7;
        private Label label6;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label11;
        private Button buttonLoadGraph;
        private DateTimePicker dateTimePickerFrom;
        private DateTimePicker dateTimePickerTo;
        private Button buttonLoadGraphToday;
        private Button buttonLoadGraphWeek;
        private Button buttonLoadGraphMonth;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Panel panel2;
    }
}