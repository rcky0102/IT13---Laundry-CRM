namespace IT13___Laundry_CRM
{
    partial class Laundry_Attendant_Template
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Laundry_Attendant_Template));
            panel1 = new Panel();
            button_feedback = new Button();
            button3 = new Button();
            button_dashboard = new Button();
            button_status = new Button();
            button_customers = new Button();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            contextmenustrip_profile = new ContextMenuStrip(components);
            logout = new ToolStripMenuItem();
            profile = new Button();
            panel3 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            contextmenustrip_profile.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(button_feedback);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button_dashboard);
            panel1.Controls.Add(button_status);
            panel1.Controls.Add(button_customers);
            panel1.Dock = DockStyle.Left;
            panel1.Font = new Font("Cascadia Code SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel1.ForeColor = SystemColors.ButtonHighlight;
            panel1.Location = new Point(0, 56);
            panel1.Name = "panel1";
            panel1.Size = new Size(202, 394);
            panel1.TabIndex = 0;
            // 
            // button_feedback
            // 
            button_feedback.FlatAppearance.BorderSize = 0;
            button_feedback.FlatStyle = FlatStyle.Flat;
            button_feedback.Font = new Font("Cascadia Code SemiLight", 12F);
            button_feedback.Location = new Point(11, 198);
            button_feedback.Margin = new Padding(2);
            button_feedback.Name = "button_feedback";
            button_feedback.Size = new Size(174, 37);
            button_feedback.TabIndex = 4;
            button_feedback.Text = "📲 Feedbacks";
            button_feedback.TextAlign = ContentAlignment.MiddleLeft;
            button_feedback.UseVisualStyleBackColor = true;
            button_feedback.Click += button_feedback_Click;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Cascadia Code SemiLight", 12F);
            button3.Location = new Point(10, 147);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.Size = new Size(166, 37);
            button3.TabIndex = 3;
            button3.Text = "📩 Messages";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button_dashboard
            // 
            button_dashboard.FlatAppearance.BorderSize = 0;
            button_dashboard.FlatStyle = FlatStyle.Flat;
            button_dashboard.Font = new Font("Cascadia Code SemiLight", 12F);
            button_dashboard.Location = new Point(10, 16);
            button_dashboard.Margin = new Padding(2);
            button_dashboard.Name = "button_dashboard";
            button_dashboard.Size = new Size(167, 37);
            button_dashboard.TabIndex = 2;
            button_dashboard.Text = "🏠 DashBoard";
            button_dashboard.TextAlign = ContentAlignment.MiddleLeft;
            button_dashboard.UseVisualStyleBackColor = true;
            button_dashboard.Click += button_dashboard_Click;
            // 
            // button_status
            // 
            button_status.FlatAppearance.BorderSize = 0;
            button_status.FlatStyle = FlatStyle.Flat;
            button_status.Font = new Font("Cascadia Code SemiLight", 12F);
            button_status.Location = new Point(10, 99);
            button_status.Name = "button_status";
            button_status.Size = new Size(166, 43);
            button_status.TabIndex = 1;
            button_status.Text = "⌚ Status";
            button_status.TextAlign = ContentAlignment.MiddleLeft;
            button_status.UseVisualStyleBackColor = true;
            button_status.Click += button_status_Click;
            // 
            // button_customers
            // 
            button_customers.FlatAppearance.BorderSize = 0;
            button_customers.FlatStyle = FlatStyle.Flat;
            button_customers.Font = new Font("Cascadia Code SemiLight", 12F);
            button_customers.Location = new Point(10, 58);
            button_customers.Name = "button_customers";
            button_customers.Size = new Size(186, 35);
            button_customers.TabIndex = 0;
            button_customers.Text = "👤 Customers";
            button_customers.TextAlign = ContentAlignment.MiddleLeft;
            button_customers.UseVisualStyleBackColor = true;
            button_customers.Click += button_customers_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cascadia Code", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.RoyalBlue;
            label2.Location = new Point(189, 6);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(70, 32);
            label2.TabIndex = 1;
            label2.Text = "Care";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Code", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(70, 4);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(127, 35);
            label1.TabIndex = 1;
            label1.Text = "Laundry";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(2, -2);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(63, 55);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
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
            // profile
            // 
            profile.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            profile.FlatStyle = FlatStyle.System;
            profile.Location = new Point(898, 11);
            profile.Name = "profile";
            profile.Size = new Size(34, 29);
            profile.TabIndex = 2;
            profile.Text = "👤";
            profile.UseVisualStyleBackColor = true;
            profile.Click += profile_Click;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaption;
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(profile);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(945, 56);
            panel3.TabIndex = 3;
            // 
            // Laundry_Attendant_Template
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(945, 450);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Name = "Laundry_Attendant_Template";
            Text = "Laundry_Attendant_Template";
            Load += Laundry_Attendant_Template_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            contextmenustrip_profile.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button_customers;
        private Button button_status;
        private Button button_dashboard;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Button button3;
        private Button button_feedback;
        private ContextMenuStrip contextmenustrip_profile;
        private Button profile;
        private ToolStripMenuItem logout;
        private Panel panel3;
    }
}