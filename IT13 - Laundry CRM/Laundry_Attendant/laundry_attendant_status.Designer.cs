namespace IT13___Laundry_CRM.Laundry_Attendant
{
    partial class laundry_attendant_status
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
            table_customers = new DataGridView();
            button_edit = new Button();
            button_add = new Button();
            button_archive = new Button();
            label1 = new Label();
            panel2 = new Panel();
            SearchBtn_Status = new Button();
            textBox1 = new TextBox();
            button1 = new Button();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)table_customers).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // table_customers
            // 
            table_customers.BackgroundColor = SystemColors.ButtonHighlight;
            table_customers.BorderStyle = BorderStyle.Fixed3D;
            table_customers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            table_customers.Location = new Point(259, 186);
            table_customers.Margin = new Padding(4);
            table_customers.Name = "table_customers";
            table_customers.RowHeadersWidth = 51;
            table_customers.Size = new Size(909, 363);
            table_customers.TabIndex = 1;
            table_customers.CellContentClick += table_customers_CellContentClick;
            // 
            // button_edit
            // 
            button_edit.BackColor = Color.MediumSeaGreen;
            button_edit.FlatAppearance.BorderSize = 0;
            button_edit.ForeColor = SystemColors.ButtonHighlight;
            button_edit.Location = new Point(789, 17);
            button_edit.Margin = new Padding(4);
            button_edit.Name = "button_edit";
            button_edit.Size = new Size(47, 36);
            button_edit.TabIndex = 2;
            button_edit.Text = "✏️";
            button_edit.UseVisualStyleBackColor = false;
            button_edit.Click += button_edit_Click;
            // 
            // button_add
            // 
            button_add.BackColor = Color.RoyalBlue;
            button_add.FlatAppearance.BorderSize = 0;
            button_add.ForeColor = SystemColors.ButtonHighlight;
            button_add.Location = new Point(18, 19);
            button_add.Margin = new Padding(4);
            button_add.Name = "button_add";
            button_add.Size = new Size(118, 36);
            button_add.TabIndex = 3;
            button_add.Text = "➕Add ";
            button_add.UseVisualStyleBackColor = false;
            button_add.Click += button_add_Click;
            // 
            // button_archive
            // 
            button_archive.BackColor = Color.Orange;
            button_archive.ForeColor = SystemColors.ButtonHighlight;
            button_archive.Location = new Point(844, 18);
            button_archive.Margin = new Padding(4);
            button_archive.Name = "button_archive";
            button_archive.Size = new Size(51, 36);
            button_archive.TabIndex = 4;
            button_archive.Text = "📦";
            button_archive.UseVisualStyleBackColor = false;
            button_archive.Click += button_archive_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Code SemiLight", 8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaption;
            label1.Location = new Point(327, 56);
            label1.Name = "label1";
            label1.Size = new Size(622, 21);
            label1.TabIndex = 5;
            label1.Text = "Laundry Status: In Progress: 5 | Ready for Pickup: 2 | Completed: 10";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(SearchBtn_Status);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(button_add);
            panel2.Controls.Add(button_archive);
            panel2.Controls.Add(button_edit);
            panel2.Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel2.Location = new Point(259, 108);
            panel2.Name = "panel2";
            panel2.Size = new Size(909, 71);
            panel2.TabIndex = 6;
            // 
            // SearchBtn_Status
            // 
            SearchBtn_Status.Location = new Point(321, 19);
            SearchBtn_Status.Name = "SearchBtn_Status";
            SearchBtn_Status.Size = new Size(41, 34);
            SearchBtn_Status.TabIndex = 6;
            SearchBtn_Status.Text = "🔎";
            SearchBtn_Status.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(368, 22);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(414, 28);
            textBox1.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(240, 19);
            button1.Name = "button1";
            button1.Size = new Size(41, 34);
            button1.TabIndex = 6;
            button1.Text = "🔎";
            button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cascadia Code SemiBold", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaption;
            label3.Location = new Point(259, 4);
            label3.Name = "label3";
            label3.Size = new Size(515, 52);
            label3.TabIndex = 7;
            label3.Text = "⌚View Laundry Status";
            // 
            // laundry_attendant_status
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1181, 562);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(table_customers);
            Controls.Add(panel2);
            Margin = new Padding(5);
            Name = "laundry_attendant_status";
            Text = "laundry_attendant_status";
            Load += laundry_attendant_status_Load;
            Controls.SetChildIndex(panel2, 0);
            Controls.SetChildIndex(table_customers, 0);
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(label3, 0);
            ((System.ComponentModel.ISupportInitialize)table_customers).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView table_customers;
        private Button button_edit;
        private Button button_add;
        private Button button_archive;
        private Label label1;
        private Panel panel2;
        private Button button1;
        private TextBox textBox1;
        private Label label3;
        private Button SearchBtn_Status;
    }
}