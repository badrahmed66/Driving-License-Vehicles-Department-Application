namespace MyDVLD_Presentation.AllApplications.InternationalLicenses
{
	partial class FrmManageInternationalLicenses
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
			this.label2 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.cbFilter = new System.Windows.Forms.ComboBox();
			this.txtFilter = new System.Windows.Forms.TextBox();
			this.dgInternationalLicenses = new System.Windows.Forms.DataGridView();
			this.button1 = new System.Windows.Forms.Button();
			this.btnNewLicense = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.lblCount = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgInternationalLicenses)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Red;
			this.label1.Location = new System.Drawing.Point(238, 99);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(412, 31);
			this.label1.TabIndex = 0;
			this.label1.Text = "Manage International Licenses";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(12, 143);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(78, 17);
			this.label2.TabIndex = 1;
			this.label2.Text = "Filter By :";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::MyDVLD_Presentation.Properties.Resources.Application_Types_512;
			this.pictureBox1.Location = new System.Drawing.Point(325, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(239, 84);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 2;
			this.pictureBox1.TabStop = false;
			// 
			// cbFilter
			// 
			this.cbFilter.FormattingEnabled = true;
			this.cbFilter.Location = new System.Drawing.Point(96, 143);
			this.cbFilter.Name = "cbFilter";
			this.cbFilter.Size = new System.Drawing.Size(121, 21);
			this.cbFilter.TabIndex = 3;
			this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
			// 
			// txtFilter
			// 
			this.txtFilter.Location = new System.Drawing.Point(223, 144);
			this.txtFilter.Name = "txtFilter";
			this.txtFilter.Size = new System.Drawing.Size(110, 20);
			this.txtFilter.TabIndex = 4;
			this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
			this.txtFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilter_KeyPress);
			// 
			// dgInternationalLicenses
			// 
			this.dgInternationalLicenses.AllowUserToAddRows = false;
			this.dgInternationalLicenses.AllowUserToDeleteRows = false;
			this.dgInternationalLicenses.AllowUserToOrderColumns = true;
			this.dgInternationalLicenses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgInternationalLicenses.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dgInternationalLicenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgInternationalLicenses.Location = new System.Drawing.Point(12, 170);
			this.dgInternationalLicenses.Name = "dgInternationalLicenses";
			this.dgInternationalLicenses.ReadOnly = true;
			this.dgInternationalLicenses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgInternationalLicenses.Size = new System.Drawing.Size(864, 176);
			this.dgInternationalLicenses.TabIndex = 5;
			// 
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Image = global::MyDVLD_Presentation.Properties.Resources.Close_32;
			this.button1.Location = new System.Drawing.Point(783, 352);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(93, 37);
			this.button1.TabIndex = 6;
			this.button1.Text = "Close";
			this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// btnNewLicense
			// 
			this.btnNewLicense.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnNewLicense.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNewLicense.Image = global::MyDVLD_Presentation.Properties.Resources.International_32;
			this.btnNewLicense.Location = new System.Drawing.Point(812, 120);
			this.btnNewLicense.Name = "btnNewLicense";
			this.btnNewLicense.Size = new System.Drawing.Size(64, 44);
			this.btnNewLicense.TabIndex = 7;
			this.btnNewLicense.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnNewLicense.UseVisualStyleBackColor = true;
			this.btnNewLicense.Click += new System.EventHandler(this.btnNewLicense_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(12, 362);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(84, 17);
			this.label3.TabIndex = 8;
			this.label3.Text = "# Record :";
			// 
			// lblCount
			// 
			this.lblCount.AutoSize = true;
			this.lblCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCount.Location = new System.Drawing.Point(102, 362);
			this.lblCount.Name = "lblCount";
			this.lblCount.Size = new System.Drawing.Size(35, 17);
			this.lblCount.TabIndex = 9;
			this.lblCount.Text = "???";
			// 
			// FrmManageInternationalLicenses
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(888, 399);
			this.Controls.Add(this.lblCount);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.btnNewLicense);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.dgInternationalLicenses);
			this.Controls.Add(this.txtFilter);
			this.Controls.Add(this.cbFilter);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "FrmManageInternationalLicenses";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Manage International Licenses";
			this.Load += new System.EventHandler(this.FrmManageInternationalLicenses_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgInternationalLicenses)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.ComboBox cbFilter;
		private System.Windows.Forms.TextBox txtFilter;
		private System.Windows.Forms.DataGridView dgInternationalLicenses;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button btnNewLicense;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lblCount;
	}
}