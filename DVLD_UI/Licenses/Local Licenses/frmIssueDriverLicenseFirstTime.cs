namespace DVLD.DriverLicense
{
    public partial class frmIssueDriverLicenseFirstTime : Form
    {
        private int _LocalDrivingLicenseApplicationID;
        private  LocalDrivingLicensApplicationModel? _LocalDrivingLicenseApplication;
        public frmIssueDriverLicenseFirstTime(int LocalDrivingLicenseApplicationID)
        {
            InitializeComponent();
            _LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
        }
        private void frmIssueDriverLicenseFirstTime_Load(object sender, EventArgs e)
        {
            txtNotes.Focus();            
            _LocalDrivingLicenseApplication = LocalDrivingLicensApplication.Find(_LocalDrivingLicenseApplicationID);

            if (_LocalDrivingLicenseApplication is null)
            {
                MessageBox.Show("No Applicaiton with ID=" + _LocalDrivingLicenseApplicationID.ToString(), "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            if (!LocalDrivingLicensApplication.PassedAllTests(_LocalDrivingLicenseApplicationID))
            {
                MessageBox.Show("Person Should Pass All Tests First.", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            int LicenseID = LocalDrivingLicensApplication.GetActiveLicenseId(_LocalDrivingLicenseApplication.Application?.PersonId ?? 0, _LocalDrivingLicenseApplication.LicenseClassId);
            if (LicenseID != default)
            {             
                MessageBox.Show("Person already has License before with License ID=" + LicenseID.ToString() , "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
            ctrlDrivingLicenseApplicationInfo1.LoadApplicationInfoByLocalDrivingAppID(_LocalDrivingLicenseApplicationID);         
        }
        private void btnIssueLicense_Click(object sender, EventArgs e)
        {
            int LicenseID = LocalDrivingLicensApplication.IssueLicenseForTheFirtTime(txtNotes.Text.Trim(),LogedUser.CurrentUser?.UserId ?? 0, _LocalDrivingLicenseApplication!);

            if (LicenseID != default)
            {
                MessageBox.Show("License Issued Successfully with License ID = " + LicenseID.ToString(), "Succeeded",MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("License Was not Issued ! " ,
                 "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
