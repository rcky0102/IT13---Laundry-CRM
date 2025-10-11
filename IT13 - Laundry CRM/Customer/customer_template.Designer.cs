namespace IT13___Laundry_CRM
{
    partial class customer_template
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(customer_template));
            panel1 = new Panel();
            button_logout = new Button();
            button_profile = new Button();
            button_feedback = new Button();
            button_message = new Button();
            button_status = new Button();
            button_dashboard = new Button();
            label4 = new Label();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            panel2 = new Panel();
            button_notif = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(button_logout);
            panel1.Controls.Add(button_profile);
            panel1.Controls.Add(button_feedback);
            panel1.Controls.Add(button_message);
            panel1.Controls.Add(button_status);
            panel1.Controls.Add(button_dashboard);
            panel1.Font = new Font("Cascadia Code SemiLight", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.Location = new Point(0, 60);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 460);
            panel1.TabIndex = 0;
            // 
            // button_logout
            // 
            button_logout.Anchor = AnchorStyles.Bottom;
            button_logout.BackColor = SystemColors.GradientActiveCaption;
            button_logout.FlatAppearance.BorderSize = 0;
            button_logout.FlatStyle = FlatStyle.Flat;
            button_logout.ForeColor = SystemColors.ButtonHighlight;
            button_logout.Location = new Point(5, 225);
            button_logout.Name = "button_logout";
            button_logout.Size = new Size(192, 35);
            button_logout.TabIndex = 5;
            button_logout.Text = "➜] Logout";
            button_logout.TextAlign = ContentAlignment.MiddleLeft;
            button_logout.UseVisualStyleBackColor = false;
            button_logout.Click += button_logout_Click;
            // 
            // button_profile
            // 
            button_profile.Anchor = AnchorStyles.Bottom;
            button_profile.BackColor = SystemColors.GradientActiveCaption;
            button_profile.FlatAppearance.BorderSize = 0;
            button_profile.FlatStyle = FlatStyle.Flat;
            button_profile.ForeColor = SystemColors.ButtonHighlight;
            button_profile.Location = new Point(5, 184);
            button_profile.Name = "button_profile";
            button_profile.Size = new Size(192, 35);
            button_profile.TabIndex = 4;
            button_profile.Text = "👤 Profile";
            button_profile.TextAlign = ContentAlignment.MiddleLeft;
            button_profile.UseVisualStyleBackColor = false;
            button_profile.Click += button_profile_Click;
            // 
            // button_feedback
            // 
            button_feedback.BackColor = SystemColors.GradientActiveCaption;
            button_feedback.FlatAppearance.BorderSize = 0;
            button_feedback.FlatStyle = FlatStyle.Flat;
            button_feedback.ForeColor = SystemColors.ButtonHighlight;
            button_feedback.Location = new Point(5, 143);
            button_feedback.Name = "button_feedback";
            button_feedback.Size = new Size(192, 35);
            button_feedback.TabIndex = 3;
            button_feedback.Text = "📲 Feedback";
            button_feedback.TextAlign = ContentAlignment.MiddleLeft;
            button_feedback.UseVisualStyleBackColor = false;
            button_feedback.Click += button_feedback_Click;
            // 
            // button_message
            // 
            button_message.BackColor = SystemColors.GradientActiveCaption;
            button_message.FlatAppearance.BorderSize = 0;
            button_message.FlatStyle = FlatStyle.Flat;
            button_message.ForeColor = SystemColors.ButtonHighlight;
            button_message.Location = new Point(5, 102);
            button_message.Name = "button_message";
            button_message.Size = new Size(192, 35);
            button_message.TabIndex = 2;
            button_message.Text = "📩 Messages";
            button_message.TextAlign = ContentAlignment.MiddleLeft;
            button_message.UseVisualStyleBackColor = false;
            button_message.Click += button_message_Click;
            // 
            // button_status
            // 
            button_status.BackColor = SystemColors.GradientActiveCaption;
            button_status.FlatAppearance.BorderSize = 0;
            button_status.FlatStyle = FlatStyle.Flat;
            button_status.ForeColor = SystemColors.ButtonHighlight;
            button_status.Location = new Point(5, 61);
            button_status.Name = "button_status";
            button_status.Size = new Size(192, 35);
            button_status.TabIndex = 1;
            button_status.Text = "⌚ Status";
            button_status.TextAlign = ContentAlignment.MiddleLeft;
            button_status.UseVisualStyleBackColor = false;
            button_status.Click += button_status_Click;
            // 
            // button_dashboard
            // 
            button_dashboard.BackColor = SystemColors.GradientActiveCaption;
            button_dashboard.FlatAppearance.BorderSize = 0;
            button_dashboard.FlatStyle = FlatStyle.Flat;
            button_dashboard.ForeColor = SystemColors.ButtonHighlight;
            button_dashboard.Location = new Point(5, 20);
            button_dashboard.Name = "button_dashboard";
            button_dashboard.Size = new Size(192, 35);
            button_dashboard.TabIndex = 0;
            button_dashboard.Text = "📊 DashBoard";
            button_dashboard.TextAlign = ContentAlignment.MiddleLeft;
            button_dashboard.UseVisualStyleBackColor = false;
            button_dashboard.Click += button_dashboard_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cascadia Code", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(63, 6);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(120, 33);
            label4.TabIndex = 1;
            label4.Text = "Laundry";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(11, 3);
            pictureBox2.Margin = new Padding(2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(50, 47);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cascadia Code", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.RoyalBlue;
            label3.Location = new Point(173, 7);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(70, 32);
            label3.TabIndex = 1;
            label3.Text = "Care";
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
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(945, 60);
            panel2.TabIndex = 4;
            // 
            // button_notif
            // 
            button_notif.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_notif.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_notif.Location = new Point(868, 7);
            button_notif.Name = "button_notif";
            button_notif.Size = new Size(50, 40);
            button_notif.TabIndex = 4;
            button_notif.Text = "👤";
            button_notif.UseVisualStyleBackColor = true;
            button_notif.Click += button_notif_Click;
            // 
            // customer_template
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(945, 520);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "customer_template";
            Text = "Customer | Template";
            Load += customer_template_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button_dashboard;
        private Button button_status;
        private Button button_message;
        private Button button_feedback;
        private Label label4;
        private PictureBox pictureBox2;
        private Label label3;
        private Panel panel2;
        private Button button_profile;
        private Button button_logout;
        private Button button_notif;
    }
}