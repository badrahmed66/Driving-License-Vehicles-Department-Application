using System;
using MyDVLD_DTO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyDVLD_Presentation.Properties;
using MyDVLD_DTOs.TestAppointment;
using MyDVLD_Business.Behaviours;
using MyDVLD_BLL;
using MyDVLD_Business.Interfaces;

namespace MyDVLD_Presentation.AllApplications.Tests
{
	public partial class ctrScheduledTest : UserControl
	{

		private TestTypeDTO.EnTestType _testType = TestTypeDTO.EnTestType.Vision;
		public TestTypeDTO.EnTestType TestType
		{
			set
			{
				_testType = value;

				switch(_testType)
				{
					case TestTypeDTO.EnTestType.Vision:
						gbScheduled.Text = "Vision Test";
						pbScheduled.Image = Resources.Vision_512;
						lblScheduledTitle.Text = gbScheduled.Text;
						break;

					case TestTypeDTO.EnTestType.Theory:
						gbScheduled.Text = "Theory Test";
						pbScheduled.Image = Resources.Written_Test_512;
						lblScheduledTitle.Text = gbScheduled.Text;
						break;

					case TestTypeDTO.EnTestType.Practical:
						gbScheduled.Text = "Practical Test";
						lblScheduledTitle.Text =gbScheduled.Text;
						pbScheduled.Image = Resources.Street_Test_32;
						break;
				}
			}
			get
			{
				return _testType;
			}
		}

		public bool TestHasScheduledTitle 
			{
				set 
				{
				if (value)
					lblShowOnly.Visible = true;
				}
			}

		private int _testID;
		public int TestID
		{
			get { return _testID; }
		}

		private int _testAppointmentID;
		public int TestAppointmentID { get { return _testAppointmentID; } }

		public void LoadTestInfo(int testAppointmentID,IDriverService driverService , ILicenseService licenseService)
		{
			_testAppointmentID = testAppointmentID;

			TestAppointmentDTO testAppointmentDTO = TestAppointmentService.Find(_testAppointmentID);

			TestAppointmentService testAppointmentService = new TestAppointmentService(testAppointmentDTO);

			if(testAppointmentDTO == null)
			{
				MessageBox.Show($"No Appointment ID with {_testAppointmentID}" , "Find Test Appointment",MessageBoxButtons.OK, MessageBoxIcon.Error);
				_testAppointmentID = -1;
				return;
			}

			_testID = testAppointmentService.TestID();

			if(testAppointmentDTO.LocalDrivingLicenseApplicationInfo == null)
			{
				MessageBox.Show("No Local Driving License ID", "Find Test Appointment", MessageBoxButtons.OK, MessageBoxIcon.Error);

				return;
			}

			lblLocalDrivingLicenseID.Text = testAppointmentDTO.LocalDrivingLicenseApplicationInfo.LocalDrivingLicenseAppID.ToString();

			lblClassTitle.Text = testAppointmentDTO.LocalDrivingLicenseApplicationInfo.LicenseClassesInfo.LicenseTitle;

			lblName.Text = testAppointmentDTO.LocalDrivingLicenseApplicationInfo.ApplicationInfo.PersonInfoDTO.FullName;

			LocalDrivingLicenseApplicationManager localService = new LocalDrivingLicenseApplicationManager(testAppointmentDTO.LocalDrivingLicenseApplicationInfo,driverService,licenseService);

			lblTrails.Text = localService.TotalTrialsPerTest(TestType).ToString();

			lblDate.Text = testAppointmentDTO.TestAppointmentDate.ToShortDateString();

			lblFees.Text = testAppointmentDTO.PaidFees.ToString();

			lblTestID.Text = testAppointmentService.TestID() <= 0 ? "No Taken Yet" : testAppointmentDTO.TestAppointmentID.ToString();
		}

		public ctrScheduledTest()
		{
			InitializeComponent();
		}

	}
}
