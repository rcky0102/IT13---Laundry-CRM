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
            button_feedback = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            button_status = new Button();
            button_customers = new Button();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(button_feedback);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button_status);
            panel1.Controls.Add(button_customers);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Font = new Font("Cascadia Code SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel1.ForeColor = SystemColors.ButtonHighlight;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(252, 562);
            panel1.TabIndex = 0;
            // 
            // button_feedback
            // 
            button_feedback.FlatAppearance.BorderSize = 0;
            button_feedback.FlatStyle = FlatStyle.Flat;
            button_feedback.Font = new Font("Cascadia Code SemiLight", 12F);
            button_feedback.Location = new Point(3, 393);
            button_feedback.Margin = new Padding(2);
            button_feedback.Name = "button_feedback";
            button_feedback.Size = new Size(214, 46);
            button_feedback.TabIndex = 4;
            button_feedback.Text = "📲 Feedbacks";
            button_feedback.UseVisualStyleBackColor = true;
            button_feedback.Click += button_feedback_Click;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Cascadia Code SemiLight", 12F);
            button3.Location = new Point(-2, 322);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.Size = new Size(214, 46);
            button3.TabIndex = 3;
            button3.Text = "📩 Messages";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Cascadia Code", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(76, 503);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(168, 46);
            button2.TabIndex = 2;
            button2.Text = "🚪Log Out";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Cascadia Code SemiLight", 12F);
            button1.Location = new Point(0, 139);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(212, 46);
            button1.TabIndex = 2;
            button1.Text = "🏠DashBoard";
            button1.UseVisualStyleBackColor = true;
            // 
            // button_status
            // 
            button_status.FlatAppearance.BorderSize = 0;
            button_status.FlatStyle = FlatStyle.Flat;
            button_status.Font = new Font("Cascadia Code SemiLight", 12F);
            button_status.Location = new Point(-2, 266);
            button_status.Margin = new Padding(4);
            button_status.Name = "button_status";
            button_status.Size = new Size(169, 36);
            button_status.TabIndex = 1;
            button_status.Text = "⌚Status";
            button_status.UseVisualStyleBackColor = true;
            button_status.Click += button_status_Click;
            // 
            // button_customers
            // 
            button_customers.FlatAppearance.BorderSize = 0;
            button_customers.FlatStyle = FlatStyle.Flat;
            button_customers.Font = new Font("Cascadia Code SemiLight", 12F);
            button_customers.Location = new Point(1, 204);
            button_customers.Margin = new Padding(4);
            button_customers.Name = "button_customers";
            button_customers.Size = new Size(211, 44);
            button_customers.TabIndex = 0;
            button_customers.Text = "👤Customers";
            button_customers.UseVisualStyleBackColor = true;
            button_customers.Click += button_customers_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(-2, 2);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(252, 110);
            panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 8);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 91);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cascadia Code", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.RoyalBlue;
            label2.Location = new Point(146, 51);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(81, 37);
            label2.TabIndex = 1;
            label2.Text = "Care";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Code", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(90, 8);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(152, 43);
            label1.TabIndex = 1;
            label1.Text = "Laundry";
            // 
            // Laundry_Attendant_Template
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1181, 562);
            Controls.Add(panel1);
            Margin = new Padding(4);
            Name = "Laundry_Attendant_Template";
            Text = "Laundry_Attendant_Template";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button_customers;
        private Button button_status;
        private Button button2;
        private Button button1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Panel panel2;
        private Button button3;
        private Button button_feedback;
    }
}