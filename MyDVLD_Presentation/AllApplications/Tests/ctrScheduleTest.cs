using MyDVLD_BLL;
using MyDVLD_Business.Behaviours;
using MyDVLD_Business.Interfaces;
using MyDVLD_DTO;
using MyDVLD_DTOs.TestAppointment;
using MyDVLD_Presentation.Properties;
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
	public partial class ctrScheduleTest : UserControl
	{
		public enum EnSheduleTestMode { Add = 1 , Update = 2}
		private EnSheduleTestMode _mode;

		public enum EnCreationMode { FirstTime = 1 , RetakeTest = 2}
		private EnCreationMode _creationMode;

		private int _localDrivingID;
		private LocalDrivingLicenseApplicationDTO _localDrivingLicenseApp;
		private int _testAppointmentID = -1;
		private TestAppointmentDTO _testAppointment;

		private TestTypeDTO.EnTestType _testTypeID = TestTypeDTO.EnTestType.Vision;

		private ILicenseService _licenseService;
		private IDriverService _driverService;

		// set the image of the user control realted on the test type
		public TestTypeDTO.EnTestType TestType
		{
			get { return _testTypeID; }
			set 
			{
				_testTypeID = value;
				
				switch(_testTypeID)
				{
					case TestTypeDTO.EnTestType.Vision:
						lblTestType.Text = "Vision Test";
						gbTestInfo.Text = "Vision Test";
						pbTestType.Image = Resources.Vision_512;
						break;

					case TestTypeDTO.EnTestType.Theory:
						lblTestType.Text = "Theory Test";
						gbTestInfo.Text = "Theory Test";
						pbTestType.Image = Resources.Written_Test_512;
						break;

					case TestTypeDTO.EnTestType.Practical:
						lblTestType.Text = "Practical Test";
						gbTestInfo.Text = "Practical Test";
						pbTestType.Image = Resources.Street_Test_32;
						break;
				}
			}
		}

		public void LoadTestData(int localDrivingID ,IDriverService driverSerivce,ILicenseService licenseService ,int  testAppointmentID = -1)
		{
			_driverService = driverSerivce;
			_licenseService = licenseService;

			if (testAppointmentID == -1)
				_mode = EnSheduleTestMode.Add;
			else
				_mode = EnSheduleTestMode.Update;

			_testAppointmentID = testAppointmentID;
			_localDrivingID = localDrivingID; 

			 _localDrivingLicenseApp =
				LocalDrivingLicenseApplicationManager.FindLDLApplicationByLDLAppIDorApplicationID(out string message , _localDrivingID); 

			if(_localDrivingLicenseApp == null)
			{
				MessageBox.Show(message , "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
				btnSave.Enabled = false;
				return;
			}

			LocalDrivingLicenseApplicationManager localAppService = new LocalDrivingLicenseApplicationManager(_localDrivingLicenseApp,_driverService,_licenseService);

			if (localAppService.HasAttendedTest(TestType))
				_creationMode = EnCreationMode.RetakeTest;
			else
				_creationMode = EnCreationMode.FirstTime;

			if(_creationMode == EnCreationMode.RetakeTest)
			{
				// fill the retake test info part with data
				lblRetakeTestFees.Text = ApplicationTypeService.FindApplicationTypeByID((int)ApplicationTypeDTO.EnType.retakeTest).Fees.ToString();

				gbRetake.Enabled = true;
				lblTestType.Text = "Schedule Retake Test";
				lblRetakeTestAppID.Text = "0";
			}
			else
			{
				gbRetake.Enabled = false;
				lblRetakeTestAppID.Text = "N/A";
				lblRetakeTestFees.Text = "0";
				lblTestType.Text = "Schedule Test";
			}

			if(_mode == EnSheduleTestMode.Add)
			{
				var testInfo = TestTypeService.FindTestByID((int)TestType);

				lblFees.Text = testInfo.Fees.ToString(); //TestTypeService.FindTestByID((int)_testTypeID).Fees.ToString();
				dpDate.MinDate = DateTime.Now;
				lblRetakeTestAppID.Text = "N/A";

				_testAppointment = new TestAppointmentDTO();

			}
			else
			{
				if (!LoadTestAppointmentData())
					return;
			}

			lblDrivingLicenseAppID.Text = _localDrivingLicenseApp.LocalDrivingLicenseAppID.ToString();

			lblDrivingClass.Text = _localDrivingLicenseApp.LicenseClassesInfo.LicenseTitle.ToString();

			lblName.Text = _localDrivingLicenseApp.ApplicationInfo.PersonInfoDTO.FullName;

			lblTrials.Text = localAppService.TotalTrialsPerTest(_testTypeID).ToString();

			lblTotalFees.Text = (Convert.ToDecimal(lblFees.Text) + Convert.ToDecimal(lblRetakeTestFees.Text)).ToString();

			if (!HandleActiveAppointmentConstraint()) return;

			if(! HandleIsAppointmentLocked()) return;

			if (!HandlePreviousTest()) return;

		}

		private bool LoadTestAppointmentData()
		{
			_testAppointment = TestAppointmentService.Find(_testAppointmentID);

			if(_testAppointment == null)
			{
				MessageBox.Show($"No Appointment for this id {_testAppointmentID}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				btnSave.Enabled = false;
				return false;
			}
			//
			//_testAppointment.LocalDrivingLicenseApplicationInfo = _localDrivingLicenseApp;
			lblFees.Text = _testAppointment.PaidFees.ToString();

			if (DateTime.Compare(DateTime.Now, _testAppointment.TestAppointmentDate) < 0)
				dpDate.MinDate = DateTime.Now;
			else
				dpDate.MinDate = _testAppointment.TestAppointmentDate;

			dpDate.Value = _testAppointment.TestAppointmentDate;

			if(_testAppointment.RetakeTestApplicationID == -1)
			{
				lblRetakeTestAppID.Text = "N/A";
				lblRetakeTestFees.Text = "0";
			}
			else
			{
				lblRetakeTestFees.Text = _testAppointment.PaidFees.ToString();
				lblRetakeTestAppID.Text = _testAppointment.RetakeTestApplicationID.ToString();
				gbRetake.Enabled = true;
				lblTestType.Text = "Schedule Retake Test";
			}
			return true;

		}

		// verify if the person has an active appointment already or not
		private bool HandleActiveAppointmentConstraint()
		{
			if(_mode == EnSheduleTestMode.Add && LocalDrivingLicenseApplicationManager.HasActiveScheduleAppointment(_localDrivingID, _testTypeID))
			{
				lblUserMessage.Visible = true;
				lblUserMessage.Text = "Person Already Has An Active Schedule Appointment";
				btnSave.Enabled = false;
				dpDate.Enabled = false;
				return false;
			}
			return true;
		}

		// check if the appointment is locked to only show the appointment data didn't update
		private bool HandleIsAppointmentLocked()
		{
			if(_testAppointment.IsLocked)
			{
				lblUserMessage.Visible = true;
				lblUserMessage.Text = "Person Already Sat This Test Before , Appointment Locked";
				btnSave.Enabled = false;
				dpDate.Enabled = false;
				return false;
			}
			return true;
		}

		// check if the person has passed the previous test or not 
		private bool HandlePreviousTest()
		{
			switch (TestType)
			{
				case TestTypeDTO.EnTestType.Vision:
					lblUserMessage.Visible = false;
					return true;

				case TestTypeDTO.EnTestType.Theory:
					{

						if(!LocalDrivingLicenseApplicationManager.HasPassedTest(_localDrivingID,	TestTypeDTO.EnTestType.Vision))
						{
							lblUserMessage.Visible = true;
							lblUserMessage.Text = "Can't Schedule , Must Pass Vision Test First";
							btnSave.Enabled = false;
							dpDate.Enabled = false;
							return false;
						}
						else
						{
							lblUserMessage.Visible = false;
							btnSave.Enabled = true;
							dpDate.Enabled = true;
						}
						return true;
					}

				case TestTypeDTO.EnTestType.Practical:
					{

						if(!LocalDrivingLicenseApplicationManager.HasPassedTest(_localDrivingID,	TestTypeDTO.EnTestType.Theory))
						{
							lblUserMessage.Visible= true;
							lblUserMessage.Text = "Can't Schedule , Must Pass Theory Test First";
							btnSave.Enabled = false;
							dpDate.Enabled = false;
							return false;
						}
						else
						{
							lblUserMessage.Visible = false;
							btnSave.Enabled = true;
							dpDate.Enabled = true;
						}
							return true;
					}
			}
			return true;
		}

		// incase Retake Application
		private bool HandleRetakeApplication()
		{
			if(_creationMode == EnCreationMode.RetakeTest && _mode == EnSheduleTestMode.Add)
			{
				ApplicationDTO app = new ApplicationDTO();

				app.PersonID = _localDrivingLicenseApp.ApplicationInfo.PersonID;
				app.ApplicationDate = DateTime.Now;
				app.ApplicationPaidFees = ApplicationTypeService.FindApplicationTypeByID((int)ApplicationTypeDTO.EnType.retakeTest).Fees;
				app.CreatedByUserID = UserAuthenticationService.CurrentUserInfo.UserID;
				app.ApplicationLastStatusUpdateDate = DateTime.Now;
				app.ApplicationTypeID = (int)ApplicationTypeDTO.EnType.retakeTest;
				app.ApplicationStatus = ApplicationDTO.Status.Complete;

				ApplicationService appService = new ApplicationService(app);

				if(!appService.AddApplication(out string message))
				{
					_testAppointment.RetakeTestApplicationID = -1;
					MessageBox.Show(message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
					return false;
				}
				_testAppointment.RetakeTestApplicationID = app.ApplicationID;

			}
			return true;
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			if (!HandleRetakeApplication()) return;

			_testAppointment.LDLApplicationID = _localDrivingID;
			_testAppointment.LocalDrivingLicenseApplicationInfo = _localDrivingLicenseApp;

			_testAppointment.TestTypeID = TestType;
			_testAppointment.TestTypeInfo = TestTypeService.FindTestByID((int)TestType);

			_testAppointment.CreatedUserID = UserAuthenticationService.CurrentUserInfo.UserID;
			_testAppointment.UserInfo = UserAuthenticationService.CurrentUserInfo;

			_testAppointment.TestAppointmentDate = dpDate.Value;
			_testAppointment.PaidFees = Convert.ToDecimal(lblFees.Text);
			_testAppointment.IsLocked = false;

			TestAppointmentService appointmentService = new TestAppointmentService(_testAppointment);

			if(_mode == EnSheduleTestMode.Add)
			{
				if (appointmentService.Insert())
				{
					_mode = EnSheduleTestMode.Update;
					MessageBox.Show("Appointment Inserted Successfuly", "Insert Confirm", MessageBoxButtons.OK,		MessageBoxIcon.Information);
				}
				else
					MessageBox.Show("Failure Insertion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

			}
			else
			{
				if (appointmentService.Update())
				{
					MessageBox.Show("Appointment UPdated Successfuly", "Update Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else
					MessageBox.Show("Failure Updating", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

			}

		}



		public ctrScheduleTest()
		{
			InitializeComponent();
		}

	}
}

