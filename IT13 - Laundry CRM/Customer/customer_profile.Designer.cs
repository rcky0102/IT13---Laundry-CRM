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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // textbox_username
            // 
            textbox_username.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textbox_username.Location = new Point(67, 30);
            textbox_username.Margin = new Padding(4, 4, 4, 4);
            textbox_username.Multiline = true;
            textbox_username.Name = "textbox_username";
            textbox_username.PlaceholderText = "User Name:";
            textbox_username.Size = new Size(243, 39);
            textbox_username.TabIndex = 0;
            // 
            // textbox_password
            // 
            textbox_password.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textbox_password.Location = new Point(67, 77);
            textbox_password.Margin = new Padding(4, 4, 4, 4);
            textbox_password.Multiline = true;
            textbox_password.Name = "textbox_password";
            textbox_password.PlaceholderText = "Password:";
            textbox_password.Size = new Size(243, 37);
            textbox_password.TabIndex = 1;
            // 
            // textbox_firstname
            // 
            textbox_firstname.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textbox_firstname.Location = new Point(67, 152);
            textbox_firstname.Margin = new Padding(4, 4, 4, 4);
            textbox_firstname.Multiline = true;
            textbox_firstname.Name = "textbox_firstname";
            textbox_firstname.PlaceholderText = "First Name:";
            textbox_firstname.Size = new Size(243, 40);
            textbox_firstname.TabIndex = 2;
            // 
            // textbox_middlename
            // 
            textbox_middlename.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textbox_middlename.Location = new Point(67, 200);
            textbox_middlename.Margin = new Padding(4, 4, 4, 4);
            textbox_middlename.Multiline = true;
            textbox_middlename.Name = "textbox_middlename";
            textbox_middlename.PlaceholderText = "Middle Name:";
            textbox_middlename.Size = new Size(239, 41);
            textbox_middlename.TabIndex = 3;
            // 
            // textbox_lastname
            // 
            textbox_lastname.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textbox_lastname.Location = new Point(67, 249);
            textbox_lastname.Margin = new Padding(4, 4, 4, 4);
            textbox_lastname.Multiline = true;
            textbox_lastname.Name = "textbox_lastname";
            textbox_lastname.PlaceholderText = "Last Name:";
            textbox_lastname.Size = new Size(239, 41);
            textbox_lastname.TabIndex = 4;
            textbox_lastname.TextChanged += textbox_lastname_TextChanged;
            // 
            // textbox_address
            // 
            textbox_address.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textbox_address.Location = new Point(67, 323);
            textbox_address.Margin = new Padding(4, 4, 4, 4);
            textbox_address.Multiline = true;
            textbox_address.Name = "textbox_address";
            textbox_address.PlaceholderText = "Address:";
            textbox_address.Size = new Size(243, 35);
            textbox_address.TabIndex = 6;
            // 
            // textbox_contact
            // 
            textbox_contact.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textbox_contact.Location = new Point(67, 366);
            textbox_contact.Margin = new Padding(4, 4, 4, 4);
            textbox_contact.Multiline = true;
            textbox_contact.Name = "textbox_contact";
            textbox_contact.PlaceholderText = "Contact:";
            textbox_contact.Size = new Size(243, 35);
            textbox_contact.TabIndex = 7;
            // 
            // button_save
            // 
            button_save.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            button_save.BackColor = SystemColors.HotTrack;
            button_save.Font = new Font("Cascadia Code", 9F);
            button_save.ForeColor = SystemColors.ControlLightLight;
            button_save.Location = new Point(122, 419);
            button_save.Margin = new Padding(4, 4, 4, 4);
            button_save.Name = "button_save";
            button_save.Size = new Size(118, 36);
            button_save.TabIndex = 8;
            button_save.Text = "Save";
            button_save.UseVisualStyleBackColor = false;
            button_save.Click += button_save_Click;
            // 
            // button_cancel
            // 
            button_cancel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            button_cancel.FlatAppearance.BorderSize = 0;
            button_cancel.FlatStyle = FlatStyle.Flat;
            button_cancel.Font = new Font("Cascadia Code", 9F);
            button_cancel.ForeColor = SystemColors.ActiveCaptionText;
            button_cancel.Location = new Point(238, 419);
            button_cancel.Margin = new Padding(4, 4, 4, 4);
            button_cancel.Name = "button_cancel";
            button_cancel.Size = new Size(118, 36);
            button_cancel.TabIndex = 9;
            button_cancel.Text = "Cancel";
            button_cancel.UseVisualStyleBackColor = true;
            button_cancel.Click += button_cancel_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(button_cancel);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(button_save);
            panel1.Controls.Add(textbox_username);
            panel1.Controls.Add(textbox_password);
            panel1.Controls.Add(textbox_firstname);
            panel1.Controls.Add(textbox_contact);
            panel1.Controls.Add(textbox_middlename);
            panel1.Controls.Add(textbox_address);
            panel1.Controls.Add(textbox_lastname);
            panel1.Font = new Font("Cascadia Code SemiLight", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.Location = new Point(51, 110);
            panel1.Name = "panel1";
            panel1.Size = new Size(375, 463);
            panel1.TabIndex = 10;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(134, -11);
            label1.Name = "label1";
            label1.Size = new Size(186, 128);
            label1.TabIndex = 11;
            label1.Text = "👤";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(3, 5);
            label2.Name = "label2";
            label2.Size = new Size(136, 21);
            label2.TabIndex = 8;
            label2.Text = "User/Password:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(3, 127);
            label3.Name = "label3";
            label3.Size = new Size(55, 21);
            label3.TabIndex = 9;
            label3.Text = "Name:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(3, 298);
            label4.Name = "label4";
            label4.Size = new Size(82, 21);
            label4.TabIndex = 10;
            label4.Text = "contact:";
            // 
            // customer_profile
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(474, 602);
            Controls.Add(label1);
            Controls.Add(panel1);
            Margin = new Padding(4, 4, 4, 4);
            Name = "customer_profile";
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
        private Label label2;
        private Label label1;
        private Label label4;
        private Label label3;
    }
}