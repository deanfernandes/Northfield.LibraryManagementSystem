﻿namespace Northfield.LibraryManagementSystem
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
            lblHeader = new Label();
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
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeader.Location = new Point(0, 150);
            lblHeader.Margin = new Padding(4, 0, 4, 0);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(86, 29);
            lblHeader.TabIndex = 6;
            lblHeader.Text = "Books";
            // 
            // txtIsbn
            // 
            txtIsbn.Location = new Point(500, 200);
            txtIsbn.MaxLength = 13;
            txtIsbn.Name = "txtIsbn";
            txtIsbn.Size = new Size(200, 26);
            txtIsbn.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(425, 200);
            label2.Name = "label2";
            label2.Size = new Size(48, 18);
            label2.TabIndex = 7;
            label2.Text = "ISBN:";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(500, 250);
            txtTitle.MaxLength = 255;
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(200, 26);
            txtTitle.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(425, 250);
            label3.Name = "label3";
            label3.Size = new Size(40, 18);
            label3.TabIndex = 9;
            label3.Text = "Title:";
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(500, 300);
            txtAuthor.MaxLength = 255;
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(200, 26);
            txtAuthor.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(425, 300);
            label4.Name = "label4";
            label4.Size = new Size(57, 18);
            label4.TabIndex = 11;
            label4.Text = "Author:";
            // 
            // btnNew
            // 
            btnNew.Location = new Point(327, 373);
            btnNew.Margin = new Padding(4);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(129, 42);
            btnNew.TabIndex = 4;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Enabled = false;
            btnUpdate.Location = new Point(480, 373);
            btnUpdate.Margin = new Padding(4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(129, 42);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(255, 76, 76);
            btnDelete.Enabled = false;
            btnDelete.Location = new Point(630, 373);
            btnDelete.Margin = new Padding(4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(129, 42);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // lstBooks
            // 
            lstBooks.FormattingEnabled = true;
            lstBooks.ItemHeight = 18;
            lstBooks.Location = new Point(48, 200);
            lstBooks.Name = "lstBooks";
            lstBooks.Size = new Size(233, 256);
            lstBooks.TabIndex = 16;
            lstBooks.SelectedIndexChanged += lstBooks_SelectedIndexChanged;
            // 
            // footerControl1
            // 
            footerControl1.Location = new Point(0, 555);
            footerControl1.Name = "footerControl1";
            footerControl1.Size = new Size(800, 50);
            footerControl1.TabIndex = 17;
            // 
            // headerControl1
            // 
            headerControl1.Location = new Point(0, 0);
            headerControl1.Name = "headerControl1";
            headerControl1.Size = new Size(800, 150);
            headerControl1.TabIndex = 18;
            // 
            // BooksForm
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 606);
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
            Controls.Add(lblHeader);
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

        private Label lblHeader;
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