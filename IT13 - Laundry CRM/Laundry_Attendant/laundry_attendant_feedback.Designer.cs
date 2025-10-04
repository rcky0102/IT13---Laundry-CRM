namespace IT13___Laundry_CRM.Laundry_Attendant
{
    partial class laundry_attendant_feedback
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
            listbox_feedback = new ListBox();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // listbox_feedback
            // 
            listbox_feedback.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listbox_feedback.BackColor = SystemColors.ButtonHighlight;
            listbox_feedback.FormattingEnabled = true;
            listbox_feedback.ItemHeight = 25;
            listbox_feedback.Location = new Point(270, 160);
            listbox_feedback.Margin = new Padding(4);
            listbox_feedback.Name = "listbox_feedback";
            listbox_feedback.Size = new Size(906, 379);
            listbox_feedback.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cascadia Code SemiBold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(259, 69);
            label3.Name = "label3";
            label3.Size = new Size(406, 43);
            label3.TabIndex = 9;
            label3.Text = "💬 Customer Feedback";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cascadia Code", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(329, 113);
            label4.Name = "label4";
            label4.Size = new Size(593, 24);
            label4.TabIndex = 10;
            label4.Text = "\"See what your users are saying and respond quickly.\"";
            // 
            // laundry_attendant_feedback
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1189, 552);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(listbox_feedback);
            Margin = new Padding(5);
            Name = "laundry_attendant_feedback";
            Text = "laundry_attendant_feedback";
            Load += laundry_attendant_feedback_Load;
            Controls.SetChildIndex(listbox_feedback, 0);
            Controls.SetChildIndex(label3, 0);
            Controls.SetChildIndex(label4, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listbox_feedback;
        private Label label3;
        private Label label4;
    }
}