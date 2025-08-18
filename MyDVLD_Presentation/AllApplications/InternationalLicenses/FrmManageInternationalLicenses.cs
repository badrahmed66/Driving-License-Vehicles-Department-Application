using MyDVLD_Business.Interfaces;
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
	public partial class FrmManageInternationalLicenses : Form
	{
		private DataTable _dtInternationalLicenses;
		private IInternationalLicenseService _internationalLicenseService;
		private ILicenseService _licenseService;
		public FrmManageInternationalLicenses(IInternationalLicenseService internationalService,ILicenseService licenseService)
		{
			InitializeComponent();
			_internationalLicenseService = internationalService;
			_licenseService = licenseService;
		}

		private void ConfigureDataGrid()
		{
			_dtInternationalLicenses = _internationalLicenseService.Retrieve();

			dgInternationalLicenses.DataSource = _dtInternationalLicenses;

			int count = dgInternationalLicenses.Rows.Count;

			if(count > 0)
			{
				dgInternationalLicenses.Columns["InternationalLicenseID"].HeaderText = "ID";
				dgInternationalLicenses.Columns["FullName"].HeaderText = "Full Name";
				dgInternationalLicenses.Columns["IssueDate"].HeaderText = "Issue Date";
				dgInternationalLicenses.Columns["ExpirationDate"].HeaderText = "Expire Date";
				dgInternationalLicenses.Columns["DriverID"].HeaderText = "Driver ID";
				dgInternationalLicenses.Columns["IssuedUsingLocalLicenseID"].HeaderText = "L.License ID";
				dgInternationalLicenses.Columns["ApplicationID"].HeaderText = "App ID";
				dgInternationalLicenses.Columns["IsActive"].HeaderText = "Is Active";
				dgInternationalLicenses.Columns["ByUserName"].HeaderText = "By User";

			}
			lblCount.Text = count.ToString();
		}

		private void SetComboBoxOptions()
		{
			string[] options = new string[] { "All", "International License ID", "Driver ID", "Full Name" };
			cbFilter.Items.AddRange(options);

			cbFilter.SelectedIndex = 0;
		}
		public void LoadInfo()
		{
			ConfigureDataGrid();
			SetComboBoxOptions();

		}
		private void FrmManageInternationalLicenses_Load(object sender, EventArgs e)
		{
			txtFilter.Visible = false;
			LoadInfo();
		}

		private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
		{
			txtFilter.Visible = cbFilter.Text != "All";
		}

		private void txtFilter_TextChanged(object sender, EventArgs e)
		{
			string filterColumn = cbFilter.Text;
			string filter = "";

			// maping the values to the real columns names
			switch (filterColumn)
			{
				case "International License ID":
					filter = "InternationalLicenseID";
					break;

				case "Driver ID":
					filter = "DriverID";
					break;

				case "Full Name":
					filter = "FullName";
					break;

				default:
					filter = "All";
					break;
			}

			if(filter == "All" || txtFilter.Text.Trim() == "")
			{
				_dtInternationalLicenses.DefaultView.RowFilter = "";
				lblCount.Text = _dtInternationalLicenses.Rows.Count.ToString(); 
				return;
			}

			if(filter != "All")
			{
				if (filter == "FullName")
					_dtInternationalLicenses.DefaultView.RowFilter = string.Format($"[{filter}] LIKE '{txtFilter.Text.Trim()}%'");
				else
					_dtInternationalLicenses.DefaultView.RowFilter = string.Format($"[{filter}] = {txtFilter.Text.Trim()}");

				lblCount.Text = _dtInternationalLicenses.Rows.Count.ToString();
			}


		}

		private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (cbFilter.Text == "Driver ID" || cbFilter.Text == "International License ID")
				e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnNewLicense_Click(object sender, EventArgs e)
		{
			var frm = new FrmIssueInternationalLicense(_internationalLicenseService,_licenseService);
			frm.ShowDialog();
			LoadInfo();
		}
	}
}
