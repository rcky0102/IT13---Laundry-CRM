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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            table_customers = new DataGridView();
            button_add_cutomer = new Button();
            panel2 = new Panel();
            button_delete = new Button();
            button_edit = new Button();
            Searchbtn_Customer = new Button();
            textbox_search = new TextBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)table_customers).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // table_customers
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            table_customers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            table_customers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            table_customers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            table_customers.BackgroundColor = SystemColors.Window;
            table_customers.BorderStyle = BorderStyle.None;
            table_customers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            table_customers.Location = new Point(218, 220);
            table_customers.Name = "table_customers";
            table_customers.ReadOnly = true;
            table_customers.RowHeadersVisible = false;
            table_customers.RowHeadersWidth = 51;
            table_customers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            table_customers.Size = new Size(718, 210);
            table_customers.TabIndex = 1;
            // 
            // button_add_cutomer
            // 
            button_add_cutomer.BackColor = Color.RoyalBlue;
            button_add_cutomer.FlatAppearance.BorderSize = 0;
            button_add_cutomer.ForeColor = SystemColors.ButtonHighlight;
            button_add_cutomer.Location = new Point(21, 11);
            button_add_cutomer.Name = "button_add_cutomer";
            button_add_cutomer.Size = new Size(71, 29);
            button_add_cutomer.TabIndex = 2;
            button_add_cutomer.Text = "➕ Add ";
            button_add_cutomer.UseVisualStyleBackColor = false;
            button_add_cutomer.Click += button_add_cutomer_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(button_delete);
            panel2.Controls.Add(button_edit);
            panel2.Controls.Add(Searchbtn_Customer);
            panel2.Controls.Add(textbox_search);
            panel2.Controls.Add(button_add_cutomer);
            panel2.Location = new Point(218, 151);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(718, 60);
            panel2.TabIndex = 3;
            // 
            // button_delete
            // 
            button_delete.Location = new Point(230, 11);
            button_delete.Name = "button_delete";
            button_delete.Size = new Size(94, 29);
            button_delete.TabIndex = 8;
            button_delete.Text = "Delete";
            button_delete.UseVisualStyleBackColor = true;
            button_delete.Click += button_delete_Click;
            // 
            // button_edit
            // 
            button_edit.Location = new Point(113, 14);
            button_edit.Name = "button_edit";
            button_edit.Size = new Size(94, 29);
            button_edit.TabIndex = 7;
            button_edit.Text = "Edit";
            button_edit.UseVisualStyleBackColor = true;
            button_edit.Click += button_edit_Click;
            // 
            // Searchbtn_Customer
            // 
            Searchbtn_Customer.Location = new Point(345, 15);
            Searchbtn_Customer.Margin = new Padding(2);
            Searchbtn_Customer.Name = "Searchbtn_Customer";
            Searchbtn_Customer.Size = new Size(34, 27);
            Searchbtn_Customer.TabIndex = 6;
            Searchbtn_Customer.Text = "🔎";
            Searchbtn_Customer.UseVisualStyleBackColor = true;
            // 
            // textbox_search
            // 
            textbox_search.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textbox_search.BorderStyle = BorderStyle.FixedSingle;
            textbox_search.Location = new Point(384, 15);
            textbox_search.Margin = new Padding(2);
            textbox_search.Name = "textbox_search";
            textbox_search.Size = new Size(300, 27);
            textbox_search.TabIndex = 5;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonHighlight;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new Point(190, 17);
            button1.Name = "button1";
            button1.Size = new Size(38, 30);
            button1.TabIndex = 4;
            button1.Text = "🔎";
            button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Code SemiBold", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaption;
            label1.Location = new Point(259, 69);
            label1.Name = "label1";
            label1.Size = new Size(561, 52);
            label1.TabIndex = 4;
            label1.Text = "👤 Customer Information";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonHighlight;
            label2.Font = new Font("Cascadia Code Light", 7F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaption;
            label2.Location = new Point(347, 118);
            label2.Name = "label2";
            label2.Size = new Size(344, 18);
            label2.TabIndex = 5;
            label2.Text = "\"Currently managing 128 active customers.\"";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cascadia Code", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(206, 55);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(323, 35);
            label3.TabIndex = 4;
            label3.Text = "👤 Manage Customers\r\n";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.Font = new Font("Cascadia Code SemiLight", 8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(266, 100);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(681, 39);
            label4.TabIndex = 5;
            label4.Text = "Easily view and track updates from the laundry service, ensuring you stay informed about your orders.\"";
            // 
            // Laundry_Attendant_CustomersForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(947, 442);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(table_customers);
            Controls.Add(panel2);
            Margin = new Padding(4);
            Name = "Laundry_Attendant_CustomersForm";
            Text = "Laundry Attendant | Customers";
            Load += Laundry_Attendant_CustomersForm_Load;
            Controls.SetChildIndex(panel2, 0);
            Controls.SetChildIndex(table_customers, 0);
            Controls.SetChildIndex(label3, 0);
            Controls.SetChildIndex(label4, 0);
            ((System.ComponentModel.ISupportInitialize)table_customers).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView table_customers;
        private Button button_add_cutomer;
        private Panel panel2;
        private Button button1;
        private TextBox textbox_search;
        private Label label1;
        private Label label2;
        private Button Searchbtn_Customer;
        private Label label3;
        private Label label4;
        private Button button_delete;
        private Button button_edit;
    }
}