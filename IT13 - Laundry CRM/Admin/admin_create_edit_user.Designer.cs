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
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // textbox_username
            // 
            textbox_username.Font = new Font("Cascadia Code SemiLight", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textbox_username.Location = new Point(29, 48);
            textbox_username.Multiline = true;
            textbox_username.Name = "textbox_username";
            textbox_username.PlaceholderText = "Username:";
            textbox_username.Size = new Size(187, 33);
            textbox_username.TabIndex = 0;
            // 
            // textbox_password
            // 
            textbox_password.Font = new Font("Cascadia Code SemiLight", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textbox_password.Location = new Point(225, 48);
            textbox_password.Multiline = true;
            textbox_password.Name = "textbox_password";
            textbox_password.PasswordChar = '*';
            textbox_password.PlaceholderText = "Password:";
            textbox_password.Size = new Size(207, 33);
            textbox_password.TabIndex = 1;
            // 
            // textbox_firstname
            // 
            textbox_firstname.Font = new Font("Cascadia Code SemiLight", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textbox_firstname.Location = new Point(29, 132);
            textbox_firstname.Multiline = true;
            textbox_firstname.Name = "textbox_firstname";
            textbox_firstname.PlaceholderText = "First Name:";
            textbox_firstname.Size = new Size(138, 36);
            textbox_firstname.TabIndex = 2;
            // 
            // textbox_middlename
            // 
            textbox_middlename.Font = new Font("Cascadia Code SemiLight", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textbox_middlename.Location = new Point(173, 132);
            textbox_middlename.Multiline = true;
            textbox_middlename.Name = "textbox_middlename";
            textbox_middlename.PlaceholderText = "Middle Name:";
            textbox_middlename.Size = new Size(111, 36);
            textbox_middlename.TabIndex = 3;
            // 
            // textbox_lastname
            // 
            textbox_lastname.Font = new Font("Cascadia Code SemiLight", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textbox_lastname.Location = new Point(295, 132);
            textbox_lastname.Multiline = true;
            textbox_lastname.Name = "textbox_lastname";
            textbox_lastname.PlaceholderText = "Last Name:";
            textbox_lastname.Size = new Size(137, 36);
            textbox_lastname.TabIndex = 4;
            // 
            // textbox_address
            // 
            textbox_address.Font = new Font("Cascadia Code SemiLight", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textbox_address.Location = new Point(29, 183);
            textbox_address.Multiline = true;
            textbox_address.Name = "textbox_address";
            textbox_address.PlaceholderText = "Address:";
            textbox_address.Size = new Size(403, 39);
            textbox_address.TabIndex = 5;
            // 
            // textbox_contact
            // 
            textbox_contact.Font = new Font("Cascadia Code SemiLight", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textbox_contact.Location = new Point(29, 238);
            textbox_contact.Multiline = true;
            textbox_contact.Name = "textbox_contact";
            textbox_contact.PlaceholderText = "Contact:";
            textbox_contact.Size = new Size(403, 41);
            textbox_contact.TabIndex = 6;
            // 
            // combobox_role
            // 
            combobox_role.FormattingEnabled = true;
            combobox_role.Location = new Point(29, 310);
            combobox_role.Name = "combobox_role";
            combobox_role.Size = new Size(151, 28);
            combobox_role.TabIndex = 7;
            // 
            // button_save
            // 
            button_save.BackColor = SystemColors.HotTrack;
            button_save.ForeColor = SystemColors.HighlightText;
            button_save.Location = new Point(275, 381);
            button_save.Name = "button_save";
            button_save.Size = new Size(94, 29);
            button_save.TabIndex = 8;
            button_save.Text = "Save";
            button_save.UseVisualStyleBackColor = false;
            button_save.Click += button_save_Click;
            // 
            // button_cancel
            // 
            button_cancel.FlatAppearance.BorderSize = 0;
            button_cancel.FlatStyle = FlatStyle.Flat;
            button_cancel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_cancel.Location = new Point(376, 381);
            button_cancel.Name = "button_cancel";
            button_cancel.Size = new Size(94, 29);
            button_cancel.TabIndex = 9;
            button_cancel.Text = "Cancel";
            button_cancel.UseVisualStyleBackColor = true;
            button_cancel.Click += button_cancel_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button_cancel);
            panel1.Controls.Add(textbox_username);
            panel1.Controls.Add(button_save);
            panel1.Controls.Add(textbox_password);
            panel1.Controls.Add(textbox_contact);
            panel1.Controls.Add(combobox_role);
            panel1.Controls.Add(textbox_address);
            panel1.Controls.Add(textbox_firstname);
            panel1.Controls.Add(textbox_lastname);
            panel1.Controls.Add(textbox_middlename);
            panel1.Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.Location = new Point(178, 113);
            panel1.Margin = new Padding(2, 2, 2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(472, 445);
            panel1.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cascadia Code SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaption;
            label3.Location = new Point(2, 282);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(156, 27);
            label3.TabIndex = 12;
            label3.Text = "Select Role:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cascadia Code SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaption;
            label2.Location = new Point(2, 103);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(264, 27);
            label2.TabIndex = 11;
            label2.Text = "Personal Information:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Code SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaption;
            label1.Location = new Point(2, 14);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(228, 27);
            label1.TabIndex = 10;
            label1.Text = "login credentials:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(333, 5);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(155, 106);
            label4.TabIndex = 11;
            label4.Text = "👤";
            // 
            // admin_create_edit_user
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(803, 567);
            Controls.Add(label4);
            Controls.Add(panel1);
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
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}