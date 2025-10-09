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
            panel1 = new Panel();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView_archived).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView_archived
            // 
            dataGridView_archived.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_archived.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView_archived.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_archived.Location = new Point(20, 24);
            dataGridView_archived.Margin = new Padding(4, 4, 4, 4);
            dataGridView_archived.Name = "dataGridView_archived";
            dataGridView_archived.ReadOnly = true;
            dataGridView_archived.RowHeadersVisible = false;
            dataGridView_archived.RowHeadersWidth = 51;
            dataGridView_archived.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_archived.Size = new Size(895, 455);
            dataGridView_archived.TabIndex = 0;
            dataGridView_archived.CellContentClick += dataGridView_archived_CellContentClick;
            // 
            // button_unarchive
            // 
            button_unarchive.BackColor = Color.Salmon;
            button_unarchive.ForeColor = SystemColors.ButtonHighlight;
            button_unarchive.Location = new Point(890, 27);
            button_unarchive.Margin = new Padding(4, 4, 4, 4);
            button_unarchive.Name = "button_unarchive";
            button_unarchive.Size = new Size(62, 50);
            button_unarchive.TabIndex = 1;
            button_unarchive.Text = "📤";
            button_unarchive.UseVisualStyleBackColor = false;
            button_unarchive.Click += button_unarchive_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(dataGridView_archived);
            panel1.Location = new Point(21, 94);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(931, 504);
            panel1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gadugi", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(21, 29);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(307, 38);
            label1.TabIndex = 2;
            label1.Text = "📤 Manage Archive";
            // 
            // archived_status
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(978, 609);
            Controls.Add(label1);
            Controls.Add(button_unarchive);
            Controls.Add(panel1);
            Margin = new Padding(4, 4, 4, 4);
            Name = "archived_status";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Laundry Attendant | Archived Status";
            Load += archived_status_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView_archived).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView_archived;
        private Button button_unarchive;
        private Panel panel1;
        private Label label1;
    }
}