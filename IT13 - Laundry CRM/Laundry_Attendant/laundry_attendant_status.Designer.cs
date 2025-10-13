namespace IT13___Laundry_CRM.Laundry_Attendant
{
    partial class laundry_attendant_status
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
            table_customers = new DataGridView();
            button_edit = new Button();
            button_add = new Button();
            button_archive = new Button();
            label1 = new Label();
            panel2 = new Panel();
            button_archives = new Button();
            add = new Button();
            panel3 = new Panel();
            textbox_search = new TextBox();
            lblRoleFilter = new Label();
            cmbRoleFilter = new ComboBox();
            panelPagination = new Panel();
            lblTotalRecords = new Label();
            cmbPageSize = new ComboBox();
            lblPageInfo = new Label();
            btnLast = new Button();
            btnNext = new Button();
            btnPrevious = new Button();
            btnFirst = new Button();
            ((System.ComponentModel.ISupportInitialize)table_customers).BeginInit();
            panel3.SuspendLayout();
            panelPagination.SuspendLayout();
            SuspendLayout();
            // 
            // table_customers
            // 
            table_customers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            table_customers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            table_customers.BackgroundColor = SystemColors.ButtonHighlight;
            table_customers.BorderStyle = BorderStyle.None;
            table_customers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            table_customers.Location = new Point(264, 153);
            table_customers.Name = "table_customers";
            table_customers.ReadOnly = true;
            table_customers.RowHeadersVisible = false;
            table_customers.RowHeadersWidth = 51;
            table_customers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            table_customers.Size = new Size(751, 291);
            table_customers.TabIndex = 1;
            table_customers.CellContentClick += table_customers_CellContentClick;
            // 
            // button_edit
            // 
            button_edit.Location = new Point(0, 0);
            button_edit.Name = "button_edit";
            button_edit.Size = new Size(75, 23);
            button_edit.TabIndex = 0;
            // 
            // button_add
            // 
            button_add.Location = new Point(0, 0);
            button_add.Name = "button_add";
            button_add.Size = new Size(75, 23);
            button_add.TabIndex = 0;
            // 
            // button_archive
            // 
            button_archive.Location = new Point(0, 0);
            button_archive.Name = "button_archive";
            button_archive.Size = new Size(75, 23);
            button_archive.TabIndex = 0;
            // 
            // label1
            // 
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 100);
            panel2.TabIndex = 0;
            // 
            // button_archives
            // 
            button_archives.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_archives.BackColor = SystemColors.ActiveCaption;
            button_archives.FlatAppearance.BorderSize = 0;
            button_archives.FlatStyle = FlatStyle.Flat;
            button_archives.Font = new Font("Gadugi", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_archives.Location = new Point(573, 16);
            button_archives.Name = "button_archives";
            button_archives.Size = new Size(50, 40);
            button_archives.TabIndex = 8;
            button_archives.Text = "🗂️";
            button_archives.UseVisualStyleBackColor = false;
            button_archives.Click += button_archives_Click;
            // 
            // add
            // 
            add.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            add.BackColor = SystemColors.Highlight;
            add.FlatAppearance.BorderSize = 0;
            add.FlatStyle = FlatStyle.Flat;
            add.Font = new Font("Gadugi", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            add.ForeColor = SystemColors.ButtonHighlight;
            add.Location = new Point(630, 18);
            add.Name = "add";
            add.Size = new Size(162, 32);
            add.TabIndex = 9;
            add.Text = "➕ Add Customer";
            add.UseVisualStyleBackColor = false;
            add.Click += add_Click;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = SystemColors.ActiveCaption;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(textbox_search);
            panel3.Controls.Add(lblRoleFilter);
            panel3.Controls.Add(cmbRoleFilter);
            panel3.Controls.Add(add);
            panel3.Controls.Add(button_archives);
            panel3.Font = new Font("Cascadia Code", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel3.ForeColor = SystemColors.ButtonHighlight;
            panel3.Location = new Point(217, 81);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(810, 67);
            panel3.TabIndex = 12;
            // 
            // textbox_search
            // 
            textbox_search.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textbox_search.Location = new Point(10, 16);
            textbox_search.Margin = new Padding(2);
            textbox_search.Multiline = true;
            textbox_search.Name = "textbox_search";
            textbox_search.PlaceholderText = "🔎 Search here...";
            textbox_search.Size = new Size(241, 35);
            textbox_search.TabIndex = 13;
            textbox_search.TextChanged += textbox_search_TextChanged;
            // 
            // lblRoleFilter
            // 
            lblRoleFilter.AutoSize = true;
            lblRoleFilter.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRoleFilter.ForeColor = Color.White;
            lblRoleFilter.Location = new Point(256, 26);
            lblRoleFilter.Margin = new Padding(2, 0, 2, 0);
            lblRoleFilter.Name = "lblRoleFilter";
            lblRoleFilter.Size = new Size(79, 19);
            lblRoleFilter.TabIndex = 15;
            lblRoleFilter.Text = "Role Filter:";
            // 
            // cmbRoleFilter
            // 
            cmbRoleFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRoleFilter.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbRoleFilter.Items.AddRange(new object[] { "🔽 All Roles", "Admin", "Laundry Attendant", "Customer" });
            cmbRoleFilter.Location = new Point(339, 24);
            cmbRoleFilter.Margin = new Padding(2);
            cmbRoleFilter.Name = "cmbRoleFilter";
            cmbRoleFilter.Size = new Size(121, 27);
            cmbRoleFilter.TabIndex = 16;
            cmbRoleFilter.SelectedIndexChanged += cmbRoleFilter_SelectedIndexChanged;
            // 
            // panelPagination
            // 
            panelPagination.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelPagination.BackColor = SystemColors.ButtonHighlight;
            panelPagination.BorderStyle = BorderStyle.FixedSingle;
            panelPagination.Controls.Add(lblTotalRecords);
            panelPagination.Controls.Add(cmbPageSize);
            panelPagination.Controls.Add(lblPageInfo);
            panelPagination.Controls.Add(btnLast);
            panelPagination.Controls.Add(btnNext);
            panelPagination.Controls.Add(btnPrevious);
            panelPagination.Controls.Add(btnFirst);
            panelPagination.Location = new Point(217, 450);
            panelPagination.Name = "panelPagination";
            panelPagination.Size = new Size(797, 49);
            panelPagination.TabIndex = 14;
            // 
            // lblTotalRecords
            // 
            lblTotalRecords.Anchor = AnchorStyles.Bottom;
            lblTotalRecords.AutoSize = true;
            lblTotalRecords.Font = new Font("Gadugi", 9F);
            lblTotalRecords.Location = new Point(344, 18);
            lblTotalRecords.Name = "lblTotalRecords";
            lblTotalRecords.Size = new Size(115, 19);
            lblTotalRecords.TabIndex = 5;
            lblTotalRecords.Text = "Total Records: 0";
            // 
            // cmbPageSize
            // 
            cmbPageSize.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            cmbPageSize.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPageSize.Font = new Font("Gadugi", 9F);
            cmbPageSize.FormattingEnabled = true;
            cmbPageSize.Items.AddRange(new object[] { "5", "10", "20", "50" });
            cmbPageSize.Location = new Point(552, 16);
            cmbPageSize.Name = "cmbPageSize";
            cmbPageSize.Size = new Size(60, 27);
            cmbPageSize.TabIndex = 6;
            cmbPageSize.SelectedIndexChanged += cmbPageSize_SelectedIndexChanged;
            // 
            // lblPageInfo
            // 
            lblPageInfo.AutoSize = true;
            lblPageInfo.Font = new Font("Gadugi", 9F);
            lblPageInfo.Location = new Point(170, 19);
            lblPageInfo.Name = "lblPageInfo";
            lblPageInfo.Size = new Size(84, 19);
            lblPageInfo.TabIndex = 4;
            lblPageInfo.Text = "Page 1 of 1";
            // 
            // btnLast
            // 
            btnLast.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnLast.Font = new Font("Gadugi", 9F);
            btnLast.Location = new Point(710, 15);
            btnLast.Name = "btnLast";
            btnLast.Size = new Size(60, 25);
            btnLast.TabIndex = 3;
            btnLast.Text = "Last";
            btnLast.UseVisualStyleBackColor = true;
            btnLast.Click += btnLast_Click;
            // 
            // btnNext
            // 
            btnNext.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnNext.Font = new Font("Gadugi", 9F);
            btnNext.Location = new Point(629, 15);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(75, 25);
            btnNext.TabIndex = 2;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // btnPrevious
            // 
            btnPrevious.Font = new Font("Gadugi", 9F);
            btnPrevious.Location = new Point(80, 15);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(75, 25);
            btnPrevious.TabIndex = 1;
            btnPrevious.Text = "Previous";
            btnPrevious.UseVisualStyleBackColor = true;
            btnPrevious.Click += btnPrevious_Click;
            // 
            // btnFirst
            // 
            btnFirst.Font = new Font("Gadugi", 9F);
            btnFirst.Location = new Point(10, 15);
            btnFirst.Name = "btnFirst";
            btnFirst.Size = new Size(60, 25);
            btnFirst.TabIndex = 0;
            btnFirst.Text = "First";
            btnFirst.UseVisualStyleBackColor = true;
            btnFirst.Click += btnFirst_Click;
            // 
            // laundry_attendant_status
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1029, 510);
            Controls.Add(panelPagination);
            Controls.Add(table_customers);
            Controls.Add(panel3);
            Margin = new Padding(4);
            Name = "laundry_attendant_status";
            Text = "Laundry Attendant | Status";
            Load += laundry_attendant_status_Load;
            Controls.SetChildIndex(panel3, 0);
            Controls.SetChildIndex(table_customers, 0);
            Controls.SetChildIndex(panelPagination, 0);
            ((System.ComponentModel.ISupportInitialize)table_customers).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panelPagination.ResumeLayout(false);
            panelPagination.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView table_customers;
        private Button button_edit;
        private Button button_add;
        private Button button_archive;
        private Label label1;
        private Panel panel2;
        private Button button_archives;
        private Button add;
        private Panel panel3;
        private TextBox textbox_search;
        private Label lblRoleFilter;
        private ComboBox cmbRoleFilter;
        private Panel panelPagination;
        private Label lblTotalRecords;
        private ComboBox cmbPageSize;
        private Label lblPageInfo;
        private Button btnLast;
        private Button btnNext;
        private Button btnPrevious;
        private Button btnFirst;
    }
}
