using System;
using MyDVLD_DTO;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;
using MyDVLD_BLL;
using MyDVLD_Presentation.Properties;
using MyDVLD_Presentation.Validations;

namespace MyDVLD_Presentation.Person
{
    public partial class FrmAddNewPerson : Form
    {
        public enum EnPersonMode { Add,Update}
        public EnPersonMode PersonMode { get; private set; }

        public event Action<int> OnPersonIDBack;

        private PersonDTO Person { set; get; }

        private string errorMessage = "";

        public FrmAddNewPerson(PersonDTO dto , EnPersonMode mode)
        {
            InitializeComponent();

            PersonMode = mode;

            Person = dto;

            if (PersonMode == EnPersonMode.Update && Person.PersonID == 0)
                throw new ArgumentNullException(nameof(dto));
        }

        // set the Default Values to the form for add mode
        private void ResetDefaultValues()
        {
            this.Text = "Add New Person";
            lblTitle.Text = "Add Person";
            rbMale.Checked = true;
            lblPersonID.Text = "N/A";
            // The PersonService must be over than 18 year
            dtDateOfBirth.MaxDate = DateTime.Now.AddYears(-18);
            pbImage.Image = Resources.Male_512;
        }

        // fill the countries in the combo box from the country class 
        private void FillCountries()
        {
           List<CountryDTO>  countries = CountryManager.RetrieveAllCountries();
            cbCountry.Items.Clear();
            cbCountry.DisplayMember = "Name";
            cbCountry.ValueMember = "ID";
            cbCountry.DataSource = countries;
            cbCountry.SelectedValue = CountryManager.FindByCountryIDOrName(null,"Egypt").ID;
        }

        private void FrmAddNewPerson_Load(object sender, EventArgs e)
        {
            FillCountries();

            if (PersonMode == EnPersonMode.Update)
                LoadPersonDetails();
            else
                ResetDefaultValues();

        }

        private void LoadPersonDetails()
        {
            
            this.Text = "Edit Person Details";
            lblTitle.Text = "Edit Person Details";
            lblPersonID.Text = Person.PersonID.ToString();
            txtFirstName.Text = Person.FirstName;
            txtSecondName.Text = Person.SecondName;
            txtThirdName.Text = Person.ThirdName ;
            txtLastName.Text = Person.LastName;
            txtNationalNo.Enabled = false;
            txtNationalNo.Text = Person.NationalNo;
            dtDateOfBirth.Value = Person.DateOfBirth;

            // set the person type value
            if (Person.Gender == 'm')
            {
                rbMale.Checked = true;
                pbImage.Image = Resources.Male_512;
            }
            else
            {
                rbFemale.Checked = true;
                pbImage.Image = Resources.Female_512;
            }

            txtPhone.Text = Person.Phone;
            txtEmail.Text = Person.Email;
            txtAddress.Text = Person.Address;
            cbCountry.Text = Person.CountryInfo.Name;

            // set the picture box by image if it founded
            if(!string.IsNullOrEmpty(Person.Image) && File.Exists(Person.Image))
                pbImage.ImageLocation = Person.Image;
            else
                pbImage.Image = (Person.Gender == 'm') ? pbImage.Image = Resources.Male_512 :
                            pbImage.Image = Resources.Female_512;
        }

        // open a dialog to select an image from the PC
        private void klblSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using(OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                // set the title of the dialog
                openFileDialog.Title = "Choose An Image";

                // set what files types will appear to the user
                openFileDialog.Filter = "Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp|All Files|*.*";

                // set the Default Directory 
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // save the path which the user selected in a string variable
                    string SelectedFilePath = openFileDialog.FileName;

                    if(File.Exists(SelectedFilePath))
                    {
                        try
                        {
                            // load the image in the picture box
                            pbImage.ImageLocation = SelectedFilePath;

                            // save the path in the object as a string
                            Person.Image = SelectedFilePath;
                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show($"{ex.Message}","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                            Person.Image = "";
                            pbImage.Image = null;
                        }
                    }
                    else
                        MessageBox.Show("Invalid Path","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("Cancel", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rbMale_Click(object sender, EventArgs e)
        {
            if (pbImage.ImageLocation == null)
                pbImage.Image = Resources.Male_512;
        }

        private void rbFemale_Click(object sender, EventArgs e)
        {
            if (pbImage.ImageLocation == null)
                pbImage.Image = Resources.Female_512;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CollectPersonDetailsFromForm()
        {
            int selectedCountryID = Convert.ToInt32(cbCountry.SelectedValue);
            string selectedCountryName = ((CountryDTO)cbCountry.SelectedItem).Name;

            Person.FirstName = txtFirstName.Text.Trim();
            Person.SecondName = txtSecondName.Text.Trim();
            Person.ThirdName = txtThirdName.Text.Trim();
            Person.LastName = txtLastName.Text.Trim();
            Person.NationalNo = txtNationalNo.Text.Trim();
            Person.DateOfBirth = dtDateOfBirth.Value;
            Person.Gender = rbMale.Checked ? 'm' : 'f';
            Person.Email = txtEmail.Text.Trim();
            Person.Address = txtAddress.Text.Trim();
            Person.Phone = txtPhone.Text.Trim();
            Person.CountryID = selectedCountryID;
            Person.Image = (pbImage.Image == Resources.Female_512 || pbImage.Image == Resources.Male_512) ? "" : pbImage.ImageLocation;
            Person.CountryInfo = new CountryDTO()
            {
                ID = selectedCountryID,
                Name = selectedCountryName
            };
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            CollectPersonDetailsFromForm();

            PersonService service = new PersonService(Person);

            if(PersonMode == EnPersonMode.Add)
            {
                if (service.InsertPerson(out errorMessage))
                {
                    MessageBox.Show(errorMessage, "Save Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(errorMessage, "Save Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            else // update mode
            {
                if(service.UpdatePerson(out errorMessage))
                {
                    MessageBox.Show(errorMessage, "Save Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(errorMessage, "Save Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            lblPersonID.Text = Person.PersonID.ToString();
            this.Text = "Edit Person Details";
            lblTitle.Text = "Edit Person Details";
            Action<int> handler = OnPersonIDBack;
            handler?.Invoke(Person.PersonID);
        }

        private void NationalNo_Validating(object sender, CancelEventArgs e)
        {
            ValidationsPresentation.NationalNo_Validating((TextBox)sender, e, errorProvider1);
        }
        private void txtBoxes_EmptyValidating(object sender, CancelEventArgs e)
        {
            ValidationsPresentation.TextBox_EmptyValidating((TextBox)sender, e, errorProvider1);
        }
    }
}
