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
            combobox_users = new ComboBox();
            listbox_messages = new ListBox();
            button_send = new Button();
            button_edit = new Button();
            button_delete = new Button();
            textbox_message = new TextBox();
            panel3 = new Panel();
            label2 = new Label();
            label1 = new Label();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // combobox_users
            // 
            combobox_users.FormattingEnabled = true;
            combobox_users.Location = new Point(3, 12);
            combobox_users.Name = "combobox_users";
            combobox_users.Size = new Size(247, 28);
            combobox_users.TabIndex = 1;
            combobox_users.SelectedIndexChanged += combobox_users_SelectedIndexChanged;
            // 
            // listbox_messages
            // 
            listbox_messages.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listbox_messages.FormattingEnabled = true;
            listbox_messages.Location = new Point(198, 210);
            listbox_messages.Name = "listbox_messages";
            listbox_messages.Size = new Size(738, 184);
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
            button_send.Location = new Point(881, 399);
            button_send.Name = "button_send";
            button_send.Size = new Size(54, 40);
            button_send.TabIndex = 3;
            button_send.Text = "📩";
            button_send.UseVisualStyleBackColor = false;
            button_send.Click += button_send_Click;
            // 
            // button_edit
            // 
            button_edit.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_edit.BackColor = Color.ForestGreen;
            button_edit.ForeColor = SystemColors.ButtonHighlight;
            button_edit.Location = new Point(640, 12);
            button_edit.Name = "button_edit";
            button_edit.Size = new Size(41, 29);
            button_edit.TabIndex = 4;
            button_edit.Text = "✏️";
            button_edit.UseVisualStyleBackColor = false;
            button_edit.Click += button_edit_Click;
            // 
            // button_delete
            // 
            button_delete.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_delete.BackColor = Color.IndianRed;
            button_delete.ForeColor = SystemColors.ButtonHighlight;
            button_delete.Location = new Point(687, 11);
            button_delete.Name = "button_delete";
            button_delete.Size = new Size(41, 31);
            button_delete.TabIndex = 5;
            button_delete.Text = "🗑️";
            button_delete.UseVisualStyleBackColor = false;
            button_delete.Click += button_delete_Click;
            // 
            // textbox_message
            // 
            textbox_message.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textbox_message.BorderStyle = BorderStyle.FixedSingle;
            textbox_message.Location = new Point(202, 399);
            textbox_message.Multiline = true;
            textbox_message.Name = "textbox_message";
            textbox_message.Size = new Size(665, 51);
            textbox_message.TabIndex = 6;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = SystemColors.ActiveCaption;
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(combobox_users);
            panel3.Controls.Add(button_edit);
            panel3.Controls.Add(button_delete);
            panel3.Location = new Point(198, 157);
            panel3.Margin = new Padding(2, 2, 2, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(738, 48);
            panel3.TabIndex = 7;
            // 
            // label2
            // 
            label2.Font = new Font("Cascadia Code SemiLight", 8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(262, 100);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(606, 38);
            label2.TabIndex = 9;
            label2.Text = "“This chat allows you to communicate directly with our administrators for timely support and guidance.”";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Code", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(198, 62);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(166, 40);
            label1.TabIndex = 10;
            label1.Text = "🔔 Inbox";
            // 
            // customer_messages
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(945, 450);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(textbox_message);
            Controls.Add(button_send);
            Controls.Add(listbox_messages);
            Controls.Add(panel3);
            Margin = new Padding(4, 4, 4, 4);
            Name = "customer_messages";
            Text = "customer_messages";
            Load += customer_messages_Load;
            Controls.SetChildIndex(panel3, 0);
            Controls.SetChildIndex(listbox_messages, 0);
            Controls.SetChildIndex(button_send, 0);
            Controls.SetChildIndex(textbox_message, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(label1, 0);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox combobox_users;
        private ListBox listbox_messages;
        private Button button_send;
        private Button button_edit;
        private Button button_delete;
        private TextBox textbox_message;
        private Panel panel3;
        private Label label2;
        private Label label1;
    }
}