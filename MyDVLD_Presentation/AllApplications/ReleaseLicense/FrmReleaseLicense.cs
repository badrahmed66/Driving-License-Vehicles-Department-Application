using MyDVLD_BLL;
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

namespace MyDVLD_Presentation.AllApplications.ReleaseLicense
{
	public partial class FrmReleaseLicense : Form
	{
		private int _licenseID;
		private readonly IDetainedLicenseService _detainedLicenseService;
		private readonly ILicenseService _licenseService;

		// in case the License ID came from outside (data grid view )
		public FrmReleaseLicense(int detainedLicenseID ,ILicenseService licenseService)
		{
			InitializeComponent();

			_licenseID = detainedLicenseID;
			_licenseService = licenseService;
			_detainedLicenseService = _licenseService.DetainedLicenseService;
			ctrLicenseInfoWithFilter1.Initialize(_licenseService);
			ctrLicenseInfoWithFilter1.LoadLicenseInfo(_licenseID);
			ctrLicenseInfoWithFilter1.FilterEnable = false;

		}

		// in case the user Enter the License ID Manualy
		public FrmReleaseLicense(ILicenseService licenseService)
		{
			InitializeComponent();
			ctrLicenseInfoWithFilter1.FocusFilter();

			_licenseService = licenseService;
			_detainedLicenseService = _licenseService.DetainedLicenseService;
			ctrLicenseInfoWithFilter1.Initialize(_licenseService);
			ctrLicenseInfoWithFilter1.FilterEnable = true;
		}

		private void ctrLicenseInfoWithFilter1_Load(object sender, EventArgs e)
		{
			
		}

		private void ctrLicenseInfoWithFilter1_OnLicenseSelected(int obj)
		{
			_licenseID = obj;

			if (_licenseID <= 0) return;

			lblLicenseID.Text = _licenseID.ToString();

			// The License Must be Detained Before Anything
			if (ctrLicenseInfoWithFilter1.SelectedLicenseInfo.DetainedLicenseInfo.IsReleased)
			{
				MessageBox.Show("License Is Already Released","Released License",MessageBoxButtons.OK,MessageBoxIcon.Error);
				btnRelease.Enabled = false;
				return;
			}

			// Fill The Card With the Detained license Info
			lblDetainID.Text = ctrLicenseInfoWithFilter1.SelectedLicenseInfo.DetainedLicenseInfo.DetainID.ToString();
			lblDetainDate.Text = ctrLicenseInfoWithFilter1.SelectedLicenseInfo.DetainedLicenseInfo.DetainedDate.ToString("dd/MMM/yyyy");

			lblApplicaitonFees.Text = ApplicationTypeService.FindApplicationTypeByID((int)ApplicationTypeDTO.EnType.releaseDetainedDrivingLicsense).Fees.ToString();

			lblFineFees.Text = ctrLicenseInfoWithFilter1.SelectedLicenseInfo.DetainedLicenseInfo.Fees.ToString();

			lblCreatedByUserID.Text = ctrLicenseInfoWithFilter1.SelectedLicenseInfo.DetainedLicenseInfo.DetainedByUserID.ToString();

			lblTotalFees.Text = (Convert.ToDecimal(lblFineFees.Text) + Convert.ToDecimal(lblApplicaitonFees.Text)).ToString();

			btnRelease.Enabled = true;
		}

		private void btnRelease_Click(object sender, EventArgs e)
		{

			// at first you must create a new application with the Release type
			ApplicationDTO appDTO = new ApplicationDTO();
			appDTO.ApplicationDate = DateTime.Now;
			appDTO.CreatedByUserID = UserAuthenticationService.CurrentUserInfo.UserID;
			appDTO.PersonID = ctrLicenseInfoWithFilter1.SelectedLicenseInfo.ApplicationInfo.PersonID;
			appDTO.ApplicationPaidFees = Convert.ToDecimal(lblApplicaitonFees.Text);
			appDTO.ApplicationLastStatusUpdateDate = DateTime.Now;
			appDTO.ApplicationStatus = ApplicationDTO.Status.Complete;
			appDTO.ApplicationTypeID = (int)ApplicationTypeDTO.EnType.releaseDetainedDrivingLicsense;

			// you should Insert the application in the system
			ApplicationService appService = new ApplicationService(appDTO);
			string message = "";

			if(!appService.AddApplication(out message))
			{
				MessageBox.Show(message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
				return;
			}

			// now we have an application in the system for release the license and you can release it easily
			if (!_detainedLicenseService.ReleaseDetainedLicense(ctrLicenseInfoWithFilter1.SelectedLicenseInfo.DetainedLicenseInfo.DetainID, appDTO.CreatedByUserID, appDTO.ApplicationID))
			{
				MessageBox.Show("Error Happed During The Process","Can't Release License",MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			MessageBox.Show("License Has Released Successfuly", "Release License", MessageBoxButtons.OK, MessageBoxIcon.Information);

			lblApplicationID.Text = appDTO.ApplicationID.ToString();
			btnRelease.Enabled = false;
			ctrLicenseInfoWithFilter1.FilterEnable = false;
			llShowLicenseInfo.Enabled = true;
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
