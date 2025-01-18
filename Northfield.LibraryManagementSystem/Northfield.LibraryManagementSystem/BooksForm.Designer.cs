namespace Northfield.LibraryManagementSystem
{
    partial class BooksForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BooksForm));
            label1 = new Label();
            txtIsbn = new TextBox();
            label2 = new Label();
            txtTitle = new TextBox();
            label3 = new Label();
            txtAuthor = new TextBox();
            label4 = new Label();
            btnNew = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            lstBooks = new ListBox();
            footerControl1 = new FooterControl();
            headerControl1 = new HeaderControl();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(349, 156);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(86, 29);
            label1.TabIndex = 6;
            label1.Text = "Books";
            // 
            // txtIsbn
            // 
            txtIsbn.Location = new Point(452, 201);
            txtIsbn.Name = "txtIsbn";
            txtIsbn.Size = new Size(200, 26);
            txtIsbn.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(389, 204);
            label2.Name = "label2";
            label2.Size = new Size(48, 18);
            label2.TabIndex = 7;
            label2.Text = "ISBN:";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(452, 246);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(200, 26);
            txtTitle.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(389, 249);
            label3.Name = "label3";
            label3.Size = new Size(40, 18);
            label3.TabIndex = 9;
            label3.Text = "Title:";
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(452, 290);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(200, 26);
            txtAuthor.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(389, 293);
            label4.Name = "label4";
            label4.Size = new Size(57, 18);
            label4.TabIndex = 11;
            label4.Text = "Author:";
            // 
            // btnNew
            // 
            btnNew.Location = new Point(358, 352);
            btnNew.Margin = new Padding(4);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(129, 42);
            btnNew.TabIndex = 13;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(495, 352);
            btnUpdate.Margin = new Padding(4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(129, 42);
            btnUpdate.TabIndex = 14;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(255, 76, 76);
            btnDelete.Location = new Point(632, 352);
            btnDelete.Margin = new Padding(4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(129, 42);
            btnDelete.TabIndex = 15;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // lstBooks
            // 
            lstBooks.FormattingEnabled = true;
            lstBooks.ItemHeight = 18;
            lstBooks.Location = new Point(75, 178);
            lstBooks.Name = "lstBooks";
            lstBooks.Size = new Size(233, 256);
            lstBooks.TabIndex = 16;
            // 
            // footerControl1
            // 
            footerControl1.Location = new Point(-8, 457);
            footerControl1.Name = "footerControl1";
            footerControl1.Size = new Size(800, 50);
            footerControl1.TabIndex = 17;
            // 
            // headerControl1
            // 
            headerControl1.Location = new Point(-8, -7);
            headerControl1.Name = "headerControl1";
            headerControl1.Size = new Size(800, 150);
            headerControl1.TabIndex = 18;
            // 
            // BooksForm
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 506);
            Controls.Add(headerControl1);
            Controls.Add(footerControl1);
            Controls.Add(lstBooks);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnNew);
            Controls.Add(txtAuthor);
            Controls.Add(label4);
            Controls.Add(txtTitle);
            Controls.Add(label3);
            Controls.Add(txtIsbn);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "BooksForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Library Management System";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtIsbn;
        private Label label2;
        private TextBox txtTitle;
        private Label label3;
        private TextBox txtAuthor;
        private Label label4;
        private Button btnNew;
        private Button btnUpdate;
        private Button btnDelete;
        private ListBox lstBooks;
        private FooterControl footerControl1;
        private HeaderControl headerControl1;
    }
}