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
            label_message = new Label();
            buttonLoadGraph = new Button();
            dateTimePickerFrom = new DateTimePicker();
            dateTimePickerTo = new DateTimePicker();
            comboBoxGrouping = new ComboBox();
            labelCustomerGraph = new Label();
            panelCustomerGraph = new Panel();
            label1 = new Label();
            label3 = new Label();
            panel3 = new Panel();
            label13 = new Label();
            panel12 = new Panel();
            label_feedback = new Label();
            label4 = new Label();
            label_welcome = new Label();
            panelCustomerGraph.SuspendLayout();
            panel3.SuspendLayout();
            panel12.SuspendLayout();
            SuspendLayout();
            // 
            // label_message
            // 
            label_message.AutoSize = true;
            label_message.Location = new Point(18, 18);
            label_message.Name = "label_message";
            label_message.Size = new Size(70, 22);
            label_message.TabIndex = 3;
            label_message.Text = "label3";
            // 
            // buttonLoadGraph
            // 
            buttonLoadGraph.BackColor = SystemColors.Highlight;
            buttonLoadGraph.ForeColor = SystemColors.ButtonHighlight;
            buttonLoadGraph.Location = new Point(254, 133);
            buttonLoadGraph.Name = "buttonLoadGraph";
            buttonLoadGraph.Size = new Size(50, 40);
            buttonLoadGraph.TabIndex = 4;
            buttonLoadGraph.Text = "🔃";
            buttonLoadGraph.UseVisualStyleBackColor = false;
            buttonLoadGraph.Click += buttonLoadGraph_Click;
            // 
            // dateTimePickerFrom
            // 
            dateTimePickerFrom.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dateTimePickerFrom.Location = new Point(617, 138);
            dateTimePickerFrom.Name = "dateTimePickerFrom";
            dateTimePickerFrom.Size = new Size(250, 27);
            dateTimePickerFrom.TabIndex = 5;
            // 
            // dateTimePickerTo
            // 
            dateTimePickerTo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dateTimePickerTo.Location = new Point(909, 138);
            dateTimePickerTo.Name = "dateTimePickerTo";
            dateTimePickerTo.Size = new Size(250, 27);
            dateTimePickerTo.TabIndex = 6;
            // 
            // comboBoxGrouping
            // 
            comboBoxGrouping.BackColor = SystemColors.ButtonFace;
            comboBoxGrouping.FormattingEnabled = true;
            comboBoxGrouping.Location = new Point(310, 137);
            comboBoxGrouping.Name = "comboBoxGrouping";
            comboBoxGrouping.Size = new Size(200, 30);
            comboBoxGrouping.TabIndex = 7;
            // 
            // labelCustomerGraph
            // 
            labelCustomerGraph.AutoSize = true;
            labelCustomerGraph.Location = new Point(37, 86);
            labelCustomerGraph.Name = "labelCustomerGraph";
            labelCustomerGraph.Size = new Size(70, 22);
            labelCustomerGraph.TabIndex = 8;
            labelCustomerGraph.Text = "label3";
            labelCustomerGraph.Click += labelCustomerGraph_Click;
            // 
            // panelCustomerGraph
            // 
            panelCustomerGraph.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelCustomerGraph.BackColor = SystemColors.ButtonHighlight;
            panelCustomerGraph.Controls.Add(labelCustomerGraph);
            panelCustomerGraph.Font = new Font("Cascadia Code", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panelCustomerGraph.Location = new Point(223, 182);
            panelCustomerGraph.Name = "panelCustomerGraph";
            panelCustomerGraph.Size = new Size(932, 575);
            panelCustomerGraph.TabIndex = 26;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(873, 140);
            label1.Name = "label1";
            label1.Size = new Size(30, 22);
            label1.TabIndex = 9;
            label1.Text = "—>";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(567, 22);
            label3.Name = "label3";
            label3.Size = new Size(30, 22);
            label3.TabIndex = 9;
            label3.Text = "—>";
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = SystemColors.GradientActiveCaption;
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(label13);
            panel3.Controls.Add(panel12);
            panel3.Location = new Point(223, 780);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(932, 205);
            panel3.TabIndex = 27;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Cascadia Code SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(2, 3);
            label13.Margin = new Padding(2, 0, 2, 0);
            label13.Name = "label13";
            label13.Size = new Size(180, 27);
            label13.TabIndex = 5;
            label13.Text = "Notifications:";
            // 
            // panel12
            // 
            panel12.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel12.BackColor = SystemColors.ButtonHighlight;
            panel12.Controls.Add(label_feedback);
            panel12.Controls.Add(label_message);
            panel12.Location = new Point(17, 46);
            panel12.Margin = new Padding(0);
            panel12.Name = "panel12";
            panel12.Size = new Size(893, 139);
            panel12.TabIndex = 6;
            // 
            // label_feedback
            // 
            label_feedback.AutoSize = true;
            label_feedback.Location = new Point(18, 72);
            label_feedback.Name = "label_feedback";
            label_feedback.Size = new Size(170, 22);
            label_feedback.TabIndex = 2;
            label_feedback.Text = "Latest Feedback:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cascadia Code SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(2, 3);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(204, 27);
            label4.TabIndex = 5;
            label4.Text = "Latest Feedback:";
            // 
            // label_welcome
            // 
            label_welcome.AutoSize = true;
            label_welcome.BackColor = SystemColors.ButtonHighlight;
            label_welcome.Font = new Font("Cascadia Code SemiBold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_welcome.ForeColor = SystemColors.ActiveCaptionText;
            label_welcome.Location = new Point(242, 79);
            label_welcome.Name = "label_welcome";
            label_welcome.Size = new Size(161, 40);
            label_welcome.TabIndex = 28;
            label_welcome.Text = "Welcome!";
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1167, 1006);
            Controls.Add(label1);
            Controls.Add(label_welcome);
            Controls.Add(panel3);
            Controls.Add(dateTimePickerTo);
            Controls.Add(panelCustomerGraph);
            Controls.Add(comboBoxGrouping);
            Controls.Add(dateTimePickerFrom);
            Controls.Add(buttonLoadGraph);
            Margin = new Padding(5, 3, 5, 3);
            Name = "AdminForm";
            Text = "Admin | Dashboard";
            Load += AdminForm_Load;
            Controls.SetChildIndex(buttonLoadGraph, 0);
            Controls.SetChildIndex(dateTimePickerFrom, 0);
            Controls.SetChildIndex(comboBoxGrouping, 0);
            Controls.SetChildIndex(panelCustomerGraph, 0);
            Controls.SetChildIndex(dateTimePickerTo, 0);
            Controls.SetChildIndex(panel3, 0);
            Controls.SetChildIndex(label_welcome, 0);
            Controls.SetChildIndex(label1, 0);
            panelCustomerGraph.ResumeLayout(false);
            panelCustomerGraph.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel12.ResumeLayout(false);
            panel12.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label_message;
        private Button buttonLoadGraph;
        private DateTimePicker dateTimePickerFrom;
        private DateTimePicker dateTimePickerTo;
        private ComboBox comboBoxGrouping;
        private Label labelCustomerGraph;
        private Panel panelCustomerGraph;
        private Label label3;
        private Panel panel3;
        private Label label13;
        private Panel panel12;
        private Label label_feedback;
        private Label label4;
        private Label label1;
        private Label label_welcome;
    }
}