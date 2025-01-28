using Northfield.LibraryManagementSystem.Library.Services;
using System.Configuration;

namespace Northfield.LibraryManagementSystem
{
    public partial class LoginForm : Form
    {
        private readonly IDataService _dataService;
        private readonly LoginService _loginService;
        public LoginForm()
        {
            InitializeComponent();

            //center horizontally
            lblHeader.Left = (ClientSize.Width - lblHeader.Width) / 2;
            txtUsername.Left = (ClientSize.Width - txtUsername.Width) / 2;
            txtPassword.Left = (ClientSize.Width - txtPassword.Width) / 2;
            btnLogin.Left = (ClientSize.Width - btnLogin.Width) / 2;

            _dataService = new SqlDatabaseService(ConfigurationManager.ConnectionStrings["default"].ConnectionString);
            _loginService = new LoginService(_dataService);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            PerformLogin();
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                PerformLogin();

                e.SuppressKeyPress = true; //prevent "ding" sound
            }
        }

        private void LoginForm_Activated(object sender, EventArgs e)
        {
            Invoke(() => txtUsername.Focus());
        }

        private void PerformLogin()
        {
            if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Empty Username or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_loginService.Login(txtUsername.Text, txtPassword.Text) == false)
            {
                MessageBox.Show("Invalid Username or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Hide();
            new DashboardForm(this).Show();

            txtUsername.Clear();
            txtPassword.Clear();
        }
    }
}
