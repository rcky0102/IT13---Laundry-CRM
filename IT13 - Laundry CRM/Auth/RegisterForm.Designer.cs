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
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label5 = new Label();
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
            textbox_username.BackColor = SystemColors.ButtonFace;
            textbox_username.BorderStyle = BorderStyle.None;
            textbox_username.Font = new Font("Gadugi", 8F);
            textbox_username.Location = new Point(19, 70);
            textbox_username.Multiline = true;
            textbox_username.Name = "textbox_username";
            textbox_username.PlaceholderText = "(e.g. John123)";
            textbox_username.Size = new Size(250, 40);
            textbox_username.TabIndex = 0;
            // 
            // textbox_password
            // 
            textbox_password.BackColor = SystemColors.ButtonFace;
            textbox_password.BorderStyle = BorderStyle.None;
            textbox_password.Font = new Font("Gadugi", 8F);
            textbox_password.Location = new Point(283, 70);
            textbox_password.Multiline = true;
            textbox_password.Name = "textbox_password";
            textbox_password.PasswordChar = '*';
            textbox_password.PlaceholderText = "(At least 8 characters )";
            textbox_password.Size = new Size(250, 40);
            textbox_password.TabIndex = 1;
            textbox_password.TextChanged += textBox2_TextChanged;
            // 
            // textbox_firstname
            // 
            textbox_firstname.BackColor = SystemColors.ButtonFace;
            textbox_firstname.BorderStyle = BorderStyle.None;
            textbox_firstname.Font = new Font("Gadugi", 8F);
            textbox_firstname.Location = new Point(21, 148);
            textbox_firstname.Multiline = true;
            textbox_firstname.Name = "textbox_firstname";
            textbox_firstname.PlaceholderText = "(e.g. John)";
            textbox_firstname.Size = new Size(180, 40);
            textbox_firstname.TabIndex = 3;
            // 
            // textbox_middlename
            // 
            textbox_middlename.BackColor = SystemColors.ButtonFace;
            textbox_middlename.BorderStyle = BorderStyle.None;
            textbox_middlename.Font = new Font("Gadugi", 8F);
            textbox_middlename.Location = new Point(207, 148);
            textbox_middlename.Multiline = true;
            textbox_middlename.Name = "textbox_middlename";
            textbox_middlename.PlaceholderText = "(Optional)";
            textbox_middlename.Size = new Size(150, 40);
            textbox_middlename.TabIndex = 4;
            // 
            // textbox_lastname
            // 
            textbox_lastname.BackColor = SystemColors.ButtonFace;
            textbox_lastname.BorderStyle = BorderStyle.None;
            textbox_lastname.Font = new Font("Gadugi", 8F);
            textbox_lastname.Location = new Point(363, 148);
            textbox_lastname.Multiline = true;
            textbox_lastname.Name = "textbox_lastname";
            textbox_lastname.PlaceholderText = "(e.g. Doe)";
            textbox_lastname.Size = new Size(170, 40);
            textbox_lastname.TabIndex = 5;
            // 
            // textbox_address
            // 
            textbox_address.BackColor = SystemColors.ButtonFace;
            textbox_address.BorderStyle = BorderStyle.None;
            textbox_address.Font = new Font("Gadugi", 8F);
            textbox_address.Location = new Point(19, 244);
            textbox_address.Multiline = true;
            textbox_address.Name = "textbox_address";
            textbox_address.PlaceholderText = "(e.g. Bagong Pag-asa, Sitio Awa, Catalunan Grande, Davao City.)";
            textbox_address.Size = new Size(514, 60);
            textbox_address.TabIndex = 6;
            // 
            // textbox_contact
            // 
            textbox_contact.BackColor = SystemColors.ButtonFace;
            textbox_contact.BorderStyle = BorderStyle.None;
            textbox_contact.Font = new Font("Gadugi", 8F);
            textbox_contact.Location = new Point(19, 342);
            textbox_contact.Multiline = true;
            textbox_contact.Name = "textbox_contact";
            textbox_contact.PlaceholderText = "(e.g. 09123456789)";
            textbox_contact.Size = new Size(514, 40);
            textbox_contact.TabIndex = 7;
            // 
            // button_register
            // 
            button_register.BackColor = Color.RoyalBlue;
            button_register.FlatAppearance.BorderSize = 0;
            button_register.FlatStyle = FlatStyle.Flat;
            button_register.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_register.ForeColor = SystemColors.ButtonHighlight;
            button_register.Location = new Point(419, 485);
            button_register.Name = "button_register";
            button_register.Size = new Size(114, 30);
            button_register.TabIndex = 9;
            button_register.Text = "Register";
            button_register.UseVisualStyleBackColor = false;
            button_register.Click += button_register_Click;
            // 
            // button_cancel
            // 
            button_cancel.BackColor = SystemColors.ButtonFace;
            button_cancel.FlatAppearance.BorderSize = 0;
            button_cancel.FlatStyle = FlatStyle.Flat;
            button_cancel.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_cancel.Location = new Point(319, 485);
            button_cancel.Name = "button_cancel";
            button_cancel.Size = new Size(94, 30);
            button_cancel.TabIndex = 10;
            button_cancel.Text = "Cancel";
            button_cancel.UseVisualStyleBackColor = false;
            button_cancel.Click += button_cancel_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveCaption;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(9, 134);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(433, 391);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ButtonHighlight;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(button_cancel);
            panel3.Controls.Add(textbox_contact);
            panel3.Controls.Add(button_register);
            panel3.Controls.Add(textbox_username);
            panel3.Controls.Add(textbox_address);
            panel3.Controls.Add(textbox_password);
            panel3.Controls.Add(textbox_lastname);
            panel3.Controls.Add(textbox_firstname);
            panel3.Controls.Add(textbox_middlename);
            panel3.Location = new Point(452, 9);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(564, 532);
            panel3.TabIndex = 14;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Gadugi", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.ActiveCaptionText;
            label9.Location = new Point(34, 320);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(67, 19);
            label9.TabIndex = 21;
            label9.Text = "Contact:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Gadugi", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ActiveCaptionText;
            label8.Location = new Point(34, 222);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(70, 19);
            label8.TabIndex = 20;
            label8.Text = "Address:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Gadugi", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ActiveCaptionText;
            label7.Location = new Point(372, 126);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(88, 19);
            label7.TabIndex = 19;
            label7.Text = "Last Name:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Gadugi", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(221, 126);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(107, 19);
            label6.TabIndex = 18;
            label6.Text = "Middle Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Gadugi", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(34, 126);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(90, 19);
            label4.TabIndex = 17;
            label4.Text = "First Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Gadugi", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(297, 44);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(80, 19);
            label3.TabIndex = 16;
            label3.Text = "Password:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Gadugi", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(34, 44);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(84, 19);
            label5.TabIndex = 15;
            label5.Text = "Username:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gadugi", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(88, 16);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(98, 28);
            label1.TabIndex = 13;
            label1.Text = "Register";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(4, 16);
            pictureBox2.Margin = new Padding(2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(81, 71);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.BackColor = SystemColors.ActiveCaption;
            label2.Font = new Font("Gadugi", 8F);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(88, 54);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(338, 34);
            label2.TabIndex = 14;
            label2.Text = "\"Join us today and experience hassle-free laundry service!\"";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Location = new Point(4, 9);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(446, 100);
            panel1.TabIndex = 12;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1010, 538);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            Controls.Add(panel3);
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
        private Label label1;
        private PictureBox pictureBox2;
        private Label label2;
        private Panel panel1;
        private Label label5;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label4;
        private Label label3;
    }
}