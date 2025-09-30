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
            SuspendLayout();
            // 
            // listbox_feedback
            // 
            listbox_feedback.FormattingEnabled = true;
            listbox_feedback.ItemHeight = 22;
            listbox_feedback.Location = new Point(431, 159);
            listbox_feedback.Name = "listbox_feedback";
            listbox_feedback.Size = new Size(404, 202);
            listbox_feedback.TabIndex = 2;
            // 
            // admin_feedback
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 495);
            Controls.Add(listbox_feedback);
            Margin = new Padding(5, 3, 5, 3);
            Name = "admin_feedback";
            Text = "admin_feedback";
            Load += admin_feedback_Load;
            Controls.SetChildIndex(listbox_feedback, 0);
            ResumeLayout(false);
        }

        #endregion

        private ListBox listbox_feedback;
    }
}