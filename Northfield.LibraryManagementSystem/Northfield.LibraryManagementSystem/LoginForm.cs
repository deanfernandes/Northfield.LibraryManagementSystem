using Northfield.LibraryManagementSystem.Library.Services;
using System.Configuration;

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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Empty Username or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            SqlDatabaseService sqlDatabaseService = new SqlDatabaseService(ConfigurationManager.ConnectionStrings["default"].ConnectionString);
            var admin = sqlDatabaseService.SelectAdmin(txtUsername.Text);

            if (admin != null)
            {
                if (PasswordService.VerifyPassword(txtPassword.Text, admin.PasswordHash, admin.Salt))
                {
                    Hide();
                    new DashboardForm(this).Show();

                    txtUsername.Clear();
                    txtPassword.Clear();

                    return;
                }
            }

            MessageBox.Show("Invalid Username or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }

        private void LoginForm_Activated(object sender, EventArgs e)
        {
            Invoke(() => txtUsername.Focus());
        }
    }
}
