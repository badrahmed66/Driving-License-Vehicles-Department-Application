using MyDVLD_BLL;
using MyDVLD_Business.Interfaces;
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

namespace MyDVLD_Presentation.AllApplications.DetainedLicenses
{
	public partial class FrmDetainLicense : Form
	{
		private int _selectedLicenseID;
		private readonly IDetainedLicenseService _detainedLicenseService;
		private readonly ILicenseService _licenseService;
		private readonly IDriverService _driverService;
		private readonly IInternationalLicenseService _internationalSerivce;
		public FrmDetainLicense(ILicenseService licenseService,IInternationalLicenseService internationalService)
		{
			InitializeComponent();
			_licenseService = licenseService;
			_detainedLicenseService = _licenseService.DetainedLicenseService;
			_driverService = _licenseService.DriverService;
			ctrLicenseInfoWithFilter1.Initialize(_licenseService);
			_internationalSerivce = internationalService;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void ctrLicenseInfoWithFilter1_Load(object sender, EventArgs e)
		{
			lblDetainDate.Text = DateTime.Now.ToString("dd/MMM/yyyy");
			lblCreatedByUserID.Text = UserAuthenticationService.CurrentUserInfo.UserName;
			ctrLicenseInfoWithFilter1.FocusFilter();
			btnDetain.Enabled = false;
			llShowLicenseInfo.Enabled = false;
		}

		private void ctrLicenseInfoWithFilter1_OnLicenseSelected(int obj)
		{
			_selectedLicenseID = obj;
			if (_selectedLicenseID <= 0)
			{
				MessageBox.Show("Invalid License ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			lblLicenseID.Text = _selectedLicenseID.ToString();

			// check about the license is not Already detained
			if (_detainedLicenseService.IsLicenseDetained(_selectedLicenseID))
			{
				MessageBox.Show("License is Already Detained","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
				return;
			}

			btnDetain.Enabled = true;
			txtFees.Focus();
		}

		private void txtFees_Validating(object sender, CancelEventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txtFees.Text))
			{
				errorProvider1.SetError(txtFees, "Mandatory Field Must Not Be Emtpy");
				e.Cancel = true;
			}
			else
				errorProvider1.SetError(txtFees, null);

		}

		private void txtFees_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
		}

		private void btnDetain_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Are You Sure To Detain This License", "Detain Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
				return;

			DetainedLicenseDTO newDetainDTO = new DetainedLicenseDTO();

			newDetainDTO.DetainedDate = DateTime.Now;
			newDetainDTO.DetainedByUserID = UserAuthenticationService.CurrentUserInfo.UserID;
			newDetainDTO.LicenseID = _selectedLicenseID;
			newDetainDTO.Fees = Convert.ToDecimal(txtFees.Text.Trim());
			newDetainDTO.IsReleased = false;

			if (!_detainedLicenseService.Save(newDetainDTO))
			{
				MessageBox.Show("License Didn't Detained ","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
				return;
			}

			MessageBox.Show($"License {newDetainDTO.DetainID} Detained Successfuly", "Detain Process", MessageBoxButtons.OK, MessageBoxIcon.Information);

			lblDetainID.Text = newDetainDTO.DetainID.ToString();
			btnDetain.Enabled = false;
			llShowLicenseInfo.Enabled = true;
			txtFees.Enabled = false;
			ctrLicenseInfoWithFilter1.FilterEnable = false;
		}

		private void llShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			FrmShowLicenseInfo frm = new FrmShowLicenseInfo(_licenseService, _selectedLicenseID);
			frm.ShowDialog();
		}

		private void llShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			FrmShowLicensesHistory frm = new FrmShowLicensesHistory(_licenseService,_internationalSerivce);
			frm.ShowDialog();
		}
	}
}
