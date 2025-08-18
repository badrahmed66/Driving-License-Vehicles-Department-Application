namespace MyDVLD_Presentation.Drivers
{
	partial class FrmManageDrivers
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
			this.dgDrivers = new System.Windows.Forms.DataGridView();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label2 = new System.Windows.Forms.Label();
			this.cbFilter = new System.Windows.Forms.ComboBox();
			this.txtFilter = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.lblRecords = new System.Windows.Forms.Label();
			this.btnClose = new System.Windows.Forms.Button();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.showPersonINFOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.showLicenseHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			((System.ComponentModel.ISupportInitialize)(this.dgDrivers)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.contextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Red;
			this.label1.Location = new System.Drawing.Point(291, 159);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(219, 31);
			this.label1.TabIndex = 1;
			this.label1.Text = "Manage Drivers";
			// 
			// dgDrivers
			// 
			this.dgDrivers.AllowUserToAddRows = false;
			this.dgDrivers.AllowUserToDeleteRows = false;
			this.dgDrivers.AllowUserToOrderColumns = true;
			this.dgDrivers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgDrivers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dgDrivers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgDrivers.ContextMenuStrip = this.contextMenuStrip1;
			this.dgDrivers.Location = new System.Drawing.Point(2, 239);
			this.dgDrivers.MultiSelect = false;
			this.dgDrivers.Name = "dgDrivers";
			this.dgDrivers.ReadOnly = true;
			this.dgDrivers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgDrivers.Size = new System.Drawing.Size(786, 188);
			this.dgDrivers.TabIndex = 2;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::MyDVLD_Presentation.Properties.Resources.Driver_Main;
			this.pictureBox1.Location = new System.Drawing.Point(262, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(277, 144);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(12, 203);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(74, 20);
			this.label2.TabIndex = 3;
			this.label2.Text = "Filter By :";
			// 
			// cbFilter
			// 
			this.cbFilter.FormattingEnabled = true;
			this.cbFilter.Location = new System.Drawing.Point(83, 205);
			this.cbFilter.Name = "cbFilter";
			this.cbFilter.Size = new System.Drawing.Size(129, 21);
			this.cbFilter.TabIndex = 4;
			this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
			// 
			// txtFilter
			// 
			this.txtFilter.Location = new System.Drawing.Point(218, 205);
			this.txtFilter.Name = "txtFilter";
			this.txtFilter.Size = new System.Drawing.Size(139, 20);
			this.txtFilter.TabIndex = 5;
			this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
			this.txtFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilter_KeyPress);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(12, 439);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(77, 20);
			this.label3.TabIndex = 6;
			this.label3.Text = "Records :";
			// 
			// lblRecords
			// 
			this.lblRecords.AutoSize = true;
			this.lblRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRecords.Location = new System.Drawing.Point(95, 439);
			this.lblRecords.Name = "lblRecords";
			this.lblRecords.Size = new System.Drawing.Size(36, 20);
			this.lblRecords.TabIndex = 7;
			this.lblRecords.Text = "???";
			// 
			// btnClose
			// 
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnClose.Image = global::MyDVLD_Presentation.Properties.Resources.Close_32;
			this.btnClose.Location = new System.Drawing.Point(689, 436);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(99, 43);
			this.btnClose.TabIndex = 8;
			this.btnClose.Text = "Close";
			this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showPersonINFOToolStripMenuItem,
            this.showLicenseHistoryToolStripMenuItem});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(187, 70);
			// 
			// showPersonINFOToolStripMenuItem
			// 
			this.showPersonINFOToolStripMenuItem.Image = global::MyDVLD_Presentation.Properties.Resources.PersonDetails_32;
			this.showPersonINFOToolStripMenuItem.Name = "showPersonINFOToolStripMenuItem";
			this.showPersonINFOToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
			this.showPersonINFOToolStripMenuItem.Text = "Show Person INFO";
			this.showPersonINFOToolStripMenuItem.Click += new System.EventHandler(this.showPersonINFOToolStripMenuItem_Click);
			// 
			// showLicenseHistoryToolStripMenuItem
			// 
			this.showLicenseHistoryToolStripMenuItem.Image = global::MyDVLD_Presentation.Properties.Resources.License_View_32;
			this.showLicenseHistoryToolStripMenuItem.Name = "showLicenseHistoryToolStripMenuItem";
			this.showLicenseHistoryToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
			this.showLicenseHistoryToolStripMenuItem.Text = "Show License History";
			this.showLicenseHistoryToolStripMenuItem.Click += new System.EventHandler(this.showLicenseHistoryToolStripMenuItem_Click);
			// 
			// FrmManageDrivers
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 491);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.lblRecords);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtFilter);
			this.Controls.Add(this.cbFilter);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.dgDrivers);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FrmManageDrivers";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Drivers";
			this.Load += new System.EventHandler(this.FrmManageDrivers_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgDrivers)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.contextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dgDrivers;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cbFilter;
		private System.Windows.Forms.TextBox txtFilter;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lblRecords;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem showPersonINFOToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem showLicenseHistoryToolStripMenuItem;
	}
}