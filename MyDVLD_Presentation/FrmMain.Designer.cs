namespace MyDVLD_Presentation
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.applicationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.driverLicenseServicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.localDriverLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.localDrivingLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.internationalLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.renewLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.replaceForDamagedOrLostToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tsManageAppsTypes = new System.Windows.Forms.ToolStripMenuItem();
			this.tsManageTestTypes = new System.Windows.Forms.ToolStripMenuItem();
			this.manageApplicationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.localDrivingLicenseAppToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.detainLicensesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.detainLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.releaseLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.managedDetainedLicensesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.peopleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.driversToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.accountSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tsShowCurrentUserInfo = new System.Windows.Forms.ToolStripMenuItem();
			this.tsChangePassword = new System.Windows.Forms.ToolStripMenuItem();
			this.changeUserNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolstriplabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.tsUserName = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.tsTime = new System.Windows.Forms.ToolStripStatusLabel();
			this.internationalLicensesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.AutoSize = false;
			this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
			this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.applicationsToolStripMenuItem,
            this.peopleToolStripMenuItem,
            this.driversToolStripMenuItem,
            this.usersToolStripMenuItem,
            this.accountSettingsToolStripMenuItem,
            this.logOutToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
			this.menuStrip1.Size = new System.Drawing.Size(1013, 67);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// applicationsToolStripMenuItem
			// 
			this.applicationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.driverLicenseServicesToolStripMenuItem,
            this.tsManageAppsTypes,
            this.tsManageTestTypes,
            this.manageApplicationsToolStripMenuItem,
            this.detainLicensesToolStripMenuItem});
			this.applicationsToolStripMenuItem.Image = global::MyDVLD_Presentation.Properties.Resources.Application_Types_64;
			this.applicationsToolStripMenuItem.Name = "applicationsToolStripMenuItem";
			this.applicationsToolStripMenuItem.Size = new System.Drawing.Size(144, 63);
			this.applicationsToolStripMenuItem.Text = "Applications";
			// 
			// driverLicenseServicesToolStripMenuItem
			// 
			this.driverLicenseServicesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.localDriverLicenseToolStripMenuItem,
            this.renewLicenseToolStripMenuItem,
            this.replaceForDamagedOrLostToolStripMenuItem});
			this.driverLicenseServicesToolStripMenuItem.Image = global::MyDVLD_Presentation.Properties.Resources.License_View_32;
			this.driverLicenseServicesToolStripMenuItem.Name = "driverLicenseServicesToolStripMenuItem";
			this.driverLicenseServicesToolStripMenuItem.Size = new System.Drawing.Size(256, 46);
			this.driverLicenseServicesToolStripMenuItem.Text = "Driver License Services";
			// 
			// localDriverLicenseToolStripMenuItem
			// 
			this.localDriverLicenseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.localDrivingLicenseToolStripMenuItem,
            this.internationalLicenseToolStripMenuItem});
			this.localDriverLicenseToolStripMenuItem.Image = global::MyDVLD_Presentation.Properties.Resources.New_Driving_License_32;
			this.localDriverLicenseToolStripMenuItem.Name = "localDriverLicenseToolStripMenuItem";
			this.localDriverLicenseToolStripMenuItem.Size = new System.Drawing.Size(302, 46);
			this.localDriverLicenseToolStripMenuItem.Text = "New Driving License";
			this.localDriverLicenseToolStripMenuItem.Click += new System.EventHandler(this.localDriverLicenseToolStripMenuItem_Click);
			// 
			// localDrivingLicenseToolStripMenuItem
			// 
			this.localDrivingLicenseToolStripMenuItem.Name = "localDrivingLicenseToolStripMenuItem";
			this.localDrivingLicenseToolStripMenuItem.Size = new System.Drawing.Size(242, 46);
			this.localDrivingLicenseToolStripMenuItem.Text = "Local Driving License";
			// 
			// internationalLicenseToolStripMenuItem
			// 
			this.internationalLicenseToolStripMenuItem.Image = global::MyDVLD_Presentation.Properties.Resources.International_32;
			this.internationalLicenseToolStripMenuItem.Name = "internationalLicenseToolStripMenuItem";
			this.internationalLicenseToolStripMenuItem.Size = new System.Drawing.Size(242, 46);
			this.internationalLicenseToolStripMenuItem.Text = "International License";
			this.internationalLicenseToolStripMenuItem.Click += new System.EventHandler(this.internationalLicenseToolStripMenuItem_Click);
			// 
			// renewLicenseToolStripMenuItem
			// 
			this.renewLicenseToolStripMenuItem.Image = global::MyDVLD_Presentation.Properties.Resources.Renew_Driving_License_32;
			this.renewLicenseToolStripMenuItem.Name = "renewLicenseToolStripMenuItem";
			this.renewLicenseToolStripMenuItem.Size = new System.Drawing.Size(302, 46);
			this.renewLicenseToolStripMenuItem.Text = "Renew Driving License";
			this.renewLicenseToolStripMenuItem.Click += new System.EventHandler(this.renewLicenseToolStripMenuItem_Click);
			// 
			// replaceForDamagedOrLostToolStripMenuItem
			// 
			this.replaceForDamagedOrLostToolStripMenuItem.Image = global::MyDVLD_Presentation.Properties.Resources.Damaged_Driving_License_32;
			this.replaceForDamagedOrLostToolStripMenuItem.Name = "replaceForDamagedOrLostToolStripMenuItem";
			this.replaceForDamagedOrLostToolStripMenuItem.Size = new System.Drawing.Size(302, 46);
			this.replaceForDamagedOrLostToolStripMenuItem.Text = "Replace For Damaged Or Lost";
			this.replaceForDamagedOrLostToolStripMenuItem.Click += new System.EventHandler(this.replaceForDamagedOrLostToolStripMenuItem_Click);
			// 
			// tsManageAppsTypes
			// 
			this.tsManageAppsTypes.Image = global::MyDVLD_Presentation.Properties.Resources.Manage_Applications_64;
			this.tsManageAppsTypes.Name = "tsManageAppsTypes";
			this.tsManageAppsTypes.Size = new System.Drawing.Size(256, 46);
			this.tsManageAppsTypes.Text = "Manage Apps Types";
			this.tsManageAppsTypes.Click += new System.EventHandler(this.tsManageAppsTypes_Click);
			// 
			// tsManageTestTypes
			// 
			this.tsManageTestTypes.Image = global::MyDVLD_Presentation.Properties.Resources.TestType_32;
			this.tsManageTestTypes.Name = "tsManageTestTypes";
			this.tsManageTestTypes.Size = new System.Drawing.Size(256, 46);
			this.tsManageTestTypes.Text = "Tests Types";
			this.tsManageTestTypes.Click += new System.EventHandler(this.tsManageTestTypes_Click);
			// 
			// manageApplicationsToolStripMenuItem
			// 
			this.manageApplicationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.localDrivingLicenseAppToolStripMenuItem,
            this.internationalLicensesToolStripMenuItem});
			this.manageApplicationsToolStripMenuItem.Image = global::MyDVLD_Presentation.Properties.Resources.Applications_64;
			this.manageApplicationsToolStripMenuItem.Name = "manageApplicationsToolStripMenuItem";
			this.manageApplicationsToolStripMenuItem.Size = new System.Drawing.Size(256, 46);
			this.manageApplicationsToolStripMenuItem.Text = "Manage Applications";
			// 
			// localDrivingLicenseAppToolStripMenuItem
			// 
			this.localDrivingLicenseAppToolStripMenuItem.Image = global::MyDVLD_Presentation.Properties.Resources.LocalDriving_License;
			this.localDrivingLicenseAppToolStripMenuItem.Name = "localDrivingLicenseAppToolStripMenuItem";
			this.localDrivingLicenseAppToolStripMenuItem.Size = new System.Drawing.Size(274, 46);
			this.localDrivingLicenseAppToolStripMenuItem.Text = "Local Driving License App";
			this.localDrivingLicenseAppToolStripMenuItem.Click += new System.EventHandler(this.localDrivingLicenseAppToolStripMenuItem_Click);
			// 
			// detainLicensesToolStripMenuItem
			// 
			this.detainLicensesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.detainLicenseToolStripMenuItem,
            this.releaseLicenseToolStripMenuItem,
            this.managedDetainedLicensesToolStripMenuItem});
			this.detainLicensesToolStripMenuItem.Image = global::MyDVLD_Presentation.Properties.Resources.Detain_64;
			this.detainLicensesToolStripMenuItem.Name = "detainLicensesToolStripMenuItem";
			this.detainLicensesToolStripMenuItem.Size = new System.Drawing.Size(256, 46);
			this.detainLicensesToolStripMenuItem.Text = "Detain Licenses";
			// 
			// detainLicenseToolStripMenuItem
			// 
			this.detainLicenseToolStripMenuItem.Image = global::MyDVLD_Presentation.Properties.Resources.Detain_64;
			this.detainLicenseToolStripMenuItem.Name = "detainLicenseToolStripMenuItem";
			this.detainLicenseToolStripMenuItem.Size = new System.Drawing.Size(287, 46);
			this.detainLicenseToolStripMenuItem.Text = "Detain License";
			this.detainLicenseToolStripMenuItem.Click += new System.EventHandler(this.detainLicenseToolStripMenuItem_Click);
			// 
			// releaseLicenseToolStripMenuItem
			// 
			this.releaseLicenseToolStripMenuItem.Image = global::MyDVLD_Presentation.Properties.Resources.Release_Detained_License_64;
			this.releaseLicenseToolStripMenuItem.Name = "releaseLicenseToolStripMenuItem";
			this.releaseLicenseToolStripMenuItem.Size = new System.Drawing.Size(287, 46);
			this.releaseLicenseToolStripMenuItem.Text = "Release License";
			this.releaseLicenseToolStripMenuItem.Click += new System.EventHandler(this.releaseLicenseToolStripMenuItem_Click);
			// 
			// managedDetainedLicensesToolStripMenuItem
			// 
			this.managedDetainedLicensesToolStripMenuItem.Image = global::MyDVLD_Presentation.Properties.Resources.Manage_Applications_641;
			this.managedDetainedLicensesToolStripMenuItem.Name = "managedDetainedLicensesToolStripMenuItem";
			this.managedDetainedLicensesToolStripMenuItem.Size = new System.Drawing.Size(287, 46);
			this.managedDetainedLicensesToolStripMenuItem.Text = "Managed Detained Licenses";
			this.managedDetainedLicensesToolStripMenuItem.Click += new System.EventHandler(this.managedDetainedLicensesToolStripMenuItem_Click);
			// 
			// peopleToolStripMenuItem
			// 
			this.peopleToolStripMenuItem.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
			this.peopleToolStripMenuItem.Image = global::MyDVLD_Presentation.Properties.Resources.People_64;
			this.peopleToolStripMenuItem.Name = "peopleToolStripMenuItem";
			this.peopleToolStripMenuItem.Size = new System.Drawing.Size(111, 63);
			this.peopleToolStripMenuItem.Text = "People";
			this.peopleToolStripMenuItem.Click += new System.EventHandler(this.peopleToolStripMenuItem_Click);
			// 
			// driversToolStripMenuItem
			// 
			this.driversToolStripMenuItem.Image = global::MyDVLD_Presentation.Properties.Resources.Drivers_64;
			this.driversToolStripMenuItem.Name = "driversToolStripMenuItem";
			this.driversToolStripMenuItem.Size = new System.Drawing.Size(109, 63);
			this.driversToolStripMenuItem.Text = "Drivers";
			this.driversToolStripMenuItem.Click += new System.EventHandler(this.driversToolStripMenuItem_Click);
			// 
			// usersToolStripMenuItem
			// 
			this.usersToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
			this.usersToolStripMenuItem.Image = global::MyDVLD_Presentation.Properties.Resources.icons8_admin_96;
			this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
			this.usersToolStripMenuItem.Size = new System.Drawing.Size(103, 63);
			this.usersToolStripMenuItem.Text = "Users";
			this.usersToolStripMenuItem.Click += new System.EventHandler(this.usersToolStripMenuItem_Click);
			// 
			// accountSettingsToolStripMenuItem
			// 
			this.accountSettingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsShowCurrentUserInfo,
            this.tsChangePassword,
            this.changeUserNameToolStripMenuItem});
			this.accountSettingsToolStripMenuItem.Image = global::MyDVLD_Presentation.Properties.Resources.account_settings_64;
			this.accountSettingsToolStripMenuItem.Name = "accountSettingsToolStripMenuItem";
			this.accountSettingsToolStripMenuItem.Size = new System.Drawing.Size(172, 63);
			this.accountSettingsToolStripMenuItem.Text = "Account Settings";
			// 
			// tsShowCurrentUserInfo
			// 
			this.tsShowCurrentUserInfo.Image = global::MyDVLD_Presentation.Properties.Resources.User_32__2;
			this.tsShowCurrentUserInfo.Name = "tsShowCurrentUserInfo";
			this.tsShowCurrentUserInfo.Size = new System.Drawing.Size(266, 46);
			this.tsShowCurrentUserInfo.Text = "Show Personality Details";
			this.tsShowCurrentUserInfo.Click += new System.EventHandler(this.tsShowCurrentUserInfo_Click);
			// 
			// tsChangePassword
			// 
			this.tsChangePassword.Image = global::MyDVLD_Presentation.Properties.Resources.Password_32;
			this.tsChangePassword.Name = "tsChangePassword";
			this.tsChangePassword.Size = new System.Drawing.Size(266, 46);
			this.tsChangePassword.Text = "Change Password";
			this.tsChangePassword.Click += new System.EventHandler(this.tsChangePassword_Click);
			// 
			// changeUserNameToolStripMenuItem
			// 
			this.changeUserNameToolStripMenuItem.Image = global::MyDVLD_Presentation.Properties.Resources.List_32;
			this.changeUserNameToolStripMenuItem.Name = "changeUserNameToolStripMenuItem";
			this.changeUserNameToolStripMenuItem.Size = new System.Drawing.Size(266, 46);
			this.changeUserNameToolStripMenuItem.Text = "Change User Name";
			this.changeUserNameToolStripMenuItem.Click += new System.EventHandler(this.changeUserNameToolStripMenuItem_Click);
			// 
			// logOutToolStripMenuItem
			// 
			this.logOutToolStripMenuItem.Image = global::MyDVLD_Presentation.Properties.Resources.Close_64;
			this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
			this.logOutToolStripMenuItem.Size = new System.Drawing.Size(114, 63);
			this.logOutToolStripMenuItem.Text = "Log Out";
			this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolstriplabel1,
            this.tsUserName,
            this.toolStripStatusLabel1,
            this.tsTime});
			this.statusStrip1.Location = new System.Drawing.Point(0, 544);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
			this.statusStrip1.Size = new System.Drawing.Size(1013, 22);
			this.statusStrip1.TabIndex = 8;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolstriplabel1
			// 
			this.toolstriplabel1.Image = global::MyDVLD_Presentation.Properties.Resources.User_32__2;
			this.toolstriplabel1.Name = "toolstriplabel1";
			this.toolstriplabel1.Size = new System.Drawing.Size(87, 17);
			this.toolstriplabel1.Text = "User Name :";
			// 
			// tsUserName
			// 
			this.tsUserName.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.tsUserName.Name = "tsUserName";
			this.tsUserName.Size = new System.Drawing.Size(17, 17);
			this.tsUserName.Text = "??";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(39, 17);
			this.toolStripStatusLabel1.Text = "Time :";
			// 
			// tsTime
			// 
			this.tsTime.Name = "tsTime";
			this.tsTime.Size = new System.Drawing.Size(17, 17);
			this.tsTime.Text = "??";
			// 
			// internationalLicensesToolStripMenuItem
			// 
			this.internationalLicensesToolStripMenuItem.Image = global::MyDVLD_Presentation.Properties.Resources.International_32;
			this.internationalLicensesToolStripMenuItem.Name = "internationalLicensesToolStripMenuItem";
			this.internationalLicensesToolStripMenuItem.Size = new System.Drawing.Size(274, 46);
			this.internationalLicensesToolStripMenuItem.Text = "International Licenses";
			this.internationalLicensesToolStripMenuItem.Click += new System.EventHandler(this.internationalLicensesToolStripMenuItem_Click);
			// 
			// FrmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(1013, 566);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.menuStrip1);
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.menuStrip1;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FrmMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Driving Vehicle License Department";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem peopleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolstriplabel1;
        private System.Windows.Forms.ToolStripStatusLabel tsUserName;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tsTime;
        private System.Windows.Forms.ToolStripMenuItem accountSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsShowCurrentUserInfo;
        private System.Windows.Forms.ToolStripMenuItem tsChangePassword;
        private System.Windows.Forms.ToolStripMenuItem applicationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsManageAppsTypes;
        private System.Windows.Forms.ToolStripMenuItem tsManageTestTypes;
        private System.Windows.Forms.ToolStripMenuItem manageApplicationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem localDrivingLicenseAppToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeUserNameToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem driverLicenseServicesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem localDriverLicenseToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem renewLicenseToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem replaceForDamagedOrLostToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem driversToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem detainLicensesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem detainLicenseToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem releaseLicenseToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem managedDetainedLicensesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem localDrivingLicenseToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem internationalLicenseToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem internationalLicensesToolStripMenuItem;
	}
}