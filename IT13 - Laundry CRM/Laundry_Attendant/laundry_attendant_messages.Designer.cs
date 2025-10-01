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
            panel3 = new Panel();
            label3 = new Label();
            label4 = new Label();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // textbox_message
            // 
            textbox_message.BorderStyle = BorderStyle.FixedSingle;
            textbox_message.Location = new Point(263, 493);
            textbox_message.Margin = new Padding(4);
            textbox_message.Multiline = true;
            textbox_message.Name = "textbox_message";
            textbox_message.Size = new Size(823, 54);
            textbox_message.TabIndex = 0;
            // 
            // button_send
            // 
            button_send.BackColor = SystemColors.MenuHighlight;
            button_send.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_send.ForeColor = SystemColors.ButtonHighlight;
            button_send.Location = new Point(1094, 499);
            button_send.Margin = new Padding(4);
            button_send.Name = "button_send";
            button_send.Size = new Size(74, 46);
            button_send.TabIndex = 1;
            button_send.Text = "📩";
            button_send.UseVisualStyleBackColor = false;
            button_send.Click += button_send_Click;
            // 
            // listbox_messages
            // 
            listbox_messages.FormattingEnabled = true;
            listbox_messages.ItemHeight = 25;
            listbox_messages.Location = new Point(260, 156);
            listbox_messages.Margin = new Padding(4);
            listbox_messages.Name = "listbox_messages";
            listbox_messages.Size = new Size(908, 329);
            listbox_messages.TabIndex = 2;
            // 
            // combobox_users
            // 
            combobox_users.FormattingEnabled = true;
            combobox_users.Location = new Point(4, 10);
            combobox_users.Margin = new Padding(4);
            combobox_users.Name = "combobox_users";
            combobox_users.Size = new Size(389, 33);
            combobox_users.TabIndex = 3;
            combobox_users.SelectedIndexChanged += combobox_users_SelectedIndexChanged;
            // 
            // button_edit
            // 
            button_edit.BackColor = Color.LimeGreen;
            button_edit.ForeColor = SystemColors.HighlightText;
            button_edit.Location = new Point(772, 7);
            button_edit.Margin = new Padding(4);
            button_edit.Name = "button_edit";
            button_edit.Size = new Size(52, 36);
            button_edit.TabIndex = 4;
            button_edit.Text = "✏️";
            button_edit.UseVisualStyleBackColor = false;
            button_edit.Click += button_edit_Click;
            // 
            // button_delete
            // 
            button_delete.BackColor = Color.IndianRed;
            button_delete.ForeColor = SystemColors.ButtonHighlight;
            button_delete.Location = new Point(832, 7);
            button_delete.Margin = new Padding(4);
            button_delete.Name = "button_delete";
            button_delete.Size = new Size(49, 36);
            button_delete.TabIndex = 5;
            button_delete.Text = "🗑️";
            button_delete.UseVisualStyleBackColor = false;
            button_delete.Click += button_delete_Click;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaption;
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(combobox_users);
            panel3.Controls.Add(button_delete);
            panel3.Controls.Add(button_edit);
            panel3.Location = new Point(260, 90);
            panel3.Name = "panel3";
            panel3.Size = new Size(908, 59);
            panel3.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ButtonHighlight;
            label3.Font = new Font("Cascadia Code SemiBold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaption;
            label3.Location = new Point(266, 9);
            label3.Name = "label3";
            label3.Size = new Size(178, 43);
            label3.TabIndex = 7;
            label3.Text = "🔔 Inbox";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cascadia Code SemiLight", 8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ActiveCaption;
            label4.Location = new Point(338, 52);
            label4.Name = "label4";
            label4.Size = new Size(361, 21);
            label4.TabIndex = 8;
            label4.Text = "“Manage all conversations efficiently.”";
            // 
            // laundry_attendant_messages
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1181, 562);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(listbox_messages);
            Controls.Add(button_send);
            Controls.Add(textbox_message);
            Controls.Add(panel3);
            Margin = new Padding(5);
            Name = "laundry_attendant_messages";
            Text = "laundry_attendant_messages";
            Load += laundry_attendant_messages_Load;
            Controls.SetChildIndex(panel3, 0);
            Controls.SetChildIndex(textbox_message, 0);
            Controls.SetChildIndex(button_send, 0);
            Controls.SetChildIndex(listbox_messages, 0);
            Controls.SetChildIndex(label3, 0);
            Controls.SetChildIndex(label4, 0);
            panel3.ResumeLayout(false);
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
        private Panel panel3;
        private Label label3;
        private Label label4;
    }
}