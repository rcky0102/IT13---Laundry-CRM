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
            SuspendLayout();
            // 
            // combobox_customer
            // 
            combobox_customer.FormattingEnabled = true;
            combobox_customer.Location = new Point(148, 95);
            combobox_customer.Name = "combobox_customer";
            combobox_customer.Size = new Size(151, 28);
            combobox_customer.TabIndex = 0;
            // 
            // combobox_status
            // 
            combobox_status.FormattingEnabled = true;
            combobox_status.Location = new Point(388, 95);
            combobox_status.Name = "combobox_status";
            combobox_status.Size = new Size(151, 28);
            combobox_status.TabIndex = 1;
            // 
            // button_save
            // 
            button_save.Location = new Point(240, 229);
            button_save.Name = "button_save";
            button_save.Size = new Size(94, 29);
            button_save.TabIndex = 2;
            button_save.Text = "Save";
            button_save.UseVisualStyleBackColor = true;
            button_save.Click += button_save_Click;
            // 
            // button_cancel
            // 
            button_cancel.Location = new Point(400, 229);
            button_cancel.Name = "button_cancel";
            button_cancel.Size = new Size(94, 29);
            button_cancel.TabIndex = 3;
            button_cancel.Text = "Cancel";
            button_cancel.UseVisualStyleBackColor = true;
            button_cancel.Click += button_cancel_Click;
            // 
            // create_edit_status
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_cancel);
            Controls.Add(button_save);
            Controls.Add(combobox_status);
            Controls.Add(combobox_customer);
            Name = "create_edit_status";
            Text = "create_edit_status";
            Load += create_edit_status_Load;
            ResumeLayout(false);
        }

        #endregion

        private ComboBox combobox_customer;
        private ComboBox combobox_status;
        private Button button_save;
        private Button button_cancel;
    }
}