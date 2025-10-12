namespace IT13___Laundry_CRM
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            textbox_username = new TextBox();
            textbox_password = new TextBox();
            textbox_firstname = new TextBox();
            textbox_middlename = new TextBox();
            textbox_lastname = new TextBox();
            textbox_address = new TextBox();
            textbox_contact = new TextBox();
            button_register = new Button();
            button_cancel = new Button();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // textbox_username
            // 
            textbox_username.BackColor = SystemColors.HighlightText;
            textbox_username.Font = new Font("Gadugi", 8F);
            textbox_username.Location = new Point(25, 159);
            textbox_username.Margin = new Padding(4);
            textbox_username.Multiline = true;
            textbox_username.Name = "textbox_username";
            textbox_username.PlaceholderText = "Username:";
            textbox_username.Size = new Size(343, 50);
            textbox_username.TabIndex = 0;
            // 
            // textbox_password
            // 
            textbox_password.BackColor = SystemColors.HighlightText;
            textbox_password.Font = new Font("Gadugi", 8F);
            textbox_password.Location = new Point(376, 156);
            textbox_password.Margin = new Padding(4);
            textbox_password.Multiline = true;
            textbox_password.Name = "textbox_password";
            textbox_password.PasswordChar = '*';
            textbox_password.PlaceholderText = "Password:";
            textbox_password.Size = new Size(290, 53);
            textbox_password.TabIndex = 1;
            textbox_password.TextChanged += textBox2_TextChanged;
            // 
            // textbox_firstname
            // 
            textbox_firstname.BackColor = SystemColors.HighlightText;
            textbox_firstname.Font = new Font("Gadugi", 8F);
            textbox_firstname.Location = new Point(25, 313);
            textbox_firstname.Margin = new Padding(4);
            textbox_firstname.Multiline = true;
            textbox_firstname.Name = "textbox_firstname";
            textbox_firstname.PlaceholderText = "First Name:";
            textbox_firstname.Size = new Size(215, 52);
            textbox_firstname.TabIndex = 3;
            // 
            // textbox_middlename
            // 
            textbox_middlename.BackColor = SystemColors.HighlightText;
            textbox_middlename.Font = new Font("Gadugi", 8F);
            textbox_middlename.Location = new Point(248, 313);
            textbox_middlename.Margin = new Padding(4);
            textbox_middlename.Multiline = true;
            textbox_middlename.Name = "textbox_middlename";
            textbox_middlename.PlaceholderText = "Middle Name:";
            textbox_middlename.Size = new Size(162, 52);
            textbox_middlename.TabIndex = 4;
            // 
            // textbox_lastname
            // 
            textbox_lastname.BackColor = SystemColors.HighlightText;
            textbox_lastname.Font = new Font("Gadugi", 8F);
            textbox_lastname.Location = new Point(418, 313);
            textbox_lastname.Margin = new Padding(4);
            textbox_lastname.Multiline = true;
            textbox_lastname.Name = "textbox_lastname";
            textbox_lastname.PlaceholderText = "Last Name:";
            textbox_lastname.Size = new Size(248, 52);
            textbox_lastname.TabIndex = 5;
            // 
            // textbox_address
            // 
            textbox_address.BackColor = SystemColors.HighlightText;
            textbox_address.Font = new Font("Gadugi", 8F);
            textbox_address.Location = new Point(25, 389);
            textbox_address.Margin = new Padding(4);
            textbox_address.Multiline = true;
            textbox_address.Name = "textbox_address";
            textbox_address.PlaceholderText = "Address:";
            textbox_address.Size = new Size(641, 52);
            textbox_address.TabIndex = 6;
            // 
            // textbox_contact
            // 
            textbox_contact.BackColor = SystemColors.HighlightText;
            textbox_contact.Font = new Font("Gadugi", 8F);
            textbox_contact.Location = new Point(25, 462);
            textbox_contact.Margin = new Padding(4);
            textbox_contact.Multiline = true;
            textbox_contact.Name = "textbox_contact";
            textbox_contact.PlaceholderText = "Contact:";
            textbox_contact.Size = new Size(641, 53);
            textbox_contact.TabIndex = 7;
            // 
            // button_register
            // 
            button_register.BackColor = Color.RoyalBlue;
            button_register.FlatAppearance.BorderSize = 0;
            button_register.Font = new Font("Gadugi", 10F);
            button_register.ForeColor = SystemColors.ButtonHighlight;
            button_register.Location = new Point(540, 612);
            button_register.Margin = new Padding(4);
            button_register.Name = "button_register";
            button_register.Size = new Size(143, 36);
            button_register.TabIndex = 9;
            button_register.Text = "Register";
            button_register.UseVisualStyleBackColor = false;
            button_register.Click += button_register_Click;
            // 
            // button_cancel
            // 
            button_cancel.FlatAppearance.BorderSize = 0;
            button_cancel.FlatStyle = FlatStyle.Flat;
            button_cancel.Font = new Font("Gadugi", 10F);
            button_cancel.Location = new Point(393, 612);
            button_cancel.Margin = new Padding(4);
            button_cancel.Name = "button_cancel";
            button_cancel.Size = new Size(118, 36);
            button_cancel.TabIndex = 10;
            button_cancel.Text = "Cancel";
            button_cancel.UseVisualStyleBackColor = true;
            button_cancel.Click += button_cancel_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveCaption;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(11, 168);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(541, 489);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ButtonHighlight;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(button_cancel);
            panel3.Controls.Add(textbox_contact);
            panel3.Controls.Add(button_register);
            panel3.Controls.Add(textbox_username);
            panel3.Controls.Add(textbox_address);
            panel3.Controls.Add(textbox_password);
            panel3.Controls.Add(textbox_lastname);
            panel3.Controls.Add(textbox_firstname);
            panel3.Controls.Add(textbox_middlename);
            panel3.Location = new Point(565, 11);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(704, 664);
            panel3.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ButtonHighlight;
            label4.Font = new Font("Gadugi", 14F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(6, 249);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(310, 34);
            label4.TabIndex = 12;
            label4.Text = "Enter Personal Details:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ButtonHighlight;
            label3.Font = new Font("Gadugi", 14F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(6, 76);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(216, 34);
            label3.TabIndex = 11;
            label3.Text = "User/Password:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gadugi", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(110, 20);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(116, 33);
            label1.TabIndex = 13;
            label1.Text = "Register";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(5, 20);
            pictureBox2.Margin = new Padding(2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(101, 89);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.BackColor = SystemColors.ActiveCaption;
            label2.Font = new Font("Gadugi", 8F);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(110, 67);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(422, 42);
            label2.TabIndex = 14;
            label2.Text = "\"Join us today and experience hassle-free laundry service!\"";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Location = new Point(5, 11);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(556, 124);
            panel1.TabIndex = 12;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1262, 673);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Margin = new Padding(4);
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegisterForm";
            Load += RegisterForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
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
        private Button button_register;
        private Button button_cancel;
        private PictureBox pictureBox1;
        private Panel panel3;
        private Label label4;
        private Label label3;
        private Label label1;
        private PictureBox pictureBox2;
        private Label label2;
        private Panel panel1;
    }
}