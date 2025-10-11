namespace IT13___Laundry_CRM.Admin
{
    partial class reports
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
            export = new Button();
            SuspendLayout();
            // 
            // export
            // 
            export.Location = new Point(331, 137);
            export.Name = "export";
            export.Size = new Size(94, 29);
            export.TabIndex = 0;
            export.Text = "Export";
            export.UseVisualStyleBackColor = true;
            // 
            // reports
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(895, 565);
            Controls.Add(export);
            Name = "reports";
            Text = "reports";
            ResumeLayout(false);
        }

        #endregion

        private Button export;
    }
}