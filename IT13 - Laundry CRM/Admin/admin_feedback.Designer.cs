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
            label3 = new Label();
            label4 = new Label();
            feedbackLabel = new Label();
            feedbackPanel = new Panel();
            feedbackPanel.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cascadia Code SemiBold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(241, 76);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(340, 35);
            label3.TabIndex = 8;
            label3.Text = "💬 Customer Feedback";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cascadia Code SemiLight", 8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(278, 111);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(432, 18);
            label4.TabIndex = 9;
            label4.Text = "\"See what your users are saying and respond quickly.\"";
            // 
            // feedbackLabel
            // 
            feedbackLabel.AutoSize = true;
            feedbackLabel.Location = new Point(28, 20);
            feedbackLabel.Name = "feedbackLabel";
            feedbackLabel.Size = new Size(70, 22);
            feedbackLabel.TabIndex = 10;
            feedbackLabel.Text = "label5";
            // 
            // feedbackPanel
            // 
            feedbackPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            feedbackPanel.Controls.Add(feedbackLabel);
            feedbackPanel.Location = new Point(235, 160);
            feedbackPanel.Name = "feedbackPanel";
            feedbackPanel.Size = new Size(725, 297);
            feedbackPanel.TabIndex = 11;
            // 
            // admin_feedback
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(988, 482);
            Controls.Add(feedbackPanel);
            Controls.Add(label4);
            Controls.Add(label3);
            Margin = new Padding(5, 3, 5, 3);
            Name = "admin_feedback";
            Text = "admin_feedback";
            Load += admin_feedback_Load;
            Controls.SetChildIndex(label3, 0);
            Controls.SetChildIndex(label4, 0);
            Controls.SetChildIndex(feedbackPanel, 0);
            feedbackPanel.ResumeLayout(false);
            feedbackPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private Label label4;
        private Label feedbackLabel;
        private Panel feedbackPanel;
    }
}