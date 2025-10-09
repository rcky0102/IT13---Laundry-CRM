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
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // combobox_users
            // 
            combobox_users.BackColor = SystemColors.ButtonFace;
            combobox_users.Font = new Font("Cascadia Code SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            combobox_users.FormattingEnabled = true;
            combobox_users.Location = new Point(20, 22);
            combobox_users.Margin = new Padding(4, 4, 4, 4);
            combobox_users.Name = "combobox_users";
            combobox_users.Size = new Size(499, 35);
            combobox_users.TabIndex = 1;
            combobox_users.SelectedIndexChanged += combobox_users_SelectedIndexChanged;
            // 
            // listbox_messages
            // 
            listbox_messages.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listbox_messages.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listbox_messages.FormattingEnabled = true;
            listbox_messages.ItemHeight = 21;
            listbox_messages.Location = new Point(276, 212);
            listbox_messages.Margin = new Padding(4, 4, 4, 4);
            listbox_messages.Name = "listbox_messages";
            listbox_messages.Size = new Size(935, 424);
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
            button_send.Location = new Point(1149, 651);
            button_send.Margin = new Padding(4, 4, 4, 4);
            button_send.Name = "button_send";
            button_send.Size = new Size(68, 50);
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
            button_edit.Location = new Point(771, 16);
            button_edit.Margin = new Padding(4, 4, 4, 4);
            button_edit.Name = "button_edit";
            button_edit.Size = new Size(62, 50);
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
            button_delete.Location = new Point(841, 16);
            button_delete.Margin = new Padding(4, 4, 4, 4);
            button_delete.Name = "button_delete";
            button_delete.Size = new Size(62, 50);
            button_delete.TabIndex = 5;
            button_delete.Text = "🗑️";
            button_delete.UseVisualStyleBackColor = false;
            button_delete.Click += button_delete_Click;
            // 
            // textbox_message
            // 
            textbox_message.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textbox_message.BorderStyle = BorderStyle.FixedSingle;
            textbox_message.Location = new Point(276, 651);
            textbox_message.Margin = new Padding(4, 4, 4, 4);
            textbox_message.Multiline = true;
            textbox_message.Name = "textbox_message";
            textbox_message.Size = new Size(864, 50);
            textbox_message.TabIndex = 6;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = SystemColors.ActiveCaption;
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(button_delete);
            panel3.Controls.Add(combobox_users);
            panel3.Controls.Add(button_edit);
            panel3.Location = new Point(276, 100);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(932, 93);
            panel3.TabIndex = 7;
            // 
            // customer_messages
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1239, 715);
            Controls.Add(textbox_message);
            Controls.Add(button_send);
            Controls.Add(listbox_messages);
            Controls.Add(panel3);
            Margin = new Padding(5, 5, 5, 5);
            Name = "customer_messages";
            Text = "Customer | Messages";
            Load += customer_messages_Load;
            Controls.SetChildIndex(panel3, 0);
            Controls.SetChildIndex(listbox_messages, 0);
            Controls.SetChildIndex(button_send, 0);
            Controls.SetChildIndex(textbox_message, 0);
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
    }
}