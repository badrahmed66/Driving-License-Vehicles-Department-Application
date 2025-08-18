namespace MyDVLD_Presentation.Licenses
{
	partial class FrmShowLicenseInfo
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
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.btnClose = new System.Windows.Forms.Button();
			this.ctrDriverLicenseInfo1 = new MyDVLD_Presentation.Licenses.ctrDriverLicenseInfo();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Red;
			this.label1.Location = new System.Drawing.Point(301, 106);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(199, 24);
			this.label1.TabIndex = 0;
			this.label1.Text = "Driver License INFO";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::MyDVLD_Presentation.Properties.Resources.LicenseView_400;
			this.pictureBox1.Location = new System.Drawing.Point(322, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(156, 91);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// btnClose
			// 
			this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnClose.Image = global::MyDVLD_Presentation.Properties.Resources.Close_32;
			this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnClose.Location = new System.Drawing.Point(779, 504);
			this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(95, 37);
			this.btnClose.TabIndex = 137;
			this.btnClose.Text = "Close";
			this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// ctrDriverLicenseInfo1
			// 
			this.ctrDriverLicenseInfo1.Location = new System.Drawing.Point(12, 143);
			this.ctrDriverLicenseInfo1.Name = "ctrDriverLicenseInfo1";
			this.ctrDriverLicenseInfo1.Size = new System.Drawing.Size(865, 353);
			this.ctrDriverLicenseInfo1.TabIndex = 138;
			// 
			// FrmShowLicenseInfo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(887, 547);
			this.Controls.Add(this.ctrDriverLicenseInfo1);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FrmShowLicenseInfo";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "License Details";
			this.Load += new System.EventHandler(this.FrmShowLicenseInfo_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button btnClose;
		private ctrDriverLicenseInfo ctrDriverLicenseInfo1;
	}
}