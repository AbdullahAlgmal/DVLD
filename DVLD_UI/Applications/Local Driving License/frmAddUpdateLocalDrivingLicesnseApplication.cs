namespace DVLD_UI.Applications.Local_Driving_License
{
    public partial class frmAddUpdateLocalDrivingLicesnseApplication : Form
    {
        public enum enMode { AddNew = 0, Update = 1 };

        private enMode _Mode;
        private int _LocalDrivingLicenseApplicationId;
        private int _SelectedPersonId;
        LocalDrivingLicensApplicationModel? _LocalDrivingLicenseApplication;

        public frmAddUpdateLocalDrivingLicesnseApplication()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
        }
        public frmAddUpdateLocalDrivingLicesnseApplication(int LocalDrivingLicenseApplicationID)
        {
            InitializeComponent();
            _Mode = enMode.Update;
            _LocalDrivingLicenseApplicationId = LocalDrivingLicenseApplicationID;
        }

        private void _FillLicenseClassesInComoboBox()
        {
            foreach (DataRow row in LicenseClass.GetAll().Rows)
                cbLicenseClass.Items.Add(row["ClassName"]);
        }
        private void _ResetDefualtValues()
        {
            _FillLicenseClassesInComoboBox();

            if (_Mode == enMode.AddNew)
            {
                lblTitle.Text = "New Local Driving License0 Application";
                this.Text = "New Local Driving License0 Application";
                ctrlPersonCardWithFilter1.FilterFocus();
                tpApplicationInfo.Enabled = false;
                cbLicenseClass.SelectedIndex = 2;
                lblApplicationFees.Text = ApplicationType.Find((int)Application0.enApplicationType.NewDrivingLicense)?.Fees.ToString() ?? "0";
                lblApplicationDate.Text = DateTime.Now.ToShortDateString();
                lblCreatedBy.Text = LogedUser.CurrentUser?.UserName ?? "[???]";
            }
            else
            {
                lblTitle.Text = "Update Local Driving License0 Application";
                this.Text = "Update Local Driving License0 Application";
                tpApplicationInfo.Enabled = true;
                btSave.Enabled = true;
            }
        }
        private void _LoadData()
        {
            ctrlPersonCardWithFilter1.FilterEnabled = false;
            _LocalDrivingLicenseApplication = LocalDrivingLicensApplication.Find(_LocalDrivingLicenseApplicationId);

            if (_LocalDrivingLicenseApplication is null)
            {
                MessageBox.Show($"No Application with ID = {_LocalDrivingLicenseApplicationId}", "Application Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
                return;
            }
            ctrlPersonCardWithFilter1.LoadPersonInfo(_LocalDrivingLicenseApplication?.Application?.PersonId ?? 0);
            lblDLAppId.Text = _LocalDrivingLicenseApplication?.ApplicationId.ToString() ?? "0";
            lblApplicationDate.Text = Format.DateToShort(_LocalDrivingLicenseApplication?.Application?.ApplicationDate ?? DateTime.UtcNow);
            cbLicenseClass.SelectedIndex = cbLicenseClass.FindString(LicenseClass.Find(_LocalDrivingLicenseApplication?.LicenseClassId ?? 0)?.ClassName ?? "");
            lblApplicationFees.Text = _LocalDrivingLicenseApplication?.Application?.PaidFees.ToString() ?? "[$$$]";
            lblCreatedBy.Text = User.Find(_LocalDrivingLicenseApplication?.Application?.User?.UserId ?? 0)?.UserName ?? "[???]";
        }
        private void frmAddUpdateLocalDrivingLicesnseApplication_Load(object sender, EventArgs e)
        {
            _ResetDefualtValues();
            if (_Mode == enMode.Update)
                _LoadData();
        }
        private void btnApplicationInfoNext_Click(object sender, EventArgs e)
        {
            if (_Mode == enMode.Update)
            {
                btSave.Enabled = true;
                tpApplicationInfo.Enabled = true;
                tcApplicationInfo.SelectedTab = tcApplicationInfo.TabPages["tpApplicationInfo"];
                return;
            }

            if (ctrlPersonCardWithFilter1.PersonId != default)
            {
                btSave.Enabled = true;
                tpApplicationInfo.Enabled = true;
                tcApplicationInfo.SelectedTab = tcApplicationInfo.TabPages["tpApplicationInfo"];
            }
            else
            {
                MessageBox.Show("Please Select a Person", "Select a Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ctrlPersonCardWithFilter1.FilterFocus();
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int LicenseClassID = LicenseClass.Find(cbLicenseClass.Text)?.LicenseClassId ?? 0;
            int ActiveApplicationID = Application0.FindActiveApplicationIdForLicenseClass(_SelectedPersonId, (int)Application0.enApplicationType.NewDrivingLicense, LicenseClassID);
            if (ActiveApplicationID != default)
            {
                MessageBox.Show("Choose another License0 Class, the selected Person Already have an active application for the selected class with id=" + ActiveApplicationID, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbLicenseClass.Focus();
                return;
            }

            if (License0.IsLicenseExistByPersonId(ctrlPersonCardWithFilter1.PersonId, LicenseClassID))
            {
                MessageBox.Show("Person already have a license with the same applied driving class, Choose diffrent driving class", "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ApplicationModel application = new(
                default,
                ctrlPersonCardWithFilter1.PersonId,
                DateTime.Now,
                1,
                (byte)Application0.enApplicationStatus.New,
                DateTime.Now,
                Convert.ToSingle(lblApplicationFees.Text),
                LogedUser.CurrentUser?.UserId ?? 0
            );
            if (Application0.Add(application))
            {
                _LocalDrivingLicenseApplication = new LocalDrivingLicensApplicationModel(
                    _LocalDrivingLicenseApplicationId,
                    application.ApplicationId,
                    LicenseClassID
                );
                if (_Mode == enMode.AddNew ? LocalDrivingLicensApplication.Add(_LocalDrivingLicenseApplication) : LocalDrivingLicensApplication.Update(_LocalDrivingLicenseApplication))
                {
                    lblDLAppId.Text = _LocalDrivingLicenseApplication?.Id.ToString() ?? "0";
                    _Mode = enMode.Update;
                    lblTitle.Text = "Update Local Driving License0 Application";
                    MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
            else
                MessageBox.Show("Error: Application Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void ctrlPersonCardWithFilter1_OnPersonSelected(int obj)
        {
            _SelectedPersonId = obj;
        }
        private void frmAddUpdateLocalDrivingLicesnseApplication_Activated(object sender, EventArgs e)
        {
            ctrlPersonCardWithFilter1.FilterFocus();
        }
    }
}
