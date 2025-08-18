using MyDVLD_BLL;
using MyDVLD_Business.Interfaces;
using MyDVLD_DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyDVLD_Presentation.Licenses
{
	public partial class FrmIssueForFirstTime : Form
	{
		private int _localDrivingID;
		private ITestService _testService;
		private ILicenseService _licenseService;
		private IDriverService _driverService;
		private  LocalDrivingLicenseApplicationDTO _localApplicationDTO;
		public FrmIssueForFirstTime(int localDrivingLicenseID , ITestService testService , ILicenseService licenseService , IDriverService driverService)
		{
			InitializeComponent();
			_testService = testService;
			_licenseService = licenseService;
			_driverService = driverService;

			_localDrivingID = localDrivingLicenseID;

		}

		private void FrmIssueForFirstTime_Load(object sender, EventArgs e)
		{

			_localApplicationDTO = LocalDrivingLicenseApplicationManager.FindLDLApplicationByLDLAppIDorApplicationID(out string message, _localDrivingID);

			// check for valid local application
			if (_localApplicationDTO == null)
			{
				MessageBox.Show($"There's no Local Driving License Application ID with {_localDrivingID}", "Invalide ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			// check about the App has passed all previous tests already
			if(!_testService.PassedAllTests(_localDrivingID))
			{
				MessageBox.Show("you must passed all previous test to issue a license", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			// check if the driver has already a license for this license class or not
			if(_licenseService.IsPersonHasLicense(_localApplicationDTO.ApplicationInfo.PersonID,_localApplicationDTO.LicenseClassID))
			{
				MessageBox.Show($"{_localDrivingID} Has Already a license For this Class", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			ctrLocalDrivingLicenseApplicationInfo1.LoadLDLAppByLocalID(_localDrivingID, _testService);

		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnIssue_Click(object sender, EventArgs e)
		{
			var localService = new LocalDrivingLicenseApplicationManager (_localApplicationDTO,_driverService,_licenseService);

			int licenseID = localService.IssueLicenseForFirstTime(txtNotes.Text.Trim(), UserAuthenticationService.CurrentUserInfo.UserID, _localApplicationDTO.ApplicationInfo.PersonID);

			if (licenseID > 0)
			{
				ApplicationService.SetComplete(_localApplicationDTO.ApplicationID);
				MessageBox.Show($"License Inserted Successfuly ID = {licenseID}", "Insert License Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
				this.Close();
			}
			else
				MessageBox.Show("Failue Process", "Insert License Confirm", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
	}
}
