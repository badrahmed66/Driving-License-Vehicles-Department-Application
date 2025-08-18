using System;
using MyDVLD_BLL;
using MyDVLD_DTO;
using System.ComponentModel;
using System.Windows.Forms;
using MyDVLD_DTO.User;
using MyDVLD_BLL.Validation;

namespace MyDVLD_Presentation.Users
{
    public partial class FrmAddUser : Form
    {
        private UserDTO User { set; get; }
        
        public enum UserMode { Add = 1 , Update = 2}

        public UserMode Mode { get; private set; }

        public FrmAddUser(UserDTO user , UserMode mode)
        {
            InitializeComponent();

            User = user;
            Mode = mode;
        }

        private void ConfigureFormForAddMode()
        {
            // set form's text and create new instance
            lblUserFormTitle.Text = "ADD New User";
            this.Text = "ADD User";
            User.IsActive = true;

            // configure user control 
            ctrShowPersonDetailsWithFilter1.AddNewPersonButton = true;
            ctrShowPersonDetailsWithFilter1.GroupFilter = true;
            ctrShowPersonDetailsWithFilter1.Focus();

            // configure the buttons which will be enable
            tbUser.SelectedTab = tpUserInfo;
            tpLogInfo.Enabled = false;
            btnPervious.Enabled = false;
            btnSave.Enabled = false;
            btnNext.Enabled = true;
            chbIsActive.Checked = true;
            ClearInputFields();

            errorProvider1.Clear();
        }

        private void LoadData()
        {
            this.Text = "EDIT User Details";
            lblUserFormTitle.Text = "Edit User Details";

            ClearInputFields();

            ctrShowPersonDetailsWithFilter1.LoadPersonInfo(User.PersonID);

            ctrShowPersonDetailsWithFilter1.GroupFilter = false;
            btnPervious.Enabled = false;
            btnNext.Enabled = true;
            btnSave.Enabled = false;

            tpUserInfo.Enabled = true;
            tbUser.SelectedTab = tpUserInfo;
            tpLogInfo.Enabled = false;
            chbIsActive.Checked = User.IsActive;

            errorProvider1.Clear();
        }

        private void ClearInputFields()
        {
            // clear tp Log Info
            txtUserName.Text = "";
            txtPassword.Text = "";
            txtConfirmPassword.Text = "";

        }

