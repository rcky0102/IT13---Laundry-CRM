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
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // textbox_subject
            // 
            textbox_subject.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textbox_subject.ForeColor = Color.Yellow;
            textbox_subject.Location = new Point(209, 159);
            textbox_subject.Name = "textbox_subject";
            textbox_subject.Size = new Size(255, 27);
            textbox_subject.TabIndex = 1;
            // 
            // textbox_feedback
            // 
            textbox_feedback.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textbox_feedback.BorderStyle = BorderStyle.FixedSingle;
            textbox_feedback.Location = new Point(209, 380);
            textbox_feedback.Multiline = true;
            textbox_feedback.Name = "textbox_feedback";
            textbox_feedback.Size = new Size(645, 60);
            textbox_feedback.TabIndex = 2;
            // 
            // listbox_feedback
            // 
            listbox_feedback.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listbox_feedback.FormattingEnabled = true;
            listbox_feedback.Location = new Point(209, 190);
            listbox_feedback.Name = "listbox_feedback";
            listbox_feedback.Size = new Size(726, 184);
            listbox_feedback.TabIndex = 3;
            // 
            // button_send
            // 
            button_send.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_send.BackColor = SystemColors.MenuHighlight;
            button_send.FlatAppearance.BorderSize = 0;
            button_send.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_send.Location = new Point(860, 387);
            button_send.Name = "button_send";
            button_send.Size = new Size(74, 44);
            button_send.TabIndex = 4;
            button_send.Text = "📩";
            button_send.UseVisualStyleBackColor = false;
            button_send.Click += button_send_Click;
            // 
            // button_edit
            // 
            button_edit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_edit.BackColor = Color.LimeGreen;
            button_edit.ForeColor = SystemColors.ButtonHighlight;
            button_edit.Location = new Point(848, 157);
            button_edit.Name = "button_edit";
            button_edit.Size = new Size(39, 29);
            button_edit.TabIndex = 5;
            button_edit.Text = "✏️";
            button_edit.UseVisualStyleBackColor = false;
            button_edit.Click += button_edit_Click;
            // 
            // button_delete
            // 
            button_delete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_delete.BackColor = Color.IndianRed;
            button_delete.ForeColor = SystemColors.ButtonHighlight;
            button_delete.Location = new Point(894, 155);
            button_delete.Name = "button_delete";
            button_delete.Size = new Size(41, 29);
            button_delete.TabIndex = 6;
            button_delete.Text = "🗑️";
            button_delete.UseVisualStyleBackColor = false;
            button_delete.Click += button_delete_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Code SemiBold", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(209, 67);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(386, 45);
            label1.TabIndex = 10;
            label1.Text = "💬 Submit Feedback";
            // 
            // label2
            // 
            label2.Font = new Font("Cascadia Code SemiLight", 8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(270, 112);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(618, 42);
            label2.TabIndex = 11;
            label2.Text = "“Your input plays a vital role in helping us refine and enhance our services to better meet your needs.”";
            // 
            // customer_feedback
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(945, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button_delete);
            Controls.Add(button_edit);
            Controls.Add(button_send);
            Controls.Add(listbox_feedback);
            Controls.Add(textbox_feedback);
            Controls.Add(textbox_subject);
            ForeColor = SystemColors.ButtonHighlight;
            Margin = new Padding(4, 4, 4, 4);
            Name = "customer_feedback";
            Text = "customer_feedback";
            Load += customer_feedback_Load;
            Controls.SetChildIndex(textbox_subject, 0);
            Controls.SetChildIndex(textbox_feedback, 0);
            Controls.SetChildIndex(listbox_feedback, 0);
            Controls.SetChildIndex(button_send, 0);
            Controls.SetChildIndex(button_edit, 0);
            Controls.SetChildIndex(button_delete, 0);
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(label2, 0);
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
        private Label label1;
        private Label label2;
    }
}