namespace IT13___Laundry_CRM.Admin
{
    partial class admin_feedback
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
            listbox_feedback.FormattingEnabled = true;
            listbox_feedback.ItemHeight = 27;
            listbox_feedback.Location = new Point(291, 150);
            listbox_feedback.Margin = new Padding(4);
            listbox_feedback.Name = "listbox_feedback";
            listbox_feedback.Size = new Size(875, 436);
            listbox_feedback.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cascadia Code SemiBold", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaption;
            label3.Location = new Point(310, 20);
            label3.Name = "label3";
            label3.Size = new Size(492, 52);
            label3.TabIndex = 8;
            label3.Text = "💬 Customer Feedback";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cascadia Code", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ActiveCaption;
            label4.Location = new Point(398, 89);
            label4.Name = "label4";
            label4.Size = new Size(593, 24);
            label4.TabIndex = 9;
            label4.Text = "\"See what your users are saying and respond quickly.\"";
            // 
            // admin_feedback
            // 
            AutoScaleDimensions = new SizeF(12F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 608);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(listbox_feedback);
            Margin = new Padding(6, 4, 6, 4);
            Name = "admin_feedback";
            Text = "admin_feedback";
            Load += admin_feedback_Load;
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