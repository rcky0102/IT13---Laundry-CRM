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
            combobox_customer = new ComboBox();
            combobox_status = new ComboBox();
            button_save = new Button();
            button_cancel = new Button();
            panel1 = new Panel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // combobox_customer
            // 
            combobox_customer.Font = new Font("Gadugi", 9F);
            combobox_customer.FormattingEnabled = true;
            combobox_customer.Location = new Point(60, 76);
            combobox_customer.Margin = new Padding(4, 4, 4, 4);
            combobox_customer.Name = "combobox_customer";
            combobox_customer.Size = new Size(344, 29);
            combobox_customer.TabIndex = 0;
            // 
            // combobox_status
            // 
            combobox_status.Font = new Font("Gadugi", 9F);
            combobox_status.FormattingEnabled = true;
            combobox_status.Location = new Point(60, 175);
            combobox_status.Margin = new Padding(4, 4, 4, 4);
            combobox_status.Name = "combobox_status";
            combobox_status.Size = new Size(344, 29);
            combobox_status.TabIndex = 1;
            // 
            // button_save
            // 
            button_save.BackColor = SystemColors.MenuHighlight;
            button_save.Font = new Font("Gadugi", 10F);
            button_save.ForeColor = SystemColors.ButtonHighlight;
            button_save.Location = new Point(331, 239);
            button_save.Margin = new Padding(4, 4, 4, 4);
            button_save.Name = "button_save";
            button_save.Size = new Size(125, 44);
            button_save.TabIndex = 2;
            button_save.Text = "Save";
            button_save.UseVisualStyleBackColor = false;
            button_save.Click += button_save_Click;
            // 
            // button_cancel
            // 
            button_cancel.BackColor = SystemColors.ButtonHighlight;
            button_cancel.FlatAppearance.BorderSize = 0;
            button_cancel.FlatStyle = FlatStyle.Flat;
            button_cancel.Font = new Font("Gadugi", 10F);
            button_cancel.Location = new Point(198, 239);
            button_cancel.Margin = new Padding(4, 4, 4, 4);
            button_cancel.Name = "button_cancel";
            button_cancel.Size = new Size(125, 38);
            button_cancel.TabIndex = 3;
            button_cancel.Text = "Cancel";
            button_cancel.UseVisualStyleBackColor = false;
            button_cancel.Click += button_cancel_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(combobox_status);
            panel1.Controls.Add(button_cancel);
            panel1.Controls.Add(combobox_customer);
            panel1.Controls.Add(button_save);
            panel1.Location = new Point(11, 92);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(469, 316);
            panel1.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Gadugi", 9F);
            label3.Location = new Point(33, 134);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(63, 21);
            label3.TabIndex = 5;
            label3.Text = "Status:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Gadugi", 9F);
            label2.Location = new Point(33, 36);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(142, 21);
            label2.TabIndex = 4;
            label2.Text = "Select Customer:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gadugi", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(-1, 25);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(394, 38);
            label1.TabIndex = 6;
            label1.Text = "⌚ Record/Update Status";
            label1.Click += label1_Click;
            // 
            // create_edit_status
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(483, 404);
            Controls.Add(label1);
            Controls.Add(panel1);
            Margin = new Padding(4, 4, 4, 4);
            Name = "create_edit_status";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Laundry Attendant | Create/Edit Status";
            Load += create_edit_status_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox combobox_customer;
        private ComboBox combobox_status;
        private Button button_save;
        private Button button_cancel;
        private Panel panel1;
        private Label label1;
        private Label label3;
        private Label label2;
    }
}