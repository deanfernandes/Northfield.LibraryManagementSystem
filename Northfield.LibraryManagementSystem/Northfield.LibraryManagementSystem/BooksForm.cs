using Northfield.LibraryManagementSystem.Library.Models;
using Northfield.LibraryManagementSystem.Library.Services;
using System.Configuration;
using System.Diagnostics;

namespace Northfield.LibraryManagementSystem
{
    public partial class BooksForm : Form
    {
        SqlDatabaseService SqlDatabaseService = new SqlDatabaseService(ConfigurationManager.ConnectionStrings["default"].ConnectionString);

        public BooksForm()
        {
            InitializeComponent();

            //center horizontally
            lblHeader.Left = (ClientSize.Width - lblHeader.Width) / 2;

            lstBooks.DisplayMember = "DisplayMember";

            ResetLstBooks();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            if (IsDataValid() == false)
            {
                return;
            }

            Book book = new Book(txtIsbn.Text, txtTitle.Text, txtAuthor.Text);
            try
            {
                SqlDatabaseService.InsertBook(book);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inserting book", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                Debug.WriteLine(ex.Message);

                return;
            }

            ResetLstBooks();

            MessageBox.Show("Inserted book", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (IsDataValid() == false)
            {
                return;
            }

            if (lstBooks.SelectedItem is Book book)
            {
                book.Title = txtTitle.Text;
                book.Author = txtAuthor.Text;

                SqlDatabaseService.UpdateBook(book);

                ResetLstBooks();

                MessageBox.Show("Updated book", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (IsDataValid() == false)
            {
                return;
            }

            DialogResult res = MessageBox.Show("Are you sure you want to delete this book?", "Delete book", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.No)
            {
                return;
            }

            if (lstBooks.SelectedItem is Book book)
            {
                SqlDatabaseService.DeleteBook(book.Isbn);

                ResetLstBooks();

                MessageBox.Show("Deleted book", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void lstBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstBooks.SelectedItem is Book book)
            {
                txtIsbn.Text = book.Isbn;
                txtTitle.Text = book.Title;
                txtAuthor.Text = book.Author;

                btnNew.Enabled = false;
                btnDelete.Enabled = true;
                btnUpdate.Enabled = true;

                txtIsbn.Enabled = false;
            }
            else
            {
                txtIsbn.Clear();
                txtTitle.Clear();
                txtAuthor.Clear();

                btnNew.Enabled = true;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;

                txtIsbn.Enabled = true;
            }
        }

        private bool IsDataValid()
        {
            if (string.IsNullOrEmpty(txtIsbn.Text))
            {
                MessageBox.Show("Empty Isbn", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
            else if (string.IsNullOrEmpty(txtTitle.Text))
            {
                MessageBox.Show("Empty Title", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
            else if (string.IsNullOrEmpty(txtAuthor.Text))
            {
                MessageBox.Show("Empty Author", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }

            if (txtIsbn.TextLength != 13)
            {
                MessageBox.Show("Invalid Isbn", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }

            return true;
        }

        private void ResetLstBooks()
        {
            lstBooks.DataSource = SqlDatabaseService.SelectAllBooks();
            //don't select item
            lstBooks.SelectedIndex = -1;
        }
    }
}
