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
            button_edit = new Button();
            button_delete = new Button();
            panel2 = new Panel();
            textBox_search = new TextBox();
            ((System.ComponentModel.ISupportInitialize)table_users).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // button_add
            // 
            button_add.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            button_add.BackColor = SystemColors.Highlight;
            button_add.Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_add.ForeColor = SystemColors.ButtonHighlight;
            button_add.Location = new Point(690, 15);
            button_add.Margin = new Padding(4, 4, 4, 4);
            button_add.Name = "button_add";
            button_add.Size = new Size(60, 49);
            button_add.TabIndex = 2;
            button_add.Text = "➕";
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
            table_users.Location = new Point(259, 197);
            table_users.Margin = new Padding(4, 4, 4, 4);
            table_users.Name = "table_users";
            table_users.ReadOnly = true;
            table_users.RowHeadersVisible = false;
            table_users.RowHeadersWidth = 51;
            table_users.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            table_users.Size = new Size(906, 383);
            table_users.TabIndex = 3;
            // 
            // button_edit
            // 
            button_edit.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            button_edit.BackColor = Color.ForestGreen;
            button_edit.Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_edit.ForeColor = SystemColors.ButtonHighlight;
            button_edit.Location = new Point(758, 15);
            button_edit.Margin = new Padding(4, 4, 4, 4);
            button_edit.Name = "button_edit";
            button_edit.Size = new Size(60, 49);
            button_edit.TabIndex = 4;
            button_edit.Text = "✏️";
            button_edit.UseVisualStyleBackColor = false;
            button_edit.Click += button_edit_Click;
            // 
            // button_delete
            // 
            button_delete.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            button_delete.BackColor = Color.IndianRed;
            button_delete.Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_delete.ForeColor = SystemColors.ButtonHighlight;
            button_delete.Location = new Point(826, 15);
            button_delete.Margin = new Padding(4, 4, 4, 4);
            button_delete.Name = "button_delete";
            button_delete.Size = new Size(60, 49);
            button_delete.TabIndex = 5;
            button_delete.Text = "🗑️";
            button_delete.UseVisualStyleBackColor = false;
            button_delete.Click += button_delete_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(textBox_search);
            panel2.Controls.Add(button_delete);
            panel2.Controls.Add(button_add);
            panel2.Controls.Add(button_edit);
            panel2.Location = new Point(260, 100);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(909, 91);
            panel2.TabIndex = 6;
            // 
            // textBox_search
            // 
            textBox_search.Location = new Point(17, 22);
            textBox_search.Margin = new Padding(4, 4, 4, 4);
            textBox_search.Multiline = true;
            textBox_search.Name = "textBox_search";
            textBox_search.PlaceholderText = "🔎 Search here...";
            textBox_search.Size = new Size(479, 48);
            textBox_search.TabIndex = 6;
            textBox_search.TextChanged += textBox_search_TextChanged;
            // 
            // admin_user
            // 
            AutoScaleDimensions = new SizeF(12F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1180, 612);
            Controls.Add(table_users);
            Controls.Add(panel2);
            Margin = new Padding(6, 4, 6, 4);
            Name = "admin_user";
            Text = "Admin | User";
            Load += admin_user_Load;
            Controls.SetChildIndex(panel2, 0);
            Controls.SetChildIndex(table_users, 0);
            ((System.ComponentModel.ISupportInitialize)table_users).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button_add;
        private DataGridView table_users;
        private Button button_edit;
        private Button button_delete;
        private Panel panel2;
        private TextBox textBox_search;
    }
}