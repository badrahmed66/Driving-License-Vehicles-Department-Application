using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyDVLD_BLL;
using MyDVLD_DTO;
using MyDVLD_Presentation.AllApplications.DetainedLicenses;
using MyDVLD_Presentation.AllApplications.InternationalLicenses;
using MyDVLD_Presentation.AllApplications.LocalDrivingApp;
using MyDVLD_Presentation.AllApplications.ReleaseLicense;
using MyDVLD_Presentation.AllApplications.RenewLicenses;
using MyDVLD_Presentation.AllApplications.ReplaceForDamagedOrLost;
using MyDVLD_Presentation.Apps;
using MyDVLD_Presentation.Drivers;
using MyDVLD_Presentation.Person;
using MyDVLD_Presentation.TestsTypes;
using MyDVLD_Presentation.Users;

namespace MyDVLD_Presentation
{
	public partial class FrmMain : Form
	{
		private ServicesContainer _container;
		public FrmMain(ServicesContainer container)
		{
			InitializeComponent();
			SetFormSizeAndLocation();
			_container = container;
		}


		// set the values size and location to the form to to be upper the bottom repon of the windows
		private void SetFormSizeAndLocation()
        {
            this.MaximumSize = Screen.PrimaryScreen.WorkingArea.Size;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }
        private void peopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmManagePeople frm = new FrmManagePeople();
            frm.ShowDialog();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUsersManagment frm = new FrmUsersManagment();
            frm.ShowDialog();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserAuthenticationService.Logout();
            Application.Exit();
        }

        private void tsShowCurrentUserInfo_Click(object sender, EventArgs e)
        {
            FrmShowUserDetails frm = new FrmShowUserDetails(UserAuthenticationService.CurrentUserInfo.UserID);
            frm.ShowDialog();
        }

        private void tsChangePassword_Click(object sender, EventArgs e)
        {
            var user = UserService.FindUserDetails(userName: UserAuthenticationService.CurrentUserInfo.UserName);
            FrmChangeUserPassword frm = new FrmChangeUserPassword(user);
            frm.ShowDialog();
        }

        private void tsManageAppsTypes_Click(object sender, EventArgs e)
        {
            FrmManageAppsTypes frm = new FrmManageAppsTypes();
            frm.ShowDialog();
        }

        private void tsManageTestTypes_Click(object sender, EventArgs e)
        {
            FrmManageTestsTypes frm = new FrmManageTestsTypes();
            frm.ShowDialog();
        }

        private void localDrivingLicenseAppToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmManageApplications frm = new FrmManageApplications(_container);
            frm.ShowDialog();
        }

        private void changeUserNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var user = UserService.FindUserDetails(userName: UserAuthenticationService.CurrentUserInfo.UserName);
            FrmChangeUserName frm = new FrmChangeUserName(user);
            frm.ShowDialog();
        }

		private void localDriverLicenseToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FrmManageApplications frm = new FrmManageApplications(_container);
			frm.ShowDialog();
		}

		private void renewLicenseToolStripMenuItem_Click(object sender, EventArgs e)
		{
            FrmRenewLicense frm = new FrmRenewLicense(_container.CreateLicneseService());
            frm.ShowDialog();
		}

		private void replaceForDamagedOrLostToolStripMenuItem_Click(object sender, EventArgs e)
		{
            var form = new FrmReplaceForDamagedOrLost(_container.CreateLicneseService());
            form.ShowDialog();
		}

		private void driversToolStripMenuItem_Click(object sender, EventArgs e)
		{
            FrmManageDrivers frm = new FrmManageDrivers(_container.CreateLicneseService(), _container.CreateInternationalLicenseService());
            frm.ShowDialog();
		}

		private void detainLicenseToolStripMenuItem_Click(object sender, EventArgs e)
		{
            FrmDetainLicense frm = new FrmDetainLicense(_container.CreateLicneseService(), _container.CreateInternationalLicenseService());
            frm.ShowDialog();
		}

		private void releaseLicenseToolStripMenuItem_Click(object sender, EventArgs e)
		{
            var frm = new FrmReleaseLicense(_container.CreateLicneseService());
            frm.ShowDialog();
		}

		private void managedDetainedLicensesToolStripMenuItem_Click(object sender, EventArgs e)
		{
            FrmManageDetainedLicenses frm = new FrmManageDetainedLicenses(_container.CreateLicneseService(),_container.CreateInternationalLicenseService());
            frm.ShowDialog();
		}

		private void internationalLicenseToolStripMenuItem_Click(object sender, EventArgs e)
		{
            var frm = new FrmIssueInternationalLicense(_container.CreateInternationalLicenseService(), _container.CreateLicneseService());
            frm.ShowDialog();
		}

		private void internationalLicensesToolStripMenuItem_Click(object sender, EventArgs e)
		{
            var frm = new FrmManageInternationalLicenses(_container.CreateInternationalLicenseService(),_container.CreateLicneseService());
            frm.ShowDialog();
		}
	}
}
