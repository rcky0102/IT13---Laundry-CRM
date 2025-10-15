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
            label9 = new Label();
            label3 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label2 = new Label();
            label1 = new Label();
            label5 = new Label();
            label4 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // textbox_username
            // 
            textbox_username.BackColor = SystemColors.ButtonFace;
            textbox_username.BorderStyle = BorderStyle.None;
            textbox_username.Font = new Font("Gadugi", 8F);
            textbox_username.Location = new Point(29, 48);
            textbox_username.Multiline = true;
            textbox_username.Name = "textbox_username";
            textbox_username.PlaceholderText = "(e.g. John123)";
            textbox_username.Size = new Size(300, 40);
            textbox_username.TabIndex = 0;
            // 
            // textbox_password
            // 
            textbox_password.BackColor = SystemColors.ButtonFace;
            textbox_password.BorderStyle = BorderStyle.None;
            textbox_password.Font = new Font("Gadugi", 8F);
            textbox_password.Location = new Point(366, 48);
            textbox_password.Multiline = true;
            textbox_password.Name = "textbox_password";
            textbox_password.PasswordChar = '*';
            textbox_password.PlaceholderText = "(At least 8 characters )";
            textbox_password.Size = new Size(300, 40);
            textbox_password.TabIndex = 1;
            // 
            // textbox_firstname
            // 
            textbox_firstname.BackColor = SystemColors.ButtonFace;
            textbox_firstname.BorderStyle = BorderStyle.None;
            textbox_firstname.Font = new Font("Gadugi", 8F);
            textbox_firstname.Location = new Point(30, 145);
            textbox_firstname.Multiline = true;
            textbox_firstname.Name = "textbox_firstname";
            textbox_firstname.PlaceholderText = "(e.g. John)";
            textbox_firstname.Size = new Size(200, 40);
            textbox_firstname.TabIndex = 2;
            // 
            // textbox_middlename
            // 
            textbox_middlename.BackColor = SystemColors.ButtonFace;
            textbox_middlename.BorderStyle = BorderStyle.None;
            textbox_middlename.Font = new Font("Gadugi", 8F);
            textbox_middlename.Location = new Point(250, 145);
            textbox_middlename.Multiline = true;
            textbox_middlename.Name = "textbox_middlename";
            textbox_middlename.PlaceholderText = "(Optional)";
            textbox_middlename.Size = new Size(200, 40);
            textbox_middlename.TabIndex = 3;
            // 
            // textbox_lastname
            // 
            textbox_lastname.BackColor = SystemColors.ButtonFace;
            textbox_lastname.BorderStyle = BorderStyle.None;
            textbox_lastname.Font = new Font("Gadugi", 8F);
            textbox_lastname.Location = new Point(466, 145);
            textbox_lastname.Multiline = true;
            textbox_lastname.Name = "textbox_lastname";
            textbox_lastname.PlaceholderText = "(e.g. Doe)";
            textbox_lastname.Size = new Size(200, 40);
            textbox_lastname.TabIndex = 4;
            // 
            // textbox_address
            // 
            textbox_address.BackColor = SystemColors.ButtonFace;
            textbox_address.BorderStyle = BorderStyle.None;
            textbox_address.Font = new Font("Gadugi", 8F);
            textbox_address.Location = new Point(28, 231);
            textbox_address.Multiline = true;
            textbox_address.Name = "textbox_address";
            textbox_address.PlaceholderText = "(e.g. Bagong Pag-asa, Sitio Awa, Catalunan Grande, Davao City.)";
            textbox_address.Size = new Size(637, 70);
            textbox_address.TabIndex = 5;
            // 
            // textbox_contact
            // 
            textbox_contact.BackColor = SystemColors.ButtonFace;
            textbox_contact.BorderStyle = BorderStyle.None;
            textbox_contact.Font = new Font("Gadugi", 8F);
            textbox_contact.Location = new Point(28, 339);
            textbox_contact.Multiline = true;
            textbox_contact.Name = "textbox_contact";
            textbox_contact.PlaceholderText = "(e.g. 09123456789)";
            textbox_contact.Size = new Size(636, 41);
            textbox_contact.TabIndex = 6;
            // 
            // combobox_role
            // 
            combobox_role.BackColor = SystemColors.ButtonFace;
            combobox_role.Font = new Font("Gadugi", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            combobox_role.FormattingEnabled = true;
            combobox_role.Location = new Point(29, 422);
            combobox_role.Name = "combobox_role";
            combobox_role.Size = new Size(272, 24);
            combobox_role.TabIndex = 7;
            // 
            // button_save
            // 
            button_save.BackColor = SystemColors.HotTrack;
            button_save.FlatAppearance.BorderSize = 0;
            button_save.FlatStyle = FlatStyle.Flat;
            button_save.Font = new Font("Gadugi", 8F);
            button_save.ForeColor = SystemColors.HighlightText;
            button_save.Location = new Point(566, 456);
            button_save.Name = "button_save";
            button_save.Size = new Size(100, 35);
            button_save.TabIndex = 8;
            button_save.Text = "Save";
            button_save.UseVisualStyleBackColor = false;
            button_save.Click += button_save_Click;
            // 
            // button_cancel
            // 
            button_cancel.BackColor = SystemColors.ButtonFace;
            button_cancel.FlatAppearance.BorderSize = 0;
            button_cancel.FlatStyle = FlatStyle.Flat;
            button_cancel.Font = new Font("Gadugi", 8F);
            button_cancel.Location = new Point(451, 456);
            button_cancel.Name = "button_cancel";
            button_cancel.Size = new Size(100, 35);
            button_cancel.TabIndex = 9;
            button_cancel.Text = "Cancel";
            button_cancel.UseVisualStyleBackColor = false;
            button_cancel.Click += button_cancel_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label5);
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
            panel1.Location = new Point(45, 74);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(700, 518);
            panel1.TabIndex = 10;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Gadugi", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.ActiveCaptionText;
            label9.Location = new Point(50, 313);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(67, 19);
            label9.TabIndex = 23;
            label9.Text = "Contact:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Gadugi", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(47, 209);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(70, 19);
            label3.TabIndex = 22;
            label3.Text = "Address:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Gadugi", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ActiveCaptionText;
            label8.Location = new Point(43, 400);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(89, 19);
            label8.TabIndex = 21;
            label8.Text = "Select Role:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Gadugi", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ActiveCaptionText;
            label7.Location = new Point(480, 123);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(88, 19);
            label7.TabIndex = 20;
            label7.Text = "Last Name:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Gadugi", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(263, 123);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(107, 19);
            label6.TabIndex = 19;
            label6.Text = "Middle Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Gadugi", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(47, 123);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(90, 19);
            label2.TabIndex = 18;
            label2.Text = "First Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gadugi", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(387, 26);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(80, 19);
            label1.TabIndex = 17;
            label1.Text = "Password:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Gadugi", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(47, 26);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(84, 19);
            label5.TabIndex = 16;
            label5.Text = "Username:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(296, -5);
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
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(782, 603);
            Controls.Add(label4);
            Controls.Add(panel1);
            Name = "admin_create_edit_user";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin | Create/Edit";
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
        private Label label4;
        private Label label5;
        private Label label1;
        private Label label2;
        private Label label6;
        private Label label8;
        private Label label7;
        private Label label3;
        private Label label9;
    }
}