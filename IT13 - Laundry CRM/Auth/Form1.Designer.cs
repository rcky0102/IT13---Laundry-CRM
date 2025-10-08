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
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            login_button = new Button();
            textbox_password = new TextBox();
            textbox_username = new TextBox();
            label1 = new Label();
            linklabel_reg = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(497, 39);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(753, 492);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaption;
            label2.Font = new Font("Cascadia Code", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(129, 97);
            label2.Name = "label2";
            label2.Size = new Size(223, 62);
            label2.TabIndex = 10;
            label2.Text = "Laundry";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaption;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Cascadia Code", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.RoyalBlue;
            label3.Location = new Point(290, 154);
            label3.Name = "label3";
            label3.Size = new Size(139, 62);
            label3.TabIndex = 11;
            label3.Text = "Care";
            // 
            // label4
            // 
            label4.BackColor = SystemColors.ActiveCaption;
            label4.Font = new Font("Cascadia Code", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(515, 534);
            label4.Name = "label4";
            label4.Size = new Size(719, 120);
            label4.TabIndex = 13;
            label4.Text = "\"Welcome back! Let's get your laundry organized and hassle-free.\"";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // login_button
            // 
            login_button.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            login_button.BackColor = Color.RoyalBlue;
            login_button.FlatAppearance.BorderColor = Color.Blue;
            login_button.FlatAppearance.BorderSize = 20;
            login_button.ForeColor = SystemColors.ButtonHighlight;
            login_button.Location = new Point(129, 413);
            login_button.Margin = new Padding(3, 2, 3, 2);
            login_button.Name = "login_button";
            login_button.Size = new Size(313, 42);
            login_button.TabIndex = 3;
            login_button.Text = "Login";
            login_button.UseVisualStyleBackColor = false;
            login_button.Click += login_button_Click;
            // 
            // textbox_password
            // 
            textbox_password.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textbox_password.BackColor = SystemColors.ButtonHighlight;
            textbox_password.Font = new Font("Cascadia Code", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textbox_password.Location = new Point(112, 332);
            textbox_password.Margin = new Padding(3, 2, 3, 2);
            textbox_password.Multiline = true;
            textbox_password.Name = "textbox_password";
            textbox_password.PasswordChar = '*';
            textbox_password.PlaceholderText = "🗝️ Password:";
            textbox_password.Size = new Size(354, 58);
            textbox_password.TabIndex = 5;
            // 
            // textbox_username
            // 
            textbox_username.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textbox_username.BackColor = SystemColors.ControlLightLight;
            textbox_username.Font = new Font("Cascadia Code", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textbox_username.ForeColor = SystemColors.ActiveCaptionText;
            textbox_username.Location = new Point(112, 241);
            textbox_username.Margin = new Padding(3, 2, 3, 2);
            textbox_username.Multiline = true;
            textbox_username.Name = "textbox_username";
            textbox_username.PlaceholderText = "👤 Username:";
            textbox_username.Size = new Size(354, 61);
            textbox_username.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Cascadia Code", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(190, 534);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(200, 18);
            label1.TabIndex = 7;
            label1.Text = "Doesn't have an account?";
            // 
            // linklabel_reg
            // 
            linklabel_reg.AutoSize = true;
            linklabel_reg.BackColor = SystemColors.ActiveCaption;
            linklabel_reg.Font = new Font("Cascadia Code", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linklabel_reg.Location = new Point(252, 562);
            linklabel_reg.Name = "linklabel_reg";
            linklabel_reg.Size = new Size(72, 18);
            linklabel_reg.TabIndex = 9;
            linklabel_reg.TabStop = true;
            linklabel_reg.Text = "Register";
            linklabel_reg.LinkClicked += linklabel_reg_LinkClicked;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1262, 673);
            Controls.Add(linklabel_reg);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(login_button);
            Controls.Add(textbox_password);
            Controls.Add(textbox_username);
            Controls.Add(label2);
            Controls.Add(label3);
            Font = new Font("Cascadia Code", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button login_button;
        private TextBox textbox_password;
        private TextBox textbox_username;
        private Label label1;
        private LinkLabel linklabel_reg;
    }
}
