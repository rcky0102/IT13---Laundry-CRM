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
<<<<<<< Updated upstream
            ((System.ComponentModel.ISupportInitialize)table_customers).BeginInit();
=======
            label1 = new Label();
            panel2 = new Panel();
            SearchBtn_Status = new Button();
            textBox1 = new TextBox();
            button1 = new Button();
            button_archives = new Button();
            add = new Button();
            panel3 = new Panel();
            textbox_search = new TextBox();
            lblPageInfo = new Label();
            btnFirst = new Button();
            btnPrev = new Button();
            btnNext = new Button();
            btnLast = new Button();
            cmbPageSize = new ComboBox();
            label3 = new Label();
            panel4 = new Panel();
            ((System.ComponentModel.ISupportInitialize)table_customers).BeginInit();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
>>>>>>> Stashed changes
            SuspendLayout();
            // 
            // table_customers
            // 
            table_customers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
<<<<<<< Updated upstream
            table_customers.Location = new Point(245, 181);
=======
            table_customers.Location = new Point(263, 186);
            table_customers.Margin = new Padding(4);
>>>>>>> Stashed changes
            table_customers.Name = "table_customers";
            table_customers.RowHeadersWidth = 51;
<<<<<<< Updated upstream
            table_customers.Size = new Size(636, 188);
=======
            table_customers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            table_customers.Size = new Size(987, 277);
>>>>>>> Stashed changes
            table_customers.TabIndex = 1;
            table_customers.CellContentClick += table_customers_CellContentClick;
            // 
            // button_edit
            // 
            button_edit.Location = new Point(563, 128);
            button_edit.Name = "button_edit";
            button_edit.Size = new Size(145, 29);
            button_edit.TabIndex = 2;
<<<<<<< Updated upstream
            button_edit.Text = "Update Status";
            button_edit.UseVisualStyleBackColor = true;
            button_edit.Click += button_edit_Click;
=======
            button_edit.Text = "✏️";
            button_edit.UseVisualStyleBackColor = false;
>>>>>>> Stashed changes
            // 
            // button_add
            // 
            button_add.Location = new Point(315, 125);
            button_add.Name = "button_add";
            button_add.Size = new Size(94, 29);
            button_add.TabIndex = 3;
<<<<<<< Updated upstream
            button_add.Text = "Add ";
            button_add.UseVisualStyleBackColor = true;
            button_add.Click += button_add_Click;
=======
            button_add.Text = "➕Add ";
            button_add.UseVisualStyleBackColor = false;
>>>>>>> Stashed changes
            // 
            // button_archive
            // 
            button_archive.Location = new Point(775, 125);
            button_archive.Name = "button_archive";
            button_archive.Size = new Size(94, 29);
            button_archive.TabIndex = 4;
<<<<<<< Updated upstream
            button_archive.Text = "Archive";
            button_archive.UseVisualStyleBackColor = true;
            button_archive.Click += button_archive_Click;
            // 
