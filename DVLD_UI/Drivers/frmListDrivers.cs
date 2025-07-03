using DVLD_UI.People;

namespace DVLD_UI.Drivers
{
    public partial class frmListDrivers : Form
    {
        private DataTable _dtDrivers;

        public frmListDrivers()
        {
            InitializeComponent();
        }

        private void _RefreshUsersList()
        {
            _dtDrivers = Driver.GetAll();
            dgvDrivers.DataSource = _dtDrivers;
            lblRecordsCount.Text = dgvDrivers.Rows.Count.ToString();
        }

        private void frmListDrivers_Load(object sender, EventArgs e)
        {
            cbFilterBy.SelectedIndex = 0;
            _RefreshUsersList();

            if (dgvDrivers.Rows.Count > 0)
            {
                dgvDrivers.Columns[0].HeaderText = "Driver ID";
                dgvDrivers.Columns[0].Width = 120;

                dgvDrivers.Columns[1].HeaderText = "Person ID";
                dgvDrivers.Columns[1].Width = 120;

                dgvDrivers.Columns[2].HeaderText = "National No.";
                dgvDrivers.Columns[2].Width = 140;

                dgvDrivers.Columns[3].HeaderText = "Full Name";
                dgvDrivers.Columns[3].Width = 320;

                dgvDrivers.Columns[4].HeaderText = "Date";
                dgvDrivers.Columns[4].Width = 170;

                dgvDrivers.Columns[5].HeaderText = "Active Licenses";
                dgvDrivers.Columns[5].Width = 150;
            }
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterValue.Visible = (cbFilterBy.Text != "None");
            txtFilterValue.Text = "";
            txtFilterValue.Focus();
        }
        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            Dictionary<string, string> FilterColumnValues = new()
            {
                { "Person ID", "Person_Id" },
                { "Driver ID", "Driver_Id" },
                { "National No.", "National_Number" },
                { "Full Name", "FullName" }
            };
            string FilterColumn = FilterColumnValues.ContainsKey(cbFilterBy.Text) ? FilterColumnValues[cbFilterBy.Text] : "None";

            if (txtFilterValue.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtDrivers.DefaultView.RowFilter = "";
                _RefreshUsersList();
                return;
            }

            if (FilterColumn != "FullName" && FilterColumn != "NationalNo")
                _dtDrivers.DefaultView.RowFilter = $"[{FilterColumn}] = {txtFilterValue.Text.Trim()}";
            else
                _dtDrivers.DefaultView.RowFilter = $"[{FilterColumn}] LIKE '{txtFilterValue.Text.Trim()}%'";

            _RefreshUsersList();
        }
        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterBy.Text == "Driver ID" || cbFilterBy.Text == "Person ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowPersonInfo frm = new((int)dgvDrivers.CurrentRow.Cells[1].Value);
            frm.ShowDialog();
            _RefreshUsersList();
        }
    }
}