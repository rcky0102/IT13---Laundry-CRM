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
            label3 = new Label();
            label4 = new Label();
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
            button_add.Location = new Point(15, 7);
            button_add.Name = "button_add";
            button_add.Size = new Size(38, 29);
            button_add.TabIndex = 2;
            button_add.Text = "➕";
            button_add.UseVisualStyleBackColor = false;
            button_add.Click += button_add_Click;
            // 
            // table_users
            // 
            table_users.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            table_users.BackgroundColor = SystemColors.ButtonHighlight;
            table_users.BorderStyle = BorderStyle.Fixed3D;
            table_users.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            table_users.GridColor = SystemColors.MenuBar;
            table_users.Location = new Point(206, 229);
            table_users.Name = "table_users";
            table_users.RowHeadersWidth = 51;
            table_users.Size = new Size(767, 260);
            table_users.TabIndex = 3;
            // 
            // button_edit
            // 
            button_edit.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            button_edit.BackColor = Color.LimeGreen;
            button_edit.Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_edit.ForeColor = SystemColors.ButtonHighlight;
            button_edit.Location = new Point(653, 7);
            button_edit.Name = "button_edit";
            button_edit.Size = new Size(40, 29);
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
            button_delete.Location = new Point(700, 7);
            button_delete.Name = "button_delete";
            button_delete.Size = new Size(45, 29);
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
            panel2.Location = new Point(206, 169);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(768, 55);
            panel2.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cascadia Code SemiBold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(223, 82);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(196, 35);
            label3.TabIndex = 7;
            label3.Text = "👤 New User";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cascadia Code SemiLight", 8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(282, 117);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(336, 18);
            label4.TabIndex = 8;
            label4.Text = "\"Add employee or customer details below.\"";
            // 
            // textBox_search
            // 
            textBox_search.Location = new Point(411, 9);
            textBox_search.Name = "textBox_search";
            textBox_search.Size = new Size(213, 27);
            textBox_search.TabIndex = 6;
            textBox_search.TextChanged += textBox_search_TextChanged;
            // 
            // admin_user
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(983, 499);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(table_users);
            Controls.Add(panel2);
            Margin = new Padding(5, 3, 5, 3);
            Name = "admin_user";
            Text = "admin_user";
            Load += admin_user_Load;
            Controls.SetChildIndex(panel2, 0);
            Controls.SetChildIndex(table_users, 0);
            Controls.SetChildIndex(label3, 0);
            Controls.SetChildIndex(label4, 0);
            ((System.ComponentModel.ISupportInitialize)table_users).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_add;
        private DataGridView table_users;
        private Button button_edit;
        private Button button_delete;
        private Panel panel2;
        private Label label3;
        private Label label4;
        private TextBox textBox_search;
    }
}