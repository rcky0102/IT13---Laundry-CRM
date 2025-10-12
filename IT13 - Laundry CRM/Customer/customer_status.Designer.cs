namespace IT13___Laundry_CRM.Customer
{
    partial class customer_status
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
            flowlayoutpanel_status = new FlowLayoutPanel();
            panel3 = new Panel();
            label_welcome = new Label();
            label1 = new Label();
            panel4 = new Panel();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // flowlayoutpanel_status
            // 
            flowlayoutpanel_status.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowlayoutpanel_status.AutoScroll = true;
            flowlayoutpanel_status.BackColor = SystemColors.GradientInactiveCaption;
            flowlayoutpanel_status.Location = new Point(280, 478);
            flowlayoutpanel_status.Margin = new Padding(4);
            flowlayoutpanel_status.Name = "flowlayoutpanel_status";
            flowlayoutpanel_status.Size = new Size(1046, 224);
            flowlayoutpanel_status.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.AutoScroll = true;
            panel3.BackColor = SystemColors.ButtonHighlight;
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Location = new Point(282, 155);
            panel3.Margin = new Padding(4);
            panel3.Name = "panel3";
            panel3.Size = new Size(1046, 178);
            panel3.TabIndex = 7;
            // 
            // label_welcome
            // 
            label_welcome.AutoSize = true;
            label_welcome.Font = new Font("Gadugi", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_welcome.ForeColor = SystemColors.ActiveCaptionText;
            label_welcome.Location = new Point(5, 12);
            label_welcome.Margin = new Padding(4, 0, 4, 0);
            label_welcome.Name = "label_welcome";
            label_welcome.Size = new Size(169, 43);
            label_welcome.TabIndex = 5;
            label_welcome.Text = "Welcome";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Gadugi", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(260, 428);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(143, 24);
            label1.TabIndex = 6;
            label1.Text = "Laundry Status:";
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel4.BackColor = SystemColors.GradientInactiveCaption;
            panel4.BorderStyle = BorderStyle.Fixed3D;
            panel4.Controls.Add(label_welcome);
            panel4.Location = new Point(253, 79);
            panel4.Name = "panel4";
            panel4.Size = new Size(1092, 69);
            panel4.TabIndex = 8;
            // 
            // customer_status
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1357, 715);
            Controls.Add(label1);
            Controls.Add(flowlayoutpanel_status);
            Controls.Add(panel3);
            Controls.Add(panel4);
            Margin = new Padding(5);
            Name = "customer_status";
            ShowInTaskbar = false;
            Text = "Customer | Status";
            Load += customer_status_Load;
            Controls.SetChildIndex(panel4, 0);
            Controls.SetChildIndex(panel3, 0);
            Controls.SetChildIndex(flowlayoutpanel_status, 0);
            Controls.SetChildIndex(label1, 0);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private FlowLayoutPanel flowlayoutpanel_status;
        private Label label_welcome;
        private Label label1;
        private Panel panel3;
        private Panel panel4;
    }
}