namespace MyDVLD_Presentation.AllApplications.Tests
{
	partial class FrmScheduleTest
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
			this.btnClose = new System.Windows.Forms.Button();
			this.ctrScheduleTest1 = new MyDVLD_Presentation.AllApplications.ctrScheduleTest();
			this.SuspendLayout();
			// 
			// btnClose
			// 
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnClose.Image = global::MyDVLD_Presentation.Properties.Resources.Close_32;
			this.btnClose.Location = new System.Drawing.Point(209, 603);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(104, 38);
			this.btnClose.TabIndex = 23;
			this.btnClose.Text = "Close";
			this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// ctrScheduleTest1
			// 
			this.ctrScheduleTest1.Location = new System.Drawing.Point(2, 3);
			this.ctrScheduleTest1.Name = "ctrScheduleTest1";
			this.ctrScheduleTest1.Size = new System.Drawing.Size(526, 594);
			this.ctrScheduleTest1.TabIndex = 0;
			this.ctrScheduleTest1.TestType = MyDVLD_DTO.TestTypeDTO.EnTestType.Practical;
			this.ctrScheduleTest1.Load += new System.EventHandler(this.ctrScheduleTest1_Load);
			// 
			// FrmScheduleTest
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(525, 650);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.ctrScheduleTest1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "FrmScheduleTest";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FrmScheduleTest";
			this.ResumeLayout(false);

		}

		#endregion

		private ctrScheduleTest ctrScheduleTest1;
		private System.Windows.Forms.Button btnClose;
	}
}