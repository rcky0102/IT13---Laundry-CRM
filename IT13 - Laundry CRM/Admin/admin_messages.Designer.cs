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
            listbox_users = new ListBox();
            textbox_message = new TextBox();
            button_send = new Button();
            listbox_messages = new ListBox();
            panel3 = new Panel();
            textbox_searchUser = new TextBox();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // listbox_users
            // 
            listbox_users.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            listbox_users.BackColor = SystemColors.GradientInactiveCaption;
            listbox_users.BorderStyle = BorderStyle.FixedSingle;
            listbox_users.Font = new Font("Gadugi", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listbox_users.FormattingEnabled = true;
            listbox_users.ItemHeight = 34;
            listbox_users.Location = new Point(251, 176);
            listbox_users.Margin = new Padding(4);
            listbox_users.Name = "listbox_users";
            listbox_users.Size = new Size(361, 444);
            listbox_users.TabIndex = 18;
            listbox_users.DrawItem += listbox_users_DrawItem;
            listbox_users.SelectedIndexChanged += listbox_users_SelectedIndexChanged;
            // 
            // textbox_message
            // 
            textbox_message.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textbox_message.BackColor = SystemColors.ButtonHighlight;
            textbox_message.BorderStyle = BorderStyle.FixedSingle;
            textbox_message.Font = new Font("Gadugi", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textbox_message.Location = new Point(620, 579);
            textbox_message.Margin = new Padding(4);
            textbox_message.Multiline = true;
            textbox_message.Name = "textbox_message";
            textbox_message.Size = new Size(549, 41);
            textbox_message.TabIndex = 16;
            // 
            // button_send
            // 
            button_send.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_send.BackColor = SystemColors.HotTrack;
            button_send.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_send.ForeColor = SystemColors.ButtonHighlight;
            button_send.Location = new Point(1175, 579);
            button_send.Margin = new Padding(4);
            button_send.Name = "button_send";
            button_send.Size = new Size(65, 49);
            button_send.TabIndex = 15;
            button_send.Text = "📩";
            button_send.UseVisualStyleBackColor = false;
            button_send.Click += button_send_Click_1;
            // 
            // listbox_messages
            // 
            listbox_messages.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listbox_messages.BackColor = SystemColors.ButtonHighlight;
            listbox_messages.Font = new Font("Gadugi", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listbox_messages.FormattingEnabled = true;
            listbox_messages.ItemHeight = 33;
            listbox_messages.Location = new Point(620, 78);
            listbox_messages.Margin = new Padding(4);
            listbox_messages.Name = "listbox_messages";
            listbox_messages.Size = new Size(621, 499);
            listbox_messages.TabIndex = 14;
            listbox_messages.DrawItem += listbox_messages_DrawItem_1;
            listbox_messages.MeasureItem += listbox_messages_MeasureItem_1;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.GradientInactiveCaption;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(textbox_searchUser);
            panel3.Location = new Point(252, 78);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(361, 92);
            panel3.TabIndex = 17;
            // 
            // textbox_searchUser
            // 
            textbox_searchUser.BackColor = SystemColors.ButtonHighlight;
            textbox_searchUser.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textbox_searchUser.Location = new Point(14, 21);
            textbox_searchUser.Margin = new Padding(4);
            textbox_searchUser.Multiline = true;
            textbox_searchUser.Name = "textbox_searchUser";
            textbox_searchUser.PlaceholderText = "🔍 Search (e.g. John | Doe | Role)";
            textbox_searchUser.Size = new Size(318, 48);
            textbox_searchUser.TabIndex = 8;
            textbox_searchUser.TextChanged += textbox_searchUser_TextChanged;
            // 
            // admin_messages
            // 
            AutoScaleDimensions = new SizeF(12F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1255, 641);
            Controls.Add(listbox_users);
            Controls.Add(textbox_message);
            Controls.Add(button_send);
            Controls.Add(listbox_messages);
            Controls.Add(panel3);
            Margin = new Padding(5, 2, 5, 2);
            Name = "admin_messages";
            Text = "Admin | Message";
            Load += admin_messages_Load;
            Controls.SetChildIndex(panel3, 0);
            Controls.SetChildIndex(listbox_messages, 0);
            Controls.SetChildIndex(button_send, 0);
            Controls.SetChildIndex(textbox_message, 0);
            Controls.SetChildIndex(listbox_users, 0);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listbox_users;
        private TextBox textbox_message;
        private Button button_send;
        private ListBox listbox_messages;
        private Panel panel3;
        private TextBox textbox_searchUser;
    }
}