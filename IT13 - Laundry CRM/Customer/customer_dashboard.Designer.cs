namespace IT13___Laundry_CRM
{
    partial class customer_dashboard
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
            label_status = new Label();
            label_welcome = new Label();
            label_message = new Label();
            SuspendLayout();
            // 
            // label_status
            // 
            label_status.AutoSize = true;
            label_status.Location = new Point(393, 210);
            label_status.Name = "label_status";
            label_status.Size = new Size(50, 20);
            label_status.TabIndex = 2;
            label_status.Text = "label1";
            // 
            // label_welcome
            // 
            label_welcome.AutoSize = true;
            label_welcome.Location = new Point(357, 119);
            label_welcome.Name = "label_welcome";
            label_welcome.Size = new Size(71, 20);
            label_welcome.TabIndex = 3;
            label_welcome.Text = "Welcome";
            // 
            // label_message
            // 
            label_message.AutoSize = true;
            label_message.Location = new Point(413, 317);
            label_message.Name = "label_message";
            label_message.Size = new Size(50, 20);
            label_message.TabIndex = 4;
            label_message.Text = "label1";
            // 
            // customer_dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label_message);
            Controls.Add(label_welcome);
            Controls.Add(label_status);
            Margin = new Padding(4);
            Name = "customer_dashboard";
            Text = "customer_dashboard";
            Load += customer_dashboard_Load;
            Controls.SetChildIndex(label_status, 0);
            Controls.SetChildIndex(label_welcome, 0);
            Controls.SetChildIndex(label_message, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_status;
        private Label label_welcome;
        private Label label_message;
    }
}