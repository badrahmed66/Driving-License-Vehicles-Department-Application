using MyDVLD_BLL;
using MyDVLD_Business.Interfaces;
using MyDVLD_DTO;
using MyDVLD_Presentation.Person;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyDVLD_Presentation.AllApplications
{
	public partial class ctrLocalDrivingLicenseApplicationInfo : UserControl
	{
		private LocalDrivingLicenseApplicationDTO _localDrivingLicesenApplication;
		private ITestService _testService;
		public int LocalDrivingID { get; private set; } = -1;
		private int _licenseID = -1;
		public byte PassedTests { set; get; }
		public ctrLocalDrivingLicenseApplicationInfo()
		{
			InitializeComponent();
		}
		public void ResetValues()
		{
			lblLDLApplicationID.Text = "[???]";
			lblAppliedFor.Text = "[???]";
			lblPassedTests.Text = "[???]";
			ctrApplicationInfo1.Reset();
		}

		private void FillLocalDrivingLicenseCard()
		{
			_licenseID = 0; // Get The Active License By the method

			lblPassedTests.Text = $"{PassedTests}/3";

			klblShowLicenseInfo.Enabled = (_licenseID != -1);
			lblLDLApplicationID.Text =_localDrivingLicesenApplication.LocalDrivingLicenseAppID.ToString();
			lblAppliedFor.Text = LicenseClassService.FindByLicenseIDOrTitle(licenseID:_localDrivingLicesenApplication.LicenseClassID).LicenseTitle;
			ctrApplicationInfo1.LoadApplicationInfo(_localDrivingLicesenApplication.ApplicationID);
		}

		public void LoadLDLAppByLocalID(int localID, ITestService testService)
		{
			_testService = testService; 
			LocalDrivingID = localID;
			PassedTests = testService.CountPassedTests(LocalDrivingID);

			_localDrivingLicesenApplication = LocalDrivingLicenseApplicationManager.FindLDLApplicationByLDLAppIDorApplicationID(out string message, localDrivingID: LocalDrivingID);
			if (_localDrivingLicesenApplication == null)
			{
				ResetValues();
				MessageBox.Show(message, "Local Driving Confirm", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			else
				FillLocalDrivingLicenseCard();
		}

		public void LoadLDLAppByApplicationID(int appID, ITestService testService)
		{
			_testService = testService;
			PassedTests = testService.CountPassedTests(LocalDrivingID);

			_localDrivingLicesenApplication = LocalDrivingLicenseApplicationManager.FindLDLApplicationByLDLAppIDorApplicationID(out string message , applicationID :  appID);
			if (_localDrivingLicesenApplication == null)
			{
				ResetValues();
				MessageBox.Show(message, "Application Confirm", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			else
				FillLocalDrivingLicenseCard();
		}

		private void klblShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{

		}


	}
}
