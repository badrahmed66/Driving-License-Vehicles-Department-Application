using System;
using MyDVLD_DTO;
using System.Windows.Forms;
using MyDVLD_BLL;
using MyDVLD_Presentation.Properties;

namespace MyDVLD_Presentation.Person
{
    public partial class FrmShowPersonDetails : Form
    {
        private int _personID;

        public FrmShowPersonDetails(int personID)
        {
            InitializeComponent();
            this._personID = personID;
        }

        private void button1_Click(object sender, EventArgs e)
         {
            this.Close();
        }

        private void FrmShowPersonDetails_Load(object sender, EventArgs e)
        {
            ctrShowPersonDetails1.LoadPersonInfo(_personID);
        }
    }
}
