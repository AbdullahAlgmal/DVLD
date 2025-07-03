using DVLD_UI.Properties;

namespace DVLD_UI.People.Controls
{
    public partial class ctrlPersonCard : UserControl
    {
        #region Properties
        public int PersonId { get; private set; } = default;
        public PersonModel? PersonInfo { get; private set; } = default;
        #endregion

        #region Constructors
        public ctrlPersonCard()
        {
            InitializeComponent();
        }
        #endregion

        #region Private Methods
        private void _FillPersonInfo()
        {
            llEditPersonInfo.Enabled = true;
            PersonId = PersonInfo!.PersonId;
            lblPersonId.Text = PersonInfo.PersonId.ToString();
            lblNationalNum.Text = PersonInfo.NationalNumber;
            lblFullName.Text = PersonInfo.FullName;
            lblGender.Text = PersonInfo.Gender == 0 ? "Male" : "Female";
            lblEmail.Text = PersonInfo.Email;
            lblPhone.Text = PersonInfo.Phone;
            lblDateOfBirth.Text = PersonInfo.BirthDate.ToShortDateString();
            lblCountry.Text = PersonInfo.Country.Name;
            lblAddress.Text = PersonInfo.Address;
            _LoadPersonImage();
        }
        private void _LoadPersonImage()
        {
            if (PersonInfo!.Gender == 0)
                pbPersonImage.Image = Resources.Male_512;
            else
                pbPersonImage.Image = Resources.Female_512;

            if (!string.IsNullOrEmpty(PersonInfo.ImagePath))
                if (File.Exists(PersonInfo.ImagePath))
                    pbPersonImage.ImageLocation = PersonInfo.ImagePath;
                else
                    MessageBox.Show("Could not Find this image: = " + PersonInfo.ImagePath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        private void llEditPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddUpdatePerson frm = new(PersonId);
            frm.ShowDialog();
            LoadPersonInfo(PersonId);
        }
        #endregion

        #region Public Methods
        public void LoadPersonInfo(int Id)
        {
            PersonInfo = Person.Find(Id);
            if (PersonInfo is null)
            {
                ResetPersonInfo();
                MessageBox.Show($"No Person with PersonID = {Id}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _FillPersonInfo();
        }
        public void LoadPersonInfo(string NationalNumber)
        {
            PersonInfo = Person.Find(NationalNumber);
            if (PersonInfo is null)
            {
                ResetPersonInfo();
                MessageBox.Show($"No Person with National Number = {NationalNumber}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _FillPersonInfo();
        }
        public void ResetPersonInfo()
        {
            llEditPersonInfo.Enabled = false;
            PersonId = default;
            PersonInfo = default;
            lblPersonId.Text = "[????]";
            lblNationalNum.Text = "[????]";
            lblFullName.Text = "[????]";
            pbGender.Image = Resources.Man_32;
            lblGender.Text = "[????]";
            lblEmail.Text = "[????]";
            lblPhone.Text = "[????]";
            lblDateOfBirth.Text = "[????]";
            lblCountry.Text = "[????]";
            lblAddress.Text = "[????]";
            pbPersonImage.Image = Resources.Male_512;
        }
        #endregion

        private void llEditPersonInfo_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddUpdatePerson frm = new frmAddUpdatePerson(PersonId);
            frm.ShowDialog();
            LoadPersonInfo(PersonId);
        }
    }
}
