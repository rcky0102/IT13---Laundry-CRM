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
            label1 = new Label();
            button_unarchive = new Button();
            panel1 = new Panel();
            dataGridView_archived = new DataGridView();
            panel2 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_archived).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Code SemiBold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 6);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(349, 43);
            label1.TabIndex = 6;
            label1.Text = "📤 Manage Archive";
            // 
            // button_unarchive
            // 
            button_unarchive.BackColor = Color.CornflowerBlue;
            button_unarchive.ForeColor = SystemColors.ButtonHighlight;
            button_unarchive.Location = new Point(876, 8);
            button_unarchive.Margin = new Padding(4, 4, 4, 4);
            button_unarchive.Name = "button_unarchive";
            button_unarchive.Size = new Size(49, 41);
            button_unarchive.TabIndex = 5;
            button_unarchive.Text = "📤";
            button_unarchive.UseVisualStyleBackColor = false;
            button_unarchive.Click += button_unarchive_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(dataGridView_archived);
            panel1.Location = new Point(11, 97);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(967, 494);
            panel1.TabIndex = 7;
            // 
            // dataGridView_archived
            // 
            dataGridView_archived.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_archived.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView_archived.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_archived.Location = new Point(13, 22);
            dataGridView_archived.Margin = new Padding(4, 4, 4, 4);
            dataGridView_archived.Name = "dataGridView_archived";
            dataGridView_archived.ReadOnly = true;
            dataGridView_archived.RowHeadersVisible = false;
            dataGridView_archived.RowHeadersWidth = 51;
            dataGridView_archived.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_archived.Size = new Size(934, 470);
            dataGridView_archived.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(button_unarchive);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(12, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(954, 64);
            panel2.TabIndex = 8;
            // 
            // archived_feedback
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(978, 602);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Margin = new Padding(4, 4, 4, 4);
            Name = "archived_feedback";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "archived_feedback";
            Load += archived_feedback_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_archived).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button button_unarchive;
        private Panel panel1;
        private DataGridView dataGridView_archived;
        private Panel panel2;
    }
}