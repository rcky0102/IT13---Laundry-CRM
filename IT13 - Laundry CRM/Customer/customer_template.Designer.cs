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
            panel2 = new Panel();
            label3 = new Label();
            label4 = new Label();
            pictureBox2 = new PictureBox();
            button_feedback = new Button();
            button_message = new Button();
            button_status = new Button();
            button1 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(button_feedback);
            panel1.Controls.Add(button_message);
            panel1.Controls.Add(button_status);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Left;
            panel1.Font = new Font("Cascadia Code SemiLight", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(240, 562);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(pictureBox2);
            panel2.Location = new Point(2, 2);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(238, 110);
            panel2.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cascadia Code", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.RoyalBlue;
            label3.Location = new Point(150, 51);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(81, 37);
            label3.TabIndex = 1;
            label3.Text = "Care";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cascadia Code", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(94, 8);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(152, 43);
            label4.TabIndex = 1;
            label4.Text = "Laundry";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 8);
            pictureBox2.Margin = new Padding(2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 91);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // button_feedback
            // 
            button_feedback.FlatAppearance.BorderSize = 0;
            button_feedback.FlatStyle = FlatStyle.Flat;
            button_feedback.ForeColor = SystemColors.ButtonHighlight;
            button_feedback.Location = new Point(36, 346);
            button_feedback.Margin = new Padding(4);
            button_feedback.Name = "button_feedback";
            button_feedback.Size = new Size(194, 36);
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
            button_message.ForeColor = SystemColors.ButtonHighlight;
            button_message.Location = new Point(36, 262);
            button_message.Margin = new Padding(4);
            button_message.Name = "button_message";
            button_message.Size = new Size(194, 55);
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
            button_status.ForeColor = SystemColors.ButtonHighlight;
            button_status.Location = new Point(36, 200);
            button_status.Margin = new Padding(4);
            button_status.Name = "button_status";
            button_status.Size = new Size(194, 36);
            button_status.TabIndex = 1;
            button_status.Text = "⌚ Status";
            button_status.TextAlign = ContentAlignment.MiddleLeft;
            button_status.UseVisualStyleBackColor = true;
            button_status.Click += button_status_Click;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(46, 135);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(194, 36);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = true;
            // 
            // customer_template
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1181, 562);
            Controls.Add(panel1);
            Margin = new Padding(4);
            Name = "customer_template";
            Text = "customer_template";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Button button_status;
        private Button button_message;
        private Button button_feedback;
        private Panel panel2;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox2;
    }
}