namespace MyDVLD_Presentation.AllApplications.Tests
{
	partial class FrmTakeTest
	{

		#region Windows Form Designer generated code
		private void InitializeComponent()
		{
			this.rbPass = new System.Windows.Forms.RadioButton();
			this.rbFail = new System.Windows.Forms.RadioButton();
			this.lblMessage = new System.Windows.Forms.Label();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.txtNotes = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.ctrScheduledTest1 = new MyDVLD_Presentation.AllApplications.Tests.ctrScheduledTest();
			this.SuspendLayout();
			// 
			// rbPass
			// 
			this.rbPass.AutoSize = true;
			this.rbPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbPass.Location = new System.Drawing.Point(109, 432);
			this.rbPass.Name = "rbPass";
			this.rbPass.Size = new System.Drawing.Size(57, 21);
			this.rbPass.TabIndex = 2;
			this.rbPass.TabStop = true;
			this.rbPass.Text = "Pass";
			this.rbPass.UseVisualStyleBackColor = true;
			// 
			// rbFail
			// 
			this.rbFail.AutoSize = true;
			this.rbFail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbFail.Location = new System.Drawing.Point(191, 434);
			this.rbFail.Name = "rbFail";
			this.rbFail.Size = new System.Drawing.Size(48, 21);
			this.rbFail.TabIndex = 3;
			this.rbFail.TabStop = true;
			this.rbFail.Text = "Fail";
			this.rbFail.UseVisualStyleBackColor = true;
			// 
			// lblMessage
			// 
			this.lblMessage.AutoSize = true;
			this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMessage.ForeColor = System.Drawing.Color.Red;
			this.lblMessage.Location = new System.Drawing.Point(275, 436);
			this.lblMessage.Name = "lblMessage";
			this.lblMessage.Size = new System.Drawing.Size(187, 17);
			this.lblMessage.TabIndex = 4;
			this.lblMessage.Text = "you Can\'t Change Result";
			this.lblMessage.Visible = false;
			// 
			// btnSave
			// 
			this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSave.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnSave.Image = global::MyDVLD_Presentation.Properties.Resources.Save_32;
			this.btnSave.Location = new System.Drawing.Point(368, 544);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(94, 40);
			this.btnSave.TabIndex = 5;
			this.btnSave.Text = "Save";
			this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnClose
			// 
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnClose.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnClose.Image = global::MyDVLD_Presentation.Properties.Resources.Save_32;
			this.btnClose.Location = new System.Drawing.Point(268, 544);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(94, 40);
			this.btnClose.TabIndex = 6;
			this.btnClose.Text = "Close";
			this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(22, 470);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(66, 20);
			this.label3.TabIndex = 7;
			this.label3.Text = "Notes :";
			// 
			// txtNotes
			// 
			this.txtNotes.Location = new System.Drawing.Point(109, 472);
			this.txtNotes.Multiline = true;
			this.txtNotes.Name = "txtNotes";
			this.txtNotes.Size = new System.Drawing.Size(353, 66);
			this.txtNotes.TabIndex = 8;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(17, 432);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(71, 20);
			this.label1.TabIndex = 1;
			this.label1.Text = "Result :";
			// 
			// ctrScheduledTest1
			// 
			this.ctrScheduledTest1.Location = new System.Drawing.Point(2, 3);
			this.ctrScheduledTest1.Name = "ctrScheduledTest1";
			this.ctrScheduledTest1.Size = new System.Drawing.Size(460, 423);
			this.ctrScheduledTest1.TabIndex = 0;
			this.ctrScheduledTest1.TestType = MyDVLD_DTO.TestTypeDTO.EnTestType.Vision;
			// 
			// FrmTakeTest
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(474, 595);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtNotes);
			this.Controls.Add(this.rbFail);
			this.Controls.Add(this.lblMessage);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.ctrScheduledTest1);
			this.Controls.Add(this.rbPass);
			this.Name = "FrmTakeTest";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FrmScheduledTest";
			this.Load += new System.EventHandler(this.FrmScheduledTest_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblMessage;
		private ctrScheduledTest ctrScheduledTest1;
		private System.Windows.Forms.RadioButton rbPass;
		private System.Windows.Forms.RadioButton rbFail;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtNotes;
		private System.Windows.Forms.Label label1;
	}
}