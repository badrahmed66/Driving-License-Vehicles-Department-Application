using System;
using MyDVLD_DTO;
using MyDVLD_BLL;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using MyDVLD_BLL.Validation;

namespace MyDVLD_Presentation.AllApplications.TestsTypes
{
    public partial class FrmEditTestsTypes : Form
    {
        private TestTypeDTO TestType { set; get; }
        public enum TestTypeMode { Add = 1 , Update = 2}
        public TestTypeMode Mode { get; private set; }

        private string message = "";

        public FrmEditTestsTypes(TestTypeDTO testType , TestTypeMode mode)
        {
            InitializeComponent();

            TestType = testType ;

            Mode = mode;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InitializeForm()
        {
            lblID.Text = "??";
            txtTitle.Clear();
            txtFees.Clear();
            txtDesc.Clear();
        }

        private void LoadData()
        {
            TestType = TestTypeService.FindTestByID(TestType.ID);

            if (TestType == null)
            {
                MessageBox.Show("Invalid Test Type ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            lblID.Text = TestType.ID.ToString();
            txtTitle.Text = TestType.Title;
            txtFees.Text = TestType.Fees.ToString();
            txtDesc.Text = TestType.Description;

        }

        private void FrmEditTestsTypes_Load(object sender, EventArgs e)
        {

            if (Mode == TestTypeMode.Update)
                LoadData();
            else
                InitializeForm();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Enter All Fields Please","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(TestTypeValidator.IsExists(txtTitle.Text.Trim()))
            {
                errorProvider1.SetError(txtTitle, "This Title is Already In The System");
                return;
            }


            TestType.Title = txtTitle.Text.Trim();
            TestType.Fees = Convert.ToDecimal(txtFees.Text.Trim());
            TestType.Description = txtDesc.Text.Trim();

            bool isSuccess;
            string title;

            try
            {
                TestTypeService service = new TestTypeService(TestType);
                
                if(Mode == TestTypeMode.Add)
                {
                     isSuccess = service.InsertTest(out message);
                    title = "Insert Test Type Confirm";
                }
                else
                {
                     isSuccess = service.UpdateTest(out message);
                    title = "Update Test Type Confirm";
                 }

                var icon = isSuccess ? MessageBoxIcon.Information : MessageBoxIcon.Error;
                MessageBox.Show(message, title, MessageBoxButtons.OK, icon);

            }
            catch(Exception ex)
            {
                MessageBox.Show($"An Error Occured :\n {ex.Message}", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // General Check To Prevent Field To Be Empty
        private void ValidationForEmptyField(object sender, CancelEventArgs e)
        {
            TextBox txtBox = (TextBox)sender;

            if (string.IsNullOrWhiteSpace(txtBox.Text))
            {
                errorProvider1.SetError(txtBox, "Can't Be Empty");
                e.Cancel = true;
            }
            else
                errorProvider1.SetError(txtBox, "");
        }

        


    }
}
