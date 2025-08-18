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

namespace MyDVLD_Presentation.AllApplications.InternationalLicenses
{
	public partial class FrmShowInternationalLicense : Form
	{
		private int _internationalLicenseID;
		private IInternationalLicenseService _internationalLicenseService;
		public FrmShowInternationalLicense(int internationalLicenseID,IInternationalLicenseService internationalService)
		{
			InitializeComponent();
			_internationalLicenseID = internationalLicenseID;
			_internationalLicenseService = internationalService;
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void FrmShowInternationalLicense_Load(object sender, EventArgs e)
		{
			ctrShowInternationalLicense1.LoadCardInfo(_internationalLicenseID, _internationalLicenseService);
		}
	}
}
