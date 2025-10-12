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
            label2 = new Label();
            button_archives = new Button();
            SuspendLayout();
            // 
            // listbox_feedback
            // 
            listbox_feedback.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listbox_feedback.Font = new Font("Gadugi", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listbox_feedback.FormattingEnabled = true;
            listbox_feedback.Location = new Point(230, 161);
            listbox_feedback.Name = "listbox_feedback";
            listbox_feedback.Size = new Size(740, 304);
            listbox_feedback.TabIndex = 19;
            listbox_feedback.DrawItem += listbox_feedback_DrawItem;
            listbox_feedback.SelectedIndexChanged += listbox_feedback_SelectedIndexChanged;
            listbox_feedback.MouseDown += listbox_feedback_MouseDown;
            // 
            // textbox_search
            // 
            textbox_search.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textbox_search.Location = new Point(606, 105);
            textbox_search.Name = "textbox_search";
            textbox_search.Size = new Size(364, 27);
            textbox_search.TabIndex = 20;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.BackColor = SystemColors.GradientInactiveCaption;
            label2.Font = new Font("Gadugi", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(421, 109);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(89, 17);
            label2.TabIndex = 22;
            label2.Text = "View Archive:";
            // 
            // button_archives
            // 
            button_archives.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_archives.BackColor = SystemColors.GradientInactiveCaption;
            button_archives.FlatAppearance.BorderSize = 0;
            button_archives.FlatStyle = FlatStyle.Flat;
            button_archives.Font = new Font("Gadugi", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_archives.ForeColor = SystemColors.ActiveCaptionText;
            button_archives.Location = new Point(537, 96);
            button_archives.Name = "button_archives";
            button_archives.Size = new Size(50, 40);
            button_archives.TabIndex = 21;
            button_archives.Text = "🗂️";
            button_archives.UseVisualStyleBackColor = false;
            button_archives.Click += button_archives_Click;
            // 
            // admin_feedback
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(988, 482);
            Controls.Add(textbox_search);
            Controls.Add(label2);
            Controls.Add(button_archives);
            Controls.Add(listbox_feedback);
            Margin = new Padding(5, 3, 5, 3);
            Name = "admin_feedback";
            Text = "Admin | Feedback";
            Load += admin_feedback_Load;
            Controls.SetChildIndex(listbox_feedback, 0);
            Controls.SetChildIndex(button_archives, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(textbox_search, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listbox_feedback;
        private TextBox textbox_search;
        private Label label2;
        private Button button_archives;
    }
}