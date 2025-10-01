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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // combobox_customer
            // 
            combobox_customer.FormattingEnabled = true;
            combobox_customer.Location = new Point(22, 36);
            combobox_customer.Margin = new Padding(4);
            combobox_customer.Name = "combobox_customer";
            combobox_customer.Size = new Size(244, 33);
            combobox_customer.TabIndex = 0;
            // 
            // combobox_status
            // 
            combobox_status.FormattingEnabled = true;
            combobox_status.Location = new Point(22, 97);
            combobox_status.Margin = new Padding(4);
            combobox_status.Name = "combobox_status";
            combobox_status.Size = new Size(244, 33);
            combobox_status.TabIndex = 1;
            // 
            // button_save
            // 
            button_save.BackColor = SystemColors.MenuHighlight;
            button_save.ForeColor = SystemColors.ButtonHighlight;
            button_save.Location = new Point(52, 223);
            button_save.Margin = new Padding(4);
            button_save.Name = "button_save";
            button_save.Size = new Size(118, 36);
            button_save.TabIndex = 2;
            button_save.Text = "Save";
            button_save.UseVisualStyleBackColor = false;
            button_save.Click += button_save_Click;
            // 
            // button_cancel
            // 
            button_cancel.FlatAppearance.BorderSize = 0;
            button_cancel.FlatStyle = FlatStyle.Flat;
            button_cancel.Location = new Point(178, 223);
            button_cancel.Margin = new Padding(4);
            button_cancel.Name = "button_cancel";
            button_cancel.Size = new Size(118, 36);
            button_cancel.TabIndex = 3;
            button_cancel.Text = "Cancel";
            button_cancel.UseVisualStyleBackColor = true;
            button_cancel.Click += button_cancel_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(combobox_status);
            panel1.Controls.Add(button_cancel);
            panel1.Controls.Add(combobox_customer);
            panel1.Controls.Add(button_save);
            panel1.Location = new Point(61, 125);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 302);
            panel1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(408, 104);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(362, 323);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Code SemiBold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(12, 47);
            label1.Name = "label1";
            label1.Size = new Size(330, 43);
            label1.TabIndex = 6;
            label1.Text = "⌚ Change Status";
            // 
            // create_edit_status
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(832, 476);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Margin = new Padding(4);
            Name = "create_edit_status";
            Text = "create_edit_status";
            Load += create_edit_status_Load;
            panel1.ResumeLayout(false);
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
    }
}