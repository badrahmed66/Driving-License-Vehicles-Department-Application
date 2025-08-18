namespace MyDVLD_Presentation.AllApplications.DetainedLicenses
{
	partial class FrmManageDetainedLicenses
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
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label2 = new System.Windows.Forms.Label();
			this.cbFilterBy = new System.Windows.Forms.ComboBox();
			this.txtFilterBy = new System.Windows.Forms.TextBox();
			this.dgDetainedLicenses = new System.Windows.Forms.DataGridView();
			this.btnClose = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.lblCount = new System.Windows.Forms.Label();
			this.cbReleased = new System.Windows.Forms.ComboBox();
			this.btnRelease = new System.Windows.Forms.Button();
			this.btnDetain = new System.Windows.Forms.Button();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.showLicenseDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.showLicenseHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.releaseLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgDetainedLicenses)).BeginInit();
			this.contextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Red;
			this.label1.Location = new System.Drawing.Point(346, 118);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(182, 24);
			this.label1.TabIndex = 0;
			this.label1.Text = "Detained Licenses";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::MyDVLD_Presentation.Properties.Resources.Detain_512;
			this.pictureBox1.Location = new System.Drawing.Point(345, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(184, 103);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(12, 157);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(77, 17);
			this.label2.TabIndex = 2;
			this.label2.Text = "Filter by :";
			// 
			// cbFilterBy
			// 
			this.cbFilterBy.FormattingEnabled = true;
			this.cbFilterBy.Location = new System.Drawing.Point(95, 157);
			this.cbFilterBy.Name = "cbFilterBy";
			this.cbFilterBy.Size = new System.Drawing.Size(146, 21);
			this.cbFilterBy.TabIndex = 3;
			this.cbFilterBy.SelectedIndexChanged += new System.EventHandler(this.cbFilterBy_SelectedIndexChanged);
			// 
			// txtFilterBy
			// 
			this.txtFilterBy.Location = new System.Drawing.Point(247, 158);
			this.txtFilterBy.Name = "txtFilterBy";
			this.txtFilterBy.Size = new System.Drawing.Size(130, 20);
			this.txtFilterBy.TabIndex = 4;
			this.txtFilterBy.TextChanged += new System.EventHandler(this.txtFilterBy_TextChanged);
			this.txtFilterBy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilterBy_KeyPress);
			// 
			// dgDetainedLicenses
			// 
			this.dgDetainedLicenses.AllowUserToAddRows = false;
			this.dgDetainedLicenses.AllowUserToDeleteRows = false;
			this.dgDetainedLicenses.AllowUserToOrderColumns = true;
			this.dgDetainedLicenses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgDetainedLicenses.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dgDetainedLicenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgDetainedLicenses.ContextMenuStrip = this.contextMenuStrip1;
			this.dgDetainedLicenses.Location = new System.Drawing.Point(12, 184);
			this.dgDetainedLicenses.Name = "dgDetainedLicenses";
			this.dgDetainedLicenses.ReadOnly = true;
			this.dgDetainedLicenses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgDetainedLicenses.Size = new System.Drawing.Size(850, 254);
			this.dgDetainedLicenses.TabIndex = 5;
			// 
			// btnClose
			// 
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnClose.Image = global::MyDVLD_Presentation.Properties.Resources.Close_32;
			this.btnClose.Location = new System.Drawing.Point(773, 444);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(89, 34);
			this.btnClose.TabIndex = 6;
			this.btnClose.Text = "Close";
			this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(12, 453);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(84, 17);
			this.label3.TabIndex = 7;
			this.label3.Text = "# Record :";
			// 
			// lblCount
			// 
			this.lblCount.AutoSize = true;
			this.lblCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCount.Location = new System.Drawing.Point(102, 457);
			this.lblCount.Name = "lblCount";
			this.lblCount.Size = new System.Drawing.Size(35, 17);
			this.lblCount.TabIndex = 8;
			this.lblCount.Text = "???";
			// 
			// cbReleased
			// 
			this.cbReleased.FormattingEnabled = true;
			this.cbReleased.Location = new System.Drawing.Point(247, 156);
			this.cbReleased.Name = "cbReleased";
			this.cbReleased.Size = new System.Drawing.Size(66, 21);
			this.cbReleased.TabIndex = 9;
			this.cbReleased.SelectedIndexChanged += new System.EventHandler(this.cbReleased_SelectedIndexChanged);
			// 
			// btnRelease
			// 
			this.btnRelease.Image = global::MyDVLD_Presentation.Properties.Resources.Release_Detained_License_64;
			this.btnRelease.Location = new System.Drawing.Point(720, 118);
			this.btnRelease.Name = "btnRelease";
			this.btnRelease.Size = new System.Drawing.Size(68, 60);
			this.btnRelease.TabIndex = 10;
			this.btnRelease.UseVisualStyleBackColor = true;
			this.btnRelease.Click += new System.EventHandler(this.btnRelease_Click);
			// 
			// btnDetain
			// 
			this.btnDetain.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnDetain.Image = global::MyDVLD_Presentation.Properties.Resources.Detain_64;
			this.btnDetain.Location = new System.Drawing.Point(794, 118);
			this.btnDetain.Name = "btnDetain";
			this.btnDetain.Size = new System.Drawing.Size(68, 60);
			this.btnDetain.TabIndex = 11;
			this.btnDetain.UseVisualStyleBackColor = true;
			this.btnDetain.Click += new System.EventHandler(this.btnDetain_Click);
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showToolStripMenuItem,
            this.showLicenseDetailsToolStripMenuItem,
            this.showLicenseHistoryToolStripMenuItem,
            this.releaseLicenseToolStripMenuItem});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(187, 114);
			this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
			// 
			// showToolStripMenuItem
			// 
			this.showToolStripMenuItem.Image = global::MyDVLD_Presentation.Properties.Resources.PersonDetails_32;
			this.showToolStripMenuItem.Name = "showToolStripMenuItem";
			this.showToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
			this.showToolStripMenuItem.Text = "Show Person Details";
			this.showToolStripMenuItem.Click += new System.EventHandler(this.showToolStripMenuItem_Click);
			// 
			// showLicenseDetailsToolStripMenuItem
			// 
			this.showLicenseDetailsToolStripMenuItem.Image = global::MyDVLD_Presentation.Properties.Resources.License_View_32;
			this.showLicenseDetailsToolStripMenuItem.Name = "showLicenseDetailsToolStripMenuItem";
			this.showLicenseDetailsToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
			this.showLicenseDetailsToolStripMenuItem.Text = "Show License Details";
			this.showLicenseDetailsToolStripMenuItem.Click += new System.EventHandler(this.showLicenseDetailsToolStripMenuItem_Click);
			// 
			// showLicenseHistoryToolStripMenuItem
			// 
			this.showLicenseHistoryToolStripMenuItem.Image = global::MyDVLD_Presentation.Properties.Resources.PersonLicenseHistory_32;
			this.showLicenseHistoryToolStripMenuItem.Name = "showLicenseHistoryToolStripMenuItem";
			this.showLicenseHistoryToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
			this.showLicenseHistoryToolStripMenuItem.Text = "Show License History";
			this.showLicenseHistoryToolStripMenuItem.Click += new System.EventHandler(this.showLicenseHistoryToolStripMenuItem_Click);
			// 
			// releaseLicenseToolStripMenuItem
			// 
			this.releaseLicenseToolStripMenuItem.Image = global::MyDVLD_Presentation.Properties.Resources.Release_Detained_License_64;
			this.releaseLicenseToolStripMenuItem.Name = "releaseLicenseToolStripMenuItem";
			this.releaseLicenseToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
			this.releaseLicenseToolStripMenuItem.Text = "Release License";
			this.releaseLicenseToolStripMenuItem.Click += new System.EventHandler(this.releaseLicenseToolStripMenuItem_Click);
			// 
			// FrmManageDetainedLicenses
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(874, 483);
			this.Controls.Add(this.btnDetain);
			this.Controls.Add(this.btnRelease);
			this.Controls.Add(this.cbReleased);
			this.Controls.Add(this.lblCount);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.dgDetainedLicenses);
			this.Controls.Add(this.txtFilterBy);
			this.Controls.Add(this.cbFilterBy);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FrmManageDetainedLicenses";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Manage Detained Licenses";
			this.Load += new System.EventHandler(this.FrmManageDetainedLicenses_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgDetainedLicenses)).EndInit();
			this.contextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cbFilterBy;
		private System.Windows.Forms.TextBox txtFilterBy;
		private System.Windows.Forms.DataGridView dgDetainedLicenses;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lblCount;
		private System.Windows.Forms.ComboBox cbReleased;
		private System.Windows.Forms.Button btnRelease;
		private System.Windows.Forms.Button btnDetain;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem showLicenseDetailsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem showLicenseHistoryToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem releaseLicenseToolStripMenuItem;
	}
}