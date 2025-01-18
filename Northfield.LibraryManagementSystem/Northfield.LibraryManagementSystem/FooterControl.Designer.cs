namespace Northfield.LibraryManagementSystem
{
    partial class FooterControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblVersion = new Label();
            SuspendLayout();
            // 
            // lblVersion
            // 
            lblVersion.AutoSize = true;
            lblVersion.Font = new Font("Arial", 12F);
            lblVersion.Location = new Point(0, 0);
            lblVersion.Name = "lblVersion";
            lblVersion.Size = new Size(104, 18);
            lblVersion.TabIndex = 0;
            lblVersion.Text = "Version: 1.0.0";
            lblVersion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Footer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblVersion);
            Name = "Footer";
            Size = new Size(800, 50);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblVersion;
    }
}
