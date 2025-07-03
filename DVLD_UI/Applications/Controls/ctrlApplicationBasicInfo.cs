using DVLD_UI.People;

namespace DVLD_UI.Applications.Controls
{
    public partial class ctrlApplicationBasicInfo : UserControl
    {
        private ApplicationModel? _Application;
        private int _ApplicationId;

        public int ApplicationID
        {
            get => _ApplicationId;
        }

        public ctrlApplicationBasicInfo()
        {
            InitializeComponent();
        }

        public void LoadApplicationInfo(int ApplicationID)
        {
            _Application = Application0.Find(ApplicationID);
            if (_Application is null)
            {
                ResetApplicationInfo();
                MessageBox.Show($"No Application with ApplicationID = {ApplicationID}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                _FillApplicationInfo();
        }

        private void _FillApplicationInfo()
        {
            _ApplicationId = _Application?.ApplicationId ?? 0;
            lblId.Text = _Application?.ApplicationId.ToString() ?? "[???]";
            lblStatus.Text = _Application?.StatusText;
            lblType.Text = _Application?.ApplicationType?.Title ?? "[???]";
            lblFees.Text = _Application?.PaidFees.ToString() ?? "[$$$]";
            lblApplicant.Text = _Application?.ApplicantFullName;
            lblDate.Text = Format.DateToShort(_Application?.ApplicationDate ?? DateTime.UtcNow);
            lblStatusDate.Text = Format.DateToShort(_Application?.LastStatusDate ?? DateTime.UtcNow);
            lblCreatedBy.Text = _Application?.User?.UserName ?? "[???]";
        }

        public void ResetApplicationInfo()
        {
            _ApplicationId = default;

            lblId.Text = "[???]";
            lblStatus.Text = "[???]";
            lblType.Text = "[???]";
            lblFees.Text = "[$$$]";
            lblApplicant.Text = "[??/??/????]";
            lblDate.Text = "[??/??/????]";
            lblStatusDate.Text = "[???]";
            lblCreatedBy.Text = "[???]";
        }

        private void llViewPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowPersonInfo frm = new frmShowPersonInfo(_Application?.PersonId ?? 0);
            frm.ShowDialog();
            LoadApplicationInfo(_ApplicationId);
        }
    }
}
