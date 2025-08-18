namespace MyDVLD_Presentation.AllApplications.DetainedLicenses
{
	partial class FrmDetainLicense
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
			this.components = new System.ComponentModel.Container();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtFees = new System.Windows.Forms.TextBox();
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
			this.btnDetain = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.llShowLicenseHistory = new System.Windows.Forms.LinkLabel();
			this.llShowLicenseInfo = new System.Windows.Forms.LinkLabel();
			this.ctrLicenseInfoWithFilter1 = new MyDVLD_Presentation.Licenses.ctrLicenseInfoWithFilter();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Red;
			this.label1.Location = new System.Drawing.Point(307, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(208, 31);
			this.label1.TabIndex = 0;
			this.label1.Text = "Detain License";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtFees);
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
			this.groupBox1.Location = new System.Drawing.Point(12, 428);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(806, 142);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Detain Info";
			// 
			// txtFees
			// 
			this.txtFees.Location = new System.Drawing.Point(145, 94);
			this.txtFees.Name = "txtFees";
			this.txtFees.Size = new System.Drawing.Size(123, 23);
			this.txtFees.TabIndex = 15;
			this.txtFees.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFees_KeyPress);
			this.txtFees.Validating += new System.ComponentModel.CancelEventHandler(this.txtFees_Validating);
			// 
			// lblCreatedByUserID
			// 
			this.lblCreatedByUserID.AutoSize = true;
			this.lblCreatedByUserID.Location = new System.Drawing.Point(538, 63);
			this.lblCreatedByUserID.Name = "lblCreatedByUserID";
			this.lblCreatedByUserID.Size = new System.Drawing.Size(35, 17);
			this.lblCreatedByUserID.TabIndex = 14;
			this.lblCreatedByUserID.Text = "???";
			// 
			// pictureBox4
			// 
			this.pictureBox4.Image = global::MyDVLD_Presentation.Properties.Resources.User_32__2;
			this.pictureBox4.Location = new System.Drawing.Point(509, 63);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(23, 17);
			this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox4.TabIndex = 13;
			this.pictureBox4.TabStop = false;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(346, 63);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(157, 17);
			this.label6.TabIndex = 12;
			this.label6.Text = "Created By User ID :";
			// 
			// lblLicenseID
			// 
			this.lblLicenseID.AutoSize = true;
			this.lblLicenseID.Location = new System.Drawing.Point(538, 29);
			this.lblLicenseID.Name = "lblLicenseID";
			this.lblLicenseID.Size = new System.Drawing.Size(35, 17);
			this.lblLicenseID.TabIndex = 11;
			this.lblLicenseID.Text = "???";
			// 
			// pictureBox5
			// 
			this.pictureBox5.Image = global::MyDVLD_Presentation.Properties.Resources.Number_32;
			this.pictureBox5.Location = new System.Drawing.Point(509, 29);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new System.Drawing.Size(23, 17);
			this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox5.TabIndex = 10;
			this.pictureBox5.TabStop = false;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(409, 29);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(94, 17);
			this.label8.TabIndex = 9;
			this.label8.Text = "License ID :";
			// 
			// pictureBox3
			// 
			this.pictureBox3.Image = global::MyDVLD_Presentation.Properties.Resources.money_32;
			this.pictureBox3.Location = new System.Drawing.Point(116, 97);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(23, 17);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox3.TabIndex = 7;
			this.pictureBox3.TabStop = false;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(57, 97);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(53, 17);
			this.label5.TabIndex = 6;
			this.label5.Text = "Fees :";
			// 
			// lblDetainDate
			// 
			this.lblDetainDate.AutoSize = true;
			this.lblDetainDate.Location = new System.Drawing.Point(145, 63);
			this.lblDetainDate.Name = "lblDetainDate";
			this.lblDetainDate.Size = new System.Drawing.Size(35, 17);
			this.lblDetainDate.TabIndex = 5;
			this.lblDetainDate.Text = "???";
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = global::MyDVLD_Presentation.Properties.Resources.Calendar_32;
			this.pictureBox2.Location = new System.Drawing.Point(116, 63);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(23, 17);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox2.TabIndex = 4;
			this.pictureBox2.TabStop = false;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 63);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(104, 17);
			this.label4.TabIndex = 3;
			this.label4.Text = "Detain Date :";
			// 
			// lblDetainID
			// 
			this.lblDetainID.AutoSize = true;
			this.lblDetainID.Location = new System.Drawing.Point(117, 29);
			this.lblDetainID.Name = "lblDetainID";
			this.lblDetainID.Size = new System.Drawing.Size(35, 17);
			this.lblDetainID.TabIndex = 2;
			this.lblDetainID.Text = "???";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::MyDVLD_Presentation.Properties.Resources.Number_32;
			this.pictureBox1.Location = new System.Drawing.Point(88, 29);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(23, 17);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 29);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(85, 17);
			this.label2.TabIndex = 0;
			this.label2.Text = "Detain ID :";
			// 
			// btnDetain
			// 
			this.btnDetain.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnDetain.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDetain.Image = global::MyDVLD_Presentation.Properties.Resources.International_32;
			this.btnDetain.Location = new System.Drawing.Point(703, 576);
			this.btnDetain.Name = "btnDetain";
			this.btnDetain.Size = new System.Drawing.Size(113, 38);
			this.btnDetain.TabIndex = 3;
			this.btnDetain.Text = "Detain";
			this.btnDetain.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnDetain.UseVisualStyleBackColor = true;
			this.btnDetain.Click += new System.EventHandler(this.btnDetain_Click);
			// 
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Image = global::MyDVLD_Presentation.Properties.Resources.Close_32;
			this.button1.Location = new System.Drawing.Point(584, 576);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(113, 38);
			this.button1.TabIndex = 4;
			this.button1.Text = "Close";
			this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// llShowLicenseHistory
			// 
			this.llShowLicenseHistory.AutoSize = true;
			this.llShowLicenseHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.llShowLicenseHistory.Location = new System.Drawing.Point(12, 589);
			this.llShowLicenseHistory.Name = "llShowLicenseHistory";
			this.llShowLicenseHistory.Size = new System.Drawing.Size(143, 17);
			this.llShowLicenseHistory.TabIndex = 5;
			this.llShowLicenseHistory.TabStop = true;
			this.llShowLicenseHistory.Text = "Show License History";
			this.llShowLicenseHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llShowLicenseHistory_LinkClicked);
			// 
			// llShowLicenseInfo
			// 
			this.llShowLicenseInfo.AutoSize = true;
			this.llShowLicenseInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.llShowLicenseInfo.Location = new System.Drawing.Point(177, 589);
			this.llShowLicenseInfo.Name = "llShowLicenseInfo";
			this.llShowLicenseInfo.Size = new System.Drawing.Size(122, 17);
			this.llShowLicenseInfo.TabIndex = 6;
			this.llShowLicenseInfo.TabStop = true;
			this.llShowLicenseInfo.Text = "Show License Info";
			this.llShowLicenseInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llShowLicenseInfo_LinkClicked);
			// 
			// ctrLicenseInfoWithFilter1
			// 
			this.ctrLicenseInfoWithFilter1.FilterEnable = true;
			this.ctrLicenseInfoWithFilter1.Location = new System.Drawing.Point(12, 54);
			this.ctrLicenseInfoWithFilter1.Name = "ctrLicenseInfoWithFilter1";
			this.ctrLicenseInfoWithFilter1.Size = new System.Drawing.Size(806, 368);
			this.ctrLicenseInfoWithFilter1.TabIndex = 1;
			this.ctrLicenseInfoWithFilter1.OnLicenseSelected += new System.Action<int>(this.ctrLicenseInfoWithFilter1_OnLicenseSelected);
			this.ctrLicenseInfoWithFilter1.Load += new System.EventHandler(this.ctrLicenseInfoWithFilter1_Load);
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// FrmDetainLicense
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(828, 634);
			this.Controls.Add(this.llShowLicenseInfo);
			this.Controls.Add(this.llShowLicenseHistory);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.btnDetain);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.ctrLicenseInfoWithFilter1);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FrmDetainLicense";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Detain License";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private Licenses.ctrLicenseInfoWithFilter ctrLicenseInfoWithFilter1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label lblDetainDate;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label lblDetainID;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtFees;
		private System.Windows.Forms.Label lblCreatedByUserID;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label lblLicenseID;
		private System.Windows.Forms.PictureBox pictureBox5;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Button btnDetain;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.LinkLabel llShowLicenseHistory;
		private System.Windows.Forms.LinkLabel llShowLicenseInfo;
		private System.Windows.Forms.ErrorProvider errorProvider1;
	}
}