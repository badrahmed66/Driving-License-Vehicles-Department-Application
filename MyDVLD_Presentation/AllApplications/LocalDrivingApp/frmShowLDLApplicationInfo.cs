using MyDVLD_Business.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyDVLD_Presentation.AllApplications.LocalDrivingApp
{
	public partial class frmShowLDLApplicationInfo : Form
	{
		private int _localID;
		private ITestService _testService;
		public frmShowLDLApplicationInfo(int localID,ITestService testService)
		{
			InitializeComponent();
			_localID = localID;
			_testService = testService;
		}

		private void frmShowLDLApplicationInfo_Load(object sender, EventArgs e)
		{
			ctrLocalDrivingLicenseApplicationInfo1.LoadLDLAppByLocalID(_localID,_testService);
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
