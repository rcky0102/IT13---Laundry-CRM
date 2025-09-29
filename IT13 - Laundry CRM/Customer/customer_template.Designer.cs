namespace IT13___Laundry_CRM
{
    partial class customer_template
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
            button_status = new Button();
            button1 = new Button();
            button_message = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button_message);
            panel1.Controls.Add(button_status);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(222, 450);
            panel1.TabIndex = 0;
            // 
            // button_status
            // 
            button_status.Location = new Point(64, 139);
            button_status.Name = "button_status";
            button_status.Size = new Size(94, 29);
            button_status.TabIndex = 1;
            button_status.Text = "Status";
            button_status.UseVisualStyleBackColor = true;
            button_status.Click += button_status_Click;
            // 
            // button1
            // 
            button1.Location = new Point(64, 78);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button_message
            // 
            button_message.Location = new Point(64, 199);
            button_message.Name = "button_message";
            button_message.Size = new Size(94, 29);
            button_message.TabIndex = 2;
            button_message.Text = "Messages";
            button_message.UseVisualStyleBackColor = true;
            button_message.Click += button_message_Click;
            // 
            // customer_template
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "customer_template";
            Text = "customer_template";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Button button_status;
        private Button button_message;
    }
}