namespace Northfield.LibraryManagementSystem
{
    partial class LoansForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoansForm));
            lstLoans = new ListBox();
            btnReturn = new Button();
            btnLoan = new Button();
            label4 = new Label();
            txtCardNumber = new TextBox();
            label3 = new Label();
            txtIsbn = new TextBox();
            label2 = new Label();
            lblHeader = new Label();
            lblReturnDate = new Label();
            footerControl1 = new FooterControl();
            headerControl1 = new HeaderControl();
            SuspendLayout();
            // 
            // lstLoans
            // 
            lstLoans.FormattingEnabled = true;
            lstLoans.ItemHeight = 18;
            lstLoans.Location = new Point(77, 200);
            lstLoans.Name = "lstLoans";
            lstLoans.Size = new Size(233, 256);
            lstLoans.TabIndex = 28;
            // 
            // btnReturn
            // 
            btnReturn.Location = new Point(560, 367);
            btnReturn.Margin = new Padding(4);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(129, 42);
            btnReturn.TabIndex = 4;
            btnReturn.Text = "Return";
            btnReturn.UseVisualStyleBackColor = true;
            // 
            // btnLoan
            // 
            btnLoan.Location = new Point(391, 367);
            btnLoan.Margin = new Padding(4);
            btnLoan.Name = "btnLoan";
            btnLoan.Size = new Size(129, 42);
            btnLoan.TabIndex = 3;
            btnLoan.Text = "Loan";
            btnLoan.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(391, 300);
            label4.Name = "label4";
            label4.Size = new Size(95, 18);
            label4.TabIndex = 23;
            label4.Text = "Return Date:";
            // 
            // txtCardNumber
            // 
            txtCardNumber.Location = new Point(503, 250);
            txtCardNumber.Name = "txtCardNumber";
            txtCardNumber.Size = new Size(200, 26);
            txtCardNumber.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(391, 250);
            label3.Name = "label3";
            label3.Size = new Size(106, 18);
            label3.TabIndex = 21;
            label3.Text = "Card Number:";
            // 
            // txtIsbn
            // 
            txtIsbn.Location = new Point(503, 200);
            txtIsbn.Name = "txtIsbn";
            txtIsbn.Size = new Size(200, 26);
            txtIsbn.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(391, 200);
            label2.Name = "label2";
            label2.Size = new Size(48, 18);
            label2.TabIndex = 19;
            label2.Text = "ISBN:";
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeader.Location = new Point(0, 150);
            lblHeader.Margin = new Padding(4, 0, 4, 0);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(84, 29);
            lblHeader.TabIndex = 18;
            lblHeader.Text = "Loans";
            // 
            // lblReturnDate
            // 
            lblReturnDate.AutoSize = true;
            lblReturnDate.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblReturnDate.Location = new Point(503, 300);
            lblReturnDate.Name = "lblReturnDate";
            lblReturnDate.Size = new Size(60, 18);
            lblReturnDate.TabIndex = 30;
            lblReturnDate.Text = "<Date>";
            // 
            // footerControl1
            // 
            footerControl1.Location = new Point(0, 555);
            footerControl1.Name = "footerControl1";
            footerControl1.Size = new Size(800, 50);
            footerControl1.TabIndex = 31;
            // 
            // headerControl1
            // 
            headerControl1.Location = new Point(0, 0);
            headerControl1.Name = "headerControl1";
            headerControl1.Size = new Size(800, 150);
            headerControl1.TabIndex = 32;
            // 
            // LoansForm
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 606);
            Controls.Add(headerControl1);
            Controls.Add(footerControl1);
            Controls.Add(lblReturnDate);
            Controls.Add(lstLoans);
            Controls.Add(btnReturn);
            Controls.Add(btnLoan);
            Controls.Add(label4);
            Controls.Add(txtCardNumber);
            Controls.Add(label3);
            Controls.Add(txtIsbn);
            Controls.Add(label2);
            Controls.Add(lblHeader);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "LoansForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Library Management System";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstLoans;
        private Button btnReturn;
        private Button btnLoan;
        private Label label4;
        private TextBox txtCardNumber;
        private Label label3;
        private TextBox txtIsbn;
        private Label label2;
        private Label lblHeader;
        private Label lblReturnDate;
        private FooterControl footerControl1;
        private HeaderControl headerControl1;
    }
}