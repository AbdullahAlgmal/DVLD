using DVLD_UI.Properties;

namespace DVLD.DriverLicense
{
    public partial class ctrlDriverLicenseInfo : UserControl
    {
        private int _LicenseID;
        private LicenseModel? _License;

        public ctrlDriverLicenseInfo()
        {
            InitializeComponent();          
        }
        public int LicenseID
        {
            get => _LicenseID;
        }
        public LicenseModel? SelectedLicenseInfo
        {
            get => _License;
        }
        private void _LoadPersonImage()
        {
            if (_License?.Driver?.Person.Gender == 0)
                pbPersonImage.Image = Resources.Male_512;
            else
                pbPersonImage.Image = Resources.Female_512;

            string ImagePath = _License?.Driver?.Person?.ImagePath ?? "";

            if (ImagePath != "")
                if (File.Exists(ImagePath))
                    pbPersonImage.Load(ImagePath);
                else
                    MessageBox.Show("Could not find this image: = " + ImagePath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public void LoadInfo(int LicenseID)
        {
            _LicenseID = LicenseID;
            _License = License0.Find(_LicenseID);
            if (_License is null)
            {
                MessageBox.Show("Could not find License ID = " + _LicenseID.ToString(),"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _LicenseID = default;
                return;
            }

            lblLicenseID.Text = _License.LicenseId.ToString();
            lblIsActive.Text = _License.IsActive ? "Yes" : "No";
            lblIsDetained.Text = License0.IsDetained(_License.LicenseId) ? "Yes" : "No";
            lblClass.Text = _License.LocalDrivingLicenseApplication?.LicenseClass?.ClassName;
            lblFullName.Text = _License.Driver?.Person.FullName;
            lblNationalNo.Text = _License.Driver?.Person.NationalNumber;
            lblGendor.Text = _License.Driver?.Person.Gender ==0 ? "Male":"Female";
            lblDateOfBirth.Text = Format.DateToShort(_License.Driver?.Person.BirthDate ?? DateTime.UtcNow);
            lblDriverID.Text= _License.DriverId.ToString();
            lblIssueDate.Text = Format.DateToShort(_License.IssueDate);
            lblExpirationDate.Text = Format.DateToShort(_License.ExpirationDate);
            lblIssueReason.Text = _License.IssueReasonText;
            lblNotes.Text= _License.Notes=="" ? "No Notes":_License.Notes;
            _LoadPersonImage();
        }    
    }
}
