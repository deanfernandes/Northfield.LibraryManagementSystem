using Northfield.LibraryManagementSystem.Library.Models;
using Northfield.LibraryManagementSystem.Library.Services;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;

namespace Northfield.LibraryManagementSystem
{
    public partial class LoansForm : Form
    {
        SqlDatabaseService SqlDatabaseService = new SqlDatabaseService(ConfigurationManager.ConnectionStrings["default"].ConnectionString);

        public LoansForm()
        {
            InitializeComponent();

            //center horizontally
            lblHeader.Left = (ClientSize.Width - lblHeader.Width) / 2;

            lstLoans.DisplayMember = "DisplayMember";

            ResetLstLoans();

            //add tooltip for abbreviation
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(lblCardNumber, "Card Number");
        }

        private void btnLoan_Click(object sender, EventArgs e)
        {
            if (IsDataValid() == false)
            {
                return;
            }

            //check if book exists
            Book? book = SqlDatabaseService.SelectBookByIsbn(txtIsbn.Text);
            if (book == null)
            {
                MessageBox.Show("Invalid Isbn", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            //check if member exists
            Member member = SqlDatabaseService.SelectMemberByCardNumber(txtCardNumber.Text);
            if (member == null)
            {
                MessageBox.Show("Invalid Card Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            //check if already loaned
            if (SqlDatabaseService.IsBookOnLoan(txtIsbn.Text))
            {
                MessageBox.Show("Invalid Isbn (book is already loaned)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            Loan loan = new Loan(txtIsbn.Text, txtCardNumber.Text);
            try
            {
                SqlDatabaseService.InsertLoan(loan);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inserting loan", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                Debug.WriteLine(ex.Message);

                return;
            }

            ResetLstLoans();

            MessageBox.Show("Loaned book", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            if (IsDataValid() == false)
            {
                return;
            }

            if (lstLoans.SelectedItem is Loan loan)
            {
                try
                {
                    SqlDatabaseService.UpdateLoanReturn(loan.LoanId);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error inserting loan", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    Debug.WriteLine(ex.Message);

                    return;
                }
            }

            ResetLstLoans();

            MessageBox.Show("Loaned book", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void lstLoans_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstLoans.SelectedItem is Loan loan)
            {
                txtIsbn.Text = loan.Isbn;
                txtCardNumber.Text = loan.CardNumber;

                btnReturn.Enabled = true;
                btnLoan.Enabled = false;

                txtIsbn.Enabled = false;
                txtCardNumber.Enabled = false;

                lblReturnDate.Text = loan.ReturnDate?.ToString("yyyy-MM-dd") ?? string.Empty;
            }
            else
            {
                txtIsbn.Clear();
                txtCardNumber.Clear();

                btnReturn.Enabled = false;
                btnLoan.Enabled = true;

                txtIsbn.Enabled = true;
                txtCardNumber.Enabled = true;

                lblReturnDate.Text = string.Empty;
            }
        }

        private bool IsDataValid()
        {
            if (string.IsNullOrEmpty(txtIsbn.Text))
            {
                MessageBox.Show("Empty Isbn", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
            else if (string.IsNullOrEmpty(txtCardNumber.Text))
            {
                MessageBox.Show("Empty Card Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }

            if (txtIsbn.TextLength != 13)
            {
                MessageBox.Show("Invalid Isbn", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }

            return true;
        }

        private void ResetLstLoans()
        {
            var loans = SqlDatabaseService.SelectAllLoans();
            var notReturnedLoans = loans.Where(loan => loan.ReturnDate == null).ToList();
            lstLoans.DataSource = notReturnedLoans.ToList();

            if (lstLoans.Items.Count == 0)
            {
                txtIsbn.Clear();
                txtCardNumber.Clear();

                btnReturn.Enabled = false;
                btnLoan.Enabled = true;

                txtIsbn.Enabled = true;
                txtCardNumber.Enabled = true;

                lblReturnDate.Text = string.Empty;
            }
            else
            {
                //don't select item
                lstLoans.SelectedIndex = -1;
            }
        }
    }
}
