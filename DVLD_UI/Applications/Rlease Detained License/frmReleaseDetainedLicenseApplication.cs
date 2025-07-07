using DVLD.DriverLicense;
using DVLD.Licenses.International_License;

namespace DVLD.Applications.Rlease_Detained_License
{
    public partial class frmReleaseDetainedLicenseApplication : Form
    {       
        private int _SelectedLicenseID = default;
        public frmReleaseDetainedLicenseApplication()
        {
            InitializeComponent();
        }
        public frmReleaseDetainedLicenseApplication(int LicenseID)
        {
            InitializeComponent();
            _SelectedLicenseID = LicenseID;      
            ctrlDriverLicenseInfoWithFilter1.LoadLicenseInfo(_SelectedLicenseID);
            ctrlDriverLicenseInfoWithFilter1.FilterEnabled = false;
        }
        private void ctrlDriverLicenseInfoWithFilter1_OnLicenseSelected(int obj = default)
        {
            _SelectedLicenseID = obj;
            lblLicenseID.Text = _SelectedLicenseID.ToString();
            llShowLicenseHistory.Enabled = (_SelectedLicenseID != default);

            if (_SelectedLicenseID == default)
                return;

            if (!DetainedLicense.IsLicenseDetained(_SelectedLicenseID))
            {
                MessageBox.Show("Selected License i is not detained, choose another one.", "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var detainedlicense = DetainedLicense.FindByLicenseId(ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo?.LicenseId ?? 0);
            lblApplicationFees.Text = ApplicationType.Find((int)Application0.enApplicationType.ReleaseDetainedDrivingLicsense)?.Fees.ToString();
            lblCreatedByUser.Text = LogedUser.CurrentUser?.UserName;
            lblDetainID.Text = detainedlicense?.DetainedLicenseId.ToString();
            lblLicenseID.Text = detainedlicense?.LicenseId.ToString();         
            lblCreatedByUser.Text = detainedlicense?.CreatedByUser?.UserName;
            lblDetainDate.Text = Format.DateToShort(detainedlicense?.DetainDate ?? DateTime.UtcNow);
            lblFineFees.Text = detainedlicense?.FineFees.ToString();
            lblTotalFees.Text = (Convert.ToSingle( lblApplicationFees.Text) + Convert.ToSingle(lblFineFees.Text)).ToString();
            btnRelease.Enabled = true;
        }
        private void frmReleaseDetainedLicenseApplication_Activated(object sender, EventArgs e)
        {
            ctrlDriverLicenseInfoWithFilter1.txtLicenseIDFocus();
        }
        private void llShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowPersonLicenseHistory frm = new (ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo?.Driver?.PersonId ?? 0);
            frm.ShowDialog();
        }
        private void llShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowLicenseInfo frm = new(_SelectedLicenseID);
            frm.ShowDialog();
        }
        private void btnRelease_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to release this detained  license?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            int ApplicationID = default;
            bool IsReleased = License0.Release(_SelectedLicenseID, LogedUser.CurrentUser!.UserId, ref ApplicationID, ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo!);

            lblApplicationID.Text = ApplicationID.ToString();
            
            if (!IsReleased)
            {
                MessageBox.Show("Faild to to release the Detain License", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Detained License released Successfully ", "Detained License Released", MessageBoxButtons.OK, MessageBoxIcon.Information);

            btnRelease.Enabled = false;
            ctrlDriverLicenseInfoWithFilter1.FilterEnabled = false;
            llShowLicenseInfo.Enabled = true;
        }
    }
}
