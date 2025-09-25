namespace IT13___Laundry_CRM
{
    partial class Laundry_Attendant_CustomersForm
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
            button_add_cutomer = new Button();
            ((System.ComponentModel.ISupportInitialize)table_customers).BeginInit();
            SuspendLayout();
            // 
            // table_customers
            // 
            table_customers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            table_customers.Location = new Point(270, 213);
            table_customers.Name = "table_customers";
            table_customers.RowHeadersWidth = 51;
            table_customers.Size = new Size(471, 188);
            table_customers.TabIndex = 1;
            // 
            // button_add_cutomer
            // 
            button_add_cutomer.Location = new Point(284, 144);
            button_add_cutomer.Name = "button_add_cutomer";
            button_add_cutomer.Size = new Size(94, 29);
            button_add_cutomer.TabIndex = 2;
            button_add_cutomer.Text = "Add";
            button_add_cutomer.UseVisualStyleBackColor = true;
            // 
            // Laundry_Attendant_CustomersForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_add_cutomer);
            Controls.Add(table_customers);
            Name = "Laundry_Attendant_CustomersForm";
            Text = "Laundry_Attendant_CustomersForm";
            Load += Laundry_Attendant_CustomersForm_Load;
            Controls.SetChildIndex(table_customers, 0);
            Controls.SetChildIndex(button_add_cutomer, 0);
            ((System.ComponentModel.ISupportInitialize)table_customers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView table_customers;
        private Button button_add_cutomer;
    }
}