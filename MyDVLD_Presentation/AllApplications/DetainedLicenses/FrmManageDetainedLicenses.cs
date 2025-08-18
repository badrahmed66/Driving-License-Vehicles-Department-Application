using MyDVLD_Business.Interfaces;
using MyDVLD_Presentation.AllApplications.ReleaseLicense;
using MyDVLD_Presentation.Licenses;
using MyDVLD_Presentation.Person;
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
	public partial class FrmManageDetainedLicenses : Form
	{
		private DataTable _dtDetainedLicenses;
		private ILicenseService _licenseService;
		private IInternationalLicenseService _internationalService;
		public FrmManageDetainedLicenses(ILicenseService licenseService, IInternationalLicenseService internationalService)
		{
			InitializeComponent();
			_licenseService = licenseService;
			_internationalService = internationalService;
		}

		private void SetOptionsInComboBox()
		{
			cbFilterBy.Items.Clear();
			string[] options = new string[] { "None", "Detain ID", "Is Release", "National No", "Full Name", "Release Application ID" };

			cbFilterBy.Items.AddRange(options);
			cbFilterBy.SelectedText = "None";
		}

		private void SetOptionInReleasedComboBox()
		{
			cbReleased.Items.Clear();
			string[] options = new string[] {"All","Yes", "No" };
			cbReleased.Items.AddRange(options);
			cbReleased.SelectedText = "All";
		}
		private void ConfigureDataGridView()
		{
			_dtDetainedLicenses = _licenseService.DetainedLicenseService.RetrieveAll();
			dgDetainedLicenses.DataSource = _dtDetainedLicenses;
			int count = _dtDetainedLicenses.Rows.Count;

			if(count > 0)
			{
				dgDetainedLicenses.Columns["DetainID"].HeaderText = "ID";
				dgDetainedLicenses.Columns["DetainID"].Width = 50;
				dgDetainedLicenses.Columns["LicenseID"].HeaderText = "License ID";
				dgDetainedLicenses.Columns["LicenseID"].Width = 70;
				dgDetainedLicenses.Columns["DetainDate"].HeaderText = "D.Date";
				dgDetainedLicenses.Columns["DetainDate"].DefaultCellStyle.Format = "dd/MMM/yyyy";
				dgDetainedLicenses.Columns["IsRelease"].HeaderText = "Is Release";
				dgDetainedLicenses.Columns["Fees"].HeaderText = "Fees";
				dgDetainedLicenses.Columns["ReleaseDate"].HeaderText = "R.Date";
				dgDetainedLicenses.Columns["ReleaseDate"].DefaultCellStyle.Format = "dd/MMM/yyyy";
				dgDetainedLicenses.Columns["NationalNo"].HeaderText = "National No";
				dgDetainedLicenses.Columns["FullName"].HeaderText = "Full Name";
				dgDetainedLicenses.Columns["ReleaseApplicationID"].HeaderText = "R.App ID";
			}
			lblCount.Text = count.ToString();
		}

		private void LoadInfo()
		{
			txtFilterBy.Visible = false;
			cbReleased.Visible = false;
			SetOptionsInComboBox();

			SetOptionInReleasedComboBox();

			ConfigureDataGridView();

		}

		private void FrmManageDetainedLicenses_Load(object sender, EventArgs e)
		{
			LoadInfo(); 
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
		{

			if(cbFilterBy.Text == "Is Release")
			{
				cbReleased.Visible = true;
				txtFilterBy.Visible = false;
				cbReleased.Focus();
				return;
			}
			else
			{
				txtFilterBy.Visible = (cbFilterBy.Text != "None");

				cbReleased.Visible = false;

				if (cbFilterBy.SelectedText != "None")
				{
					txtFilterBy.Visible = true;
					txtFilterBy.Focus();
					txtFilterBy.Clear();

				}	
			}
		}

		private void txtFilterBy_TextChanged(object sender, EventArgs e)
		{
			string filterValue = "";

			// Map To The Real Column Name
			switch (cbFilterBy.Text)
			{
				case "Detain ID":
					filterValue = "DetainID";
					break;

				case "Is Released":
					filterValue = "IsRelease";
					break;

				case "National No":
					filterValue = "NationalNo";
					break;

				case "Full Name":
					filterValue = "FullName";
					break;

				case "Release Application ID":
					filterValue = "ReleaseApplicationID";
					break;
			}

			// No Filter
			if (cbFilterBy.Text == "None" || txtFilterBy.Text.Trim() == "")
			{
				_dtDetainedLicenses.DefaultView.RowFilter = "";
				lblCount.Text = _dtDetainedLicenses.Rows.Count.ToString();
				return;
			}


			if (filterValue == "DetainID" || filterValue == "ReleaseApplicationID")
				_dtDetainedLicenses.DefaultView.RowFilter = string.Format($"[{filterValue}] = {txtFilterBy.Text.Trim()}");
			else
				_dtDetainedLicenses.DefaultView.RowFilter = string.Format($"[{filterValue}] LIKE '{txtFilterBy.Text.Trim()}%' ");
				
			
			lblCount.Text = _dtDetainedLicenses.Rows.Count.ToString();
		}

		private void txtFilterBy_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (cbFilterBy.Text == "Detain ID" || cbFilterBy.Text == "Release Application ID")
				e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
		}

		private void cbReleased_SelectedIndexChanged(object sender, EventArgs e)
		{
			string filterValue = "";
			string filterColumn = "IsRelease";

			switch (cbReleased.Text)
			{
				case "All":
					filterValue = "All";
					break;

				case "Yes":
					filterValue = "1";
					break;

				case "No":
					filterValue = "0";
					break;
			}

			if (filterValue == "All")
				_dtDetainedLicenses.DefaultView.RowFilter = "";
			else
				_dtDetainedLicenses.DefaultView.RowFilter = string.Format($" [{filterColumn}] = {filterValue}");

			lblCount.Text = _dtDetainedLicenses.Rows.Count.ToString();
		}

		private void btnDetain_Click(object sender, EventArgs e)
		{
			FrmDetainLicense frm = new FrmDetainLicense(_licenseService,_internationalService);
			frm.ShowDialog();
			LoadInfo();
		}

		private void btnRelease_Click(object sender, EventArgs e)
		{
			FrmReleaseLicense frm = new FrmReleaseLicense(_licenseService);
			frm.ShowDialog();
			LoadInfo();
		}

		private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
		{
			int licenseID = (int)dgDetainedLicenses.CurrentRow.Cells["LicenseID"].Value;

			bool isDetained = _licenseService.IsLicenseDetained(licenseID);

			releaseLicenseToolStripMenuItem.Enabled = isDetained;

		}

		private void releaseLicenseToolStripMenuItem_Click(object sender, EventArgs e)
		{
			int detainedLicenseID = (int)dgDetainedLicenses.CurrentRow.Cells["DetainID"].Value;
			FrmReleaseLicense frm = new FrmReleaseLicense(detainedLicenseID, _licenseService);
			frm.ShowDialog();
			LoadInfo();
		}

		private void showToolStripMenuItem_Click(object sender, EventArgs e)
		{
			int licenseID = (int)dgDetainedLicenses.CurrentRow.Cells["LicenseID"].Value;
			int personID = _licenseService.FindByLicenseID(licenseID).ApplicationInfo.PersonID;
			FrmShowPersonDetails frm = new FrmShowPersonDetails(personID);
			frm.ShowDialog();
		}

		private void showLicenseDetailsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			int licenseID = (int)dgDetainedLicenses.CurrentRow.Cells["LicenseID"].Value;

			FrmShowLicenseInfo frm = new FrmShowLicenseInfo(_licenseService, licenseID);
			frm.ShowDialog();

		}

		private void showLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
		{
			int licenseID = (int)dgDetainedLicenses.CurrentRow.Cells["LicenseID"].Value;
			int personID = _licenseService.FindByLicenseID(licenseID).ApplicationInfo.PersonID;
			FrmShowLicensesHistory frm = new FrmShowLicensesHistory(personID,_licenseService, _internationalService);
			frm.ShowDialog();
		}
	}
}
