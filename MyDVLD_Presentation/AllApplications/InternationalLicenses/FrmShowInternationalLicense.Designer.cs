namespace MyDVLD_Presentation.AllApplications.InternationalLicenses
{
	partial class FrmShowInternationalLicense
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
			this.ctrShowInternationalLicense1 = new MyDVLD_Presentation.AllApplications.InternationalLicenses.ctrShowInternationalLicense();
			this.label1 = new System.Windows.Forms.Label();
			this.btnClose = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// ctrShowInternationalLicense1
			// 
			this.ctrShowInternationalLicense1.Location = new System.Drawing.Point(11, 54);
			this.ctrShowInternationalLicense1.Name = "ctrShowInternationalLicense1";
			this.ctrShowInternationalLicense1.Size = new System.Drawing.Size(803, 388);
			this.ctrShowInternationalLicense1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Red;
			this.label1.Location = new System.Drawing.Point(227, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(373, 31);
			this.label1.TabIndex = 1;
			this.label1.Text = "Driver International License";
			// 
			// btnClose
			// 
			this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnClose.Image = global::MyDVLD_Presentation.Properties.Resources.Close_32;
			this.btnClose.Location = new System.Drawing.Point(711, 448);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(103, 39);
			this.btnClose.TabIndex = 2;
			this.btnClose.Text = "Close";
			this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// FrmShowInternationalLicense
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(826, 511);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.ctrShowInternationalLicense1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FrmShowInternationalLicense";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Show International License";
			this.Load += new System.EventHandler(this.FrmShowInternationalLicense_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private ctrShowInternationalLicense ctrShowInternationalLicense1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnClose;
	}
}