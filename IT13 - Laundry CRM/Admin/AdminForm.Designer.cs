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
            buttonLoadGraph = new Button();
            dateTimePickerFrom = new DateTimePicker();
            dateTimePickerTo = new DateTimePicker();
            comboBoxGrouping = new ComboBox();
            labelCustomerGraph = new Label();
            SuspendLayout();
            // 
            // label_feedback
            // 
            label_feedback.AutoSize = true;
            label_feedback.Location = new Point(358, 365);
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
            // buttonLoadGraph
            // 
            buttonLoadGraph.Location = new Point(275, 91);
            buttonLoadGraph.Name = "buttonLoadGraph";
            buttonLoadGraph.Size = new Size(94, 29);
            buttonLoadGraph.TabIndex = 4;
            buttonLoadGraph.Text = "Load";
            buttonLoadGraph.UseVisualStyleBackColor = true;
            buttonLoadGraph.Click += buttonLoadGraph_Click;
            // 
            // dateTimePickerFrom
            // 
            dateTimePickerFrom.Location = new Point(470, 93);
            dateTimePickerFrom.Name = "dateTimePickerFrom";
            dateTimePickerFrom.Size = new Size(250, 27);
            dateTimePickerFrom.TabIndex = 5;
            // 
            // dateTimePickerTo
            // 
            dateTimePickerTo.Location = new Point(749, 93);
            dateTimePickerTo.Name = "dateTimePickerTo";
            dateTimePickerTo.Size = new Size(250, 27);
            dateTimePickerTo.TabIndex = 6;
            // 
            // comboBoxGrouping
            // 
            comboBoxGrouping.FormattingEnabled = true;
            comboBoxGrouping.Location = new Point(277, 134);
            comboBoxGrouping.Name = "comboBoxGrouping";
            comboBoxGrouping.Size = new Size(151, 30);
            comboBoxGrouping.TabIndex = 7;
            // 
            // labelCustomerGraph
            // 
            labelCustomerGraph.AutoSize = true;
            labelCustomerGraph.Location = new Point(299, 210);
            labelCustomerGraph.Name = "labelCustomerGraph";
            labelCustomerGraph.Size = new Size(70, 22);
            labelCustomerGraph.TabIndex = 8;
            labelCustomerGraph.Text = "label3";
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1090, 551);
            Controls.Add(labelCustomerGraph);
            Controls.Add(comboBoxGrouping);
            Controls.Add(dateTimePickerTo);
            Controls.Add(dateTimePickerFrom);
            Controls.Add(buttonLoadGraph);
            Controls.Add(label_message);
            Controls.Add(label_feedback);
            Margin = new Padding(5, 3, 5, 3);
            Name = "AdminForm";
            Text = "AdminForm";
            Load += AdminForm_Load;
            Controls.SetChildIndex(label_feedback, 0);
            Controls.SetChildIndex(label_message, 0);
            Controls.SetChildIndex(buttonLoadGraph, 0);
            Controls.SetChildIndex(dateTimePickerFrom, 0);
            Controls.SetChildIndex(dateTimePickerTo, 0);
            Controls.SetChildIndex(comboBoxGrouping, 0);
            Controls.SetChildIndex(labelCustomerGraph, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_feedback;
        private Label label_message;
        private Button buttonLoadGraph;
        private DateTimePicker dateTimePickerFrom;
        private DateTimePicker dateTimePickerTo;
        private ComboBox comboBoxGrouping;
        private Label labelCustomerGraph;
    }
}