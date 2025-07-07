namespace DVLD.Tests
{
    public partial class frmScheduleTest: Form
    {
        private int _LocalDrivingLicenseApplicationID;
        private TestType.enTestType _TestTypeID = TestType.enTestType.VisionTest;
        private int _AppointmentID=-1;

        public frmScheduleTest(int LocalDrivingLicenseApplicationID, TestType.enTestType TestTypeID, int AppointmentID = default)
        {          
            InitializeComponent();           
            _LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            _TestTypeID = TestTypeID;
            _AppointmentID = AppointmentID;          
        }
        private void frmScheduleTest_Load(object sender, EventArgs e)
        {
            ctrlScheduleTest1.TestTypeID= _TestTypeID;
            ctrlScheduleTest1.LoadInfo(_LocalDrivingLicenseApplicationID, _AppointmentID);
        }
    }
}
