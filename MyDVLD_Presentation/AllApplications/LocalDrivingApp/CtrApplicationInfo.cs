using MyDVLD_BLL;
using MyDVLD_DTO;
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

namespace MyDVLD_Presentation.AllApplications.LocalDrivingApp
{
	public partial class CtrApplicationInfo : UserControl 
	{
		private ApplicationDTO _application;
		private int _applicatinID;
		public int ApplicationID
		{
			get { return _applicatinID; }
		}
		public CtrApplicationInfo()
		{
			InitializeComponent();
		}

		public void Reset()
		{
			lblApplicationID.Text = "[???]";
			lblStatus.Text = "[???]";
			lblFees.Text = "[???]";
			lblType.Text = "[???]";
			lblApplicationID.Text = "[???]";
			lblDate.Text = "[???]";
			lblStatusDate.Text = "[???]";
			lblCreatedBy.Text = "[???]";
		}

		public void LoadApplicationInfo(int applicationID)
		{
			_application = ApplicationService.FindApplicationByID(applicationID);
			if (_application == null)
			{
				Reset();
				klblVewPersonInfo.Enabled = false;
				MessageBox.Show("Invalid Application ID", "Applicatin Confirm", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			else
				FillApplicationData();
		}

		private void FillApplicationData()
		{
			_applicatinID = _application.ApplicationID;
			lblApplicationID.Text = _applicatinID.ToString();
			lblStatus.Text = _application.ApplicationStatus.ToString();
			lblFees.Text = _application.ApplicationPaidFees.ToString();
			lblType.Text = _application.ApplicationTypeInfoDTO.Title;
			lblApplicant.Text = _application.PersonInfoDTO.FullName;
			lblDate.Text = _application.ApplicationDate.ToShortDateString();
			lblStatusDate.Text = _application.ApplicationLastStatusUpdateDate.ToShortDateString();
			lblCreatedBy.Text = _application.UserInfoDTO.UserName;
		}

		//private void klblVewPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		//{
		//	FrmShowPersonDetails frm = new FrmShowPersonDetails(_application.PersonID);
		//	frm.ShowDialog();
		//	LoadApplicationInfo(_application.ApplicationID);
		//}

		private void klblVewPersonInfo_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
		{
			FrmShowPersonDetails frm = new FrmShowPersonDetails(_application.PersonID);
			frm.ShowDialog();
			LoadApplicationInfo(_application.ApplicationID);
		}
	}
}
