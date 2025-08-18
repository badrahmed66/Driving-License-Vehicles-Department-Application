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

namespace MyDVLD_Presentation.AllApplications.InternationalLicenses
{
	public partial class ctrShowInternationalLicense : UserControl
	{
		private int _internationalLicenseID;
		private int _driverID;
		private  IInternationalLicenseService _internationalService;
		public ctrShowInternationalLicense()
		{
			InitializeComponent();
		}

		private void Reset()
		{
			lblAppID.Text = "???";
			lblDriverID.Text = "???";
			lblDateBirth.Text = "???";
			lblExpireDate.Text = "???";
			lblGender.Text = "???";
			lblIsActive.Text = "???";
			lblIssueDate.Text = "???";
			lblLocalLicenseID.Text = "???";
			lblNationalNo.Text = "???";
			lblName.Text = "???";
			lblInternationalLicenseID.Text = "???";
		}

		public void LoadCardInfo(int internationalLicenseID, IInternationalLicenseService internationalService)
		{
			_internationalService = internationalService;

			var dto = _internationalService.FindByInternationalID(internationalLicenseID);
			if (dto ==null)
			{
				Reset();
				return;
			}

			lblName.Text = dto.ApplicationInfo.PersonInfoDTO.FullName;
			lblInternationalLicenseID.Text = dto.InternationalLicenseID.ToString();
			lblLocalLicenseID.Text = dto.RelatedToLocalLicenseID.ToString();
			lblNationalNo.Text = dto.ApplicationInfo.PersonInfoDTO.NationalNo;
			lblGender.Text = dto.ApplicationInfo.PersonInfoDTO.Gender == 'm' ? "Male " : "Female";
			pbImage.Image = lblGender.Text == "Male" ? Resources.Male_512 : Resources.Woman_32;
			lblIssueDate.Text = dto.IssueDate.ToString("dd/MMM/yyyy");
			lblAppID.Text = dto.ApplicationID.ToString();
			lblIsActive.Text = dto.IsActive == true ? "Yes" : "No";
			lblDateBirth.Text = dto.ApplicationInfo.PersonInfoDTO.DateOfBirth.ToString("dd/MMM/yyyy");
			lblDriverID.Text = dto.DriverID.ToString();
			lblExpireDate.Text = dto.ExpirationDate.ToString("dd/MMM/yyyy");

			string imagePath = dto.ApplicationInfo.PersonInfoDTO.Image;
			if ( imagePath != "")
			{
				if (File.Exists(imagePath))
					pbImage.ImageLocation = imagePath;
				else
					MessageBox.Show("There's An Error During loading Image", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}
	}
}
