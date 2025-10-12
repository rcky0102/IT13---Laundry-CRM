namespace IT13___Laundry_CRM
{
    partial class SIdebarTemplate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SIdebarTemplate));
            panel1 = new Panel();
            button2 = new Button();
            button_feedback = new Button();
            button_messages = new Button();
            button_users = new Button();
            button1 = new Button();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            button_notif = new Button();
            button_logout = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(button_logout);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button_feedback);
            panel1.Controls.Add(button_messages);
            panel1.Controls.Add(button_users);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 60);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(202, 434);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Cascadia Code", 12F);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(5, 220);
            button2.Margin = new Padding(4, 3, 4, 3);
            button2.Name = "button2";
            button2.Size = new Size(195, 35);
            button2.TabIndex = 5;
            button2.Text = "📲 Reports";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_2;
            // 
            // button_feedback
            // 
            button_feedback.FlatAppearance.BorderSize = 0;
            button_feedback.FlatStyle = FlatStyle.Flat;
            button_feedback.Font = new Font("Cascadia Code", 12F);
            button_feedback.ForeColor = SystemColors.ButtonHighlight;
            button_feedback.Location = new Point(5, 170);
            button_feedback.Margin = new Padding(4, 3, 4, 3);
            button_feedback.Name = "button_feedback";
            button_feedback.Size = new Size(195, 35);
            button_feedback.TabIndex = 4;
            button_feedback.Text = "📲 Feedback";
            button_feedback.TextAlign = ContentAlignment.MiddleLeft;
            button_feedback.UseVisualStyleBackColor = true;
            button_feedback.Click += button_feedback_Click;
            // 
            // button_messages
            // 
            button_messages.FlatAppearance.BorderSize = 0;
            button_messages.FlatStyle = FlatStyle.Flat;
            button_messages.Font = new Font("Cascadia Code", 12F);
            button_messages.ForeColor = SystemColors.ButtonHighlight;
            button_messages.Location = new Point(5, 120);
            button_messages.Margin = new Padding(4, 3, 4, 3);
            button_messages.Name = "button_messages";
            button_messages.Size = new Size(195, 35);
            button_messages.TabIndex = 2;
            button_messages.Text = "📩 Message";
            button_messages.TextAlign = ContentAlignment.MiddleLeft;
            button_messages.UseVisualStyleBackColor = true;
            button_messages.Click += button_messages_Click;
            // 
            // button_users
            // 
            button_users.FlatAppearance.BorderSize = 0;
            button_users.FlatStyle = FlatStyle.Flat;
            button_users.Font = new Font("Cascadia Code", 12F);
            button_users.ForeColor = SystemColors.ButtonHighlight;
            button_users.Location = new Point(5, 70);
            button_users.Margin = new Padding(4, 3, 4, 3);
            button_users.Name = "button_users";
            button_users.Size = new Size(195, 35);
            button_users.TabIndex = 1;
            button_users.Text = "👤 Users";
            button_users.TextAlign = ContentAlignment.MiddleLeft;
            button_users.UseVisualStyleBackColor = true;
            button_users.Click += button_users_Click;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Cascadia Code", 12F);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(5, 20);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(195, 35);
            button1.TabIndex = 0;
            button1.Text = "📊 DashBoard";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(button_notif);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label4);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(941, 60);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(7, 4);
            pictureBox2.Margin = new Padding(2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(50, 47);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cascadia Code", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.RoyalBlue;
            label3.Location = new Point(169, 8);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(70, 32);
            label3.TabIndex = 7;
            label3.Text = "Care";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cascadia Code", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(59, 7);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(120, 33);
            label4.TabIndex = 8;
            label4.Text = "Laundry";
            // 
            // button_notif
            // 
            button_notif.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_notif.FlatAppearance.BorderSize = 0;
            button_notif.FlatAppearance.MouseDownBackColor = Color.RoyalBlue;
            button_notif.FlatAppearance.MouseOverBackColor = Color.RoyalBlue;
            button_notif.FlatStyle = FlatStyle.Flat;
            button_notif.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_notif.ForeColor = SystemColors.ButtonHighlight;
            button_notif.Location = new Point(877, 7);
            button_notif.Name = "button_notif";
            button_notif.Size = new Size(50, 40);
            button_notif.TabIndex = 10;
            button_notif.Text = "🔔";
            button_notif.UseVisualStyleBackColor = true;
            button_notif.Click += button_notif_Click;
            // 
            // button_logout
            // 
            button_logout.FlatAppearance.BorderSize = 0;
            button_logout.FlatStyle = FlatStyle.Flat;
            button_logout.Font = new Font("Cascadia Code", 12F);
            button_logout.ForeColor = SystemColors.ButtonHighlight;
            button_logout.Location = new Point(5, 270);
            button_logout.Margin = new Padding(4, 3, 4, 3);
            button_logout.Name = "button_logout";
            button_logout.Size = new Size(195, 35);
            button_logout.TabIndex = 6;
            button_logout.Text = "➜] Logout";
            button_logout.TextAlign = ContentAlignment.MiddleLeft;
            button_logout.UseVisualStyleBackColor = true;
            button_logout.Click += button_logout_Click;
            // 
            // SIdebarTemplate
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(941, 494);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Font = new Font("Cascadia Code", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "SIdebarTemplate";
            Text = "Admin | Template";
            Load += SIdebarTemplate_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button_users;
        private Button button1;
        private Button button_messages;
        private Button button_feedback;
        private Panel panel2;
        private PictureBox pictureBox2;
        private Label label3;
        private Label label4;
        private Button button2;
        private Button button_notif;
        private Button button_logout;
    }
}