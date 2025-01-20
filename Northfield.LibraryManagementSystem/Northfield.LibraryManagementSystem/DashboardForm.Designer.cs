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
            lblHeader = new Label();
            btnMembers = new Button();
            btnBooks = new Button();
            btnLoans = new Button();
            footer1 = new FooterControl();
            headerControl1 = new HeaderControl();
            SuspendLayout();
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(0, 380);
            btnLogout.Margin = new Padding(4);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(129, 42);
            btnLogout.TabIndex = 6;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeader.Location = new Point(0, 150);
            lblHeader.Margin = new Padding(4, 0, 4, 0);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(339, 29);
            lblHeader.TabIndex = 5;
            lblHeader.Text = "Library Management System";
            // 
            // btnMembers
            // 
            btnMembers.Location = new Point(0, 260);
            btnMembers.Margin = new Padding(4);
            btnMembers.Name = "btnMembers";
            btnMembers.Size = new Size(129, 42);
            btnMembers.TabIndex = 7;
            btnMembers.Text = "Members";
            btnMembers.UseVisualStyleBackColor = true;
            btnMembers.Click += btnMembers_Click;
            // 
            // btnBooks
            // 
            btnBooks.Location = new Point(0, 200);
            btnBooks.Margin = new Padding(4);
            btnBooks.Name = "btnBooks";
            btnBooks.Size = new Size(129, 42);
            btnBooks.TabIndex = 8;
            btnBooks.Text = "Books";
            btnBooks.UseVisualStyleBackColor = true;
            btnBooks.Click += btnBooks_Click;
            // 
            // btnLoans
            // 
            btnLoans.Location = new Point(0, 320);
            btnLoans.Margin = new Padding(4);
            btnLoans.Name = "btnLoans";
            btnLoans.Size = new Size(129, 42);
            btnLoans.TabIndex = 9;
            btnLoans.Text = "Loans";
            btnLoans.UseVisualStyleBackColor = true;
            btnLoans.Click += btnLoans_Click;
            // 
            // footer1
            // 
            footer1.Location = new Point(0, 455);
            footer1.Name = "footer1";
            footer1.Size = new Size(800, 50);
            footer1.TabIndex = 10;
            // 
            // headerControl1
            // 
            headerControl1.Location = new Point(0, 0);
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
            Controls.Add(lblHeader);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "DashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Library Management System";
            FormClosed += DashboardForm_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogout;
        private Label lblHeader;
        private Button btnMembers;
        private Button btnBooks;
        private Button btnLoans;
        private FooterControl footer1;
        private HeaderControl headerControl1;
    }
}