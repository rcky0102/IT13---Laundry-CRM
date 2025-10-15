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
            dgvGrowth = new DataGridView();
            dgvAddress = new DataGridView();
            panel3 = new Panel();
            label23 = new Label();
            label5 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lblSummary1 = new Label();
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
            lblSummary.Location = new Point(241, 1166);
            lblSummary.Margin = new Padding(2, 0, 2, 0);
            lblSummary.Name = "lblSummary";
            lblSummary.Size = new Size(207, 20);
            lblSummary.TabIndex = 2;
            lblSummary.Text = "Summary will appear here";
            // 
            // btnGenerateReport
            // 
            btnGenerateReport.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnGenerateReport.BackColor = SystemColors.Highlight;
            btnGenerateReport.ForeColor = SystemColors.ButtonHighlight;
            btnGenerateReport.Location = new Point(595, 13);
            btnGenerateReport.Margin = new Padding(2, 3, 2, 3);
            btnGenerateReport.Name = "btnGenerateReport";
            btnGenerateReport.Size = new Size(149, 40);
            btnGenerateReport.TabIndex = 3;
            btnGenerateReport.Text = "🔃 Generate";
            btnGenerateReport.UseVisualStyleBackColor = false;
            btnGenerateReport.Click += btnGenerateReport_Click;
            // 
            // dgvRoles
            // 
            dgvRoles.AllowUserToAddRows = false;
            dgvRoles.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvRoles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRoles.BackgroundColor = SystemColors.ButtonFace;
            dgvRoles.BorderStyle = BorderStyle.None;
            dgvRoles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRoles.Location = new Point(219, 174);
            dgvRoles.Margin = new Padding(2, 3, 2, 3);
            dgvRoles.MultiSelect = false;
            dgvRoles.Name = "dgvRoles";
            dgvRoles.ReadOnly = true;
            dgvRoles.RowHeadersVisible = false;
            dgvRoles.RowHeadersWidth = 51;
            dgvRoles.Size = new Size(902, 130);
            dgvRoles.TabIndex = 4;
            // 
            // dtpStart
            // 
            dtpStart.Format = DateTimePickerFormat.Short;
            dtpStart.Location = new Point(20, 13);
            dtpStart.Margin = new Padding(2, 3, 2, 3);
            dtpStart.Name = "dtpStart";
            dtpStart.Size = new Size(150, 30);
            dtpStart.TabIndex = 5;
            // 
            // dtpEnd
            // 
            dtpEnd.Format = DateTimePickerFormat.Short;
            dtpEnd.Location = new Point(215, 14);
            dtpEnd.Margin = new Padding(2, 3, 2, 3);
            dtpEnd.Name = "dtpEnd";
            dtpEnd.Size = new Size(150, 30);
            dtpEnd.TabIndex = 6;
            // 
            // btnExportPDF
            // 
            btnExportPDF.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExportPDF.BackColor = Color.MediumSeaGreen;
            btnExportPDF.ForeColor = SystemColors.ButtonHighlight;
            btnExportPDF.Location = new Point(748, 13);
            btnExportPDF.Margin = new Padding(2, 3, 2, 3);
            btnExportPDF.Name = "btnExportPDF";
            btnExportPDF.Size = new Size(131, 40);
            btnExportPDF.TabIndex = 7;
            btnExportPDF.Text = "📄 Export";
            btnExportPDF.UseVisualStyleBackColor = false;
            btnExportPDF.Click += btnExportPDF_Click;
            // 
            // dgvMonthlyUsers
            // 
            dgvMonthlyUsers.AllowUserToAddRows = false;
            dgvMonthlyUsers.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvMonthlyUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMonthlyUsers.BackgroundColor = SystemColors.ButtonFace;
            dgvMonthlyUsers.BorderStyle = BorderStyle.None;
            dgvMonthlyUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMonthlyUsers.Location = new Point(217, 331);
            dgvMonthlyUsers.Margin = new Padding(2, 3, 2, 3);
            dgvMonthlyUsers.MultiSelect = false;
            dgvMonthlyUsers.Name = "dgvMonthlyUsers";
            dgvMonthlyUsers.ReadOnly = true;
            dgvMonthlyUsers.RowHeadersVisible = false;
            dgvMonthlyUsers.RowHeadersWidth = 51;
            dgvMonthlyUsers.Size = new Size(902, 100);
            dgvMonthlyUsers.TabIndex = 8;
            dgvMonthlyUsers.CellContentClick += dgvRecentChanges_CellContentClick;
            // 
            // dgvArchived
            // 
            dgvArchived.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvArchived.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvArchived.BackgroundColor = SystemColors.ButtonFace;
            dgvArchived.BorderStyle = BorderStyle.None;
            dgvArchived.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvArchived.Location = new Point(218, 456);
            dgvArchived.Margin = new Padding(2, 3, 2, 3);
            dgvArchived.MultiSelect = false;
            dgvArchived.Name = "dgvArchived";
            dgvArchived.ReadOnly = true;
            dgvArchived.RowHeadersVisible = false;
            dgvArchived.RowHeadersWidth = 51;
            dgvArchived.Size = new Size(902, 120);
            dgvArchived.TabIndex = 9;
            dgvArchived.CellContentClick += dgvArchived_CellContentClick;
            // 
            // dgvGrowth
            // 
            dgvGrowth.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvGrowth.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGrowth.BackgroundColor = SystemColors.ButtonFace;
            dgvGrowth.BorderStyle = BorderStyle.None;
            dgvGrowth.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGrowth.Location = new Point(219, 606);
            dgvGrowth.Margin = new Padding(2, 3, 2, 3);
            dgvGrowth.MultiSelect = false;
            dgvGrowth.Name = "dgvGrowth";
            dgvGrowth.ReadOnly = true;
            dgvGrowth.RowHeadersVisible = false;
            dgvGrowth.RowHeadersWidth = 51;
            dgvGrowth.Size = new Size(902, 150);
            dgvGrowth.TabIndex = 14;
            dgvGrowth.CellContentClick += dgvGrowth_CellContentClick;
            // 
            // dgvAddress
            // 
            dgvAddress.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvAddress.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAddress.BackgroundColor = SystemColors.ButtonFace;
            dgvAddress.BorderStyle = BorderStyle.None;
            dgvAddress.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAddress.Location = new Point(220, 781);
            dgvAddress.Margin = new Padding(2, 3, 2, 3);
            dgvAddress.MultiSelect = false;
            dgvAddress.Name = "dgvAddress";
            dgvAddress.ReadOnly = true;
            dgvAddress.RowHeadersVisible = false;
            dgvAddress.RowHeadersWidth = 51;
            dgvAddress.Size = new Size(902, 192);
            dgvAddress.TabIndex = 15;
            dgvAddress.CellContentClick += dgvAddress_CellContentClick;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = SystemColors.GradientActiveCaption;
            panel3.Controls.Add(label23);
            panel3.Controls.Add(btnExportPDF);
            panel3.Controls.Add(btnGenerateReport);
            panel3.Controls.Add(dtpEnd);
            panel3.Controls.Add(dtpStart);
            panel3.Font = new Font("Gadugi", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel3.Location = new Point(219, 81);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(902, 67);
            panel3.TabIndex = 16;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Gadugi", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label23.Location = new Point(178, 14);
            label23.Margin = new Padding(4, 0, 4, 0);
            label23.Name = "label23";
            label23.Size = new Size(31, 27);
            label23.TabIndex = 60;
            label23.Text = "➜";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.Window;
            label5.Font = new Font("Gadugi", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(266, 162);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(216, 24);
            label5.TabIndex = 17;
            label5.Text = "New Users per Month";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Window;
            label1.Font = new Font("Gadugi", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(264, 319);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(258, 24);
            label1.TabIndex = 18;
            label1.Text = "Active and Archived Users";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Window;
            label2.Font = new Font("Gadugi", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(264, 444);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(172, 24);
            label2.TabIndex = 19;
            label2.Text = "Role Distribution";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Window;
            label3.Font = new Font("Gadugi", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(264, 590);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(232, 24);
            label3.TabIndex = 20;
            label3.Text = "User Growth Over Time";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Window;
            label4.Font = new Font("Gadugi", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(264, 768);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(268, 24);
            label4.TabIndex = 21;
            label4.Text = "Address-based Distribution";
            // 
            // lblSummary1
            // 
            lblSummary1.AutoSize = true;
            lblSummary1.Font = new Font("Gadugi", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSummary1.Location = new Point(239, 993);
            lblSummary1.Name = "lblSummary1";
            lblSummary1.Size = new Size(81, 20);
            lblSummary1.TabIndex = 22;
            lblSummary1.Text = "Summary";
            // 
            // admin_reports
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1168, 1055);
            Controls.Add(lblSummary1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label5);
            Controls.Add(dgvAddress);
            Controls.Add(dgvGrowth);
            Controls.Add(dgvArchived);
            Controls.Add(dgvMonthlyUsers);
            Controls.Add(dgvRoles);
            Controls.Add(lblSummary);
            Controls.Add(panel3);
            Margin = new Padding(5, 3, 5, 3);
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
            Controls.SetChildIndex(label5, 0);
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(label3, 0);
            Controls.SetChildIndex(label4, 0);
            Controls.SetChildIndex(lblSummary1, 0);
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
        private DataGridView dgvGrowth;
        private DataGridView dgvAddress;
        private Panel panel3;
        private Label label23;
        private Label label5;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lblSummary1;
    }
}