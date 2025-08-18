using System;
using MyDVLD_BLL;
using MyDVLD_DTO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyDVLD_Presentation.AllApplications.TestsTypes;

namespace MyDVLD_Presentation.TestsTypes
{
    public partial class FrmManageTestsTypes : Form
    {
        private List<TestTypeDTO> _testTypesList ;

        public FrmManageTestsTypes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // set all the data from the database to the data grid view
        private void ConfigureDataGridViewForData()
        {
            if(dgvTestsTypes.Columns.Contains("TestTypeID") && dgvTestsTypes.Columns.Contains("TestTypeTitle")&& dgvTestsTypes.Columns.Contains("TestTypeDescription") && dgvTestsTypes.Columns.Contains("TestTypeFees"))
            {
                dgvTestsTypes.Columns["TestTypeID"].HeaderText = "ID";
                dgvTestsTypes.Columns["TestTypeID"].Width = 100;

                dgvTestsTypes.Columns["TestTypeTitle"].HeaderText = "Title";
                dgvTestsTypes.Columns["TestTypeTitle"].Width = 120;
                
                dgvTestsTypes.Columns["TestTypeDescription"].HeaderText = "Description";

                dgvTestsTypes.Columns["TestTypeFees"].HeaderText = "Fees $";
                dgvTestsTypes.Columns["TestTypeFees"].Width = 120;
            }
        }

        private void LoadTestTypesData()
        {
            _testTypesList = TestTypeService.RetrieveAllTests();
            bindingSource1.DataSource = _testTypesList;
            dgvTestsTypes.DataSource = bindingSource1;
            lblRecords.Text = dgvTestsTypes.Rows.Count.ToString();
        }

        private void FrmManageTestsTypes_Load(object sender, EventArgs e)
        {
            // add the method to control of font and color of the header row of the data grid view
            ChangeStyleOfDGV();

            LoadTestTypesData();
            ConfigureDataGridViewForData();
        }


        // change the style of the main header Row
        private void ChangeStyleOfDGV()
        {
            // cancel the auto style 
            dgvTestsTypes.EnableHeadersVisualStyles = false;

            //change the background of the main Header Row
            dgvTestsTypes.ColumnHeadersDefaultCellStyle.BackColor = Color.Blue;
            dgvTestsTypes.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            // change the font of the Main Header Row
            dgvTestsTypes.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);

            // change the alingment of the main header row
            dgvTestsTypes.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // change the selection background color
            dgvTestsTypes.DefaultCellStyle.SelectionBackColor = Color.SkyBlue;

            // 
            //dgvTestsTypes.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TestTypeDTO testDTO = TestTypeService.FindTestByID((int)dgvTestsTypes.CurrentRow.Cells["ID"].Value);
            FrmEditTestsTypes frm = new FrmEditTestsTypes(testDTO,FrmEditTestsTypes.TestTypeMode.Update);
            frm.ShowDialog();
            LoadTestTypesData();
        }

        // if the Fees has Fractions Show it if not Only Show The Int part
        private void dgvTestsTypes_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // look for the column name 'Fees'
            if(dgvTestsTypes.Columns[e.ColumnIndex].Name == "Fees" && e.Value != null)
            {
                // Get the value of this column and convert it to decimal
                if(decimal.TryParse(e.Value.ToString(),out  decimal result))
                {
                    // check about if the value is int
                    if(result % 1 == 0)
                    {
                        e.Value = result.ToString("N0");
                        e.FormattingApplied = true;
                    }
                    //if the value has fractions show only 2 part after the poin
                    else
                    {
                        e.Value = result.ToString("N2");
                        e.FormattingApplied = true;
                    }
                }
            }
        }


    }
}
