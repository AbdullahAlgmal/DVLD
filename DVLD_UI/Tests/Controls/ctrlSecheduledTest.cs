using DVLD_UI.Properties;

namespace DVLD.Tests
{
    public partial class ctrlSecheduledTest: UserControl
    {
        private TestType.enTestType _TestTypeID;
        private int _TestID;
        private LocalDrivingLicensApplicationModel? _LocalDrivingLicenseApplication;
        private int _TestAppointmentID;
        private int _LocalDrivingLicenseApplicationID;
        private TestAppointmentModel? _TestAppointment;
        public TestType.enTestType TestTypeID
        {
            get => _TestTypeID;
            set
            {
                _TestTypeID = value;
                switch (_TestTypeID)
                {

                    case TestType.enTestType.VisionTest:
                    {
                            gbTestType.Text = "Vision Test";
                            pbTestTypeImage.Image = Resources.Vision_512;
                            break;
                    }
                    case TestType.enTestType.WrittenTest:
                    {
                            gbTestType.Text = "Written Test";
                            pbTestTypeImage.Image = Resources.Written_Test_512;
                            break;
                    }
                    case TestType.enTestType.StreetTest:
                    {
                            gbTestType.Text = "Street Test";
                            pbTestTypeImage.Image = Resources.driving_test_512;
                            break;
                    }
                }
            }
        }
        public int TestAppointmentID
        {
            get => _TestAppointmentID;
        }
        public int TestID
        {
            get => _TestID;
        }

        public void LoadInfo(int TestAppointmentID)
        {
            _TestAppointmentID = TestAppointmentID;        
            _TestAppointment = TestAppointment.Find(_TestAppointmentID);

            if (_TestAppointment is null)
            {
                MessageBox.Show("Error: No  Appointment ID = " + _TestAppointmentID.ToString(),"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _TestAppointmentID = -1;
                return;
            }

            _TestID = TestAppointment.GetTestId(_TestAppointmentID);           
            _LocalDrivingLicenseApplicationID = _TestAppointment.LocalDrivingLicensApplicationId;
            _LocalDrivingLicenseApplication = LocalDrivingLicensApplication.Find(_LocalDrivingLicenseApplicationID);

            if (_LocalDrivingLicenseApplication == null)
            {
                MessageBox.Show("Error: No Local Driving License Application with ID = " + _LocalDrivingLicenseApplicationID.ToString(),"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            lblLocalDrivingLicenseAppID.Text = _LocalDrivingLicenseApplication.Id.ToString();
            lblDrivingClass.Text = _LocalDrivingLicenseApplication?.LicenseClass?.ClassName;
            lblFullName.Text = _LocalDrivingLicenseApplication?.Application?.Person.FullName;
            lblTrial.Text = LocalDrivingLicensApplication.TotalTrialsPerTest(_LocalDrivingLicenseApplicationID, (byte)_TestTypeID).ToString();
            lblDate.Text = Format.DateToShort(_TestAppointment.AppointmentDate);
            lblFees.Text = _TestAppointment.PaidFees.ToString();
            lblTestID.Text = (TestAppointment.GetTestId(_TestAppointmentID) == default)? "Not Taken Yet": TestAppointment.GetTestId(_TestAppointmentID).ToString();
        }
        public ctrlSecheduledTest()
        {
            InitializeComponent();
        }
    }
}
