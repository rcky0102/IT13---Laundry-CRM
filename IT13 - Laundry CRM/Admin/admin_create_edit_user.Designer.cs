namespace IT13___Laundry_CRM.Admin
{
    partial class admin_create_edit_user
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
            textbox_username = new TextBox();
            textbox_password = new TextBox();
            textbox_firstname = new TextBox();
            textbox_middlename = new TextBox();
            textbox_lastname = new TextBox();
            textbox_address = new TextBox();
            textbox_contact = new TextBox();
            combobox_role = new ComboBox();
            button_save = new Button();
            button_cancel = new Button();
            SuspendLayout();
            // 
            // textbox_username
            // 
            textbox_username.Location = new Point(113, 52);
            textbox_username.Name = "textbox_username";
            textbox_username.PlaceholderText = "Username";
            textbox_username.Size = new Size(125, 27);
            textbox_username.TabIndex = 0;
            // 
            // textbox_password
            // 
            textbox_password.Location = new Point(113, 115);
            textbox_password.Name = "textbox_password";
            textbox_password.PasswordChar = '*';
            textbox_password.PlaceholderText = "Password";
            textbox_password.Size = new Size(125, 27);
            textbox_password.TabIndex = 1;
            // 
            // textbox_firstname
            // 
            textbox_firstname.Location = new Point(345, 59);
            textbox_firstname.Name = "textbox_firstname";
            textbox_firstname.PlaceholderText = "First Name";
            textbox_firstname.Size = new Size(125, 27);
            textbox_firstname.TabIndex = 2;
            // 
            // textbox_middlename
            // 
            textbox_middlename.Location = new Point(501, 61);
            textbox_middlename.Name = "textbox_middlename";
            textbox_middlename.PlaceholderText = "Middle Name";
            textbox_middlename.Size = new Size(125, 27);
            textbox_middlename.TabIndex = 3;
            // 
            // textbox_lastname
            // 
            textbox_lastname.Location = new Point(649, 61);
            textbox_lastname.Name = "textbox_lastname";
            textbox_lastname.PlaceholderText = "Last Name";
            textbox_lastname.Size = new Size(125, 27);
            textbox_lastname.TabIndex = 4;
            // 
            // textbox_address
            // 
            textbox_address.Location = new Point(426, 124);
            textbox_address.Name = "textbox_address";
            textbox_address.PlaceholderText = "Address";
            textbox_address.Size = new Size(125, 27);
            textbox_address.TabIndex = 5;
            // 
            // textbox_contact
            // 
            textbox_contact.Location = new Point(426, 174);
            textbox_contact.Name = "textbox_contact";
            textbox_contact.PlaceholderText = "Contact";
            textbox_contact.Size = new Size(125, 27);
            textbox_contact.TabIndex = 6;
            // 
            // combobox_role
            // 
            combobox_role.FormattingEnabled = true;
            combobox_role.Location = new Point(113, 174);
            combobox_role.Name = "combobox_role";
            combobox_role.Size = new Size(151, 28);
            combobox_role.TabIndex = 7;
            // 
            // button_save
            // 
            button_save.Location = new Point(230, 283);
            button_save.Name = "button_save";
            button_save.Size = new Size(94, 29);
            button_save.TabIndex = 8;
            button_save.Text = "Save";
            button_save.UseVisualStyleBackColor = true;
            button_save.Click += button_save_Click;
            // 
            // button_cancel
            // 
            button_cancel.Location = new Point(389, 285);
            button_cancel.Name = "button_cancel";
            button_cancel.Size = new Size(94, 29);
            button_cancel.TabIndex = 9;
            button_cancel.Text = "Cancel";
            button_cancel.UseVisualStyleBackColor = true;
            button_cancel.Click += button_cancel_Click;
            // 
            // admin_create_edit_user
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_cancel);
            Controls.Add(button_save);
            Controls.Add(combobox_role);
            Controls.Add(textbox_contact);
            Controls.Add(textbox_address);
            Controls.Add(textbox_lastname);
            Controls.Add(textbox_middlename);
            Controls.Add(textbox_firstname);
            Controls.Add(textbox_password);
            Controls.Add(textbox_username);
            Name = "admin_create_edit_user";
            Text = "admin_create_edit_user";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textbox_username;
        private TextBox textbox_password;
        private TextBox textbox_firstname;
        private TextBox textbox_middlename;
        private TextBox textbox_lastname;
        private TextBox textbox_address;
        private TextBox textbox_contact;
        private ComboBox combobox_role;
        private Button button_save;
        private Button button_cancel;
    }
}