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
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // textbox_subject
            // 
            textbox_subject.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textbox_subject.BackColor = SystemColors.ButtonHighlight;
            textbox_subject.ForeColor = SystemColors.WindowText;
            textbox_subject.Location = new Point(633, 216);
            textbox_subject.Margin = new Padding(4);
            textbox_subject.Multiline = true;
            textbox_subject.Name = "textbox_subject";
            textbox_subject.Size = new Size(446, 39);
            textbox_subject.TabIndex = 1;
            // 
            // textbox_feedback
            // 
            textbox_feedback.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textbox_feedback.BackColor = SystemColors.ButtonHighlight;
            textbox_feedback.BorderStyle = BorderStyle.FixedSingle;
            textbox_feedback.Location = new Point(495, 263);
            textbox_feedback.Margin = new Padding(4);
            textbox_feedback.Multiline = true;
            textbox_feedback.Name = "textbox_feedback";
            textbox_feedback.Size = new Size(584, 261);
            textbox_feedback.TabIndex = 2;
            // 
            // listbox_feedback
            // 
            listbox_feedback.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listbox_feedback.BackColor = SystemColors.ButtonHighlight;
            listbox_feedback.Font = new Font("Gadugi", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listbox_feedback.FormattingEnabled = true;
            listbox_feedback.ItemHeight = 26;
            listbox_feedback.Location = new Point(275, 626);
            listbox_feedback.Margin = new Padding(4);
            listbox_feedback.Name = "listbox_feedback";
            listbox_feedback.Size = new Size(1015, 134);
            listbox_feedback.TabIndex = 3;
            listbox_feedback.DrawItem += listbox_feedback_DrawItem;
            listbox_feedback.SelectedIndexChanged += listbox_feedback_SelectedIndexChanged;
            // 
            // button_send
            // 
            button_send.Anchor = AnchorStyles.Bottom;
            button_send.BackColor = SystemColors.MenuHighlight;
            button_send.FlatAppearance.BorderSize = 0;
            button_send.Font = new Font("Gadugi", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_send.Location = new Point(716, 532);
            button_send.Margin = new Padding(4);
            button_send.Name = "button_send";
            button_send.Size = new Size(170, 49);
            button_send.TabIndex = 4;
            button_send.Text = "Submit Feedback";
            button_send.UseVisualStyleBackColor = false;
            button_send.Click += button_send_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Gadugi", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(555, 220);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(79, 24);
            label5.TabIndex = 12;
            label5.Text = "Subject:";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Font = new Font("Gadugi", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(275, 586);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(202, 24);
            label6.TabIndex = 13;
            label6.Text = "Submitted Feedbacks:";
            // 
            // customer_feedback
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1306, 773);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(button_send);
            Controls.Add(listbox_feedback);
            Controls.Add(textbox_feedback);
            Controls.Add(textbox_subject);
            ForeColor = SystemColors.ButtonHighlight;
            Margin = new Padding(5);
            Name = "customer_feedback";
            Text = "Customer | Feedback";
            Load += customer_feedback_Load;
            Controls.SetChildIndex(textbox_subject, 0);
            Controls.SetChildIndex(textbox_feedback, 0);
            Controls.SetChildIndex(listbox_feedback, 0);
            Controls.SetChildIndex(button_send, 0);
            Controls.SetChildIndex(label5, 0);
            Controls.SetChildIndex(label6, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textbox_subject;
        private TextBox textbox_feedback;
        private ListBox listbox_feedback;
        private Button button_send;
        private Label label5;
        private Label label6;
    }
}