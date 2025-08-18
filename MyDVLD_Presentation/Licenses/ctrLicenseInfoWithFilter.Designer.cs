namespace MyDVLD_Presentation.Licenses
{
	partial class ctrLicenseInfoWithFilter
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
			this.components = new System.ComponentModel.Container();
			this.gbFilter = new System.Windows.Forms.GroupBox();
			this.btnSearch = new System.Windows.Forms.Button();
			this.txtFilter = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.ctrDriverLicenseInfo1 = new MyDVLD_Presentation.Licenses.ctrDriverLicenseInfo();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.gbFilter.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// gbFilter
			// 
			this.gbFilter.Controls.Add(this.btnSearch);
			this.gbFilter.Controls.Add(this.txtFilter);
			this.gbFilter.Controls.Add(this.label1);
			this.gbFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gbFilter.Location = new System.Drawing.Point(3, 3);
			this.gbFilter.Name = "gbFilter";
			this.gbFilter.Size = new System.Drawing.Size(422, 65);
			this.gbFilter.TabIndex = 1;
			this.gbFilter.TabStop = false;
			this.gbFilter.Text = "Filter";
			// 
			// btnSearch
			// 
			this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnSearch.Image = global::MyDVLD_Presentation.Properties.Resources.License_View_32;
			this.btnSearch.Location = new System.Drawing.Point(329, 18);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(41, 32);
			this.btnSearch.TabIndex = 2;
			this.btnSearch.UseVisualStyleBackColor = true;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// txtFilter
			// 
			this.txtFilter.Location = new System.Drawing.Point(161, 21);
			this.txtFilter.Name = "txtFilter";
			this.txtFilter.Size = new System.Drawing.Size(162, 26);
			this.txtFilter.TabIndex = 1;
			this.txtFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilter_KeyPress);
			this.txtFilter.Validating += new System.ComponentModel.CancelEventHandler(this.txtFilter_Validating);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(61, 27);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(94, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "License ID :";
			// 
			// ctrDriverLicenseInfo1
			// 
			this.ctrDriverLicenseInfo1.Location = new System.Drawing.Point(3, 74);
			this.ctrDriverLicenseInfo1.Name = "ctrDriverLicenseInfo1";
			this.ctrDriverLicenseInfo1.Size = new System.Drawing.Size(806, 295);
			this.ctrDriverLicenseInfo1.TabIndex = 0;
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// ctrLicenseInfoWithFilter
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.gbFilter);
			this.Controls.Add(this.ctrDriverLicenseInfo1);
			this.Name = "ctrLicenseInfoWithFilter";
			this.Size = new System.Drawing.Size(816, 368);
			this.gbFilter.ResumeLayout(false);
			this.gbFilter.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private ctrDriverLicenseInfo ctrDriverLicenseInfo1;
		private System.Windows.Forms.GroupBox gbFilter;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.TextBox txtFilter;
		private System.Windows.Forms.ErrorProvider errorProvider1;
	}
}
