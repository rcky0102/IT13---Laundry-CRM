namespace IT13___Laundry_CRM.Laundry_Attendant
{
    partial class archived_feedback
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
            button_unarchive = new Button();
            dataGridView_archived = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView_archived).BeginInit();
            SuspendLayout();
            // 
            // button_unarchive
            // 
            button_unarchive.BackColor = SystemColors.Highlight;
            button_unarchive.ForeColor = SystemColors.ButtonHighlight;
            button_unarchive.Location = new Point(718, 32);
            button_unarchive.Name = "button_unarchive";
            button_unarchive.Size = new Size(39, 33);
            button_unarchive.TabIndex = 5;
            button_unarchive.Text = "📤";
            button_unarchive.UseVisualStyleBackColor = false;
            button_unarchive.Click += button_unarchive_Click;
            // 
            // dataGridView_archived
            // 
            dataGridView_archived.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_archived.BackgroundColor = SystemColors.GradientInactiveCaption;
            dataGridView_archived.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_archived.Location = new Point(12, 75);
            dataGridView_archived.Name = "dataGridView_archived";
            dataGridView_archived.ReadOnly = true;
            dataGridView_archived.RowHeadersVisible = false;
            dataGridView_archived.RowHeadersWidth = 51;
            dataGridView_archived.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_archived.Size = new Size(758, 395);
            dataGridView_archived.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Code SemiBold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(34, 25);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(239, 35);
            label1.TabIndex = 6;
            label1.Text = "Manage Archive";
            label1.Click += label1_Click;
            // 
            // archived_feedback
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(782, 482);
            Controls.Add(dataGridView_archived);
            Controls.Add(label1);
            Controls.Add(button_unarchive);
            Name = "archived_feedback";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "archived_feedback";
            Load += archived_feedback_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView_archived).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button_unarchive;
        private DataGridView dataGridView_archived;
        private Label label1;
    }
}