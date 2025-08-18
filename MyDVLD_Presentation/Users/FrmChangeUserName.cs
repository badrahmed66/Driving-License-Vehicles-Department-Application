using MyDVLD_BLL;
using MyDVLD_BLL.Validation;
using MyDVLD_DTO;
using MyDVLD_DTO.User;
using MyDVLD_DTOs.User;
using System;
using System.ComponentModel;
using System.Net;
using System.Windows.Forms;

namespace MyDVLD_Presentation.Users
{
    public partial class FrmChangeUserName : Form
    {
        private readonly UserDTO _user;

        public FrmChangeUserName(UserDTO user)
        {
            InitializeComponent();
            _user = user ?? throw new ArgumentNullException(nameof(user));
        }

        private void FrmChangeUserName_Load(object sender, EventArgs e)
        {
            txtCurrentUserName.Focus();

            if(_user != null)
            {
                ctrPersonDetailsCard1.LoadPersonInfo(_user.PersonID);
                lblUserID.Text = _user.UserID.ToString();
                lblUserName.Text = _user.UserName;
                lblIsActive.Text = _user.IsActive ? "Yes" : "No";
            }
            else
            {
                btnSave.Enabled = false;
            }
        }

        private void EmptyField_Validation(object sender , CancelEventArgs e)
        {
            TextBox txt = (TextBox)sender;

            if (string.IsNullOrWhiteSpace(txt.Text))
            {
                errorProvider1.SetError(txt, "Mandatory Field");
                e.Cancel = true;
            }
            else
                errorProvider1.SetError(txt, "");
        }

        private void txtNewUserName_Validating(object sender , CancelEventArgs e)
        {
            string error = "";

            string userNameValue = txtNewUserName.Text.Trim();

            if (UserValidator.IsPersonAlreadyUser(null,userName : userNameValue))
                error = "User Name is reserved by another User";

            if (string.IsNullOrWhiteSpace(userNameValue))
                error = "Mandatory Field";

            if (error != "")
            {
                errorProvider1.SetError(txtNewUserName, error);
                e.Cancel = true;
            }
            else
                errorProvider1.SetError(txtNewUserName, "");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(!ValidateChildren())
            {
                MessageBox.Show("There's an Empty Field , Please Fill it","Empty Field Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            if (!UserAuthenticationService.UserAuthentication(txtCurrentUserName.Text.Trim(), txtPassword.Text))
            {
                MessageBox.Show("Wrong User Name or Password","Login Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            _user.UserName = txtNewUserName.Text;

            UserService service = new UserService(_user);

            if (service.Update(txtPassword.Text, out string error))
            {
                MessageBox.Show("Change User Name Successfuly", "Change User Name", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblUserName.Text = _user.UserName;
                UserAuthenticationService.RefreshCurrentUserData(_user.UserName);
                txtCurrentUserName.Clear();
                txtNewUserName.Clear();
                txtPassword.Clear();
            }
            else
            {
                MessageBox.Show("Failed To change user name", "Change User Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCurrentUserName.Clear();
                txtNewUserName.Clear();
                txtPassword.Clear();
                txtCurrentUserName.Focus();
            }    
        }



    }
}
