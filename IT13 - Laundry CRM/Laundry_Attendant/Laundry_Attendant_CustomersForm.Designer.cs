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
            textbox_search = new TextBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
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
            table_customers.Location = new Point(272, 186);
            table_customers.Margin = new Padding(4, 4, 4, 4);
            table_customers.Name = "table_customers";
            table_customers.ReadOnly = true;
            table_customers.RowHeadersVisible = false;
            table_customers.RowHeadersWidth = 51;
            table_customers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            table_customers.Size = new Size(898, 352);
            table_customers.TabIndex = 1;
            // 
            // button_add_cutomer
            // 
            button_add_cutomer.BackColor = Color.RoyalBlue;
            button_add_cutomer.FlatAppearance.BorderSize = 0;
            button_add_cutomer.ForeColor = SystemColors.ButtonHighlight;
            button_add_cutomer.Location = new Point(24, 19);
            button_add_cutomer.Margin = new Padding(4, 4, 4, 4);
            button_add_cutomer.Name = "button_add_cutomer";
            button_add_cutomer.Size = new Size(62, 50);
            button_add_cutomer.TabIndex = 2;
            button_add_cutomer.Text = "➕";
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
            panel2.Controls.Add(textbox_search);
            panel2.Controls.Add(button_add_cutomer);
            panel2.Location = new Point(272, 87);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(896, 93);
            panel2.TabIndex = 3;
            panel2.Paint += panel2_Paint;
            // 
            // button_delete
            // 
            button_delete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_delete.BackColor = Color.IndianRed;
            button_delete.ForeColor = SystemColors.ButtonHighlight;
            button_delete.Location = new Point(810, 19);
            button_delete.Margin = new Padding(4, 4, 4, 4);
            button_delete.Name = "button_delete";
            button_delete.Size = new Size(62, 50);
            button_delete.TabIndex = 8;
            button_delete.Text = "🗑️";
            button_delete.UseVisualStyleBackColor = false;
            button_delete.Click += button_delete_Click;
            // 
            // button_edit
            // 
            button_edit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_edit.BackColor = Color.ForestGreen;
            button_edit.ForeColor = SystemColors.ButtonHighlight;
            button_edit.Location = new Point(729, 19);
            button_edit.Margin = new Padding(4, 4, 4, 4);
            button_edit.Name = "button_edit";
            button_edit.Size = new Size(62, 50);
            button_edit.TabIndex = 7;
            button_edit.Text = "✏️";
            button_edit.UseVisualStyleBackColor = false;
            button_edit.Click += button_edit_Click;
            // 
            // textbox_search
            // 
            textbox_search.BorderStyle = BorderStyle.FixedSingle;
            textbox_search.Location = new Point(92, 19);
            textbox_search.Margin = new Padding(2);
            textbox_search.Multiline = true;
            textbox_search.Name = "textbox_search";
            textbox_search.PlaceholderText = "🔎 Search here...";
            textbox_search.Size = new Size(374, 50);
            textbox_search.TabIndex = 5;
            textbox_search.TextChanged += textbox_search_TextChanged;
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
            // Laundry_Attendant_CustomersForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1184, 552);
            Controls.Add(table_customers);
            Controls.Add(panel2);
            Margin = new Padding(5, 5, 5, 5);
            Name = "Laundry_Attendant_CustomersForm";
            Text = "Laundry Attendant | Customers";
            Load += Laundry_Attendant_CustomersForm_Load;
            Controls.SetChildIndex(panel2, 0);
            Controls.SetChildIndex(table_customers, 0);
            ((System.ComponentModel.ISupportInitialize)table_customers).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView table_customers;
        private Button button_add_cutomer;
        private Panel panel2;
        private Button button1;
        private TextBox textbox_search;
        private Label label1;
        private Label label2;
        private Button button_delete;
        private Button button_edit;
    }
}