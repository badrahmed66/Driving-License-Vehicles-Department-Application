using MyDVLD_BLL;
using MyDVLD_DTO.User;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace MyDVLD_Presentation.Users
{
    public partial class FrmChangeUserPassword : Form
    {
        private readonly UserDTO _user;
        public FrmChangeUserPassword(UserDTO user)
        {
            InitializeComponent();
            _user = user;
        }

        private void txtCurrentPassword_Validating(object sender , CancelEventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtCurrentPassword.Text))
            {
                errorProvider1.SetError(txtCurrentPassword, "Mandatory Field");
                e.Cancel = true;
            }
            else
                errorProvider1.SetError(txtCurrentPassword, "");
        }

        private void FrmChangeUserPassword_Load(object sender, EventArgs e)
        {
            if (_user != null)
            {
                ctrShowPersonDetails1.LoadPersonInfo(_user.PersonID);
                lblUserID.Text = _user.UserID.ToString();
                lblUserName.Text = _user.UserName;
                lblIsActive.Text = _user.IsActive ? "Yes" : "No";
            }
            else
            {
                btnSave.Enabled = false;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren() || !UserAuthenticationService.UserAuthentication(_user.UserName,txtCurrentPassword.Text))
            {
                MessageBox.Show("Your Password Input not correct", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            UserService service = new UserService(_user);

            if (MessageBox.Show("Are you Sure to Change User Password ", "Change Password", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                if (service.Update(txtCurrentPassword.Text , out string errorMessage))
                {
                    MessageBox.Show(errorMessage, "Change Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtConfirmPassword.Clear();
                    txtCurrentPassword.Clear();
                    txtNewPassword.Clear();
                }
                else
                    MessageBox.Show("Failue Proccess", errorMessage, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
                
        private void txtConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if (txtConfirmPassword.Text != txtNewPassword.Text || string.IsNullOrWhiteSpace(txtConfirmPassword.Text))
            {
                errorProvider1.SetError(txtConfirmPassword, "must The Same New Password");
                e.Cancel = true;
            }
            else
                errorProvider1.SetError(txtConfirmPassword, "");
        }

        private void txtNewPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNewPassword.Text))
                errorProvider1.SetError(txtNewPassword, "Can't be Empty");
            else
                errorProvider1.SetError(txtNewPassword, "");
        }
    }
}
