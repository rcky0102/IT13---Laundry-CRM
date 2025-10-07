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
            label1 = new Label();
            flowlayoutpanel_status = new FlowLayoutPanel();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Cascadia Code SemiLight", 8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(254, 132);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(619, 49);
            label1.TabIndex = 1;
            label1.Text = "“Track every step of your laundry process, from washing and drying to folding and delivery, all in one place.”";
            // 
            // flowlayoutpanel_status
            // 
            flowlayoutpanel_status.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowlayoutpanel_status.Location = new Point(209, 182);
            flowlayoutpanel_status.Name = "flowlayoutpanel_status";
            flowlayoutpanel_status.Size = new Size(726, 258);
            flowlayoutpanel_status.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cascadia Code SemiBold", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(195, 78);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(546, 45);
            label2.TabIndex = 8;
            label2.Text = "⌚View Your Laundry Status";
            // 
            // customer_status
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(945, 450);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(flowlayoutpanel_status);
            Margin = new Padding(4);
            Name = "customer_status";
            ShowInTaskbar = false;
            Text = "Customer | Status";
            Load += customer_status_Load;
            Controls.SetChildIndex(flowlayoutpanel_status, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(label1, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private FlowLayoutPanel flowlayoutpanel_status;
        private Label label2;
    }
}