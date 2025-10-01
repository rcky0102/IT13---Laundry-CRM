namespace IT13___Laundry_CRM
{
    partial class Laundry_Attendant_Dashboard
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
            label_pending = new Label();
            label_washing = new Label();
            label_drying = new Label();
            label_ironing = new Label();
            label_ready = new Label();
            label_completed = new Label();
            label_cancelled = new Label();
            label_onhold = new Label();
            label_welcome = new Label();
            label_message = new Label();
            SuspendLayout();
            // 
            // label_pending
            // 
            label_pending.AutoSize = true;
            label_pending.Location = new Point(285, 162);
            label_pending.Name = "label_pending";
            label_pending.Size = new Size(50, 20);
            label_pending.TabIndex = 3;
            label_pending.Text = "label3";
            // 
            // label_washing
            // 
            label_washing.AutoSize = true;
            label_washing.Location = new Point(286, 190);
            label_washing.Name = "label_washing";
            label_washing.Size = new Size(50, 20);
            label_washing.TabIndex = 4;
            label_washing.Text = "label4";
            // 
            // label_drying
            // 
            label_drying.AutoSize = true;
            label_drying.Location = new Point(293, 224);
            label_drying.Name = "label_drying";
            label_drying.Size = new Size(50, 20);
            label_drying.TabIndex = 5;
            label_drying.Text = "label5";
            // 
            // label_ironing
            // 
            label_ironing.AutoSize = true;
            label_ironing.Location = new Point(286, 259);
            label_ironing.Name = "label_ironing";
            label_ironing.Size = new Size(50, 20);
            label_ironing.TabIndex = 6;
            label_ironing.Text = "label6";
            // 
            // label_ready
            // 
            label_ready.AutoSize = true;
            label_ready.Location = new Point(293, 294);
            label_ready.Name = "label_ready";
            label_ready.Size = new Size(50, 20);
            label_ready.TabIndex = 7;
            label_ready.Text = "label7";
            // 
            // label_completed
            // 
            label_completed.AutoSize = true;
            label_completed.Location = new Point(300, 328);
            label_completed.Name = "label_completed";
            label_completed.Size = new Size(50, 20);
            label_completed.TabIndex = 8;
            label_completed.Text = "label8";
            // 
            // label_cancelled
            // 
            label_cancelled.AutoSize = true;
            label_cancelled.Location = new Point(303, 358);
            label_cancelled.Name = "label_cancelled";
            label_cancelled.Size = new Size(50, 20);
            label_cancelled.TabIndex = 9;
            label_cancelled.Text = "label9";
            // 
            // label_onhold
            // 
            label_onhold.AutoSize = true;
            label_onhold.Location = new Point(304, 392);
            label_onhold.Name = "label_onhold";
            label_onhold.Size = new Size(58, 20);
            label_onhold.TabIndex = 10;
            label_onhold.Text = "label10";
            // 
            // label_welcome
            // 
            label_welcome.AutoSize = true;
            label_welcome.Location = new Point(334, 84);
            label_welcome.Name = "label_welcome";
            label_welcome.Size = new Size(69, 20);
            label_welcome.TabIndex = 11;
            label_welcome.Text = "welcome";
            // 
            // label_message
            // 
            label_message.AutoSize = true;
            label_message.Location = new Point(574, 94);
            label_message.Name = "label_message";
            label_message.Size = new Size(50, 20);
            label_message.TabIndex = 12;
            label_message.Text = "label3";
            // 
            // Laundry_Attendant_Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label_message);
            Controls.Add(label_welcome);
            Controls.Add(label_onhold);
            Controls.Add(label_cancelled);
            Controls.Add(label_completed);
            Controls.Add(label_ready);
            Controls.Add(label_ironing);
            Controls.Add(label_drying);
            Controls.Add(label_washing);
            Controls.Add(label_pending);
            Name = "Laundry_Attendant_Dashboard";
            Text = "Laundry_Attendant_Dashboard";
            Load += Laundry_Attendant_Dashboard_Load;
            Controls.SetChildIndex(label_pending, 0);
            Controls.SetChildIndex(label_washing, 0);
            Controls.SetChildIndex(label_drying, 0);
            Controls.SetChildIndex(label_ironing, 0);
            Controls.SetChildIndex(label_ready, 0);
            Controls.SetChildIndex(label_completed, 0);
            Controls.SetChildIndex(label_cancelled, 0);
            Controls.SetChildIndex(label_onhold, 0);
            Controls.SetChildIndex(label_welcome, 0);
            Controls.SetChildIndex(label_message, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_pending;
        private Label label_washing;
        private Label label_drying;
        private Label label_ironing;
        private Label label_ready;
        private Label label_completed;
        private Label label_cancelled;
        private Label label_onhold;
        private Label label_welcome;
        private Label label_message;
    }
}