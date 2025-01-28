using Northfield.LibraryManagementSystem.Library.Models;
using Northfield.LibraryManagementSystem.Library.Services;
using System.Configuration;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace Northfield.LibraryManagementSystem
{
    public partial class MembersForm : Form
    {
        private readonly IDataService _dataService;

        public MembersForm()
        {
            InitializeComponent();

            //center horizontally
            lblHeader.Left = (ClientSize.Width - lblHeader.Width) / 2;

            _dataService = new SqlDatabaseService(ConfigurationManager.ConnectionStrings["default"].ConnectionString);

            lstMembers.DisplayMember = "DisplayMember";

            ResetLstMembers();

            //add tooltips for abbreviations
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(lblEmailAddress, "Email Address");
            toolTip.SetToolTip(lblCardNumber, "Card Number");
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            if (IsDataValid() == false)
            {
                return;
            }

            Member member = new Member(txtCardNumber.Text, txtFirstName.Text, txtLastName.Text, txtEmailAddress.Text);
            try
            {
                _dataService.InsertMember(member);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inserting member", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                Debug.WriteLine(ex.Message);

                return;
            }

            ResetLstMembers();

            MessageBox.Show("Inserted member", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (IsDataValid() == false)
            {
                return;
            }

            if (lstMembers.SelectedItem is Member member)
            {
                member.FirstName = txtFirstName.Text;
                member.LastName = txtLastName.Text;
                member.EmailAddress = txtEmailAddress.Text;

                _dataService.UpdateMember(member);

                ResetLstMembers();

                MessageBox.Show("Updated member", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (IsDataValid() == false)
            {
                return;
            }

            DialogResult res = MessageBox.Show("Are you sure you want to delete this member?", "Delete member", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.No)
            {
                return;
            }

            if (lstMembers.SelectedItem is Member member)
            {
                _dataService.DeleteMember(member.CardNumber);

                ResetLstMembers();

                MessageBox.Show("Deleted member", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void lstMembers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstMembers.SelectedItem is Member member)
            {
                txtCardNumber.Text = member.CardNumber;
                txtFirstName.Text = member.FirstName;
                txtLastName.Text = member.LastName;
                txtEmailAddress.Text = member.EmailAddress;

                btnNew.Enabled = false;
                btnDelete.Enabled = true;
                btnUpdate.Enabled = true;

                txtCardNumber.Enabled = false;
            }
            else
            {
                txtCardNumber.Clear();
                txtFirstName.Clear();
                txtLastName.Clear();
                txtEmailAddress.Clear();

                btnNew.Enabled = true;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;

                txtCardNumber.Enabled = true;
            }
        }

        private bool IsDataValid()
        {
            if (string.IsNullOrEmpty(txtCardNumber.Text))
            {
                MessageBox.Show("Empty Card Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
            else if (string.IsNullOrEmpty(txtFirstName.Text))
            {
                MessageBox.Show("Empty First Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
            else if (string.IsNullOrEmpty(txtLastName.Text))
            {
                MessageBox.Show("Empty Last Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
            else if (string.IsNullOrEmpty(txtEmailAddress.Text))
            {
                MessageBox.Show("Empty Email Address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }

            if (IsEmailValid(txtEmailAddress.Text) == false)
            {
                MessageBox.Show("Invalid Email Address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }

            return true;
        }
        
        private bool IsEmailValid(string email)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            Regex regex = new Regex(pattern);

            return regex.IsMatch(email);
        }

        private void ResetLstMembers()
        {
            lstMembers.DataSource = _dataService.SelectAllMembers();

            if (lstMembers.Items.Count == 0)
            {
                txtCardNumber.Clear();
                txtFirstName.Clear();
                txtLastName.Clear();
                txtEmailAddress.Clear();

                btnNew.Enabled = true;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;

                txtCardNumber.Enabled = true;
            }
            else
            {
                //don't select item
                lstMembers.SelectedIndex = -1;
            }
        }
    }
}
