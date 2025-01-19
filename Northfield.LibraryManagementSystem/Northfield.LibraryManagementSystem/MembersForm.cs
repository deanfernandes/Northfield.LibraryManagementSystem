namespace Northfield.LibraryManagementSystem
{
    public partial class MembersForm : Form
    {
        public MembersForm()
        {
            InitializeComponent();

            //center horizontally
            lblHeader.Left = (ClientSize.Width - lblHeader.Width) / 2;
        }
    }
}
