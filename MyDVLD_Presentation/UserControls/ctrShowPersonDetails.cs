using System;
using MyDVLD_DTO;
using System.IO;
using System.Windows.Forms;
using MyDVLD_BLL;
using MyDVLD_Presentation.Person;
using MyDVLD_Presentation.Properties;
using System.Diagnostics;

namespace MyDVLD_Presentation.UserControls
{
    public partial class ctrPersonDetailsCard : UserControl
    {
        public int PersonID { get; private set; }
        public PersonDTO PersonCardDTO { get; private set; }
        public bool IsPersonInfoFound { get; private set; }

        public ctrPersonDetailsCard()
        {
            InitializeComponent();
        }

        // load the person information using his ID
        public void LoadPersonInfo(int personID)
        {
            if (personID <= 0)
            {
                SetDefaultValues();
                return;
            }

            PersonID = personID;
            string error = "";
            PersonCardDTO = PersonService.FindPersonByIDOrNationalNo(out error , PersonID, null);

            if (PersonCardDTO == null)
            {
                MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                IsPersonInfoFound = false;
                SetDefaultValues();
                return;
            }
            IsPersonInfoFound = true;
            FillCardWithPersonInfo();
            LoadCardImage();
        }

        // load the person information using his National No
        public void LoadPersonInfo(string nationalNo)
        {
            string error = "";

            PersonCardDTO = PersonService.FindPersonByIDOrNationalNo(out error , null , nationalNo);

            if (PersonCardDTO == null)
            {
                MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                IsPersonInfoFound= false;
                SetDefaultValues();
                return;
            }

            PersonID = PersonCardDTO.PersonID;
            // set the value of the bool vairable 
            IsPersonInfoFound= true;
            // fill the card by the person information
            FillCardWithPersonInfo();
            // load the picture 
            LoadCardImage();
        }
        // fill the card by the person information
        private void FillCardWithPersonInfo()
        {
            lblPersonID.Text = PersonCardDTO.PersonID.ToString();
            lblNationalNo.Text = PersonCardDTO.NationalNo.ToString();
            lblName.Text = PersonCardDTO.FullName;
            lblGendor.Text = PersonCardDTO.Gender == 'm' ? "Male" : "Female";
            lblEmail.Text = PersonCardDTO.Email;
            lblCountry.Text =PersonCardDTO.CountryInfo.Name;
            lblDateOfBirth.Text = PersonCardDTO.DateOfBirth.ToShortDateString();
            lblPhone.Text = PersonCardDTO.Phone;
            lblAddress.Text = PersonCardDTO.Address;
        }

        // load the picture box by the person image if he has a one
        private void LoadCardImage()
        {
            // Default Case related on Gender
            if (PersonCardDTO.Gender == 'm')
                pbPersonImage.Image = Resources.Male_512;
            else
                pbPersonImage.Image = Resources.Female_512;
            try
            {
                if (PersonCardDTO.Image != "")
                {
                    if (File.Exists(PersonCardDTO.Image))
                        pbPersonImage.ImageLocation = PersonCardDTO.Image;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Can't Find The Image","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void klblEditPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmAddNewPerson frm = new FrmAddNewPerson(PersonCardDTO,FrmAddNewPerson.EnPersonMode.Update);
            frm.ShowDialog();
            LoadPersonInfo(PersonID);
        }

        private void SetDefaultValues()
        {
            lblPersonID.Text = "??";
            lblNationalNo.Text = "??";
            lblName.Text = "??";
            lblGendor.Text = "??";
            lblEmail.Text = "??";
            lblCountry.Text = "??";
            lblPhone.Text = "??";
            lblDateOfBirth.Text = "??";
            lblAddress.Text = "??";
            pbPersonImage.Image = Resources.Male_512;
            klblEditPersonInfo.Enabled = false;
        }

    }
}
