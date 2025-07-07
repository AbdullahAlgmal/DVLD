namespace DVLD.Tests
{
    public partial class frmTakeTest: Form
    {
        private int _AppointmentID;
        private TestType.enTestType _TestType;
        private int _TestID;
        private TestModel? _Test;

        public frmTakeTest(int AppointmentID, TestType.enTestType TestType )
        {
            InitializeComponent();
            _AppointmentID= AppointmentID;
            _TestType = TestType;
        }
        private void frmTakeTest_Load(object sender, EventArgs e)
        {
            ctrlSecheduledTest1.TestTypeID = _TestType;
            ctrlSecheduledTest1.LoadInfo(_AppointmentID);
            
            if (ctrlSecheduledTest1.TestAppointmentID == default)
                btnSave.Enabled = false;
            else
                btnSave.Enabled = true;

            int _TestID = ctrlSecheduledTest1.TestID;
            if (_TestID != default)
            {
                _Test = Test.Find(_TestID);

                if (_Test?.Result ?? false)
                    rbPass.Checked = true;
                else
                    rbFail.Checked = true;
                   txtNotes.Text = _Test?.Notes;

                lblUserMessage.Visible = true;
                rbFail.Enabled = false; 
                rbPass.Enabled = false;
            }          
            else
                _Test = new();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
          if (MessageBox.Show("Are you sure you want to save? After that you cannot change the Pass/Fail results after you save?.","Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)==DialogResult.No)
                return;

            _Test!.TestAppointmentId = _AppointmentID;
            _Test.Result = rbPass.Checked;
            _Test.Notes = txtNotes.Text.Trim();
            _Test.CreatedByUserId = LogedUser.CurrentUser?.UserId ?? 0;

            if (Test.Add(_Test))
            {
                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnSave.Enabled = false;
            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
