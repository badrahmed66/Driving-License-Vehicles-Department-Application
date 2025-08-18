using System;
using MyDVLD_DTO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyDVLD_BLL;
using MyDVLD_Presentation.Person;

namespace MyDVLD_Presentation.UserControls
{
    public partial class ctrShowPersonDetailsWithFilter : UserControl
    {
        public event Action<int> OnPersonSelected;
        
        public void PersonSelected(int personId)
        {
            // copy the public event to prevent null Exeption error for list invocation
            Action<int> handler = OnPersonSelected;

            // check if the list has subscribers  then Invoke the list 
            handler?.Invoke(personId);
        }

        // to save the person Id after adding new person by the event
        public int PersonID { get { return ctrShowPersonDetails1.PersonID; } }
        public PersonDTO PersonInfo { get { return ctrShowPersonDetails1.PersonCardDTO; } }
        public bool PersonFounded { get { return ctrShowPersonDetails1.IsPersonInfoFound; } }

        // during edit mode control the button of add new person desable or enable from outside
        private bool _addNewPerson;
        public bool AddNewPersonButton
        {
            get { return _addNewPerson; }
            set
            {
                _addNewPerson = value;
                btnAddNewPerson.Enabled = _addNewPerson;
            }
        }

        // to control Enabled the group box of filtering part
        private bool _gbFilter = true;
        public bool GroupFilter 
        {
            get { return _gbFilter; }
            set 
            {
                _gbFilter = value;
                gbFilter.Enabled = _gbFilter;
            }
        }
        public ctrShowPersonDetailsWithFilter()
        {
            InitializeComponent();
        }

        // fill the combo box of filter by with its items and set a default item
        private void SetFilterList()
        {
            cbFilter.Items.Clear();
            cbFilter.Items.AddRange(new object[] { "National No", "Person ID" });
            cbFilter.SelectedIndex = 0;
        }
        
        public void LoadPersonInfo(int personID)
        {
            // load the information for this person
            ctrShowPersonDetails1.LoadPersonInfo(personID);
            cbFilter.SelectedIndex = 1;
            txtFilter.Text = PersonID.ToString();
            // create a method for two cases person id or national no option
            FindUserPersonatilyDetails();
        }

        public void ctrShowPersonDetailsWithFilter_Load(object sender, EventArgs e)
        {
            SetFilterList();
        }

        private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilter.Text == "PersonService ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilter.Visible = true;
            txtFilter.Focus();
            txtFilter.Text = "";
        }

        private void FindUserPersonatilyDetails()
        {
            if (cbFilter.Text == "Person ID")
                ctrShowPersonDetails1.LoadPersonInfo(int.Parse(txtFilter.Text.Trim()));
            else
                ctrShowPersonDetails1.LoadPersonInfo(txtFilter.Text.Trim());
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFilter.Text))
            {
                MessageBox.Show("Must Enter A person ID or National No","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            FindUserPersonatilyDetails();
        }

        private void btnAddNewPerson_Click(object sender, EventArgs e)
        {
            var person = new PersonDTO();
            FrmAddNewPerson frm = new FrmAddNewPerson(person,FrmAddNewPerson.EnPersonMode.Add);
            frm.OnPersonIDBack += PersonIDBackEventHandler;
            frm.ShowDialog();
        }

        // the handler of the event ( this methd will utlized from the event )
        private void PersonIDBackEventHandler(int ID)
        {
            cbFilter.SelectedIndex = 1; // set the combo box value to PersonService ID
            txtFilter.Text = ID.ToString(); // set the text box value to the person id
            ctrShowPersonDetails1.LoadPersonInfo(ID);
        }

        private void txtFilter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                btnSearch_Click(btnSearch, new EventArgs());
            }   
         }

        }
    }

