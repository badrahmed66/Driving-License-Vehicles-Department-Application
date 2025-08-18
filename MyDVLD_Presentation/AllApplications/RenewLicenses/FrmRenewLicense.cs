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
using System.Xml.Linq;

namespace MyDVLD_Presentation.AllApplications.RenewLicenses
{
	public partial class FrmRenewLicense : Form
	{
		private int _newLicenseID;
		private ILicenseService _licenseService;
		private LicenseDTO _newRenewLicense;
		public FrmRenewLicense(ILicenseService licenseService)
		{
			InitializeComponent();
			_licenseService = licenseService;
			ctrLicenseInfoWithFilter1.Initialize(_licenseService);
		}


		private void SetDefaultValues()
		{
			lblApplicationDate.Text = DateTime.Now.ToShortDateString();
			lblIssueDate.Text = lblApplicationDate.Text;

			lblApplicationFees.Text = ApplicationTypeService.FindApplicationTypeByID((int)ApplicationTypeDTO.EnType.renewDrivingLicenseService).Fees.ToString();

			lblCreatedByUserName.Text = UserAuthenticationService.CurrentUserInfo.UserName;

			klblShowLicensInfo.Enabled = false;
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void ctrLicenseInfoWithFilter1_Load(object sender, EventArgs e)
		{
			SetDefaultValues();
		}

		private void ctrLicenseInfoWithFilter1_OnLicenseSelected(int obj)
		{
			int selectedLicenseID = obj;

			lblOldLicenseID.Text = selectedLicenseID.ToString();

			klblShowLicenseHistory.Enabled = selectedLicenseID > 0;

			if (selectedLicenseID <= 0) return;

			int defaultValidatyLength = ctrLicenseInfoWithFilter1.SelectedLicenseInfo.LicenseClassInfo.LicenseDefaultValidateLength;

			lblLicenseFees.Text = ctrLicenseInfoWithFilter1.SelectedLicenseInfo.LicenseClassInfo.LicenseFees.ToString();

			txtNotes.Text = ctrLicenseInfoWithFilter1.SelectedLicenseInfo.Notes;

			lblExpireDate.Text = (DateTime.Now.AddYears(defaultValidatyLength)).ToShortDateString();

			lblTotalFees.Text = (Convert.ToSingle(lblApplicationFees.Text) + Convert.ToSingle(lblLicenseFees.Text)).ToString();

			// The License must be Expire to complete renew application
			DateTime ExpireDate = Convert.ToDateTime(ctrLicenseInfoWithFilter1.SelectedLicenseInfo.ExpirationDate);

			if(! _licenseService.IsLicenseExpired(ExpireDate))
			{
				MessageBox.Show($"Selected License Is not Expire Yet , Expire Date : {ExpireDate}", "Invalid Expire Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
				btnRenew.Enabled = false;

				return;
			}

			// the license must be Active Before Renew it
			if(!ctrLicenseInfoWithFilter1.SelectedLicenseInfo.IsActive)
			{
				MessageBox.Show("You Can't Renew Because The License Is Not Active", "Not Active License", MessageBoxButtons.OK, MessageBoxIcon.Error);
				btnRenew.Enabled = false;

				return;

			}

			btnRenew.Enabled = true;
		}

		private void btnRenew_Click(object sender, EventArgs e)
		{
			if(MessageBox.Show
				("Are You Want To Renew This License","Confirm",MessageBoxButtons.OKCancel,MessageBoxIcon.Question) == DialogResult.Cancel)
				{ return; }

			// Renew the License and get the new license
			 _newRenewLicense = _licenseService.RenewLicense(ctrLicenseInfoWithFilter1.SelectedLicenseInfo, UserAuthenticationService.CurrentUserInfo.UserID,txtNotes.Text.Trim());

			if(_newRenewLicense == null )
			{
				MessageBox.Show("Error Has happened While Renew The License", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			// update the details by the new renew license
			_newLicenseID = _newRenewLicense.LicenseID;

			lblRenwLicenseID.Text = _newLicenseID.ToString();

			lblRenewAppID.Text = _newRenewLicense.ApplicationID.ToString();	

			MessageBox.Show("License Renewed Successfuly","Renew License",MessageBoxButtons.OK,MessageBoxIcon.Information);

			// control the buttons and link labels
			btnRenew.Enabled = false;
			klblShowLicensInfo.Enabled = true;
			ctrLicenseInfoWithFilter1.FilterEnable = false;
		}

		private void klblShowLicensInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{// pass local ID
			FrmShowLicenseInfo frm = new FrmShowLicenseInfo(_licenseService,_newLicenseID);
			frm.ShowDialog();
		}

		private void klblShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			MessageBox.Show("Not Implemented Yet","Feature Will Be Soon", MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}
	}
}
