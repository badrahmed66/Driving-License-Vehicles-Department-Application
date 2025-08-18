namespace MyDVLD_Presentation.AllApplications.LocalDrivingApp
{
    partial class FrmManageApplications
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
			this.label2 = new System.Windows.Forms.Label();
			this.cbFilterBy = new System.Windows.Forms.ComboBox();
			this.dgvApplications = new System.Windows.Forms.DataGridView();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.showApplicationInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.editApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.deleteApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.cancelApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.scheduleTestsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmScheduleVisionTest = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmScheduleTheoryTest = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmSchedulPracticalTest = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.issueDrivingLicenseFirstTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.showLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.showPersonLIcenseHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.label3 = new System.Windows.Forms.Label();
			this.lblCount = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtFilterValue = new System.Windows.Forms.TextBox();
			this.btnAddNewApp = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.dgvApplications)).BeginInit();
			this.contextMenuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(12, 169);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(85, 20);
			this.label2.TabIndex = 2;
			this.label2.Text = "Filter By :";
			// 
			// cbFilterBy
			// 
			this.cbFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbFilterBy.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cbFilterBy.FormattingEnabled = true;
			this.cbFilterBy.Location = new System.Drawing.Point(103, 168);
			this.cbFilterBy.Name = "cbFilterBy";
			this.cbFilterBy.Size = new System.Drawing.Size(148, 21);
			this.cbFilterBy.TabIndex = 3;
			this.cbFilterBy.SelectedIndexChanged += new System.EventHandler(this.cbFilterBy_SelectedIndexChanged);
			// 
			// dgvApplications
			// 
			this.dgvApplications.AllowUserToAddRows = false;
			this.dgvApplications.AllowUserToDeleteRows = false;
			this.dgvApplications.AllowUserToOrderColumns = true;
			this.dgvApplications.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvApplications.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dgvApplications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvApplications.ContextMenuStrip = this.contextMenuStrip1;
			this.dgvApplications.GridColor = System.Drawing.SystemColors.ControlLightLight;
			this.dgvApplications.Location = new System.Drawing.Point(11, 195);
			this.dgvApplications.Name = "dgvApplications";
			this.dgvApplications.ReadOnly = true;
			this.dgvApplications.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvApplications.Size = new System.Drawing.Size(900, 248);
			this.dgvApplications.TabIndex = 4;
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showApplicationInfoToolStripMenuItem,
            this.toolStripSeparator1,
            this.editApplicationToolStripMenuItem,
            this.deleteApplicationToolStripMenuItem,
            this.toolStripSeparator2,
            this.cancelApplicationToolStripMenuItem,
            this.scheduleTestsToolStripMenuItem,
            this.toolStripSeparator3,
            this.issueDrivingLicenseFirstTimeToolStripMenuItem,
            this.showLicenseToolStripMenuItem,
            this.showPersonLIcenseHistoryToolStripMenuItem});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(246, 198);
			this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
			// 
			// showApplicationInfoToolStripMenuItem
			// 
			this.showApplicationInfoToolStripMenuItem.Image = global::MyDVLD_Presentation.Properties.Resources.PersonDetails_32;
			this.showApplicationInfoToolStripMenuItem.Name = "showApplicationInfoToolStripMenuItem";
			this.showApplicationInfoToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
			this.showApplicationInfoToolStripMenuItem.Text = "Show Application Info";
			this.showApplicationInfoToolStripMenuItem.Click += new System.EventHandler(this.showApplicationInfoToolStripMenuItem_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(242, 6);
			// 
			// editApplicationToolStripMenuItem
			// 
			this.editApplicationToolStripMenuItem.Image = global::MyDVLD_Presentation.Properties.Resources.edit_32;
			this.editApplicationToolStripMenuItem.Name = "editApplicationToolStripMenuItem";
			this.editApplicationToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
			this.editApplicationToolStripMenuItem.Text = "Edit Application";
			this.editApplicationToolStripMenuItem.Click += new System.EventHandler(this.editApplicationToolStripMenuItem_Click);
			// 
			// deleteApplicationToolStripMenuItem
			// 
			this.deleteApplicationToolStripMenuItem.Image = global::MyDVLD_Presentation.Properties.Resources.Delete_32_2;
			this.deleteApplicationToolStripMenuItem.Name = "deleteApplicationToolStripMenuItem";
			this.deleteApplicationToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
			this.deleteApplicationToolStripMenuItem.Text = "Delete Application";
			this.deleteApplicationToolStripMenuItem.Click += new System.EventHandler(this.deleteApplicationToolStripMenuItem_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(242, 6);
			// 
			// cancelApplicationToolStripMenuItem
			// 
			this.cancelApplicationToolStripMenuItem.Image = global::MyDVLD_Presentation.Properties.Resources.Delete_32;
			this.cancelApplicationToolStripMenuItem.Name = "cancelApplicationToolStripMenuItem";
			this.cancelApplicationToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
			this.cancelApplicationToolStripMenuItem.Text = "Cancel Application";
			this.cancelApplicationToolStripMenuItem.Click += new System.EventHandler(this.cancelApplicationToolStripMenuItem_Click);
			// 
			// scheduleTestsToolStripMenuItem
			// 
			this.scheduleTestsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmScheduleVisionTest,
            this.tsmScheduleTheoryTest,
            this.tsmSchedulPracticalTest});
			this.scheduleTestsToolStripMenuItem.Image = global::MyDVLD_Presentation.Properties.Resources.TestType_32;
			this.scheduleTestsToolStripMenuItem.Name = "scheduleTestsToolStripMenuItem";
			this.scheduleTestsToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
			this.scheduleTestsToolStripMenuItem.Text = "Schedule Tests";
			// 
			// tsmScheduleVisionTest
			// 
			this.tsmScheduleVisionTest.Image = global::MyDVLD_Presentation.Properties.Resources.Vision_Test_32;
			this.tsmScheduleVisionTest.Name = "tsmScheduleVisionTest";
			this.tsmScheduleVisionTest.Size = new System.Drawing.Size(193, 22);
			this.tsmScheduleVisionTest.Text = "Schedule Vision Test";
			this.tsmScheduleVisionTest.Click += new System.EventHandler(this.tsmScheduleVisionTest_Click);
			// 
			// tsmScheduleTheoryTest
			// 
			this.tsmScheduleTheoryTest.Image = global::MyDVLD_Presentation.Properties.Resources.Written_Test_32_Sechdule;
			this.tsmScheduleTheoryTest.Name = "tsmScheduleTheoryTest";
			this.tsmScheduleTheoryTest.Size = new System.Drawing.Size(193, 22);
			this.tsmScheduleTheoryTest.Text = "Schedule Theory Test";
			this.tsmScheduleTheoryTest.Click += new System.EventHandler(this.tsmScheduleTheoryTest_Click);
			// 
			// tsmSchedulPracticalTest
			// 
			this.tsmSchedulPracticalTest.Image = global::MyDVLD_Presentation.Properties.Resources.Street_Test_32;
			this.tsmSchedulPracticalTest.Name = "tsmSchedulPracticalTest";
			this.tsmSchedulPracticalTest.Size = new System.Drawing.Size(193, 22);
			this.tsmSchedulPracticalTest.Text = "Schedule Practical Test";
			this.tsmSchedulPracticalTest.Click += new System.EventHandler(this.tsmSchedulPracticalTest_Click);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(242, 6);
			// 
			// issueDrivingLicenseFirstTimeToolStripMenuItem
			// 
			this.issueDrivingLicenseFirstTimeToolStripMenuItem.Image = global::MyDVLD_Presentation.Properties.Resources.IssueDrivingLicense_32;
			this.issueDrivingLicenseFirstTimeToolStripMenuItem.Name = "issueDrivingLicenseFirstTimeToolStripMenuItem";
			this.issueDrivingLicenseFirstTimeToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
			this.issueDrivingLicenseFirstTimeToolStripMenuItem.Text = "Issue Driving License (First Time)";
			this.issueDrivingLicenseFirstTimeToolStripMenuItem.Click += new System.EventHandler(this.issueDrivingLicenseFirstTimeToolStripMenuItem_Click);
			// 
			// showLicenseToolStripMenuItem
			// 
			this.showLicenseToolStripMenuItem.Image = global::MyDVLD_Presentation.Properties.Resources.License_View_32;
			this.showLicenseToolStripMenuItem.Name = "showLicenseToolStripMenuItem";
			this.showLicenseToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
			this.showLicenseToolStripMenuItem.Text = "Show License";
			this.showLicenseToolStripMenuItem.Click += new System.EventHandler(this.showLicenseToolStripMenuItem_Click);
			// 
			// showPersonLIcenseHistoryToolStripMenuItem
			// 
			this.showPersonLIcenseHistoryToolStripMenuItem.Image = global::MyDVLD_Presentation.Properties.Resources.PersonLicenseHistory_32;
			this.showPersonLIcenseHistoryToolStripMenuItem.Name = "showPersonLIcenseHistoryToolStripMenuItem";
			this.showPersonLIcenseHistoryToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
			this.showPersonLIcenseHistoryToolStripMenuItem.Text = "Show Person LIcense History";
			this.showPersonLIcenseHistoryToolStripMenuItem.Click += new System.EventHandler(this.showPersonLIcenseHistoryToolStripMenuItem_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(12, 465);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(86, 20);
			this.label3.TabIndex = 5;
			this.label3.Text = "Records :";
			// 
			// lblCount
			// 
			this.lblCount.AutoSize = true;
			this.lblCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCount.ForeColor = System.Drawing.Color.DodgerBlue;
			this.lblCount.Location = new System.Drawing.Point(104, 465);
			this.lblCount.Name = "lblCount";
			this.lblCount.Size = new System.Drawing.Size(29, 20);
			this.lblCount.TabIndex = 6;
			this.lblCount.Text = "??";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Red;
			this.label1.Location = new System.Drawing.Point(284, 113);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(355, 40);
			this.label1.TabIndex = 1;
			this.label1.Text = "Local Driving License Applications";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtFilterValue
			// 
			this.txtFilterValue.Location = new System.Drawing.Point(257, 168);
			this.txtFilterValue.Name = "txtFilterValue";
			this.txtFilterValue.Size = new System.Drawing.Size(168, 20);
			this.txtFilterValue.TabIndex = 10;
			this.txtFilterValue.TextChanged += new System.EventHandler(this.txtFilterValue_TextChanged);
			// 
			// btnAddNewApp
			// 
			this.btnAddNewApp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnAddNewApp.Image = global::MyDVLD_Presentation.Properties.Resources.New_Application_64;
			this.btnAddNewApp.Location = new System.Drawing.Point(836, 113);
			this.btnAddNewApp.Name = "btnAddNewApp";
			this.btnAddNewApp.Size = new System.Drawing.Size(75, 76);
			this.btnAddNewApp.TabIndex = 8;
			this.btnAddNewApp.UseVisualStyleBackColor = true;
			this.btnAddNewApp.Click += new System.EventHandler(this.btnAddNewApp_Click);
			// 
			// btnClose
			// 
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnClose.Image = global::MyDVLD_Presentation.Properties.Resources.Close_32;
			this.btnClose.Location = new System.Drawing.Point(809, 462);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(102, 36);
			this.btnClose.TabIndex = 7;
			this.btnClose.Text = "Close";
			this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::MyDVLD_Presentation.Properties.Resources.Manage_Applications_641;
			this.pictureBox1.Location = new System.Drawing.Point(337, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(248, 98);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// FrmManageApplications
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(923, 511);
			this.Controls.Add(this.txtFilterValue);
			this.Controls.Add(this.btnAddNewApp);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.lblCount);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.dgvApplications);
			this.Controls.Add(this.cbFilterBy);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FrmManageApplications";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FrmManageApplications";
			this.Load += new System.EventHandler(this.FrmManageApplications_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvApplications)).EndInit();
			this.contextMenuStrip1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbFilterBy;
        private System.Windows.Forms.DataGridView dgvApplications;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAddNewApp;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFilterValue;
        private System.Windows.Forms.BindingSource bindingSource1;
		private System.Windows.Forms.ToolStripMenuItem showApplicationInfoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editApplicationToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem scheduleTestsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem tsmScheduleVisionTest;
		private System.Windows.Forms.ToolStripMenuItem tsmScheduleTheoryTest;
		private System.Windows.Forms.ToolStripMenuItem tsmSchedulPracticalTest;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem deleteApplicationToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem cancelApplicationToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem issueDrivingLicenseFirstTimeToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripMenuItem showLicenseToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem showPersonLIcenseHistoryToolStripMenuItem;
	}
}