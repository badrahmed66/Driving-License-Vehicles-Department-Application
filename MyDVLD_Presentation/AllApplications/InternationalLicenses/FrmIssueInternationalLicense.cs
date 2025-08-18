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

namespace MyDVLD_Presentation.AllApplications.InternationalLicenses
{
	public partial class FrmIssueInternationalLicense : Form
	{
		private readonly IInternationalLicenseService _internationalService;
		private readonly ILicenseService _licenseService;
		private int _licenseID;
		private int _internationalLicenseID;

		public FrmIssueInternationalLicense(IInternationalLicenseService internationalService , ILicenseService licenseService)
		{
			InitializeComponent();
			_internationalService = internationalService;
			_licenseService = licenseService;
			ctrLicenseInfoWithFilter1.Initialize(_licenseService);
		}


		private void ctrLicenseInfoWithFilter1_OnLicenseSelected(int obj)
		{
			_licenseID = obj;


			if(_licenseID <= 0)
			{
				MessageBox.Show("Invalid License ID","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
				btnIssue.Enabled = false;
				llShowLicenseInfo.Enabled = false;
				return;
			}
			llShowLicenseHistory.Enabled = (_licenseID > 0);
			lblApplicationDate.Text = DateTime.Now.ToString("dd/MMM/yyyy");
			lblIssueDate.Text = DateTime.Now.ToString("dd/MMM/yyyy");
			lblFees.Text = ApplicationTypeService.FindApplicationTypeByID((int)ApplicationTypeDTO.EnType.newInternationalLicense).Fees.ToString();
			lblExpireDate.Text = DateTime.Now.AddYears(2).ToString("dd/MMM/yyyyy");
			lblLocalLicenseID.Text = _licenseID.ToString();
			lblCreatedByUser.Text = UserAuthenticationService.CurrentUserInfo.UserName;

			// check about two things (person doesn't have international license and he has license of class 3 already)
			if(ctrLicenseInfoWithFilter1.SelectedLicenseInfo.LicenseClassID != 4)
			{
				MessageBox.Show("License Must to Class 3 Ordinary Driving License", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				btnIssue.Enabled = false;
				llShowLicenseInfo.Enabled = false;
				return;
			}

			int activateID = _internationalService.GetActiveInternationalLicenseID(ctrLicenseInfoWithFilter1.SelectedLicenseInfo.DriverID);

			if (activateID > 0)
			{
				MessageBox.Show("Person Has Already International License ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				btnIssue.Enabled = false;
				_internationalLicenseID = activateID;
				llShowLicenseInfo.Enabled = true;
				lblInternationalLicenseID.Text = activateID.ToString();
				return;
			}

			btnIssue.Enabled = true;


		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnIssue_Click(object sender, EventArgs e)
		{
			// create , fill and save Application object
			ApplicationDTO app = new ApplicationDTO();
			app.ApplicationStatus = ApplicationDTO.Status.Complete;
			app.ApplicationDate = DateTime.Now;
			app.ApplicationLastStatusUpdateDate = DateTime.Now;
			app.ApplicationTypeID = (int)ApplicationTypeDTO.EnType.newInternationalLicense;
			app.ApplicationPaidFees = ApplicationTypeService.FindApplicationTypeByID(app.ApplicationTypeID).Fees;
			app.CreatedByUserID = UserAuthenticationService.CurrentUserInfo.UserID;
			app.PersonID = ctrLicenseInfoWithFilter1.SelectedLicenseInfo.ApplicationInfo.PersonID;

			ApplicationService appService = new ApplicationService(app);

			if(!appService.AddApplication(out string m))
			{
				MessageBox.Show("Application Didin't Inserted","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
				btnIssue.Enabled = false;
				return;
			}

			lblApplicationID.Text = app.ApplicationID.ToString();

			// create and fill international DTO object
			InternationalLicenseDTO newLicense = new InternationalLicenseDTO();
			newLicense.ApplicationID = app.ApplicationID;
			newLicense.RelatedToLocalLicenseID = ctrLicenseInfoWithFilter1.SelectedLicenseInfo.LicenseID;
			newLicense.CreatedByUserID= UserAuthenticationService.CurrentUserInfo.UserID;
			newLicense.DriverID = ctrLicenseInfoWithFilter1 .SelectedLicenseInfo.DriverID;
			newLicense.IsActive = true;
			newLicense.IssueDate = DateTime.Now;
			newLicense.ExpirationDate = DateTime.Now.AddYears(2); 

			if(!_internationalService.Insert(newLicense))
			{
				MessageBox.Show("CAn't Inserted The International LIcense","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
				btnIssue.Enabled = false;
				return;
			}

			MessageBox.Show("International License Inserted Successfuly", "Add License", MessageBoxButtons.OK, MessageBoxIcon.Information);

			_internationalLicenseID = newLicense.InternationalLicenseID;
			lblInternationalLicenseID.Text = _internationalLicenseID.ToString();
			btnIssue.Enabled = false;
			llShowLicenseInfo.Enabled = true;
			ctrLicenseInfoWithFilter1.FilterEnable = false;
		}

		private void llShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			FrmShowInternationalLicense frm = new FrmShowInternationalLicense(_internationalLicenseID, _internationalService);
			frm.ShowDialog();
		}

		private void llShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			int personID = ctrLicenseInfoWithFilter1.SelectedLicenseInfo.ApplicationInfo.PersonID;
			FrmShowLicensesHistory frm = new FrmShowLicensesHistory(personID,_licenseService,_internationalService);
			frm.ShowDialog();
		}

		private void FrmIssueInternationalLicense_Load(object sender, EventArgs e)
		{
			llShowLicenseInfo.Enabled = false;

		}

		private void FrmIssueInternationalLicense_Activated(object sender, EventArgs e)
		{
			ctrLicenseInfoWithFilter1.FocusFilter();
		}
	}
}
