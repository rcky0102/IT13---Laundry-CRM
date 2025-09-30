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
            SuspendLayout();
            // 
            // listbox_feedback
            // 
            listbox_feedback.FormattingEnabled = true;
            listbox_feedback.Location = new Point(265, 87);
            listbox_feedback.Name = "listbox_feedback";
            listbox_feedback.Size = new Size(436, 284);
            listbox_feedback.TabIndex = 1;
            // 
            // laundry_attendant_feedback
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listbox_feedback);
            Name = "laundry_attendant_feedback";
            Text = "laundry_attendant_feedback";
            Load += laundry_attendant_feedback_Load;
            Controls.SetChildIndex(listbox_feedback, 0);
            ResumeLayout(false);
        }

        #endregion

        private ListBox listbox_feedback;
    }
}