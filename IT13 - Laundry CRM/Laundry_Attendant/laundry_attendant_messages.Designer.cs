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
            panel2 = new Panel();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // textbox_message
            // 
            textbox_message.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textbox_message.BorderStyle = BorderStyle.FixedSingle;
            textbox_message.Location = new Point(276, 534);
            textbox_message.Margin = new Padding(4, 4, 4, 4);
            textbox_message.Multiline = true;
            textbox_message.Name = "textbox_message";
            textbox_message.Size = new Size(740, 50);
            textbox_message.TabIndex = 0;
            // 
            // button_send
            // 
            button_send.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_send.BackColor = SystemColors.MenuHighlight;
            button_send.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_send.ForeColor = SystemColors.ButtonHighlight;
            button_send.Location = new Point(1024, 534);
            button_send.Margin = new Padding(4, 4, 4, 4);
            button_send.Name = "button_send";
            button_send.Size = new Size(62, 50);
            button_send.TabIndex = 1;
            button_send.Text = "📩";
            button_send.UseVisualStyleBackColor = false;
            button_send.Click += button_send_Click;
            // 
            // listbox_messages
            // 
            listbox_messages.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listbox_messages.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listbox_messages.FormattingEnabled = true;
            listbox_messages.ItemHeight = 21;
            listbox_messages.Location = new Point(276, 206);
            listbox_messages.Margin = new Padding(4, 4, 4, 4);
            listbox_messages.Name = "listbox_messages";
            listbox_messages.Size = new Size(809, 319);
            listbox_messages.TabIndex = 2;
            listbox_messages.DrawItem += listbox_messages_DrawItem;
            listbox_messages.MeasureItem += listbox_messages_MeasureItem;
            // 
            // combobox_users
            // 
            combobox_users.BackColor = SystemColors.ButtonFace;
            combobox_users.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            combobox_users.FormattingEnabled = true;
            combobox_users.Location = new Point(19, 25);
            combobox_users.Margin = new Padding(4, 4, 4, 4);
            combobox_users.Name = "combobox_users";
            combobox_users.Size = new Size(499, 29);
            combobox_users.TabIndex = 3;
            combobox_users.SelectedIndexChanged += combobox_users_SelectedIndexChanged;
            // 
            // button_edit
            // 
            button_edit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_edit.BackColor = Color.ForestGreen;
            button_edit.ForeColor = SystemColors.HighlightText;
            button_edit.Location = new Point(655, 16);
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
            button_delete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_delete.BackColor = Color.IndianRed;
            button_delete.ForeColor = SystemColors.ButtonHighlight;
            button_delete.Location = new Point(725, 16);
            button_delete.Margin = new Padding(4, 4, 4, 4);
            button_delete.Name = "button_delete";
            button_delete.Size = new Size(62, 50);
            button_delete.TabIndex = 5;
            button_delete.Text = "🗑️";
            button_delete.UseVisualStyleBackColor = false;
            button_delete.Click += button_delete_Click;
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
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(combobox_users);
            panel2.Controls.Add(button_edit);
            panel2.Controls.Add(button_delete);
            panel2.Location = new Point(277, 100);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(809, 86);
            panel2.TabIndex = 9;
            // 
            // laundry_attendant_messages
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1115, 599);
            Controls.Add(panel2);
            Controls.Add(listbox_messages);
            Controls.Add(button_send);
            Controls.Add(textbox_message);
            Margin = new Padding(5, 5, 5, 5);
            Name = "laundry_attendant_messages";
            Text = "Laundry Attendant | Message";
            Load += laundry_attendant_messages_Load;
            Controls.SetChildIndex(textbox_message, 0);
            Controls.SetChildIndex(button_send, 0);
            Controls.SetChildIndex(listbox_messages, 0);
            Controls.SetChildIndex(panel2, 0);
            panel2.ResumeLayout(false);
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
        private Panel panel2;
    }
}