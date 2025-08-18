namespace MyDVLD_Presentation.AllApplications.Tests
{
	partial class FrmListTestAppointments
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
			this.lblAppointment = new System.Windows.Forms.Label();
			this.dgvTestAppointments = new System.Windows.Forms.DataGridView();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.takeTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.lblRecords = new System.Windows.Forms.Label();
			this.btnClose = new System.Windows.Forms.Button();
			this.btnAddNewAppointment = new System.Windows.Forms.Button();
			this.pbAppointment = new System.Windows.Forms.PictureBox();
			this.ctrLocalDrivingLicenseApplicationInfo1 = new MyDVLD_Presentation.AllApplications.ctrLocalDrivingLicenseApplicationInfo();
			((System.ComponentModel.ISupportInitialize)(this.dgvTestAppointments)).BeginInit();
			this.contextMenuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbAppointment)).BeginInit();
			this.SuspendLayout();
			// 
			// lblAppointment
			// 
			this.lblAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblAppointment.ForeColor = System.Drawing.Color.Red;
			this.lblAppointment.Location = new System.Drawing.Point(289, 84);
			this.lblAppointment.Name = "lblAppointment";
			this.lblAppointment.Size = new System.Drawing.Size(266, 33);
			this.lblAppointment.TabIndex = 2;
			this.lblAppointment.Text = "Vision Test Appointment";
			this.lblAppointment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// dgvTestAppointments
			// 
			this.dgvTestAppointments.AllowUserToAddRows = false;
			this.dgvTestAppointments.AllowUserToDeleteRows = false;
			this.dgvTestAppointments.AllowUserToOrderColumns = true;
			this.dgvTestAppointments.AllowUserToResizeRows = false;
			this.dgvTestAppointments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvTestAppointments.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
			this.dgvTestAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvTestAppointments.ContextMenuStrip = this.contextMenuStrip1;
			this.dgvTestAppointments.Location = new System.Drawing.Point(7, 471);
			this.dgvTestAppointments.Name = "dgvTestAppointments";
			this.dgvTestAppointments.ReadOnly = true;
			this.dgvTestAppointments.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dgvTestAppointments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvTestAppointments.Size = new System.Drawing.Size(834, 120);
			this.dgvTestAppointments.TabIndex = 3;
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.takeTestToolStripMenuItem});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(181, 70);
			// 
			// editToolStripMenuItem
			// 
			this.editToolStripMenuItem.Image = global::MyDVLD_Presentation.Properties.Resources.edit_32;
			this.editToolStripMenuItem.Name = "editToolStripMenuItem";
			this.editToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.editToolStripMenuItem.Text = "Edit";
			this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
			// 
			// takeTestToolStripMenuItem
			// 
			this.takeTestToolStripMenuItem.Image = global::MyDVLD_Presentation.Properties.Resources.Test_32;
			this.takeTestToolStripMenuItem.Name = "takeTestToolStripMenuItem";
			this.takeTestToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.takeTestToolStripMenuItem.Text = "Take Test";
			this.takeTestToolStripMenuItem.Click += new System.EventHandler(this.takeTestToolStripMenuItem_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 436);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(125, 20);
			this.label1.TabIndex = 136;
			this.label1.Text = "Appointments:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(12, 597);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(86, 20);
			this.label2.TabIndex = 139;
			this.label2.Text = "Records :";
			// 
			// lblRecords
			// 
			this.lblRecords.AutoSize = true;
			this.lblRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRecords.Location = new System.Drawing.Point(104, 597);
			this.lblRecords.Name = "lblRecords";
			this.lblRecords.Size = new System.Drawing.Size(29, 20);
			this.lblRecords.TabIndex = 140;
			this.lblRecords.Text = "??";
			// 
			// btnClose
			// 
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnClose.Image = global::MyDVLD_Presentation.Properties.Resources.Close_32;
			this.btnClose.Location = new System.Drawing.Point(727, 597);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(114, 38);
			this.btnClose.TabIndex = 141;
			this.btnClose.Text = "Close";
			this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// btnAddNewAppointment
			// 
			this.btnAddNewAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAddNewAppointment.Image = global::MyDVLD_Presentation.Properties.Resources.AddAppointment_32;
			this.btnAddNewAppointment.Location = new System.Drawing.Point(784, 429);
			this.btnAddNewAppointment.Name = "btnAddNewAppointment";
			this.btnAddNewAppointment.Size = new System.Drawing.Size(49, 36);
			this.btnAddNewAppointment.TabIndex = 138;
			this.btnAddNewAppointment.UseVisualStyleBackColor = true;
			this.btnAddNewAppointment.Click += new System.EventHandler(this.btnAddNewAppointment_Click);
			// 
			// pbAppointment
			// 
			this.pbAppointment.Image = global::MyDVLD_Presentation.Properties.Resources.Vision_512;
			this.pbAppointment.Location = new System.Drawing.Point(361, 12);
			this.pbAppointment.Name = "pbAppointment";
			this.pbAppointment.Size = new System.Drawing.Size(123, 69);
			this.pbAppointment.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbAppointment.TabIndex = 1;
			this.pbAppointment.TabStop = false;
			// 
			// ctrLocalDrivingLicenseApplicationInfo1
			// 
			this.ctrLocalDrivingLicenseApplicationInfo1.Location = new System.Drawing.Point(3, 120);
			this.ctrLocalDrivingLicenseApplicationInfo1.Name = "ctrLocalDrivingLicenseApplicationInfo1";
			this.ctrLocalDrivingLicenseApplicationInfo1.PassedTests = ((byte)(0));
			this.ctrLocalDrivingLicenseApplicationInfo1.Size = new System.Drawing.Size(838, 313);
			this.ctrLocalDrivingLicenseApplicationInfo1.TabIndex = 0;
			// 
			// FrmListTestAppointments
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(845, 640);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.lblRecords);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnAddNewAppointment);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dgvTestAppointments);
			this.Controls.Add(this.lblAppointment);
			this.Controls.Add(this.pbAppointment);
			this.Controls.Add(this.ctrLocalDrivingLicenseApplicationInfo1);
			this.Name = "FrmListTestAppointments";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Test Appointments";
			this.Load += new System.EventHandler(this.FrmListTestAppointments_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvTestAppointments)).EndInit();
			this.contextMenuStrip1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pbAppointment)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private ctrLocalDrivingLicenseApplicationInfo ctrLocalDrivingLicenseApplicationInfo1;
		private System.Windows.Forms.PictureBox pbAppointment;
		private System.Windows.Forms.Label lblAppointment;
		private System.Windows.Forms.DataGridView dgvTestAppointments;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnAddNewAppointment;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblRecords;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem takeTestToolStripMenuItem;
	}
}