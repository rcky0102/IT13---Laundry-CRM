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
            feedbackLabel = new Label();
            feedbackPanel = new Panel();
            textbox_search = new TextBox();
            feedbackPanel.SuspendLayout();
            SuspendLayout();
            // 
            // feedbackLabel
            // 
            feedbackLabel.AutoSize = true;
            feedbackLabel.Location = new Point(34, 25);
            feedbackLabel.Margin = new Padding(4, 0, 4, 0);
            feedbackLabel.Name = "feedbackLabel";
            feedbackLabel.Size = new Size(63, 24);
            feedbackLabel.TabIndex = 10;
            feedbackLabel.Text = "label5";
            // 
            // feedbackPanel
            // 
            feedbackPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            feedbackPanel.AutoScroll = true;
            feedbackPanel.Controls.Add(feedbackLabel);
            feedbackPanel.Font = new Font("Gadugi", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            feedbackPanel.Location = new Point(282, 137);
            feedbackPanel.Margin = new Padding(4, 4, 4, 4);
            feedbackPanel.Name = "feedbackPanel";
            feedbackPanel.Size = new Size(870, 424);
            feedbackPanel.TabIndex = 11;
            // 
            // textbox_search
            // 
            textbox_search.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textbox_search.BackColor = SystemColors.ButtonFace;
            textbox_search.Font = new Font("Gadugi", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textbox_search.Location = new Point(814, 81);
            textbox_search.Margin = new Padding(4, 4, 4, 4);
            textbox_search.Multiline = true;
            textbox_search.Name = "textbox_search";
            textbox_search.PlaceholderText = "🔎 Search here...";
            textbox_search.Size = new Size(359, 48);
            textbox_search.TabIndex = 14;
            textbox_search.TextChanged += textbox_search_TextChanged;
            // 
            // admin_feedback
            // 
            AutoScaleDimensions = new SizeF(12F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1186, 592);
            Controls.Add(textbox_search);
            Controls.Add(feedbackPanel);
            Margin = new Padding(6, 4, 6, 4);
            Name = "admin_feedback";
            Text = "Admin | Feedback";
            Load += admin_feedback_Load;
            Controls.SetChildIndex(feedbackPanel, 0);
            Controls.SetChildIndex(textbox_search, 0);
            feedbackPanel.ResumeLayout(false);
            feedbackPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label feedbackLabel;
        private Panel feedbackPanel;
        private TextBox textbox_search;
    }
}