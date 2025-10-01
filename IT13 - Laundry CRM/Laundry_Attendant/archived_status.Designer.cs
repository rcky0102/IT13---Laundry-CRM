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
            ((System.ComponentModel.ISupportInitialize)dataGridView_archived).BeginInit();
            SuspendLayout();
            // 
            // dataGridView_archived
            // 
            dataGridView_archived.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_archived.Location = new Point(74, 178);
            dataGridView_archived.Name = "dataGridView_archived";
            dataGridView_archived.RowHeadersWidth = 51;
            dataGridView_archived.Size = new Size(632, 188);
            dataGridView_archived.TabIndex = 0;
            // 
            // button_unarchive
            // 
            button_unarchive.Location = new Point(585, 124);
            button_unarchive.Name = "button_unarchive";
            button_unarchive.Size = new Size(94, 29);
            button_unarchive.TabIndex = 1;
            button_unarchive.Text = "Unarchive";
            button_unarchive.UseVisualStyleBackColor = true;
            button_unarchive.Click += button_unarchive_Click;
            // 
            // archived_status
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_unarchive);
            Controls.Add(dataGridView_archived);
            Name = "archived_status";
            Text = "archived_status";
            Load += archived_status_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView_archived).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView_archived;
        private Button button_unarchive;
    }
}