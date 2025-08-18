using System;
using MyDVLD_DTO;
using MyDVLD_BLL;
using System.Collections.Generic;
using System.Windows.Forms;
using MyDVLD_DTO.Person;

namespace MyDVLD_Presentation.Person
{
    public partial class FrmManagePeople : Form
    {
        private List<PersonViewDTO> _peopleList ;

        public FrmManagePeople()
        {
            InitializeComponent();
        }
        private void FillComboBoxFilterByOptions()
        {
            
            txtFilterBy.Visible = false;
            cbFilterBy.Items.Clear();
            cbFilterBy.Items.AddRange(new object[] { "All", "National No", "Person ID", "First Name","Last Name", "Country","Gender","Phone" });
            cbFilterBy.SelectedIndex = 0;
        }

        private void ConfigureDataGridViewColumns()
        {
            if (dgvPeople.Columns.Contains("PersonID"))
                dgvPeople.Columns["PersonID"].HeaderText = "Person ID";

            if(dgvPeople.Columns.Contains("NationalNo"))
                 dgvPeople.Columns["NationalNo"].HeaderText = "National No";

            if(dgvPeople.Columns.Contains("FullName"))
                dgvPeople.Columns["FullName"].HeaderText = "Full Name";

            if (dgvPeople.Columns.Contains("Gender"))
            {
                dgvPeople.Columns["Gender"].Width = 50;
                dgvPeople.Columns["Gender"].HeaderText = "Gender";
            }

            if(dgvPeople.Columns.Contains("DateOfBirth"))
                dgvPeople.Columns["DateOfBirth"].HeaderText = "Date Of Birth";

            if(dgvPeople.Columns.Contains("Country"))
                dgvPeople.Columns["Country"].HeaderText = "Country";

            if(dgvPeople.Columns.Contains("Phone"))
                dgvPeople.Columns["Phone"].HeaderText = "Phone";

            if (dgvPeople.Columns.Contains("Email"))
            {
                dgvPeople.Columns["Email"].HeaderText = "Email";
                dgvPeople.Columns["Email"].Width = 200;
            }

            if(dgvPeople.Columns.Contains("Address"))
            {
                dgvPeople.Columns["Address"].HeaderText = "Address";
                dgvPeople.Columns["Address"].Width = 100;
            }

        }

        // to get the people data and show it in the data grid view with or without filter
        private void InitializeFormData()
        {
            string filterColumn = cbFilterBy.SelectedItem.ToString();
            string filterValue = txtFilterBy.Text.Trim();

            _peopleList = PersonService.RetrieveAllPeople(filterColumn, filterValue);

            bsPeople.DataSource = _peopleList;

            dgvPeople.DataSource = bsPeople;

            lblPeopleCount.Text = bsPeople.Count.ToString();
        }

        private void FrmManagePeople_Load(object sender, EventArgs e)
        {
            FillComboBoxFilterByOptions();
            InitializeFormData();
            ConfigureDataGridViewColumns();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilterBy.SelectedItem.ToString() == "All")
            {
                txtFilterBy.Clear();
                txtFilterBy.Visible = false;
            }
            else
            {
                txtFilterBy.Visible = true;
                txtFilterBy.Clear();
                txtFilterBy.Focus();
            }
                InitializeFormData();
        }

        private void txtFilterBy_TextChanged(object sender, EventArgs e)
        {
            InitializeFormData();
        }

        private void txtFilterBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(cbFilterBy.SelectedItem.ToString() == "Person ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmShowPersonDetails frm = new FrmShowPersonDetails((int)dgvPeople.CurrentRow.Cells["PersonID"].Value);
            frm.ShowDialog();
            InitializeFormData();
        }

        private void addNewPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenAddPersonForm();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "";
            var dto = PersonService.FindPersonByIDOrNationalNo(out message , (int)dgvPeople.CurrentRow.Cells["PersonID"].Value,null);
            FrmAddNewPerson frm = new FrmAddNewPerson(dto,FrmAddNewPerson.EnPersonMode.Update);
            frm.ShowDialog();
            InitializeFormData();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string error = "";

            int PersonID = (int)dgvPeople.CurrentRow.Cells["PersonID"].Value;

                 if (MessageBox.Show("Are You Sure To Delete This Person ?", "Delete Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                 {
                    if (PersonService.DeletePerson(PersonID, out error))
                    {
                        MessageBox.Show(error, "Delete Confilrm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        InitializeFormData();
                    }
                    else
                        MessageBox.Show(error, "Delete Confirm", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    return;
        }

        private void OpenAddPersonForm()
        {
            FrmAddNewPerson frm = new FrmAddNewPerson(new PersonDTO(),FrmAddNewPerson.EnPersonMode.Add);
            frm.ShowDialog();
            InitializeFormData();
        }

        private void b_Click(object sender, EventArgs e)
        {
            OpenAddPersonForm();
        }
    }
}
