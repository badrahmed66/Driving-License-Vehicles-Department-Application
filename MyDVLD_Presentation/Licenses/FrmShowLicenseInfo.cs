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
	public partial class FrmShowLicenseInfo : Form
	{
		private int _licenseID;
		private readonly ILicenseService _licenseService;
		public FrmShowLicenseInfo(ILicenseService licenseService, int licenseID)
		{
			InitializeComponent();
			_licenseService = licenseService;
			_licenseID = licenseID;
		}



		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void FrmShowLicenseInfo_Load(object sender, EventArgs e)
		{
			if(_licenseID <= 0)
			{
				MessageBox.Show("Invalid Local Driving License App ID","Invalid ID",MessageBoxButtons.OK,MessageBoxIcon.Error);
				return;
			}

			ctrDriverLicenseInfo1.Initialize(_licenseService);
			ctrDriverLicenseInfo1.LoadLicenseInfo(_licenseID);
		}
	}
}
