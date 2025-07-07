using DVLD_UI.Properties;

namespace DVLD.Tests
{
    public partial class frmListTestAppointments: Form
    {
        private DataTable _dtLicenseTestAppointments;
        private int _LocalDrivingLicenseApplicationID ;
        private TestType.enTestType _TestType = TestType.enTestType.VisionTest;

        public frmListTestAppointments(int LocalDrivingLicenseApplicationID, TestType.enTestType TestType)
        {
            InitializeComponent();
            _LocalDrivingLicenseApplicationID= LocalDrivingLicenseApplicationID;
            _TestType = TestType;
        }
        private void _LoadTestTypeImageAndTitle()
        {
            switch (_TestType)
            {
                case TestType.enTestType.VisionTest:
                {
                        lblTitle.Text = "Vision Test Appointments";
                        this.Text= lblTitle.Text;
                        pbTestTypeImage.Image = Resources.Vision_512;
                        break;
                }
                case TestType.enTestType.WrittenTest:
                {
                        lblTitle.Text = "Written Test Appointments";
                        this.Text = lblTitle.Text;
                        pbTestTypeImage.Image = Resources.Written_Test_512;
                        break;
                }
                case TestType.enTestType.StreetTest:
                {
                        lblTitle.Text = "Street Test Appointments";
                        this.Text = lblTitle.Text;
                        pbTestTypeImage.Image = Resources.driving_test_512;
                        break;
                }
            }
        }
        private void frmListTestAppointments_Load(object sender, EventArgs e)
        {
            _LoadTestTypeImageAndTitle();
            ctrlDrivingLicenseApplicationInfo1.LoadApplicationInfoByLocalDrivingAppID(_LocalDrivingLicenseApplicationID);
            _dtLicenseTestAppointments = TestAppointment.GetApplicationTestAppointmentsPerTestType((byte)_TestType, _LocalDrivingLicenseApplicationID);        
            dgvLicenseTestAppointments.DataSource = _dtLicenseTestAppointments;
            lblRecordsCount.Text = dgvLicenseTestAppointments.Rows.Count.ToString();

            if (dgvLicenseTestAppointments.Rows.Count>0)
            {
                dgvLicenseTestAppointments.Columns[0].HeaderText = "Appointment ID";
                dgvLicenseTestAppointments.Columns[0].Width = 150;

                dgvLicenseTestAppointments.Columns[1].HeaderText = "Appointment Date";
                dgvLicenseTestAppointments.Columns[1].Width = 200;

                dgvLicenseTestAppointments.Columns[2].HeaderText = "Paid Fees";
                dgvLicenseTestAppointments.Columns[2].Width = 150;

                dgvLicenseTestAppointments.Columns[3].HeaderText = "Is Locked";
                dgvLicenseTestAppointments.Columns[3].Width = 100;
            }        
        }
        private void btnAddNewAppointment_Click(object sender, EventArgs e)
        {
            LocalDrivingLicensApplicationModel? localDrivingLicenseApplication = LocalDrivingLicensApplication.Find(_LocalDrivingLicenseApplicationID);

            if (LocalDrivingLicensApplication.IsThereAnActiveScheduledTest(localDrivingLicenseApplication?.Id ?? 0, (byte)_TestType))
            {
                MessageBox.Show("Person Already have an active appointment for this test, You cannot add new appointment", "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
             TestModel? LastTest = LocalDrivingLicensApplication.GetLastTestPerTestType(_LocalDrivingLicenseApplicationID, (byte)(localDrivingLicenseApplication?.LicenseClassId ?? 0), localDrivingLicenseApplication?.Application?.PersonId ?? 0, (byte)_TestType);

            if (LastTest is null)
            {
                frmScheduleTest frm1 = new frmScheduleTest(_LocalDrivingLicenseApplicationID, _TestType);
                frm1.ShowDialog();
                frmListTestAppointments_Load(null!, null!);
                return;
            }
            if (LastTest.Result == true)
            {
                MessageBox.Show("This person already passed this test before, you can only retake faild test", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            frmScheduleTest frm2 = new(LastTest.TestAppointment?.LocalDrivingLicensApplicationId ?? default, _TestType);
            frm2.ShowDialog();
            frmListTestAppointments_Load(null!, null!);
        }
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int TestAppointmentID = (int)dgvLicenseTestAppointments.CurrentRow.Cells[0].Value;

            frmScheduleTest frm = new frmScheduleTest(_LocalDrivingLicenseApplicationID, _TestType, TestAppointmentID);
            frm.ShowDialog();
            frmListTestAppointments_Load(null!, null!);
        }
        private void takeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int TestAppointmentID = (int)dgvLicenseTestAppointments.CurrentRow.Cells[0].Value;

            frmTakeTest frm = new frmTakeTest(TestAppointmentID, _TestType);
            frm.ShowDialog();
            frmListTestAppointments_Load(null!, null!);
        }
    }
}
