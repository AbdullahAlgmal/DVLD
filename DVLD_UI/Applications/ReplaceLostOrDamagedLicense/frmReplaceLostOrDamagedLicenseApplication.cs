using DVLD.DriverLicense;
using DVLD.Licenses.International_License;
using static DVLD_Buisness.License0;

namespace DVLD.Applications.ReplaceLostOrDamagedLicense
{
    public partial class frmReplaceLostOrDamagedLicenseApplication : Form
    {
        private int _NewLicenseID;
        public frmReplaceLostOrDamagedLicenseApplication()
        {
            InitializeComponent();
        }
        private int _GetApplicationTypeID()
        {
            if (rbDamagedLicense.Checked)
                return (int)Application0.enApplicationType.ReplaceDamagedDrivingLicense;
            else
                return (int)Application0.enApplicationType.ReplaceLostDrivingLicense;
        }
        private enIssueReason _GetIssueReason()
        {           
            if (rbDamagedLicense.Checked)
                return enIssueReason.DamagedReplacement;
            else
                return enIssueReason.LostReplacement; 
        }
        private void frmReplaceLostOrDamagedLicenseApplication_Load(object sender, EventArgs e)
        {        
            lblApplicationDate.Text = Format.DateToShort(DateTime.Now);
            lblCreatedByUser.Text = LogedUser.CurrentUser?.UserName;        
            rbDamagedLicense.Checked = true;
        }
        private void rbDamagedLicense_CheckedChanged(object sender, EventArgs e)
        {
            lblTitle.Text = "Replacement for Damaged License";
            this.Text = lblTitle.Text;
            lblApplicationFees.Text = ApplicationType.Find(_GetApplicationTypeID())?.Fees.ToString();
        }
        private void rbLostLicense_CheckedChanged(object sender, EventArgs e)
        {
            lblTitle.Text = "Replacement for Lost License";
            this.Text = lblTitle.Text;
            lblApplicationFees.Text = ApplicationType.Find(_GetApplicationTypeID())?.Fees.ToString();
        }
        private void frmReplaceLostOrDamagedLicenseApplication_Activated(object sender, EventArgs e)
        {
            ctrlDriverLicenseInfoWithFilter1.txtLicenseIDFocus();
        }
        private void ctrlDriverLicenseInfoWithFilter1_OnLicenseSelected(int obj = default)
        {
            int SelectedLicenseID = obj;
            lblOldLicenseID.Text = SelectedLicenseID.ToString();
            llShowLicenseHistory.Enabled = (SelectedLicenseID != default);

            if (SelectedLicenseID == default)
                return;

            if (!(ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo?.IsActive ?? false))
            {
                MessageBox.Show("Selected License is not Not Active, choose an active license.", "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnIssueReplacement.Enabled = false;
                return;
            }
            btnIssueReplacement.Enabled = true;
        }
        private void btnIssueReplacement_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Issue a Replacement for the license?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            var NewLicense = License0.Replace(_GetIssueReason(), LogedUser.CurrentUser?.UserId ?? 0, ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo!);

            if (NewLicense is null)
            {
                MessageBox.Show("Faild to Issue a replacemnet for this  License", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lblApplicationID.Text = NewLicense.LocalDrivingLicenseApplication?.ApplicationId.ToString();
            _NewLicenseID = NewLicense.LicenseId;
            lblRreplacedLicenseID.Text = _NewLicenseID.ToString();
            MessageBox.Show("Licensed Replaced Successfully with ID=" + _NewLicenseID.ToString(), "License Issued", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnIssueReplacement.Enabled = false;
            gbReplacementFor.Enabled = false;
            ctrlDriverLicenseInfoWithFilter1.FilterEnabled = false;
            llShowLicenseInfo.Enabled = true;          
        }
        private void llShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowPersonLicenseHistory frm = new (ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo?.Driver?.PersonId ?? 0);
            frm.ShowDialog();
        }
        private void llShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowLicenseInfo frm = new(_NewLicenseID);
            frm.ShowDialog();
        }
    }
}
