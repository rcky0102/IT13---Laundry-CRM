namespace IT13___Laundry_CRM
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label2 = new Label();
            label3 = new Label();
            login_button = new Button();
            textbox_username = new TextBox();
            textbox_password = new TextBox();
            linkLabel1 = new LinkLabel();
            label1 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(269, 105);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(84, 19);
            label2.TabIndex = 1;
            label2.Text = "Username:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(274, 179);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(81, 19);
            label3.TabIndex = 2;
            label3.Text = "Password:";
            // 
            // login_button
            // 
            login_button.Location = new Point(410, 265);
            login_button.Margin = new Padding(4, 2, 4, 2);
            login_button.Name = "login_button";
            login_button.Size = new Size(106, 28);
            login_button.TabIndex = 3;
            login_button.Text = "Login";
            login_button.UseVisualStyleBackColor = true;
            login_button.Click += login_button_Click;
            // 
            // textbox_username
            // 
            textbox_username.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textbox_username.Location = new Point(375, 102);
            textbox_username.Margin = new Padding(4, 2, 4, 2);
            textbox_username.Multiline = true;
            textbox_username.Name = "textbox_username";
            textbox_username.Size = new Size(238, 37);
            textbox_username.TabIndex = 4;
            // 
            // textbox_password
            // 
            textbox_password.Location = new Point(375, 173);
            textbox_password.Margin = new Padding(4, 2, 4, 2);
            textbox_password.Name = "textbox_password";
            textbox_password.Size = new Size(202, 26);
            textbox_password.TabIndex = 5;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(522, 309);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(75, 19);
            linkLabel1.TabIndex = 6;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Register.";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(324, 309);
            label1.Name = "label1";
            label1.Size = new Size(192, 19);
            label1.TabIndex = 7;
            label1.Text = "Doesn't have an account?";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(936, 404);
            Controls.Add(label1);
            Controls.Add(linkLabel1);
            Controls.Add(textbox_password);
            Controls.Add(textbox_username);
            Controls.Add(login_button);
            Controls.Add(label3);
            Controls.Add(label2);
            Font = new Font("Ink Free", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 2, 4, 2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private Button login_button;
        private TextBox textbox_username;
        private TextBox textbox_password;
        private LinkLabel linkLabel1;
        private Label label1;
    }
}
