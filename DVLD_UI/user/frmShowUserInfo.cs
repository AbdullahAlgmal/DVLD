namespace DVLD_UI.user
{
    public partial class frmShowUserInfo : Form
    {
        public frmShowUserInfo(int UserId)
        {
            InitializeComponent();
            ctrlUserCard1.LoadUserInfo(UserId);
        }
    }
}
