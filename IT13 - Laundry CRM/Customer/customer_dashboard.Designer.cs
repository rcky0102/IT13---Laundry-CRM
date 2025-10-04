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
            label_message = new Label();
            panel4 = new Panel();
            label_welcome = new Label();
            label1 = new Label();
            Luandry_Status = new Panel();
            panel3 = new Panel();
            progressBar1 = new ProgressBar();
            labelPercentage = new Label();
            panel4.SuspendLayout();
            Luandry_Status.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // label_status
            // 
            label_status.AutoSize = true;
            label_status.Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_status.Location = new Point(4, 9);
            label_status.Margin = new Padding(4, 0, 4, 0);
            label_status.Name = "label_status";
            label_status.Size = new Size(175, 24);
            label_status.TabIndex = 2;
            label_status.Text = "Luandry Status:";
            // 
            // label_message
            // 
            label_message.AutoSize = true;
            label_message.Font = new Font("Cascadia Code SemiLight", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_message.Location = new Point(4, 0);
            label_message.Margin = new Padding(4, 0, 4, 0);
            label_message.Name = "label_message";
            label_message.Size = new Size(73, 21);
            label_message.TabIndex = 4;
            label_message.Text = "Message";
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel4.BorderStyle = BorderStyle.Fixed3D;
            panel4.Controls.Add(label1);
            panel4.Controls.Add(panel3);
            panel4.Location = new Point(265, 341);
            panel4.Name = "panel4";
            panel4.Size = new Size(790, 166);
            panel4.TabIndex = 6;
            // 
            // label_welcome
            // 
            label_welcome.AutoSize = true;
            label_welcome.Font = new Font("Cascadia Code", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_welcome.ForeColor = SystemColors.ActiveCaptionText;
            label_welcome.Location = new Point(265, 92);
            label_welcome.Margin = new Padding(4, 0, 4, 0);
            label_welcome.Name = "label_welcome";
            label_welcome.Size = new Size(167, 47);
            label_welcome.TabIndex = 3;
            label_welcome.Text = "Welcome";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Code SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 4);
            label1.Name = "label1";
            label1.Size = new Size(350, 32);
            label1.TabIndex = 5;
            label1.Text = "Mesage and Notification:";
            // 
            // Luandry_Status
            // 
            Luandry_Status.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Luandry_Status.BorderStyle = BorderStyle.Fixed3D;
            Luandry_Status.Controls.Add(labelPercentage);
            Luandry_Status.Controls.Add(progressBar1);
            Luandry_Status.Controls.Add(label_status);
            Luandry_Status.Location = new Point(265, 165);
            Luandry_Status.Name = "Luandry_Status";
            Luandry_Status.Size = new Size(790, 160);
            Luandry_Status.TabIndex = 7;
            Luandry_Status.Paint += Luandry_Status_Paint;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = SystemColors.Control;
            panel3.Controls.Add(label_message);
            panel3.Location = new Point(16, 52);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Size = new Size(751, 80);
            panel3.TabIndex = 6;
            // 
            // progressBar1
            // 
            progressBar1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            progressBar1.Location = new Point(16, 50);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(715, 34);
            progressBar1.TabIndex = 8;
            // 
            // labelPercentage
            // 
            labelPercentage.AutoSize = true;
            labelPercentage.Location = new Point(16, 87);
            labelPercentage.Name = "labelPercentage";
            labelPercentage.Size = new Size(37, 25);
            labelPercentage.TabIndex = 9;
            labelPercentage.Text = "0%";
            // 
            // customer_dashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1113, 584);
            Controls.Add(Luandry_Status);
            Controls.Add(label_welcome);
            Controls.Add(panel4);
            Margin = new Padding(5);
            Name = "customer_dashboard";
            Text = "customer_dashboard";
            Load += customer_dashboard_Load;
            Controls.SetChildIndex(panel4, 0);
            Controls.SetChildIndex(label_welcome, 0);
            Controls.SetChildIndex(Luandry_Status, 0);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            Luandry_Status.ResumeLayout(false);
            Luandry_Status.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_status;
        private Label label_message;
        private Panel panel4;
        private Label label_welcome;
        private Label label1;
        private Panel Luandry_Status;
        private Panel panel3;
        private ProgressBar progressBar1;
        private Label labelPercentage;
    }
}