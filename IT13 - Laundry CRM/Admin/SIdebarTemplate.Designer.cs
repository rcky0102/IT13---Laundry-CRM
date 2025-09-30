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
            button3 = new Button();
            button_messages = new Button();
            button_users = new Button();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel2 = new Panel();
            button_feedback = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(button_feedback);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button_messages);
            panel1.Controls.Add(button_users);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 99);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(279, 641);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(62, 525);
            button3.Margin = new Padding(4, 3, 4, 3);
            button3.Name = "button3";
            button3.Size = new Size(209, 43);
            button3.TabIndex = 3;
            button3.Text = "🚪Log Out";
            button3.TextAlign = ContentAlignment.MiddleRight;
            button3.UseVisualStyleBackColor = true;
            // 
            // button_messages
            // 
            button_messages.FlatAppearance.BorderSize = 0;
            button_messages.FlatStyle = FlatStyle.Flat;
            button_messages.ForeColor = SystemColors.ButtonHighlight;
            button_messages.Location = new Point(41, 172);
            button_messages.Margin = new Padding(4, 3, 4, 3);
            button_messages.Name = "button_messages";
            button_messages.Size = new Size(155, 50);
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
            button_users.ForeColor = SystemColors.ButtonHighlight;
            button_users.ImageAlign = ContentAlignment.MiddleLeft;
            button_users.Location = new Point(30, 119);
            button_users.Margin = new Padding(4, 3, 4, 3);
            button_users.Name = "button_users";
            button_users.Size = new Size(132, 43);
            button_users.TabIndex = 1;
            button_users.Text = "👤Users";
            button_users.UseVisualStyleBackColor = true;
            button_users.Click += button_users_Click;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(30, 61);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(209, 43);
            button1.TabIndex = 0;
            button1.Text = " 📺 DashBoard";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(13, 4);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(102, 89);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Code", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(123, 18);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(264, 49);
            label1.TabIndex = 3;
            label1.Text = "LaundryCare";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(1578, 99);
            panel2.TabIndex = 1;
            // 
            // button_feedback
            // 
            button_feedback.FlatAppearance.BorderSize = 0;
            button_feedback.FlatStyle = FlatStyle.Flat;
            button_feedback.ForeColor = SystemColors.ButtonHighlight;
            button_feedback.Location = new Point(30, 244);
            button_feedback.Margin = new Padding(4, 3, 4, 3);
            button_feedback.Name = "button_feedback";
            button_feedback.Size = new Size(155, 50);
            button_feedback.TabIndex = 4;
            button_feedback.Text = "📩 Feedback";
            button_feedback.TextAlign = ContentAlignment.MiddleLeft;
            button_feedback.UseVisualStyleBackColor = true;
            button_feedback.Click += button_feedback_Click;
            // 
            // SIdebarTemplate
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1578, 740);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Font = new Font("Cascadia Code", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "SIdebarTemplate";
            Text = "SIdebarTemplate";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button_users;
        private Button button1;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Button button_messages;
        private Button button3;
        private Button button_feedback;
    }
}