namespace Northfield.LibraryManagementSystem
{
    public partial class DashboardForm : Form
    {
        public LoginForm LoginForm { get; set; }

        public DashboardForm(LoginForm loginForm)
        {
            InitializeComponent();

            //center horizontally
            lblHeader.Left = (ClientSize.Width - lblHeader.Width) / 2;
            btnBooks.Left = (ClientSize.Width - btnBooks.Width) / 2;
            btnMembers.Left = (ClientSize.Width - btnMembers.Width) / 2;
            btnLoans.Left = (ClientSize.Width - btnLoans.Width) / 2;
            btnLogout.Left = (ClientSize.Width - btnLogout.Width) / 2;

            LoginForm = loginForm;
        }

        private void DashboardForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoginForm.Show();
        }

        private void btnBooks_Click(object sender, EventArgs e)
        {
            new BooksForm().ShowDialog();
        }

        private void btnMembers_Click(object sender, EventArgs e)
        {
            new MembersForm().ShowDialog();
        }

        private void btnLoans_Click(object sender, EventArgs e)
        {
            new LoansForm().ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
