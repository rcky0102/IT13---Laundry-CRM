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
            label1 = new Label();
            label_welcome = new Label();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // flowlayoutpanel_status
            // 
            flowlayoutpanel_status.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            flowlayoutpanel_status.AutoScroll = true;
            flowlayoutpanel_status.BackColor = SystemColors.Window;
            flowlayoutpanel_status.Font = new Font("Gadugi", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            flowlayoutpanel_status.Location = new Point(272, 150);
            flowlayoutpanel_status.Name = "flowlayoutpanel_status";
            flowlayoutpanel_status.Size = new Size(639, 86);
            flowlayoutpanel_status.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.AutoScroll = true;
            panel3.BackColor = SystemColors.GradientInactiveCaption;
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Font = new Font("Gadugi", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel3.Location = new Point(224, 280);
            panel3.Name = "panel3";
            panel3.Size = new Size(687, 170);
            panel3.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gadugi", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(239, 266);
            label1.Name = "label1";
            label1.Size = new Size(172, 24);
            label1.TabIndex = 6;
            label1.Text = "🕒 Status History";
            // 
            // label_welcome
            // 
            label_welcome.AutoSize = true;
            label_welcome.Font = new Font("Gadugi", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_welcome.ForeColor = SystemColors.ActiveCaptionText;
            label_welcome.Location = new Point(239, 77);
            label_welcome.Name = "label_welcome";
            label_welcome.Size = new Size(140, 35);
            label_welcome.TabIndex = 5;
            label_welcome.Text = "Welcome";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BackColor = SystemColors.GradientActiveCaption;
            pictureBox1.Location = new Point(224, 121);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(687, 10);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox3.BackColor = SystemColors.GradientActiveCaption;
            pictureBox3.Location = new Point(224, 242);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(687, 10);
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
            // 
            // customer_status
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(923, 480);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox1);
            Controls.Add(label_welcome);
            Controls.Add(label1);
            Controls.Add(panel3);
            Controls.Add(flowlayoutpanel_status);
            Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "customer_status";
            ShowInTaskbar = false;
            Text = "Customer | Status";
            Load += customer_status_Load;
            Controls.SetChildIndex(flowlayoutpanel_status, 0);
            Controls.SetChildIndex(panel3, 0);
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(label_welcome, 0);
            Controls.SetChildIndex(pictureBox1, 0);
            Controls.SetChildIndex(pictureBox3, 0);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private FlowLayoutPanel flowlayoutpanel_status;
        private Label label1;
        private Panel panel3;
        private Label label_welcome;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
    }
}