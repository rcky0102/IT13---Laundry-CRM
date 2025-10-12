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
            panel2 = new Panel();
            comboBoxFilter = new ComboBox();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // listbox_feedback
            // 
            listbox_feedback.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listbox_feedback.Font = new Font("Gadugi", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listbox_feedback.FormattingEnabled = true;
            listbox_feedback.Location = new Point(256, 164);
            listbox_feedback.Name = "listbox_feedback";
            listbox_feedback.Size = new Size(1033, 364);
            listbox_feedback.TabIndex = 14;
            listbox_feedback.DrawItem += listbox_feedback_DrawItem;
            listbox_feedback.SelectedIndexChanged += listbox_feedback_SelectedIndexChanged;
            listbox_feedback.MouseDown += listbox_feedback_MouseDown;
            // 
            // textbox_search
            // 
            textbox_search.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textbox_search.Location = new Point(651, 15);
            textbox_search.Name = "textbox_search";
            textbox_search.Size = new Size(364, 27);
            textbox_search.TabIndex = 15;
            textbox_search.TextChanged += textbox_search_TextChanged;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = SystemColors.GradientInactiveCaption;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(comboBoxFilter);
            panel2.Controls.Add(textbox_search);
            panel2.Location = new Point(256, 82);
            panel2.Name = "panel2";
            panel2.Size = new Size(1035, 62);
            panel2.TabIndex = 18;
            // 
            // comboBoxFilter
            // 
            comboBoxFilter.FormattingEnabled = true;
            comboBoxFilter.Location = new Point(41, 18);
            comboBoxFilter.Name = "comboBoxFilter";
            comboBoxFilter.Size = new Size(151, 27);
            comboBoxFilter.TabIndex = 18;
            comboBoxFilter.SelectedIndexChanged += comboBoxFilter_SelectedIndexChanged;
            // 
            // laundry_attendant_feedback
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1306, 614);
            Controls.Add(listbox_feedback);
            Controls.Add(panel2);
            Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "laundry_attendant_feedback";
            Text = "Laundry Attendant | Feedback";
            Load += laundry_attendant_feedback_Load;
            Controls.SetChildIndex(panel2, 0);
            Controls.SetChildIndex(listbox_feedback, 0);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private ListBox listbox_feedback;
        private TextBox textbox_search;
        private Panel panel2;
        private ComboBox comboBoxFilter;
    }
}