namespace Northfield.LibraryManagementSystem
{
    partial class DashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));
            btnLogout = new Button();
            label1 = new Label();
            btnMembers = new Button();
            btnBooks = new Button();
            btnLoans = new Button();
            footer1 = new FooterControl();
            headerControl1 = new HeaderControl();
            SuspendLayout();
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(320, 379);
            btnLogout.Margin = new Padding(4);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(129, 42);
            btnLogout.TabIndex = 6;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(240, 142);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(339, 29);
            label1.TabIndex = 5;
            label1.Text = "Library Management System";
            // 
            // btnMembers
            // 
            btnMembers.Location = new Point(320, 258);
            btnMembers.Margin = new Padding(4);
            btnMembers.Name = "btnMembers";
            btnMembers.Size = new Size(129, 42);
            btnMembers.TabIndex = 7;
            btnMembers.Text = "Members";
            btnMembers.UseVisualStyleBackColor = true;
            // 
            // btnBooks
            // 
            btnBooks.Location = new Point(320, 196);
            btnBooks.Margin = new Padding(4);
            btnBooks.Name = "btnBooks";
            btnBooks.Size = new Size(129, 42);
            btnBooks.TabIndex = 8;
            btnBooks.Text = "Books";
            btnBooks.UseVisualStyleBackColor = true;
            // 
            // btnLoans
            // 
            btnLoans.Location = new Point(320, 317);
            btnLoans.Margin = new Padding(4);
            btnLoans.Name = "btnLoans";
            btnLoans.Size = new Size(129, 42);
            btnLoans.TabIndex = 9;
            btnLoans.Text = "Loans";
            btnLoans.UseVisualStyleBackColor = true;
            // 
            // footer1
            // 
            footer1.Location = new Point(-8, 457);
            footer1.Name = "footer1";
            footer1.Size = new Size(800, 50);
            footer1.TabIndex = 10;
            // 
            // headerControl1
            // 
            headerControl1.Location = new Point(-8, -1);
            headerControl1.Name = "headerControl1";
            headerControl1.Size = new Size(800, 150);
            headerControl1.TabIndex = 11;
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 506);
            Controls.Add(headerControl1);
            Controls.Add(footer1);
            Controls.Add(btnLoans);
            Controls.Add(btnBooks);
            Controls.Add(btnMembers);
            Controls.Add(btnLogout);
            Controls.Add(label1);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "DashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Library Management System";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogout;
        private Label label1;
        private Button btnMembers;
        private Button btnBooks;
        private Button btnLoans;
        private FooterControl footer1;
        private HeaderControl headerControl1;
    }
}