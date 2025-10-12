namespace IT13___Laundry_CRM.Admin
{
    partial class admin_reports
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
            lblSummary = new Label();
            btnGenerateReport = new Button();
            dgvTopUsers = new DataGridView();
            dtpStart = new DateTimePicker();
            dtpEnd = new DateTimePicker();
            btnExportPDF = new Button();
            dgvStatusCounts = new DataGridView();
            lblAverageStatus = new Label();
            label1 = new Label();
            label2 = new Label();
            panel3 = new Panel();
            panel4 = new Panel();
            dgvRecentChanges = new DataGridView();
            panel5 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvTopUsers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvStatusCounts).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecentChanges).BeginInit();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // lblSummary
            // 
            lblSummary.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblSummary.AutoSize = true;
            lblSummary.Font = new Font("Gadugi", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSummary.Location = new Point(546, 14);
            lblSummary.Margin = new Padding(4, 0, 4, 0);
            lblSummary.Name = "lblSummary";
            lblSummary.Size = new Size(236, 24);
            lblSummary.TabIndex = 2;
            lblSummary.Text = "Summary will appear here";
            // 
            // btnGenerateReport
            // 
            btnGenerateReport.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnGenerateReport.BackColor = Color.RoyalBlue;
            btnGenerateReport.Font = new Font("Gadugi", 10F);
            btnGenerateReport.ForeColor = SystemColors.ButtonHighlight;
            btnGenerateReport.Location = new Point(766, 12);
            btnGenerateReport.Margin = new Padding(4);
            btnGenerateReport.Name = "btnGenerateReport";
            btnGenerateReport.Size = new Size(140, 36);
            btnGenerateReport.TabIndex = 3;
            btnGenerateReport.Text = "Generate";
            btnGenerateReport.UseVisualStyleBackColor = false;
            btnGenerateReport.Click += btnGenerateReport_Click;
            // 
            // dgvTopUsers
            // 
            dgvTopUsers.AllowUserToAddRows = false;
            dgvTopUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTopUsers.BackgroundColor = SystemColors.ButtonHighlight;
            dgvTopUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTopUsers.Location = new Point(15, 10);
            dgvTopUsers.Margin = new Padding(4);
            dgvTopUsers.Name = "dgvTopUsers";
            dgvTopUsers.ReadOnly = true;
            dgvTopUsers.RowHeadersWidth = 51;
            dgvTopUsers.Size = new Size(447, 214);
            dgvTopUsers.TabIndex = 4;
            // 
            // dtpStart
            // 
            dtpStart.CalendarMonthBackground = SystemColors.HighlightText;
            dtpStart.Font = new Font("Gadugi", 10F);
            dtpStart.Format = DateTimePickerFormat.Short;
            dtpStart.Location = new Point(114, 17);
            dtpStart.Margin = new Padding(4);
            dtpStart.Name = "dtpStart";
            dtpStart.Size = new Size(179, 34);
            dtpStart.TabIndex = 5;
            // 
            // dtpEnd
            // 
            dtpEnd.Font = new Font("Gadugi", 10F);
            dtpEnd.Format = DateTimePickerFormat.Short;
            dtpEnd.Location = new Point(434, 17);
            dtpEnd.Margin = new Padding(4);
            dtpEnd.Name = "dtpEnd";
            dtpEnd.Size = new Size(179, 34);
            dtpEnd.TabIndex = 6;
            // 
            // btnExportPDF
            // 
            btnExportPDF.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExportPDF.BackColor = Color.MediumSeaGreen;
            btnExportPDF.Font = new Font("Gadugi", 10F);
            btnExportPDF.ForeColor = SystemColors.ButtonHighlight;
            btnExportPDF.Location = new Point(914, 12);
            btnExportPDF.Margin = new Padding(4);
            btnExportPDF.Name = "btnExportPDF";
            btnExportPDF.Size = new Size(152, 36);
            btnExportPDF.TabIndex = 7;
            btnExportPDF.Text = "📄 Export";
            btnExportPDF.UseVisualStyleBackColor = false;
            btnExportPDF.Click += btnExportPDF_Click;
            // 
            // dgvStatusCounts
            // 
            dgvStatusCounts.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            dgvStatusCounts.BackgroundColor = SystemColors.ButtonHighlight;
            dgvStatusCounts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStatusCounts.Location = new Point(17, 14);
            dgvStatusCounts.Margin = new Padding(4);
            dgvStatusCounts.Name = "dgvStatusCounts";
            dgvStatusCounts.RowHeadersWidth = 51;
            dgvStatusCounts.Size = new Size(447, 211);
            dgvStatusCounts.TabIndex = 9;
            // 
            // lblAverageStatus
            // 
            lblAverageStatus.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblAverageStatus.AutoSize = true;
            lblAverageStatus.Font = new Font("Gadugi", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAverageStatus.ForeColor = SystemColors.ActiveCaptionText;
            lblAverageStatus.Location = new Point(568, 201);
            lblAverageStatus.Margin = new Padding(4, 0, 4, 0);
            lblAverageStatus.Name = "lblAverageStatus";
            lblAverageStatus.Size = new Size(63, 24);
            lblAverageStatus.TabIndex = 11;
            lblAverageStatus.Text = "label1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gadugi", 10F);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(4, 24);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(102, 24);
            label1.TabIndex = 12;
            label1.Text = "Start Date:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Gadugi", 10F);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(339, 24);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(93, 24);
            label2.TabIndex = 13;
            label2.Text = "End Date:";
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = SystemColors.ActiveCaption;
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(btnGenerateReport);
            panel3.Controls.Add(btnExportPDF);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(dtpStart);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(dtpEnd);
            panel3.Location = new Point(266, 100);
            panel3.Name = "panel3";
            panel3.Size = new Size(1074, 69);
            panel3.TabIndex = 14;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel4.BorderStyle = BorderStyle.Fixed3D;
            panel4.Controls.Add(dgvTopUsers);
            panel4.Controls.Add(dgvRecentChanges);
            panel4.Location = new Point(287, 198);
            panel4.Name = "panel4";
            panel4.Size = new Size(1047, 232);
            panel4.TabIndex = 15;
            // 
            // dgvRecentChanges
            // 
            dgvRecentChanges.AllowUserToAddRows = false;
            dgvRecentChanges.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dgvRecentChanges.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRecentChanges.BackgroundColor = SystemColors.ButtonHighlight;
            dgvRecentChanges.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRecentChanges.Location = new Point(546, 10);
            dgvRecentChanges.Margin = new Padding(4);
            dgvRecentChanges.Name = "dgvRecentChanges";
            dgvRecentChanges.ReadOnly = true;
            dgvRecentChanges.RowHeadersWidth = 51;
            dgvRecentChanges.Size = new Size(493, 214);
            dgvRecentChanges.TabIndex = 8;
            dgvRecentChanges.CellContentClick += dgvRecentChanges_CellContentClick;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel5.BorderStyle = BorderStyle.Fixed3D;
            panel5.Controls.Add(lblAverageStatus);
            panel5.Controls.Add(dgvStatusCounts);
            panel5.Controls.Add(lblSummary);
            panel5.Location = new Point(287, 452);
            panel5.Name = "panel5";
            panel5.Size = new Size(1041, 233);
            panel5.TabIndex = 16;
            // 
            // admin_reports
            // 
            AutoScaleDimensions = new SizeF(12F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1368, 766);
            Controls.Add(panel3);
            Controls.Add(panel4);
            Controls.Add(panel5);
            Margin = new Padding(6, 4, 6, 4);
            Name = "admin_reports";
            Text = "admin_reports";
            Load += admin_reports_Load;
            Controls.SetChildIndex(panel5, 0);
            Controls.SetChildIndex(panel4, 0);
            Controls.SetChildIndex(panel3, 0);
            ((System.ComponentModel.ISupportInitialize)dgvTopUsers).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvStatusCounts).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRecentChanges).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblSummary;
        private Button btnGenerateReport;
        private DataGridView dgvTopUsers;
        private DateTimePicker dtpStart;
        private DateTimePicker dtpEnd;
        private Button btnExportPDF;
        private DataGridView dgvStatusCounts;
        private Label lblAverageStatus;
        private Label label1;
        private Label label2;
        private Panel panel3;
        private Panel panel4;
        private DataGridView dgvRecentChanges;
        private Panel panel5;
    }
}