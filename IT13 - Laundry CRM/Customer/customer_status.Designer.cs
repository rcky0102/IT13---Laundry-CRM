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
            SuspendLayout();
            // 
            // flowlayoutpanel_status
            // 
            flowlayoutpanel_status.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowlayoutpanel_status.Location = new Point(206, 168);
            flowlayoutpanel_status.Name = "flowlayoutpanel_status";
            flowlayoutpanel_status.Size = new Size(726, 277);
            flowlayoutpanel_status.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Location = new Point(212, 163);
            panel3.Name = "panel3";
            panel3.Size = new Size(721, 125);
            panel3.TabIndex = 7;
            // 
            // label_welcome
            // 
            label_welcome.AutoSize = true;
            label_welcome.Font = new Font("Cascadia Code", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_welcome.ForeColor = SystemColors.ActiveCaptionText;
            label_welcome.Location = new Point(239, 73);
            label_welcome.Name = "label_welcome";
            label_welcome.Size = new Size(143, 40);
            label_welcome.TabIndex = 5;
            label_welcome.Text = "Welcome";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gadugi", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(225, 140);
            label1.Name = "label1";
            label1.Size = new Size(134, 20);
            label1.TabIndex = 6;
            label1.Text = "Laundry Status:";
            // 
            // customer_status
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(945, 450);
            Controls.Add(flowlayoutpanel_status);
            Controls.Add(label1);
            Controls.Add(label_welcome);
            Controls.Add(panel3);
            Margin = new Padding(4);
            Name = "customer_status";
            ShowInTaskbar = false;
            Text = "Customer | Status";
            Load += customer_status_Load;
            Controls.SetChildIndex(panel3, 0);
            Controls.SetChildIndex(label_welcome, 0);
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(flowlayoutpanel_status, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private FlowLayoutPanel flowlayoutpanel_status;
        private Label label_welcome;
        private Label label1;
        private Panel panel3;
    }
}