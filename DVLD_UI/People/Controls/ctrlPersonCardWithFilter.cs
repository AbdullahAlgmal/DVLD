using DVLD_DataAccess.Models;
using System.ComponentModel;

namespace DVLD_UI.People.Controls
{
    public partial class ctrlPersonCardWithFilter : UserControl
    {
        public event Action<int> OnPersonSelected;

        #region Properties
        private bool _ShowAddPerson = true;
        public bool ShowAddPerson
        {
            get
            {
                return _ShowAddPerson;
            }
            set
            {
                _ShowAddPerson = value;
                btAddNewPerson.Visible = _ShowAddPerson;
            }
        }

        private bool _FilterEnabled = true;
        public bool FilterEnabled
        {
            get
            {
                return _FilterEnabled;
            }
            set
            {
                _FilterEnabled = value;
                gbFilter.Enabled = _FilterEnabled;
            }
        }

        private int _PersonId = default;
        public int PersonId
        {
            get => ctrlPersonCard1.PersonId;
        }
        public PersonModel PersonInfo
        {
            get =>  ctrlPersonCard1.PersonInfo!;
        }
        #endregion

        public ctrlPersonCardWithFilter()
        {
            InitializeComponent();
        }

        public void FilterFocus()
        {
            cbFilterBy.Focus();
        }

        #region Private Methods
        public void LoadPersonInfo(int PersonId)
        {
            cbFilterBy.SelectedIndex = 1;
            txtFilterValue.Text = PersonId.ToString();
            FindNow();
        }
        private void FindNow()
        {
            if (cbFilterBy.Text == "Person ID")
                ctrlPersonCard1.LoadPersonInfo(int.Parse(txtFilterValue.Text));
            else if (cbFilterBy.Text == "National No.")
                ctrlPersonCard1.LoadPersonInfo(txtFilterValue.Text);

            if (FilterEnabled)
                OnPersonSelected?.Invoke(ctrlPersonCard1.PersonId);
        }
        private void DataBackEvent(object sender, int PersonId)
        {
            cbFilterBy.SelectedIndex = 1;
            txtFilterValue.Text = PersonId.ToString();
            ctrlPersonCard1.LoadPersonInfo(PersonId);
        }
        #endregion

        #region Events
        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterValue.Text = "";
            cbFilterBy.Focus();
        }
        private void btnFind_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            FindNow();
        }
        private void ctrlPersonCardWithFilter_Load(object sender, EventArgs e)
        {
            cbFilterBy.SelectedIndex = 0;
            cbFilterBy.Focus();
        }
        private void txtFilterValue_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtFilterValue.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtFilterValue, "This field is required!");
            }
            else
            {
                errorProvider1.SetError(txtFilterValue, null);
            }
        }
        private void btnAddNewPerson_Click(object sender, EventArgs e)
        {
            frmAddUpdatePerson frm = new();
            frm.DataBack += DataBackEvent;
            frm.ShowDialog();
        }
        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                btFind.PerformClick();

            if (cbFilterBy.Text == "Person ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        #endregion
    }
}
