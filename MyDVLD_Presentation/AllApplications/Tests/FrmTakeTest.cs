using MyDVLD_BLL;
using MyDVLD_Business.Behaviours;
using MyDVLD_Business.Interfaces;
using MyDVLD_DTO;
using MyDVLD_DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyDVLD_Presentation.AllApplications.Tests
{
	public partial class FrmTakeTest : Form
	{
		private int _testAppointmentID;

		private TestTypeDTO.EnTestType _testType;

		private ITestService _testService;
		private IDriverService _driverService;
		private ILicenseService _licenseService;

		private TestDTO _testDTO;
		public FrmTakeTest(int testAppointmentID , TestTypeDTO.EnTestType testType , ITestService itestService , IDriverService driverService , ILicenseService licenseService)
		{
			InitializeComponent();
			_testAppointmentID = testAppointmentID;
			_testType = testType;
			_testService = itestService;
			_driverService = driverService;
			_licenseService = licenseService;
		}

		private void FrmScheduledTest_Load(object sender, EventArgs e)
		{
			
			ctrScheduledTest1.TestType = _testType; // came from test appointment from data grid view

			ctrScheduledTest1.LoadTestInfo(_testAppointmentID,_driverService,_licenseService);

			if (ctrScheduledTest1.TestAppointmentID <= 0) 
				btnSave.Enabled = false;
			else
				btnSave.Enabled = true;

			int testID = ctrScheduledTest1.TestID;

			if (testID > 0)
			{
				// only show the test information not change anything
				_testDTO = _testService.FindByID(testID);
				
				if (_testDTO.IsPassed)
					rbPass.Checked = true;
				else
					rbFail.Checked = true; // check the result

				txtNotes.Text = _testDTO.Notes;
				ctrScheduledTest1.TestHasScheduledTitle = true;

				// visible the title that shows the test has scheduled already
				ctrScheduledTest1.TestType = _testDTO.TestAppointmentInfo.TestTypeID;

				// disable the component only show them
				lblMessage.Visible = true;
				rbPass.Enabled = false;
				rbFail.Enabled = false;
				txtNotes.Enabled = false;
				btnSave.Enabled = false;
			}
			else 
				_testDTO = new TestDTO(); 

		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Are you sure to Save the Test You Can't change the result again ?", "Save Test Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

			_testDTO.TestAppointmentID = _testAppointmentID;
			_testDTO.Notes = txtNotes.Text.Trim();
			_testDTO.IsPassed = rbPass.Checked ;
			_testDTO.CreatedByUserID = UserAuthenticationService.CurrentUserInfo.UserID;

			if (_testService.Save(_testDTO))
			{
				MessageBox.Show("Test Saved Successfuly","Saved Test",MessageBoxButtons.OK, MessageBoxIcon.Information);
				
				btnSave.Enabled = false;
			}
			else
				MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
