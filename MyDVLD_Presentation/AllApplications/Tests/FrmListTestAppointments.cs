using MyDVLD_BLL;
using MyDVLD_Business.Behaviours;
using MyDVLD_Business.Interfaces;
using MyDVLD_DAL.Behaviours;
using MyDVLD_DAL.Interfaces;
using MyDVLD_DTO;
using MyDVLD_DTOs;
using MyDVLD_DTOs.TestAppointment;
using MyDVLD_Presentation.Properties;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MyDVLD_Presentation.AllApplications.Tests
{
	public partial class FrmListTestAppointments : Form
	{
		private List<TestAppointmentDTO> originList;
		private int _localDrivingLicenseID;

		private TestTypeDTO.EnTestType _testType;

		private ITestService _testService ;
		private IDriverService _driverService;
		private ILicenseService _licenseService;
		public FrmListTestAppointments(int localID , TestTypeDTO.EnTestType testType,ITestService testService , IDriverService driverService , ILicenseService licenseService)
		{
			InitializeComponent();
			_testType = testType;
			_localDrivingLicenseID = localID;
			_testService = testService;
			_driverService = driverService;
			_licenseService = licenseService;
		}

		// Bind the data grid view with Appointments List
		private void ConfigureDataGridAppointments()
		{
			originList = TestAppointmentService.GetAll(_localDrivingLicenseID);

			dgvTestAppointments.DataSource = originList;

			int count = dgvTestAppointments.Rows.Count;

			//hide these properties from the Data Grid View
			dgvTestAppointments.Columns["TestTypeID"].Visible = false;
			dgvTestAppointments.Columns["CreatedUserID"].Visible = false;
			dgvTestAppointments.Columns["RetakeTestApplicationID"].Visible = false;
			dgvTestAppointments.Columns["TestTypeInfo"].Visible = false;
			dgvTestAppointments.Columns["UserInfo"].Visible = false;
			dgvTestAppointments.Columns["LocalDrivingLicenseApplicationInfo"].Visible = false;
			dgvTestAppointments.Columns["RetakeTestInfo"].Visible = false;


			if (count > 0)
			{

				// only show these properties in the data grid view
				dgvTestAppointments.Columns["TestAppointmentID"].HeaderText = "Appointment ID";
				dgvTestAppointments.Columns["TestAppointmentID"].Width = 150;

				dgvTestAppointments.Columns["LDLApplicationID"].HeaderText = "Local Driving ID";
				dgvTestAppointments.Columns["LDLApplicationID"].Width = 150;

				dgvTestAppointments.Columns["TestAppointmentDate"].HeaderText = "Appointment Date";

				dgvTestAppointments.Columns["PaidFees"].HeaderText = "Paid Fees";
				dgvTestAppointments.Columns["PaidFees"].Width = 70;

				dgvTestAppointments.Columns["IsLocked"].HeaderText = "Is Locked";
				dgvTestAppointments.Columns["IsLocked"].Width = 70;
			}

			lblRecords.Text = count.ToString();

		}

		// handle the Test Type Cases(image , titles)
		private void HandleTestTypeCases()
		{
			switch (_testType)
			{
				case TestTypeDTO.EnTestType.Vision:
					pbAppointment.Image = Resources.Vision_512;
					lblAppointment.Text = "Vision Test Appointment";
					this.Text = lblAppointment.Text;
					break;

				case TestTypeDTO.EnTestType.Theory:
					pbAppointment.Image = Resources.Written_Test_512;
					lblAppointment.Text = "Theory Test Appointment";
					this.Text = lblAppointment.Text;
					break;

				case TestTypeDTO.EnTestType.Practical:
					pbAppointment.Image = Resources.Street_Test_32;
					lblAppointment.Text = "Practical Test Appointment";
					this.Text = lblAppointment.Text;
					break;
			}

		}

		private void FrmListTestAppointments_Load(object sender, EventArgs e)
		{
			ConfigureDataGridAppointments();

			HandleTestTypeCases();
			ctrLocalDrivingLicenseApplicationInfo1.PassedTests = _testService.CountPassedTests(_localDrivingLicenseID);

			ctrLocalDrivingLicenseApplicationInfo1.LoadLDLAppByLocalID(_localDrivingLicenseID, _testService);
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		 private void btnAddNewAppointment_Click(object sender, EventArgs e)
		  {

			var localDTO =LocalDrivingLicenseApplicationManager.FindLDLApplicationByLDLAppIDorApplicationID(out	string message , _localDrivingLicenseID);
			
			var localService = new LocalDrivingLicenseApplicationManager(localDTO,_driverService, _licenseService);
			// don't allow him to schedule a test he has passed it already.
			if(localService.HasPassedTest(_testType))
			{
				MessageBox.Show("This Local Driving License ID Already Has Passed This Test Before", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			// check if he already had a schedule for this test
			if(localService.HasActiveScheduleAppointment(_testType))
			{
				MessageBox.Show("this Local Driving license app ID has already an active Schedule for this test", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			var testDTO = _testService.GetLastTestInfo(localDTO.ApplicationInfo.PersonID, localDTO.LicenseClassID, _testType);

			// this is the first time for schedule test
			if(testDTO == null)
			{
				FrmScheduleTest frm = new FrmScheduleTest(_localDrivingLicenseID, _testType,_driverService,_licenseService);
				frm.ShowDialog();
				FrmListTestAppointments_Load(null, null);
				return;
			}

			if(testDTO.IsPassed == true)
			{
				MessageBox.Show("Already Passed This Test Before","Not Allowed",MessageBoxButtons.OK,MessageBoxIcon.Error);
				return;
			}
				
			FrmScheduleTest frm1 = new FrmScheduleTest(testDTO.TestAppointmentInfo.LDLApplicationID, _testType,_driverService,_licenseService);
			frm1.ShowDialog();
			FrmListTestAppointments_Load(null, null);

		  }

		private void takeTestToolStripMenuItem_Click(object sender, EventArgs e)
		{
			int testAppointmentID = (int)dgvTestAppointments.CurrentRow.Cells[0].Value;
			FrmTakeTest frm = new FrmTakeTest(testAppointmentID, _testType, _testService,_driverService,_licenseService);
			frm.ShowDialog();
			FrmListTestAppointments_Load(null, null);

		}

		private void editToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FrmScheduleTest frm1 = new FrmScheduleTest(_localDrivingLicenseID	, _testType, _driverService, _licenseService, (int)dgvTestAppointments.CurrentRow.Cells[0].Value);
			frm1.ShowDialog();
			FrmListTestAppointments_Load(null, null);
		}
	}
}
