namespace MyDVLD_Presentation.Drivers
{
	partial class ctrDriverLicenses
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tbLocalLicenses = new System.Windows.Forms.TabPage();
			this.lblCountLocal = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.dgLocalLicenses = new System.Windows.Forms.DataGridView();
			this.tbInternationalLicenses = new System.Windows.Forms.TabPage();
			this.lblInternationalCount = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.lblCountInternational = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.dgInternationalLicenses = new System.Windows.Forms.DataGridView();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.showLicenseINFOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.groupBox1.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tbLocalLicenses.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgLocalLicenses)).BeginInit();
			this.tbInternationalLicenses.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgInternationalLicenses)).BeginInit();
			this.contextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.tabControl1);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(3, 3);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(947, 236);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Driver Licenses";
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tbLocalLicenses);
			this.tabControl1.Controls.Add(this.tbInternationalLicenses);
			this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tabControl1.Location = new System.Drawing.Point(6, 25);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(935, 211);
			this.tabControl1.TabIndex = 0;
			// 
			// tbLocalLicenses
			// 
			this.tbLocalLicenses.Controls.Add(this.lblCountLocal);
			this.tbLocalLicenses.Controls.Add(this.label2);
			this.tbLocalLicenses.Controls.Add(this.label1);
			this.tbLocalLicenses.Controls.Add(this.dgLocalLicenses);
			this.tbLocalLicenses.Location = new System.Drawing.Point(4, 24);
			this.tbLocalLicenses.Name = "tbLocalLicenses";
			this.tbLocalLicenses.Padding = new System.Windows.Forms.Padding(3);
			this.tbLocalLicenses.Size = new System.Drawing.Size(927, 183);
			this.tbLocalLicenses.TabIndex = 0;
			this.tbLocalLicenses.Text = "Local";
			this.tbLocalLicenses.UseVisualStyleBackColor = true;
			// 
			// lblCountLocal
			// 
			this.lblCountLocal.AutoSize = true;
			this.lblCountLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCountLocal.Location = new System.Drawing.Point(94, 158);
			this.lblCountLocal.Name = "lblCountLocal";
			this.lblCountLocal.Size = new System.Drawing.Size(35, 18);
			this.lblCountLocal.TabIndex = 3;
			this.lblCountLocal.Text = "???";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(6, 158);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(82, 18);
			this.label2.TabIndex = 2;
			this.label2.Text = "Records :";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(6, 7);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(190, 18);
			this.label1.TabIndex = 1;
			this.label1.Text = "Local Licenses History :";
			// 
			// dgLocalLicenses
			// 
			this.dgLocalLicenses.AllowUserToAddRows = false;
			this.dgLocalLicenses.AllowUserToDeleteRows = false;
			this.dgLocalLicenses.AllowUserToOrderColumns = true;
			this.dgLocalLicenses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgLocalLicenses.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dgLocalLicenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgLocalLicenses.Location = new System.Drawing.Point(9, 28);
			this.dgLocalLicenses.Name = "dgLocalLicenses";
			this.dgLocalLicenses.ReadOnly = true;
			this.dgLocalLicenses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgLocalLicenses.Size = new System.Drawing.Size(912, 127);
			this.dgLocalLicenses.TabIndex = 0;
			// 
			// tbInternationalLicenses
			// 
			this.tbInternationalLicenses.Controls.Add(this.lblInternationalCount);
			this.tbInternationalLicenses.Controls.Add(this.label6);
			this.tbInternationalLicenses.Controls.Add(this.lblCountInternational);
			this.tbInternationalLicenses.Controls.Add(this.label4);
			this.tbInternationalLicenses.Controls.Add(this.label5);
			this.tbInternationalLicenses.Controls.Add(this.dgInternationalLicenses);
			this.tbInternationalLicenses.Location = new System.Drawing.Point(4, 24);
			this.tbInternationalLicenses.Name = "tbInternationalLicenses";
			this.tbInternationalLicenses.Padding = new System.Windows.Forms.Padding(3);
			this.tbInternationalLicenses.Size = new System.Drawing.Size(927, 183);
			this.tbInternationalLicenses.TabIndex = 1;
			this.tbInternationalLicenses.Text = "International ";
			this.tbInternationalLicenses.UseVisualStyleBackColor = true;
			// 
			// lblInternationalCount
			// 
			this.lblInternationalCount.AutoSize = true;
			this.lblInternationalCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblInternationalCount.Location = new System.Drawing.Point(94, 155);
			this.lblInternationalCount.Name = "lblInternationalCount";
			this.lblInternationalCount.Size = new System.Drawing.Size(35, 18);
			this.lblInternationalCount.TabIndex = 8;
			this.lblInternationalCount.Text = "???";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(6, 155);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(82, 18);
			this.label6.TabIndex = 7;
			this.label6.Text = "Records :";
			// 
			// lblCountInternational
			// 
			this.lblCountInternational.AutoSize = true;
			this.lblCountInternational.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCountInternational.Location = new System.Drawing.Point(94, 220);
			this.lblCountInternational.Name = "lblCountInternational";
			this.lblCountInternational.Size = new System.Drawing.Size(35, 18);
			this.lblCountInternational.TabIndex = 6;
			this.lblCountInternational.Text = "???";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(6, 220);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(82, 18);
			this.label4.TabIndex = 5;
			this.label4.Text = "Records :";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(6, 3);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(159, 15);
			this.label5.TabIndex = 4;
			this.label5.Text = "Local Licenses History :";
			// 
			// dgInternationalLicenses
			// 
			this.dgInternationalLicenses.AllowUserToAddRows = false;
			this.dgInternationalLicenses.AllowUserToDeleteRows = false;
			this.dgInternationalLicenses.AllowUserToOrderColumns = true;
			this.dgInternationalLicenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgInternationalLicenses.Location = new System.Drawing.Point(9, 24);
			this.dgInternationalLicenses.Name = "dgInternationalLicenses";
			this.dgInternationalLicenses.ReadOnly = true;
			this.dgInternationalLicenses.Size = new System.Drawing.Size(912, 128);
			this.dgInternationalLicenses.TabIndex = 1;
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showLicenseINFOToolStripMenuItem});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(176, 26);
			// 
			// showLicenseINFOToolStripMenuItem
			// 
			this.showLicenseINFOToolStripMenuItem.Image = global::MyDVLD_Presentation.Properties.Resources.License_View_32;
			this.showLicenseINFOToolStripMenuItem.Name = "showLicenseINFOToolStripMenuItem";
			this.showLicenseINFOToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
			this.showLicenseINFOToolStripMenuItem.Text = "Show License INFO";
			this.showLicenseINFOToolStripMenuItem.Click += new System.EventHandler(this.showLicenseINFOToolStripMenuItem_Click);
			// 
			// ctrDriverLicenses
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.groupBox1);
			this.Name = "ctrDriverLicenses";
			this.Size = new System.Drawing.Size(953, 242);
			this.groupBox1.ResumeLayout(false);
			this.tabControl1.ResumeLayout(false);
			this.tbLocalLicenses.ResumeLayout(false);
			this.tbLocalLicenses.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgLocalLicenses)).EndInit();
			this.tbInternationalLicenses.ResumeLayout(false);
			this.tbInternationalLicenses.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgInternationalLicenses)).EndInit();
			this.contextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tbLocalLicenses;
		private System.Windows.Forms.DataGridView dgLocalLicenses;
		private System.Windows.Forms.TabPage tbInternationalLicenses;
		private System.Windows.Forms.Label lblCountLocal;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblCountInternational;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.DataGridView dgInternationalLicenses;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem showLicenseINFOToolStripMenuItem;
		private System.Windows.Forms.Label lblInternationalCount;
		private System.Windows.Forms.Label label6;
	}
}
