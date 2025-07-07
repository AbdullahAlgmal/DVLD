using DVLD.DriverLicense;
using DVLD.Licenses.International_License;

namespace DVLD.Licenses
{
    public partial class frmRenewLocalDrivingLicenseApplication: Form
    {
        private int _NewLicenseID;
        public frmRenewLocalDrivingLicenseApplication()
        {
            InitializeComponent();
        }
        private void frmRenewLocalDrivingLicenseApplication_Load(object sender, EventArgs e)
        {
            ctrlDriverLicenseInfoWithFilter1.txtLicenseIDFocus();
            lblApplicationDate.Text = Format.DateToShort(DateTime.Now);
            lblIssueDate.Text = lblApplicationDate.Text;
            lblExpirationDate.Text = "???";
            lblApplicationFees.Text = ApplicationType.Find((byte)Application0.enApplicationType.RenewDrivingLicense)?.Fees.ToString();
            lblCreatedByUser.Text = LogedUser.CurrentUser?.UserName;
        }
        private void ctrlDriverLicenseInfoWithFilter1_OnLicenseSelected(int obj = default)
        {
            int SelectedLicenseID = obj;

            lblOldLicenseID.Text = SelectedLicenseID.ToString();
            llShowLicenseHistory.Enabled = (SelectedLicenseID != default);

            if (SelectedLicenseID == default)
                return;

            int DefaultValidityLength = ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo?.LocalDrivingLicenseApplication?.LicenseClass?.ValidityLength ?? 0;
            lblExpirationDate.Text = Format.DateToShort(DateTime.Now.AddYears(DefaultValidityLength));
            lblLicenseFees.Text = ctrlDriverLicenseInfoWithFilter1?.SelectedLicenseInfo?.LocalDrivingLicenseApplication?.LicenseClass?.ClassFees.ToString();
            lblTotalFees.Text = (Convert.ToSingle(lblApplicationFees.Text) + Convert.ToSingle(lblLicenseFees.Text)).ToString();
            txtNotes.Text = ctrlDriverLicenseInfoWithFilter1?.SelectedLicenseInfo?.Notes;

            if (!(ctrlDriverLicenseInfoWithFilter1?.SelectedLicenseInfo?.IsLicenseExpired ?? false))
            {
                MessageBox.Show("Selected License is not yet expiared, it will expire on: " + Format.DateToShort(ctrlDriverLicenseInfoWithFilter1?.SelectedLicenseInfo?.ExpirationDate ?? DateTime.UtcNow), "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnRenewLicense.Enabled = false;
                return;
            }

            if (!(ctrlDriverLicenseInfoWithFilter1?.SelectedLicenseInfo?.IsActive ?? false))
            {
                MessageBox.Show("Selected License is not Not Active, choose an active license.", "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnRenewLicense.Enabled = false;
                return;
            }
         
            btnRenewLicense.Enabled = true;
        }
        private void btnRenewLicense_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Renew the license?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            var NewLicense = License0.RenewLicense(txtNotes.Text.Trim(), LogedUser.CurrentUser?.UserId ?? 0, ctrlDriverLicenseInfoWithFilter1?.SelectedLicenseInfo!);
            if (NewLicense is null)
            {
                MessageBox.Show("Faild to Renew the License", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lblApplicationID.Text= NewLicense.LocalDrivingLicenseApplication?.ApplicationId.ToString();
            _NewLicenseID = NewLicense.LicenseId;
            lblRenewedLicenseID.Text = _NewLicenseID.ToString();
            MessageBox.Show("Licensed Renewed Successfully with ID=" + _NewLicenseID.ToString(), "License Issued", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnRenewLicense.Enabled = false;
            ctrlDriverLicenseInfoWithFilter1!.FilterEnabled = false;
            llShowLicenseInfo.Enabled = true;          
        }
        private void frmRenewLocalDrivingLicenseApplication_Activated(object sender, EventArgs e)
        {
            ctrlDriverLicenseInfoWithFilter1.txtLicenseIDFocus();
        }
        private void llShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowPersonLicenseHistory frm = new(ctrlDriverLicenseInfoWithFilter1?.SelectedLicenseInfo?.Driver?.PersonId ?? 0);
            frm.ShowDialog();
        }
        private void llShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowLicenseInfo frm = new(_NewLicenseID);
            frm.ShowDialog();
        }
    }
}
