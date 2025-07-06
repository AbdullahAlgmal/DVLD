namespace DVLD_UI.Applications.Local_Driving_License
{
    public partial class ctrlDrivingLicenseApplicationInfo : UserControl
    {

        private LocalDrivingLicensApplicationModel? _LocalDrivingLicenseApplication;
        private int _LocalDrivingLicenseApplicationID;
        private int _LicenseId;

        public int LocalDrivingLicenseApplicationId
        {
            get => _LocalDrivingLicenseApplicationID;
        }

        public ctrlDrivingLicenseApplicationInfo()
        {
            InitializeComponent();
        }

        public void LoadApplicationInfoByLocalDrivingAppID(int LocalDrivingLicenseApplicationID)
        {
            _LocalDrivingLicenseApplication = LocalDrivingLicensApplication.Find(LocalDrivingLicenseApplicationID);
            if (_LocalDrivingLicenseApplication == null)
            {
                _ResetLocalDrivingLicenseApplicationInfo();
                MessageBox.Show($"No Application with ApplicationID = {LocalDrivingLicenseApplicationID}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _FillLocalDrivingLicenseApplicationInfo();
        }
        public void LoadApplicationInfoByApplicationID(int ApplicationID)
        {
            _LocalDrivingLicenseApplication = LocalDrivingLicensApplication.FindByApplicationId(ApplicationID);
            if (_LocalDrivingLicenseApplication == null)
            {
                _ResetLocalDrivingLicenseApplicationInfo();
                MessageBox.Show($"No Application with ApplicationID = {LocalDrivingLicenseApplicationId}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _FillLocalDrivingLicenseApplicationInfo();
        }

        private void _FillLocalDrivingLicenseApplicationInfo()
        {
            _LicenseId = LocalDrivingLicensApplication.GetActiveLicenseId(_LocalDrivingLicenseApplication?.Application?.PersonId ?? 0, _LocalDrivingLicenseApplication?.LicenseClassId ?? 0);

            llShowLicensInfo.Enabled = (_LicenseId != default);

            lblDLAppId.Text = _LocalDrivingLicenseApplication?.Id.ToString() ?? "0";
            lblAppliedForLicense.Text = _LocalDrivingLicenseApplication?.LicenseClass?.ClassName ?? "[???]";
            lblPassedTests.Text = LocalDrivingLicensApplication.GetPassedTestCount(_LocalDrivingLicenseApplication?.Id ?? 0).ToString() + "/3";
            ctrlApplicationBasicInfo1.LoadApplicationInfo(_LocalDrivingLicenseApplication?.ApplicationId ?? 0);
        }
        private void _ResetLocalDrivingLicenseApplicationInfo()
        {
            _LocalDrivingLicenseApplicationID = default;
            ctrlApplicationBasicInfo1.ResetApplicationInfo();
            lblDLAppId.Text = "[????]";
            lblAppliedForLicense.Text = "[????]";
        }

        private void llShowLicenceInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        }
    }
}
