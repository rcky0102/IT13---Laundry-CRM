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
            panel1 = new Panel();
            button_customers = new Button();
            button_status = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
<<<<<<< Updated upstream
            panel1.Controls.Add(button_status);
            panel1.Controls.Add(button_customers);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
=======
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(button_feedback);
            panel1.Controls.Add(profile);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button_dashboard);
            panel1.Controls.Add(button_status);
            panel1.Controls.Add(button_customers);
            panel1.Dock = DockStyle.Left;
            panel1.Font = new Font("Cascadia Code SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel1.ForeColor = SystemColors.ButtonHighlight;
            panel1.Location = new Point(0, 74);
            panel1.Margin = new Padding(4);
>>>>>>> Stashed changes
            panel1.Name = "panel1";
            panel1.Size = new Size(214, 450);
            panel1.TabIndex = 0;
            // 
<<<<<<< Updated upstream
            // button_customers
            // 
            button_customers.Location = new Point(26, 118);
=======
            // button_feedback
            // 
            button_feedback.FlatAppearance.BorderSize = 0;
            button_feedback.FlatStyle = FlatStyle.Flat;
            button_feedback.Font = new Font("Gadugi", 12F);
            button_feedback.Location = new Point(6, 275);
            button_feedback.Margin = new Padding(2);
            button_feedback.Name = "button_feedback";
            button_feedback.Size = new Size(244, 44);
            button_feedback.TabIndex = 4;
            button_feedback.Text = "📲 Feedbacks";
            button_feedback.TextAlign = ContentAlignment.MiddleLeft;
            button_feedback.UseVisualStyleBackColor = false;
            button_feedback.Click += button_feedback_Click;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Gadugi", 12F);
            button3.Location = new Point(6, 212);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.Size = new Size(244, 44);
            button3.TabIndex = 3;
            button3.Text = "📩 Messages";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button_dashboard
            // 
            button_dashboard.FlatAppearance.BorderSize = 0;
            button_dashboard.FlatStyle = FlatStyle.Flat;
            button_dashboard.Font = new Font("Gadugi", 12F);
            button_dashboard.Location = new Point(6, 25);
            button_dashboard.Margin = new Padding(2);
            button_dashboard.Name = "button_dashboard";
            button_dashboard.Size = new Size(244, 44);
            button_dashboard.TabIndex = 2;
            button_dashboard.Text = "🏠 DashBoard";
            button_dashboard.TextAlign = ContentAlignment.MiddleLeft;
            button_dashboard.UseVisualStyleBackColor = false;
            button_dashboard.Click += button_dashboard_Click;
            // 
            // button_status
            // 
            button_status.FlatAppearance.BorderSize = 0;
            button_status.FlatStyle = FlatStyle.Flat;
            button_status.Font = new Font("Gadugi", 12F);
            button_status.Location = new Point(6, 150);
            button_status.Margin = new Padding(4);
            button_status.Name = "button_status";
            button_status.Size = new Size(244, 44);
            button_status.TabIndex = 1;
            button_status.Text = "⌚ Status";
            button_status.TextAlign = ContentAlignment.MiddleLeft;
            button_status.UseVisualStyleBackColor = false;
            button_status.Click += button_status_Click;
            // 
            // button_customers
            // 
            button_customers.FlatAppearance.BorderSize = 0;
            button_customers.FlatStyle = FlatStyle.Flat;
            button_customers.Font = new Font("Gadugi", 12F);
            button_customers.Location = new Point(6, 88);
            button_customers.Margin = new Padding(4);
>>>>>>> Stashed changes
            button_customers.Name = "button_customers";
            button_customers.Size = new Size(159, 29);
            button_customers.TabIndex = 0;
<<<<<<< Updated upstream
            button_customers.Text = "Customers";
            button_customers.UseVisualStyleBackColor = true;
=======
            button_customers.Text = "👤 Customers";
            button_customers.TextAlign = ContentAlignment.MiddleLeft;
            button_customers.UseVisualStyleBackColor = false;
>>>>>>> Stashed changes
            button_customers.Click += button_customers_Click;
            // 
            // button_status
            // 
<<<<<<< Updated upstream
            button_status.Location = new Point(26, 181);
            button_status.Name = "button_status";
            button_status.Size = new Size(159, 29);
            button_status.TabIndex = 1;
            button_status.Text = "Status";
            button_status.UseVisualStyleBackColor = true;
            button_status.Click += button_status_Click;
=======
            contextmenustrip_profile.Font = new Font("Cascadia Code SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            contextmenustrip_profile.ImageScalingSize = new Size(20, 20);
            contextmenustrip_profile.Items.AddRange(new ToolStripItem[] { logout });
            contextmenustrip_profile.Name = "contextmenustrip_profile";
            contextmenustrip_profile.ShowImageMargin = false;
            contextmenustrip_profile.Size = new Size(148, 42);
            // 
            // logout
            // 
            logout.Name = "logout";
            logout.Size = new Size(147, 38);
            logout.Text = "Logout";
            logout.Click += logout_Click;
            // 
            // profile
            // 
            profile.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            profile.FlatAppearance.BorderSize = 0;
            profile.FlatStyle = FlatStyle.Flat;
            profile.Font = new Font("Gadugi", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            profile.Location = new Point(101, 437);
            profile.Margin = new Padding(4);
            profile.Name = "profile";
            profile.Size = new Size(143, 45);
            profile.TabIndex = 2;
            profile.Text = "🚪 Log Out ";
            profile.UseVisualStyleBackColor = true;
            profile.Click += profile_Click;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaption;
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(pictureBox2);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label4);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(1181, 74);
            panel3.TabIndex = 3;
            panel3.Paint += panel3_Paint;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(8, 5);
            pictureBox2.Margin = new Padding(2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(62, 59);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cascadia Code", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.RoyalBlue;
            label3.Location = new Point(210, 10);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(81, 37);
            label3.TabIndex = 4;
            label3.Text = "Care";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cascadia Code", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(72, 9);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(143, 40);
            label4.TabIndex = 5;
            label4.Text = "Laundry";
>>>>>>> Stashed changes
            // 
            // Laundry_Attendant_Template
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
<<<<<<< Updated upstream
=======
            Controls.Add(panel3);
            Margin = new Padding(4);
>>>>>>> Stashed changes
            Name = "Laundry_Attendant_Template";
            Text = "Laundry_Attendant_Template";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button_customers;
        private Button button_status;
    }
}