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
            label3 = new Label();
            label4 = new Label();
            feedbackLabel = new Label();
            feedbackPanel = new Panel();
            textbox_search = new TextBox();
            feedbackPanel.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cascadia Code SemiBold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(228, 75);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(340, 35);
            label3.TabIndex = 9;
            label3.Text = "💬 Customer Feedback";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cascadia Code", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(277, 110);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(486, 20);
            label4.TabIndex = 10;
            label4.Text = "\"See what your users are saying and respond quickly.\"";
            // 
            // feedbackLabel
            // 
            feedbackLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            feedbackLabel.AutoSize = true;
            feedbackLabel.Font = new Font("Cascadia Code", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            feedbackLabel.Location = new Point(49, 12);
            feedbackLabel.Name = "feedbackLabel";
            feedbackLabel.Size = new Size(84, 27);
            feedbackLabel.TabIndex = 11;
            feedbackLabel.Text = "label5";
            // 
            // feedbackPanel
            // 
            feedbackPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            feedbackPanel.AutoScroll = true;
            feedbackPanel.Controls.Add(feedbackLabel);
            feedbackPanel.Location = new Point(228, 199);
            feedbackPanel.Name = "feedbackPanel";
            feedbackPanel.Size = new Size(699, 218);
            feedbackPanel.TabIndex = 12;
            feedbackPanel.Resize += feedbackPanel_Resize;
            // 
            // textbox_search
            // 
            textbox_search.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textbox_search.BackColor = SystemColors.ButtonFace;
            textbox_search.Location = new Point(599, 153);
            textbox_search.Multiline = true;
            textbox_search.Name = "textbox_search";
            textbox_search.PlaceholderText = "🔎 Search here...";
            textbox_search.Size = new Size(300, 40);
            textbox_search.TabIndex = 13;
            textbox_search.TextChanged += textbox_search_TextChanged;
            // 
            // laundry_attendant_feedback
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(951, 442);
            Controls.Add(textbox_search);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(feedbackPanel);
            Margin = new Padding(4);
            Name = "laundry_attendant_feedback";
            Text = "Laundry Attendant | Feedback";
            Load += laundry_attendant_feedback_Load;
            Controls.SetChildIndex(feedbackPanel, 0);
            Controls.SetChildIndex(label3, 0);
            Controls.SetChildIndex(label4, 0);
            Controls.SetChildIndex(textbox_search, 0);
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
        private TextBox textbox_search;
    }
}