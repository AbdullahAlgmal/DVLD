﻿namespace DVLD_UI.Tests.Test_Types
{
    public partial class frmEditTestType : Form
    {
        private int _TestTypeId;
        private TestTypeModel? _TestType;

        public frmEditTestType(int TestTypeID)
        {
            InitializeComponent();
            _TestTypeId = TestTypeID;
        }

        private void frmEditTestType_Load(object sender, EventArgs e)
        {
            _TestType = TestType.Find(_TestTypeId);

            if (_TestType is not null)
            {
                lblTestTypeId.Text = _TestTypeId.ToString();
                txtTitle.Text = _TestType.Title;
                txtDescription.Text = _TestType.Description;
                txtFees.Text = _TestType.Fees.ToString();
            }
            else
            {
                MessageBox.Show($"Could not find Test Type with id = {_TestTypeId}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _TestType!.Title = txtTitle.Text.Trim();
            _TestType.Description = txtDescription.Text.Trim();
            _TestType.Fees = Convert.ToSingle(txtFees.Text.Trim());

            if (TestType.Update(_TestType))
                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void txtTitle_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtTitle.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtTitle, "Title cannot be empty!");
            }
        }
        private void txtDescription_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtDescription.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtDescription, "Description cannot be empty!");
            }
        }
        private void txtFees_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtFees.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtFees, "Fees cannot be empty!");
                return;
            }

            if (!Validation.IsNumber(txtFees.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtFees, "Invalid Number.");
            }
        }
    }
}
