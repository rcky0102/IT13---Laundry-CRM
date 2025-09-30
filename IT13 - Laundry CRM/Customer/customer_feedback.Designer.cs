namespace IT13___Laundry_CRM.Customer
{
    partial class customer_feedback
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
            textbox_subject = new TextBox();
            textbox_feedback = new TextBox();
            listbox_feedback = new ListBox();
            button_send = new Button();
            button_edit = new Button();
            button_delete = new Button();
            SuspendLayout();
            // 
            // textbox_subject
            // 
            textbox_subject.Location = new Point(359, 54);
            textbox_subject.Name = "textbox_subject";
            textbox_subject.Size = new Size(217, 27);
            textbox_subject.TabIndex = 1;
            // 
            // textbox_feedback
            // 
            textbox_feedback.Location = new Point(359, 109);
            textbox_feedback.Multiline = true;
            textbox_feedback.Name = "textbox_feedback";
            textbox_feedback.Size = new Size(256, 90);
            textbox_feedback.TabIndex = 2;
            // 
            // listbox_feedback
            // 
            listbox_feedback.FormattingEnabled = true;
            listbox_feedback.Location = new Point(359, 321);
            listbox_feedback.Name = "listbox_feedback";
            listbox_feedback.Size = new Size(331, 164);
            listbox_feedback.TabIndex = 3;
            // 
            // button_send
            // 
            button_send.Location = new Point(359, 227);
            button_send.Name = "button_send";
            button_send.Size = new Size(94, 29);
            button_send.TabIndex = 4;
            button_send.Text = "Send";
            button_send.UseVisualStyleBackColor = true;
            button_send.Click += button_send_Click;
            // 
            // button_edit
            // 
            button_edit.Location = new Point(482, 227);
            button_edit.Name = "button_edit";
            button_edit.Size = new Size(94, 29);
            button_edit.TabIndex = 5;
            button_edit.Text = "Edit";
            button_edit.UseVisualStyleBackColor = true;
            button_edit.Click += button_edit_Click;
            // 
            // button_delete
            // 
            button_delete.Location = new Point(607, 227);
            button_delete.Name = "button_delete";
            button_delete.Size = new Size(94, 29);
            button_delete.TabIndex = 6;
            button_delete.Text = "Delete";
            button_delete.UseVisualStyleBackColor = true;
            button_delete.Click += button_delete_Click;
            // 
            // customer_feedback
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(878, 557);
            Controls.Add(button_delete);
            Controls.Add(button_edit);
            Controls.Add(button_send);
            Controls.Add(listbox_feedback);
            Controls.Add(textbox_feedback);
            Controls.Add(textbox_subject);
            Name = "customer_feedback";
            Text = "customer_feedback";
            Load += customer_feedback_Load;
            Controls.SetChildIndex(textbox_subject, 0);
            Controls.SetChildIndex(textbox_feedback, 0);
            Controls.SetChildIndex(listbox_feedback, 0);
            Controls.SetChildIndex(button_send, 0);
            Controls.SetChildIndex(button_edit, 0);
            Controls.SetChildIndex(button_delete, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textbox_subject;
        private TextBox textbox_feedback;
        private ListBox listbox_feedback;
        private Button button_send;
        private Button button_edit;
        private Button button_delete;
    }
}