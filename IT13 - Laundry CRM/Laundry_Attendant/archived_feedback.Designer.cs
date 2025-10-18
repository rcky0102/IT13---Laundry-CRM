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
            txtSearch = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView_archived).BeginInit();
            SuspendLayout();
            // 
            // button_unarchive
            // 
            button_unarchive.BackColor = SystemColors.Highlight;
            button_unarchive.FlatAppearance.BorderSize = 0;
            button_unarchive.FlatStyle = FlatStyle.Flat;
            button_unarchive.Font = new Font("Gadugi", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_unarchive.ForeColor = SystemColors.ButtonHighlight;
            button_unarchive.Location = new Point(720, 20);
            button_unarchive.Name = "button_unarchive";
            button_unarchive.Size = new Size(50, 40);
            button_unarchive.TabIndex = 5;
            button_unarchive.Text = "📤";
            button_unarchive.UseVisualStyleBackColor = false;
            button_unarchive.Click += button_unarchive_Click;
            // 
            // dataGridView_archived
            // 
            dataGridView_archived.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_archived.BackgroundColor = SystemColors.GradientInactiveCaption;
            dataGridView_archived.BorderStyle = BorderStyle.None;
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
            // txtSearch
            // 
            txtSearch.BackColor = SystemColors.ButtonFace;
            txtSearch.BorderStyle = BorderStyle.None;
            txtSearch.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(35, 30);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "🔎 Search via subject, first name, last name, or date";
            txtSearch.Size = new Size(250, 30);
            txtSearch.TabIndex = 9;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // archived_feedback
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(782, 482);
            Controls.Add(txtSearch);
            Controls.Add(dataGridView_archived);
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
        private TextBox txtSearch;
    }
}