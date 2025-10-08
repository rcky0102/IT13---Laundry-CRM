namespace IT13___Laundry_CRM.Laundry_Attendant
{
    partial class create_edit_status
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(create_edit_status));
            combobox_customer = new ComboBox();
            combobox_status = new ComboBox();
            button_save = new Button();
            button_cancel = new Button();
            panel1 = new Panel();
            label3 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label4 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // combobox_customer
            // 
            combobox_customer.Font = new Font("Cascadia Code SemiBold", 10.8F, FontStyle.Bold);
            combobox_customer.FormattingEnabled = true;
            combobox_customer.Location = new Point(48, 80);
            combobox_customer.Name = "combobox_customer";
            combobox_customer.Size = new Size(276, 32);
            combobox_customer.TabIndex = 0;
            // 
            // combobox_status
            // 
            combobox_status.Font = new Font("Cascadia Code SemiBold", 10.8F, FontStyle.Bold);
            combobox_status.FormattingEnabled = true;
            combobox_status.Location = new Point(48, 193);
            combobox_status.Name = "combobox_status";
            combobox_status.Size = new Size(276, 32);
            combobox_status.TabIndex = 1;
            // 
            // button_save
            // 
            button_save.BackColor = SystemColors.MenuHighlight;
            button_save.Font = new Font("Cascadia Code SemiBold", 10.8F, FontStyle.Bold);
            button_save.ForeColor = SystemColors.ButtonHighlight;
            button_save.Location = new Point(79, 373);
            button_save.Name = "button_save";
            button_save.Size = new Size(100, 35);
            button_save.TabIndex = 2;
            button_save.Text = "Save";
            button_save.UseVisualStyleBackColor = false;
            button_save.Click += button_save_Click;
            // 
            // button_cancel
            // 
            button_cancel.BackColor = SystemColors.Control;
            button_cancel.FlatAppearance.BorderSize = 0;
            button_cancel.FlatStyle = FlatStyle.Flat;
            button_cancel.Font = new Font("Cascadia Code SemiBold", 10.8F, FontStyle.Bold);
            button_cancel.Location = new Point(196, 375);
            button_cancel.Name = "button_cancel";
            button_cancel.Size = new Size(100, 30);
            button_cancel.TabIndex = 3;
            button_cancel.Text = "Cancel";
            button_cancel.UseVisualStyleBackColor = false;
            button_cancel.Click += button_cancel_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientInactiveCaption;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(combobox_status);
            panel1.Controls.Add(button_cancel);
            panel1.Controls.Add(combobox_customer);
            panel1.Controls.Add(button_save);
            panel1.Location = new Point(57, 126);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(376, 450);
            panel1.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cascadia Code SemiBold", 10.8F, FontStyle.Bold);
            label3.Location = new Point(132, 151);
            label3.Name = "label3";
            label3.Size = new Size(87, 24);
            label3.TabIndex = 5;
            label3.Text = "Status:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cascadia Code SemiBold", 10.8F, FontStyle.Bold);
            label2.Location = new Point(79, 37);
            label2.Name = "label2";
            label2.Size = new Size(186, 24);
            label2.TabIndex = 4;
            label2.Text = "Select Customer:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(437, 126);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(290, 450);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Code SemiBold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(39, 18);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(388, 35);
            label1.TabIndex = 6;
            label1.Text = "⌚ Record/Update Status";
            label1.Click += label1_Click;
            // 
            // label4
            // 
            label4.Font = new Font("Cascadia Code SemiLight", 8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(107, 64);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(543, 41);
            label4.TabIndex = 7;
            label4.Text = "Record or modify the current progress of your laundry orders, keeping your workflow accurate and up-to-date.";
            // 
            // create_edit_status
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(782, 603);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Name = "create_edit_status";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Laundry Attendant | Create/Edit Status";
            Load += create_edit_status_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox combobox_customer;
        private ComboBox combobox_status;
        private Button button_save;
        private Button button_cancel;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label3;
        private Label label2;
        private Label label4;
    }
}