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
            textbox_search = new TextBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            panelPagination = new Panel();
            lblTotalRecords = new Label();
            cmbPageSize = new ComboBox();
            lblPageInfo = new Label();
            btnLast = new Button();
            btnNext = new Button();
            btnPrevious = new Button();
            btnFirst = new Button();
            ((System.ComponentModel.ISupportInitialize)table_customers).BeginInit();
            panel2.SuspendLayout();
            panelPagination.SuspendLayout();
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
            table_customers.Location = new Point(258, 188);
            table_customers.Margin = new Padding(4);
            table_customers.Name = "table_customers";
            table_customers.ReadOnly = true;
            table_customers.RowHeadersVisible = false;
            table_customers.RowHeadersWidth = 51;
            table_customers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            table_customers.Size = new Size(911, 350);
            table_customers.TabIndex = 1;
            table_customers.CellContentClick += table_customers_CellContentClick;
            // 
            // button_add_cutomer
            // 
            button_add_cutomer.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_add_cutomer.BackColor = Color.RoyalBlue;
            button_add_cutomer.FlatAppearance.BorderSize = 0;
            button_add_cutomer.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_add_cutomer.ForeColor = SystemColors.ButtonHighlight;
            button_add_cutomer.Location = new Point(689, 23);
            button_add_cutomer.Margin = new Padding(4);
            button_add_cutomer.Name = "button_add_cutomer";
            button_add_cutomer.Size = new Size(206, 50);
            button_add_cutomer.TabIndex = 2;
            button_add_cutomer.Text = "➕ Add Customer";
            button_add_cutomer.UseVisualStyleBackColor = false;
            button_add_cutomer.Click += button_add_cutomer_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(textbox_search);
            panel2.Controls.Add(button_add_cutomer);
            panel2.Location = new Point(257, 89);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(912, 93);
            panel2.TabIndex = 3;
            // 
            // textbox_search
            // 
            textbox_search.BorderStyle = BorderStyle.FixedSingle;
            textbox_search.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textbox_search.Location = new Point(11, 23);
            textbox_search.Margin = new Padding(2);
            textbox_search.Multiline = true;
            textbox_search.Name = "textbox_search";
            textbox_search.PlaceholderText = "🔎 Search here...";
            textbox_search.Size = new Size(374, 40);
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
            // panelPagination
            // 
            panelPagination.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelPagination.BackColor = SystemColors.ButtonHighlight;
            panelPagination.Controls.Add(lblTotalRecords);
            panelPagination.Controls.Add(cmbPageSize);
            panelPagination.Controls.Add(lblPageInfo);
            panelPagination.Controls.Add(btnLast);
            panelPagination.Controls.Add(btnNext);
            panelPagination.Controls.Add(btnPrevious);
            panelPagination.Controls.Add(btnFirst);
            panelPagination.Location = new Point(258, 545);
            panelPagination.Margin = new Padding(4);
            panelPagination.Name = "panelPagination";
            panelPagination.Size = new Size(912, 62);
            panelPagination.TabIndex = 14;
            // 
            // lblTotalRecords
            // 
            lblTotalRecords.Anchor = AnchorStyles.Bottom;
            lblTotalRecords.AutoSize = true;
            lblTotalRecords.Font = new Font("Gadugi", 9F);
            lblTotalRecords.Location = new Point(396, 24);
            lblTotalRecords.Margin = new Padding(4, 0, 4, 0);
            lblTotalRecords.Name = "lblTotalRecords";
            lblTotalRecords.Size = new Size(137, 21);
            lblTotalRecords.TabIndex = 5;
            lblTotalRecords.Text = "Total Records: 0";
            // 
            // cmbPageSize
            // 
            cmbPageSize.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            cmbPageSize.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPageSize.Font = new Font("Gadugi", 9F);
            cmbPageSize.FormattingEnabled = true;
            cmbPageSize.Items.AddRange(new object[] { "5", "10", "20", "50" });
            cmbPageSize.Location = new Point(615, 20);
            cmbPageSize.Margin = new Padding(4);
            cmbPageSize.Name = "cmbPageSize";
            cmbPageSize.Size = new Size(74, 29);
            cmbPageSize.TabIndex = 6;
            cmbPageSize.SelectedIndexChanged += cmbPageSize_SelectedIndexChanged;
            // 
            // lblPageInfo
            // 
            lblPageInfo.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblPageInfo.AutoSize = true;
            lblPageInfo.Font = new Font("Gadugi", 9F);
            lblPageInfo.Location = new Point(212, 24);
            lblPageInfo.Margin = new Padding(4, 0, 4, 0);
            lblPageInfo.Name = "lblPageInfo";
            lblPageInfo.Size = new Size(101, 21);
            lblPageInfo.TabIndex = 4;
            lblPageInfo.Text = "Page 1 of 1";
            // 
            // btnLast
            // 
            btnLast.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnLast.Font = new Font("Gadugi", 9F);
            btnLast.Location = new Point(821, 19);
            btnLast.Margin = new Padding(4);
            btnLast.Name = "btnLast";
            btnLast.Size = new Size(75, 31);
            btnLast.TabIndex = 3;
            btnLast.Text = "Last";
            btnLast.UseVisualStyleBackColor = true;
            btnLast.Click += btnLast_Click;
            // 
            // btnNext
            // 
            btnNext.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnNext.Font = new Font("Gadugi", 9F);
            btnNext.Location = new Point(715, 19);
            btnNext.Margin = new Padding(4);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(94, 31);
            btnNext.TabIndex = 2;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // btnPrevious
            // 
            btnPrevious.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnPrevious.Font = new Font("Gadugi", 9F);
            btnPrevious.Location = new Point(100, 19);
            btnPrevious.Margin = new Padding(4);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(94, 31);
            btnPrevious.TabIndex = 1;
            btnPrevious.Text = "Previous";
            btnPrevious.UseVisualStyleBackColor = true;
            btnPrevious.Click += btnPrevious_Click;
            // 
            // btnFirst
            // 
            btnFirst.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnFirst.Font = new Font("Gadugi", 9F);
            btnFirst.Location = new Point(12, 19);
            btnFirst.Margin = new Padding(4);
            btnFirst.Name = "btnFirst";
            btnFirst.Size = new Size(75, 31);
            btnFirst.TabIndex = 0;
            btnFirst.Text = "First";
            btnFirst.UseVisualStyleBackColor = true;
            btnFirst.Click += btnFirst_Click;
            // 
            // Laundry_Attendant_CustomersForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1184, 625);
            Controls.Add(panelPagination);
            Controls.Add(table_customers);
            Controls.Add(panel2);
            Margin = new Padding(5);
            Name = "Laundry_Attendant_CustomersForm";
            Text = "Laundry Attendant | Customers";
            Load += Laundry_Attendant_CustomersForm_Load;
            Controls.SetChildIndex(panel2, 0);
            Controls.SetChildIndex(table_customers, 0);
            Controls.SetChildIndex(panelPagination, 0);
            ((System.ComponentModel.ISupportInitialize)table_customers).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panelPagination.ResumeLayout(false);
            panelPagination.PerformLayout();
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
        private Panel panelPagination;
        private Label lblTotalRecords;
        private ComboBox cmbPageSize;
        private Label lblPageInfo;
        private Button btnLast;
        private Button btnNext;
        private Button btnPrevious;
        private Button btnFirst;
    }
}