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
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)table_users).BeginInit();
            panel2.SuspendLayout();
            panelPagination.SuspendLayout();
            SuspendLayout();
            // 
            // button_add
            // 
            button_add.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            button_add.BackColor = SystemColors.Highlight;
            button_add.Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_add.ForeColor = SystemColors.ButtonHighlight;
            button_add.Location = new Point(681, 15);
            button_add.Name = "button_add";
            button_add.Size = new Size(234, 40);
            button_add.TabIndex = 2;
            button_add.Text = "➕ Add Customer";
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
            table_users.Location = new Point(250, 159);
            table_users.Name = "table_users";
            table_users.ReadOnly = true;
            table_users.RowHeadersVisible = false;
            table_users.RowHeadersWidth = 51;
            table_users.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            table_users.Size = new Size(916, 440);
            table_users.TabIndex = 3;
            table_users.CellClick += table_users_CellClick;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(textBox_search);
            panel2.Controls.Add(cmbRoleFilter);
            panel2.Controls.Add(button_add);
            panel2.Location = new Point(249, 79);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(928, 75);
            panel2.TabIndex = 6;
            // 
            // textBox_search
            // 
            textBox_search.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_search.Location = new Point(18, 12);
            textBox_search.Multiline = true;
            textBox_search.Name = "textBox_search";
            textBox_search.PlaceholderText = "🔎 Search here...";
            textBox_search.Size = new Size(250, 40);
            textBox_search.TabIndex = 6;
            textBox_search.TextChanged += textBox_search_TextChanged;
            // 
            // cmbRoleFilter
            // 
            cmbRoleFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRoleFilter.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbRoleFilter.Items.AddRange(new object[] { "All", "Admin", "Staff", "Customer" });
            cmbRoleFilter.Location = new Point(389, 19);
            cmbRoleFilter.Name = "cmbRoleFilter";
            cmbRoleFilter.Size = new Size(120, 29);
            cmbRoleFilter.TabIndex = 7;
            cmbRoleFilter.SelectedIndexChanged += cmbRoleFilter_SelectedIndexChanged;
            // 
            // cmbPageSize
            // 
            cmbPageSize.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPageSize.Font = new Font("Cascadia Code", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbPageSize.FormattingEnabled = true;
            cmbPageSize.Items.AddRange(new object[] { "5", "10", "25", "50" });
            cmbPageSize.Location = new Point(694, 10);
            cmbPageSize.Name = "cmbPageSize";
            cmbPageSize.Size = new Size(60, 29);
            cmbPageSize.TabIndex = 11;
            // 
            // btnLast
            // 
            btnLast.Font = new Font("Cascadia Code", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLast.Location = new Point(854, 9);
            btnLast.Name = "btnLast";
            btnLast.Size = new Size(67, 28);
            btnLast.TabIndex = 10;
            btnLast.Text = "Last";
            btnLast.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            btnNext.Font = new Font("Cascadia Code", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNext.Location = new Point(776, 10);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(72, 28);
            btnNext.TabIndex = 9;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            // 
            // lblTotalRecords
            // 
            lblTotalRecords.AutoSize = true;
            lblTotalRecords.Font = new Font("Cascadia Code", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalRecords.Location = new Point(410, 14);
            lblTotalRecords.Name = "lblTotalRecords";
            lblTotalRecords.Size = new Size(154, 21);
            lblTotalRecords.TabIndex = 8;
            lblTotalRecords.Text = "Total Records: 0";
            // 
            // lblPageInfo
            // 
            lblPageInfo.AutoSize = true;
            lblPageInfo.Font = new Font("Cascadia Code", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPageInfo.Location = new Point(209, 13);
            lblPageInfo.Name = "lblPageInfo";
            lblPageInfo.Size = new Size(109, 21);
            lblPageInfo.TabIndex = 7;
            lblPageInfo.Text = "Page 1 of 1";
            // 
            // btnPrevious
            // 
            btnPrevious.Font = new Font("Cascadia Code", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPrevious.Location = new Point(101, 9);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(102, 28);
            btnPrevious.TabIndex = 6;
            btnPrevious.Text = "Previous";
            btnPrevious.UseVisualStyleBackColor = true;
            // 
            // btnFirst
            // 
            btnFirst.Font = new Font("Cascadia Code", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFirst.Location = new Point(20, 9);
            btnFirst.Name = "btnFirst";
            btnFirst.Size = new Size(75, 28);
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
            panelPagination.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panelPagination.Location = new Point(247, 605);
            panelPagination.Name = "panelPagination";
            panelPagination.Size = new Size(929, 45);
            panelPagination.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Code", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(274, 20);
            label1.Name = "label1";
            label1.Size = new Size(118, 21);
            label1.TabIndex = 8;
            label1.Text = "Role Filter:";
            // 
            // admin_user
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1188, 662);
            Controls.Add(panelPagination);
            Controls.Add(table_users);
            Controls.Add(panel2);
            Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
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
    }
}
