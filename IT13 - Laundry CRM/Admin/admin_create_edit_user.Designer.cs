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
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // textbox_username
            // 
            textbox_username.Location = new Point(234, 53);
            textbox_username.Margin = new Padding(4);
            textbox_username.Name = "textbox_username";
            textbox_username.PlaceholderText = "Username";
            textbox_username.Size = new Size(155, 31);
            textbox_username.TabIndex = 0;
            // 
            // textbox_password
            // 
            textbox_password.Location = new Point(622, 55);
            textbox_password.Margin = new Padding(4);
            textbox_password.Name = "textbox_password";
            textbox_password.PasswordChar = '*';
            textbox_password.PlaceholderText = "Password";
            textbox_password.Size = new Size(155, 31);
            textbox_password.TabIndex = 1;
            // 
            // textbox_firstname
            // 
            textbox_firstname.Location = new Point(459, 109);
            textbox_firstname.Margin = new Padding(4);
            textbox_firstname.Name = "textbox_firstname";
            textbox_firstname.PlaceholderText = "First Name";
            textbox_firstname.Size = new Size(155, 31);
            textbox_firstname.TabIndex = 2;
            // 
            // textbox_middlename
            // 
            textbox_middlename.Location = new Point(622, 109);
            textbox_middlename.Margin = new Padding(4);
            textbox_middlename.Name = "textbox_middlename";
            textbox_middlename.PlaceholderText = "Middle Name";
            textbox_middlename.Size = new Size(155, 31);
            textbox_middlename.TabIndex = 3;
            // 
            // textbox_lastname
            // 
            textbox_lastname.Location = new Point(785, 109);
            textbox_lastname.Margin = new Padding(4);
            textbox_lastname.Name = "textbox_lastname";
            textbox_lastname.PlaceholderText = "Last Name";
            textbox_lastname.Size = new Size(155, 31);
            textbox_lastname.TabIndex = 4;
            // 
            // textbox_address
            // 
            textbox_address.Location = new Point(574, 242);
            textbox_address.Margin = new Padding(4);
            textbox_address.Name = "textbox_address";
            textbox_address.PlaceholderText = "Address";
            textbox_address.Size = new Size(155, 31);
            textbox_address.TabIndex = 5;
            // 
            // textbox_contact
            // 
            textbox_contact.Location = new Point(574, 305);
            textbox_contact.Margin = new Padding(4);
            textbox_contact.Name = "textbox_contact";
            textbox_contact.PlaceholderText = "Contact";
            textbox_contact.Size = new Size(155, 31);
            textbox_contact.TabIndex = 6;
            // 
            // combobox_role
            // 
            combobox_role.FormattingEnabled = true;
            combobox_role.Location = new Point(785, 55);
            combobox_role.Margin = new Padding(4);
            combobox_role.Name = "combobox_role";
            combobox_role.Size = new Size(188, 33);
            combobox_role.TabIndex = 7;
            // 
            // button_save
            // 
            button_save.Location = new Point(330, 441);
            button_save.Margin = new Padding(4);
            button_save.Name = "button_save";
            button_save.Size = new Size(118, 36);
            button_save.TabIndex = 8;
            button_save.Text = "Save";
            button_save.UseVisualStyleBackColor = true;
            button_save.Click += button_save_Click;
            // 
            // button_cancel
            // 
            button_cancel.Location = new Point(528, 443);
            button_cancel.Margin = new Padding(4);
            button_cancel.Name = "button_cancel";
            button_cancel.Size = new Size(118, 36);
            button_cancel.TabIndex = 9;
            button_cancel.Text = "Cancel";
            button_cancel.UseVisualStyleBackColor = true;
            button_cancel.Click += button_cancel_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(textbox_username);
            panel1.Location = new Point(40, 83);
            panel1.Name = "panel1";
            panel1.Size = new Size(948, 150);
            panel1.TabIndex = 10;
            // 
            // admin_create_edit_user
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1000, 562);
            Controls.Add(button_cancel);
            Controls.Add(button_save);
            Controls.Add(combobox_role);
            Controls.Add(textbox_contact);
            Controls.Add(textbox_address);
            Controls.Add(textbox_lastname);
            Controls.Add(textbox_middlename);
            Controls.Add(textbox_firstname);
            Controls.Add(textbox_password);
            Controls.Add(panel1);
            Margin = new Padding(4);
            Name = "admin_create_edit_user";
            Text = "admin_create_edit_user";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private Panel panel1;
    }
}