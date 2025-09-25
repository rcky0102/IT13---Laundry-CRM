namespace IT13___Laundry_CRM
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            login_button = new Button();
            textbox_username = new TextBox();
            textbox_password = new TextBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            linklabel_reg = new LinkLabel();
            linkLabel2 = new LinkLabel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // login_button
            // 
            login_button.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            login_button.BackColor = SystemColors.ActiveCaption;
            login_button.Location = new Point(116, 289);
            login_button.Margin = new Padding(3, 2, 3, 2);
            login_button.Name = "login_button";
            login_button.Size = new Size(259, 42);
            login_button.TabIndex = 3;
            login_button.Text = "Login";
            login_button.UseVisualStyleBackColor = false;
            login_button.Click += login_button_Click;
            // 
            // textbox_username
            // 
            textbox_username.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textbox_username.Location = new Point(80, 74);
            textbox_username.Margin = new Padding(3, 2, 3, 2);
            textbox_username.Multiline = true;
            textbox_username.Name = "textbox_username";
            textbox_username.PlaceholderText = "Username";
            textbox_username.Size = new Size(354, 61);
            textbox_username.TabIndex = 4;
            // 
            // textbox_password
            // 
            textbox_password.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textbox_password.Location = new Point(80, 191);
            textbox_password.Margin = new Padding(3, 2, 3, 2);
            textbox_password.Multiline = true;
            textbox_password.Name = "textbox_password";
            textbox_password.PasswordChar = '*';
            textbox_password.PlaceholderText = "Password";
            textbox_password.Size = new Size(354, 58);
            textbox_password.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(80, 497);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(250, 22);
            label1.TabIndex = 7;
            label1.Text = "Doesn't have an account?";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ControlLightLight;
            groupBox1.Controls.Add(linklabel_reg);
            groupBox1.Controls.Add(linkLabel2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textbox_username);
            groupBox1.Controls.Add(login_button);
            groupBox1.Controls.Add(textbox_password);
            groupBox1.FlatStyle = FlatStyle.System;
            groupBox1.Location = new Point(73, 67);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(514, 570);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // linklabel_reg
            // 
            linklabel_reg.AutoSize = true;
            linklabel_reg.Location = new Point(325, 497);
            linklabel_reg.Name = "linklabel_reg";
            linklabel_reg.Size = new Size(90, 22);
            linklabel_reg.TabIndex = 9;
            linklabel_reg.TabStop = true;
            linklabel_reg.Text = "Register";
            linklabel_reg.LinkClicked += linklabel_reg_LinkClicked;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Location = new Point(160, 345);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(170, 22);
            linkLabel2.TabIndex = 8;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Forgot Password?";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(653, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(610, 672);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cascadia Code", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(97, 21);
            label2.Name = "label2";
            label2.Size = new Size(223, 62);
            label2.TabIndex = 10;
            label2.Text = "Laundry";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ButtonHighlight;
            label3.Font = new Font("Cascadia Code", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.RoyalBlue;
            label3.Location = new Point(309, 21);
            label3.Name = "label3";
            label3.Size = new Size(139, 62);
            label3.TabIndex = 11;
            label3.Text = "Care";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.ButtonHighlight;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1262, 673);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox1);
            Font = new Font("Cascadia Code", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button login_button;
        private TextBox textbox_username;
        private TextBox textbox_password;
        private Label label1;
        private GroupBox groupBox1;
        private LinkLabel linkLabel2;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private LinkLabel linklabel_reg;
    }
}
