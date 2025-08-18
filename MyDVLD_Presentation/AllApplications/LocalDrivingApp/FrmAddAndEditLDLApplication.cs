using MyDVLD_BLL;
using MyDVLD_Business.Interfaces;
using MyDVLD_DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyDVLD_Presentation.AllApplications.LocalDrivingApp
{
	public partial class FrmAddAndEditLDLApplication : Form
	{
		private readonly LocalDrivingLicenseApplicationDTO _localApplication;

		public enum LDLApplicationMode { Add = 1, Update = 2 }
		public LDLApplicationMode Mode { get; private set; }
		private string message = "";

		private readonly IDriverService _driverService;
		private readonly ILicenseService _licenseService;

		public FrmAddAndEditLDLApplication(LocalDrivingLicenseApplicationDTO localApp, LDLApplicationMode mode , IDriverService driverService , ILicenseService licenseService)
		{
			InitializeComponent();
			_localApplication = localApp;

			Mode = mode;
			_driverService = driverService;
			_licenseService = licenseService;
		}

		private void FillLicenseClassesComboBox()
		{
			cbLicenseClass.Items.Clear();
			var licenseList = LicenseClassService.RetrieveAllLicenseClasses();
			cbLicenseClass.DisplayMember = "LicenseTitle";
			cbLicenseClass.ValueMember = "LicenseID";

			cbLicenseClass.DataSource = licenseList;

			cbLicenseClass.SelectedIndex = LicenseClassService.FindByLicenseIDOrTitle(licenseTitle: "Class 3 - Ordinary driving license").LicenseID;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (ctrShowPersonDetailsWithFilter1.PersonInfo == null && tabControl1.SelectedTab == tpPersonInfo)
			{
				MessageBox.Show("You must Enter a valid Person", "Invalid Persn", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			else
			{
				tpApplicationInfo.Enabled = true;
				tabControl1.SelectedTab = tpApplicationInfo;
				btnSave.Enabled = true;
			}

		}

		private void FrmAddAndEditLDLApplication_Load(object sender, EventArgs e)
		{
			FillLicenseClassesComboBox();

			if (Mode == LDLApplicationMode.Add)
				ConfigureFormForAddNewApplication();
			else
				LoadApplicationDetails();
		}

		private void LoadApplicationDetails()
		{
			this.Text = "Edit Local Driving License Application";
			lblMain.Text = "Edit Local Driving License Application";
			ctrShowPersonDetailsWithFilter1.LoadPersonInfo(_localApplication.ApplicationInfo.PersonID);
			lblLocalDrivingLicenseAppID.Text = _localApplication.LocalDrivingLicenseAppID.ToString();
			lblApplicationDate.Text = _localApplication.ApplicationInfo.ApplicationDate.ToShortDateString();
			cbLicenseClass.SelectedIndex = cbLicenseClass.FindString(LicenseClassService.FindByLicenseIDOrTitle(_localApplication.LicenseClassID).LicenseTitle);
			lblFees.Text = _localApplication.ApplicationInfo.ApplicationPaidFees.ToString();
			lblCreatedByUser.Text = UserService.FindUserDetails(userID : _localApplication.ApplicationInfo.CreatedByUserID).UserName;
			ctrShowPersonDetailsWithFilter1.Enabled = false;
		}

		private void ConfigureFormForAddNewApplication()
		{
			this.Text = "Add New Local Driving License Application";
			lblMain.Text = "Add New Local Driving License Application";
			ctrShowPersonDetailsWithFilter1.GroupFilter = true;
			ctrShowPersonDetailsWithFilter1.Focus();
			ctrShowPersonDetailsWithFilter1.AddNewPersonButton = true;
			tpApplicationInfo.Enabled = false;

			lblApplicationDate.Text = DateTime.Now.ToShortDateString();
			lblFees.Text = ApplicationTypeService.FindApplicationTypeByID(Convert.ToInt32(ApplicationTypeDTO.EnType.newLocalDrivingLicenseService)).Fees.ToString();
			lblCreatedByUser.Text = UserAuthenticationService.CurrentUserInfo.UserName;
			btnSave.Enabled = false;
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void CollectDataForAdd()
		{
			_localApplication.ApplicationInfo = new ApplicationDTO();
			_localApplication.ApplicationInfo.PersonID = ctrShowPersonDetailsWithFilter1.PersonID;
			_localApplication.ApplicationInfo.CreatedByUserID = UserAuthenticationService.CurrentUserInfo.UserID;
			_localApplication.ApplicationInfo.ApplicationTypeID = Convert.ToInt32(ApplicationTypeDTO.EnType.newLocalDrivingLicenseService);
			_localApplication.ApplicationInfo.ApplicationDate = DateTime.Now;
			_localApplication.ApplicationInfo.ApplicationLastStatusUpdateDate = DateTime.Now;
			_localApplication.ApplicationInfo.ApplicationPaidFees = ApplicationTypeService.FindApplicationTypeByID(Convert.ToInt32(ApplicationTypeDTO.EnType.newLocalDrivingLicenseService)).Fees;

			_localApplication.ApplicationInfo.ApplicationStatus = ApplicationDTO.Status.New;
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			bool isNew = (Mode == LDLApplicationMode.Add);

			if (ctrShowPersonDetailsWithFilter1.PersonInfo == null)
			{
				MessageBox.Show("You Didn't Enter any person information", "invalidPerson", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (isNew)
			{ CollectDataForAdd(); }


			var appService = new ApplicationService(_localApplication.ApplicationInfo);

			_localApplication.LicenseClassID = (int)cbLicenseClass.SelectedValue;

			 var localService = new LocalDrivingLicenseApplicationManager(_localApplication,_driverService,_licenseService);

			if (isNew)
			{
				if (appService.AddApplication(out message))
				{
					// assign inner ApplicationDTO composition 
					_localApplication.ApplicationID = _localApplication.ApplicationInfo.ApplicationID;
					_localApplication.ApplicationInfo = ApplicationService.FindApplicationByID(_localApplication.ApplicationID);

					// assign inner LicenseClass Composition
					_localApplication.LicenseClassesInfo = LicenseClassService.FindByLicenseIDOrTitle(_localApplication.LicenseClassID);


					if (localService.InsertLDLApplication(out message))
					{
						MessageBox.Show(message, "Insert  Local Driving License ApplicationConfirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
						Mode = LDLApplicationMode.Update;
						return;
					}
					else
					{
						MessageBox.Show(message, "Insert  Local Driving License ApplicationConfirm", MessageBoxButtons.OK, MessageBoxIcon.Error);
						return;
					}
				}
				else
				{
					MessageBox.Show(message, "Insert ApplicationConfirm", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
			}
			else // update mode
			{
				if (appService.UpdateApplication(out message))
				{
					if (localService.UpdateLDLApplication(out message))
					{
						MessageBox.Show(message, "Update Local Driving License Application Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
						return;
					}
					else
					{
						MessageBox.Show(message, "Update Local Driving License Application Confirm", MessageBoxButtons.OK, MessageBoxIcon.Error);
						return;
					}
				}
				else
				{
					MessageBox.Show(message, "Insert Application Confirm", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
			}

		}
	}
} 
