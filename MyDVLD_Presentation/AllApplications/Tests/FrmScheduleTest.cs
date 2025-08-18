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

namespace MyDVLD_Presentation.AllApplications.Tests
{
	public partial class FrmScheduleTest : Form
	{
		private int _localDrivingID;
		private int _testAppointmentID = -1;
		private TestTypeDTO.EnTestType _testType = TestTypeDTO.EnTestType.Vision;
		private IDriverService _driverService;
		private ILicenseService _licenseService;
		public FrmScheduleTest(int localID , TestTypeDTO.EnTestType testType , IDriverService driverService, ILicenseService licenseService, int testAppointment = -1)
		{
			InitializeComponent();
			_localDrivingID = localID;
			_testAppointmentID=testAppointment;
			_testType = testType;
			_driverService = driverService;
			_licenseService = licenseService;
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void ctrScheduleTest1_Load(object sender, EventArgs e)
		{
			ctrScheduleTest1.TestType = _testType;
			ctrScheduleTest1.LoadTestData(_localDrivingID,_driverService,_licenseService, _testAppointmentID);
		}
	}
}
