namespace MyDVLD_Presentation.AllApplications.LocalDrivingApp
{
    partial class FrmAddAndEditLDLApplication
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
			this.lblMain = new System.Windows.Forms.Label();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tpPersonInfo = new System.Windows.Forms.TabPage();
			this.btnNext = new System.Windows.Forms.Button();
			this.tpApplicationInfo = new System.Windows.Forms.TabPage();
			this.lblCreatedByUser = new System.Windows.Forms.Label();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			this.label7 = new System.Windows.Forms.Label();
			this.lblFees = new System.Windows.Forms.Label();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.label6 = new System.Windows.Forms.Label();
			this.cbLicenseClass = new System.Windows.Forms.ComboBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.label5 = new System.Windows.Forms.Label();
			this.lblApplicationDate = new System.Windows.Forms.Label();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.label3 = new System.Windows.Forms.Label();
			this.lblLocalDrivingLicenseAppID = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.ctrShowPersonDetailsWithFilter1 = new MyDVLD_Presentation.UserControls.ctrShowPersonDetailsWithFilter();
			this.tabControl1.SuspendLayout();
			this.tpPersonInfo.SuspendLayout();
			this.tpApplicationInfo.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// lblMain
			// 
			this.lblMain.AutoSize = true;
			this.lblMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMain.ForeColor = System.Drawing.Color.Red;
			this.lblMain.Location = new System.Drawing.Point(165, 9);
			this.lblMain.Name = "lblMain";
			this.lblMain.Size = new System.Drawing.Size(634, 39);
			this.lblMain.TabIndex = 0;
			this.lblMain.Text = "New Local Driving License Application";
			this.lblMain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tpPersonInfo);
			this.tabControl1.Controls.Add(this.tpApplicationInfo);
			this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tabControl1.Location = new System.Drawing.Point(12, 69);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(913, 512);
			this.tabControl1.TabIndex = 1;
			// 
			// tpPersonInfo
			// 
			this.tpPersonInfo.Controls.Add(this.btnNext);
			this.tpPersonInfo.Controls.Add(this.ctrShowPersonDetailsWithFilter1);
			this.tpPersonInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tpPersonInfo.Location = new System.Drawing.Point(4, 29);
			this.tpPersonInfo.Name = "tpPersonInfo";
			this.tpPersonInfo.Padding = new System.Windows.Forms.Padding(3);
			this.tpPersonInfo.Size = new System.Drawing.Size(905, 479);
			this.tpPersonInfo.TabIndex = 0;
			this.tpPersonInfo.Text = "PersonService Info";
			this.tpPersonInfo.UseVisualStyleBackColor = true;
			// 
			// btnNext
			// 
			this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNext.Image = global::MyDVLD_Presentation.Properties.Resources.Next_32;
			this.btnNext.Location = new System.Drawing.Point(795, 430);
			this.btnNext.Name = "btnNext";
			this.btnNext.Size = new System.Drawing.Size(104, 40);
			this.btnNext.TabIndex = 1;
			this.btnNext.Text = "Next";
			this.btnNext.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnNext.UseVisualStyleBackColor = true;
			this.btnNext.Click += new System.EventHandler(this.button1_Click);
			// 
			// tpApplicationInfo
			// 
			this.tpApplicationInfo.Controls.Add(this.lblCreatedByUser);
			this.tpApplicationInfo.Controls.Add(this.pictureBox5);
			this.tpApplicationInfo.Controls.Add(this.label7);
			this.tpApplicationInfo.Controls.Add(this.lblFees);
			this.tpApplicationInfo.Controls.Add(this.pictureBox4);
			this.tpApplicationInfo.Controls.Add(this.label6);
			this.tpApplicationInfo.Controls.Add(this.cbLicenseClass);
			this.tpApplicationInfo.Controls.Add(this.pictureBox3);
			this.tpApplicationInfo.Controls.Add(this.label5);
			this.tpApplicationInfo.Controls.Add(this.lblApplicationDate);
			this.tpApplicationInfo.Controls.Add(this.pictureBox2);
			this.tpApplicationInfo.Controls.Add(this.label3);
			this.tpApplicationInfo.Controls.Add(this.lblLocalDrivingLicenseAppID);
			this.tpApplicationInfo.Controls.Add(this.pictureBox1);
			this.tpApplicationInfo.Controls.Add(this.label2);
			this.tpApplicationInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tpApplicationInfo.Location = new System.Drawing.Point(4, 29);
			this.tpApplicationInfo.Name = "tpApplicationInfo";
			this.tpApplicationInfo.Padding = new System.Windows.Forms.Padding(3);
			this.tpApplicationInfo.Size = new System.Drawing.Size(905, 479);
			this.tpApplicationInfo.TabIndex = 1;
			this.tpApplicationInfo.Text = "Application Info";
			this.tpApplicationInfo.UseVisualStyleBackColor = true;
			// 
			// lblCreatedByUser
			// 
			this.lblCreatedByUser.AutoSize = true;
			this.lblCreatedByUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCreatedByUser.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.lblCreatedByUser.Location = new System.Drawing.Point(384, 246);
			this.lblCreatedByUser.Name = "lblCreatedByUser";
			this.lblCreatedByUser.Size = new System.Drawing.Size(36, 25);
			this.lblCreatedByUser.TabIndex = 14;
			this.lblCreatedByUser.Text = "??";
			// 
			// pictureBox5
			// 
			this.pictureBox5.Image = global::MyDVLD_Presentation.Properties.Resources.User_32__2;
			this.pictureBox5.Location = new System.Drawing.Point(354, 246);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new System.Drawing.Size(24, 25);
			this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox5.TabIndex = 13;
			this.pictureBox5.TabStop = false;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(180, 246);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(167, 25);
			this.label7.TabIndex = 12;
			this.label7.Text = "Created By User :";
			// 
			// lblFees
			// 
			this.lblFees.AutoSize = true;
			this.lblFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblFees.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.lblFees.Location = new System.Drawing.Point(384, 203);
			this.lblFees.Name = "lblFees";
			this.lblFees.Size = new System.Drawing.Size(36, 25);
			this.lblFees.TabIndex = 11;
			this.lblFees.Text = "??";
			// 
			// pictureBox4
			// 
			this.pictureBox4.Image = global::MyDVLD_Presentation.Properties.Resources.money_32;
			this.pictureBox4.Location = new System.Drawing.Point(354, 203);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(24, 25);
			this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox4.TabIndex = 10;
			this.pictureBox4.TabStop = false;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(180, 203);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(168, 25);
			this.label6.TabIndex = 9;
			this.label6.Text = "Application Fees :";
			// 
			// cbLicenseClass
			// 
			this.cbLicenseClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbLicenseClass.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cbLicenseClass.FormattingEnabled = true;
			this.cbLicenseClass.Location = new System.Drawing.Point(389, 160);
			this.cbLicenseClass.Name = "cbLicenseClass";
			this.cbLicenseClass.Size = new System.Drawing.Size(311, 28);
			this.cbLicenseClass.TabIndex = 8;
			// 
			// pictureBox3
			// 
			this.pictureBox3.Image = global::MyDVLD_Presentation.Properties.Resources.LocalDriving_License;
			this.pictureBox3.Location = new System.Drawing.Point(354, 160);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(24, 25);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox3.TabIndex = 7;
			this.pictureBox3.TabStop = false;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(202, 160);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(146, 25);
			this.label5.TabIndex = 6;
			this.label5.Text = "License Class :";
			// 
			// lblApplicationDate
			// 
			this.lblApplicationDate.AutoSize = true;
			this.lblApplicationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblApplicationDate.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.lblApplicationDate.Location = new System.Drawing.Point(384, 117);
			this.lblApplicationDate.Name = "lblApplicationDate";
			this.lblApplicationDate.Size = new System.Drawing.Size(36, 25);
			this.lblApplicationDate.TabIndex = 5;
			this.lblApplicationDate.Text = "??";
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = global::MyDVLD_Presentation.Properties.Resources.Calendar_32;
			this.pictureBox2.Location = new System.Drawing.Point(354, 117);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(24, 25);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 4;
			this.pictureBox2.TabStop = false;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(183, 117);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(165, 25);
			this.label3.TabIndex = 3;
			this.label3.Text = "Application Date :";
			// 
			// lblLocalDrivingLicenseAppID
			// 
			this.lblLocalDrivingLicenseAppID.AutoSize = true;
			this.lblLocalDrivingLicenseAppID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLocalDrivingLicenseAppID.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.lblLocalDrivingLicenseAppID.Location = new System.Drawing.Point(384, 74);
			this.lblLocalDrivingLicenseAppID.Name = "lblLocalDrivingLicenseAppID";
			this.lblLocalDrivingLicenseAppID.Size = new System.Drawing.Size(36, 25);
			this.lblLocalDrivingLicenseAppID.TabIndex = 2;
			this.lblLocalDrivingLicenseAppID.Text = "??";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::MyDVLD_Presentation.Properties.Resources.Number_32;
			this.pictureBox1.Location = new System.Drawing.Point(354, 74);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(24, 25);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(75, 74);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(273, 25);
			this.label2.TabIndex = 0;
			this.label2.Text = "Local Driving License App ID :";
			// 
			// btnSave
			// 
			this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSave.Image = global::MyDVLD_Presentation.Properties.Resources.Save_32;
			this.btnSave.Location = new System.Drawing.Point(814, 583);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(104, 40);
			this.btnSave.TabIndex = 2;
			this.btnSave.Text = "Save";
			this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnClose
			// 
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnClose.Image = global::MyDVLD_Presentation.Properties.Resources.Close_32;
			this.btnClose.Location = new System.Drawing.Point(695, 583);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(104, 40);
			this.btnClose.TabIndex = 3;
			this.btnClose.Text = "Close";
			this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// ctrShowPersonDetailsWithFilter1
			// 
			this.ctrShowPersonDetailsWithFilter1.AddNewPersonButton = false;
			this.ctrShowPersonDetailsWithFilter1.GroupFilter = true;
			this.ctrShowPersonDetailsWithFilter1.Location = new System.Drawing.Point(8, 6);
			this.ctrShowPersonDetailsWithFilter1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.ctrShowPersonDetailsWithFilter1.Name = "ctrShowPersonDetailsWithFilter1";
			this.ctrShowPersonDetailsWithFilter1.Size = new System.Drawing.Size(894, 418);
			this.ctrShowPersonDetailsWithFilter1.TabIndex = 0;
			// 
			// FrmAddAndEditLDLApplication
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(927, 634);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.lblMain);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FrmAddAndEditLDLApplication";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FrmAddAndEditLDLApplication";
			this.Load += new System.EventHandler(this.FrmAddAndEditLDLApplication_Load);
			this.tabControl1.ResumeLayout(false);
			this.tpPersonInfo.ResumeLayout(false);
			this.tpApplicationInfo.ResumeLayout(false);
			this.tpApplicationInfo.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMain;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpPersonInfo;
        private System.Windows.Forms.TabPage tpApplicationInfo;
        private System.Windows.Forms.Button btnNext;
        private UserControls.ctrShowPersonDetailsWithFilter ctrShowPersonDetailsWithFilter1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblApplicationDate;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblLocalDrivingLicenseAppID;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCreatedByUser;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblFees;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbLicenseClass;
    }
}