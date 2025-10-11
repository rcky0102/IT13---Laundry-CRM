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
            textbox_search = new TextBox();
            SuspendLayout();
            // 
            // listbox_feedback
            // 
            listbox_feedback.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listbox_feedback.Font = new Font("Gadugi", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listbox_feedback.FormattingEnabled = true;
            listbox_feedback.Location = new Point(228, 134);
            listbox_feedback.Name = "listbox_feedback";
            listbox_feedback.Size = new Size(711, 264);
            listbox_feedback.TabIndex = 14;
            listbox_feedback.DrawItem += listbox_feedback_DrawItem;
            listbox_feedback.SelectedIndexChanged += listbox_feedback_SelectedIndexChanged;
            listbox_feedback.MouseDown += listbox_feedback_MouseDown;
            // 
            // textbox_search
            // 
            textbox_search.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textbox_search.Location = new Point(549, 101);
            textbox_search.Name = "textbox_search";
            textbox_search.Size = new Size(364, 27);
            textbox_search.TabIndex = 15;
            textbox_search.TextChanged += textbox_search_TextChanged;
            // 
            // laundry_attendant_feedback
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(951, 420);
            Controls.Add(textbox_search);
            Controls.Add(listbox_feedback);
            Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "laundry_attendant_feedback";
            Text = "Laundry Attendant | Feedback";
            Load += laundry_attendant_feedback_Load;
            Controls.SetChildIndex(listbox_feedback, 0);
            Controls.SetChildIndex(textbox_search, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListBox listbox_feedback;
        private TextBox textbox_search;
    }
}