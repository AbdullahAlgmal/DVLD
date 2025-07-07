using DVLD.DriverLicense;
using DVLD.Licenses.International_License;

namespace DVLD.Applications.Detain_License
{
    public partial class frmDetainLicenseApplication : Form
    {
        private int _DetainID;
        private int _SelectedLicenseID;
        public frmDetainLicenseApplication()
        {
            InitializeComponent();
        }
        private void btnDetain_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to detain this license?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            _DetainID = License0.Detain(Convert.ToSingle(txtFineFees.Text), LogedUser.CurrentUser?.UserId ?? 0, ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo!);
            if (_DetainID == default)
            {
                MessageBox.Show("Faild to Detain License", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lblDetainID.Text = _DetainID.ToString();
            MessageBox.Show("License Detained Successfully with ID=" + _DetainID.ToString(), "License Issued", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnDetain.Enabled = false;
            ctrlDriverLicenseInfoWithFilter1.FilterEnabled = false;
            txtFineFees.Enabled = false;
            llShowLicenseInfo.Enabled = true;
        }
        private void frmDetainLicenseApplication_Load(object sender, EventArgs e)
        {
            lblDetainDate.Text = Format.DateToShort(DateTime.Now);
            lblCreatedByUser.Text = LogedUser.CurrentUser?.UserName;
        }
        private void ctrlDriverLicenseInfoWithFilter1_OnLicenseSelected(int obj)
        {
            _SelectedLicenseID = obj;
            lblLicenseID.Text = _SelectedLicenseID.ToString();
            llShowLicenseHistory.Enabled = (_SelectedLicenseID != default);

            if (_SelectedLicenseID == default)
                return;

            if (License0.IsDetained(ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo?.LicenseId ?? 0))
            {
                MessageBox.Show("Selected License i already detained, choose another one.", "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            txtFineFees.Focus();
            btnDetain.Enabled = true;
        }
        private void frmDetainLicenseApplication_Activated(object sender, EventArgs e)
        {
            ctrlDriverLicenseInfoWithFilter1.txtLicenseIDFocus();
        }
        private void llShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowPersonLicenseHistory frm = new(ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo?.Driver?.PersonId ?? 0);
            frm.ShowDialog();
        }
        private void llShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowLicenseInfo frm = new(_SelectedLicenseID);
            frm.ShowDialog();
        }
        private void txtFineFees_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtFineFees.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtFineFees, "Fees cannot be empty!");
                return;
            }

            if (!Validation.IsNumber(txtFineFees.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtFineFees, "Invalid Number.");
            }
        }
    }
}
