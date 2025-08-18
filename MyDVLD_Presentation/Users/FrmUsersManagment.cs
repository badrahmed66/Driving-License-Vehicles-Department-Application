using System;
using MyDVLD_BLL;
using MyDVLD_DTO;
using System.Collections.Generic;
using System.Windows.Forms;
using MyDVLD_DTO.User;

namespace MyDVLD_Presentation.Users
{ 
    public partial class FrmUsersManagment : Form
    {
        string message = "";
        private List<UserViewDTO> _usersList ;

        public FrmUsersManagment()
        {
            InitializeComponent();
        }

        // fill the combo box of filter by by items
        private void SetFilterList()
        {
            txtFilterBy.Visible = false;
            cbFilterBy.Items.Clear();
            cbFilterBy.Items.AddRange(new object[] { "All", "Full Name", "User ID", "Person ID",
                "Is Active", "User Name" });
            cbFilterBy.SelectedIndex = 0;
        }

        // draw the dgv with the HeaderTitles and the Appropriate size
        private void ConfigureUserDataGridView()
        {
            if (dgvUsers.Columns.Contains("UserID"))
                dgvUsers.Columns["UserID"].HeaderText = "User ID";

            if(dgvUsers.Columns.Contains("PersonID"))
                dgvUsers.Columns["PersonID"].HeaderText = "Person ID";
            
            if(dgvUsers.Columns.Contains("FullName"))
                dgvUsers.Columns["FullName"].HeaderText = "Full Name";

            if (dgvUsers.Columns.Contains("UserName"))
                dgvUsers.Columns["UserName"].HeaderText = "User Name";

            if (dgvUsers.Columns.Contains("IsActive"))
                dgvUsers.Columns["IsActive"].HeaderText = "Is Active";
        }

        // load the data from BLL and assign it to the Binding Source then to the dgv
        private void LoadUsersData()
        {
            string columnName = cbFilterBy.SelectedItem.ToString();
            string filterValue = txtFilterBy.Text.Trim();

            _usersList = UserService.RetrieveAllUsers(columnName, filterValue);

            bsUsers.DataSource = _usersList;

            dgvUsers.DataSource = bsUsers;

            lblCount.Text = dgvUsers.Rows.Count.ToString();

        }

        private void FrmUsersManagment_Load(object sender, EventArgs e)
        {
            SetFilterList();
            LoadUsersData();
            ConfigureUserDataGridView();
        }

        private void DeleteProgress(int userID)
        {
           
            if(MessageBox.Show("Are you sure to Delete This User","Delete User Confirm",MessageBoxButtons.OKCancel,MessageBoxIcon.Question) == DialogResult.OK)
            {
                if(UserService.Delete(userID,out message))
                {
                    MessageBox.Show($"User with ID {userID} Deleted Successfuly", "Delete Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Failure Deleted","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmShowUserDetails frm = new FrmShowUserDetails((int)dgvUsers.CurrentRow.Cells["UserID"].Value);
            frm.ShowDialog();
            LoadUsersData();
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {

            if(cbFilterBy.SelectedItem.ToString() == "All")
            {
                txtFilterBy.Visible = false;
                txtFilterBy.Clear();
            }
            else
            {
                txtFilterBy.Visible = true;
                txtFilterBy.Focus();
                txtFilterBy.Clear();
            }
            
            LoadUsersData();
        }

        private void txtFilterBy_TextChanged(object sender, EventArgs e)
        {
            LoadUsersData();
        }

        // to prevent the user to write letters in the person id or user id case
        private void txtFilterBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(cbFilterBy.Text == "PersonService ID" || cbFilterBy.Text == "User ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            UserDTO dto = new UserDTO();
            FrmAddUser frm = new FrmAddUser(dto,FrmAddUser.UserMode.Add);
            frm.ShowDialog();
            LoadUsersData();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserDTO dto = new UserDTO();
            FrmAddUser frm = new FrmAddUser(dto, FrmAddUser.UserMode.Add);
            frm.ShowDialog();
            LoadUsersData();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteProgress((int)dgvUsers.CurrentRow.Cells["UserID"].Value);
            LoadUsersData();
        }

    }
}
