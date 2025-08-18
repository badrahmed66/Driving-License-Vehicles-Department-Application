namespace MyDVLD_Presentation.Users
{
    partial class FrmAddUser
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
            this.lblUserFormTitle = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnPervious = new System.Windows.Forms.Button();
            this.tpLogInfo = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblUserID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.chbIsActive = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.tpUserInfo = new System.Windows.Forms.TabPage();
            this.ctrShowPersonDetailsWithFilter1 = new MyDVLD_Presentation.UserControls.ctrShowPersonDetailsWithFilter();
            this.tbUser = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tpLogInfo.SuspendLayout();
            this.tpUserInfo.SuspendLayout();
            this.tbUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUserFormTitle
            // 
            this.lblUserFormTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserFormTitle.ForeColor = System.Drawing.Color.Red;
            this.lblUserFormTitle.Location = new System.Drawing.Point(285, 9);
            this.lblUserFormTitle.Name = "lblUserFormTitle";
            this.lblUserFormTitle.Size = new System.Drawing.Size(230, 34);
            this.lblUserFormTitle.TabIndex = 0;
            this.lblUserFormTitle.Text = "Add New User";
            this.lblUserFormTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNext
            // 
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Image = global::MyDVLD_Presentation.Properties.Resources.Next_32;
            this.btnNext.Location = new System.Drawing.Point(693, 521);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(91, 43);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "Next";
            this.btnNext.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = global::MyDVLD_Presentation.Properties.Resources.Save_32;
            this.btnSave.Location = new System.Drawing.Point(408, 522);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(91, 43);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::MyDVLD_Presentation.Properties.Resources.Close_32;
            this.btnClose.Location = new System.Drawing.Point(295, 522);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(91, 43);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnPervious
            // 
            this.btnPervious.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPervious.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPervious.Image = global::MyDVLD_Presentation.Properties.Resources.Next_32;
            this.btnPervious.Location = new System.Drawing.Point(12, 523);
            this.btnPervious.Name = "btnPervious";
            this.btnPervious.Size = new System.Drawing.Size(112, 43);
            this.btnPervious.TabIndex = 4;
            this.btnPervious.Text = "Pervious";
            this.btnPervious.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPervious.UseVisualStyleBackColor = true;
            this.btnPervious.Click += new System.EventHandler(this.btnPervios_Click);
            // 
            // tpLogInfo
            // 
            this.tpLogInfo.Controls.Add(this.txtConfirmPassword);
            this.tpLogInfo.Controls.Add(this.txtPassword);
            this.tpLogInfo.Controls.Add(this.txtUserName);
            this.tpLogInfo.Controls.Add(this.label5);
            this.tpLogInfo.Controls.Add(this.chbIsActive);
            this.tpLogInfo.Controls.Add(this.label4);
            this.tpLogInfo.Controls.Add(this.label3);
            this.tpLogInfo.Controls.Add(this.lblUserID);
            this.tpLogInfo.Controls.Add(this.label2);
            this.tpLogInfo.Controls.Add(this.label1);
            this.tpLogInfo.Location = new System.Drawing.Point(4, 22);
            this.tpLogInfo.Name = "tpLogInfo";
            this.tpLogInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpLogInfo.Size = new System.Drawing.Size(769, 435);
            this.tpLogInfo.TabIndex = 1;
            this.tpLogInfo.Text = "Log Info";
            this.tpLogInfo.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(292, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login Details";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(200, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "User ID :";
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserID.Location = new System.Drawing.Point(274, 104);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(27, 20);
            this.lblUserID.TabIndex = 2;
            this.lblUserID.Text = "??";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(175, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "User Name :";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(278, 156);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(166, 20);
            this.txtUserName.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(186, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Password :";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(278, 210);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(166, 20);
            this.txtPassword.TabIndex = 6;
            // 
            // chbIsActive
            // 
            this.chbIsActive.AutoSize = true;
            this.chbIsActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbIsActive.Location = new System.Drawing.Point(278, 312);
            this.chbIsActive.Name = "chbIsActive";
            this.chbIsActive.Size = new System.Drawing.Size(88, 24);
            this.chbIsActive.TabIndex = 9;
            this.chbIsActive.Text = "Is Active";
            this.chbIsActive.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(127, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Confirm Password :";
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Location = new System.Drawing.Point(278, 260);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '*';
            this.txtConfirmPassword.Size = new System.Drawing.Size(166, 20);
            this.txtConfirmPassword.TabIndex = 11;
            // 
            // tpUserInfo
            // 
            this.tpUserInfo.Controls.Add(this.ctrShowPersonDetailsWithFilter1);
            this.tpUserInfo.Location = new System.Drawing.Point(4, 22);
            this.tpUserInfo.Name = "tpUserInfo";
            this.tpUserInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpUserInfo.Size = new System.Drawing.Size(769, 435);
            this.tpUserInfo.TabIndex = 0;
            this.tpUserInfo.Text = "Personal Info";
            this.tpUserInfo.UseVisualStyleBackColor = true;
            // 
            // ctrShowPersonDetailsWithFilter1
            // 
            this.ctrShowPersonDetailsWithFilter1.AddNewPersonButton = false;
            this.ctrShowPersonDetailsWithFilter1.GroupFilter = true;
            this.ctrShowPersonDetailsWithFilter1.Location = new System.Drawing.Point(3, 6);
            this.ctrShowPersonDetailsWithFilter1.Name = "ctrShowPersonDetailsWithFilter1";
            this.ctrShowPersonDetailsWithFilter1.Size = new System.Drawing.Size(765, 433);
            this.ctrShowPersonDetailsWithFilter1.TabIndex = 0;
            // 
            // tbUser
            // 
            this.tbUser.Controls.Add(this.tpUserInfo);
            this.tbUser.Controls.Add(this.tpLogInfo);
            this.tbUser.Location = new System.Drawing.Point(12, 54);
            this.tbUser.Name = "tbUser";
            this.tbUser.SelectedIndex = 0;
            this.tbUser.Size = new System.Drawing.Size(777, 461);
            this.tbUser.TabIndex = 1;
            // 
            // FrmAddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(801, 575);
            this.Controls.Add(this.btnPervious);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbUser);
            this.Controls.Add(this.lblUserFormTitle);
            this.Name = "FrmAddUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAddUser";
            this.Load += new System.EventHandler(this.FrmAddUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tpLogInfo.ResumeLayout(false);
            this.tpLogInfo.PerformLayout();
            this.tpUserInfo.ResumeLayout(false);
            this.tbUser.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblUserFormTitle;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnPervious;
        private System.Windows.Forms.TabControl tbUser;
        private System.Windows.Forms.TabPage tpUserInfo;
        private UserControls.ctrShowPersonDetailsWithFilter ctrShowPersonDetailsWithFilter1;
        private System.Windows.Forms.TabPage tpLogInfo;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chbIsActive;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}