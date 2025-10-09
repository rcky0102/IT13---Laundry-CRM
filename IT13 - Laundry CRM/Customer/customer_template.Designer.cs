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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(customer_template));
            panel1 = new Panel();
            button_feedback = new Button();
            button_message = new Button();
            button_status = new Button();
            button_dashboard = new Button();
            contextmenustrip_profile = new ContextMenuStrip(components);
            profile = new ToolStripMenuItem();
            logout = new ToolStripMenuItem();
            button_profile = new Button();
            label4 = new Label();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            panel2 = new Panel();
            panel1.SuspendLayout();
            contextmenustrip_profile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(button_feedback);
            panel1.Controls.Add(button_message);
            panel1.Controls.Add(button_status);
            panel1.Controls.Add(button_dashboard);
            panel1.Font = new Font("Cascadia Code SemiLight", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.Location = new Point(0, 75);
            panel1.Margin = new Padding(4, 4, 4, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 575);
            panel1.TabIndex = 0;
            // 
            // button_feedback
            // 
            button_feedback.FlatAppearance.BorderSize = 0;
            button_feedback.FlatStyle = FlatStyle.Flat;
            button_feedback.Font = new Font("Gadugi", 12F);
            button_feedback.ForeColor = SystemColors.ButtonHighlight;
            button_feedback.Location = new Point(6, 212);
            button_feedback.Margin = new Padding(4, 4, 4, 4);
            button_feedback.Name = "button_feedback";
            button_feedback.Size = new Size(244, 44);
            button_feedback.TabIndex = 3;
            button_feedback.Text = "📲 Feedback";
            button_feedback.TextAlign = ContentAlignment.MiddleLeft;
            button_feedback.UseVisualStyleBackColor = true;
            button_feedback.Click += button_feedback_Click;
            // 
            // button_message
            // 
            button_message.FlatAppearance.BorderSize = 0;
            button_message.FlatStyle = FlatStyle.Flat;
            button_message.Font = new Font("Gadugi", 12F);
            button_message.ForeColor = SystemColors.ButtonHighlight;
            button_message.Location = new Point(6, 150);
            button_message.Margin = new Padding(4, 4, 4, 4);
            button_message.Name = "button_message";
            button_message.Size = new Size(244, 44);
            button_message.TabIndex = 2;
            button_message.Text = "📩 Messages";
            button_message.TextAlign = ContentAlignment.MiddleLeft;
            button_message.UseVisualStyleBackColor = true;
            button_message.Click += button_message_Click;
            // 
            // button_status
            // 
            button_status.FlatAppearance.BorderSize = 0;
            button_status.FlatStyle = FlatStyle.Flat;
            button_status.Font = new Font("Gadugi", 12F);
            button_status.ForeColor = SystemColors.ButtonHighlight;
            button_status.Location = new Point(6, 88);
            button_status.Margin = new Padding(4, 4, 4, 4);
            button_status.Name = "button_status";
            button_status.Size = new Size(244, 44);
            button_status.TabIndex = 1;
            button_status.Text = "⌚ Status";
            button_status.TextAlign = ContentAlignment.MiddleLeft;
            button_status.UseVisualStyleBackColor = true;
            button_status.Click += button_status_Click;
            // 
            // button_dashboard
            // 
            button_dashboard.FlatAppearance.BorderSize = 0;
            button_dashboard.FlatStyle = FlatStyle.Flat;
            button_dashboard.Font = new Font("Gadugi", 12F);
            button_dashboard.ForeColor = SystemColors.ButtonHighlight;
            button_dashboard.Location = new Point(6, 25);
            button_dashboard.Margin = new Padding(4, 4, 4, 4);
            button_dashboard.Name = "button_dashboard";
            button_dashboard.Size = new Size(244, 44);
            button_dashboard.TabIndex = 0;
            button_dashboard.Text = "📊 DashBoard";
            button_dashboard.TextAlign = ContentAlignment.MiddleLeft;
            button_dashboard.UseVisualStyleBackColor = true;
            button_dashboard.Click += button_dashboard_Click;
            // 
            // contextmenustrip_profile
            // 
            contextmenustrip_profile.Font = new Font("Cascadia Code SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            contextmenustrip_profile.ImageScalingSize = new Size(20, 20);
            contextmenustrip_profile.Items.AddRange(new ToolStripItem[] { profile, logout });
            contextmenustrip_profile.Name = "contextmenustrip_profile";
            contextmenustrip_profile.RenderMode = ToolStripRenderMode.Professional;
            contextmenustrip_profile.ShowImageMargin = false;
            contextmenustrip_profile.Size = new Size(162, 80);
            contextmenustrip_profile.Text = "Profile";
            // 
            // profile
            // 
            profile.Name = "profile";
            profile.Size = new Size(161, 38);
            profile.Text = "Profile";
            profile.Click += profile_Click;
            // 
            // logout
            // 
            logout.Name = "logout";
            logout.Size = new Size(161, 38);
            logout.Text = "Logout";
            logout.Click += logout_Click;
            // 
            // button_profile
            // 
            button_profile.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_profile.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_profile.Location = new Point(1102, 8);
            button_profile.Margin = new Padding(4, 4, 4, 4);
            button_profile.Name = "button_profile";
            button_profile.Size = new Size(62, 50);
            button_profile.TabIndex = 1;
            button_profile.Text = "👤";
            button_profile.UseVisualStyleBackColor = true;
            button_profile.Click += button_profile_Click;
            button_profile.Resize += button_profile_Resize;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cascadia Code", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(79, 8);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(143, 40);
            label4.TabIndex = 1;
            label4.Text = "Laundry";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(14, 4);
            pictureBox2.Margin = new Padding(2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(62, 59);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cascadia Code", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.RoyalBlue;
            label3.Location = new Point(216, 9);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(81, 37);
            label3.TabIndex = 1;
            label3.Text = "Care";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(button_profile);
            panel2.Controls.Add(label4);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1181, 74);
            panel2.TabIndex = 4;
            // 
            // customer_template
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1181, 650);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(4, 4, 4, 4);
            Name = "customer_template";
            Text = "Customer | Template";
            Load += customer_template_Load;
            panel1.ResumeLayout(false);
            contextmenustrip_profile.ResumeLayout(false);
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
        private ContextMenuStrip contextmenustrip_profile;
        private ToolStripMenuItem profile;
        private ToolStripMenuItem logout;
        private Button button_profile;
        private Label label4;
        private PictureBox pictureBox2;
        private Label label3;
        private Panel panel2;
    }
}