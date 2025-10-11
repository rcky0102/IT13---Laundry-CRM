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
            dataGridView2 = new DataGridView();
            lblAverageStatus = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvTopUsers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvRecentChanges).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvStatusCounts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // lblSummary
            // 
            lblSummary.AutoSize = true;
            lblSummary.Location = new Point(336, 90);
            lblSummary.Name = "lblSummary";
            lblSummary.Size = new Size(250, 22);
            lblSummary.TabIndex = 2;
            lblSummary.Text = "Summary will appear here";
            // 
            // btnGenerateReport
            // 
            btnGenerateReport.Location = new Point(345, 172);
            btnGenerateReport.Name = "btnGenerateReport";
            btnGenerateReport.Size = new Size(227, 29);
            btnGenerateReport.TabIndex = 3;
            btnGenerateReport.Text = "Generate";
            btnGenerateReport.UseVisualStyleBackColor = true;
            btnGenerateReport.Click += btnGenerateReport_Click;
            // 
            // dgvTopUsers
            // 
            dgvTopUsers.AllowUserToAddRows = false;
            dgvTopUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTopUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTopUsers.Location = new Point(233, 219);
            dgvTopUsers.Name = "dgvTopUsers";
            dgvTopUsers.ReadOnly = true;
            dgvTopUsers.RowHeadersWidth = 51;
            dgvTopUsers.Size = new Size(232, 132);
            dgvTopUsers.TabIndex = 4;
            // 
            // dtpStart
            // 
            dtpStart.Format = DateTimePickerFormat.Short;
            dtpStart.Location = new Point(336, 128);
            dtpStart.Name = "dtpStart";
            dtpStart.Size = new Size(250, 27);
            dtpStart.TabIndex = 5;
            // 
            // dtpEnd
            // 
            dtpEnd.Format = DateTimePickerFormat.Short;
            dtpEnd.Location = new Point(604, 128);
            dtpEnd.Name = "dtpEnd";
            dtpEnd.Size = new Size(250, 27);
            dtpEnd.TabIndex = 6;
            // 
            // btnExportPDF
            // 
            btnExportPDF.Location = new Point(604, 172);
            btnExportPDF.Name = "btnExportPDF";
            btnExportPDF.Size = new Size(247, 29);
            btnExportPDF.TabIndex = 7;
            btnExportPDF.Text = "Export";
            btnExportPDF.UseVisualStyleBackColor = true;
            btnExportPDF.Click += btnExportPDF_Click;
            // 
            // dgvRecentChanges
            // 
            dgvRecentChanges.AllowUserToAddRows = false;
            dgvRecentChanges.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRecentChanges.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRecentChanges.Location = new Point(481, 219);
            dgvRecentChanges.Name = "dgvRecentChanges";
            dgvRecentChanges.ReadOnly = true;
            dgvRecentChanges.RowHeadersWidth = 51;
            dgvRecentChanges.Size = new Size(334, 135);
            dgvRecentChanges.TabIndex = 8;
            dgvRecentChanges.CellContentClick += dgvRecentChanges_CellContentClick;
            // 
            // dgvStatusCounts
            // 
            dgvStatusCounts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStatusCounts.Location = new Point(233, 376);
            dgvStatusCounts.Name = "dgvStatusCounts";
            dgvStatusCounts.RowHeadersWidth = 51;
            dgvStatusCounts.Size = new Size(249, 154);
            dgvStatusCounts.TabIndex = 9;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(500, 376);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(300, 188);
            dataGridView2.TabIndex = 10;
            // 
            // lblAverageStatus
            // 
            lblAverageStatus.AutoSize = true;
            lblAverageStatus.Location = new Point(313, 67);
            lblAverageStatus.Name = "lblAverageStatus";
            lblAverageStatus.Size = new Size(70, 22);
            lblAverageStatus.TabIndex = 11;
            lblAverageStatus.Text = "label1";
            // 
            // admin_reports
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 624);
            Controls.Add(lblAverageStatus);
            Controls.Add(dataGridView2);
            Controls.Add(dgvStatusCounts);
            Controls.Add(dgvRecentChanges);
            Controls.Add(btnExportPDF);
            Controls.Add(dtpEnd);
            Controls.Add(dtpStart);
            Controls.Add(dgvTopUsers);
            Controls.Add(btnGenerateReport);
            Controls.Add(lblSummary);
            Margin = new Padding(5, 3, 5, 3);
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
            Controls.SetChildIndex(dataGridView2, 0);
            Controls.SetChildIndex(lblAverageStatus, 0);
            ((System.ComponentModel.ISupportInitialize)dgvTopUsers).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvRecentChanges).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvStatusCounts).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
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
        private DataGridView dataGridView2;
        private Label lblAverageStatus;
    }
}