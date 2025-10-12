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
            dgvRecentChanges = new DataGridView();
            dgvStatusCounts = new DataGridView();
            lblAverageStatus = new Label();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvTopUsers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvRecentChanges).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvStatusCounts).BeginInit();
            SuspendLayout();
            // 
            // lblSummary
            // 
            lblSummary.AutoSize = true;
            lblSummary.Location = new Point(280, 614);
            lblSummary.Margin = new Padding(4, 0, 4, 0);
            lblSummary.Name = "lblSummary";
            lblSummary.Size = new Size(300, 28);
            lblSummary.TabIndex = 2;
            lblSummary.Text = "Summary will appear here";
            // 
            // btnGenerateReport
            // 
            btnGenerateReport.Location = new Point(296, 199);
            btnGenerateReport.Margin = new Padding(4, 4, 4, 4);
            btnGenerateReport.Name = "btnGenerateReport";
            btnGenerateReport.Size = new Size(331, 36);
            btnGenerateReport.TabIndex = 3;
            btnGenerateReport.Text = "Generate";
            btnGenerateReport.UseVisualStyleBackColor = true;
            btnGenerateReport.Click += btnGenerateReport_Click;
            // 
            // dgvTopUsers
            // 
            dgvTopUsers.AllowUserToAddRows = false;
            dgvTopUsers.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvTopUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTopUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTopUsers.Location = new Point(280, 254);
            dgvTopUsers.Margin = new Padding(4, 4, 4, 4);
            dgvTopUsers.Name = "dgvTopUsers";
            dgvTopUsers.ReadOnly = true;
            dgvTopUsers.RowHeadersWidth = 51;
            dgvTopUsers.Size = new Size(1059, 94);
            dgvTopUsers.TabIndex = 4;
            // 
            // dtpStart
            // 
            dtpStart.Format = DateTimePickerFormat.Short;
            dtpStart.Location = new Point(448, 142);
            dtpStart.Margin = new Padding(4, 4, 4, 4);
            dtpStart.Name = "dtpStart";
            dtpStart.Size = new Size(179, 31);
            dtpStart.TabIndex = 5;
            // 
            // dtpEnd
            // 
            dtpEnd.Format = DateTimePickerFormat.Short;
            dtpEnd.Location = new Point(806, 142);
            dtpEnd.Margin = new Padding(4, 4, 4, 4);
            dtpEnd.Name = "dtpEnd";
            dtpEnd.Size = new Size(179, 31);
            dtpEnd.TabIndex = 6;
            // 
            // btnExportPDF
            // 
            btnExportPDF.Location = new Point(679, 199);
            btnExportPDF.Margin = new Padding(4, 4, 4, 4);
            btnExportPDF.Name = "btnExportPDF";
            btnExportPDF.Size = new Size(307, 36);
            btnExportPDF.TabIndex = 7;
            btnExportPDF.Text = "Export";
            btnExportPDF.UseVisualStyleBackColor = true;
            btnExportPDF.Click += btnExportPDF_Click;
            // 
            // dgvRecentChanges
            // 
            dgvRecentChanges.AllowUserToAddRows = false;
            dgvRecentChanges.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvRecentChanges.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRecentChanges.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRecentChanges.Location = new Point(280, 373);
            dgvRecentChanges.Margin = new Padding(4, 4, 4, 4);
            dgvRecentChanges.Name = "dgvRecentChanges";
            dgvRecentChanges.ReadOnly = true;
            dgvRecentChanges.RowHeadersWidth = 51;
            dgvRecentChanges.Size = new Size(1059, 110);
            dgvRecentChanges.TabIndex = 8;
            dgvRecentChanges.CellContentClick += dgvRecentChanges_CellContentClick;
            // 
            // dgvStatusCounts
            // 
            dgvStatusCounts.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvStatusCounts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStatusCounts.Location = new Point(280, 511);
            dgvStatusCounts.Margin = new Padding(4, 4, 4, 4);
            dgvStatusCounts.Name = "dgvStatusCounts";
            dgvStatusCounts.RowHeadersWidth = 51;
            dgvStatusCounts.Size = new Size(1059, 74);
            dgvStatusCounts.TabIndex = 9;
            // 
            // lblAverageStatus
            // 
            lblAverageStatus.AutoSize = true;
            lblAverageStatus.Location = new Point(314, 728);
            lblAverageStatus.Margin = new Padding(4, 0, 4, 0);
            lblAverageStatus.Name = "lblAverageStatus";
            lblAverageStatus.Size = new Size(84, 28);
            lblAverageStatus.TabIndex = 11;
            lblAverageStatus.Text = "label1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(296, 142);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(144, 28);
            label1.TabIndex = 12;
            label1.Text = "Start Date:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(679, 142);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(120, 28);
            label2.TabIndex = 13;
            label2.Text = "End Date:";
            // 
            // admin_reports
            // 
            AutoScaleDimensions = new SizeF(12F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1368, 766);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblAverageStatus);
            Controls.Add(dgvStatusCounts);
            Controls.Add(dgvRecentChanges);
            Controls.Add(btnExportPDF);
            Controls.Add(dtpEnd);
            Controls.Add(dtpStart);
            Controls.Add(dgvTopUsers);
            Controls.Add(btnGenerateReport);
            Controls.Add(lblSummary);
            Margin = new Padding(6, 4, 6, 4);
            Name = "admin_reports";
            Text = "admin_reports";
            Load += admin_reports_Load;
            Controls.SetChildIndex(lblSummary, 0);
            Controls.SetChildIndex(btnGenerateReport, 0);
            Controls.SetChildIndex(dgvTopUsers, 0);
            Controls.SetChildIndex(dtpStart, 0);
            Controls.SetChildIndex(dtpEnd, 0);
            Controls.SetChildIndex(btnExportPDF, 0);
            Controls.SetChildIndex(dgvRecentChanges, 0);
            Controls.SetChildIndex(dgvStatusCounts, 0);
            Controls.SetChildIndex(lblAverageStatus, 0);
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(label2, 0);
            ((System.ComponentModel.ISupportInitialize)dgvTopUsers).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvRecentChanges).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvStatusCounts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSummary;
        private Button btnGenerateReport;
        private DataGridView dgvTopUsers;
        private DateTimePicker dtpStart;
        private DateTimePicker dtpEnd;
        private Button btnExportPDF;
        private DataGridView dgvRecentChanges;
        private DataGridView dgvStatusCounts;
        private Label lblAverageStatus;
        private Label label1;
        private Label label2;
    }
}