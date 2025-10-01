namespace IT13___Laundry_CRM
{
    partial class AdminForm
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
            label_feedback = new Label();
            label_message = new Label();
            SuspendLayout();
            // 
            // label_feedback
            // 
            label_feedback.AutoSize = true;
            label_feedback.Location = new Point(358, 139);
            label_feedback.Name = "label_feedback";
            label_feedback.Size = new Size(70, 22);
            label_feedback.TabIndex = 2;
            label_feedback.Text = "label3";
            // 
            // label_message
            // 
            label_message.AutoSize = true;
            label_message.Location = new Point(358, 422);
            label_message.Name = "label_message";
            label_message.Size = new Size(70, 22);
            label_message.TabIndex = 3;
            label_message.Text = "label3";
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 479);
            Controls.Add(label_message);
            Controls.Add(label_feedback);
            Margin = new Padding(5, 3, 5, 3);
            Name = "AdminForm";
            Text = "AdminForm";
            Load += AdminForm_Load;
            Controls.SetChildIndex(label_feedback, 0);
            Controls.SetChildIndex(label_message, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_feedback;
        private Label label_message;
    }
}