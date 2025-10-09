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
            button_archives = new Button();
            add = new Button();
            edit = new Button();
            archive = new Button();
            panel3 = new Panel();
            textbox_search = new TextBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)table_customers).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // table_customers
            // 
            table_customers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            table_customers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            table_customers.BackgroundColor = SystemColors.ButtonHighlight;
            table_customers.BorderStyle = BorderStyle.None;
            table_customers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            table_customers.Location = new Point(286, 319);
            table_customers.Margin = new Padding(4, 4, 4, 4);
            table_customers.Name = "table_customers";
            table_customers.ReadOnly = true;
            table_customers.RowHeadersVisible = false;
            table_customers.RowHeadersWidth = 51;
            table_customers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            table_customers.Size = new Size(930, 219);
            table_customers.TabIndex = 1;
            table_customers.CellContentClick += table_customers_CellContentClick;
            // 
            // button_edit
            // 
            button_edit.BackColor = Color.MediumSeaGreen;
            button_edit.FlatAppearance.BorderSize = 0;
            button_edit.ForeColor = SystemColors.ButtonHighlight;
            button_edit.Location = new Point(631, 14);
            button_edit.Name = "button_edit";
            button_edit.Size = new Size(38, 29);
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
            button_add.Location = new Point(14, 15);
            button_add.Name = "button_add";
            button_add.Size = new Size(94, 29);
            button_add.TabIndex = 3;
            button_add.Text = "➕Add ";
            button_add.UseVisualStyleBackColor = false;
            button_add.Click += button_add_Click;
            // 
            // button_archive
            // 
            button_archive.BackColor = Color.Orange;
            button_archive.ForeColor = SystemColors.ButtonHighlight;
            button_archive.Location = new Point(675, 14);
            button_archive.Name = "button_archive";
            button_archive.Size = new Size(41, 29);
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
            label1.Location = new Point(262, 45);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(552, 18);
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
            panel2.Location = new Point(207, 86);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(728, 58);
            panel2.TabIndex = 6;
            // 
            // SearchBtn_Status
            // 
            SearchBtn_Status.Location = new Point(257, 15);
            SearchBtn_Status.Margin = new Padding(2);
            SearchBtn_Status.Name = "SearchBtn_Status";
            SearchBtn_Status.Size = new Size(33, 27);
            SearchBtn_Status.TabIndex = 6;
            SearchBtn_Status.Text = "🔎";
            SearchBtn_Status.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(294, 18);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(332, 28);
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
            // button_archives
            // 
            button_archives.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_archives.BackColor = Color.Salmon;
            button_archives.Location = new Point(841, 19);
            button_archives.Margin = new Padding(4, 4, 4, 4);
            button_archives.Name = "button_archives";
            button_archives.Size = new Size(62, 50);
            button_archives.TabIndex = 8;
            button_archives.Text = "🗂️";
            button_archives.UseVisualStyleBackColor = false;
            button_archives.Click += button_archives_Click;
            // 
            // add
            // 
            add.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            add.BackColor = SystemColors.MenuHighlight;
            add.ForeColor = SystemColors.ButtonHighlight;
            add.Location = new Point(496, 19);
            add.Margin = new Padding(4, 4, 4, 4);
            add.Name = "add";
            add.Size = new Size(62, 50);
            add.TabIndex = 9;
            add.Text = "➕";
            add.UseVisualStyleBackColor = false;
            add.Click += add_Click;
            // 
            // edit
            // 
            edit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            edit.BackColor = Color.ForestGreen;
            edit.Location = new Point(571, 19);
            edit.Margin = new Padding(4, 4, 4, 4);
            edit.Name = "edit";
            edit.Size = new Size(62, 50);
            edit.TabIndex = 10;
            edit.Text = "✏️";
            edit.UseVisualStyleBackColor = false;
            edit.Click += edit_Click;
            // 
            // archive
            // 
            archive.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            archive.BackColor = Color.Salmon;
            archive.Location = new Point(641, 19);
            archive.Margin = new Padding(4, 4, 4, 4);
            archive.Name = "archive";
            archive.Size = new Size(62, 50);
            archive.TabIndex = 11;
            archive.Text = "📦";
            archive.UseVisualStyleBackColor = false;
            archive.Click += archive_Click;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = SystemColors.ActiveCaption;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(textbox_search);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(edit);
            panel3.Controls.Add(archive);
            panel3.Controls.Add(add);
            panel3.Controls.Add(button_archives);
            panel3.Font = new Font("Cascadia Code", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel3.ForeColor = SystemColors.ButtonHighlight;
            panel3.Location = new Point(272, 91);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(930, 93);
            panel3.TabIndex = 12;
            // 
            // textbox_search
            // 
            textbox_search.BorderStyle = BorderStyle.FixedSingle;
            textbox_search.Location = new Point(13, 19);
            textbox_search.Margin = new Padding(2);
            textbox_search.Multiline = true;
            textbox_search.Name = "textbox_search";
            textbox_search.PlaceholderText = "🔎 Search here...";
            textbox_search.Size = new Size(374, 50);
            textbox_search.TabIndex = 13;
            textbox_search.TextChanged += textbox_search_TextChanged;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(711, 36);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(122, 21);
            label5.TabIndex = 12;
            label5.Text = "View Archives:";
            // 
            // laundry_attendant_status
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1246, 562);
            Controls.Add(table_customers);
            Controls.Add(panel3);
            Margin = new Padding(5, 5, 5, 5);
            Name = "laundry_attendant_status";
            Text = "Laundry Attendant | Status";
            Load += laundry_attendant_status_Load;
            Controls.SetChildIndex(panel3, 0);
            Controls.SetChildIndex(table_customers, 0);
            ((System.ComponentModel.ISupportInitialize)table_customers).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
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
        private Button SearchBtn_Status;
        private Button button_archives;
        private Button add;
        private Button edit;
        private Button archive;
        private Panel panel3;
        private Label label5;
        private TextBox textbox_search;
    }
}