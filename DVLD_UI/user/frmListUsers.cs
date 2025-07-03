using DVLD_Buisness;
using System.Data;

namespace DVLD_UI.user
{
    public partial class frmListUsers : Form
    {
        private static DataTable _dtUsers;

        public frmListUsers()
        {
            InitializeComponent();
        }

        private void dgvRowsCountChanged()
        {
            if (dgvUsers.Rows.Count == 0)
            {
                showToolStripMenuItem.Enabled = false;
                editToolStripMenuItem.Enabled = false;
                toolStripMenuItem2.Enabled = false;
                toolStripMenuItem1.Enabled = false;
            }
            else
            {
                showToolStripMenuItem.Enabled = true;
                editToolStripMenuItem.Enabled = true;
                toolStripMenuItem2.Enabled = true;
                toolStripMenuItem1.Enabled = true;
            }
        }
        private void _RefreshUsersList()
        {
            _dtUsers = User.GetAll();
            dgvUsers.DataSource = _dtUsers;
            lblRecordsCount.Text = dgvUsers.Rows.Count.ToString();
            dgvRowsCountChanged();
        }

        private void frmListUsers_Load(object sender, EventArgs e)
        {
            _RefreshUsersList();
            cbFilterBy.SelectedIndex = 0;

            if (dgvUsers.Rows.Count > 0)
            {
                dgvUsers.Columns[0].HeaderText = "User ID";
                dgvUsers.Columns[0].Width = 110;

                dgvUsers.Columns[1].HeaderText = "Person ID";
                dgvUsers.Columns[1].Width = 120;

                dgvUsers.Columns[2].HeaderText = "Full Name";
                dgvUsers.Columns[2].Width = 350;

                dgvUsers.Columns[3].HeaderText = "UserName";
                dgvUsers.Columns[3].Width = 120;

                dgvUsers.Columns[4].HeaderText = "Is Active";
                dgvUsers.Columns[4].Width = 120;
            }
        }
        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilterBy.Text == "Is Active")
            {
                txtFilterValue.Visible = false;
                cbIsActive.Visible = true;
                cbIsActive.Focus();
                cbIsActive.SelectedIndex = 0;
            }
            else
            {
                txtFilterValue.Visible = (cbFilterBy.Text != "None");
                cbIsActive.Visible = false;
                txtFilterValue.Text = "";
                txtFilterValue.Focus();
            }
        }
        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            Dictionary<string, string> FilterColumnValues = new()
            {
                { "Person ID", "Person_Id" },
                { "UserName", "User_Name" },
                { "User ID", "User_Id" },
                { "Full Name", "FullName" }
            };
            string FilterColumn = FilterColumnValues.ContainsKey(cbFilterBy.Text) ? FilterColumnValues[cbFilterBy.Text] : "None";

            if (txtFilterValue.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtUsers.DefaultView.RowFilter = "";
                dgvRowsCountChanged();
                lblRecordsCount.Text = dgvUsers.Rows.Count.ToString();
                return;
            }

            if (FilterColumn != "FullName" && FilterColumn != "User_Name")
                _dtUsers.DefaultView.RowFilter = $"[{FilterColumn}] = {txtFilterValue.Text.Trim()}";
            else
                _dtUsers.DefaultView.RowFilter = $"[{FilterColumn}] LIKE '{txtFilterValue.Text.Trim()}%'";

            dgvRowsCountChanged();
            lblRecordsCount.Text = _dtUsers.Rows.Count.ToString();
        }
        private void cbIsActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            string FilterColumn = "IsActive";
            string FilterValue = cbIsActive.Text;

            switch (FilterValue)
            {
                case "All":
                    break;
                case "Yes":
                    FilterValue = "1";
                    break;
                case "No":
                    FilterValue = "0";
                    break;
            }

            if (FilterValue == "All")
                _dtUsers.DefaultView.RowFilter = "";
            else
                _dtUsers.DefaultView.RowFilter = $"[{FilterColumn}] = {FilterValue}";

            dgvRowsCountChanged();
            lblRecordsCount.Text = _dtUsers.Rows.Count.ToString();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdateUser Frm1 = new frmAddUpdateUser((int)dgvUsers.CurrentRow.Cells[0].Value);
            Frm1.ShowDialog();
            _RefreshUsersList();
        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmAddUpdateUser Frm1 = new frmAddUpdateUser();
            Frm1.ShowDialog();
            _RefreshUsersList();
        }
        private void dgvUsers_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmShowUserInfo Frm1 = new frmShowUserInfo((int)dgvUsers.CurrentRow.Cells[0].Value);
            Frm1.ShowDialog();
        }
        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowUserInfo Frm1 = new frmShowUserInfo((int)dgvUsers.CurrentRow.Cells[0].Value);
            Frm1.ShowDialog();
        }
        private void ChangePasswordtoolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChangePassword Frm1 = new frmChangePassword((int)dgvUsers.CurrentRow.Cells[0].Value);
            Frm1.ShowDialog();
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterBy.Text == "Person ID" || cbFilterBy.Text == "User ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (User.Delete((int)dgvUsers.CurrentRow.Cells[0].Value))
            {
                MessageBox.Show("User has been deleted successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _RefreshUsersList();
            }
            else
                MessageBox.Show("User is not delted due to data connected to it.", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
