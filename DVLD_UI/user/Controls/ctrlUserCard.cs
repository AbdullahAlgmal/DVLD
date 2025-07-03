using DVLD_Buisness;
using DVLD_DataAccess.Models;

namespace DVLD_UI.user.Controls
{
    public partial class ctrlUserCard : UserControl
    {
        private UserModel? _User;
        private int _UserId;

        public int UserId
        {
            get => _UserId;
        }

        public ctrlUserCard()
        {
            InitializeComponent();
        }

        public void LoadUserInfo(int UserId)
        {
            _User = User.Find(UserId);

            if (_User is null)
            {
                _ResetPersonInfo();
                MessageBox.Show($"No user with UserId = {UserId}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FillUserInfo();
        }

        private void _FillUserInfo()
        {
            ctrlPersonCard1.LoadPersonInfo(_User?.PersonId ?? 0);
            lblUserId.Text = _User?.UserId.ToString() ?? "???";
            lblUserName.Text = _User?.UserName?.ToString() ?? "???";
            lblIsActive.Text = _User?.IsActive ?? false ? "Yes" : "No";
        }
        private void _ResetPersonInfo()
        {
            ctrlPersonCard1.ResetPersonInfo();
            lblUserId.Text = "{???}";
            lblUserName.Text = "{???}";
            lblIsActive.Text = "{???}";
        }

    }
}
