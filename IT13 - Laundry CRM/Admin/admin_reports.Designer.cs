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
            dgvRoles = new DataGridView();
            dtpStart = new DateTimePicker();
            dtpEnd = new DateTimePicker();
            btnExportPDF = new Button();
            dgvMonthlyUsers = new DataGridView();
            dgvArchived = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            dgvGrowth = new DataGridView();
            dgvAddress = new DataGridView();
            panel3 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvRoles).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvMonthlyUsers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvArchived).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvGrowth).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvAddress).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // lblSummary
            // 
            lblSummary.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblSummary.AutoSize = true;
            lblSummary.Font = new Font("Gadugi", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSummary.Location = new Point(309, 932);
            lblSummary.Margin = new Padding(4, 0, 4, 0);
            lblSummary.Name = "lblSummary";
            lblSummary.Size = new Size(236, 24);
            lblSummary.TabIndex = 2;
            lblSummary.Text = "Summary will appear here";
            // 
            // btnGenerateReport
            // 
            btnGenerateReport.BackColor = Color.CornflowerBlue;
            btnGenerateReport.ForeColor = SystemColors.ButtonHighlight;
            btnGenerateReport.Location = new Point(701, 20);
            btnGenerateReport.Margin = new Padding(4, 4, 4, 4);
            btnGenerateReport.Name = "btnGenerateReport";
            btnGenerateReport.Size = new Size(145, 36);
            btnGenerateReport.TabIndex = 3;
            btnGenerateReport.Text = "Generate";
            btnGenerateReport.UseVisualStyleBackColor = false;
            btnGenerateReport.Click += btnGenerateReport_Click;
            // 
            // dgvRoles
            // 
            dgvRoles.AllowUserToAddRows = false;
            dgvRoles.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvRoles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRoles.BackgroundColor = SystemColors.ButtonHighlight;
            dgvRoles.BorderStyle = BorderStyle.Fixed3D;
            dgvRoles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRoles.Location = new Point(325, 233);
            dgvRoles.Margin = new Padding(4, 4, 4, 4);
            dgvRoles.Name = "dgvRoles";
            dgvRoles.ReadOnly = true;
            dgvRoles.RowHeadersWidth = 51;
            dgvRoles.Size = new Size(1013, 94);
            dgvRoles.TabIndex = 4;
            // 
            // dtpStart
            // 
            dtpStart.Format = DateTimePickerFormat.Short;
            dtpStart.Location = new Point(117, 19);
            dtpStart.Margin = new Padding(4, 4, 4, 4);
            dtpStart.Name = "dtpStart";
            dtpStart.Size = new Size(179, 34);
            dtpStart.TabIndex = 5;
            // 
            // dtpEnd
            // 
            dtpEnd.Format = DateTimePickerFormat.Short;
            dtpEnd.Location = new Point(422, 19);
            dtpEnd.Margin = new Padding(4, 4, 4, 4);
            dtpEnd.Name = "dtpEnd";
            dtpEnd.Size = new Size(179, 34);
            dtpEnd.TabIndex = 6;
            // 
            // btnExportPDF
            // 
            btnExportPDF.BackColor = Color.MediumSeaGreen;
            btnExportPDF.ForeColor = SystemColors.ButtonHighlight;
            btnExportPDF.Location = new Point(854, 20);
            btnExportPDF.Margin = new Padding(4, 4, 4, 4);
            btnExportPDF.Name = "btnExportPDF";
            btnExportPDF.Size = new Size(151, 36);
            btnExportPDF.TabIndex = 7;
            btnExportPDF.Text = "Export";
            btnExportPDF.UseVisualStyleBackColor = false;
            btnExportPDF.Click += btnExportPDF_Click;
            // 
            // dgvMonthlyUsers
            // 
            dgvMonthlyUsers.AllowUserToAddRows = false;
            dgvMonthlyUsers.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvMonthlyUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMonthlyUsers.BackgroundColor = SystemColors.ButtonHighlight;
            dgvMonthlyUsers.BorderStyle = BorderStyle.Fixed3D;
            dgvMonthlyUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMonthlyUsers.Location = new Point(325, 344);
            dgvMonthlyUsers.Margin = new Padding(4, 4, 4, 4);
            dgvMonthlyUsers.Name = "dgvMonthlyUsers";
            dgvMonthlyUsers.ReadOnly = true;
            dgvMonthlyUsers.RowHeadersWidth = 51;
            dgvMonthlyUsers.Size = new Size(1013, 110);
            dgvMonthlyUsers.TabIndex = 8;
            dgvMonthlyUsers.CellContentClick += dgvRecentChanges_CellContentClick;
            // 
            // dgvArchived
            // 
            dgvArchived.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvArchived.BackgroundColor = SystemColors.ButtonHighlight;
            dgvArchived.BorderStyle = BorderStyle.Fixed3D;
            dgvArchived.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvArchived.Location = new Point(325, 474);
            dgvArchived.Margin = new Padding(4, 4, 4, 4);
            dgvArchived.Name = "dgvArchived";
            dgvArchived.RowHeadersWidth = 51;
            dgvArchived.Size = new Size(1013, 139);
            dgvArchived.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(7, 26);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(102, 24);
            label1.TabIndex = 12;
            label1.Text = "Start Date:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(321, 25);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(93, 24);
            label2.TabIndex = 13;
            label2.Text = "End Date:";
            // 
            // dgvGrowth
            // 
            dgvGrowth.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvGrowth.BackgroundColor = SystemColors.ButtonHighlight;
            dgvGrowth.BorderStyle = BorderStyle.Fixed3D;
            dgvGrowth.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGrowth.Location = new Point(325, 632);
            dgvGrowth.Margin = new Padding(4, 4, 4, 4);
            dgvGrowth.Name = "dgvGrowth";
            dgvGrowth.RowHeadersWidth = 51;
            dgvGrowth.Size = new Size(1013, 123);
            dgvGrowth.TabIndex = 14;
            // 
            // dgvAddress
            // 
            dgvAddress.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvAddress.BackgroundColor = SystemColors.ButtonHighlight;
            dgvAddress.BorderStyle = BorderStyle.Fixed3D;
            dgvAddress.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAddress.Location = new Point(325, 775);
            dgvAddress.Margin = new Padding(4, 4, 4, 4);
            dgvAddress.Name = "dgvAddress";
            dgvAddress.RowHeadersWidth = 51;
            dgvAddress.Size = new Size(1013, 140);
            dgvAddress.TabIndex = 15;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ButtonHighlight;
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(btnExportPDF);
            panel3.Controls.Add(btnGenerateReport);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(dtpEnd);
            panel3.Controls.Add(dtpStart);
            panel3.Font = new Font("Gadugi", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel3.Location = new Point(307, 114);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(1050, 74);
            panel3.TabIndex = 16;
            // 
            // admin_reports
            // 
            AutoScaleDimensions = new SizeF(12F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1368, 1050);
            Controls.Add(dgvAddress);
            Controls.Add(dgvGrowth);
            Controls.Add(dgvArchived);
            Controls.Add(dgvMonthlyUsers);
            Controls.Add(dgvRoles);
            Controls.Add(lblSummary);
            Controls.Add(panel3);
            Margin = new Padding(6, 4, 6, 4);
            Name = "admin_reports";
            Text = "admin_reports";
            Load += admin_reports_Load;
            Controls.SetChildIndex(panel3, 0);
            Controls.SetChildIndex(lblSummary, 0);
            Controls.SetChildIndex(dgvRoles, 0);
            Controls.SetChildIndex(dgvMonthlyUsers, 0);
            Controls.SetChildIndex(dgvArchived, 0);
            Controls.SetChildIndex(dgvGrowth, 0);
            Controls.SetChildIndex(dgvAddress, 0);
            ((System.ComponentModel.ISupportInitialize)dgvRoles).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvMonthlyUsers).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvArchived).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvGrowth).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvAddress).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSummary;
        private Button btnGenerateReport;
        private DataGridView dgvRoles;
        private DateTimePicker dtpStart;
        private DateTimePicker dtpEnd;
        private Button btnExportPDF;
        private DataGridView dgvMonthlyUsers;
        private DataGridView dgvArchived;
        private Label label1;
        private Label label2;
        private DataGridView dgvGrowth;
        private DataGridView dgvAddress;
        private Panel panel3;
    }
}