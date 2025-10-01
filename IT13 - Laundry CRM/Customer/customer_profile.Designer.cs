namespace IT13___Laundry_CRM.Customer
{
    partial class customer_profile
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
            button_save = new Button();
            button_cancel = new Button();
            SuspendLayout();
            // 
            // textbox_username
            // 
            textbox_username.Location = new Point(286, 61);
            textbox_username.Name = "textbox_username";
            textbox_username.Size = new Size(195, 27);
            textbox_username.TabIndex = 0;
            // 
            // textbox_password
            // 
            textbox_password.Location = new Point(286, 105);
            textbox_password.Name = "textbox_password";
            textbox_password.Size = new Size(195, 27);
            textbox_password.TabIndex = 1;
            // 
            // textbox_firstname
            // 
            textbox_firstname.Location = new Point(72, 173);
            textbox_firstname.Name = "textbox_firstname";
            textbox_firstname.Size = new Size(195, 27);
            textbox_firstname.TabIndex = 2;
            // 
            // textbox_middlename
            // 
            textbox_middlename.Location = new Point(286, 173);
            textbox_middlename.Name = "textbox_middlename";
            textbox_middlename.Size = new Size(192, 27);
            textbox_middlename.TabIndex = 3;
            // 
            // textbox_lastname
            // 
            textbox_lastname.Location = new Point(494, 173);
            textbox_lastname.Name = "textbox_lastname";
            textbox_lastname.Size = new Size(163, 27);
            textbox_lastname.TabIndex = 4;
            textbox_lastname.TextChanged += textbox_lastname_TextChanged;
            // 
            // textbox_address
            // 
            textbox_address.Location = new Point(286, 234);
            textbox_address.Name = "textbox_address";
            textbox_address.Size = new Size(195, 27);
            textbox_address.TabIndex = 6;
            // 
            // textbox_contact
            // 
            textbox_contact.Location = new Point(286, 289);
            textbox_contact.Name = "textbox_contact";
            textbox_contact.Size = new Size(195, 27);
            textbox_contact.TabIndex = 7;
            // 
            // button_save
            // 
            button_save.Location = new Point(272, 361);
            button_save.Name = "button_save";
            button_save.Size = new Size(94, 29);
            button_save.TabIndex = 8;
            button_save.Text = "Save";
            button_save.UseVisualStyleBackColor = true;
            button_save.Click += button_save_Click;
            // 
            // button_cancel
            // 
            button_cancel.Location = new Point(387, 361);
            button_cancel.Name = "button_cancel";
            button_cancel.Size = new Size(94, 29);
            button_cancel.TabIndex = 9;
            button_cancel.Text = "Cancel";
            button_cancel.UseVisualStyleBackColor = true;
            button_cancel.Click += button_cancel_Click;
            // 
            // customer_profile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_cancel);
            Controls.Add(button_save);
            Controls.Add(textbox_contact);
            Controls.Add(textbox_address);
            Controls.Add(textbox_lastname);
            Controls.Add(textbox_middlename);
            Controls.Add(textbox_firstname);
            Controls.Add(textbox_password);
            Controls.Add(textbox_username);
            Name = "customer_profile";
            Text = "customer_profile";
            Load += customer_profile_Load;
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
        private Button button_save;
        private Button button_cancel;
    }
}