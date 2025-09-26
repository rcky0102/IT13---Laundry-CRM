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
            ((System.ComponentModel.ISupportInitialize)table_customers).BeginInit();
            SuspendLayout();
            // 
            // table_customers
            // 
            table_customers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            table_customers.Location = new Point(245, 181);
            table_customers.Name = "table_customers";
            table_customers.RowHeadersWidth = 51;
            table_customers.Size = new Size(636, 188);
            table_customers.TabIndex = 1;
            table_customers.CellContentClick += table_customers_CellContentClick;
            // 
            // button_edit
            // 
            button_edit.Location = new Point(563, 128);
            button_edit.Name = "button_edit";
            button_edit.Size = new Size(145, 29);
            button_edit.TabIndex = 2;
            button_edit.Text = "Update Status";
            button_edit.UseVisualStyleBackColor = true;
            button_edit.Click += button_edit_Click;
            // 
            // button_add
            // 
            button_add.Location = new Point(315, 125);
            button_add.Name = "button_add";
            button_add.Size = new Size(94, 29);
            button_add.TabIndex = 3;
            button_add.Text = "Add ";
            button_add.UseVisualStyleBackColor = true;
            button_add.Click += button_add_Click;
            // 
            // button_archive
            // 
            button_archive.Location = new Point(775, 125);
            button_archive.Name = "button_archive";
            button_archive.Size = new Size(94, 29);
            button_archive.TabIndex = 4;
            button_archive.Text = "Archive";
            button_archive.UseVisualStyleBackColor = true;
            button_archive.Click += button_archive_Click;
            // 
            // laundry_attendant_status
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(945, 450);
            Controls.Add(button_archive);
            Controls.Add(button_add);
            Controls.Add(button_edit);
            Controls.Add(table_customers);
            Name = "laundry_attendant_status";
            Text = "laundry_attendant_status";
            Load += laundry_attendant_status_Load;
            Controls.SetChildIndex(table_customers, 0);
            Controls.SetChildIndex(button_edit, 0);
            Controls.SetChildIndex(button_add, 0);
            Controls.SetChildIndex(button_archive, 0);
            ((System.ComponentModel.ISupportInitialize)table_customers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView table_customers;
        private Button button_edit;
        private Button button_add;
        private Button button_archive;
    }
}