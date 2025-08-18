using System;
using MyDVLD_DTO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyDVLD_BLL;
using System.Windows.Forms;

namespace MyDVLD_Presentation.Apps
{
    
    public partial class FrmEditAppInfo : Form
    {
        private ApplicationTypeDTO ApplicationType { get; set; }
        public enum ApplicationTypeMode { Add = 1 , Update = 2}
        public ApplicationTypeMode Mode { get; private set; }

        public FrmEditAppInfo(ApplicationTypeDTO dto , ApplicationTypeMode mode)
        {
            InitializeComponent();
            ApplicationType = dto;
            Mode = mode;
        }

        private void LoadFormByData()
        {
            

            lblID.Text = ApplicationType.ID.ToString();
            txtTitle.Text = ApplicationType.Title;
            txtFees.Text = ApplicationType.Fees.ToString();
        }
        private void FrmEditAppInfo_Load(object sender, EventArgs e)
        {
            if (Mode == ApplicationTypeMode.Update)
                LoadFormByData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool ValidationForm(out string errorMessage)
        {
            errorMessage = "";
            bool isValid = true;

            if (!this.ValidateChildren())
            {
                errorMessage = "There's an empty Text Box , please fill all the fields and try again";
                isValid = false ;
            }
            return isValid;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            string validationMessage = "";

            if (!ValidationForm(out validationMessage))
            {
                MessageBox.Show(validationMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ApplicationType.Title = txtTitle.Text.Trim();
            ApplicationType.Fees = Convert.ToDecimal(txtFees.Text.Trim());

            try
            {
                string errorMessage;

                ApplicationTypeService service = new ApplicationTypeService(ApplicationType);

                bool isSuccess = service.UpdateApplicationType(out errorMessage);
                var icon = isSuccess ? MessageBoxIcon.Information : MessageBoxIcon.Error;

               MessageBox.Show(errorMessage, "Edit Confirm", MessageBoxButtons.OK, icon);

            }
            catch (Exception ex) 
            {
                MessageBox.Show($"An Error Occured :\n {ex.Message}","Exception" ,MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void txtTitle_Validating(object sender, CancelEventArgs e)
        {
            string messageError = "";

            if (string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                messageError = "Can't Be Empty";
            }
            // add condition check about is the title is already in the apps or not

            if (messageError != "")
            {
                errorProvider1.SetError(txtTitle, messageError);
                e.Cancel = true;
            }
            else
                errorProvider1.SetError(txtTitle, "");
        }

        private void txtFees_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFees.Text))
            {
                errorProvider1.SetError(txtFees, "Must Has Fees Value");
                e.Cancel = true;
            }
            else
                errorProvider1.SetError(txtFees, "");
        }
    }
}
