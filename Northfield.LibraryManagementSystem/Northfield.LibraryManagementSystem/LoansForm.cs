namespace Northfield.LibraryManagementSystem
{
    public partial class LoansForm : Form
    {
        public LoansForm()
        {
            InitializeComponent();

            //center horizontally
            lblHeader.Left = (ClientSize.Width - lblHeader.Width) / 2;
        }
    }
}
