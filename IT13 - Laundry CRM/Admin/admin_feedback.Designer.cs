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
            textbox_search = new TextBox();
            button_archives = new Button();
            panel4 = new Panel();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // listbox_feedback
            // 
            listbox_feedback.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listbox_feedback.Font = new Font("Gadugi", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listbox_feedback.FormattingEnabled = true;
            listbox_feedback.Location = new Point(216, 157);
            listbox_feedback.Name = "listbox_feedback";
            listbox_feedback.Size = new Size(762, 344);
            listbox_feedback.TabIndex = 19;
            listbox_feedback.DrawItem += listbox_feedback_DrawItem;
            listbox_feedback.SelectedIndexChanged += listbox_feedback_SelectedIndexChanged;
            listbox_feedback.MouseDown += listbox_feedback_MouseDown;
            // 
            // textbox_search
            // 
            textbox_search.BackColor = SystemColors.ButtonHighlight;
            textbox_search.BorderStyle = BorderStyle.None;
            textbox_search.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textbox_search.Location = new Point(21, 21);
            textbox_search.Multiline = true;
            textbox_search.Name = "textbox_search";
            textbox_search.PlaceholderText = "🔎 Search via subject, sender name, or date";
            textbox_search.Size = new Size(350, 30);
            textbox_search.TabIndex = 20;
            // 
            // button_archives
            // 
            button_archives.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_archives.BackColor = SystemColors.Highlight;
            button_archives.FlatAppearance.BorderSize = 0;
            button_archives.FlatStyle = FlatStyle.Flat;
            button_archives.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_archives.ForeColor = SystemColors.ButtonHighlight;
            button_archives.Location = new Point(638, 13);
            button_archives.Name = "button_archives";
            button_archives.Size = new Size(110, 40);
            button_archives.TabIndex = 21;
            button_archives.Text = "🗂️ Archives";
            button_archives.UseVisualStyleBackColor = false;
            button_archives.Click += button_archives_Click;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel4.BackColor = SystemColors.GradientActiveCaption;
            panel4.Controls.Add(textbox_search);
            panel4.Controls.Add(button_archives);
            panel4.Location = new Point(216, 77);
            panel4.Margin = new Padding(2);
            panel4.Name = "panel4";
            panel4.Size = new Size(762, 67);
            panel4.TabIndex = 24;
            // 
            // admin_feedback
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(988, 538);
            Controls.Add(listbox_feedback);
            Controls.Add(panel4);
            Name = "admin_feedback";
            Text = "Admin | Feedback";
            Controls.SetChildIndex(panel4, 0);
            Controls.SetChildIndex(listbox_feedback, 0);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListBox listbox_feedback;
        private TextBox textbox_search;
        private Button button_archives;
        private Panel panel4;
    }
}