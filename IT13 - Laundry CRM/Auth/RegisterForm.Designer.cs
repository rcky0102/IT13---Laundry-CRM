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
            panel1 = new Panel();
            label2 = new Label();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            panel3 = new Panel();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // textbox_username
            // 
            textbox_username.BackColor = SystemColors.Menu;
            textbox_username.Font = new Font("Cascadia Code", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textbox_username.Location = new Point(26, 37);
            textbox_username.Margin = new Padding(4);
            textbox_username.Multiline = true;
            textbox_username.Name = "textbox_username";
            textbox_username.PlaceholderText = "Username:";
            textbox_username.Size = new Size(343, 50);
            textbox_username.TabIndex = 0;
            // 
            // textbox_password
            // 
            textbox_password.BackColor = SystemColors.Menu;
            textbox_password.Font = new Font("Cascadia Code", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textbox_password.Location = new Point(26, 95);
            textbox_password.Margin = new Padding(4);
            textbox_password.Multiline = true;
            textbox_password.Name = "textbox_password";
            textbox_password.PlaceholderText = "Password:";
            textbox_password.Size = new Size(343, 53);
            textbox_password.TabIndex = 1;
            textbox_password.TextChanged += textBox2_TextChanged;
            // 
            // textbox_firstname
            // 
            textbox_firstname.BackColor = SystemColors.Menu;
            textbox_firstname.Font = new Font("Cascadia Code", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textbox_firstname.Location = new Point(26, 190);
            textbox_firstname.Margin = new Padding(4);
            textbox_firstname.Multiline = true;
            textbox_firstname.Name = "textbox_firstname";
            textbox_firstname.PlaceholderText = "First Name:";
            textbox_firstname.Size = new Size(343, 51);
            textbox_firstname.TabIndex = 3;
            // 
            // textbox_middlename
            // 
            textbox_middlename.BackColor = SystemColors.Menu;
            textbox_middlename.Font = new Font("Cascadia Code", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textbox_middlename.Location = new Point(26, 249);
            textbox_middlename.Margin = new Padding(4);
            textbox_middlename.Multiline = true;
            textbox_middlename.Name = "textbox_middlename";
            textbox_middlename.PlaceholderText = "Middle Name:";
            textbox_middlename.Size = new Size(343, 41);
            textbox_middlename.TabIndex = 4;
            // 
            // textbox_lastname
            // 
            textbox_lastname.BackColor = SystemColors.Menu;
            textbox_lastname.Font = new Font("Cascadia Code", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textbox_lastname.Location = new Point(26, 298);
            textbox_lastname.Margin = new Padding(4);
            textbox_lastname.Multiline = true;
            textbox_lastname.Name = "textbox_lastname";
            textbox_lastname.PlaceholderText = "Last Name:";
            textbox_lastname.Size = new Size(343, 51);
            textbox_lastname.TabIndex = 5;
            // 
            // textbox_address
            // 
            textbox_address.BackColor = SystemColors.Menu;
            textbox_address.Font = new Font("Cascadia Code", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textbox_address.Location = new Point(26, 357);
            textbox_address.Margin = new Padding(4);
            textbox_address.Multiline = true;
            textbox_address.Name = "textbox_address";
            textbox_address.PlaceholderText = "Address:";
            textbox_address.Size = new Size(343, 51);
            textbox_address.TabIndex = 6;
            // 
            // textbox_contact
            // 
            textbox_contact.BackColor = SystemColors.Menu;
            textbox_contact.Font = new Font("Cascadia Code", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textbox_contact.Location = new Point(26, 416);
            textbox_contact.Margin = new Padding(4);
            textbox_contact.Multiline = true;
            textbox_contact.Name = "textbox_contact";
            textbox_contact.PlaceholderText = "Contact:";
            textbox_contact.Size = new Size(343, 53);
            textbox_contact.TabIndex = 7;
            // 
            // button_register
            // 
            button_register.BackColor = Color.RoyalBlue;
            button_register.FlatAppearance.BorderSize = 0;
            button_register.ForeColor = SystemColors.ButtonHighlight;
            button_register.Location = new Point(180, 495);
            button_register.Margin = new Padding(4);
            button_register.Name = "button_register";
            button_register.Size = new Size(118, 36);
            button_register.TabIndex = 9;
            button_register.Text = "Register";
            button_register.UseVisualStyleBackColor = false;
            button_register.Click += button_register_Click;
            // 
            // button_cancel
            // 
            button_cancel.FlatAppearance.BorderSize = 0;
            button_cancel.FlatStyle = FlatStyle.Flat;
            button_cancel.Location = new Point(294, 495);
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
            pictureBox1.Location = new Point(9, 103);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(541, 455);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(557, 565);
            panel1.TabIndex = 12;
            // 
            // label2
            // 
            label2.BackColor = SystemColors.ActiveCaption;
            label2.Font = new Font("Cascadia Code Light", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(130, 50);
            label2.Name = "label2";
            label2.Size = new Size(422, 42);
            label2.TabIndex = 14;
            label2.Text = "\"Join us today and experience hassle-free laundry service!\"";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(-2, -2);
            panel2.Name = "panel2";
            panel2.Size = new Size(557, 99);
            panel2.TabIndex = 14;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(10, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(101, 89);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Code SemiBold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(117, 3);
            label1.Name = "label1";
            label1.Size = new Size(188, 47);
            label1.TabIndex = 13;
            label1.Text = "Register";
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
            panel3.Location = new Point(565, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(423, 538);
            panel3.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ButtonHighlight;
            label3.Font = new Font("Cascadia Code", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaption;
            label3.Location = new Point(3, 8);
            label3.Name = "label3";
            label3.Size = new Size(153, 24);
            label3.TabIndex = 11;
            label3.Text = "User/Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ButtonHighlight;
            label4.Font = new Font("Cascadia Code", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ActiveCaption;
            label4.Location = new Point(3, 162);
            label4.Name = "label4";
            label4.Size = new Size(252, 24);
            label4.TabIndex = 12;
            label4.Text = "Enter Personal Details";
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1000, 562);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Margin = new Padding(4);
            Name = "RegisterForm";
            Text = "RegisterForm";
            Load += RegisterForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
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
        private Panel panel1;
        private Label label1;
        private Label label2;
        private Panel panel2;
        private PictureBox pictureBox2;
        private Panel panel3;
        private Label label4;
        private Label label3;
    }
}