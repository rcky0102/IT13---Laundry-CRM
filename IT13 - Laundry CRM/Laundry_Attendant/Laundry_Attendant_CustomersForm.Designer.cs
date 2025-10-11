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
<<<<<<< Updated upstream
=======
            panel2 = new Panel();
            textbox_search = new TextBox();
            lblPageInfo = new Label();
            btnFirst = new Button();
            btnPrev = new Button();
            btnNext = new Button();
            btnLast = new Button();
            cmbPageSize = new ComboBox();
            label3 = new Label();
>>>>>>> Stashed changes
            ((System.ComponentModel.ISupportInitialize)table_customers).BeginInit();
            SuspendLayout();
            // 
            // table_customers
            // 
            table_customers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
<<<<<<< Updated upstream
            table_customers.Location = new Point(270, 213);
=======
            table_customers.Location = new Point(281, 186);
            table_customers.Margin = new Padding(4);
>>>>>>> Stashed changes
            table_customers.Name = "table_customers";
            table_customers.RowHeadersWidth = 51;
<<<<<<< Updated upstream
            table_customers.Size = new Size(471, 188);
=======
            table_customers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            table_customers.Size = new Size(901, 311);
>>>>>>> Stashed changes
            table_customers.TabIndex = 1;
            // 
            // button_add_cutomer
            // 
<<<<<<< Updated upstream
            button_add_cutomer.Location = new Point(284, 144);
            button_add_cutomer.Name = "button_add_cutomer";
            button_add_cutomer.Size = new Size(94, 29);
            button_add_cutomer.TabIndex = 2;
            button_add_cutomer.Text = "Add";
            button_add_cutomer.UseVisualStyleBackColor = true;
=======
            button_add_cutomer.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_add_cutomer.BackColor = Color.RoyalBlue;
            button_add_cutomer.FlatAppearance.BorderSize = 0;
            button_add_cutomer.ForeColor = SystemColors.ButtonHighlight;
            button_add_cutomer.Location = new Point(691, 19);
            button_add_cutomer.Margin = new Padding(4);
            button_add_cutomer.Name = "button_add_cutomer";
            button_add_cutomer.Size = new Size(184, 50);
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
            panel2.Location = new Point(272, 87);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(914, 93);
            panel2.TabIndex = 3;
            panel2.Paint += panel2_Paint;
            // 
            // textbox_search
            // 
            textbox_search.BorderStyle = BorderStyle.FixedSingle;
            textbox_search.Location = new Point(10, 19);
            textbox_search.Margin = new Padding(2);
            textbox_search.Multiline = true;
            textbox_search.Name = "textbox_search";
            textbox_search.PlaceholderText = "🔎 Search here...";
            textbox_search.Size = new Size(374, 50);
            textbox_search.TabIndex = 5;
            textbox_search.TextChanged += textbox_search_TextChanged;
            // 
            // lblPageInfo
            // 
            lblPageInfo.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblPageInfo.AutoSize = true;
            lblPageInfo.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPageInfo.ForeColor = SystemColors.ControlDarkDark;
            lblPageInfo.Location = new Point(272, 565);
            lblPageInfo.Name = "lblPageInfo";
            lblPageInfo.Size = new Size(238, 21);
            lblPageInfo.TabIndex = 6;
            lblPageInfo.Text = "Page 1 of 1 (Total: 0 records)";
            // 
            // btnFirst
            // 
            btnFirst.Anchor = AnchorStyles.Bottom;
            btnFirst.BackColor = SystemColors.ButtonHighlight;
            btnFirst.FlatStyle = FlatStyle.Popup;
            btnFirst.Font = new Font("Gadugi", 8F);
            btnFirst.ForeColor = SystemColors.ActiveCaptionText;
            btnFirst.Location = new Point(539, 516);
            btnFirst.Margin = new Padding(4);
            btnFirst.Name = "btnFirst";
            btnFirst.Size = new Size(85, 32);
            btnFirst.TabIndex = 7;
            btnFirst.Text = "« First";
            btnFirst.UseVisualStyleBackColor = false;
            btnFirst.Click += btnFirst_Click;
            // 
            // btnPrev
            // 
            btnPrev.Anchor = AnchorStyles.Bottom;
            btnPrev.BackColor = SystemColors.ButtonHighlight;
            btnPrev.FlatStyle = FlatStyle.Popup;
            btnPrev.Font = new Font("Gadugi", 8F);
            btnPrev.ForeColor = SystemColors.ActiveCaptionText;
            btnPrev.Location = new Point(632, 516);
            btnPrev.Margin = new Padding(4);
            btnPrev.Name = "btnPrev";
            btnPrev.Size = new Size(105, 32);
            btnPrev.TabIndex = 8;
            btnPrev.Text = "‹ Previous";
            btnPrev.UseVisualStyleBackColor = false;
            btnPrev.Click += btnPrev_Click;
            // 
            // btnNext
            // 
            btnNext.Anchor = AnchorStyles.Bottom;
            btnNext.BackColor = SystemColors.ButtonHighlight;
            btnNext.FlatStyle = FlatStyle.Popup;
            btnNext.Font = new Font("Gadugi", 8F);
            btnNext.ForeColor = SystemColors.ActiveCaptionText;
            btnNext.Location = new Point(740, 516);
            btnNext.Margin = new Padding(4);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(85, 32);
            btnNext.TabIndex = 9;
            btnNext.Text = "Next ›";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // btnLast
            // 
            btnLast.Anchor = AnchorStyles.Bottom;
            btnLast.BackColor = SystemColors.ButtonHighlight;
            btnLast.FlatStyle = FlatStyle.Popup;
            btnLast.Font = new Font("Gadugi", 8F);
            btnLast.ForeColor = SystemColors.ActiveCaptionText;
            btnLast.Location = new Point(828, 516);
            btnLast.Margin = new Padding(4);
            btnLast.Name = "btnLast";
            btnLast.Size = new Size(85, 32);
            btnLast.TabIndex = 10;
            btnLast.Text = "Last »";
            btnLast.UseVisualStyleBackColor = false;
            btnLast.Click += btnLast_Click;
            // 
            // cmbPageSize
            // 
            cmbPageSize.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            cmbPageSize.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPageSize.Font = new Font("Gadugi", 9F);
            cmbPageSize.FormattingEnabled = true;
            cmbPageSize.Items.AddRange(new object[] { "5", "10", "20", "50" });
            cmbPageSize.Location = new Point(1104, 565);
            cmbPageSize.Margin = new Padding(4);
            cmbPageSize.Name = "cmbPageSize";
            cmbPageSize.Size = new Size(70, 29);
            cmbPageSize.TabIndex = 11;
            cmbPageSize.SelectedIndexChanged += cmbPageSize_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Gadugi", 9F);
            label3.ForeColor = SystemColors.ControlDarkDark;
            label3.Location = new Point(1005, 573);
            label3.Name = "label3";
            label3.Size = new Size(83, 21);
            label3.TabIndex = 12;
            label3.Text = "Per Page:";
