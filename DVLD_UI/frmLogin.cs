using DVLD_Buisness;
using DVLD_DataAccess.Models;
using DVLD_UI.Global_Classes;
using Microsoft.Win32;

namespace DVLD_UI
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            UserModel? user = User.Find(txtUserName.Text.Trim(), txtPassword.Text.Trim());

            if (user is not null)
            {
                if (chkRememberMe.Checked)
                {
                    Properties.Settings.Default.UserName = txtUserName.Text.Trim();
                    Properties.Settings.Default.Password = txtPassword.Text.Trim();
                    Properties.Settings.Default.Save();
                }
                else
                {
                    Properties.Settings.Default.UserName = "";
                    Properties.Settings.Default.Password = "";
                    Properties.Settings.Default.Save();
                }

                if (!user.IsActive)
                {
                    txtUserName.Focus();
                    MessageBox.Show("Your accound is not Active, Contact Admin.", "In Active Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                LogedUser.CurrentUser = user;
                this.Hide();
                frmMain frm = new frmMain(this);
                frm.ShowDialog();
            }
            else
            {
                txtUserName.Focus();
                MessageBox.Show("Invalid Username/Password.", "Wrong Credintials", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtPassword.Text = Properties.Settings.Default.Password;
            if ((txtUserName.Text = Properties.Settings.Default.UserName) != "")
                chkRememberMe.Checked = true;
            else
                chkRememberMe.Checked = false;
        }
    }
}
