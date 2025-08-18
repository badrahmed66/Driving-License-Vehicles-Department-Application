using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyDVLD_BLL;
using MyDVLD_DTO;
using MyDVLD_DTO.User;
namespace MyDVLD_Presentation.Users
{
    public partial class FrmShowUserDetails : Form
    {
        private int _userID;
        private UserDTO _userDTO;
        public FrmShowUserDetails(int userID)
        {
            InitializeComponent();
            _userID = userID;
        }

        private void FrmShowUserDetails_Load(object sender, EventArgs e)
        {
            _userDTO = UserService.FindUserDetails(userID :_userID);

            if(_userDTO != null)
            {
                ctrShowPersonDetails1.LoadPersonInfo(_userDTO.PersonID);
                // current user details 
                lblUserID.Text = UserAuthenticationService.CurrentUserInfo.UserID.ToString();
                lblUserName.Text = UserAuthenticationService.CurrentUserInfo.UserName;
                lblIsActive.Text = UserAuthenticationService.CurrentUserInfo.IsActive ? "Yes" : "No";
            }
            else
                MessageBox.Show("WE Can't Find This User","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

    }
}
