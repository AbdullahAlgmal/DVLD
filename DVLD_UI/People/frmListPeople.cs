using DVLD_Buisness;
using System.Data;
namespace DVLD_UI.People
{
    public partial class frmListPeople : Form
    {
        private DataTable _dtPeople = Person.GetAll().DefaultView.ToTable(false,
                                                                       "Person_Id",
                                                                       "First_Name",
                                                                       "Second_Name",
                                                                       "Third_Name",
                                                                       "Last_Name",
                                                                       "Birth_Date",
                                                                       "Phone",
                                                                       "Email",
                                                                       "National_Number",
                                                                       "Gender_Caption",
                                                                       "Name");
        public frmListPeople()
        {
            InitializeComponent();
        }

        #region Private Methods
        private void dgvRowsCountChanged()
        {
            if (dgvPeople.Rows.Count == 0)
            {
                showToolStripMenuItem.Enabled = false;
                editToolStripMenuItem.Enabled = false;
                toolStripMenuItem2.Enabled = false;
            }
            else
            {
                showToolStripMenuItem.Enabled = true;
                editToolStripMenuItem.Enabled = true;
                toolStripMenuItem2.Enabled = true;
            }
        }
        private void _RefreshPeoplList()
        {
            _dtPeople = Person.GetAll().DefaultView.ToTable(false,
                                                                 "Person_Id",
                                                                 "First_Name",
                                                                 "Second_Name",
                                                                 "Third_Name",
                                                                 "Last_Name",
                                                                 "Birth_Date",
                                                                 "Phone",
                                                                 "Email",
                                                                 "National_Number",
                                                                 "Gender_Caption",
                                                                 "Name");

            dgvPeople.DataSource = _dtPeople;
            lblRecordsCount.Text = dgvPeople.Rows.Count.ToString();
            dgvRowsCountChanged();
        }
        #endregion

        #region Events
        private void frmListPeople_Load(object sender, EventArgs e)
        {
            dgvPeople.DataSource = _dtPeople;
            cbFilterBy.SelectedIndex = 0;
            lblRecordsCount.Text = dgvPeople.Rows.Count.ToString();
            if (dgvPeople.Rows.Count > 0)
            {

                dgvPeople.Columns[0].HeaderText = "Person ID";
                dgvPeople.Columns[0].Width = 110;

                dgvPeople.Columns[1].HeaderText = "First Name";
                dgvPeople.Columns[1].Width = 120;


                dgvPeople.Columns[2].HeaderText = "Second Name";
                dgvPeople.Columns[2].Width = 120;

                dgvPeople.Columns[3].HeaderText = "Third Name";
                dgvPeople.Columns[3].Width = 140;


                dgvPeople.Columns[4].HeaderText = "Last Name";
                dgvPeople.Columns[4].Width = 120;

                dgvPeople.Columns[5].HeaderText = "Date Of Birth";
                dgvPeople.Columns[5].Width = 120;

                dgvPeople.Columns[6].HeaderText = "Phone";
                dgvPeople.Columns[6].Width = 120;

                dgvPeople.Columns[7].HeaderText = "Email";
                dgvPeople.Columns[7].Width = 140;

                dgvPeople.Columns[8].HeaderText = "National No.";
                dgvPeople.Columns[8].Width = 120;


                dgvPeople.Columns[9].HeaderText = "Gender";
                dgvPeople.Columns[9].Width = 120;


                dgvPeople.Columns[10].HeaderText = "Nationality";
                dgvPeople.Columns[10].Width = 170;
            }
            dgvRowsCountChanged();
        }
        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterValue.Visible = (cbFilterBy.Text != "None");

            if (txtFilterValue.Visible)
            {
                txtFilterValue.Text = "";
                txtFilterValue.Focus();
            }
        }
        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            Dictionary<string, string> FilterColumnValues = new()
            {
                { "Person ID", "Person_Id" },
                { "National No.", "National_Number" },
                { "First Name", "First_Name" },
                { "Second Name", "Second_Name" },
                { "Third Name", "Third_Name" },
                { "Last Name", "Last_Name" },
                { "Nationality", "Name" },
                { "Gendor", "Gender_Caption" },
                { "Phone", "Phone" },
                { "Email", "Email" }
            };
            string FilterColumn = FilterColumnValues.ContainsKey(cbFilterBy.Text) ? FilterColumnValues[cbFilterBy.Text] : "None";

            if (txtFilterValue.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtPeople.DefaultView.RowFilter = "";
                dgvRowsCountChanged();
                lblRecordsCount.Text = dgvPeople.Rows.Count.ToString();
                return;
            }
            if (FilterColumn == "Person_Id")
                _dtPeople.DefaultView.RowFilter = $"{FilterColumn} = {txtFilterValue.Text.Trim()}";
            else
                _dtPeople.DefaultView.RowFilter = $"{FilterColumn} LIKE '{txtFilterValue.Text.Trim()}%'";

            dgvRowsCountChanged();
            lblRecordsCount.Text = dgvPeople.Rows.Count.ToString();
        }
        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterBy.Text == "Person ID") e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowPersonInfo frm = new(Convert.ToInt32(dgvPeople.SelectedRows[0].Cells[0].Value));
            frm.ShowDialog();
        }
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Are you sure you want to delete Person [{dgvPeople.CurrentRow.Cells[0].Value}]", "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (Person.Delete((int)dgvPeople.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("Person Deleted Successfully.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _RefreshPeoplList();
                }
                else
                {
                    MessageBox.Show("Person was not deleted because it has data linked to it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void addNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddUpdatePerson();
            frm.ShowDialog();
            _RefreshPeoplList();
        }
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddUpdatePerson((int)dgvPeople.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _RefreshPeoplList();
        }
        #endregion
    }
}
