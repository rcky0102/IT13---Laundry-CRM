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
            SearchBtn_Status = new Button();
            textBox1 = new TextBox();
            button1 = new Button();
            button_archives = new Button();
            add = new Button();
            panel3 = new Panel();
            label2 = new Label();
            textbox_search = new TextBox();
            panelPagination = new Panel();
            lblTotalRecords = new Label();
            cmbPageSize = new ComboBox();
            lblPageInfo = new Label();
            btnLast = new Button();
            btnNext = new Button();
            btnPrevious = new Button();
            btnFirst = new Button();
            ((System.ComponentModel.ISupportInitialize)table_customers).BeginInit();
            panel2.SuspendLayout();
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
            table_customers.Location = new Point(259, 185);
            table_customers.Margin = new Padding(4);
            table_customers.Name = "table_customers";
            table_customers.ReadOnly = true;
            table_customers.RowHeadersVisible = false;
            table_customers.RowHeadersWidth = 51;
            table_customers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            table_customers.Size = new Size(1010, 370);
            table_customers.TabIndex = 1;
            table_customers.CellContentClick += table_customers_CellContentClick;
            // 
            // button_edit
            // 
            button_edit.BackColor = Color.MediumSeaGreen;
            button_edit.FlatAppearance.BorderSize = 0;
            button_edit.ForeColor = SystemColors.ButtonHighlight;
            button_edit.Location = new Point(631, 14);
            button_edit.Name = "button_edit";
            button_edit.Size = new Size(38, 29);
            button_edit.TabIndex = 2;
            button_edit.Text = "✏️";
            button_edit.UseVisualStyleBackColor = false;
            button_edit.Click += button_edit_Click;
            // 
            // button_add
            // 
            button_add.BackColor = Color.RoyalBlue;
            button_add.FlatAppearance.BorderSize = 0;
            button_add.ForeColor = SystemColors.ButtonHighlight;
            button_add.Location = new Point(14, 15);
            button_add.Name = "button_add";
            button_add.Size = new Size(94, 29);
            button_add.TabIndex = 3;
            button_add.Text = "➕Add ";
            button_add.UseVisualStyleBackColor = false;
            button_add.Click += button_add_Click;
            // 
            // button_archive
            // 
            button_archive.BackColor = Color.Orange;
            button_archive.ForeColor = SystemColors.ButtonHighlight;
            button_archive.Location = new Point(675, 14);
            button_archive.Name = "button_archive";
            button_archive.Size = new Size(41, 29);
            button_archive.TabIndex = 4;
            button_archive.Text = "📦";
            button_archive.UseVisualStyleBackColor = false;
            button_archive.Click += button_archive_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Code SemiLight", 8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaption;
            label1.Location = new Point(262, 45);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(552, 18);
            label1.TabIndex = 5;
            label1.Text = "Laundry Status: In Progress: 5 | Ready for Pickup: 2 | Completed: 10";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(SearchBtn_Status);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(button_add);
            panel2.Controls.Add(button_archive);
            panel2.Controls.Add(button_edit);
            panel2.Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel2.Location = new Point(207, 86);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(728, 58);
            panel2.TabIndex = 6;
            // 
            // SearchBtn_Status
            // 
            SearchBtn_Status.Location = new Point(257, 15);
            SearchBtn_Status.Margin = new Padding(2);
            SearchBtn_Status.Name = "SearchBtn_Status";
            SearchBtn_Status.Size = new Size(33, 27);
            SearchBtn_Status.TabIndex = 6;
            SearchBtn_Status.Text = "🔎";
            SearchBtn_Status.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(294, 18);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(332, 28);
            textBox1.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(240, 19);
            button1.Name = "button1";
            button1.Size = new Size(41, 34);
            button1.TabIndex = 6;
            button1.Text = "🔎";
            button1.UseVisualStyleBackColor = true;
            // 
            // button_archives
            // 
            button_archives.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_archives.BackColor = SystemColors.ActiveCaption;
            button_archives.FlatAppearance.BorderSize = 0;
            button_archives.FlatStyle = FlatStyle.Flat;
            button_archives.Font = new Font("Gadugi", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_archives.Location = new Point(714, 18);
            button_archives.Margin = new Padding(4);
            button_archives.Name = "button_archives";
            button_archives.Size = new Size(62, 50);
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
            add.Location = new Point(786, 21);
            add.Margin = new Padding(4);
            add.Name = "add";
            add.Size = new Size(202, 40);
            add.TabIndex = 9;
            add.Text = "➕ Add Cutomer";
            add.UseVisualStyleBackColor = false;
            add.Click += add_Click;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = SystemColors.ActiveCaption;
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(label2);
            panel3.Controls.Add(textbox_search);
            panel3.Controls.Add(add);
            panel3.Controls.Add(button_archives);
            panel3.Font = new Font("Cascadia Code", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel3.ForeColor = SystemColors.ButtonHighlight;
            panel3.Location = new Point(259, 78);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(1012, 83);
            panel3.TabIndex = 12;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Gadugi", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(614, 35);
            label2.Name = "label2";
            label2.Size = new Size(102, 19);
            label2.TabIndex = 14;
            label2.Text = "View Archive:";
            // 
            // textbox_search
            // 
            textbox_search.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textbox_search.Location = new Point(13, 20);
            textbox_search.Margin = new Padding(2);
            textbox_search.Multiline = true;
            textbox_search.Name = "textbox_search";
            textbox_search.PlaceholderText = "🔎 Search here...";
            textbox_search.Size = new Size(415, 43);
            textbox_search.TabIndex = 13;
            textbox_search.TextChanged += textbox_search_TextChanged;
            // 
            // panelPagination
            // 
            panelPagination.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelPagination.BackColor = SystemColors.ButtonHighlight;
            panelPagination.BorderStyle = BorderStyle.Fixed3D;
            panelPagination.Controls.Add(lblTotalRecords);
            panelPagination.Controls.Add(cmbPageSize);
            panelPagination.Controls.Add(lblPageInfo);
            panelPagination.Controls.Add(btnLast);
            panelPagination.Controls.Add(btnNext);
            panelPagination.Controls.Add(btnPrevious);
            panelPagination.Controls.Add(btnFirst);
            panelPagination.Location = new Point(259, 576);
            panelPagination.Margin = new Padding(4);
            panelPagination.Name = "panelPagination";
            panelPagination.Size = new Size(1008, 48);
            panelPagination.TabIndex = 14;
            // 
            // lblTotalRecords
            // 
            lblTotalRecords.Anchor = AnchorStyles.Bottom;
            lblTotalRecords.AutoSize = true;
            lblTotalRecords.Font = new Font("Gadugi", 9F);
            lblTotalRecords.Location = new Point(435, 8);
            lblTotalRecords.Margin = new Padding(4, 0, 4, 0);
            lblTotalRecords.Name = "lblTotalRecords";
            lblTotalRecords.Size = new Size(137, 21);
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
            cmbPageSize.Location = new Point(700, 5);
            cmbPageSize.Margin = new Padding(4);
            cmbPageSize.Name = "cmbPageSize";
            cmbPageSize.Size = new Size(74, 29);
            cmbPageSize.TabIndex = 6;
            cmbPageSize.SelectedIndexChanged += cmbPageSize_SelectedIndexChanged;
            // 
            // lblPageInfo
            // 
            lblPageInfo.AutoSize = true;
            lblPageInfo.Font = new Font("Gadugi", 9F);
            lblPageInfo.Location = new Point(204, 11);
            lblPageInfo.Margin = new Padding(4, 0, 4, 0);
            lblPageInfo.Name = "lblPageInfo";
            lblPageInfo.Size = new Size(101, 21);
            lblPageInfo.TabIndex = 4;
            lblPageInfo.Text = "Page 1 of 1";
            // 
            // btnLast
            // 
            btnLast.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnLast.Font = new Font("Gadugi", 9F);
            btnLast.Location = new Point(898, 4);
            btnLast.Margin = new Padding(4);
            btnLast.Name = "btnLast";
            btnLast.Size = new Size(75, 31);
            btnLast.TabIndex = 3;
            btnLast.Text = "Last";
            btnLast.UseVisualStyleBackColor = true;
            btnLast.Click += btnLast_Click;
            // 
            // btnNext
            // 
            btnNext.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnNext.Font = new Font("Gadugi", 9F);
            btnNext.Location = new Point(796, 4);
            btnNext.Margin = new Padding(4);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(94, 31);
            btnNext.TabIndex = 2;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // btnPrevious
            // 
            btnPrevious.Font = new Font("Gadugi", 9F);
            btnPrevious.Location = new Point(92, 6);
            btnPrevious.Margin = new Padding(4);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(94, 31);
            btnPrevious.TabIndex = 1;
            btnPrevious.Text = "Previous";
            btnPrevious.UseVisualStyleBackColor = true;
            btnPrevious.Click += btnPrevious_Click;
            // 
            // btnFirst
            // 
            btnFirst.Font = new Font("Gadugi", 9F);
            btnFirst.Location = new Point(4, 6);
            btnFirst.Margin = new Padding(4);
            btnFirst.Name = "btnFirst";
            btnFirst.Size = new Size(75, 31);
            btnFirst.TabIndex = 0;
            btnFirst.Text = "First";
            btnFirst.UseVisualStyleBackColor = true;
            btnFirst.Click += btnFirst_Click;
            // 
            // laundry_attendant_status
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1286, 637);
            Controls.Add(panelPagination);
            Controls.Add(table_customers);
            Controls.Add(panel3);
            Margin = new Padding(5);
            Name = "laundry_attendant_status";
            Text = "Laundry Attendant | Status";
            Load += laundry_attendant_status_Load;
            Controls.SetChildIndex(panel3, 0);
            Controls.SetChildIndex(table_customers, 0);
            Controls.SetChildIndex(panelPagination, 0);
            ((System.ComponentModel.ISupportInitialize)table_customers).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
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
        private Button button1;
        private TextBox textBox1;
        private Button SearchBtn_Status;
        private Button button_archives;
        private Button add;
        private Panel panel3;
        private TextBox textbox_search;
        private Panel panelPagination;
        private Label lblTotalRecords;
        private ComboBox cmbPageSize;
        private Label lblPageInfo;
        private Button btnLast;
        private Button btnNext;
        private Button btnPrevious;
        private Button btnFirst;
        private Label label2;
    }
}