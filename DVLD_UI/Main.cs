using DVLD_UI.Application_Types;
using DVLD_UI.Drivers;
using DVLD_UI.People;
using DVLD_UI.Tests.Test_Types;
using DVLD_UI.user;

namespace DVLD_UI
{
    public partial class frmMain : Form
    {
        frmLogin _frmLogin;
        public frmMain(frmLogin frm)
        {
            InitializeComponent();
            _frmLogin = frm;
        }

        private void peopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListPeople ManagePeople = new frmListPeople();
            ManagePeople.ShowDialog();
        }
        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmListUsers();
            frm.ShowDialog();
        }
        private void currentUserInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowUserInfo frm = new frmShowUserInfo(LogedUser.CurrentUser?.UserId ?? 0);
            frm.ShowDialog();
        }
        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LogedUser.CurrentUser = null;
            this.Close();
        }
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            _frmLogin.Close();
        }
        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChangePassword frm = new(LogedUser.CurrentUser?.UserId ?? 0);
            frm.ShowDialog();
        }
        private void driversToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListDrivers frm = new frmListDrivers();
            frm.ShowDialog();
        }

        private void manageApplicationTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListApplicationTypes frm = new();
            frm.ShowDialog();
        }

        private void managToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListTestTypes frm = new();
            frm.ShowDialog();
        }
    }
}
