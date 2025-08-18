using System;
using MyDVLD_BLL;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MyDVLD_DTO.User;

namespace MyDVLD_Presentation.Users
{
    public partial class FrmLoginScreen : Form
    {
        private ServicesContainer _container;
        public FrmLoginScreen(ServicesContainer container)
        {
            InitializeComponent();
            _container = container;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string errorMessage = "";

            if (UserAuthenticationService.Login(txtUserName.Text.Trim(), txtPassword.Text.Trim(), out errorMessage))
            {
                if (chbRememberMe.Checked)
                {
                    Properties.Settings.Default.LastUserName = txtUserName.Text.Trim();
                    Properties.Settings.Default.Save();
                }
                else
                {
                    Properties.Settings.Default.LastUserName = string.Empty;
                    Properties.Settings.Default.Save();
                }


                this.Hide();
                // move on the main form of the program
                FrmMain frm = new FrmMain(_container);
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show(errorMessage,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Clear();
                txtPassword.Focus();
            }
        }

        private void FrmLoginScreen_Load(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(Properties.Settings.Default.LastUserName))
            {
                txtUserName.Text = Properties.Settings.Default.LastUserName;
                chbRememberMe.Checked = true;
            }
            else
            {
                txtUserName.Clear();
                chbRememberMe.Checked = false;
            }
        }
    }
}
