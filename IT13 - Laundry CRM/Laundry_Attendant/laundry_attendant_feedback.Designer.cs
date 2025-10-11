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
            feedbackLabel = new Label();
            feedbackPanel = new Panel();
            textbox_search = new TextBox();
            feedbackPanel.SuspendLayout();
            SuspendLayout();
            // 
            // feedbackLabel
            // 
            feedbackLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            feedbackLabel.AutoSize = true;
            feedbackLabel.Font = new Font("Cascadia Code", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            feedbackLabel.Location = new Point(4, 15);
            feedbackLabel.Margin = new Padding(4, 0, 4, 0);
            feedbackLabel.Name = "feedbackLabel";
            feedbackLabel.Size = new Size(98, 32);
            feedbackLabel.TabIndex = 11;
            feedbackLabel.Text = "label5";
            // 
            // feedbackPanel
            // 
            feedbackPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            feedbackPanel.AutoScroll = true;
            feedbackPanel.Controls.Add(feedbackLabel);
            feedbackPanel.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            feedbackPanel.Location = new Point(285, 154);
            feedbackPanel.Margin = new Padding(4);
            feedbackPanel.Name = "feedbackPanel";
            feedbackPanel.Size = new Size(909, 384);
            feedbackPanel.TabIndex = 12;
            feedbackPanel.Resize += feedbackPanel_Resize;
            // 
            // textbox_search
            // 
            textbox_search.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textbox_search.BackColor = SystemColors.ButtonHighlight;
            textbox_search.Location = new Point(285, 100);
            textbox_search.Margin = new Padding(4);
            textbox_search.Multiline = true;
            textbox_search.Name = "textbox_search";
            textbox_search.PlaceholderText = "🔎 Search here...";
            textbox_search.Size = new Size(909, 49);
            textbox_search.TabIndex = 13;
            textbox_search.TextChanged += textbox_search_TextChanged;
            // 
            // laundry_attendant_feedback
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1224, 569);
            Controls.Add(textbox_search);
            Controls.Add(feedbackPanel);
            Margin = new Padding(5);
            Name = "laundry_attendant_feedback";
            Text = "Laundry Attendant | Feedback";
            Load += laundry_attendant_feedback_Load;
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