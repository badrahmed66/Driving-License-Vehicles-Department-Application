namespace MyDVLD_Presentation.AllApplications.LocalDrivingApp
{
	partial class frmShowLDLApplicationInfo
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
			this.btnClose = new System.Windows.Forms.Button();
			this.ctrLocalDrivingLicenseApplicationInfo1 = new MyDVLD_Presentation.AllApplications.ctrLocalDrivingLicenseApplicationInfo();
			this.SuspendLayout();
			// 
			// btnClose
			// 
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnClose.Image = global::MyDVLD_Presentation.Properties.Resources.Close_32;
			this.btnClose.Location = new System.Drawing.Point(738, 315);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(92, 38);
			this.btnClose.TabIndex = 1;
			this.btnClose.Text = "Close";
			this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// ctrLocalDrivingLicenseApplicationInfo1
			// 
			this.ctrLocalDrivingLicenseApplicationInfo1.Location = new System.Drawing.Point(1, 3);
			this.ctrLocalDrivingLicenseApplicationInfo1.Name = "ctrLocalDrivingLicenseApplicationInfo1";
			this.ctrLocalDrivingLicenseApplicationInfo1.PassedTests = ((byte)(0));
			this.ctrLocalDrivingLicenseApplicationInfo1.Size = new System.Drawing.Size(840, 319);
			this.ctrLocalDrivingLicenseApplicationInfo1.TabIndex = 0;
			// 
			// frmShowLDLApplicationInfo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(840, 361);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.ctrLocalDrivingLicenseApplicationInfo1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmShowLDLApplicationInfo";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmShowLDLApplicationInfo";
			this.Load += new System.EventHandler(this.frmShowLDLApplicationInfo_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private ctrLocalDrivingLicenseApplicationInfo ctrLocalDrivingLicenseApplicationInfo1;
		private System.Windows.Forms.Button btnClose;
	}
}