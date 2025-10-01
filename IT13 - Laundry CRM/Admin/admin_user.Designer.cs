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
            ((System.ComponentModel.ISupportInitialize)table_users).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // button_add
            // 
            button_add.BackColor = SystemColors.Highlight;
            button_add.Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_add.ForeColor = SystemColors.ButtonHighlight;
            button_add.Location = new Point(18, 9);
            button_add.Margin = new Padding(4);
            button_add.Name = "button_add";
            button_add.Size = new Size(113, 36);
            button_add.TabIndex = 2;
            button_add.Text = "➕ Add";
            button_add.UseVisualStyleBackColor = false;
            button_add.Click += button_add_Click;
            // 
            // table_users
            // 
            table_users.BackgroundColor = SystemColors.ButtonHighlight;
            table_users.BorderStyle = BorderStyle.Fixed3D;
            table_users.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            table_users.GridColor = SystemColors.MenuBar;
            table_users.Location = new Point(306, 203);
            table_users.Margin = new Padding(4);
            table_users.Name = "table_users";
            table_users.RowHeadersWidth = 51;
            table_users.Size = new Size(851, 346);
            table_users.TabIndex = 3;
            // 
            // button_edit
            // 
            button_edit.BackColor = Color.LimeGreen;
            button_edit.Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_edit.ForeColor = SystemColors.ButtonHighlight;
            button_edit.Location = new Point(714, 9);
            button_edit.Margin = new Padding(4);
            button_edit.Name = "button_edit";
            button_edit.Size = new Size(48, 36);
            button_edit.TabIndex = 4;
            button_edit.Text = "✏️";
            button_edit.UseVisualStyleBackColor = false;
            button_edit.Click += button_edit_Click;
            // 
            // button_delete
            // 
            button_delete.BackColor = Color.IndianRed;
            button_delete.Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_delete.ForeColor = SystemColors.ButtonHighlight;
            button_delete.Location = new Point(770, 9);
            button_delete.Margin = new Padding(4);
            button_delete.Name = "button_delete";
            button_delete.Size = new Size(54, 36);
            button_delete.TabIndex = 5;
            button_delete.Text = "🗑️";
            button_delete.UseVisualStyleBackColor = false;
            button_delete.Click += button_delete_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(button_delete);
            panel2.Controls.Add(button_add);
            panel2.Controls.Add(button_edit);
            panel2.Location = new Point(306, 129);
            panel2.Name = "panel2";
            panel2.Size = new Size(851, 67);
            panel2.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cascadia Code SemiBold", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaption;
            label3.Location = new Point(315, 21);
            label3.Name = "label3";
            label3.Size = new Size(320, 58);
            label3.TabIndex = 7;
            label3.Text = "👤 New User";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cascadia Code", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ActiveCaption;
            label4.Location = new Point(412, 79);
            label4.Name = "label4";
            label4.Size = new Size(461, 24);
            label4.TabIndex = 8;
            label4.Text = "\"Add employee or customer details below.\"";
            // 
            // admin_user
            // 
            AutoScaleDimensions = new SizeF(12F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1181, 562);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(table_users);
            Controls.Add(panel2);
            Margin = new Padding(6, 4, 6, 4);
            Name = "admin_user";
            Text = "admin_user";
            Load += admin_user_Load;
            Controls.SetChildIndex(panel2, 0);
            Controls.SetChildIndex(table_users, 0);
            Controls.SetChildIndex(label3, 0);
            Controls.SetChildIndex(label4, 0);
            ((System.ComponentModel.ISupportInitialize)table_users).EndInit();
            panel2.ResumeLayout(false);
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
    }
}