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
            panel1 = new Panel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // textbox_username
            // 
            textbox_username.Location = new Point(28, 69);
            textbox_username.Margin = new Padding(4, 3, 4, 3);
            textbox_username.Multiline = true;
            textbox_username.Name = "textbox_username";
            textbox_username.PlaceholderText = "User Name:";
            textbox_username.Size = new Size(300, 40);
            textbox_username.TabIndex = 0;
            // 
            // textbox_password
            // 
            textbox_password.Location = new Point(360, 69);
            textbox_password.Margin = new Padding(4, 3, 4, 3);
            textbox_password.Multiline = true;
            textbox_password.Name = "textbox_password";
            textbox_password.PlaceholderText = "Password:";
            textbox_password.Size = new Size(300, 40);
            textbox_password.TabIndex = 1;
            // 
            // textbox_firstname
            // 
            textbox_firstname.Location = new Point(28, 195);
            textbox_firstname.Margin = new Padding(4, 3, 4, 3);
            textbox_firstname.Multiline = true;
            textbox_firstname.Name = "textbox_firstname";
            textbox_firstname.PlaceholderText = "First Name:";
            textbox_firstname.Size = new Size(200, 40);
            textbox_firstname.TabIndex = 2;
            // 
            // textbox_middlename
            // 
            textbox_middlename.Location = new Point(243, 195);
            textbox_middlename.Margin = new Padding(4, 3, 4, 3);
            textbox_middlename.Multiline = true;
            textbox_middlename.Name = "textbox_middlename";
            textbox_middlename.PlaceholderText = "Middle Name:";
            textbox_middlename.Size = new Size(200, 40);
            textbox_middlename.TabIndex = 3;
            // 
            // textbox_lastname
            // 
            textbox_lastname.Location = new Point(460, 195);
            textbox_lastname.Margin = new Padding(4, 3, 4, 3);
            textbox_lastname.Multiline = true;
            textbox_lastname.Name = "textbox_lastname";
            textbox_lastname.PlaceholderText = "Last Name:";
            textbox_lastname.Size = new Size(200, 40);
            textbox_lastname.TabIndex = 4;
            textbox_lastname.TextChanged += textbox_lastname_TextChanged;
            // 
            // textbox_address
            // 
            textbox_address.Location = new Point(28, 257);
            textbox_address.Margin = new Padding(4, 3, 4, 3);
            textbox_address.Multiline = true;
            textbox_address.Name = "textbox_address";
            textbox_address.PlaceholderText = "Address:";
            textbox_address.Size = new Size(632, 70);
            textbox_address.TabIndex = 6;
            textbox_address.TextChanged += textbox_address_TextChanged;
            // 
            // textbox_contact
            // 
            textbox_contact.Location = new Point(28, 344);
            textbox_contact.Margin = new Padding(4, 3, 4, 3);
            textbox_contact.Multiline = true;
            textbox_contact.Name = "textbox_contact";
            textbox_contact.PlaceholderText = "Contact:";
            textbox_contact.Size = new Size(632, 40);
            textbox_contact.TabIndex = 7;
            // 
            // button_save
            // 
            button_save.BackColor = SystemColors.HotTrack;
            button_save.Font = new Font("Gadugi", 9F);
            button_save.ForeColor = SystemColors.ControlLightLight;
            button_save.Location = new Point(574, 460);
            button_save.Margin = new Padding(4, 3, 4, 3);
            button_save.Name = "button_save";
            button_save.Size = new Size(100, 35);
            button_save.TabIndex = 8;
            button_save.Text = "Save";
            button_save.UseVisualStyleBackColor = false;
            button_save.Click += button_save_Click;
            // 
            // button_cancel
            // 
            button_cancel.BackColor = SystemColors.GradientInactiveCaption;
            button_cancel.FlatAppearance.BorderSize = 0;
            button_cancel.FlatStyle = FlatStyle.Flat;
            button_cancel.Font = new Font("Gadugi", 9F);
            button_cancel.ForeColor = SystemColors.ActiveCaptionText;
            button_cancel.Location = new Point(466, 465);
            button_cancel.Margin = new Padding(4, 3, 4, 3);
            button_cancel.Name = "button_cancel";
            button_cancel.Size = new Size(100, 30);
            button_cancel.TabIndex = 9;
            button_cancel.Text = "Cancel";
            button_cancel.UseVisualStyleBackColor = false;
            button_cancel.Click += button_cancel_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = SystemColors.GradientInactiveCaption;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(button_cancel);
            panel1.Controls.Add(button_save);
            panel1.Controls.Add(textbox_username);
            panel1.Controls.Add(textbox_password);
            panel1.Controls.Add(textbox_firstname);
            panel1.Controls.Add(textbox_contact);
            panel1.Controls.Add(textbox_middlename);
            panel1.Controls.Add(textbox_address);
            panel1.Controls.Add(textbox_lastname);
            panel1.Font = new Font("Cascadia Code SemiLight", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.Location = new Point(28, 152);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(687, 511);
            panel1.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Gadugi", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(14, 144);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(218, 26);
            label3.TabIndex = 12;
            label3.Text = "Personal Information:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Gadugi", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(14, 21);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(175, 26);
            label2.TabIndex = 11;
            label2.Text = "login credentials:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(273, 9);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(186, 128);
            label1.TabIndex = 11;
            label1.Text = "👤";
            // 
            // customer_profile
            // 
            AutoScaleDimensions = new SizeF(12F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(737, 714);
            Controls.Add(label1);
            Controls.Add(panel1);
            Font = new Font("Cascadia Code", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "customer_profile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "customer_profile";
            Load += customer_profile_Load;
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
        private Button button_save;
        private Button button_cancel;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}