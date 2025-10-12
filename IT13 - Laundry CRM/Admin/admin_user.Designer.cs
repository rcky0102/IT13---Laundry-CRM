namespace IT13___Laundry_CRM.Admin
{
    partial class admin_user
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
            button_add = new Button();
            table_users = new DataGridView();
            panel2 = new Panel();
            textBox_search = new TextBox();
            cmbPageSize = new ComboBox();
            btnLast = new Button();
            btnNext = new Button();
            lblTotalRecords = new Label();
            lblPageInfo = new Label();
            btnPrevious = new Button();
            btnFirst = new Button();
            panelPagination = new Panel();
            panel3 = new Panel();
            ((System.ComponentModel.ISupportInitialize)table_users).BeginInit();
            panelPagination.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // button_add
            // 
            button_add.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_add.BackColor = SystemColors.Highlight;
            button_add.FlatAppearance.BorderSize = 0;
            button_add.FlatStyle = FlatStyle.Flat;
            button_add.Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_add.ForeColor = SystemColors.ButtonHighlight;
            button_add.Location = new Point(788, 12);
            button_add.Name = "button_add";
            button_add.Size = new Size(171, 48);
            button_add.TabIndex = 2;
            button_add.Text = "➕ Add User";
            button_add.UseVisualStyleBackColor = false;
            button_add.Click += button_add_Click;
            // 
            // table_users
            // 
            table_users.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            table_users.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            table_users.BackgroundColor = SystemColors.ButtonHighlight;
            table_users.BorderStyle = BorderStyle.None;
            table_users.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            table_users.GridColor = SystemColors.MenuBar;
            table_users.Location = new Point(250, 161);
            table_users.Name = "table_users";
            table_users.ReadOnly = true;
            table_users.RowHeadersVisible = false;
            table_users.RowHeadersWidth = 51;
            table_users.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            table_users.Size = new Size(961, 416);
            table_users.TabIndex = 3;
            table_users.CellClick += table_users_CellClick;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Location = new Point(272, 100);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(958, 75);
            panel2.TabIndex = 6;
            // 
            // textBox_search
            // 
            textBox_search.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_search.Location = new Point(16, 18);
            textBox_search.Multiline = true;
            textBox_search.Name = "textBox_search";
            textBox_search.PlaceholderText = "🔎 Search here...";
            textBox_search.Size = new Size(400, 40);
            textBox_search.TabIndex = 6;
            textBox_search.TextChanged += textBox_search_TextChanged;
            // 
            // cmbPageSize
            // 
            cmbPageSize.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            cmbPageSize.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPageSize.Font = new Font("Gadugi", 9F);
            cmbPageSize.FormattingEnabled = true;
            cmbPageSize.Items.AddRange(new object[] { "5", "10", "25", "50" });
            cmbPageSize.Location = new Point(703, 7);
            cmbPageSize.Name = "cmbPageSize";
            cmbPageSize.Size = new Size(60, 29);
            cmbPageSize.TabIndex = 11;
            // 
            // btnLast
            // 
            btnLast.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnLast.Font = new Font("Gadugi", 9F);
            btnLast.Location = new Point(886, 8);
            btnLast.Name = "btnLast";
            btnLast.Size = new Size(73, 28);
            btnLast.TabIndex = 10;
            btnLast.Text = "Last";
            btnLast.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            btnNext.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnNext.Font = new Font("Gadugi", 9F);
            btnNext.Location = new Point(804, 8);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(76, 28);
            btnNext.TabIndex = 9;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            // 
            // lblTotalRecords
            // 
            lblTotalRecords.Anchor = AnchorStyles.Bottom;
            lblTotalRecords.AutoSize = true;
            lblTotalRecords.Font = new Font("Gadugi", 9F);
            lblTotalRecords.Location = new Point(409, 12);
            lblTotalRecords.Name = "lblTotalRecords";
            lblTotalRecords.Size = new Size(137, 21);
            lblTotalRecords.TabIndex = 8;
            lblTotalRecords.Text = "Total Records: 0";
            // 
            // lblPageInfo
            // 
            lblPageInfo.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblPageInfo.AutoSize = true;
            lblPageInfo.Font = new Font("Gadugi", 9F);
            lblPageInfo.Location = new Point(202, 10);
            lblPageInfo.Name = "lblPageInfo";
            lblPageInfo.Size = new Size(101, 21);
            lblPageInfo.TabIndex = 7;
            lblPageInfo.Text = "Page 1 of 1";
            // 
            // btnPrevious
            // 
            btnPrevious.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnPrevious.Font = new Font("Gadugi", 9F);
            btnPrevious.Location = new Point(92, 8);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(104, 28);
            btnPrevious.TabIndex = 6;
            btnPrevious.Text = "Previous";
            btnPrevious.UseVisualStyleBackColor = true;
            // 
            // btnFirst
            // 
            btnFirst.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnFirst.Font = new Font("Gadugi", 9F);
            btnFirst.Location = new Point(10, 8);
            btnFirst.Name = "btnFirst";
            btnFirst.Size = new Size(76, 28);
            btnFirst.TabIndex = 5;
            btnFirst.Text = "First";
            btnFirst.UseVisualStyleBackColor = true;
            // 
            // panelPagination
            // 
            panelPagination.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelPagination.BackColor = SystemColors.ButtonHighlight;
            panelPagination.BorderStyle = BorderStyle.Fixed3D;
            panelPagination.Controls.Add(btnFirst);
            panelPagination.Controls.Add(cmbPageSize);
            panelPagination.Controls.Add(btnPrevious);
            panelPagination.Controls.Add(btnLast);
            panelPagination.Controls.Add(lblPageInfo);
            panelPagination.Controls.Add(btnNext);
            panelPagination.Controls.Add(lblTotalRecords);
            panelPagination.Location = new Point(250, 605);
            panelPagination.Name = "panelPagination";
            panelPagination.Size = new Size(977, 45);
            panelPagination.TabIndex = 9;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = SystemColors.ActiveCaption;
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(textBox_search);
            panel3.Controls.Add(button_add);
            panel3.Location = new Point(250, 80);
            panel3.Name = "panel3";
            panel3.Size = new Size(977, 75);
            panel3.TabIndex = 10;
            // 
            // admin_user
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1241, 662);
            Controls.Add(panelPagination);
            Controls.Add(table_users);
            Controls.Add(panel3);
            Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 3, 5, 3);
            Name = "admin_user";
            Text = "Admin | User";
            Load += admin_user_Load;
            Controls.SetChildIndex(panel3, 0);
            Controls.SetChildIndex(table_users, 0);
            Controls.SetChildIndex(panelPagination, 0);
            ((System.ComponentModel.ISupportInitialize)table_users).EndInit();
            panelPagination.ResumeLayout(false);
            panelPagination.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button_add;
        private DataGridView table_users;
        private Button button_delete;
        private Panel panel2;
        private TextBox textBox_search;
        private Panel panelPagination;
        private ComboBox cmbPageSize;
        private Button btnLast;
        private Button btnNext;
        private Label lblTotalRecords;
        private Label lblPageInfo;
        private Button btnPrevious;
        private Button btnFirst;
        private Panel panel3;
    }
}