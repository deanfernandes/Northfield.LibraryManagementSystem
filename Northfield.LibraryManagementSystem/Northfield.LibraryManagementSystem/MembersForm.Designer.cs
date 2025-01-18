namespace Northfield.LibraryManagementSystem
{
    partial class MembersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MembersForm));
            footerControl1 = new FooterControl();
            lstMembers = new ListBox();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnNew = new Button();
            txtLastName = new TextBox();
            label4 = new Label();
            txtFirstName = new TextBox();
            label3 = new Label();
            txtCardNumber = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txtEmail = new TextBox();
            label5 = new Label();
            headerControl1 = new HeaderControl();
            SuspendLayout();
            // 
            // footerControl1
            // 
            footerControl1.Location = new Point(-8, 457);
            footerControl1.Name = "footerControl1";
            footerControl1.Size = new Size(800, 50);
            footerControl1.TabIndex = 29;
            // 
            // lstMembers
            // 
            lstMembers.FormattingEnabled = true;
            lstMembers.ItemHeight = 18;
            lstMembers.Location = new Point(75, 181);
            lstMembers.Name = "lstMembers";
            lstMembers.Size = new Size(233, 256);
            lstMembers.TabIndex = 28;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(255, 76, 76);
            btnDelete.Location = new Point(632, 355);
            btnDelete.Margin = new Padding(4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(129, 42);
            btnDelete.TabIndex = 27;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(495, 355);
            btnUpdate.Margin = new Padding(4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(129, 42);
            btnUpdate.TabIndex = 26;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(358, 355);
            btnNew.Margin = new Padding(4);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(129, 42);
            btnNew.TabIndex = 25;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(501, 272);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(200, 26);
            txtLastName.TabIndex = 24;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(390, 272);
            label4.Name = "label4";
            label4.Size = new Size(88, 18);
            label4.TabIndex = 23;
            label4.Text = "Last Name:";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(501, 228);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(200, 26);
            txtFirstName.TabIndex = 22;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(389, 228);
            label3.Name = "label3";
            label3.Size = new Size(89, 18);
            label3.TabIndex = 21;
            label3.Text = "First Name:";
            // 
            // txtCardNumber
            // 
            txtCardNumber.Location = new Point(501, 190);
            txtCardNumber.Name = "txtCardNumber";
            txtCardNumber.Size = new Size(200, 26);
            txtCardNumber.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(389, 190);
            label2.Name = "label2";
            label2.Size = new Size(106, 18);
            label2.TabIndex = 19;
            label2.Text = "Card Number:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(338, 151);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(118, 29);
            label1.TabIndex = 18;
            label1.Text = "Members";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(501, 310);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(200, 26);
            txtEmail.TabIndex = 31;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(390, 310);
            label5.Name = "label5";
            label5.Size = new Size(52, 18);
            label5.TabIndex = 30;
            label5.Text = "Email:";
            // 
            // headerControl1
            // 
            headerControl1.Location = new Point(-8, -21);
            headerControl1.Name = "headerControl1";
            headerControl1.Size = new Size(800, 150);
            headerControl1.TabIndex = 32;
            // 
            // MembersForm
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 506);
            Controls.Add(headerControl1);
            Controls.Add(txtEmail);
            Controls.Add(label5);
            Controls.Add(footerControl1);
            Controls.Add(lstMembers);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnNew);
            Controls.Add(txtLastName);
            Controls.Add(label4);
            Controls.Add(txtFirstName);
            Controls.Add(label3);
            Controls.Add(txtCardNumber);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "MembersForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Library Management System";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FooterControl footerControl1;
        private ListBox lstMembers;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnNew;
        private TextBox txtLastName;
        private Label label4;
        private TextBox txtFirstName;
        private Label label3;
        private TextBox txtCardNumber;
        private Label label2;
        private Label label1;
        private TextBox txtEmail;
        private Label label5;
        private HeaderControl headerControl1;
    }
}