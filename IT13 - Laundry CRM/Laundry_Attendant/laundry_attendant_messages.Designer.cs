namespace IT13___Laundry_CRM.Laundry_Attendant
{
    partial class laundry_attendant_messages
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
            textbox_message = new TextBox();
            button_send = new Button();
            listbox_messages = new ListBox();
            combobox_users = new ComboBox();
            button_edit = new Button();
            button_delete = new Button();
            SuspendLayout();
            // 
            // textbox_message
            // 
            textbox_message.Location = new Point(283, 275);
            textbox_message.Name = "textbox_message";
            textbox_message.Size = new Size(243, 27);
            textbox_message.TabIndex = 0;
            // 
            // button_send
            // 
            button_send.Location = new Point(283, 317);
            button_send.Name = "button_send";
            button_send.Size = new Size(94, 29);
            button_send.TabIndex = 1;
            button_send.Text = "Send";
            button_send.UseVisualStyleBackColor = true;
            button_send.Click += button_send_Click;
            // 
            // listbox_messages
            // 
            listbox_messages.FormattingEnabled = true;
            listbox_messages.Location = new Point(283, 87);
            listbox_messages.Name = "listbox_messages";
            listbox_messages.Size = new Size(316, 164);
            listbox_messages.TabIndex = 2;
            // 
            // combobox_users
            // 
            combobox_users.FormattingEnabled = true;
            combobox_users.Location = new Point(283, 40);
            combobox_users.Name = "combobox_users";
            combobox_users.Size = new Size(243, 28);
            combobox_users.TabIndex = 3;
            combobox_users.SelectedIndexChanged += combobox_users_SelectedIndexChanged;
            // 
            // button_edit
            // 
            button_edit.Location = new Point(404, 323);
            button_edit.Name = "button_edit";
            button_edit.Size = new Size(94, 29);
            button_edit.TabIndex = 4;
            button_edit.Text = "Edit";
            button_edit.UseVisualStyleBackColor = true;
            button_edit.Click += button_edit_Click;
            // 
            // button_delete
            // 
            button_delete.Location = new Point(533, 320);
            button_delete.Name = "button_delete";
            button_delete.Size = new Size(94, 29);
            button_delete.TabIndex = 5;
            button_delete.Text = "Delete";
            button_delete.UseVisualStyleBackColor = true;
            button_delete.Click += button_delete_Click;
            // 
            // laundry_attendant_messages
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_delete);
            Controls.Add(button_edit);
            Controls.Add(combobox_users);
            Controls.Add(listbox_messages);
            Controls.Add(button_send);
            Controls.Add(textbox_message);
            Name = "laundry_attendant_messages";
            Text = "laundry_attendant_messages";
            Load += laundry_attendant_messages_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textbox_message;
        private Button button_send;
        private ListBox listbox_messages;
        private ComboBox combobox_users;
        private Button button_edit;
        private Button button_delete;
    }
}