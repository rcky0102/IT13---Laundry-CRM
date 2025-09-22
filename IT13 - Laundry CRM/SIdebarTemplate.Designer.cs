namespace IT13___Laundry_CRM
{
    partial class SIdebarTemplate
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
            panel1 = new Panel();
            button_users = new Button();
            button1 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button_users);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(202, 450);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // button_users
            // 
            button_users.Location = new Point(12, 130);
            button_users.Name = "button_users";
            button_users.Size = new Size(170, 29);
            button_users.TabIndex = 1;
            button_users.Text = "Users";
            button_users.UseVisualStyleBackColor = true;
            button_users.Click += button_users_Click;
            // 
            // button1
            // 
            button1.Location = new Point(12, 70);
            button1.Name = "button1";
            button1.Size = new Size(170, 29);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // SIdebarTemplate
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "SIdebarTemplate";
            Text = "SIdebarTemplate";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button_users;
        private Button button1;
    }
}