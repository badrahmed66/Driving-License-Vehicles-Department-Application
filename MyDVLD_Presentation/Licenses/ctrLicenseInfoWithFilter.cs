using MyDVLD_Business.Interfaces;
using MyDVLD_DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyDVLD_Presentation.Licenses
{

	public partial class ctrLicenseInfoWithFilter : UserControl
	{
		// declare a custom event 
		public event Action<int> OnLicenseSelected;

		// create handler method 
		protected virtual void LicenseSelected(int licenseID) 
		{
			Action<int> handler = OnLicenseSelected;

			handler?.Invoke(licenseID);
		}

		// declare Interface Service to License 
		private ILicenseService _licenseService;

		// method to set the ILicense Service interface from outside
		public void Initialize(ILicenseService licenseService)
		{
			_licenseService = licenseService ?? throw new ArgumentNullException(nameof(licenseService));
		}

		public ctrLicenseInfoWithFilter()
		{
			InitializeComponent();
		}



		// declare global member help outer classes to access on group filter 
		private bool _gbFilterEnable = true;
		public bool FilterEnable
		{
			get { return _gbFilterEnable; }
			set 
			{
				_gbFilterEnable = value;
				gbFilter.Enabled = _gbFilterEnable; 
			}
		}

		private int _licenseID;

		public int LicenseID { get { return ctrDriverLicenseInfo1.LicenseID; } }

		public LicenseDTO SelectedLicenseInfo { get { return ctrDriverLicenseInfo1.LicenseInfo; } }

		//public bool IsDetained
		//{
		//	get { return _licenseService.IsLicenseDetained(LicenseID); }
		//}
		public void LoadLicenseInfo(int licenseID)
		{
			_licenseID = licenseID;

			txtFilter.Text = _licenseID.ToString();

			// initialize the interface of license service before use the control
			ctrDriverLicenseInfo1.Initialize(_licenseService);

			// then load the drivier license info in the inner control
			ctrDriverLicenseInfo1.LoadLicenseInfo(_licenseID);

			// Raise the event handler method
			if(FilterEnable)
				LicenseSelected(licenseID);
		}

		// to access on the text box from outer
		public void FocusFilter()
		{
			txtFilter.Focus();
		}

		private void txtFilter_Validating(object sender, CancelEventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txtFilter.Text.Trim()))
			{
				e.Cancel = true;
				errorProvider1.SetError(txtFilter, "Mandatory Field");
			}
			else
				errorProvider1.SetError(txtFilter, null);
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			if (!this.ValidateChildren())
			{
				MessageBox.Show("Some Field Are Not Valid","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			_licenseID = int.Parse(txtFilter.Text.Trim());
			LoadLicenseInfo(_licenseID);
		}

		private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
		{
			// inforce the user to only input numbers (Driver ID)
			e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

			// when the user press Enter After input the driver ID the behavious will be like when press on the butto		n
			if (e.KeyChar == (char)13)
				btnSearch.PerformClick(); 
		}
	}
}
