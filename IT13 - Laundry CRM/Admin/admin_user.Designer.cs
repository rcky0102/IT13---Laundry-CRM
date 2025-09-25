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
            ((System.ComponentModel.ISupportInitialize)table_users).BeginInit();
            SuspendLayout();
            // 
            // button_add
            // 
            button_add.Location = new Point(463, 278);
            button_add.Name = "button_add";
            button_add.Size = new Size(94, 29);
            button_add.TabIndex = 2;
            button_add.Text = "Add";
            button_add.UseVisualStyleBackColor = true;
            button_add.Click += button_add_Click;
            // 
            // table_users
            // 
            table_users.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            table_users.Location = new Point(426, 387);
            table_users.Name = "table_users";
            table_users.RowHeadersWidth = 51;
            table_users.Size = new Size(828, 188);
            table_users.TabIndex = 3;
            // 
            // button_edit
            // 
            button_edit.Location = new Point(849, 278);
            button_edit.Name = "button_edit";
            button_edit.Size = new Size(94, 29);
            button_edit.TabIndex = 4;
            button_edit.Text = "Edit";
            button_edit.UseVisualStyleBackColor = true;
            button_edit.Click += button_edit_Click;
            // 
            // button_delete
            // 
            button_delete.Location = new Point(969, 278);
            button_delete.Name = "button_delete";
            button_delete.Size = new Size(94, 29);
            button_delete.TabIndex = 5;
            button_delete.Text = "Delete";
            button_delete.UseVisualStyleBackColor = true;
            // 
            // admin_user
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1578, 740);
            Controls.Add(button_delete);
            Controls.Add(button_edit);
            Controls.Add(table_users);
            Controls.Add(button_add);
            Margin = new Padding(5, 3, 5, 3);
            Name = "admin_user";
            Text = "admin_user";
            Load += admin_user_Load;
            Controls.SetChildIndex(button_add, 0);
            Controls.SetChildIndex(table_users, 0);
            Controls.SetChildIndex(button_edit, 0);
            Controls.SetChildIndex(button_delete, 0);
            ((System.ComponentModel.ISupportInitialize)table_users).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button_add;
        private DataGridView table_users;
        private Button button_edit;
        private Button button_delete;
    }
}