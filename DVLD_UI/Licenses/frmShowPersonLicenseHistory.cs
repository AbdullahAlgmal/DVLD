namespace DVLD.Licenses.International_License
{
    public partial class frmShowPersonLicenseHistory : Form
    {
        private int _PersonID;
        public frmShowPersonLicenseHistory()
        {
            InitializeComponent();          
        }
        public frmShowPersonLicenseHistory(int PersonID)
        {
            InitializeComponent();
            _PersonID = PersonID;   
        }
        private void frmShowPersonLicenseHistory_Load(object sender, EventArgs e)
        {
            if (_PersonID != default)
            {
                ctrlPersonCardWithFilter1.LoadPersonInfo(_PersonID);
                ctrlPersonCardWithFilter1.FilterEnabled = false;
                ctrlDriverLicenses1.LoadInfoByPersonID(_PersonID);
            }
            else
            {
                ctrlPersonCardWithFilter1.Enabled = true;
                ctrlPersonCardWithFilter1.FilterFocus();
            }
        }
    }
}
