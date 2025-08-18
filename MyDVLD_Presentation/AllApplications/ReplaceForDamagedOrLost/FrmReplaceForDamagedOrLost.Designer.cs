namespace MyDVLD_Presentation.AllApplications.ReplaceForDamagedOrLost
{
	partial class FrmReplaceForDamagedOrLost
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
			this.lblTitle = new System.Windows.Forms.Label();
			this.ctrLicenseInfoWithFilter1 = new MyDVLD_Presentation.Licenses.ctrLicenseInfoWithFilter();
			this.gbReplacmentFor = new System.Windows.Forms.GroupBox();
			this.rbLost = new System.Windows.Forms.RadioButton();
			this.rbDamaged = new System.Windows.Forms.RadioButton();
			this.gpApplicationInfo = new System.Windows.Forms.GroupBox();
			this.pictureBox6 = new System.Windows.Forms.PictureBox();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.lblOldLicenseID = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.lblRreplacedLicenseID = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.label2 = new System.Windows.Forms.Label();
			this.lblCreatedByUser = new System.Windows.Forms.Label();
			this.lblApplicationFees = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.lblApplicationDate = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.lblApplicationID = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.btnIssueReplacement = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.llShowLicenseInfo = new System.Windows.Forms.LinkLabel();
			this.llShowLicenseHistory = new System.Windows.Forms.LinkLabel();
			this.gbReplacmentFor.SuspendLayout();
			this.gpApplicationInfo.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// lblTitle
			// 
			this.lblTitle.AutoSize = true;
			this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitle.ForeColor = System.Drawing.Color.Red;
			this.lblTitle.Location = new System.Drawing.Point(311, 9);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(206, 25);
			this.lblTitle.TabIndex = 0;
			this.lblTitle.Text = "License Replacment";
			// 
			// ctrLicenseInfoWithFilter1
			// 
			this.ctrLicenseInfoWithFilter1.FilterEnable = true;
			this.ctrLicenseInfoWithFilter1.Location = new System.Drawing.Point(12, 47);
			this.ctrLicenseInfoWithFilter1.Name = "ctrLicenseInfoWithFilter1";
			this.ctrLicenseInfoWithFilter1.Size = new System.Drawing.Size(811, 368);
			this.ctrLicenseInfoWithFilter1.TabIndex = 1;
			this.ctrLicenseInfoWithFilter1.OnLicenseSelected += new System.Action<int>(this.ctrLicenseInfoWithFilter1_OnLicenseSelected);
			this.ctrLicenseInfoWithFilter1.Load += new System.EventHandler(this.ctrLicenseInfoWithFilter1_Load);
			// 
			// gbReplacmentFor
			// 
			this.gbReplacmentFor.Controls.Add(this.rbLost);
			this.gbReplacmentFor.Controls.Add(this.rbDamaged);
			this.gbReplacmentFor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gbReplacmentFor.Location = new System.Drawing.Point(617, 28);
			this.gbReplacmentFor.Name = "gbReplacmentFor";
			this.gbReplacmentFor.Size = new System.Drawing.Size(200, 100);
			this.gbReplacmentFor.TabIndex = 2;
			this.gbReplacmentFor.TabStop = false;
			this.gbReplacmentFor.Text = "Replace For :";
			// 
			// rbLost
			// 
			this.rbLost.AutoSize = true;
			this.rbLost.Location = new System.Drawing.Point(28, 49);
			this.rbLost.Name = "rbLost";
			this.rbLost.Size = new System.Drawing.Size(106, 21);
			this.rbLost.TabIndex = 1;
			this.rbLost.TabStop = true;
			this.rbLost.Text = "Lost License";
			this.rbLost.UseVisualStyleBackColor = true;
			this.rbLost.CheckedChanged += new System.EventHandler(this.rbLost_CheckedChanged);
			// 
			// rbDamaged
			// 
			this.rbDamaged.AutoSize = true;
			this.rbDamaged.Location = new System.Drawing.Point(28, 22);
			this.rbDamaged.Name = "rbDamaged";
			this.rbDamaged.Size = new System.Drawing.Size(140, 21);
			this.rbDamaged.TabIndex = 0;
			this.rbDamaged.TabStop = true;
			this.rbDamaged.Text = "Damaged License";
			this.rbDamaged.UseVisualStyleBackColor = true;
			this.rbDamaged.CheckedChanged += new System.EventHandler(this.rbDamaged_CheckedChanged);
			// 
			// gpApplicationInfo
			// 
			this.gpApplicationInfo.Controls.Add(this.pictureBox6);
			this.gpApplicationInfo.Controls.Add(this.pictureBox5);
			this.gpApplicationInfo.Controls.Add(this.pictureBox4);
			this.gpApplicationInfo.Controls.Add(this.pictureBox3);
			this.gpApplicationInfo.Controls.Add(this.pictureBox1);
			this.gpApplicationInfo.Controls.Add(this.lblOldLicenseID);
			this.gpApplicationInfo.Controls.Add(this.label12);
			this.gpApplicationInfo.Controls.Add(this.lblRreplacedLicenseID);
			this.gpApplicationInfo.Controls.Add(this.label10);
			this.gpApplicationInfo.Controls.Add(this.pictureBox2);
			this.gpApplicationInfo.Controls.Add(this.label2);
			this.gpApplicationInfo.Controls.Add(this.lblCreatedByUser);
			this.gpApplicationInfo.Controls.Add(this.lblApplicationFees);
			this.gpApplicationInfo.Controls.Add(this.label3);
			this.gpApplicationInfo.Controls.Add(this.lblApplicationDate);
			this.gpApplicationInfo.Controls.Add(this.label5);
			this.gpApplicationInfo.Controls.Add(this.lblApplicationID);
			this.gpApplicationInfo.Controls.Add(this.label4);
			this.gpApplicationInfo.Location = new System.Drawing.Point(12, 421);
			this.gpApplicationInfo.Name = "gpApplicationInfo";
			this.gpApplicationInfo.Size = new System.Drawing.Size(805, 142);
			this.gpApplicationInfo.TabIndex = 186;
			this.gpApplicationInfo.TabStop = false;
			this.gpApplicationInfo.Text = "Application Info for License Replacement";
			// 
			// pictureBox6
			// 
			this.pictureBox6.Image = global::MyDVLD_Presentation.Properties.Resources.Calendar_32;
			this.pictureBox6.Location = new System.Drawing.Point(155, 70);
			this.pictureBox6.Name = "pictureBox6";
			this.pictureBox6.Size = new System.Drawing.Size(16, 17);
			this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox6.TabIndex = 199;
			this.pictureBox6.TabStop = false;
			// 
			// pictureBox5
			// 
			this.pictureBox5.Image = global::MyDVLD_Presentation.Properties.Resources.money_32;
			this.pictureBox5.Location = new System.Drawing.Point(155, 102);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new System.Drawing.Size(16, 17);
			this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox5.TabIndex = 198;
			this.pictureBox5.TabStop = false;
			// 
			// pictureBox4
			// 
			this.pictureBox4.Image = global::MyDVLD_Presentation.Properties.Resources.User_32__2;
			this.pictureBox4.Location = new System.Drawing.Point(568, 102);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(16, 17);
			this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox4.TabIndex = 197;
			this.pictureBox4.TabStop = false;
			// 
			// pictureBox3
			// 
			this.pictureBox3.Image = global::MyDVLD_Presentation.Properties.Resources.Number_32;
			this.pictureBox3.Location = new System.Drawing.Point(568, 70);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(16, 17);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox3.TabIndex = 196;
			this.pictureBox3.TabStop = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::MyDVLD_Presentation.Properties.Resources.Number_32;
			this.pictureBox1.Location = new System.Drawing.Point(568, 38);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(16, 17);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox1.TabIndex = 195;
			this.pictureBox1.TabStop = false;
			// 
			// lblOldLicenseID
			// 
			this.lblOldLicenseID.AutoSize = true;
			this.lblOldLicenseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblOldLicenseID.Location = new System.Drawing.Point(591, 70);
			this.lblOldLicenseID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblOldLicenseID.Name = "lblOldLicenseID";
			this.lblOldLicenseID.Size = new System.Drawing.Size(45, 17);
			this.lblOldLicenseID.TabIndex = 194;
			this.lblOldLicenseID.Text = "[???]";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(442, 70);
			this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(119, 17);
			this.label12.TabIndex = 193;
			this.label12.Text = "Old License ID:";
			// 
			// lblRreplacedLicenseID
			// 
			this.lblRreplacedLicenseID.AutoSize = true;
			this.lblRreplacedLicenseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRreplacedLicenseID.Location = new System.Drawing.Point(591, 38);
			this.lblRreplacedLicenseID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblRreplacedLicenseID.Name = "lblRreplacedLicenseID";
			this.lblRreplacedLicenseID.Size = new System.Drawing.Size(45, 17);
			this.lblRreplacedLicenseID.TabIndex = 191;
			this.lblRreplacedLicenseID.Text = "[???]";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(399, 38);
			this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(162, 17);
			this.label10.TabIndex = 190;
			this.label10.Text = "Replaced License ID:";
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = global::MyDVLD_Presentation.Properties.Resources.Number_32;
			this.pictureBox2.Location = new System.Drawing.Point(155, 38);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(16, 17);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox2.TabIndex = 183;
			this.pictureBox2.TabStop = false;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(468, 102);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(93, 17);
			this.label2.TabIndex = 181;
			this.label2.Text = "Created By:";
			// 
			// lblCreatedByUser
			// 
			this.lblCreatedByUser.AutoSize = true;
			this.lblCreatedByUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCreatedByUser.Location = new System.Drawing.Point(591, 102);
			this.lblCreatedByUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblCreatedByUser.Name = "lblCreatedByUser";
			this.lblCreatedByUser.Size = new System.Drawing.Size(54, 17);
			this.lblCreatedByUser.TabIndex = 180;
			this.lblCreatedByUser.Text = "[????]";
			// 
			// lblApplicationFees
			// 
			this.lblApplicationFees.AutoSize = true;
			this.lblApplicationFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblApplicationFees.Location = new System.Drawing.Point(214, 102);
			this.lblApplicationFees.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblApplicationFees.Name = "lblApplicationFees";
			this.lblApplicationFees.Size = new System.Drawing.Size(45, 17);
			this.lblApplicationFees.TabIndex = 179;
			this.lblApplicationFees.Text = "[$$$]";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(5, 102);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(133, 17);
			this.label3.TabIndex = 177;
			this.label3.Text = "Application Fees:";
			// 
			// lblApplicationDate
			// 
			this.lblApplicationDate.AutoSize = true;
			this.lblApplicationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblApplicationDate.Location = new System.Drawing.Point(214, 70);
			this.lblApplicationDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblApplicationDate.Name = "lblApplicationDate";
			this.lblApplicationDate.Size = new System.Drawing.Size(100, 17);
			this.lblApplicationDate.TabIndex = 176;
			this.lblApplicationDate.Text = "[??/??/????]";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(5, 70);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(132, 17);
			this.label5.TabIndex = 174;
			this.label5.Text = "Application Date:";
			// 
			// lblApplicationID
			// 
			this.lblApplicationID.AutoSize = true;
			this.lblApplicationID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblApplicationID.Location = new System.Drawing.Point(214, 38);
			this.lblApplicationID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblApplicationID.Name = "lblApplicationID";
			this.lblApplicationID.Size = new System.Drawing.Size(45, 17);
			this.lblApplicationID.TabIndex = 173;
			this.lblApplicationID.Text = "[???]";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(5, 38);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(143, 17);
			this.label4.TabIndex = 172;
			this.label4.Text = "L.R.Application ID:";
			// 
			// btnIssueReplacement
			// 
			this.btnIssueReplacement.Enabled = false;
			this.btnIssueReplacement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnIssueReplacement.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnIssueReplacement.Image = global::MyDVLD_Presentation.Properties.Resources.IssueDrivingLicense_32;
			this.btnIssueReplacement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnIssueReplacement.Location = new System.Drawing.Point(645, 569);
			this.btnIssueReplacement.Name = "btnIssueReplacement";
			this.btnIssueReplacement.Size = new System.Drawing.Size(172, 37);
			this.btnIssueReplacement.TabIndex = 188;
			this.btnIssueReplacement.Text = "Issue Replacement";
			this.btnIssueReplacement.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnIssueReplacement.UseVisualStyleBackColor = true;
			this.btnIssueReplacement.Click += new System.EventHandler(this.btnIssueReplacement_Click);
			// 
			// btnClose
			// 
			this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnClose.Image = global::MyDVLD_Presentation.Properties.Resources.Close_32;
			this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnClose.Location = new System.Drawing.Point(549, 569);
			this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(89, 37);
			this.btnClose.TabIndex = 189;
			this.btnClose.Text = "Close";
			this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// llShowLicenseInfo
			// 
			this.llShowLicenseInfo.AutoSize = true;
			this.llShowLicenseInfo.Enabled = false;
			this.llShowLicenseInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.llShowLicenseInfo.Location = new System.Drawing.Point(194, 569);
			this.llShowLicenseInfo.Name = "llShowLicenseInfo";
			this.llShowLicenseInfo.Size = new System.Drawing.Size(182, 17);
			this.llShowLicenseInfo.TabIndex = 191;
			this.llShowLicenseInfo.TabStop = true;
			this.llShowLicenseInfo.Text = "Show New Licenses Info";
			this.llShowLicenseInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llShowLicenseInfo_LinkClicked);
			// 
			// llShowLicenseHistory
			// 
			this.llShowLicenseHistory.AutoSize = true;
			this.llShowLicenseHistory.Enabled = false;
			this.llShowLicenseHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.llShowLicenseHistory.Location = new System.Drawing.Point(17, 569);
			this.llShowLicenseHistory.Name = "llShowLicenseHistory";
			this.llShowLicenseHistory.Size = new System.Drawing.Size(171, 17);
			this.llShowLicenseHistory.TabIndex = 190;
			this.llShowLicenseHistory.TabStop = true;
			this.llShowLicenseHistory.Text = "Show Licenses History";
			this.llShowLicenseHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llShowLicenseHistory_LinkClicked);
			// 
			// FrmReplaceForDamagedOrLost
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(829, 612);
			this.Controls.Add(this.llShowLicenseInfo);
			this.Controls.Add(this.llShowLicenseHistory);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.btnIssueReplacement);
			this.Controls.Add(this.gpApplicationInfo);
			this.Controls.Add(this.gbReplacmentFor);
			this.Controls.Add(this.ctrLicenseInfoWithFilter1);
			this.Controls.Add(this.lblTitle);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FrmReplaceForDamagedOrLost";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FrmReplaceForDamagedOrLost";
			this.Activated += new System.EventHandler(this.FrmReplaceForDamagedOrLost_Activated);
			this.gbReplacmentFor.ResumeLayout(false);
			this.gbReplacmentFor.PerformLayout();
			this.gpApplicationInfo.ResumeLayout(false);
			this.gpApplicationInfo.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblTitle;
		private Licenses.ctrLicenseInfoWithFilter ctrLicenseInfoWithFilter1;
		private System.Windows.Forms.GroupBox gbReplacmentFor;
		private System.Windows.Forms.RadioButton rbLost;
		private System.Windows.Forms.RadioButton rbDamaged;
		private System.Windows.Forms.GroupBox gpApplicationInfo;
		private System.Windows.Forms.Label lblOldLicenseID;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label lblRreplacedLicenseID;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblCreatedByUser;
		private System.Windows.Forms.Label lblApplicationFees;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lblApplicationDate;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label lblApplicationID;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.PictureBox pictureBox6;
		private System.Windows.Forms.PictureBox pictureBox5;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button btnIssueReplacement;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.LinkLabel llShowLicenseInfo;
		private System.Windows.Forms.LinkLabel llShowLicenseHistory;
	}
}