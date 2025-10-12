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
            panel3 = new Panel();
            listbox_users = new ListBox();
            textbox_message = new TextBox();
            button_send = new Button();
            listbox_messages = new ListBox();
            panel2 = new Panel();
            label1 = new Label();
            textbox_searchUser = new TextBox();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaption;
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Location = new Point(263, 190);
            panel3.Name = "panel3";
            panel3.Size = new Size(908, 59);
            panel3.TabIndex = 6;
            // 
            // listbox_users
            // 
            listbox_users.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            listbox_users.BackColor = SystemColors.GradientInactiveCaption;
            listbox_users.BorderStyle = BorderStyle.FixedSingle;
            listbox_users.Font = new Font("Gadugi", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listbox_users.FormattingEnabled = true;
            listbox_users.ItemHeight = 27;
            listbox_users.Location = new Point(256, 159);
            listbox_users.Name = "listbox_users";
            listbox_users.Size = new Size(238, 380);
            listbox_users.TabIndex = 13;
            listbox_users.DrawItem += listbox_users_DrawItem;
            listbox_users.SelectedIndexChanged += listbox_users_SelectedIndexChanged;
            // 
            // textbox_message
            // 
            textbox_message.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textbox_message.BackColor = SystemColors.ButtonHighlight;
            textbox_message.BorderStyle = BorderStyle.FixedSingle;
            textbox_message.Font = new Font("Gadugi", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textbox_message.Location = new Point(500, 514);
            textbox_message.Multiline = true;
            textbox_message.Name = "textbox_message";
            textbox_message.Size = new Size(524, 40);
            textbox_message.TabIndex = 11;
            // 
            // button_send
            // 
            button_send.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_send.BackColor = SystemColors.HotTrack;
            button_send.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_send.ForeColor = SystemColors.ButtonHighlight;
            button_send.Location = new Point(1030, 514);
            button_send.Name = "button_send";
            button_send.Size = new Size(54, 40);
            button_send.TabIndex = 10;
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
            listbox_messages.ItemHeight = 27;
            listbox_messages.Location = new Point(499, 158);
            listbox_messages.Name = "listbox_messages";
            listbox_messages.Size = new Size(584, 328);
            listbox_messages.TabIndex = 9;
            listbox_messages.DrawItem += listbox_messages_DrawItem_1;
            listbox_messages.MeasureItem += listbox_messages_MeasureItem_1;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = SystemColors.GradientInactiveCaption;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(textbox_searchUser);
            panel2.Location = new Point(256, 78);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(829, 75);
            panel2.TabIndex = 12;
            panel2.Paint += panel2_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gadugi", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(18, 24);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(122, 28);
            label1.TabIndex = 9;
            label1.Text = "Messages";
            // 
            // textbox_searchUser
            // 
            textbox_searchUser.BackColor = SystemColors.ButtonHighlight;
            textbox_searchUser.Font = new Font("Gadugi", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textbox_searchUser.Location = new Point(391, 18);
            textbox_searchUser.Multiline = true;
            textbox_searchUser.Name = "textbox_searchUser";
            textbox_searchUser.PlaceholderText = "🔍 Search (e.g. John | Doe | Role)";
            textbox_searchUser.Size = new Size(400, 40);
            textbox_searchUser.TabIndex = 8;
            textbox_searchUser.TextChanged += textbox_searchUser_TextChanged;
            // 
            // laundry_attendant_messages
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1096, 568);
            Controls.Add(listbox_users);
            Controls.Add(textbox_message);
            Controls.Add(button_send);
            Controls.Add(listbox_messages);
            Controls.Add(panel2);
            Margin = new Padding(4);
            Name = "laundry_attendant_messages";
            Text = "Laundry Attendant | Message";
            Load += laundry_attendant_messages_Load;
            Controls.SetChildIndex(panel2, 0);
            Controls.SetChildIndex(listbox_messages, 0);
            Controls.SetChildIndex(button_send, 0);
            Controls.SetChildIndex(textbox_message, 0);
            Controls.SetChildIndex(listbox_users, 0);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel3;
        private ListBox listbox_users;
        private TextBox textbox_message;
        private Button button_send;
        private ListBox listbox_messages;
        private Panel panel2;
        private TextBox textbox_searchUser;
        private Label label1;
    }
}