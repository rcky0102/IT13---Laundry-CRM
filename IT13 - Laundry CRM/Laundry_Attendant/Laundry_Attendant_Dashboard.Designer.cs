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
            panel3 = new Panel();
            label4 = new Label();
            panel4 = new Panel();
            label5 = new Label();
            panel5 = new Panel();
            label7 = new Label();
            panel6 = new Panel();
            label6 = new Label();
            panel7 = new Panel();
            label10 = new Label();
            panel8 = new Panel();
            label9 = new Label();
            panel9 = new Panel();
            label8 = new Label();
            panel10 = new Panel();
            panel11 = new Panel();
            label11 = new Label();
            label3 = new Label();
            label12 = new Label();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            panel9.SuspendLayout();
            panel10.SuspendLayout();
            panel11.SuspendLayout();
            SuspendLayout();
            // 
            // label_pending
            // 
            label_pending.AutoSize = true;
            label_pending.Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_pending.ForeColor = SystemColors.ButtonHighlight;
            label_pending.Location = new Point(-1, -2);
            label_pending.Margin = new Padding(4, 0, 4, 0);
            label_pending.Name = "label_pending";
            label_pending.Size = new Size(87, 24);
            label_pending.TabIndex = 3;
            label_pending.Text = "Pending";
            // 
            // label_washing
            // 
            label_washing.AutoSize = true;
            label_washing.Location = new Point(-2, 0);
            label_washing.Margin = new Padding(4, 0, 4, 0);
            label_washing.Name = "label_washing";
            label_washing.Size = new Size(73, 21);
            label_washing.TabIndex = 4;
            label_washing.Text = "Washing";
            // 
            // label_drying
            // 
            label_drying.AutoSize = true;
            label_drying.Location = new Point(-2, 0);
            label_drying.Margin = new Padding(4, 0, 4, 0);
            label_drying.Name = "label_drying";
            label_drying.Size = new Size(64, 21);
            label_drying.TabIndex = 5;
            label_drying.Text = "Drying";
            // 
            // label_ironing
            // 
            label_ironing.AutoSize = true;
            label_ironing.Location = new Point(-3, -2);
            label_ironing.Margin = new Padding(4, 0, 4, 0);
            label_ironing.Name = "label_ironing";
            label_ironing.Size = new Size(73, 21);
            label_ironing.TabIndex = 6;
            label_ironing.Text = "Ironing";
            // 
            // label_ready
            // 
            label_ready.AutoSize = true;
            label_ready.Location = new Point(-2, 0);
            label_ready.Margin = new Padding(4, 0, 4, 0);
            label_ready.Name = "label_ready";
            label_ready.Size = new Size(55, 21);
            label_ready.TabIndex = 7;
            label_ready.Text = "Ready";
            // 
            // label_completed
            // 
            label_completed.AutoSize = true;
            label_completed.Location = new Point(-2, -2);
            label_completed.Margin = new Padding(4, 0, 4, 0);
            label_completed.Name = "label_completed";
            label_completed.Size = new Size(82, 21);
            label_completed.TabIndex = 8;
            label_completed.Text = "Complete";
            // 
            // label_cancelled
            // 
            label_cancelled.AutoSize = true;
            label_cancelled.Location = new Point(-2, 0);
            label_cancelled.Margin = new Padding(4, 0, 4, 0);
            label_cancelled.Name = "label_cancelled";
            label_cancelled.Size = new Size(91, 21);
            label_cancelled.TabIndex = 9;
            label_cancelled.Text = "Cancelled";
            // 
            // label_onhold
            // 
            label_onhold.AutoSize = true;
            label_onhold.Location = new Point(-2, 0);
            label_onhold.Margin = new Padding(4, 0, 4, 0);
            label_onhold.Name = "label_onhold";
            label_onhold.Size = new Size(64, 21);
            label_onhold.TabIndex = 10;
            label_onhold.Text = "Onhold";
            // 
            // label_welcome
            // 
            label_welcome.AutoSize = true;
            label_welcome.BackColor = SystemColors.ButtonHighlight;
            label_welcome.Font = new Font("Cascadia Code SemiBold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_welcome.ForeColor = SystemColors.ActiveCaptionText;
            label_welcome.Location = new Point(260, 72);
            label_welcome.Margin = new Padding(4, 0, 4, 0);
            label_welcome.Name = "label_welcome";
            label_welcome.Size = new Size(188, 47);
            label_welcome.TabIndex = 11;
            label_welcome.Text = "Welcome!";
            // 
            // label_message
            // 
            label_message.AutoSize = true;
            label_message.Font = new Font("Cascadia Code SemiLight", 8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label_message.Location = new Point(4, 5);
            label_message.Margin = new Padding(4, 0, 4, 0);
            label_message.Name = "label_message";
            label_message.Size = new Size(73, 21);
            label_message.TabIndex = 12;
            label_message.Text = "Message";
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel3.BackColor = SystemColors.HotTrack;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label_pending);
            panel3.Font = new Font("Cascadia Code SemiLight", 8F);
            panel3.ForeColor = SystemColors.ButtonHighlight;
            panel3.Location = new Point(308, 175);
            panel3.Name = "panel3";
            panel3.Size = new Size(174, 88);
            panel3.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(135, 62);
            label4.Name = "label4";
            label4.Size = new Size(32, 21);
            label4.TabIndex = 19;
            label4.Text = "⏳";
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            panel4.BackColor = Color.RoyalBlue;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(label5);
            panel4.Controls.Add(label_ready);
            panel4.Font = new Font("Cascadia Code SemiLight", 8F);
            panel4.ForeColor = SystemColors.ButtonHighlight;
            panel4.Location = new Point(519, 175);
            panel4.Name = "panel4";
            panel4.Size = new Size(174, 88);
            panel4.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(130, 58);
            label5.Name = "label5";
            label5.Size = new Size(32, 21);
            label5.TabIndex = 20;
            label5.Text = "✅";
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            panel5.BackColor = Color.RoyalBlue;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(label7);
            panel5.Controls.Add(label_drying);
            panel5.Font = new Font("Cascadia Code SemiLight", 8F);
            panel5.ForeColor = SystemColors.ButtonHighlight;
            panel5.Location = new Point(935, 176);
            panel5.Name = "panel5";
            panel5.Size = new Size(177, 88);
            panel5.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(138, 62);
            label7.Name = "label7";
            label7.Size = new Size(32, 21);
            label7.TabIndex = 20;
            label7.Text = "💨";
            // 
            // panel6
            // 
            panel6.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            panel6.BackColor = SystemColors.HotTrack;
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(label6);
            panel6.Controls.Add(label_washing);
            panel6.Font = new Font("Cascadia Code SemiLight", 8F);
            panel6.ForeColor = SystemColors.ButtonHighlight;
            panel6.Location = new Point(726, 175);
            panel6.Name = "panel6";
            panel6.Size = new Size(174, 88);
            panel6.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(135, 59);
            label6.Name = "label6";
            label6.Size = new Size(32, 21);
            label6.TabIndex = 20;
            label6.Text = "\U0001f9fc";
            // 
            // panel7
            // 
            panel7.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            panel7.BackColor = Color.RoyalBlue;
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Controls.Add(label10);
            panel7.Controls.Add(label_onhold);
            panel7.Font = new Font("Cascadia Code SemiLight", 8F);
            panel7.ForeColor = SystemColors.ButtonHighlight;
            panel7.Location = new Point(726, 277);
            panel7.Name = "panel7";
            panel7.Size = new Size(174, 88);
            panel7.TabIndex = 16;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(135, 60);
            label10.Name = "label10";
            label10.Size = new Size(32, 21);
            label10.TabIndex = 20;
            label10.Text = "⏸️";
            // 
            // panel8
            // 
            panel8.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            panel8.BackColor = SystemColors.HotTrack;
            panel8.BorderStyle = BorderStyle.FixedSingle;
            panel8.Controls.Add(label9);
            panel8.Controls.Add(label_completed);
            panel8.Font = new Font("Cascadia Code SemiLight", 8F);
            panel8.ForeColor = SystemColors.ButtonHighlight;
            panel8.Location = new Point(519, 277);
            panel8.Name = "panel8";
            panel8.Size = new Size(174, 88);
            panel8.TabIndex = 16;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(135, 62);
            label9.Name = "label9";
            label9.Size = new Size(32, 21);
            label9.TabIndex = 20;
            label9.Text = "✨";
            // 
            // panel9
            // 
            panel9.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            panel9.BackColor = Color.RoyalBlue;
            panel9.BorderStyle = BorderStyle.FixedSingle;
            panel9.Controls.Add(label8);
            panel9.Controls.Add(label_ironing);
            panel9.Font = new Font("Cascadia Code SemiLight", 8F);
            panel9.ForeColor = SystemColors.ButtonHighlight;
            panel9.Location = new Point(309, 275);
            panel9.Name = "panel9";
            panel9.Size = new Size(173, 88);
            panel9.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(134, 60);
            label8.Name = "label8";
            label8.Size = new Size(32, 21);
            label8.TabIndex = 20;
            label8.Text = "👔";
            // 
            // panel10
            // 
            panel10.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel10.BorderStyle = BorderStyle.Fixed3D;
            panel10.Controls.Add(label_message);
            panel10.Location = new Point(308, 430);
            panel10.Name = "panel10";
            panel10.Size = new Size(863, 100);
            panel10.TabIndex = 17;
            // 
            // panel11
            // 
            panel11.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            panel11.BackColor = SystemColors.HotTrack;
            panel11.BorderStyle = BorderStyle.FixedSingle;
            panel11.Controls.Add(label11);
            panel11.Controls.Add(label_cancelled);
            panel11.Font = new Font("Cascadia Code SemiLight", 8F);
            panel11.ForeColor = SystemColors.ButtonHighlight;
            panel11.Location = new Point(935, 276);
            panel11.Name = "panel11";
            panel11.Size = new Size(177, 88);
            panel11.TabIndex = 16;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(138, 61);
            label11.Name = "label11";
            label11.Size = new Size(32, 21);
            label11.TabIndex = 20;
            label11.Text = "❌";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cascadia Code SemiLight", 10F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(308, 132);
            label3.Name = "label3";
            label3.Size = new Size(192, 27);
            label3.TabIndex = 18;
            label3.Text = "Order Overview:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Cascadia Code", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(260, 395);
            label12.Name = "label12";
            label12.Size = new Size(182, 32);
            label12.TabIndex = 13;
            label12.Text = "New Message:";
            // 
            // Laundry_Attendant_Dashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1184, 552);
            Controls.Add(label12);
            Controls.Add(label3);
            Controls.Add(panel11);
            Controls.Add(panel9);
            Controls.Add(panel8);
            Controls.Add(panel7);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(label_welcome);
            Controls.Add(panel3);
            Controls.Add(panel4);
            Controls.Add(panel10);
            Margin = new Padding(5);
            Name = "Laundry_Attendant_Dashboard";
            Text = "Laundry_Attendant_Dashboard";
            Load += Laundry_Attendant_Dashboard_Load;
            Controls.SetChildIndex(panel10, 0);
            Controls.SetChildIndex(panel4, 0);
            Controls.SetChildIndex(panel3, 0);
            Controls.SetChildIndex(label_welcome, 0);
            Controls.SetChildIndex(panel5, 0);
            Controls.SetChildIndex(panel6, 0);
            Controls.SetChildIndex(panel7, 0);
            Controls.SetChildIndex(panel8, 0);
            Controls.SetChildIndex(panel9, 0);
            Controls.SetChildIndex(panel11, 0);
            Controls.SetChildIndex(label3, 0);
            Controls.SetChildIndex(label12, 0);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
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
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Panel panel7;
        private Panel panel8;
        private Panel panel9;
        private Panel panel10;
        private Panel panel11;
        private Label label4;
        private Label label3;
        private Label label5;
        private Label label7;
        private Label label6;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label11;
        private Label label12;
    }
}