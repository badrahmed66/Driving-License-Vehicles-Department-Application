using MyDVLD_Business.Interfaces;
using MyDVLD_DTOs;
using MyDVLD_Presentation.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyDVLD_Presentation.Licenses
{
	public partial class ctrDriverLicenseInfo : UserControl
	{
		private int _licenseID;
		private LicenseDTO _licenseDTO;
		public int LicenseID { get { return _licenseID; } }
		public LicenseDTO LicenseInfo { get { return _licenseDTO; } }

		private ILicenseService _licenseService;

		public ctrDriverLicenseInfo()
		{
			InitializeComponent();
		}

		public void Initialize(ILicenseService licenseService)
		{
			_licenseService = licenseService;
		}
		public void LoadLicenseInfo(int licenseID)
		{
			_licenseID = licenseID;

			_licenseDTO = _licenseService.FindByLicenseID(licenseID);

			if (_licenseDTO == null)
			{
				MessageBox.Show("No License With This ID","Invalid License ID",MessageBoxButtons.OK,MessageBoxIcon.Error);
				return;
			}

			// fill the card with the license details
			lblClass.Text = _licenseDTO.LicenseClassInfo.LicenseTitle;
			lblName.Text = _licenseDTO.ApplicationInfo.PersonInfoDTO.FullName;
			lblLicenseID.Text = _licenseID.ToString();
			lblNationalNo.Text = _licenseDTO.ApplicationInfo.PersonInfoDTO.NationalNo;
			lblGender.Text = _licenseDTO.ApplicationInfo.PersonInfoDTO.Gender == 'm' ? "Male" : "Female";
			lblIssueDate.Text = _licenseDTO.IssueDate.ToString("dd/MMM/yyyy").ToLower();
			lblIssueReason.Text = _licenseDTO.GetIssueReasonText; // must return text but there's an error here
			lblNotes.Text = _licenseDTO.Notes == "" ? "No Notes" : _licenseDTO.Notes;
			lblIsActive.Text = _licenseDTO.IsActive  ? "Yes" : "No";
			lblDateOfBirth.Text = _licenseDTO.ApplicationInfo.PersonInfoDTO.DateOfBirth.ToString("dd/MMM/yyyy").ToLower();
			lblDriverID.Text = _licenseDTO.DriverID.ToString();
			lblExpirationDate.Text = _licenseDTO.ExpirationDate.ToString("dd/MMM/yyyy").ToLower();

			lblIsDetained.Text = _licenseService.IsLicenseDetained(_licenseDTO.LicenseID) == true ? "Yes" : "No";

			LoadDriverImage();
		}
	

		private void LoadDriverImage()
		{
			// set the default value to the picture box
			if (_licenseDTO.ApplicationInfo.PersonInfoDTO.Gender == 'm')
				pbDriverImage.Image = Resources.Male_512;
			else
				pbDriverImage.Image = Resources.Woman_32;

			// then check if the driver has a valid photo or not
			string imagePath = _licenseDTO.ApplicationInfo.PersonInfoDTO.Image;
			if (imagePath != "")
				if (File.Exists(imagePath))
					pbDriverImage.Load(imagePath);
			else
					MessageBox.Show("Invalid Driver Image Path","Loading Image Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
		}
	}
}
