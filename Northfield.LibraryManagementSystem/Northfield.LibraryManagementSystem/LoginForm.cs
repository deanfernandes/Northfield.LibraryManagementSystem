namespace Northfield.LibraryManagementSystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            //center horizontally
            lblHeader.Left = (ClientSize.Width - lblHeader.Width) / 2;
            txtUsername.Left = (ClientSize.Width - txtUsername.Width) / 2;
            txtPassword.Left = (ClientSize.Width - txtPassword.Width) / 2;
            btnLogin.Left = (ClientSize.Width - btnLogin.Width) / 2;
        }
    }
}
