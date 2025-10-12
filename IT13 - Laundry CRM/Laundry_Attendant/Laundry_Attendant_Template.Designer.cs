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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Laundry_Attendant_Template));
            panel1 = new Panel();
            button_logout = new Button();
            button_feedback = new Button();
            button3 = new Button();
            button_dashboard = new Button();
            button_status = new Button();
            button_customers = new Button();
            panel3 = new Panel();
            button_notif = new Button();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(button_logout);
            panel1.Controls.Add(button_feedback);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button_dashboard);
            panel1.Controls.Add(button_status);
            panel1.Controls.Add(button_customers);
            panel1.Dock = DockStyle.Left;
            panel1.Font = new Font("Cascadia Code SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel1.ForeColor = SystemColors.ButtonHighlight;
            panel1.Location = new Point(0, 60);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 390);
            panel1.TabIndex = 0;
            // 
            // button_logout
            // 
            button_logout.FlatAppearance.BorderSize = 0;
            button_logout.FlatStyle = FlatStyle.Flat;
            button_logout.Font = new Font("Gadugi", 12F);
            button_logout.Location = new Point(5, 270);
            button_logout.Margin = new Padding(2);
            button_logout.Name = "button_logout";
            button_logout.Size = new Size(195, 35);
            button_logout.TabIndex = 5;
            button_logout.Text = "➜] Logout";
            button_logout.TextAlign = ContentAlignment.MiddleLeft;
            button_logout.UseVisualStyleBackColor = true;
            button_logout.Click += button_logout_Click;
            // 
            // button_feedback
            // 
            button_feedback.FlatAppearance.BorderSize = 0;
            button_feedback.FlatStyle = FlatStyle.Flat;
            button_feedback.Font = new Font("Gadugi", 12F);
            button_feedback.Location = new Point(5, 220);
            button_feedback.Margin = new Padding(2);
            button_feedback.Name = "button_feedback";
            button_feedback.Size = new Size(195, 35);
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
            button3.Font = new Font("Gadugi", 12F);
            button3.Location = new Point(5, 170);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.Size = new Size(195, 35);
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
            button_dashboard.Font = new Font("Gadugi", 12F);
            button_dashboard.Location = new Point(5, 20);
            button_dashboard.Margin = new Padding(2);
            button_dashboard.Name = "button_dashboard";
            button_dashboard.Size = new Size(195, 35);
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
            button_status.Font = new Font("Gadugi", 12F);
            button_status.Location = new Point(5, 120);
            button_status.Name = "button_status";
            button_status.Size = new Size(195, 35);
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
            button_customers.Font = new Font("Gadugi", 12F);
            button_customers.Location = new Point(5, 70);
            button_customers.Name = "button_customers";
            button_customers.Size = new Size(195, 35);
            button_customers.TabIndex = 0;
            button_customers.Text = "👤 Customers";
            button_customers.TextAlign = ContentAlignment.MiddleLeft;
            button_customers.UseVisualStyleBackColor = true;
            button_customers.Click += button_customers_Click;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaption;
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(button_notif);
            panel3.Controls.Add(pictureBox2);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label4);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(945, 60);
            panel3.TabIndex = 3;
            panel3.Paint += panel3_Paint;
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
            button_notif.Location = new Point(881, 10);
            button_notif.Name = "button_notif";
            button_notif.Size = new Size(50, 40);
            button_notif.TabIndex = 7;
            button_notif.Text = "🔔";
            button_notif.UseVisualStyleBackColor = true;
            button_notif.Click += button_notif_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(6, 4);
            pictureBox2.Margin = new Padding(2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(50, 47);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cascadia Code", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.RoyalBlue;
            label3.Location = new Point(168, 8);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(70, 32);
            label3.TabIndex = 4;
            label3.Text = "Care";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cascadia Code", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(58, 7);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(120, 33);
            label4.TabIndex = 5;
            label4.Text = "Laundry";
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
            Text = "Laundry Attendant | Template";
            Load += Laundry_Attendant_Template_Load;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button_customers;
        private Button button_status;
        private Button button_dashboard;
        private Button button3;
        private Button button_feedback;
        private Panel panel3;
        private PictureBox pictureBox2;
        private Label label3;
        private Label label4;
        private Button button_logout;
        private Button button_notif;
    }
}