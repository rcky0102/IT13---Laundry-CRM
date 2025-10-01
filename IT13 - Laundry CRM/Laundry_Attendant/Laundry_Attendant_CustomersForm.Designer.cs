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
            panel2 = new Panel();
            Searchbtn_Customer = new Button();
            textBox1 = new TextBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)table_customers).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // table_customers
            // 
            table_customers.BackgroundColor = SystemColors.ButtonHighlight;
            table_customers.BorderStyle = BorderStyle.Fixed3D;
            table_customers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            table_customers.Location = new Point(259, 190);
            table_customers.Margin = new Padding(4);
            table_customers.Name = "table_customers";
            table_customers.RowHeadersWidth = 51;
            table_customers.Size = new Size(910, 358);
            table_customers.TabIndex = 1;
            // 
            // button_add_cutomer
            // 
            button_add_cutomer.BackColor = Color.RoyalBlue;
            button_add_cutomer.FlatAppearance.BorderSize = 0;
            button_add_cutomer.ForeColor = SystemColors.ButtonHighlight;
            button_add_cutomer.Location = new Point(26, 14);
            button_add_cutomer.Margin = new Padding(4);
            button_add_cutomer.Name = "button_add_cutomer";
            button_add_cutomer.Size = new Size(89, 36);
            button_add_cutomer.TabIndex = 2;
            button_add_cutomer.Text = "➕ Add ";
            button_add_cutomer.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(Searchbtn_Customer);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(button_add_cutomer);
            panel2.Location = new Point(259, 109);
            panel2.Name = "panel2";
            panel2.Size = new Size(910, 74);
            panel2.TabIndex = 3;
            // 
            // Searchbtn_Customer
            // 
            Searchbtn_Customer.Location = new Point(431, 19);
            Searchbtn_Customer.Name = "Searchbtn_Customer";
            Searchbtn_Customer.Size = new Size(43, 34);
            Searchbtn_Customer.TabIndex = 6;
            Searchbtn_Customer.Text = "🔎";
            Searchbtn_Customer.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(480, 19);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(396, 31);
            textBox1.TabIndex = 5;
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
            label1.Location = new Point(254, 0);
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
            label2.Location = new Point(350, 70);
            label2.Name = "label2";
            label2.Size = new Size(344, 18);
            label2.TabIndex = 5;
            label2.Text = "\"Currently managing 128 active customers.\"";
            // 
            // Laundry_Attendant_CustomersForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1181, 562);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(table_customers);
            Controls.Add(panel2);
            Margin = new Padding(5);
            Name = "Laundry_Attendant_CustomersForm";
            Text = "Laundry_Attendant_CustomersForm";
            Load += Laundry_Attendant_CustomersForm_Load;
            Controls.SetChildIndex(panel2, 0);
            Controls.SetChildIndex(table_customers, 0);
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(label2, 0);
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
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Button Searchbtn_Customer;
    }
}