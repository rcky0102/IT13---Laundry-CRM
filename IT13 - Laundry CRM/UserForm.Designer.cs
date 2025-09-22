namespace IT13___Laundry_CRM
{
    partial class UserForm
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
            button_add_user = new Button();
            button_update_user = new Button();
            button_delete_user = new Button();
            table_users = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)table_users).BeginInit();
            SuspendLayout();
            // 
            // button_add_user
            // 
            button_add_user.Location = new Point(280, 100);
            button_add_user.Name = "button_add_user";
            button_add_user.Size = new Size(94, 29);
            button_add_user.TabIndex = 1;
            button_add_user.Text = "Add";
            button_add_user.UseVisualStyleBackColor = true;
            button_add_user.Click += button_add_user_Click;
            // 
            // button_update_user
            // 
            button_update_user.Location = new Point(476, 130);
            button_update_user.Name = "button_update_user";
            button_update_user.Size = new Size(94, 29);
            button_update_user.TabIndex = 2;
            button_update_user.Text = "Edit";
            button_update_user.UseVisualStyleBackColor = true;
            button_update_user.Click += button_update_user_Click;
            // 
            // button_delete_user
            // 
            button_delete_user.Location = new Point(663, 130);
            button_delete_user.Name = "button_delete_user";
            button_delete_user.Size = new Size(94, 29);
            button_delete_user.TabIndex = 3;
            button_delete_user.Text = "Delete";
            button_delete_user.UseVisualStyleBackColor = true;
            button_delete_user.Click += button_delete_user_Click;
            // 
            // table_users
            // 
            table_users.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            table_users.Location = new Point(252, 206);
            table_users.Name = "table_users";
            table_users.RowHeadersWidth = 51;
            table_users.Size = new Size(494, 188);
            table_users.TabIndex = 4;
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(table_users);
            Controls.Add(button_delete_user);
            Controls.Add(button_update_user);
            Controls.Add(button_add_user);
            Name = "UserForm";
            Text = "UserForm";
            Load += UserForm_Load;
            Controls.SetChildIndex(button_add_user, 0);
            Controls.SetChildIndex(button_update_user, 0);
            Controls.SetChildIndex(button_delete_user, 0);
            Controls.SetChildIndex(table_users, 0);
            ((System.ComponentModel.ISupportInitialize)table_users).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button_add_user;
        private Button button_update_user;
        private Button button_delete_user;
        private DataGridView table_users;
    }
}