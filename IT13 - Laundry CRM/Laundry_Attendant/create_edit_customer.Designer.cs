namespace IT13___Laundry_CRM.Laundry_Attendant
{
    partial class create_edit_customer
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
            label4 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            button_cancel = new Button();
            textbox_username = new TextBox();
            button_save = new Button();
            textbox_password = new TextBox();
            textbox_contact = new TextBox();
            textbox_address = new TextBox();
            textbox_firstname = new TextBox();
            textbox_lastname = new TextBox();
            textbox_middlename = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(321, 31);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(155, 106);
            label4.TabIndex = 13;
            label4.Text = "👤";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientInactiveCaption;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button_cancel);
            panel1.Controls.Add(textbox_username);
            panel1.Controls.Add(button_save);
            panel1.Controls.Add(textbox_password);
            panel1.Controls.Add(textbox_contact);
            panel1.Controls.Add(textbox_address);
            panel1.Controls.Add(textbox_firstname);
            panel1.Controls.Add(textbox_lastname);
            panel1.Controls.Add(textbox_middlename);
            panel1.Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.Location = new Point(43, 123);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(700, 419);
            panel1.TabIndex = 12;
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
            // button_cancel
            // 
            button_cancel.BackColor = SystemColors.ButtonFace;
            button_cancel.FlatAppearance.BorderSize = 0;
            button_cancel.FlatStyle = FlatStyle.Flat;
            button_cancel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_cancel.Location = new Point(344, 352);
            button_cancel.Name = "button_cancel";
            button_cancel.Size = new Size(100, 30);
            button_cancel.TabIndex = 9;
            button_cancel.Text = "Cancel";
            button_cancel.UseVisualStyleBackColor = false;
            button_cancel.Click += button_cancel_Click_1;
            // 
            // textbox_username
            // 
            textbox_username.Font = new Font("Cascadia Code SemiLight", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textbox_username.Location = new Point(29, 48);
            textbox_username.Multiline = true;
            textbox_username.Name = "textbox_username";
            textbox_username.PlaceholderText = "Username:";
            textbox_username.Size = new Size(300, 40);
            textbox_username.TabIndex = 0;
            // 
            // button_save
            // 
            button_save.BackColor = SystemColors.HotTrack;
            button_save.ForeColor = SystemColors.HighlightText;
            button_save.Location = new Point(235, 350);
            button_save.Name = "button_save";
            button_save.Size = new Size(100, 35);
            button_save.TabIndex = 8;
            button_save.Text = "Save";
            button_save.UseVisualStyleBackColor = false;
            button_save.Click += button_save_Click_1;
            // 
            // textbox_password
            // 
            textbox_password.Font = new Font("Cascadia Code SemiLight", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textbox_password.Location = new Point(365, 48);
            textbox_password.Multiline = true;
            textbox_password.Name = "textbox_password";
            textbox_password.PasswordChar = '*';
            textbox_password.PlaceholderText = "Password:";
            textbox_password.Size = new Size(300, 40);
            textbox_password.TabIndex = 1;
            textbox_password.TextChanged += textbox_password_TextChanged;
            // 
            // textbox_contact
            // 
            textbox_contact.Font = new Font("Cascadia Code SemiLight", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textbox_contact.Location = new Point(29, 274);
            textbox_contact.Multiline = true;
            textbox_contact.Name = "textbox_contact";
            textbox_contact.PlaceholderText = "Contact:";
            textbox_contact.Size = new Size(636, 40);
            textbox_contact.TabIndex = 6;
            textbox_contact.TextChanged += textbox_contact_TextChanged;
            // 
            // textbox_address
            // 
            textbox_address.Font = new Font("Cascadia Code SemiLight", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textbox_address.Location = new Point(29, 183);
            textbox_address.Multiline = true;
            textbox_address.Name = "textbox_address";
            textbox_address.PlaceholderText = "Address:";
            textbox_address.Size = new Size(636, 70);
            textbox_address.TabIndex = 5;
            // 
            // textbox_firstname
            // 
            textbox_firstname.Font = new Font("Cascadia Code SemiLight", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textbox_firstname.Location = new Point(29, 132);
            textbox_firstname.Multiline = true;
            textbox_firstname.Name = "textbox_firstname";
            textbox_firstname.PlaceholderText = "First Name:";
            textbox_firstname.Size = new Size(200, 40);
            textbox_firstname.TabIndex = 2;
            // 
            // textbox_lastname
            // 
            textbox_lastname.Font = new Font("Cascadia Code SemiLight", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textbox_lastname.Location = new Point(465, 132);
            textbox_lastname.Multiline = true;
            textbox_lastname.Name = "textbox_lastname";
            textbox_lastname.PlaceholderText = "Last Name:";
            textbox_lastname.Size = new Size(200, 40);
            textbox_lastname.TabIndex = 4;
            // 
            // textbox_middlename
            // 
            textbox_middlename.Font = new Font("Cascadia Code SemiLight", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textbox_middlename.Location = new Point(244, 132);
            textbox_middlename.Multiline = true;
            textbox_middlename.Name = "textbox_middlename";
            textbox_middlename.PlaceholderText = "Middle Name:";
            textbox_middlename.Size = new Size(200, 40);
            textbox_middlename.TabIndex = 3;
            // 
            // create_edit_customer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(782, 603);
            Controls.Add(label4);
            Controls.Add(panel1);
            Name = "create_edit_customer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Laundry Attendant | Create/Edit Customer";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Panel panel1;
        private Label label2;
        private Label label1;
        private Button button_cancel;
        private TextBox textbox_username;
        private Button button_save;
        private TextBox textbox_password;
        private TextBox textbox_contact;
        private TextBox textbox_address;
        private TextBox textbox_firstname;
        private TextBox textbox_lastname;
        private TextBox textbox_middlename;
    }
}