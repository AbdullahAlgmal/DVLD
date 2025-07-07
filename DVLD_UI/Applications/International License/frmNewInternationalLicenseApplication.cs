using DVLD.Licenses.International_License;
using DVLD.Licenses.International_Licenses;

namespace DVLD.Applications.International_License
{
    public partial class frmNewInternationalLicenseApplication : Form
    {      
        private int _InternationalLicenseID;     
        public frmNewInternationalLicenseApplication()
        {
            InitializeComponent();
        }
        private void ctrlDriverLicenseInfoWithFilter1_OnLicenseSelected(int obj = default)
        {
            int SelectedLicenseID = obj;

            lblLocalLicenseID.Text = SelectedLicenseID.ToString();
            llShowLicenseHistory.Enabled = (SelectedLicenseID != default);

            if (SelectedLicenseID == default) 
                return;

            if (ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo?.LocalDrivingLicenseApplication?.LicenseClassId != 3)
            {
                MessageBox.Show("Selected License should be Class 3, select another one.", "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int ActiveInternaionalLicenseID = InternationalLicense.GetActiveInternationalLicenseIDByDriverID(ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.DriverId);

            if (ActiveInternaionalLicenseID != default)
            {
                MessageBox.Show("Person already have an active international license with ID = " + ActiveInternaionalLicenseID.ToString(), "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                llShowLicenseInfo.Enabled = true;
                _InternationalLicenseID = ActiveInternaionalLicenseID;
                btnIssueLicense.Enabled = false;
                return;
            }

            btnIssueLicense.Enabled = true;
        }
        private void frmNewInternationalLicenseApplication_Load(object sender, EventArgs e)
        {           
            lblApplicationDate.Text = Format.DateToShort(DateTime.Now);
            lblIssueDate.Text = lblApplicationDate.Text;
            lblExpirationDate.Text = Format.DateToShort(DateTime.Now.AddYears(1));
            lblFees.Text = ApplicationType.Find((int)Application0.enApplicationType.NewInternationalLicense)?.Fees.ToString();
            lblCreatedByUser.Text = LogedUser.CurrentUser?.UserName;
        }
        private void btnIssueLicense_Click(object sender, EventArgs e)
        { 
            if (MessageBox.Show("Are you sure you want to issue the license?","Confirm",MessageBoxButtons.YesNo ,MessageBoxIcon.Question)==DialogResult.No)
                return;

            ApplicationModel? application = new(default,
                                                ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo?.Driver?.PersonId ?? 0,
                                                DateTime.Now,
                                                (byte)Application0.enApplicationType.NewInternationalLicense,
                                                (byte)Application0.enApplicationStatus.Completed,
                                                DateTime.Now,
                                                ApplicationType.Find((byte)Application0.enApplicationType.NewInternationalLicense)?.Fees ?? 0,
                                                LogedUser.CurrentUser?.UserId ?? 0);
            if (!Application0.Add(application))
            {
                MessageBox.Show("Faild to Issue International License", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            InternationalLicenseModel? internationalLicense = new()
            {
                IsActive = true,
                ApplicationId = application.ApplicationId,
                UserId = LogedUser.CurrentUser?.UserId ?? 0,
                IssuedUsingLicenseId = ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo?.LicenseId ?? 0,
                IssueDate = DateTime.Now,
                ExpirationDate = DateTime.Now.AddYears(1)
            };
            if (!InternationalLicense.Add(internationalLicense))
            {
                MessageBox.Show("Faild to Issue International License" , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lblApplicationID.Text = internationalLicense.ApplicationId.ToString();
            _InternationalLicenseID = internationalLicense.InternationalLicenseId;
            lblInternationalLicenseID.Text = internationalLicense.InternationalLicenseId.ToString();
            MessageBox.Show("International License Issued Successfully with ID=" + internationalLicense.InternationalLicenseId.ToString() , "License Issued", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnIssueLicense.Enabled = false;
            ctrlDriverLicenseInfoWithFilter1.FilterEnabled = false;
            llShowLicenseInfo.Enabled = true;
        }
        private void llShowDriverLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {         
            frmShowPersonLicenseHistory frm = new(ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo?.Driver?.PersonId ?? 0);
            frm.ShowDialog();
        }
        private void llShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowInternationalLicenseInfo frm = new(_InternationalLicenseID);
            frm.ShowDialog();
        }
        private void frmNewInternationalLicenseApplication_Activated(object sender, EventArgs e)
        {
            ctrlDriverLicenseInfoWithFilter1.txtLicenseIDFocus();
        }
    }
}
