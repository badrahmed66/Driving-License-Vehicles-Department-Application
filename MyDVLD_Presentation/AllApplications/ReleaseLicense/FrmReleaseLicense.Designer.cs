namespace MyDVLD_Presentation.AllApplications.ReleaseLicense
{
	partial class FrmReleaseLicense
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
			this.label1 = new System.Windows.Forms.Label();
			this.ctrLicenseInfoWithFilter1 = new MyDVLD_Presentation.Licenses.ctrLicenseInfoWithFilter();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.lblTotalFees = new System.Windows.Forms.Label();
			this.lblApplicationID = new System.Windows.Forms.Label();
			this.pictureBox7 = new System.Windows.Forms.PictureBox();
			this.label10 = new System.Windows.Forms.Label();
			this.pictureBox8 = new System.Windows.Forms.PictureBox();
			this.label11 = new System.Windows.Forms.Label();
			this.lblApplicaitonFees = new System.Windows.Forms.Label();
			this.lblFineFees = new System.Windows.Forms.Label();
			this.pictureBox6 = new System.Windows.Forms.PictureBox();
			this.label3 = new System.Windows.Forms.Label();
			this.lblCreatedByUserID = new System.Windows.Forms.Label();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.label6 = new System.Windows.Forms.Label();
			this.lblLicenseID = new System.Windows.Forms.Label();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			this.label8 = new System.Windows.Forms.Label();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.label5 = new System.Windows.Forms.Label();
			this.lblDetainDate = new System.Windows.Forms.Label();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.label4 = new System.Windows.Forms.Label();
			this.lblDetainID = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label2 = new System.Windows.Forms.Label();
			this.llShowLicenseInfo = new System.Windows.Forms.LinkLabel();
			this.llShowLicenseHistory = new System.Windows.Forms.LinkLabel();
			this.btnClose = new System.Windows.Forms.Button();
			this.btnRelease = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Red;
			this.label1.Location = new System.Drawing.Point(299, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(230, 31);
			this.label1.TabIndex = 0;
			this.label1.Text = "Release License";
			// 
			// ctrLicenseInfoWithFilter1
			// 
			this.ctrLicenseInfoWithFilter1.FilterEnable = true;
			this.ctrLicenseInfoWithFilter1.Location = new System.Drawing.Point(12, 53);
			this.ctrLicenseInfoWithFilter1.Name = "ctrLicenseInfoWithFilter1";
			this.ctrLicenseInfoWithFilter1.Size = new System.Drawing.Size(816, 368);
			this.ctrLicenseInfoWithFilter1.TabIndex = 1;
			this.ctrLicenseInfoWithFilter1.OnLicenseSelected += new System.Action<int>(this.ctrLicenseInfoWithFilter1_OnLicenseSelected);
			this.ctrLicenseInfoWithFilter1.Load += new System.EventHandler(this.ctrLicenseInfoWithFilter1_Load);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.lblTotalFees);
			this.groupBox1.Controls.Add(this.lblApplicationID);
			this.groupBox1.Controls.Add(this.pictureBox7);
			this.groupBox1.Controls.Add(this.label10);
			this.groupBox1.Controls.Add(this.pictureBox8);
			this.groupBox1.Controls.Add(this.label11);
			this.groupBox1.Controls.Add(this.lblApplicaitonFees);
			this.groupBox1.Controls.Add(this.lblFineFees);
			this.groupBox1.Controls.Add(this.pictureBox6);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.lblCreatedByUserID);
			this.groupBox1.Controls.Add(this.pictureBox4);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.lblLicenseID);
			this.groupBox1.Controls.Add(this.pictureBox5);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.pictureBox3);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.lblDetainDate);
			this.groupBox1.Controls.Add(this.pictureBox2);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.lblDetainID);
			this.groupBox1.Controls.Add(this.pictureBox1);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.groupBox1.Location = new System.Drawing.Point(12, 427);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(806, 172);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Detain Info";
			// 
			// lblTotalFees
			// 
			this.lblTotalFees.AutoSize = true;
			this.lblTotalFees.Location = new System.Drawing.Point(177, 132);
			this.lblTotalFees.Name = "lblTotalFees";
			this.lblTotalFees.Size = new System.Drawing.Size(35, 17);
			this.lblTotalFees.TabIndex = 25;
			this.lblTotalFees.Text = "???";
			// 
			// lblApplicationID
			// 
			this.lblApplicationID.AutoSize = true;
			this.lblApplicationID.Location = new System.Drawing.Point(610, 135);
			this.lblApplicationID.Name = "lblApplicationID";
			this.lblApplicationID.Size = new System.Drawing.Size(35, 17);
			this.lblApplicationID.TabIndex = 24;
			this.lblApplicationID.Text = "???";
			// 
			// pictureBox7
			// 
			this.pictureBox7.Image = global::MyDVLD_Presentation.Properties.Resources.Number_32;
			this.pictureBox7.Location = new System.Drawing.Point(577, 135);
			this.pictureBox7.Name = "pictureBox7";
			this.pictureBox7.Size = new System.Drawing.Size(23, 17);
			this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox7.TabIndex = 23;
			this.pictureBox7.TabStop = false;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(450, 135);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(118, 17);
			this.label10.TabIndex = 22;
			this.label10.Text = "Application ID :";
			// 
			// pictureBox8
			// 
			this.pictureBox8.Image = global::MyDVLD_Presentation.Properties.Resources.money_32;
			this.pictureBox8.Location = new System.Drawing.Point(148, 132);
			this.pictureBox8.Name = "pictureBox8";
			this.pictureBox8.Size = new System.Drawing.Size(23, 17);
			this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox8.TabIndex = 21;
			this.pictureBox8.TabStop = false;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(44, 132);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(95, 17);
			this.label11.TabIndex = 20;
			this.label11.Text = "Total Fees :";
			// 
			// lblApplicaitonFees
			// 
			this.lblApplicaitonFees.AutoSize = true;
			this.lblApplicaitonFees.Location = new System.Drawing.Point(177, 97);
			this.lblApplicaitonFees.Name = "lblApplicaitonFees";
			this.lblApplicaitonFees.Size = new System.Drawing.Size(35, 17);
			this.lblApplicaitonFees.TabIndex = 19;
			this.lblApplicaitonFees.Text = "???";
			// 
			// lblFineFees
			// 
			this.lblFineFees.AutoSize = true;
			this.lblFineFees.Location = new System.Drawing.Point(610, 100);
			this.lblFineFees.Name = "lblFineFees";
			this.lblFineFees.Size = new System.Drawing.Size(35, 17);
			this.lblFineFees.TabIndex = 18;
			this.lblFineFees.Text = "???";
			// 
			// pictureBox6
			// 
			this.pictureBox6.Image = global::MyDVLD_Presentation.Properties.Resources.money_32;
			this.pictureBox6.Location = new System.Drawing.Point(577, 100);
			this.pictureBox6.Name = "pictureBox6";
			this.pictureBox6.Size = new System.Drawing.Size(23, 17);
			this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox6.TabIndex = 17;
			this.pictureBox6.TabStop = false;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(479, 103);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(89, 17);
			this.label3.TabIndex = 16;
			this.label3.Text = "Fine Fees :";
			// 
			// lblCreatedByUserID
			// 
			this.lblCreatedByUserID.AutoSize = true;
			this.lblCreatedByUserID.Location = new System.Drawing.Point(610, 63);
			this.lblCreatedByUserID.Name = "lblCreatedByUserID";
			this.lblCreatedByUserID.Size = new System.Drawing.Size(35, 17);
			this.lblCreatedByUserID.TabIndex = 14;
			this.lblCreatedByUserID.Text = "???";
			// 
			// pictureBox4
			// 
			this.pictureBox4.Image = global::MyDVLD_Presentation.Properties.Resources.User_32__2;
			this.pictureBox4.Location = new System.Drawing.Point(581, 63);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(23, 17);
			this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox4.TabIndex = 13;
			this.pictureBox4.TabStop = false;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(416, 63);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(157, 17);
			this.label6.TabIndex = 12;
			this.label6.Text = "Created By User ID :";
			// 
			// lblLicenseID
			// 
			this.lblLicenseID.AutoSize = true;
			this.lblLicenseID.Location = new System.Drawing.Point(610, 29);
			this.lblLicenseID.Name = "lblLicenseID";
			this.lblLicenseID.Size = new System.Drawing.Size(35, 17);
			this.lblLicenseID.TabIndex = 11;
			this.lblLicenseID.Text = "???";
			// 
			// pictureBox5
			// 
			this.pictureBox5.Image = global::MyDVLD_Presentation.Properties.Resources.Number_32;
			this.pictureBox5.Location = new System.Drawing.Point(581, 29);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new System.Drawing.Size(23, 17);
			this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox5.TabIndex = 10;
			this.pictureBox5.TabStop = false;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(479, 29);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(94, 17);
			this.label8.TabIndex = 9;
			this.label8.Text = "License ID :";
			// 
			// pictureBox3
			// 
			this.pictureBox3.Image = global::MyDVLD_Presentation.Properties.Resources.money_32;
			this.pictureBox3.Location = new System.Drawing.Point(148, 97);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(23, 17);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox3.TabIndex = 7;
			this.pictureBox3.TabStop = false;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(6, 97);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(138, 17);
			this.label5.TabIndex = 6;
			this.label5.Text = "Application Fees :";
			// 
			// lblDetainDate
			// 
			this.lblDetainDate.AutoSize = true;
			this.lblDetainDate.Location = new System.Drawing.Point(174, 63);
			this.lblDetainDate.Name = "lblDetainDate";
			this.lblDetainDate.Size = new System.Drawing.Size(35, 17);
			this.lblDetainDate.TabIndex = 5;
			this.lblDetainDate.Text = "???";
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = global::MyDVLD_Presentation.Properties.Resources.Calendar_32;
			this.pictureBox2.Location = new System.Drawing.Point(145, 63);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(23, 17);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox2.TabIndex = 4;
			this.pictureBox2.TabStop = false;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(35, 63);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(104, 17);
			this.label4.TabIndex = 3;
			this.label4.Text = "Detain Date :";
			// 
			// lblDetainID
			// 
			this.lblDetainID.AutoSize = true;
			this.lblDetainID.Location = new System.Drawing.Point(174, 29);
			this.lblDetainID.Name = "lblDetainID";
			this.lblDetainID.Size = new System.Drawing.Size(35, 17);
			this.lblDetainID.TabIndex = 2;
			this.lblDetainID.Text = "???";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::MyDVLD_Presentation.Properties.Resources.Number_32;
			this.pictureBox1.Location = new System.Drawing.Point(145, 29);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(23, 17);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(54, 29);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(85, 17);
			this.label2.TabIndex = 0;
			this.label2.Text = "Detain ID :";
			// 
			// llShowLicenseInfo
			// 
			this.llShowLicenseInfo.AutoSize = true;
			this.llShowLicenseInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.llShowLicenseInfo.Location = new System.Drawing.Point(182, 618);
			this.llShowLicenseInfo.Name = "llShowLicenseInfo";
			this.llShowLicenseInfo.Size = new System.Drawing.Size(122, 17);
			this.llShowLicenseInfo.TabIndex = 10;
			this.llShowLicenseInfo.TabStop = true;
			this.llShowLicenseInfo.Text = "Show License Info";
			// 
			// llShowLicenseHistory
			// 
			this.llShowLicenseHistory.AutoSize = true;
			this.llShowLicenseHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.llShowLicenseHistory.Location = new System.Drawing.Point(17, 618);
			this.llShowLicenseHistory.Name = "llShowLicenseHistory";
			this.llShowLicenseHistory.Size = new System.Drawing.Size(143, 17);
			this.llShowLicenseHistory.TabIndex = 9;
			this.llShowLicenseHistory.TabStop = true;
			this.llShowLicenseHistory.Text = "Show License History";
			// 
			// btnClose
			// 
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnClose.Image = global::MyDVLD_Presentation.Properties.Resources.Close_32;
			this.btnClose.Location = new System.Drawing.Point(561, 605);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(113, 56);
			this.btnClose.TabIndex = 8;
			this.btnClose.Text = "Close";
			this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// btnRelease
			// 
			this.btnRelease.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnRelease.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRelease.Image = global::MyDVLD_Presentation.Properties.Resources.Release_Detained_License_641;
			this.btnRelease.Location = new System.Drawing.Point(680, 605);
			this.btnRelease.Name = "btnRelease";
			this.btnRelease.Size = new System.Drawing.Size(141, 56);
			this.btnRelease.TabIndex = 7;
			this.btnRelease.Text = "Release";
			this.btnRelease.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnRelease.UseVisualStyleBackColor = true;
			this.btnRelease.Click += new System.EventHandler(this.btnRelease_Click);
			// 
			// FrmReleaseLicense
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(829, 673);
			this.Controls.Add(this.llShowLicenseInfo);
			this.Controls.Add(this.llShowLicenseHistory);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.btnRelease);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.ctrLicenseInfoWithFilter1);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FrmReleaseLicense";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Release License";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private Licenses.ctrLicenseInfoWithFilter ctrLicenseInfoWithFilter1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label lblTotalFees;
		private System.Windows.Forms.Label lblApplicationID;
		private System.Windows.Forms.PictureBox pictureBox7;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.PictureBox pictureBox8;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label lblApplicaitonFees;
		private System.Windows.Forms.Label lblFineFees;
		private System.Windows.Forms.PictureBox pictureBox6;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lblCreatedByUserID;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label lblLicenseID;
		private System.Windows.Forms.PictureBox pictureBox5;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label lblDetainDate;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label lblDetainID;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.LinkLabel llShowLicenseInfo;
		private System.Windows.Forms.LinkLabel llShowLicenseHistory;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Button btnRelease;
	}
}