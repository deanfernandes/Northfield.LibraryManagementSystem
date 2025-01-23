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
            lblCardNumber = new Label();
            lblHeader = new Label();
            txtEmailAddress = new TextBox();
            lblEmailAddress = new Label();
            headerControl1 = new HeaderControl();
            SuspendLayout();
            // 
            // footerControl1
            // 
            footerControl1.Location = new Point(0, 555);
            footerControl1.Name = "footerControl1";
            footerControl1.Size = new Size(800, 50);
            footerControl1.TabIndex = 29;
            // 
            // lstMembers
            // 
            lstMembers.FormattingEnabled = true;
            lstMembers.ItemHeight = 18;
            lstMembers.Location = new Point(75, 200);
            lstMembers.Name = "lstMembers";
            lstMembers.Size = new Size(233, 256);
            lstMembers.TabIndex = 28;
            lstMembers.SelectedIndexChanged += lstMembers_SelectedIndexChanged;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(255, 76, 76);
            btnDelete.Enabled = false;
            btnDelete.Location = new Point(638, 414);
            btnDelete.Margin = new Padding(4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(129, 42);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Enabled = false;
            btnUpdate.Location = new Point(501, 414);
            btnUpdate.Margin = new Padding(4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(129, 42);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(366, 414);
            btnNew.Margin = new Padding(4);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(129, 42);
            btnNew.TabIndex = 5;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(501, 300);
            txtLastName.MaxLength = 255;
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(200, 26);
            txtLastName.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(390, 300);
            label4.Name = "label4";
            label4.Size = new Size(88, 18);
            label4.TabIndex = 23;
            label4.Text = "Last Name:";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(501, 250);
            txtFirstName.MaxLength = 255;
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(200, 26);
            txtFirstName.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(390, 250);
            label3.Name = "label3";
            label3.Size = new Size(89, 18);
            label3.TabIndex = 21;
            label3.Text = "First Name:";
            // 
            // txtCardNumber
            // 
            txtCardNumber.Location = new Point(501, 200);
            txtCardNumber.MaxLength = 255;
            txtCardNumber.Name = "txtCardNumber";
            txtCardNumber.Size = new Size(200, 26);
            txtCardNumber.TabIndex = 1;
            // 
            // lblCardNumber
            // 
            lblCardNumber.AutoSize = true;
            lblCardNumber.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCardNumber.Location = new Point(390, 200);
            lblCardNumber.Name = "lblCardNumber";
            lblCardNumber.Size = new Size(68, 18);
            lblCardNumber.TabIndex = 19;
            lblCardNumber.Text = "Card №:";
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeader.Location = new Point(0, 150);
            lblHeader.Margin = new Padding(4, 0, 4, 0);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(118, 29);
            lblHeader.TabIndex = 18;
            lblHeader.Text = "Members";
            // 
            // txtEmailAddress
            // 
            txtEmailAddress.Location = new Point(501, 350);
            txtEmailAddress.MaxLength = 255;
            txtEmailAddress.Name = "txtEmailAddress";
            txtEmailAddress.Size = new Size(200, 26);
            txtEmailAddress.TabIndex = 4;
            // 
            // lblEmailAddress
            // 
            lblEmailAddress.AutoSize = true;
            lblEmailAddress.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmailAddress.Location = new Point(390, 350);
            lblEmailAddress.Name = "lblEmailAddress";
            lblEmailAddress.Size = new Size(52, 18);
            lblEmailAddress.TabIndex = 30;
            lblEmailAddress.Text = "Email:";
            // 
            // headerControl1
            // 
            headerControl1.Location = new Point(0, 0);
            headerControl1.Name = "headerControl1";
            headerControl1.Size = new Size(800, 150);
            headerControl1.TabIndex = 32;
            // 
            // MembersForm
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 606);
            Controls.Add(headerControl1);
            Controls.Add(txtEmailAddress);
            Controls.Add(lblEmailAddress);
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
            Controls.Add(lblCardNumber);
            Controls.Add(lblHeader);
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
        private Label lblCardNumber;
        private Label lblHeader;
        private TextBox txtEmailAddress;
        private Label lblEmailAddress;
        private HeaderControl headerControl1;
    }
}