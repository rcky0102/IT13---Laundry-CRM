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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SIdebarTemplate));
            panel1 = new Panel();
            button_feedback = new Button();
            button_messages = new Button();
            button_users = new Button();
            button1 = new Button();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            profile = new Button();
            contextmenustrip_profile = new ContextMenuStrip(components);
            logout = new ToolStripMenuItem();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            contextmenustrip_profile.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(button_feedback);
            panel1.Controls.Add(button_messages);
            panel1.Controls.Add(button_users);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 56);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(202, 438);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // button_feedback
            // 
            button_feedback.FlatAppearance.BorderSize = 0;
            button_feedback.FlatStyle = FlatStyle.Flat;
            button_feedback.Font = new Font("Cascadia Code", 12F);
            button_feedback.ForeColor = SystemColors.ButtonHighlight;
            button_feedback.Location = new Point(-2, 202);
            button_feedback.Margin = new Padding(4, 3, 4, 3);
            button_feedback.Name = "button_feedback";
            button_feedback.Size = new Size(241, 50);
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
            button_messages.Location = new Point(-2, 146);
            button_messages.Margin = new Padding(4, 3, 4, 3);
            button_messages.Name = "button_messages";
            button_messages.Size = new Size(241, 50);
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
            button_users.Location = new Point(-2, 97);
            button_users.Margin = new Padding(4, 3, 4, 3);
            button_users.Name = "button_users";
            button_users.Size = new Size(241, 43);
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
            button1.Location = new Point(-2, 48);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(241, 43);
            button1.TabIndex = 0;
            button1.Text = "📊 DashBoard";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cascadia Code", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.HotTrack;
            label2.Location = new Point(194, 0);
            label2.Name = "label2";
            label2.Size = new Size(79, 35);
            label2.TabIndex = 5;
            label2.Text = "Care";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Code SemiBold", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(73, 0);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(127, 35);
            label1.TabIndex = 3;
            label1.Text = "Laundry";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(11, -2);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(59, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(profile);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1181, 56);
            panel2.TabIndex = 1;
            // 
            // profile
            // 
            profile.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            profile.Location = new Point(1109, 10);
            profile.Name = "profile";
            profile.Size = new Size(43, 35);
            profile.TabIndex = 1;
            profile.Text = "👤";
            profile.UseVisualStyleBackColor = true;
            profile.Click += profile_Click;
            // 
            // contextmenustrip_profile
            // 
            contextmenustrip_profile.ImageScalingSize = new Size(20, 20);
            contextmenustrip_profile.Items.AddRange(new ToolStripItem[] { logout });
            contextmenustrip_profile.Name = "contextmenustrip_profile";
            contextmenustrip_profile.Size = new Size(126, 28);
            // 
            // logout
            // 
            logout.Name = "logout";
            logout.Size = new Size(125, 24);
            logout.Text = "Logout";
            logout.Click += logout_Click;
            // 
            // SIdebarTemplate
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1181, 494);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Font = new Font("Cascadia Code", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "SIdebarTemplate";
            Text = "SIdebarTemplate";
            Load += SIdebarTemplate_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            contextmenustrip_profile.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button_users;
        private Button button1;
        private Label label1;
        private PictureBox pictureBox1;
        private Button button_messages;
        private Button button_feedback;
        private Label label2;
        private Panel panel2;
        private Button profile;
        private ContextMenuStrip contextmenustrip_profile;
        private ToolStripMenuItem logout;
    }
}