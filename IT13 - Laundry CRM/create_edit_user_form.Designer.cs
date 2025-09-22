namespace IT13___Laundry_CRM
{
    partial class create_edit_user_form
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
            combobox_role = new ComboBox();
            textbox_password = new TextBox();
            textbox_username = new TextBox();
            button_save = new Button();
            button_cancel = new Button();
            label_title = new Label();
            label_id = new Label();
            SuspendLayout();
            // 
            // combobox_role
            // 
            combobox_role.FormattingEnabled = true;
            combobox_role.Location = new Point(289, 187);
            combobox_role.Name = "combobox_role";
            combobox_role.Size = new Size(151, 28);
            combobox_role.TabIndex = 1;
            // 
            // textbox_password
            // 
            textbox_password.Location = new Point(289, 144);
            textbox_password.Name = "textbox_password";
            textbox_password.Size = new Size(125, 27);
            textbox_password.TabIndex = 2;
            // 
            // textbox_username
            // 
            textbox_username.Location = new Point(289, 104);
            textbox_username.Name = "textbox_username";
            textbox_username.Size = new Size(125, 27);
            textbox_username.TabIndex = 3;
            // 
            // button_save
            // 
            button_save.Location = new Point(254, 250);
            button_save.Name = "button_save";
            button_save.Size = new Size(94, 29);
            button_save.TabIndex = 4;
            button_save.Text = "Save";
            button_save.UseVisualStyleBackColor = true;
            button_save.Click += button_save_Click;
            // 
            // button_cancel
            // 
            button_cancel.Location = new Point(421, 250);
            button_cancel.Name = "button_cancel";
            button_cancel.Size = new Size(94, 29);
            button_cancel.TabIndex = 5;
            button_cancel.Text = "Cancel";
            button_cancel.UseVisualStyleBackColor = true;
            button_cancel.Click += button_cancel_Click;
            // 
            // label_title
            // 
            label_title.AutoSize = true;
            label_title.Location = new Point(343, 23);
            label_title.Name = "label_title";
            label_title.Size = new Size(35, 20);
            label_title.TabIndex = 6;
            label_title.Text = "title";
            // 
            // label_id
            // 
            label_id.AutoSize = true;
            label_id.Location = new Point(348, 62);
            label_id.Name = "label_id";
            label_id.Size = new Size(24, 20);
            label_id.TabIndex = 7;
            label_id.Text = "ID";
            // 
            // create_edit_user_form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label_id);
            Controls.Add(label_title);
            Controls.Add(button_cancel);
            Controls.Add(button_save);
            Controls.Add(textbox_username);
            Controls.Add(textbox_password);
            Controls.Add(combobox_role);
            Name = "create_edit_user_form";
            Text = "create_edit_user_form";
            Load += create_edit_user_form_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox combobox_role;
        private TextBox textbox_password;
        private TextBox textbox_username;
        private Button button_save;
        private Button button_cancel;
        private Label label_title;
        private Label label_id;
    }
}