>>>>>>> Stashed changes
            // 
            // Laundry_Attendant_CustomersForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
<<<<<<< Updated upstream
            ClientSize = new Size(800, 450);
            Controls.Add(button_add_cutomer);
            Controls.Add(table_customers);
=======
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1197, 617);
            Controls.Add(label3);
            Controls.Add(cmbPageSize);
            Controls.Add(btnLast);
            Controls.Add(btnNext);
            Controls.Add(btnPrev);
            Controls.Add(btnFirst);
            Controls.Add(lblPageInfo);
            Controls.Add(panel2);
            Controls.Add(table_customers);
            Margin = new Padding(5);
>>>>>>> Stashed changes
            Name = "Laundry_Attendant_CustomersForm";
            Text = "Laundry_Attendant_CustomersForm";
            Load += Laundry_Attendant_CustomersForm_Load;
            Controls.SetChildIndex(table_customers, 0);
<<<<<<< Updated upstream
            Controls.SetChildIndex(button_add_cutomer, 0);
=======
            Controls.SetChildIndex(panel2, 0);
            Controls.SetChildIndex(lblPageInfo, 0);
            Controls.SetChildIndex(btnFirst, 0);
            Controls.SetChildIndex(btnPrev, 0);
            Controls.SetChildIndex(btnNext, 0);
            Controls.SetChildIndex(btnLast, 0);
            Controls.SetChildIndex(cmbPageSize, 0);
            Controls.SetChildIndex(label3, 0);
>>>>>>> Stashed changes
            ((System.ComponentModel.ISupportInitialize)table_customers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView table_customers;
        private Button button_add_cutomer;
<<<<<<< Updated upstream
=======
        private Panel panel2;
        private TextBox textbox_search;
        private Label lblPageInfo;
        private Button btnFirst;
        private Button btnPrev;
        private Button btnNext;
        private Button btnLast;
        private ComboBox cmbPageSize;
        private Label label3;
>>>>>>> Stashed changes
    }
}