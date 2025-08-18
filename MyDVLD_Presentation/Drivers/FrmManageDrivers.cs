using MyDVLD_Business.Interfaces;
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

namespace MyDVLD_Presentation.Drivers
{
	public partial class FrmManageDrivers : Form
	{
		private readonly IDriverService _driverService;
		private readonly ILicenseService _licenseService;
		private DataTable _dtDrivers;
		private readonly IInternationalLicenseService _internationalLicenseService;
		public FrmManageDrivers(ILicenseService licenseService,IInternationalLicenseService internationalService)
		{
			InitializeComponent();
			_licenseService = licenseService;
			_driverService = _licenseService.DriverService;
			_internationalLicenseService = internationalService;
		}

		private void FillComboBoxOptions()
		{
			string[] options = new string[] { "None", "Driver ID", "Person ID", "Full Name" };
			cbFilter.Items.AddRange(options);

			cbFilter.SelectedItem = "None";
		}

		private void ConfigureDriversDataGridView()
		{
			_dtDrivers = _driverService.Retrieve();

			dgDrivers.DataSource = _dtDrivers;

			int count = dgDrivers.Rows.Count;

			if(count > 0)
			{
				dgDrivers.Columns["DriverID"].HeaderText = "Driver ID";
				dgDrivers.Columns["PersonID"].HeaderText = "Person ID";
				dgDrivers.Columns["FullName"].HeaderText = "Full Name";
				dgDrivers.Columns["FullName"].Width = 200;
				dgDrivers.Columns["CreatedByUserID"].HeaderText = "Created By";
				dgDrivers.Columns["CreatedDate"].HeaderText = "Created IN";

			}

			lblRecords.Text = count.ToString();
		}

		private void LoadFormDetails()
		{
			FillComboBoxOptions();

			ConfigureDriversDataGridView();

		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void FrmManageDrivers_Load(object sender, EventArgs e)
		{
			LoadFormDetails();
		}

		private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
		{
			txtFilter.Visible = cbFilter.Text != "None";

			if (cbFilter.Text == "None")
				txtFilter.Visible = false;
			else
				txtFilter.Visible = true;

			txtFilter.Clear();
			txtFilter.Focus();
		}

		private void txtFilter_TextChanged(object sender, EventArgs e)
		{
			string filterValue = "";

			switch(cbFilter.Text)
			{
				case "Driver ID":
					filterValue = "DriverID";
					break;

				case "Person ID":
					filterValue = "PersonID";
					break;

				case "Full Name":
					filterValue = "FullName";
					break;

				default:
					filterValue = "None";
					break;
			}

			// not filter count all drivers
			if(filterValue == "None" || txtFilter.Text.Trim() == "")
			{
				_dtDrivers.DefaultView.RowFilter = "";
				lblRecords.Text = _dtDrivers.Rows.Count.ToString();
				return;
			}

			// filtering format
			if (filterValue == "FullName")
				_dtDrivers.DefaultView.RowFilter = string.Format($"[{filterValue}] LIKE '{txtFilter.Text.Trim()}%' ");
			else
				_dtDrivers.DefaultView.RowFilter = string.Format($"[{filterValue}] = {txtFilter.Text.Trim()}");

			lblRecords.Text = _dtDrivers.Rows.Count.ToString();
		}

		private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
		{
			if(cbFilter.Text == "Driver ID" || cbFilter.Text == "Person ID")
				e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
		}

		private void showPersonINFOToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FrmShowPersonDetails frm = new FrmShowPersonDetails((int)dgDrivers.CurrentRow.Cells["PersonID"].Value);
			frm.ShowDialog();
			LoadFormDetails();
		}

		private void showLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
		{
			int personID = (int)dgDrivers.CurrentRow.Cells["PersonID"].Value;
			FrmShowLicensesHistory frm = new FrmShowLicensesHistory(personID, _licenseService, _internationalLicenseService);
			frm.ShowDialog();
		}
	}
}
