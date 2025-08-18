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

namespace MyDVLD_Presentation.Apps
{
    public partial class FrmManageAppsTypes : Form
    {
        private List<ApplicationTypeDTO> _applicationTypeList;

        public FrmManageAppsTypes()
        {
            InitializeComponent();
        }

        private void ConfigureDataGridViewByTestTypesList()
        {
            if (dgvAppsTypes.Columns.Contains("ID") && dgvAppsTypes.Columns.Contains("Title") && dgvAppsTypes.Columns.Contains("Fees"))
            {
                //dgvAppsTypes.Columns["ID"].HeaderText = "ID";
                dgvAppsTypes.Columns["ID"].Width = 70;

                //dgvAppsTypes.Columns["Title"].HeaderText = "Title";
                //dgvAppsTypes.Columns["Title"].Width = 70;

                //dgvAppsTypes.Columns["Fees"].HeaderText = "Fees $";
                dgvAppsTypes.Columns["Fees"].Width = 100;
            }
        }

        private void LoadApplicationTypesList()
        {
            _applicationTypeList = ApplicationTypeService.RetrieveApplicationAllApplicationType();
            bindingSource1.DataSource = _applicationTypeList;
            dgvAppsTypes.DataSource = bindingSource1;
            lblcount.Text = dgvAppsTypes.Rows.Count.ToString();
        }
        private void FrmManageAppsTypes_Load(object sender, EventArgs e)
        {
            ChangeDataGridStyle();
            LoadApplicationTypesList();
            ConfigureDataGridViewByTestTypesList();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // change the data grid view style ( color , font , of the header Row)
        private void ChangeDataGridStyle()
        {
            dgvAppsTypes.EnableHeadersVisualStyles = false;
            // change the back ground color of the header column
            dgvAppsTypes.ColumnHeadersDefaultCellStyle.BackColor = Color.DodgerBlue;
            dgvAppsTypes.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            // change the font
            dgvAppsTypes.ColumnHeadersDefaultCellStyle.Font = new Font("Arial",10,FontStyle.Bold);
            
            // change allignment
            dgvAppsTypes.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        //if the fees row has fraction show it or only show int nums
        private void dgvAppsTypes_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvAppsTypes.Columns[e.ColumnIndex].Name == "Fees" && e.Value != null)
            {
                if(decimal.TryParse(e.Value.ToString(), out decimal feesValue))
                {
                    if(feesValue % 1 == 0)
                    {
                        e.Value = feesValue.ToString("N0");
                        e.FormattingApplied = true;
                    }
                    else
                    {
                        e.Value = feesValue.ToString("N2");
                        e.FormattingApplied = true;
                    }
                }
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int selectedID = (int)dgvAppsTypes.CurrentRow.Cells["ID"].Value;
            var ApplicationType = ApplicationTypeService.FindApplicationTypeByID(selectedID);

            if (ApplicationType == null)
            {
                MessageBox.Show("Invalid Application Type ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            var frm = new FrmEditAppInfo(ApplicationType,FrmEditAppInfo.ApplicationTypeMode.Update);
            frm.ShowDialog();
            LoadApplicationTypesList();

        }
    }
}
