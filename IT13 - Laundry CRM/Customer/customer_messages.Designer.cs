namespace IT13___Laundry_CRM.Customer
{
    partial class customer_messages
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
            listbox_messages = new ListBox();
            button_send = new Button();
            textbox_message = new TextBox();
            panel3 = new Panel();
            textbox_searchUser = new TextBox();
            listbox_users = new ListBox();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // listbox_messages
            // 
            listbox_messages.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listbox_messages.BackColor = SystemColors.ButtonFace;
            listbox_messages.BorderStyle = BorderStyle.None;
            listbox_messages.Font = new Font("Gadugi", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listbox_messages.FormattingEnabled = true;
            listbox_messages.ItemHeight = 27;
            listbox_messages.Location = new Point(625, 81);
            listbox_messages.Name = "listbox_messages";
            listbox_messages.Size = new Size(307, 351);
            listbox_messages.TabIndex = 2;
            listbox_messages.DrawItem += listbox_messages_DrawItem;
            listbox_messages.MeasureItem += listbox_messages_MeasureItem;
            // 
            // button_send
            // 
            button_send.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_send.BackColor = SystemColors.HotTrack;
            button_send.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_send.ForeColor = SystemColors.ButtonHighlight;
            button_send.Location = new Point(833, 442);
            button_send.Name = "button_send";
            button_send.Size = new Size(100, 50);
            button_send.TabIndex = 3;
            button_send.Text = "📩 Send";
            button_send.UseVisualStyleBackColor = false;
            button_send.Click += button_send_Click;
            // 
            // textbox_message
            // 
            textbox_message.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textbox_message.BackColor = SystemColors.ButtonFace;
            textbox_message.BorderStyle = BorderStyle.None;
            textbox_message.Font = new Font("Gadugi", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textbox_message.Location = new Point(625, 442);
            textbox_message.Multiline = true;
            textbox_message.Name = "textbox_message";
            textbox_message.Size = new Size(202, 50);
            textbox_message.TabIndex = 6;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.GradientInactiveCaption;
            panel3.Controls.Add(textbox_searchUser);
            panel3.Location = new Point(218, 81);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(713, 65);
            panel3.TabIndex = 7;
            // 
            // textbox_searchUser
            // 
            textbox_searchUser.BackColor = SystemColors.ButtonFace;
            textbox_searchUser.BorderStyle = BorderStyle.None;
            textbox_searchUser.Font = new Font("Gadugi", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textbox_searchUser.Location = new Point(29, 11);
            textbox_searchUser.Multiline = true;
            textbox_searchUser.Name = "textbox_searchUser";
            textbox_searchUser.PlaceholderText = "🔍 Search via first name, last name, or role";
            textbox_searchUser.Size = new Size(350, 40);
            textbox_searchUser.TabIndex = 8;
            textbox_searchUser.TextChanged += textbox_searchUser_TextChanged;
            // 
            // listbox_users
            // 
            listbox_users.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            listbox_users.BackColor = SystemColors.GradientInactiveCaption;
            listbox_users.BorderStyle = BorderStyle.None;
            listbox_users.Font = new Font("Gadugi", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listbox_users.FormattingEnabled = true;
            listbox_users.ItemHeight = 27;
            listbox_users.Location = new Point(218, 151);
            listbox_users.Name = "listbox_users";
            listbox_users.Size = new Size(400, 351);
            listbox_users.TabIndex = 8;
            listbox_users.DrawItem += listbox_users_DrawItem;
            listbox_users.SelectedIndexChanged += listbox_users_SelectedIndexChanged;
            // 
            // customer_messages
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(946, 541);
            Controls.Add(listbox_users);
            Controls.Add(textbox_message);
            Controls.Add(button_send);
            Controls.Add(listbox_messages);
            Controls.Add(panel3);
            Margin = new Padding(4);
            Name = "customer_messages";
            Text = "Customer | Messages";
            Load += customer_messages_Load;
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
        private ListBox listbox_messages;
        private Button button_send;
        private TextBox textbox_message;
        private Panel panel3;
        private TextBox textbox_searchUser;
        private ListBox listbox_users;
    }
}