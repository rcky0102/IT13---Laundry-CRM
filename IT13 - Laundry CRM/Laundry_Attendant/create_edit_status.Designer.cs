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
            combobox_customer.Location = new Point(270, 119);
            combobox_customer.Margin = new Padding(4, 4, 4, 4);
            combobox_customer.Name = "combobox_customer";
            combobox_customer.Size = new Size(188, 33);
            combobox_customer.TabIndex = 0;
            // 
            // combobox_status
            // 
            combobox_status.FormattingEnabled = true;
            combobox_status.Location = new Point(485, 119);
            combobox_status.Margin = new Padding(4, 4, 4, 4);
            combobox_status.Name = "combobox_status";
            combobox_status.Size = new Size(188, 33);
            combobox_status.TabIndex = 1;
            // 
            // button_save
            // 
            button_save.Location = new Point(300, 286);
            button_save.Margin = new Padding(4, 4, 4, 4);
            button_save.Name = "button_save";
            button_save.Size = new Size(118, 36);
            button_save.TabIndex = 2;
            button_save.Text = "Save";
            button_save.UseVisualStyleBackColor = true;
            button_save.Click += button_save_Click;
            // 
            // button_cancel
            // 
            button_cancel.Location = new Point(555, 286);
            button_cancel.Margin = new Padding(4, 4, 4, 4);
            button_cancel.Name = "button_cancel";
            button_cancel.Size = new Size(118, 36);
            button_cancel.TabIndex = 3;
            button_cancel.Text = "Cancel";
            button_cancel.UseVisualStyleBackColor = true;
            button_cancel.Click += button_cancel_Click;
            // 
            // create_edit_status
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 562);
            Controls.Add(button_cancel);
            Controls.Add(button_save);
            Controls.Add(combobox_status);
            Controls.Add(combobox_customer);
            Margin = new Padding(4, 4, 4, 4);
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