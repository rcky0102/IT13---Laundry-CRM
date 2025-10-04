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
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // combobox_users
            // 
            combobox_users.FormattingEnabled = true;
            combobox_users.Location = new Point(297, 199);
            combobox_users.Margin = new Padding(4, 4, 4, 4);
            combobox_users.Name = "combobox_users";
            combobox_users.Size = new Size(323, 35);
            combobox_users.TabIndex = 2;
            combobox_users.SelectedIndexChanged += combobox_users_SelectedIndexChanged;
            // 
            // listbox_messages
            // 
            listbox_messages.FormattingEnabled = true;
            listbox_messages.ItemHeight = 27;
            listbox_messages.Location = new Point(297, 239);
            listbox_messages.Margin = new Padding(4, 4, 4, 4);
            listbox_messages.Name = "listbox_messages";
            listbox_messages.Size = new Size(890, 274);
            listbox_messages.TabIndex = 3;
            // 
            // textbox_message
            // 
            textbox_message.Location = new Point(297, 521);
            textbox_message.Margin = new Padding(4, 4, 4, 4);
            textbox_message.Multiline = true;
            textbox_message.Name = "textbox_message";
            textbox_message.Size = new Size(805, 74);
            textbox_message.TabIndex = 4;
            // 
            // button_send
            // 
            button_send.BackColor = SystemColors.HotTrack;
            button_send.ForeColor = SystemColors.InactiveBorder;
            button_send.Location = new Point(1110, 536);
            button_send.Margin = new Padding(4, 4, 4, 4);
            button_send.Name = "button_send";
            button_send.Size = new Size(82, 47);
            button_send.TabIndex = 5;
            button_send.Text = "📩";
            button_send.UseVisualStyleBackColor = false;
            button_send.Click += button_send_Click;
            // 
            // button_edit
            // 
            button_edit.BackColor = Color.LimeGreen;
            button_edit.Location = new Point(1065, 196);
            button_edit.Margin = new Padding(4, 4, 4, 4);
            button_edit.Name = "button_edit";
            button_edit.Size = new Size(55, 36);
            button_edit.TabIndex = 6;
            button_edit.Text = "✏️";
            button_edit.UseVisualStyleBackColor = false;
            button_edit.Click += button_edit_Click;
            // 
            // button_delete
            // 
            button_delete.BackColor = Color.IndianRed;
            button_delete.Location = new Point(1128, 196);
            button_delete.Margin = new Padding(4, 4, 4, 4);
            button_delete.Name = "button_delete";
            button_delete.Size = new Size(59, 38);
            button_delete.TabIndex = 7;
            button_delete.Text = "🗑️";
            button_delete.UseVisualStyleBackColor = false;
            button_delete.Click += button_delete_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cascadia Code", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(296, 90);
            label3.Name = "label3";
            label3.Size = new Size(348, 43);
            label3.TabIndex = 8;
            label3.Text = "📩 Admin Messages";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.Font = new Font("Cascadia Code SemiLight", 8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(361, 133);
            label4.Name = "label4";
            label4.Size = new Size(826, 47);
            label4.TabIndex = 9;
            label4.Text = "\"View, manage, and respond to customer messages efficiently, ensuring clear communication and timely support.\"";
            // 
            // admin_messages
            // 
            AutoScaleDimensions = new SizeF(12F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 608);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button_delete);
            Controls.Add(button_edit);
            Controls.Add(button_send);
            Controls.Add(textbox_message);
            Controls.Add(listbox_messages);
            Controls.Add(combobox_users);
            Margin = new Padding(5, 2, 5, 2);
            Name = "admin_messages";
            Text = "admin_messages";
            Load += admin_messages_Load;
            Controls.SetChildIndex(combobox_users, 0);
            Controls.SetChildIndex(listbox_messages, 0);
            Controls.SetChildIndex(textbox_message, 0);
            Controls.SetChildIndex(button_send, 0);
            Controls.SetChildIndex(button_edit, 0);
            Controls.SetChildIndex(button_delete, 0);
            Controls.SetChildIndex(label3, 0);
            Controls.SetChildIndex(label4, 0);
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
        private Label label3;
        private Label label4;
    }
}