=======
            button_archive.Text = "📦";
            button_archive.UseVisualStyleBackColor = false;
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
            button_archives.BackColor = SystemColors.ButtonHighlight;
            button_archives.FlatAppearance.BorderSize = 0;
            button_archives.FlatStyle = FlatStyle.Flat;
            button_archives.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_archives.ForeColor = SystemColors.ActiveCaptionText;
            button_archives.Location = new Point(1184, 469);
            button_archives.Margin = new Padding(4);
            button_archives.Name = "button_archives";
            button_archives.Size = new Size(70, 39);
            button_archives.TabIndex = 8;
            button_archives.Text = "🗂";
            button_archives.UseVisualStyleBackColor = false;
            button_archives.Click += button_archives_Click;
            // 
            // add
            // 
            add.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            add.BackColor = SystemColors.Highlight;
            add.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            add.ForeColor = SystemColors.ButtonHighlight;
            add.Location = new Point(774, 14);
            add.Margin = new Padding(4);
            add.Name = "add";
            add.Size = new Size(199, 43);
            add.TabIndex = 9;
            add.Text = "➕ Add Status";
            add.UseVisualStyleBackColor = false;
            add.Click += add_Click;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = SystemColors.ActiveCaption;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Font = new Font("Cascadia Code", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel3.ForeColor = SystemColors.ButtonHighlight;
            panel3.Location = new Point(272, 91);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(944, 88);
            panel3.TabIndex = 12;
            // 
            // textbox_search
            // 
            textbox_search.BorderStyle = BorderStyle.FixedSingle;
            textbox_search.Font = new Font("Gadugi", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textbox_search.Location = new Point(5, 18);
            textbox_search.Margin = new Padding(2);
            textbox_search.Multiline = true;
            textbox_search.Name = "textbox_search";
            textbox_search.PlaceholderText = "🔎 Search here...";
            textbox_search.Size = new Size(377, 43);
            textbox_search.TabIndex = 13;
            textbox_search.TextChanged += textbox_search_TextChanged;
            // 
            // lblPageInfo
            // 
            lblPageInfo.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblPageInfo.AutoSize = true;
            lblPageInfo.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPageInfo.ForeColor = SystemColors.ControlDarkDark;
            lblPageInfo.Location = new Point(257, 516);
            lblPageInfo.Name = "lblPageInfo";
            lblPageInfo.Size = new Size(238, 21);
            lblPageInfo.TabIndex = 13;
            lblPageInfo.Text = "Page 1 of 1 (Total: 0 records)";
            // 
            // btnFirst
            // 
            btnFirst.Anchor = AnchorStyles.Bottom;
            btnFirst.BackColor = SystemColors.ActiveCaption;
            btnFirst.FlatAppearance.BorderSize = 0;
            btnFirst.FlatStyle = FlatStyle.System;
            btnFirst.Font = new Font("Gadugi", 8F);
            btnFirst.ForeColor = SystemColors.ActiveCaptionText;
            btnFirst.Location = new Point(537, 475);
            btnFirst.Margin = new Padding(4);
            btnFirst.Name = "btnFirst";
            btnFirst.Size = new Size(123, 28);
            btnFirst.TabIndex = 14;
            btnFirst.Text = "« First";
            btnFirst.UseVisualStyleBackColor = false;
            btnFirst.Click += btnFirst_Click;
            // 
            // btnPrev
            // 
            btnPrev.Anchor = AnchorStyles.Bottom;
            btnPrev.BackColor = SystemColors.ActiveCaption;
            btnPrev.FlatAppearance.BorderSize = 0;
            btnPrev.FlatStyle = FlatStyle.System;
            btnPrev.Font = new Font("Gadugi", 8F);
            btnPrev.ForeColor = SystemColors.ActiveCaptionText;
            btnPrev.Location = new Point(661, 475);
            btnPrev.Margin = new Padding(4);
            btnPrev.Name = "btnPrev";
            btnPrev.Size = new Size(134, 28);
            btnPrev.TabIndex = 15;
            btnPrev.Text = "‹ Previous";
            btnPrev.UseVisualStyleBackColor = false;
            btnPrev.Click += btnPrev_Click;
            // 
            // btnNext
            // 
            btnNext.Anchor = AnchorStyles.Bottom;
            btnNext.BackColor = SystemColors.ActiveCaption;
            btnNext.FlatAppearance.BorderSize = 0;
            btnNext.FlatStyle = FlatStyle.System;
            btnNext.Font = new Font("Gadugi", 8F);
            btnNext.ForeColor = SystemColors.ActiveCaptionText;
            btnNext.Location = new Point(796, 475);
            btnNext.Margin = new Padding(4);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(100, 28);
            btnNext.TabIndex = 16;
            btnNext.Text = "Next ›";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // btnLast
            // 
            btnLast.Anchor = AnchorStyles.Bottom;
            btnLast.BackColor = SystemColors.ActiveCaption;
            btnLast.FlatAppearance.BorderSize = 0;
            btnLast.FlatStyle = FlatStyle.System;
            btnLast.Font = new Font("Gadugi", 8F);
            btnLast.ForeColor = SystemColors.ActiveCaptionText;
            btnLast.Location = new Point(897, 475);
            btnLast.Margin = new Padding(4);
            btnLast.Name = "btnLast";
            btnLast.Size = new Size(128, 28);
            btnLast.TabIndex = 17;
            btnLast.Text = "Last »";
            btnLast.UseVisualStyleBackColor = false;
            btnLast.Click += btnLast_Click;
            // 
            // cmbPageSize
            // 
            cmbPageSize.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            cmbPageSize.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPageSize.Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbPageSize.FormattingEnabled = true;
            cmbPageSize.Items.AddRange(new object[] { "5", "10", "20", "50" });
            cmbPageSize.Location = new Point(1184, 516);
            cmbPageSize.Margin = new Padding(4);
            cmbPageSize.Name = "cmbPageSize";
            cmbPageSize.Size = new Size(70, 32);
            cmbPageSize.TabIndex = 18;
            cmbPageSize.SelectedIndexChanged += cmbPageSize_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlDarkDark;
            label3.Location = new Point(1071, 523);
            label3.Name = "label3";
            label3.Size = new Size(83, 21);
            label3.TabIndex = 19;
            label3.Text = "Per Page:";
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel4.BackColor = SystemColors.ActiveCaption;
            panel4.BorderStyle = BorderStyle.Fixed3D;
            panel4.Controls.Add(add);
            panel4.Controls.Add(textbox_search);
            panel4.Location = new Point(263, 92);
            panel4.Name = "panel4";
            panel4.Size = new Size(991, 87);
            panel4.TabIndex = 19;
            panel4.Paint += panel4_Paint;
            // 
>>>>>>> Stashed changes
            // laundry_attendant_status
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
<<<<<<< Updated upstream
            ClientSize = new Size(945, 450);
            Controls.Add(button_archive);
            Controls.Add(button_add);
            Controls.Add(button_edit);
            Controls.Add(table_customers);
=======
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1269, 561);
            Controls.Add(button_archives);
            Controls.Add(cmbPageSize);
            Controls.Add(btnLast);
            Controls.Add(btnNext);
            Controls.Add(btnPrev);
            Controls.Add(btnFirst);
            Controls.Add(lblPageInfo);
            Controls.Add(table_customers);
            Controls.Add(panel4);
            Margin = new Padding(5);
>>>>>>> Stashed changes
            Name = "laundry_attendant_status";
            Text = "laundry_attendant_status";
            Load += laundry_attendant_status_Load;
<<<<<<< Updated upstream
            Controls.SetChildIndex(table_customers, 0);
            Controls.SetChildIndex(button_edit, 0);
            Controls.SetChildIndex(button_add, 0);
            Controls.SetChildIndex(button_archive, 0);
            ((System.ComponentModel.ISupportInitialize)table_customers).EndInit();
=======
            Controls.SetChildIndex(panel4, 0);
            Controls.SetChildIndex(table_customers, 0);
            Controls.SetChildIndex(lblPageInfo, 0);
            Controls.SetChildIndex(btnFirst, 0);
            Controls.SetChildIndex(btnPrev, 0);
            Controls.SetChildIndex(btnNext, 0);
            Controls.SetChildIndex(btnLast, 0);
            Controls.SetChildIndex(cmbPageSize, 0);
            Controls.SetChildIndex(button_archives, 0);
            ((System.ComponentModel.ISupportInitialize)table_customers).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
>>>>>>> Stashed changes
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView table_customers;
        private Button button_edit;
        private Button button_add;
        private Button button_archive;
<<<<<<< Updated upstream
=======
        private Label label1;
        private Panel panel2;
        private Button button1;
        private TextBox textBox1;
        private Button SearchBtn_Status;
        private Button button_archives;
        private Button add;
        private Panel panel3;
        private TextBox textbox_search;
        private Label lblPageInfo;
        private Button btnFirst;
        private Button btnPrev;
        private Button btnNext;
        private Button btnLast;
        private ComboBox cmbPageSize;
        private Label label3;
        private Panel panel4;
>>>>>>> Stashed changes
    }
}