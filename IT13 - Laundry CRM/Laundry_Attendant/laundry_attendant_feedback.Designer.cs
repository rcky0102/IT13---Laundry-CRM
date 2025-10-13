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
            textbox_search = new TextBox();
            panel2 = new Panel();
            button_archives = new Button();
            listbox_feedback = new ListBox();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // textbox_search
            // 
            textbox_search.BackColor = SystemColors.ButtonFace;
            textbox_search.BorderStyle = BorderStyle.None;
            textbox_search.Location = new Point(17, 17);
            textbox_search.Multiline = true;
            textbox_search.Name = "textbox_search";
            textbox_search.Size = new Size(350, 35);
            textbox_search.TabIndex = 15;
            textbox_search.TextChanged += textbox_search_TextChanged;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = SystemColors.GradientActiveCaption;
            panel2.Controls.Add(button_archives);
            panel2.Controls.Add(textbox_search);
            panel2.Location = new Point(220, 81);
            panel2.Name = "panel2";
            panel2.Size = new Size(620, 67);
            panel2.TabIndex = 18;
            panel2.Paint += panel2_Paint;
            // 
            // button_archives
            // 
            button_archives.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_archives.BackColor = SystemColors.Highlight;
            button_archives.FlatAppearance.BorderSize = 2;
            button_archives.FlatStyle = FlatStyle.Flat;
            button_archives.Font = new Font("Gadugi", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_archives.ForeColor = SystemColors.ButtonHighlight;
            button_archives.Location = new Point(556, 13);
            button_archives.Name = "button_archives";
            button_archives.Size = new Size(50, 40);
            button_archives.TabIndex = 23;
            button_archives.Text = "🗂️";
            button_archives.UseVisualStyleBackColor = false;
            button_archives.Click += button_archives_Click;
            // 
            // listbox_feedback
            // 
            listbox_feedback.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listbox_feedback.BackColor = SystemColors.ButtonFace;
            listbox_feedback.BorderStyle = BorderStyle.None;
            listbox_feedback.Font = new Font("Gadugi", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listbox_feedback.FormattingEnabled = true;
            listbox_feedback.Location = new Point(220, 154);
            listbox_feedback.Name = "listbox_feedback";
            listbox_feedback.Size = new Size(620, 440);
            listbox_feedback.TabIndex = 14;
            listbox_feedback.DrawItem += listbox_feedback_DrawItem;
            listbox_feedback.SelectedIndexChanged += listbox_feedback_SelectedIndexChanged;
            listbox_feedback.MouseDown += listbox_feedback_MouseDown;
            // 
            // laundry_attendant_feedback
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(852, 614);
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
        private TextBox textbox_search;
        private Panel panel2;
        private Button button_archives;
        private ListBox listbox_feedback;
    }
}