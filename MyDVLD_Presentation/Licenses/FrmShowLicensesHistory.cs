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

namespace MyDVLD_Presentation.Licenses
{
	public partial class FrmShowLicensesHistory : Form
	{
		private int _personID;
		private ILicenseService _licenseService;
		public IDriverService DriverService { get; }
		public IInternationalLicenseService _internationalService;
		public FrmShowLicensesHistory(ILicenseService licenseService,IInternationalLicenseService internationalService)
		{
			InitializeComponent();
			_licenseService = licenseService;
			DriverService = _licenseService.DriverService;
			_internationalService = internationalService;
		}

		public FrmShowLicensesHistory(int personID , ILicenseService licenseService,IInternationalLicenseService internationalSerive)
		{
			InitializeComponent();
			_personID = personID;
			_licenseService = licenseService;
			DriverService = _licenseService.DriverService;
			_internationalService = internationalSerive;
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void ctrShowPersonDetailsWithFilter1_Load(object sender, EventArgs e)
		{
			if(_personID > 0)
			{
				ctrShowPersonDetailsWithFilter1.LoadPersonInfo(_personID);
				ctrShowPersonDetailsWithFilter1.GroupFilter = false;
				ctrDriverLicenses1.LoadInfo(_personID,_licenseService,_internationalService);
			}
			else
			{
				ctrShowPersonDetailsWithFilter1.Focus();
				ctrShowPersonDetailsWithFilter1.GroupFilter = true;
			}
		}

		private void ctrShowPersonDetailsWithFilter1_OnPersonSelected(int obj)
		{
			// in this case you Enter The Person ID Manual
			if (obj > 0)
			{
				_personID = obj;
				ctrDriverLicenses1.LoadInfo(_personID, _licenseService,_internationalService);
			}
			else
				ctrDriverLicenses1.ClearDataTables();
		}

	}
}
