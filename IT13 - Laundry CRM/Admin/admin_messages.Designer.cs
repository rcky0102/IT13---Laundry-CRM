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
            panel3 = new Panel();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // combobox_users
            // 
            combobox_users.BackColor = SystemColors.ButtonFace;
            combobox_users.FormattingEnabled = true;
            combobox_users.Location = new Point(35, 22);
            combobox_users.Margin = new Padding(4, 4, 4, 4);
            combobox_users.Name = "combobox_users";
            combobox_users.Size = new Size(479, 35);
            combobox_users.TabIndex = 2;
            combobox_users.SelectedIndexChanged += combobox_users_SelectedIndexChanged;
            // 
            // listbox_messages
            // 
            listbox_messages.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listbox_messages.FormattingEnabled = true;
            listbox_messages.ItemHeight = 27;
            listbox_messages.Location = new Point(270, 204);
            listbox_messages.Margin = new Padding(4, 4, 4, 4);
            listbox_messages.Name = "listbox_messages";
            listbox_messages.Size = new Size(893, 328);
            listbox_messages.TabIndex = 3;
            listbox_messages.DrawItem += listbox_messages_DrawItem;
            listbox_messages.MeasureItem += listbox_messages_MeasureItem;
            // 
            // textbox_message
            // 
            textbox_message.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textbox_message.Location = new Point(270, 544);
            textbox_message.Margin = new Padding(4, 4, 4, 4);
            textbox_message.Multiline = true;
            textbox_message.Name = "textbox_message";
            textbox_message.Size = new Size(804, 48);
            textbox_message.TabIndex = 4;
            // 
            // button_send
            // 
            button_send.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_send.BackColor = SystemColors.HotTrack;
            button_send.ForeColor = SystemColors.InactiveBorder;
            button_send.Location = new Point(1092, 544);
            button_send.Margin = new Padding(4, 4, 4, 4);
            button_send.Name = "button_send";
            button_send.Size = new Size(72, 49);
            button_send.TabIndex = 5;
            button_send.Text = "📩";
            button_send.UseVisualStyleBackColor = false;
            button_send.Click += button_send_Click;
            // 
            // button_edit
            // 
            button_edit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_edit.BackColor = Color.ForestGreen;
            button_edit.ForeColor = SystemColors.ButtonHighlight;
            button_edit.Location = new Point(743, 15);
            button_edit.Margin = new Padding(4, 4, 4, 4);
            button_edit.Name = "button_edit";
            button_edit.Size = new Size(60, 49);
            button_edit.TabIndex = 6;
            button_edit.Text = "✏️";
            button_edit.UseVisualStyleBackColor = false;
            button_edit.Click += button_edit_Click;
            // 
            // button_delete
            // 
            button_delete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_delete.BackColor = Color.IndianRed;
            button_delete.ForeColor = SystemColors.ButtonHighlight;
            button_delete.Location = new Point(810, 15);
            button_delete.Margin = new Padding(4, 4, 4, 4);
            button_delete.Name = "button_delete";
            button_delete.Size = new Size(60, 49);
            button_delete.TabIndex = 7;
            button_delete.Text = "🗑️";
            button_delete.UseVisualStyleBackColor = false;
            button_delete.Click += button_delete_Click;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = SystemColors.ActiveCaption;
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(combobox_users);
            panel3.Controls.Add(button_edit);
            panel3.Controls.Add(button_delete);
            panel3.Location = new Point(270, 100);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(893, 85);
            panel3.TabIndex = 10;
            // 
            // admin_messages
            // 
            AutoScaleDimensions = new SizeF(12F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 608);
            Controls.Add(panel3);
            Controls.Add(button_send);
            Controls.Add(textbox_message);
            Controls.Add(listbox_messages);
            Margin = new Padding(5, 2, 5, 2);
            Name = "admin_messages";
            Text = "Admin | Message";
            Load += admin_messages_Load;
            Controls.SetChildIndex(listbox_messages, 0);
            Controls.SetChildIndex(textbox_message, 0);
            Controls.SetChildIndex(button_send, 0);
            Controls.SetChildIndex(panel3, 0);
            panel3.ResumeLayout(false);
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
        private Panel panel3;
    }
}