namespace MyDVLD_Presentation.AllApplications
{
	partial class ctrLocalDrivingLicenseApplicationInfo
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.gbLDLApplication = new System.Windows.Forms.GroupBox();
			this.klblShowLicenseInfo = new System.Windows.Forms.LinkLabel();
			this.lblPassedTests = new System.Windows.Forms.Label();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.label4 = new System.Windows.Forms.Label();
			this.lblAppliedFor = new System.Windows.Forms.Label();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.label3 = new System.Windows.Forms.Label();
			this.lblLDLApplicationID = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
			this.ctrApplicationInfo1 = new MyDVLD_Presentation.AllApplications.LocalDrivingApp.CtrApplicationInfo();
			this.gbLDLApplication.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// gbLDLApplication
			// 
			this.gbLDLApplication.Controls.Add(this.klblShowLicenseInfo);
			this.gbLDLApplication.Controls.Add(this.lblPassedTests);
			this.gbLDLApplication.Controls.Add(this.pictureBox3);
			this.gbLDLApplication.Controls.Add(this.label4);
			this.gbLDLApplication.Controls.Add(this.lblAppliedFor);
			this.gbLDLApplication.Controls.Add(this.pictureBox2);
			this.gbLDLApplication.Controls.Add(this.label3);
			this.gbLDLApplication.Controls.Add(this.lblLDLApplicationID);
			this.gbLDLApplication.Controls.Add(this.pictureBox1);
			this.gbLDLApplication.Controls.Add(this.label1);
			this.gbLDLApplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gbLDLApplication.Location = new System.Drawing.Point(3, 3);
			this.gbLDLApplication.Name = "gbLDLApplication";
			this.gbLDLApplication.Size = new System.Drawing.Size(829, 104);
			this.gbLDLApplication.TabIndex = 2;
			this.gbLDLApplication.TabStop = false;
			this.gbLDLApplication.Text = "Driving License Application Info";
			// 
			// klblShowLicenseInfo
			// 
			this.klblShowLicenseInfo.AutoSize = true;
			this.klblShowLicenseInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.klblShowLicenseInfo.Location = new System.Drawing.Point(479, 55);
			this.klblShowLicenseInfo.Name = "klblShowLicenseInfo";
			this.klblShowLicenseInfo.Size = new System.Drawing.Size(164, 24);
			this.klblShowLicenseInfo.TabIndex = 9;
			this.klblShowLicenseInfo.TabStop = true;
			this.klblShowLicenseInfo.Text = "Show License Info";
			this.klblShowLicenseInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.klblShowLicenseInfo_LinkClicked);
			// 
			// lblPassedTests
			// 
			this.lblPassedTests.AutoSize = true;
			this.lblPassedTests.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPassedTests.Location = new System.Drawing.Point(620, 23);
			this.lblPassedTests.Name = "lblPassedTests";
			this.lblPassedTests.Size = new System.Drawing.Size(35, 17);
			this.lblPassedTests.TabIndex = 8;
			this.lblPassedTests.Text = "???";
			// 
			// pictureBox3
			// 
			this.pictureBox3.Image = global::MyDVLD_Presentation.Properties.Resources.Test_32;
			this.pictureBox3.Location = new System.Drawing.Point(586, 20);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(28, 22);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox3.TabIndex = 7;
			this.pictureBox3.TabStop = false;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(468, 21);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(121, 18);
			this.label4.TabIndex = 6;
			this.label4.Text = "Passed Tests :";
			// 
			// lblAppliedFor
			// 
			this.lblAppliedFor.AutoSize = true;
			this.lblAppliedFor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblAppliedFor.Location = new System.Drawing.Point(203, 65);
			this.lblAppliedFor.Name = "lblAppliedFor";
			this.lblAppliedFor.Size = new System.Drawing.Size(35, 17);
			this.lblAppliedFor.TabIndex = 5;
			this.lblAppliedFor.Text = "???";
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = global::MyDVLD_Presentation.Properties.Resources.LocalDriving_License;
			this.pictureBox2.Location = new System.Drawing.Point(169, 64);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(28, 22);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 4;
			this.pictureBox2.TabStop = false;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(6, 64);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(166, 18);
			this.label3.TabIndex = 3;
			this.label3.Text = "Applied For License :";
			// 
			// lblLDLApplicationID
			// 
			this.lblLDLApplicationID.AutoSize = true;
			this.lblLDLApplicationID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLDLApplicationID.Location = new System.Drawing.Point(203, 35);
			this.lblLDLApplicationID.Name = "lblLDLApplicationID";
			this.lblLDLApplicationID.Size = new System.Drawing.Size(35, 17);
			this.lblLDLApplicationID.TabIndex = 2;
			this.lblLDLApplicationID.Text = "???";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::MyDVLD_Presentation.Properties.Resources.Number_32;
			this.pictureBox1.Location = new System.Drawing.Point(169, 30);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(28, 22);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(60, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(112, 18);
			this.label1.TabIndex = 0;
			this.label1.Text = "L.D.L.App ID :";
			// 
			// ctrApplicationInfo1
			// 
			this.ctrApplicationInfo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ctrApplicationInfo1.Location = new System.Drawing.Point(3, 114);
			this.ctrApplicationInfo1.Margin = new System.Windows.Forms.Padding(4);
			this.ctrApplicationInfo1.Name = "ctrApplicationInfo1";
			this.ctrApplicationInfo1.Size = new System.Drawing.Size(829, 191);
			this.ctrApplicationInfo1.TabIndex = 3;
			// 
			// ctrLocalDrivingLicenseApplicationInfo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.ctrApplicationInfo1);
			this.Controls.Add(this.gbLDLApplication);
			this.Name = "ctrLocalDrivingLicenseApplicationInfo";
			this.Size = new System.Drawing.Size(839, 309);
			this.gbLDLApplication.ResumeLayout(false);
			this.gbLDLApplication.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox gbLDLApplication;
		private System.Windows.Forms.LinkLabel klblShowLicenseInfo;
		private System.Windows.Forms.Label lblPassedTests;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label lblAppliedFor;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lblLDLApplicationID;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private LocalDrivingApp.CtrApplicationInfo ctrApplicationInfo1;
		private System.DirectoryServices.DirectoryEntry directoryEntry1;
	}
}
