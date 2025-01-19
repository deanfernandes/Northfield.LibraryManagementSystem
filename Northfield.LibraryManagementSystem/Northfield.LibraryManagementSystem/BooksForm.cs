namespace Northfield.LibraryManagementSystem
{
    public partial class BooksForm : Form
    {
        public BooksForm()
        {
            InitializeComponent();

            //center horizontally
            lblHeader.Left = (ClientSize.Width - lblHeader.Width) / 2;
        }
    }
}
