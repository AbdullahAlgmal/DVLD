namespace DVLD.DriverLicense
{
    public partial class frmShowLicenseInfo : Form
    {
        private int _LicenseID;
        public frmShowLicenseInfo(int LicenseID)
        {
            InitializeComponent();
            _LicenseID= LicenseID;
        }
        private void frmShowLicenseInfo_Load(object sender, EventArgs e)
        {
            ctrlDriverLicenseInfo1.LoadInfo(_LicenseID);
        }
    }
}
