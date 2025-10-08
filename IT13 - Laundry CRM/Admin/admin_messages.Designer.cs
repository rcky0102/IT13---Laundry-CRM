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
            panel3 = new Panel();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // combobox_users
            // 
            combobox_users.BackColor = SystemColors.ButtonFace;
            combobox_users.FormattingEnabled = true;
            combobox_users.Location = new Point(29, 18);
            combobox_users.Name = "combobox_users";
            combobox_users.Size = new Size(400, 30);
            combobox_users.TabIndex = 2;
            combobox_users.SelectedIndexChanged += combobox_users_SelectedIndexChanged;
            // 
            // listbox_messages
            // 
            listbox_messages.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listbox_messages.FormattingEnabled = true;
            listbox_messages.ItemHeight = 22;
            listbox_messages.Location = new Point(225, 232);
            listbox_messages.Name = "listbox_messages";
            listbox_messages.Size = new Size(745, 202);
            listbox_messages.TabIndex = 3;
            listbox_messages.DrawItem += listbox_messages_DrawItem;
            listbox_messages.MeasureItem += listbox_messages_MeasureItem;
            // 
            // textbox_message
            // 
            textbox_message.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textbox_message.Location = new Point(225, 443);
            textbox_message.Multiline = true;
            textbox_message.Name = "textbox_message";
            textbox_message.Size = new Size(671, 40);
            textbox_message.TabIndex = 4;
            // 
            // button_send
            // 
            button_send.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_send.BackColor = SystemColors.HotTrack;
            button_send.ForeColor = SystemColors.InactiveBorder;
            button_send.Location = new Point(910, 443);
            button_send.Name = "button_send";
            button_send.Size = new Size(60, 40);
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
            button_edit.Location = new Point(619, 12);
            button_edit.Name = "button_edit";
            button_edit.Size = new Size(50, 40);
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
            button_delete.Location = new Point(675, 12);
            button_delete.Name = "button_delete";
            button_delete.Size = new Size(50, 40);
            button_delete.TabIndex = 7;
            button_delete.Text = "🗑️";
            button_delete.UseVisualStyleBackColor = false;
            button_delete.Click += button_delete_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cascadia Code", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(235, 67);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(291, 35);
            label3.TabIndex = 8;
            label3.Text = "📩 Admin Messages";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.Font = new Font("Cascadia Code SemiLight", 8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(278, 101);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(688, 38);
            label4.TabIndex = 9;
            label4.Text = "\"View, manage, and respond to customer messages efficiently, ensuring clear communication and timely support.\"";
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = SystemColors.ActiveCaption;
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(combobox_users);
            panel3.Controls.Add(button_edit);
            panel3.Controls.Add(button_delete);
            panel3.Location = new Point(225, 150);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(745, 70);
            panel3.TabIndex = 10;
            // 
            // admin_messages
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 495);
            Controls.Add(panel3);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button_send);
            Controls.Add(textbox_message);
            Controls.Add(listbox_messages);
            Margin = new Padding(4, 2, 4, 2);
            Name = "admin_messages";
            Text = "Admin | Message";
            Load += admin_messages_Load;
            Controls.SetChildIndex(listbox_messages, 0);
            Controls.SetChildIndex(textbox_message, 0);
            Controls.SetChildIndex(button_send, 0);
            Controls.SetChildIndex(label3, 0);
            Controls.SetChildIndex(label4, 0);
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
        private Label label3;
        private Label label4;
        private Panel panel3;
    }
}