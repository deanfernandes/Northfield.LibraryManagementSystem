namespace Northfield.LibraryManagementSystem
{
    public partial class FooterControl : UserControl
    {
        public FooterControl()
        {
            InitializeComponent();

            //center label horizontally and vertically
            lblVersion.Left = (ClientSize.Width - lblVersion.Width) / 2;
            lblVersion.Top = (ClientSize.Height - lblVersion.Height) / 2;
        }
    }
}
