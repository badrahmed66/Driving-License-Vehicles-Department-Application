namespace MyDVLD_Presentation.Licenses
{
	partial class FrmShowLicensesHistory
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
			this.ctrShowPersonDetailsWithFilter1 = new MyDVLD_Presentation.UserControls.ctrShowPersonDetailsWithFilter();
			this.ctrDriverLicenses1 = new MyDVLD_Presentation.Drivers.ctrDriverLicenses();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Red;
			this.label1.Location = new System.Drawing.Point(12, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(205, 29);
			this.label1.TabIndex = 0;
			this.label1.Text = "Licenses History";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::MyDVLD_Presentation.Properties.Resources.PersonLicenseHistory_512;
			this.pictureBox1.Location = new System.Drawing.Point(12, 64);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(205, 350);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 2;
			this.pictureBox1.TabStop = false;
			// 
			// btnClose
			// 
			this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnClose.Image = global::MyDVLD_Presentation.Properties.Resources.Close_32;
			this.btnClose.Location = new System.Drawing.Point(885, 644);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(93, 35);
			this.btnClose.TabIndex = 5;
			this.btnClose.Text = "Close";
			this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// ctrShowPersonDetailsWithFilter1
			// 
			this.ctrShowPersonDetailsWithFilter1.AddNewPersonButton = false;
			this.ctrShowPersonDetailsWithFilter1.GroupFilter = true;
			this.ctrShowPersonDetailsWithFilter1.Location = new System.Drawing.Point(223, 12);
			this.ctrShowPersonDetailsWithFilter1.Name = "ctrShowPersonDetailsWithFilter1";
			this.ctrShowPersonDetailsWithFilter1.Size = new System.Drawing.Size(755, 424);
			this.ctrShowPersonDetailsWithFilter1.TabIndex = 4;
			this.ctrShowPersonDetailsWithFilter1.OnPersonSelected += new System.Action<int>(this.ctrShowPersonDetailsWithFilter1_OnPersonSelected);
			this.ctrShowPersonDetailsWithFilter1.Load += new System.EventHandler(this.ctrShowPersonDetailsWithFilter1_Load);
			// 
			// ctrDriverLicenses1
			// 
			this.ctrDriverLicenses1.Location = new System.Drawing.Point(12, 430);
			this.ctrDriverLicenses1.Name = "ctrDriverLicenses1";
			this.ctrDriverLicenses1.Size = new System.Drawing.Size(966, 233);
			this.ctrDriverLicenses1.TabIndex = 3;
			// 
			// FrmShowLicensesHistory
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnClose;
			this.ClientSize = new System.Drawing.Size(990, 681);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.ctrShowPersonDetailsWithFilter1);
			this.Controls.Add(this.ctrDriverLicenses1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FrmShowLicensesHistory";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Licenses History";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private Drivers.ctrDriverLicenses ctrDriverLicenses1;
		private UserControls.ctrShowPersonDetailsWithFilter ctrShowPersonDetailsWithFilter1;
		private System.Windows.Forms.Button btnClose;
	}
}