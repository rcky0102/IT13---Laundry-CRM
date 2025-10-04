namespace IT13___Laundry_CRM.Laundry_Attendant
{
    partial class archived_status
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
            dataGridView_archived = new DataGridView();
            button_unarchive = new Button();
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView_archived).BeginInit();
            SuspendLayout();
            // 
            // dataGridView_archived
            // 
            dataGridView_archived.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView_archived.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_archived.Location = new Point(21, 151);
            dataGridView_archived.Margin = new Padding(4, 4, 4, 4);
            dataGridView_archived.Name = "dataGridView_archived";
            dataGridView_archived.RowHeadersWidth = 51;
            dataGridView_archived.Size = new Size(790, 235);
            dataGridView_archived.TabIndex = 0;
            // 
            // button_unarchive
            // 
            button_unarchive.BackColor = Color.Chocolate;
            button_unarchive.ForeColor = SystemColors.ButtonHighlight;
            button_unarchive.Location = new Point(762, 82);
            button_unarchive.Margin = new Padding(4, 4, 4, 4);
            button_unarchive.Name = "button_unarchive";
            button_unarchive.Size = new Size(49, 36);
            button_unarchive.TabIndex = 1;
            button_unarchive.Text = "📤";
            button_unarchive.UseVisualStyleBackColor = false;
            button_unarchive.Click += button_unarchive_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Code SemiBold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 9);
            label1.Name = "label1";
            label1.Size = new Size(349, 43);
            label1.TabIndex = 2;
            label1.Text = "📤 Manage Archive";
            // 
            // label2
            // 
            label2.Font = new Font("Cascadia Code SemiLight", 8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(75, 56);
            label2.Name = "label2";
            label2.Size = new Size(679, 51);
            label2.TabIndex = 3;
            label2.Text = "Access and review your past laundry orders and messages for easy reference and record-keeping";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Location = new Point(0, 125);
            panel1.Name = "panel1";
            panel1.Size = new Size(826, 275);
            panel1.TabIndex = 4;
            // 
            // archived_status
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(820, 393);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button_unarchive);
            Controls.Add(dataGridView_archived);
            Controls.Add(panel1);
            Margin = new Padding(4, 4, 4, 4);
            Name = "archived_status";
            Text = "archived_status";
            Load += archived_status_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView_archived).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView_archived;
        private Button button_unarchive;
        private Label label1;
        private Label label2;
        private Panel panel1;
    }
}