        private void FrmAddUser_Load(object sender, EventArgs e)
        {
            if (Mode == UserMode.Add)
                ConfigureFormForAddMode();
            else
                LoadData();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            string errorMessage = "";

            // move from person info to Log info ( ADD MODE)
            if(User.UserID == 0 && tbUser.SelectedTab == tpUserInfo)
            {
                if (!ValidatePersonInfoTabForAddMode(out errorMessage)) 
                {
                    errorMessage = "Must choose person from the system or create him";
                    MessageBox.Show(errorMessage,"Not Found a Person",MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                btnPervious.Enabled = true;
                tpLogInfo.Enabled = true;
                tbUser.SelectedTab = tpLogInfo; // move to the next tap page

            }

            // add mode in the log info tab (enter user name and password)
            else if(User.UserID == 0 && tbUser.SelectedTab == tpLogInfo)
            {
                if (!ValidateLogInfoTabForAddMode(out errorMessage))
                {
                    errorMessage = "User Name or password not valid please check it";
                    MessageBox.Show(errorMessage,"Add User Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }

                btnSave.Enabled = true;
                btnNext.Enabled = false;
            }
         }


        private bool ValidatePersonInfoTabForAddMode(out string errorMessage)
        {
            errorMessage = "";
            errorProvider1.Clear();

            bool isValied = true;

            // check about invalid user 
            if (!ctrShowPersonDetailsWithFilter1.PersonFounded)
            {
                errorMessage = "Add new person or choose from the system";
                errorProvider1.SetError(ctrShowPersonDetailsWithFilter1, errorMessage);
                isValied = false;
            }
            // check if the person already has an account in the system
            else if(User.UserID == 0 && UserValidator.IsPersonAlreadyUser(ctrShowPersonDetailsWithFilter1.PersonID,null))
            {
                errorMessage = "This Person Has Already An Account";
                errorProvider1.SetError(ctrShowPersonDetailsWithFilter1, errorMessage);
                isValied = false;
            }

            return isValied;
        }

        private bool ValidateLogInfoTabForAddMode(out string errorMessage)
        {
            errorMessage = "";
            errorProvider1.Clear();
            bool isValied = true;

            //check on text box of user name
            if (string.IsNullOrWhiteSpace(txtUserName.Text))
            {
                errorMessage = "User Name is Mandatory";
                errorProvider1.SetError(txtUserName,errorMessage);
                isValied = false;
            }
            else if (UserValidator.IsPersonAlreadyUser(null,userName : txtUserName.Text))
            {
                errorMessage = "This User Name Already Exists Choose Another one";
                errorProvider1.SetError(txtUserName, errorMessage);
                isValied = false;
            }
            else
                errorProvider1.SetError(txtUserName, "");

            // check on password's Text box
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                errorMessage = "Password is Mandatory";
                errorProvider1.SetError(txtPassword, errorMessage);
                isValied = false;
            }
            else if (txtPassword.Text.Length < 5)
            {
                errorMessage = "Password Must be over than or Equal to 5 characters or numbers";
                errorProvider1.SetError(txtPassword, errorMessage);
                isValied = false;
            }
            else
                errorProvider1.SetError(txtPassword, "");

            // check on confirm password text box
            if (string.IsNullOrWhiteSpace(txtConfirmPassword.Text))
            {
                errorMessage = "Confirm Password is mandatory";
                errorProvider1.SetError(txtConfirmPassword, errorMessage);
                isValied = false;
            }
            else if (txtConfirmPassword.Text != txtPassword.Text)
            {
                errorMessage = "Must Be Same with Password Field";
                errorProvider1.SetError(txtConfirmPassword,errorMessage);
                isValied = false;
            }
            else
                errorProvider1.SetError(txtConfirmPassword, "");

            return isValied;
        }


        // save the new information for user during the both path add or update in a new object
        private void btnSave_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            string plainPassword = "";

            string resultMessage = "";

            if(Mode == UserMode.Add)
            {
                if(!ValidatePersonInfoTabForAddMode(out resultMessage))
                {
                    MessageBox.Show(resultMessage,"Data Error" , MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbUser.SelectedTab = tpUserInfo;
                    return;
                }

                if(!ValidateLogInfoTabForAddMode(out resultMessage) )
                {
                    MessageBox.Show(resultMessage,"Add New User Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbUser.SelectedTab = tpLogInfo;
                    return;
                }
                User.UserName = txtUserName.Text.Trim();
                //User.PlainTextPassword = txtPassword.Text;
                plainPassword = txtPassword.Text;
            }
            

                // save the information in the object
             User.PersonID = ctrShowPersonDetailsWithFilter1.PersonID;
            User.IsActive = chbIsActive.Checked;

            UserService service = new UserService(User);

            if(Mode == UserMode.Add)
            {
                if (service.Insert(plainPassword,out resultMessage))
                {
                // user saved successfuly
                    plainPassword = string.Empty;
                    MessageBox.Show(resultMessage, "Insert User Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblUserID.Text = User.UserID.ToString();

                    LoadData();
                    }    
                   else
                    MessageBox.Show(resultMessage, "Insert User", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(service.Update(plainPassword, out resultMessage))
                {
                    plainPassword = string.Empty;
                    MessageBox.Show(resultMessage, "Update User Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblUserID.Text = User.UserID.ToString();

                    LoadData();
                }
                else
                    MessageBox.Show(resultMessage, "Update User", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }   

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPervios_Click(object sender, EventArgs e)
        {
            if (tbUser.SelectedTab == tpLogInfo)
                tbUser.SelectedTab = tpUserInfo;

            btnSave.Enabled = false;
            btnPervious.Enabled = false;
            btnNext.Enabled = true;
        }
    }
}
