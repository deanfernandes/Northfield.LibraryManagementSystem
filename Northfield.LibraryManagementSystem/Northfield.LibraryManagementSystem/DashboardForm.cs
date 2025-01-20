using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Northfield.LibraryManagementSystem
{
    public partial class DashboardForm : Form
    {
        public DashboardForm(LoginForm loginForm)
        {
            InitializeComponent();

            //center horizontally
            lblHeader.Left = (ClientSize.Width - lblHeader.Width) / 2;
            btnBooks.Left = (ClientSize.Width - btnBooks.Width) / 2;
            btnMembers.Left = (ClientSize.Width - btnMembers.Width) / 2;
            btnLoans.Left = (ClientSize.Width - btnLoans.Width) / 2;
            btnLogout.Left = (ClientSize.Width - btnLogout.Width) / 2;
        }
    }
}
