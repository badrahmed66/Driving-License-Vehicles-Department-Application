using MyDVLD_BLL;
using MyDVLD_Business.Interfaces;
using MyDVLD_DTO;
using MyDVLD_DTOs;
using MyDVLD_Presentation.Licenses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyDVLD_Presentation.AllApplications.ReplaceForDamagedOrLost
{
	public partial class FrmReplaceForDamagedOrLost : Form
	{
		private LicenseDTO _newLicenseInfo;
		private ILicenseService _licenseService;
		public FrmReplaceForDamagedOrLost(ILicenseService licenseService)
		{
			InitializeComponent();
			_licenseService = licenseService;
			ctrLicenseInfoWithFilter1.Initialize(_licenseService);
		}

		private void DefaultCardValues()
		{
			rbDamaged.Checked = true;
			lblApplicationDate.Text = DateTime.Now.ToString("dd/MMM/yyyy");
			lblCreatedByUser.Text = UserAuthenticationService.CurrentUserInfo.UserName;
			llShowLicenseInfo.Enabled = false;
		}

		private void ctrLicenseInfoWithFilter1_Load(object sender, EventArgs e)
		{
			DefaultCardValues();
		}

		private int GetApplicationTypeID()
		{
			if (rbDamaged.Checked)
				return (int)ApplicationTypeDTO.EnType.replacementForDamagedDrivingLicense;
			else
				return (int)ApplicationTypeDTO.EnType.replacementForLostDrivingLicense;
		}

		private LicenseDTO.EnIssueReason GetReason()
		{
			if (rbDamaged.Checked)
				return LicenseDTO.EnIssueReason.Damaged;
			else
				return LicenseDTO.EnIssueReason.Lost;
		}

		private void rbDamaged_CheckedChanged(object sender, EventArgs e)
		{
			this.Text = "Replacment For Damaged License";
			lblTitle.Text = this.Text;
			lblApplicationFees.Text = ApplicationTypeService.FindApplicationTypeByID(GetApplicationTypeID()).Fees.ToString();
		}

		private void btnIssueReplacement_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Are You Sure To Issue New License", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.Cancel)
				return;

			_newLicenseInfo = _licenseService.ReplaceLicense(ctrLicenseInfoWithFilter1.SelectedLicenseInfo,GetReason(), UserAuthenticationService.CurrentUserInfo.UserID);

			if(_newLicenseInfo == null)
			{
				MessageBox.Show("License Didn't Replaced","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			lblRreplacedLicenseID.Text = _newLicenseInfo.LicenseID.ToString();
			lblApplicationID.Text = _newLicenseInfo.ApplicationID.ToString();

			MessageBox.Show("License Replaced Successfult","Success Replacment",MessageBoxButtons.OK,MessageBoxIcon.Information);

			btnIssueReplacement.Enabled = false;
			llShowLicenseInfo.Enabled = true;
			ctrLicenseInfoWithFilter1.FilterEnable = false;


		}

		private void rbLost_CheckedChanged(object sender, EventArgs e)
		{
			this.Text = "Replacment For Lost License";
			lblTitle.Text = this.Text;
			lblApplicationFees.Text = ApplicationTypeService.FindApplicationTypeByID(GetApplicationTypeID()).Fees.ToString();
		}

		private void ctrLicenseInfoWithFilter1_OnLicenseSelected(int obj)
		{
			int selectedLicenseID = obj;

			if (selectedLicenseID <= 0) return;

			lblOldLicenseID.Text = selectedLicenseID.ToString();

			if(!ctrLicenseInfoWithFilter1.SelectedLicenseInfo.IsActive)
			{
				btnIssueReplacement.Enabled = false;
				MessageBox.Show("License Is Not Active","Not Active",MessageBoxButtons.OK,MessageBoxIcon.Error);
				return;
			}

			btnIssueReplacement.Enabled = true;

		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void llShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			FrmShowLicenseInfo frm = new FrmShowLicenseInfo(_licenseService, _newLicenseInfo.LicenseID);
			frm.ShowDialog();
		}

		private void llShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			MessageBox.Show("Not Implemented Yet");
		}

		private void FrmReplaceForDamagedOrLost_Activated(object sender, EventArgs e)
		{
			ctrLicenseInfoWithFilter1.Focus();
		}
	}
}
