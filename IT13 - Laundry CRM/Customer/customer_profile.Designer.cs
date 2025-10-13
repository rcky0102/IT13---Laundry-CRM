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
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            richTextBox1 = new RichTextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // textbox_username
            // 
            textbox_username.Font = new Font("Gadugi", 9F);
            textbox_username.Location = new Point(28, 69);
            textbox_username.Margin = new Padding(4, 3, 4, 3);
            textbox_username.Multiline = true;
            textbox_username.Name = "textbox_username";
            textbox_username.PlaceholderText = "(e.g. John123)";
            textbox_username.Size = new Size(300, 40);
            textbox_username.TabIndex = 0;
            // 
            // textbox_password
            // 
            textbox_password.Font = new Font("Gadugi", 9F);
            textbox_password.Location = new Point(460, 69);
            textbox_password.Margin = new Padding(4, 3, 4, 3);
            textbox_password.Multiline = true;
            textbox_password.Name = "textbox_password";
            textbox_password.PlaceholderText = "(At least 8 characters )";
            textbox_password.Size = new Size(225, 40);
            textbox_password.TabIndex = 1;
            // 
            // textbox_firstname
            // 
            textbox_firstname.Font = new Font("Gadugi", 9F);
            textbox_firstname.Location = new Point(28, 179);
            textbox_firstname.Margin = new Padding(4, 3, 4, 3);
            textbox_firstname.Multiline = true;
            textbox_firstname.Name = "textbox_firstname";
            textbox_firstname.PlaceholderText = "First Name:";
            textbox_firstname.Size = new Size(200, 40);
            textbox_firstname.TabIndex = 2;
            // 
            // textbox_middlename
            // 
            textbox_middlename.Font = new Font("Gadugi", 9F);
            textbox_middlename.Location = new Point(243, 179);
            textbox_middlename.Margin = new Padding(4, 3, 4, 3);
            textbox_middlename.Multiline = true;
            textbox_middlename.Name = "textbox_middlename";
            textbox_middlename.PlaceholderText = "Middle Name:";
            textbox_middlename.Size = new Size(200, 40);
            textbox_middlename.TabIndex = 3;
            // 
            // textbox_lastname
            // 
            textbox_lastname.Font = new Font("Gadugi", 9F);
            textbox_lastname.Location = new Point(460, 179);
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
            textbox_address.Font = new Font("Gadugi", 9F);
            textbox_address.Location = new Point(28, 251);
            textbox_address.Margin = new Padding(4, 3, 4, 3);
            textbox_address.Multiline = true;
            textbox_address.Name = "textbox_address";
            textbox_address.PlaceholderText = "Address:";
            textbox_address.Size = new Size(632, 70);
            textbox_address.TabIndex = 6;
            // 
            // textbox_contact
            // 
            textbox_contact.Font = new Font("Gadugi", 9F);
            textbox_contact.Location = new Point(28, 360);
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
            button_save.Font = new Font("Cascadia Code", 9F);
            button_save.ForeColor = SystemColors.ControlLightLight;
            button_save.Location = new Point(228, 441);
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
            button_cancel.BackColor = SystemColors.ButtonFace;
            button_cancel.FlatAppearance.BorderSize = 0;
            button_cancel.FlatStyle = FlatStyle.Flat;
            button_cancel.Font = new Font("Cascadia Code", 9F);
            button_cancel.ForeColor = SystemColors.ActiveCaptionText;
            button_cancel.Location = new Point(360, 443);
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
            panel1.Controls.Add(richTextBox1);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
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
            panel1.Location = new Point(41, 81);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(700, 496);
            panel1.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Gadugi", 9F);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(39, 46);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(78, 19);
            label2.TabIndex = 11;
            label2.Text = "Username:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.GradientActiveCaption;
            label1.Location = new Point(316, -7);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(155, 106);
            label1.TabIndex = 11;
            label1.Text = "👤";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Gadugi", 9F);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(474, 46);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(74, 19);
            label4.TabIndex = 13;
            label4.Text = "Password:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Gadugi", 9F);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(39, 157);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(78, 19);
            label3.TabIndex = 14;
            label3.Text = "Username:";
            label3.Click += label3_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Gadugi", 9F);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(260, 157);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(78, 19);
            label5.TabIndex = 15;
            label5.Text = "Username:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Gadugi", 9F);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(470, 157);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(78, 19);
            label6.TabIndex = 16;
            label6.Text = "Username:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Gadugi", 9F);
            label7.ForeColor = SystemColors.ActiveCaptionText;
            label7.Location = new Point(48, 222);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(78, 19);
            label7.TabIndex = 17;
            label7.Text = "Username:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Gadugi", 9F);
            label8.ForeColor = SystemColors.ActiveCaptionText;
            label8.Location = new Point(39, 349);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(78, 19);
            label8.TabIndex = 18;
            label8.Text = "Username:";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(204, 69);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(186, 53);
            richTextBox1.TabIndex = 19;
            richTextBox1.Text = "";
            // 
            // customer_profile
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(782, 603);
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
        private Label label4;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label3;
        private RichTextBox richTextBox1;
    }
}