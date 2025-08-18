using MyDVLD_Business.Interfaces;
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

namespace MyDVLD_Presentation.Drivers
{
	public partial class ctrDriverLicenses : UserControl
	{
		private int _driverID;
		private DataTable _dtLocalLicenses;
		private DataTable _dtInternationalLicenses;
		private ILicenseService _licenseService;
		private IDriverService _driverService;
		private IInternationalLicenseService _internationalService;
		public ctrDriverLicenses()
		{
			InitializeComponent();
		}

		private void LoadInternationalLicenses()
		{
			_dtInternationalLicenses = _internationalService.RetrieveAll(_driverID);

			dgInternationalLicenses.DataSource = _dtInternationalLicenses;

			int count = dgInternationalLicenses.Rows.Count;

			if(count > 0)
			{
				dgInternationalLicenses.Columns["InternationalLicenseID"].HeaderText = "ID";
				dgInternationalLicenses.Columns["IssueDate"].HeaderText = "Issue Date";
				dgInternationalLicenses.Columns["IsActive"].HeaderText = "Is Active";
				dgInternationalLicenses.Columns["DriverID"].HeaderText = "Driver ID";
				dgInternationalLicenses.Columns["CreatedByUserID"].HeaderText = "By User ";
				dgInternationalLicenses.Columns["IssuedUsingLocalLicenseID"].HeaderText = "L.License ID";
				dgInternationalLicenses.Columns["ApplicationID"].HeaderText = "App ID";
				dgInternationalLicenses.Columns["ExpirationDate"].HeaderText = "Expire Date";
				dgInternationalLicenses.Columns["ExpirationDate"].DefaultCellStyle.Format = "dd/MMM/yyyy";
			}
			lblInternationalCount.Text = count.ToString();
		}
		private void LoadLocalLicenses()
		{
			_dtLocalLicenses = _licenseService.GetDriverLicenses(_driverID);

			dgLocalLicenses.DataSource = _dtLocalLicenses;

			int count = dgLocalLicenses.Rows.Count;

			if(count > 0)
			{
				dgLocalLicenses.Columns["LicenseID"].HeaderText = "License ID";
				dgLocalLicenses.Columns["ApplicationID"].HeaderText = "Application ID";
				dgLocalLicenses.Columns["LicenseTitle"].HeaderText = "License Title";
				dgLocalLicenses.Columns["IssueDate"].HeaderText = "Issue Date";
				dgLocalLicenses.Columns["IssueDate"].DefaultCellStyle.Format = "dd/MMM/yyyy";
				dgLocalLicenses.Columns["ExpirationDate"].HeaderText = "Expiration Date";
				dgLocalLicenses.Columns["ExpirationDate"].DefaultCellStyle.Format = "dd/MMM/yyyy";
				dgLocalLicenses.Columns["IsActive"].HeaderText = "Is Active";
			}
			lblCountLocal.Text = count.ToString();
		}

		// General Method You will call it form the outer form
		public void LoadInfo(int personID,ILicenseService licenseService,IInternationalLicenseService internationalService)
		{
			// assign Dependcises
			_licenseService = licenseService;
			_driverService = _licenseService.DriverService;
			_internationalService = internationalService;
			_driverID = _driverService.FindByPersonID(personID).DriverID;

			if (_driverID <= 0)
			{
				MessageBox.Show("Invalid Person ID","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
				return;
			}

			// load licenses in the local licenses tab
			LoadLocalLicenses();

			// load international licenses in the next tab
			LoadInternationalLicenses();
		}

		public void ClearDataTables()
		{
			_dtLocalLicenses.Clear();
		}

		private void showLicenseINFOToolStripMenuItem_Click(object sender, EventArgs e)
		{
			int ID = (int)dgLocalLicenses.CurrentRow.Cells[0].Value;
			FrmShowLicenseInfo frm = new FrmShowLicenseInfo(_licenseService, ID);
			frm.ShowDialog();
		}

	
	}
}
