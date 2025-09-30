namespace IT13___Laundry_CRM.Admin
{
    partial class admin_messages
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
            combobox_users = new ComboBox();
            listbox_messages = new ListBox();
            textbox_message = new TextBox();
            button_send = new Button();
            button_edit = new Button();
            button_delete = new Button();
            SuspendLayout();
            // 
            // combobox_users
            // 
            combobox_users.FormattingEnabled = true;
            combobox_users.Location = new Point(404, 109);
            combobox_users.Name = "combobox_users";
            combobox_users.Size = new Size(270, 30);
            combobox_users.TabIndex = 2;
            combobox_users.SelectedIndexChanged += combobox_users_SelectedIndexChanged;
            // 
            // listbox_messages
            // 
            listbox_messages.FormattingEnabled = true;
            listbox_messages.ItemHeight = 22;
            listbox_messages.Location = new Point(404, 169);
            listbox_messages.Name = "listbox_messages";
            listbox_messages.Size = new Size(455, 158);
            listbox_messages.TabIndex = 3;
            // 
            // textbox_message
            // 
            textbox_message.Location = new Point(408, 352);
            textbox_message.Name = "textbox_message";
            textbox_message.Size = new Size(246, 27);
            textbox_message.TabIndex = 4;
            // 
            // button_send
            // 
            button_send.Location = new Point(411, 402);
            button_send.Name = "button_send";
            button_send.Size = new Size(94, 29);
            button_send.TabIndex = 5;
            button_send.Text = "Send";
            button_send.UseVisualStyleBackColor = true;
            button_send.Click += button_send_Click;
            // 
            // button_edit
            // 
            button_edit.Location = new Point(533, 400);
            button_edit.Name = "button_edit";
            button_edit.Size = new Size(94, 29);
            button_edit.TabIndex = 6;
            button_edit.Text = "Edit";
            button_edit.UseVisualStyleBackColor = true;
            button_edit.Click += button_edit_Click;
            // 
            // button_delete
            // 
            button_delete.Location = new Point(653, 399);
            button_delete.Name = "button_delete";
            button_delete.Size = new Size(94, 29);
            button_delete.TabIndex = 7;
            button_delete.Text = "Delete";
            button_delete.UseVisualStyleBackColor = true;
            button_delete.Click += button_delete_Click;
            // 
            // admin_messages
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 495);
            Controls.Add(button_delete);
            Controls.Add(button_edit);
            Controls.Add(button_send);
            Controls.Add(textbox_message);
            Controls.Add(listbox_messages);
            Controls.Add(combobox_users);
            Margin = new Padding(4, 2, 4, 2);
            Name = "admin_messages";
            Text = "admin_messages";
            Load += admin_messages_Load;
            Controls.SetChildIndex(combobox_users, 0);
            Controls.SetChildIndex(listbox_messages, 0);
            Controls.SetChildIndex(textbox_message, 0);
            Controls.SetChildIndex(button_send, 0);
            Controls.SetChildIndex(button_edit, 0);
            Controls.SetChildIndex(button_delete, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox combobox_users;
        private ListBox listbox_messages;
        private TextBox textbox_message;
        private Button button_send;
        private Button button_edit;
        private Button button_delete;
    }
}