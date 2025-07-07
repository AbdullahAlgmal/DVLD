using DVLD_UI.Properties;

namespace DVLD.Licenses.International_Licenses.Controls
{
    public partial class ctrlDriverInternationalLicenseInfo : UserControl
    {
        private int _InternationalLicenseID;
        private InternationalLicenseModel? _InternationalLicense;
        public ctrlDriverInternationalLicenseInfo()
        {
            InitializeComponent();
        }
        public int InternationalLicenseID
        {
            get => _InternationalLicenseID;
        }
        private void _LoadPersonImage()
        {
            if (_InternationalLicense?.IssuedUsingLicense?.Driver?.Person.Gender == 0)
                pbPersonImage.Image = Resources.Male_512;
            else
                pbPersonImage.Image = Resources.Female_512;

            string ImagePath = _InternationalLicense?.IssuedUsingLicense?.Driver?.Person?.ImagePath ?? "";

            if (ImagePath != "")
                if (File.Exists(ImagePath))
                    pbPersonImage.Load(ImagePath);
                else
                    MessageBox.Show("Could not find this image: = " + ImagePath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public void LoadInfo(int InternationalLicenseID)
        {
            _InternationalLicenseID = InternationalLicenseID;
            _InternationalLicense = InternationalLicense.Find(_InternationalLicenseID);
            if (_InternationalLicense == null)
            {
                MessageBox.Show("Could not find Internationa License ID = " + _InternationalLicenseID.ToString(),"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _InternationalLicenseID = -1;
                return;
            }

            lblInternationalLicenseID.Text = _InternationalLicense.InternationalLicenseId.ToString();
            lblApplicationID.Text = _InternationalLicense.ApplicationId.ToString();
            lblIsActive.Text = _InternationalLicense.IsActive ? "Yes" : "No";
            lblLocalLicenseID.Text = _InternationalLicense.IssuedUsingLicenseId.ToString();
            lblFullName.Text = _InternationalLicense?.IssuedUsingLicense?.Driver?.Person?.FullName;
            lblNationalNo.Text = _InternationalLicense?.IssuedUsingLicense?.Driver?.Person?.NationalNumber;
            lblGendor.Text = _InternationalLicense?.IssuedUsingLicense?.Driver?.Person?.Gender == 0 ? "Male" : "Female";
            lblDateOfBirth.Text = Format.DateToShort(_InternationalLicense?.IssuedUsingLicense?.Driver?.Person?.BirthDate ?? DateTime.UtcNow);
            lblDriverID.Text = _InternationalLicense?.IssuedUsingLicense?.DriverId.ToString();
            lblIssueDate.Text = Format.DateToShort(_InternationalLicense?.IssueDate ?? DateTime.UtcNow);
            lblExpirationDate.Text = Format.DateToShort(_InternationalLicense?.ExpirationDate ?? DateTime.UtcNow);          
            _LoadPersonImage();
        }     
    }
}
