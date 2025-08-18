namespace MyDVLD_Presentation.Licenses
{
	partial class FrmIssueForFirstTime
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
			this.ctrLocalDrivingLicenseApplicationInfo1 = new MyDVLD_Presentation.AllApplications.ctrLocalDrivingLicenseApplicationInfo();
			this.label1 = new System.Windows.Forms.Label();
			this.txtNotes = new System.Windows.Forms.TextBox();
			this.btnIssue = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// ctrLocalDrivingLicenseApplicationInfo1
			// 
			this.ctrLocalDrivingLicenseApplicationInfo1.Location = new System.Drawing.Point(-1, 2);
			this.ctrLocalDrivingLicenseApplicationInfo1.Name = "ctrLocalDrivingLicenseApplicationInfo1";
			this.ctrLocalDrivingLicenseApplicationInfo1.PassedTests = ((byte)(0));
			this.ctrLocalDrivingLicenseApplicationInfo1.Size = new System.Drawing.Size(839, 309);
			this.ctrLocalDrivingLicenseApplicationInfo1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 324);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(66, 20);
			this.label1.TabIndex = 1;
			this.label1.Text = "Notes :";
			// 
			// txtNotes
			// 
			this.txtNotes.Location = new System.Drawing.Point(122, 326);
			this.txtNotes.Multiline = true;
			this.txtNotes.Name = "txtNotes";
			this.txtNotes.Size = new System.Drawing.Size(705, 69);
			this.txtNotes.TabIndex = 2;
			// 
			// btnIssue
			// 
			this.btnIssue.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnIssue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnIssue.Image = global::MyDVLD_Presentation.Properties.Resources.IssueDrivingLicense_321;
			this.btnIssue.Location = new System.Drawing.Point(730, 414);
			this.btnIssue.Name = "btnIssue";
			this.btnIssue.Size = new System.Drawing.Size(97, 46);
			this.btnIssue.TabIndex = 5;
			this.btnIssue.Text = "Issue";
			this.btnIssue.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnIssue.UseVisualStyleBackColor = true;
			this.btnIssue.Click += new System.EventHandler(this.btnIssue_Click);
			// 
			// btnClose
			// 
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnClose.Image = global::MyDVLD_Presentation.Properties.Resources.Close_32;
			this.btnClose.Location = new System.Drawing.Point(613, 414);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(97, 46);
			this.btnClose.TabIndex = 4;
			this.btnClose.Text = "Close";
			this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::MyDVLD_Presentation.Properties.Resources.Notes_32;
			this.pictureBox1.Location = new System.Drawing.Point(84, 324);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(32, 32);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox1.TabIndex = 3;
			this.pictureBox1.TabStop = false;
			// 
			// FrmIssueForFirstTime
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(839, 472);
			this.Controls.Add(this.btnIssue);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.txtNotes);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.ctrLocalDrivingLicenseApplicationInfo1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FrmIssueForFirstTime";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Issue For First Time";
			this.Load += new System.EventHandler(this.FrmIssueForFirstTime_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private AllApplications.ctrLocalDrivingLicenseApplicationInfo ctrLocalDrivingLicenseApplicationInfo1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtNotes;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Button btnIssue;
	}
}