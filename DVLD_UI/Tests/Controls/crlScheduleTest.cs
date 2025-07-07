using DVLD_UI.Properties;

namespace DVLD.Tests
{

  
    public partial class ctrlScheduleTest : UserControl
    {   
        public enum enMode { AddNew = 0, Update = 1 };
        public enum enCreationMode { FirstTimeSchedule = 0, RetakeTestSchedule = 1 };

        private enMode _Mode = enMode.AddNew;      
        private enCreationMode _CreationMode = enCreationMode.FirstTimeSchedule;

        private TestType.enTestType _TestTypeID = TestType.enTestType.VisionTest; 
        private LocalDrivingLicensApplicationModel? _LocalDrivingLicenseApplication;
        private int _LocalDrivingLicenseApplicationID;
        private TestAppointmentModel? _TestAppointment;
        private int _TestAppointmentID;

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

        public void LoadInfo(int LocalDrivingLicenseApplicationID,int AppointmentID = default)
        {
            if (AppointmentID == default)
                _Mode = enMode.AddNew;
            else
                _Mode = enMode.Update;

            _LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            _TestAppointmentID = AppointmentID;     
            _LocalDrivingLicenseApplication =  LocalDrivingLicensApplication.Find(_LocalDrivingLicenseApplicationID);

           if (_LocalDrivingLicenseApplication is null)
           {
                MessageBox.Show($"Error: No Local Driving License Application with ID = {_LocalDrivingLicenseApplicationID}","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnSave.Enabled = false;
                return;
           }
            if (LocalDrivingLicensApplication.DoesAttendTestType(_LocalDrivingLicenseApplicationID, (byte)_TestTypeID))           
                _CreationMode = enCreationMode.RetakeTestSchedule;
            else
                _CreationMode = enCreationMode.FirstTimeSchedule;

            if (_CreationMode == enCreationMode.RetakeTestSchedule)
            {
                lblRetakeAppFees.Text = ApplicationType.Find((int)Application0.enApplicationType.RetakeTest)?.Fees.ToString() ?? "0";
                gbRetakeTestInfo.Enabled = true;
                lblTitle.Text = "Schedule Retake Test";
                lblRetakeTestAppID.Text = "0";
            }
            else
            {
                gbRetakeTestInfo.Enabled = false;
                lblTitle.Text = "Schedule Test";
                lblRetakeAppFees.Text = "0";
                lblRetakeTestAppID.Text = "N/A";
            }

            lblLocalDrivingLicenseAppID.Text = _LocalDrivingLicenseApplication.Id.ToString();
            lblDrivingClass.Text = _LocalDrivingLicenseApplication?.LicenseClass?.ClassName;
            lblFullName.Text = _LocalDrivingLicenseApplication?.Application?.Person.FullName;
            lblTrial.Text = LocalDrivingLicensApplication.TotalTrialsPerTest(_LocalDrivingLicenseApplicationID, (byte)_TestTypeID).ToString();

            if (_Mode == enMode.AddNew)
            {
                lblFees.Text = TestType.Find((byte)_TestTypeID)?.Fees.ToString();
                dtpTestDate.MinDate = DateTime.Now;
                lblRetakeTestAppID.Text = "N/A";        
                _TestAppointment = new();
            }
            else
            {
                if (!_LoadTestAppointmentData())
                    return;
            }
         
            lblTotalFees.Text= (Convert.ToSingle(lblFees.Text) + Convert.ToSingle(lblRetakeAppFees.Text)).ToString();

           if (!_HandleActiveTestAppointmentConstraint())
                return;

            if (!_HandleAppointmentLockedConstraint())
                return;

            if (!_HandlePrviousTestConstraint())
                return;            
        }
        private bool _HandleActiveTestAppointmentConstraint()
        {
            if (_Mode == enMode.AddNew && LocalDrivingLicensApplication.IsThereAnActiveScheduledTest(_LocalDrivingLicenseApplicationID, (byte)_TestTypeID))
            {
                lblUserMessage.Text = "Person Already have an active appointment for this test";
                btnSave.Enabled = false;
                dtpTestDate.Enabled = false;
                return false;
            }

            return true;
        }
        private bool _LoadTestAppointmentData()
        {
            _TestAppointment = TestAppointment.Find(_TestAppointmentID);

            if (_TestAppointment is null)
            {
                MessageBox.Show("Error: No Appointment with ID = " + _TestAppointmentID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnSave.Enabled = false;
                return false;
            }

            lblFees.Text = _TestAppointment.PaidFees.ToString();

            if (DateTime.Compare(DateTime.Now, _TestAppointment.AppointmentDate) < 0)
                dtpTestDate.MinDate = DateTime.Now;
            else
                dtpTestDate.MinDate = _TestAppointment.AppointmentDate;

            dtpTestDate.Value = _TestAppointment.AppointmentDate;

            if (_TestAppointment.RetakeTestApplicationId == default)
            {
                lblRetakeAppFees.Text = "0";
                lblRetakeTestAppID.Text = "N/A";
            }
            else
            {
                lblRetakeAppFees.Text = _TestAppointment?.RetakeApplication?.PaidFees.ToString() ?? "0";
                gbRetakeTestInfo.Enabled = true;
                lblTitle.Text = "Schedule Retake Test";
                lblRetakeTestAppID.Text = _TestAppointment?.RetakeTestApplicationId.ToString() ?? "0";
            }
            return true;
        }
        private bool _HandleAppointmentLockedConstraint()
        {
            if (_TestAppointment?.IsLocked ?? true)
            {
                lblUserMessage.Visible = true;
                lblUserMessage.Text = "Person already sat for the test, appointment loacked.";
                dtpTestDate.Enabled = false;
                btnSave.Enabled = false;
                return false;
            }
            else
                lblUserMessage.Visible = false;

            return true;
        }
        private bool _HandlePrviousTestConstraint()
        {
            switch (TestTypeID)
            {
                case TestType.enTestType.VisionTest:
                    lblUserMessage.Visible = false;
                    return true;
                case TestType.enTestType.WrittenTest:
                    if (!LocalDrivingLicensApplication.DoesPassTestType(_LocalDrivingLicenseApplicationID, (byte)TestType.enTestType.VisionTest))
                    {
                        lblUserMessage.Text = "Cannot Sechule, Vision Test should be passed first";
                        lblUserMessage.Visible = true;
                        btnSave.Enabled = false;
                        dtpTestDate.Enabled = false;
                        return false;
                    }
                    else
                    {
                        lblUserMessage.Visible = false;
                        btnSave.Enabled = true;
                        dtpTestDate.Enabled = true;
                    }
                    return true;
                case TestType.enTestType.StreetTest:
                    if (!LocalDrivingLicensApplication.DoesPassTestType(_LocalDrivingLicenseApplicationID, (byte)TestType.enTestType.WrittenTest))
                    {
                        lblUserMessage.Text = "Cannot Sechule, Written Test should be passed first";
                        lblUserMessage.Visible = true;
                        btnSave.Enabled = false;
                        dtpTestDate.Enabled = false;
                        return false;
                    }
                    else
                    {
                        lblUserMessage.Visible = false;
                        btnSave.Enabled = true;
                        dtpTestDate.Enabled = true;
                    }
                    return true;
            }
            return true;
        }
        private bool _HandleRetakeApplication()
        {
            if (_Mode == enMode.AddNew && _CreationMode == enCreationMode.RetakeTestSchedule)
            {
                //First Create Applicaiton 
                ApplicationModel Application = new(default,
                                                   _LocalDrivingLicenseApplication?.Application?.PersonId
                                                   ?? 0,
                                                   DateTime.Now,
                                                   (int)Application0.enApplicationType.RetakeTest,
                                                   (byte)Application0.enApplicationStatus.Completed,
                                                   DateTime.Now,
                                                   ApplicationType.Find((byte)Application0.enApplicationType.RetakeTest)?.Fees ?? 0,
                                                   LogedUser.CurrentUser?.UserId ?? 0);
                if (!Application0.Add(Application))
                {
                    _TestAppointment!.RetakeTestApplicationId = default;
                    MessageBox.Show("Faild to Create application", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                _TestAppointment!.RetakeTestApplicationId = Application.ApplicationId;                
            }
            return true;
        }
        public ctrlScheduleTest()
        {
            InitializeComponent();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!_HandleRetakeApplication())
                return;

            _TestAppointment!.TestTypeId = (byte)_TestTypeID;
            _TestAppointment.LocalDrivingLicensApplicationId = _LocalDrivingLicenseApplication?.Id ?? 0;
            _TestAppointment.AppointmentDate = dtpTestDate.Value;
            _TestAppointment.PaidFees = Convert.ToSingle(lblFees.Text);
            _TestAppointment.UserId = LogedUser.CurrentUser?.UserId ?? 0;
            
            if (TestAppointment.Add(_TestAppointment))
            {
                _Mode = enMode.Update;
              MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);           
            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
