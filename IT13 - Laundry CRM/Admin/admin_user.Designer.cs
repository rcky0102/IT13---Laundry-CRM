namespace IT13___Laundry_CRM.Admin
{
    partial class admin_user
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            button_add = new Button();
            table_users = new DataGridView();
            panel2 = new Panel();
            button_archives = new Button();
            label1 = new Label();
            textBox_search = new TextBox();
            cmbRoleFilter = new ComboBox();
            cmbPageSize = new ComboBox();
            btnLast = new Button();
            btnNext = new Button();
            lblTotalRecords = new Label();
            lblPageInfo = new Label();
            btnPrevious = new Button();
            btnFirst = new Button();
            panelPagination = new Panel();
            ((System.ComponentModel.ISupportInitialize)table_users).BeginInit();
            panel2.SuspendLayout();
            panelPagination.SuspendLayout();
            SuspendLayout();
            // 
            // button_add
            // 
            button_add.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_add.BackColor = SystemColors.Highlight;
            button_add.FlatAppearance.BorderSize = 0;
            button_add.FlatStyle = FlatStyle.Flat;
            button_add.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_add.ForeColor = SystemColors.ButtonHighlight;
            button_add.Location = new Point(705, 12);
            button_add.Name = "button_add";
            button_add.Size = new Size(110, 40);
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
            table_users.Location = new Point(220, 153);
            table_users.Name = "table_users";
            table_users.ReadOnly = true;
            table_users.RowHeadersVisible = false;
            table_users.RowHeadersWidth = 51;
            table_users.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            table_users.Size = new Size(826, 431);
            table_users.TabIndex = 3;
            table_users.CellClick += table_users_CellClick;
            table_users.CellPainting += table_users_CellPainting;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = SystemColors.GradientActiveCaption;
            panel2.Controls.Add(button_archives);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(textBox_search);
            panel2.Controls.Add(cmbRoleFilter);
            panel2.Controls.Add(button_add);
            panel2.Location = new Point(220, 81);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(826, 67);
            panel2.TabIndex = 6;
            // 
            // button_archives
            // 
            button_archives.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_archives.BackColor = SystemColors.Highlight;
            button_archives.FlatAppearance.BorderSize = 0;
            button_archives.FlatStyle = FlatStyle.Flat;
            button_archives.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_archives.ForeColor = SystemColors.ButtonHighlight;
            button_archives.Location = new Point(589, 12);
            button_archives.Name = "button_archives";
            button_archives.Size = new Size(110, 40);
            button_archives.TabIndex = 9;
            button_archives.Text = "🗂️ Archives";
            button_archives.UseVisualStyleBackColor = false;
            button_archives.Click += button_archives_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gadugi", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(285, 23);
            label1.Name = "label1";
            label1.Size = new Size(71, 17);
            label1.TabIndex = 8;
            label1.Text = "Role Filter:";
            // 
            // textBox_search
            // 
            textBox_search.BorderStyle = BorderStyle.None;
            textBox_search.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_search.Location = new Point(18, 18);
            textBox_search.Multiline = true;
            textBox_search.Name = "textBox_search";
            textBox_search.PlaceholderText = "🔎 Search via first name, last name, or ID";
            textBox_search.Size = new Size(250, 30);
            textBox_search.TabIndex = 6;
            textBox_search.TextChanged += textBox_search_TextChanged;
            // 
            // cmbRoleFilter
            // 
            cmbRoleFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRoleFilter.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbRoleFilter.Items.AddRange(new object[] { "All", "Admin", "Staff", "Customer" });
            cmbRoleFilter.Location = new Point(362, 18);
            cmbRoleFilter.Name = "cmbRoleFilter";
            cmbRoleFilter.Size = new Size(120, 27);
            cmbRoleFilter.TabIndex = 7;
            cmbRoleFilter.SelectedIndexChanged += cmbRoleFilter_SelectedIndexChanged;
            // 
            // cmbPageSize
            // 
            cmbPageSize.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            cmbPageSize.BackColor = SystemColors.ButtonFace;
            cmbPageSize.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPageSize.Font = new Font("Gadugi", 9F);
            cmbPageSize.FormattingEnabled = true;
            cmbPageSize.Items.AddRange(new object[] { "5", "10", "25", "50" });
            cmbPageSize.Location = new Point(600, 21);
            cmbPageSize.Name = "cmbPageSize";
            cmbPageSize.Size = new Size(60, 27);
            cmbPageSize.TabIndex = 11;
            // 
            // btnLast
            // 
            btnLast.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnLast.BackColor = SystemColors.GradientActiveCaption;
            btnLast.FlatAppearance.BorderSize = 0;
            btnLast.FlatStyle = FlatStyle.Flat;
            btnLast.Font = new Font("Gadugi", 9F);
            btnLast.Location = new Point(755, 19);
            btnLast.Name = "btnLast";
            btnLast.Size = new Size(60, 30);
            btnLast.TabIndex = 10;
            btnLast.Text = "Last";
            btnLast.UseVisualStyleBackColor = false;
            // 
            // btnNext
            // 
            btnNext.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnNext.BackColor = SystemColors.GradientActiveCaption;
            btnNext.FlatAppearance.BorderSize = 0;
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.Font = new Font("Gadugi", 9F);
            btnNext.Location = new Point(677, 19);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(72, 30);
            btnNext.TabIndex = 9;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = false;
            // 
            // lblTotalRecords
            // 
            lblTotalRecords.Anchor = AnchorStyles.Bottom;
            lblTotalRecords.AutoSize = true;
            lblTotalRecords.Font = new Font("Gadugi", 9F);
            lblTotalRecords.Location = new Point(385, 24);
            lblTotalRecords.Name = "lblTotalRecords";
            lblTotalRecords.Size = new Size(115, 19);
            lblTotalRecords.TabIndex = 8;
            lblTotalRecords.Text = "Total Records: 0";
            // 
            // lblPageInfo
            // 
            lblPageInfo.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblPageInfo.AutoSize = true;
            lblPageInfo.Font = new Font("Gadugi", 9F);
            lblPageInfo.Location = new Point(204, 24);
            lblPageInfo.Name = "lblPageInfo";
            lblPageInfo.Size = new Size(84, 19);
            lblPageInfo.TabIndex = 7;
            lblPageInfo.Text = "Page 1 of 1";
            // 
            // btnPrevious
            // 
            btnPrevious.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnPrevious.BackColor = SystemColors.GradientActiveCaption;
            btnPrevious.FlatAppearance.BorderSize = 0;
            btnPrevious.FlatStyle = FlatStyle.Flat;
            btnPrevious.Font = new Font("Gadugi", 9F);
            btnPrevious.Location = new Point(84, 18);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(102, 30);
            btnPrevious.TabIndex = 6;
            btnPrevious.Text = "Previous";
            btnPrevious.UseVisualStyleBackColor = false;
            // 
            // btnFirst
            // 
            btnFirst.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnFirst.BackColor = SystemColors.GradientActiveCaption;
            btnFirst.FlatAppearance.BorderSize = 0;
            btnFirst.FlatStyle = FlatStyle.Flat;
            btnFirst.Font = new Font("Gadugi", 9F);
            btnFirst.Location = new Point(18, 18);
            btnFirst.Name = "btnFirst";
            btnFirst.Size = new Size(60, 30);
            btnFirst.TabIndex = 5;
            btnFirst.Text = "First";
            btnFirst.UseVisualStyleBackColor = false;
            // 
            // panelPagination
            // 
            panelPagination.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelPagination.BackColor = SystemColors.GradientInactiveCaption;
            panelPagination.Controls.Add(btnFirst);
            panelPagination.Controls.Add(cmbPageSize);
            panelPagination.Controls.Add(btnPrevious);
            panelPagination.Controls.Add(btnLast);
            panelPagination.Controls.Add(lblPageInfo);
            panelPagination.Controls.Add(btnNext);
            panelPagination.Controls.Add(lblTotalRecords);
            panelPagination.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panelPagination.Location = new Point(220, 590);
            panelPagination.Name = "panelPagination";
            panelPagination.Size = new Size(826, 60);
            panelPagination.TabIndex = 9;
            // 
            // admin_user
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1064, 662);
            Controls.Add(panelPagination);
            Controls.Add(table_users);
            Controls.Add(panel2);
            Font = new Font("Gadugi", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 3, 5, 3);
            Name = "admin_user";
            Text = "Admin | User";
            Load += admin_user_Load;
            Controls.SetChildIndex(panel2, 0);
            Controls.SetChildIndex(table_users, 0);
            Controls.SetChildIndex(panelPagination, 0);
            ((System.ComponentModel.ISupportInitialize)table_users).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panelPagination.ResumeLayout(false);
            panelPagination.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button_add;
        private DataGridView table_users;
        private Panel panel2;
        private TextBox textBox_search;
        private ComboBox cmbRoleFilter; // <-- Added here
        private Panel panelPagination;
        private ComboBox cmbPageSize;
        private Button btnLast;
        private Button btnNext;
        private Label lblTotalRecords;
        private Label lblPageInfo;
        private Button btnPrevious;
        private Button btnFirst;
        private Label label1;
        private Button button_archives;
    }
}
