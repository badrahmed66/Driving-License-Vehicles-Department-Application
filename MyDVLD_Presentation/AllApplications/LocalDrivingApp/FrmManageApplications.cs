using MyDVLD_BLL;
using MyDVLD_Business.Interfaces;
using MyDVLD_DTO;
using MyDVLD_Presentation.AllApplications.Tests;
using MyDVLD_Presentation.Licenses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MyDVLD_Presentation.AllApplications.LocalDrivingApp
{
    public partial class FrmManageApplications : Form
    {
        private List<LocalDrivingLicenseApplicationViewDTO> _localApps;
        private readonly ServicesContainer _container;
        public FrmManageApplications(ServicesContainer container)
        {
            InitializeComponent();
            _container = container;
        }

        // Inner Actions

        // getting the applications data to show it in the data grid view
        private void LoadLDLAppsData()
        {
            string filterColumn = cbFilterBy.SelectedItem.ToString();
            string filterValue = txtFilterValue.Text.Trim();

            _localApps = LocalDrivingLicenseApplicationManager.RetrieveLDLApplicatoinsWithFiltering(filterColumn,filterValue);

            bindingSource1.DataSource = _localApps;
            dgvApplications.DataSource = bindingSource1;
            lblCount.Text = dgvApplications.Rows.Count.ToString();
        }

        // the options of filtering will be in the combo box
        private void FillComboBoxByOptions()
        {
            cbFilterBy.Items.Clear();
            cbFilterBy.Items.AddRange(new object[] { "All", "LDL App ID", "National No", "Full Name",
                "App Status" });
            cbFilterBy.SelectedIndex = 0;
        }

        private void ConfigureDataGridView()
        {
            if (dgvApplications.Columns.Contains("LocalDrivingLicenseAppID"))
            {
                dgvApplications.Columns["LocalDrivingLicenseAppID"].HeaderText = "ID";
                dgvApplications.Columns["LocalDrivingLicenseAppID"].Width = 50;
            }

            if (dgvApplications.Columns.Contains("LicenseClassTitle"))
                dgvApplications.Columns["LicenseClassTitle"].HeaderText = "License";

            if (dgvApplications.Columns.Contains("PersonNationalNoID"))
                dgvApplications.Columns["PersonNationalNoID"].HeaderText = "National No";

            if (dgvApplications.Columns.Contains("PersonFullName"))
                dgvApplications.Columns["PersonFullName"].HeaderText = "Name";

            if (dgvApplications.Columns.Contains("ApplicationDate"))
                dgvApplications.Columns["ApplicationDate"].HeaderText = "Date";

            if (dgvApplications.Columns.Contains("PassedTestCount"))
                dgvApplications.Columns["PassedTestCount"].HeaderText = "Passed Test";

            if (dgvApplications.Columns.Contains("ApplicationStatus"))
            {
                dgvApplications.Columns["ApplicationStatus"].HeaderText = "Status";
                dgvApplications.Columns["ApplicationStatus"].Width = 70;
            }
        }

        private void FrmManageApplications_Load(object sender, EventArgs e)
        {
            FillComboBoxByOptions();
            LoadLDLAppsData();
            ConfigureDataGridView();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbFilterBy.SelectedItem.ToString() != "All")
            {
                txtFilterValue.Visible = true;
                txtFilterValue.Clear();
                txtFilterValue.Focus();
            }
            else
            {
                txtFilterValue.Visible = false;
                txtFilterValue.Clear();
            }
            LoadLDLAppsData();
        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            LoadLDLAppsData();
        }


        //----------------------------

        // Outer Actions
        private void btnAddNewApp_Click(object sender, EventArgs e)
        {
            int localID = (int)dgvApplications.CurrentRow.Cells[0].Value;

            var localApplicatoin = new LocalDrivingLicenseApplicationDTO();
            var frm = new FrmAddAndEditLDLApplication(localApplicatoin,FrmAddAndEditLDLApplication.LDLApplicationMode.Add,_container.CreateDriverService(),_container.CreateLicneseService());

            frm.ShowDialog();
            LoadLDLAppsData();
        }

		private void editApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int localID = (int)dgvApplications.CurrentRow.Cells [0].Value;

            var localDTO = LocalDrivingLicenseApplicationManager.FindLDLApplicationByLDLAppIDorApplicationID(out string message, localDrivingID: localID);


            FrmAddAndEditLDLApplication frm = new FrmAddAndEditLDLApplication(localDTO, FrmAddAndEditLDLApplication.LDLApplicationMode.Update, _container.CreateDriverService(), _container.CreateLicneseService());

            frm.ShowDialog();
            LoadLDLAppsData();
		}

		private void showApplicationInfoToolStripMenuItem_Click(object sender, EventArgs e)
		{
            frmShowLDLApplicationInfo frm = new frmShowLDLApplicationInfo((int)dgvApplications.CurrentRow.Cells[0].Value,_container.CreateTestService());
            frm.ShowDialog();
            LoadLDLAppsData();
		}

        // General Method
        private void ScheduleTest(TestTypeDTO.EnTestType testType)
        {
            int localID = (int)dgvApplications.CurrentRow.Cells[0].Value;
            FrmListTestAppointments frm = new FrmListTestAppointments(localID, testType,_container.CreateTestService(),_container.CreateDriverService(),_container.CreateLicneseService());
            frm.ShowDialog();
            LoadLDLAppsData();
        }

		private void tsmScheduleVisionTest_Click(object sender, EventArgs e)
		{
            ScheduleTest(TestTypeDTO.EnTestType.Vision);
		}

		private void tsmScheduleTheoryTest_Click(object sender, EventArgs e)
		{
            ScheduleTest(TestTypeDTO.EnTestType.Theory);
		}

		private void tsmSchedulPracticalTest_Click(object sender, EventArgs e)
		{
            ScheduleTest(TestTypeDTO.EnTestType.Practical);
		}


		private void issueDrivingLicenseFirstTimeToolStripMenuItem_Click(object sender, EventArgs e)
		{
            int localID = (int)dgvApplications.CurrentRow.Cells[0].Value;

			FrmIssueForFirstTime frm = new FrmIssueForFirstTime(localID,_container.CreateTestService(),_container.CreateLicneseService(),_container.CreateDriverService());
            frm.ShowDialog();
            LoadLDLAppsData();

		}

		private void showLicenseToolStripMenuItem_Click(object sender, EventArgs e)
		{
            int localID = (int)dgvApplications.CurrentRow.Cells[0].Value;

            var localDTO = LocalDrivingLicenseApplicationManager.FindLDLApplicationByLDLAppIDorApplicationID(out string message , localID);

            var licenseService = _container.CreateLicneseService();

            int licenseID = licenseService.GetActiveLicenseForPerson(localDTO.ApplicationInfo.PersonID, localDTO.LicenseClassID);

            if(licenseID > 0)
            {
                FrmShowLicenseInfo frm = new FrmShowLicenseInfo(_container.CreateLicneseService (), licenseID);
                frm.ShowDialog();

            }
            else
                MessageBox.Show("No License Founded","Invalid License",MessageBoxButtons.OK,MessageBoxIcon.Error);
		}

		private void showPersonLIcenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
		{
            int localID = (int)dgvApplications.CurrentRow.Cells[0].Value;

            var dto = LocalDrivingLicenseApplicationManager.FindLDLApplicationByLDLAppIDorApplicationID(out string message , localID);

            int personID = dto.ApplicationInfo.PersonID;

            FrmShowLicensesHistory frm = new FrmShowLicensesHistory(personID,_container.CreateLicneseService(),_container.CreateInternationalLicenseService());
            frm.ShowDialog();

        }

		private void deleteApplicationToolStripMenuItem_Click(object sender, EventArgs e)
		{
            // there's an error in the process
            int localDrivingID = (int)dgvApplications.CurrentRow.Cells[0].Value;

            var local = LocalDrivingLicenseApplicationManager.FindLDLApplicationByLDLAppIDorApplicationID(out string message, localDrivingID);

            if(MessageBox.Show("Are You Sure To Delete This Application","Delete Confirm", MessageBoxButtons.OK, MessageBoxIcon.Exclamation) == DialogResult.OK)
            {

                if (LocalDrivingLicenseApplicationManager.Delete(localDrivingID , local.ApplicationID))
                {
                   MessageBox.Show("Application Deleted Successfuly","Delete",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    LoadLDLAppsData();
                }
                else
                    MessageBox.Show("Failure Deleting Process","Delete Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
		}

		private void cancelApplicationToolStripMenuItem_Click(object sender, EventArgs e)
		{
            if((MessageBox.Show("Are You Sure To Cancel The Application ","Cancel Application",MessageBoxButtons.OKCancel) == DialogResult.OK) ) 
            {
                int localDrivingID = (int)dgvApplications.CurrentRow.Cells[0].Value;
                // get the local driving license dto
                var localDTO = LocalDrivingLicenseApplicationManager.FindLDLApplicationByLDLAppIDorApplicationID(out    string message, localDrivingID);

                if (localDTO == null) return;

                // get the application dto
                ApplicationDTO appDTO= localDTO.ApplicationInfo;

                if (appDTO == null) return;

                var appService = new ApplicationService(appDTO);

                if (appService.Cancel())
                {
                    MessageBox.Show("Application Canceled Successfuly", "Cancel Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadLDLAppsData();
                }
                else
                    MessageBox.Show("Failure Process", "Cancel Confirm", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            int localID = (int)dgvApplications.CurrentRow.Cells[0].Value;

            var localDTO = LocalDrivingLicenseApplicationManager.FindLDLApplicationByLDLAppIDorApplicationID(out string message, localID);

            var localService = new LocalDrivingLicenseApplicationManager(localDTO,_container.CreateDriverService(),_container.CreateLicneseService());

            // Edit menu item enabled condition
            editApplicationToolStripMenuItem.Enabled = (localDTO.ApplicationInfo.ApplicationStatus == ApplicationDTO.Status.New); // the result always canecl // error

            // Cancel Menu Item Enabled / Disable condition
            cancelApplicationToolStripMenuItem.Enabled = (localDTO.ApplicationInfo.ApplicationStatus == ApplicationDTO.Status.New);

            // delete menu itme enable condition
            deleteApplicationToolStripMenuItem.Enabled = (localDTO.ApplicationInfo.ApplicationStatus == ApplicationDTO.Status.New);

            // control Schedule appointments menu items
            bool passVistionTest = localService.HasPassedTest(TestTypeDTO.EnTestType.Vision);
            bool passTheoryTest = localService.HasPassedTest(TestTypeDTO.EnTestType.Theory);
            bool passPracticalTest = localService.HasPassedTest(TestTypeDTO.EnTestType.Practical);

            // must the app status be new and there's at least one test didn't pass it
            scheduleTestsToolStripMenuItem.Enabled = 
                (!passVistionTest || !passTheoryTest || !passPracticalTest) && (localDTO.ApplicationInfo.ApplicationStatus == ApplicationDTO.Status.New);

            if (scheduleTestsToolStripMenuItem.Enabled)
            {
                // control the vistion tool menu strip
                tsmScheduleVisionTest.Enabled = !passVistionTest;

                // control the theory tool menu strip
                tsmScheduleTheoryTest.Enabled = (passVistionTest && !passTheoryTest);

                // control the practical tool menu strip
                tsmSchedulPracticalTest.Enabled = (passVistionTest && passTheoryTest && !passPracticalTest);
            }

            //make sure the application has passed all tests before issue the license
            ILicenseService licenseService = _container.CreateLicneseService();
            bool isPersonHasLicense = licenseService.IsPersonHasLicense(localDTO.ApplicationInfo.PersonID, localDTO.LicenseClassID);

			int passedTests = (byte)dgvApplications.CurrentRow.Cells["PassedTestCount"].Value;

			issueDrivingLicenseFirstTimeToolStripMenuItem.Enabled =  passedTests == 3 && ! isPersonHasLicense;
            // control the issue History tool menu strip
            showPersonLIcenseHistoryToolStripMenuItem.Enabled = passedTests == 3 && isPersonHasLicense;
			//control the license information tool menu strip
			showLicenseToolStripMenuItem.Enabled = passedTests == 3 && isPersonHasLicense;



		}
	}
}


