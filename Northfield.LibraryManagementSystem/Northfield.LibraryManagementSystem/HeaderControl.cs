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
    public partial class HeaderControl : UserControl
    {
        public HeaderControl()
        {
            InitializeComponent();

            //center logo picture box horizontally and vertically
            picLogo.Left = (ClientSize.Width - picLogo.Width) / 2;
            picLogo.Top = (ClientSize.Height - picLogo.Height) / 2;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
