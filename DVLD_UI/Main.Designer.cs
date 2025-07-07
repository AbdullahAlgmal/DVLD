namespace DVLD_UI
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            applicationsToolStripMenuItem = new ToolStripMenuItem();
            drivingLicensesServicesToolStripMenuItem = new ToolStripMenuItem();
            newDrivingLIixenseToolStripMenuItem = new ToolStripMenuItem();
            localLicenseToolStripMenuItem = new ToolStripMenuItem();
            internationalLicenseToolStripMenuItem = new ToolStripMenuItem();
            renewDrivingLicenseToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator4 = new ToolStripSeparator();
            replacementForLostOrDamagedLicenseToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator5 = new ToolStripSeparator();
            releaseDetianedDrivingLicenseToolStripMenuItem = new ToolStripMenuItem();
            retakeTestToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            manageApplicationsToolStripMenuItem = new ToolStripMenuItem();
            localDrivingLicenseApplicationToolStripMenuItem = new ToolStripMenuItem();
            internationalDrivingLicenseApplicationsToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            detainLicensesToolStripMenuItem = new ToolStripMenuItem();
            manageToolStripMenuItem = new ToolStripMenuItem();
            detainLicenseToolStripMenuItem = new ToolStripMenuItem();
            releaseDetainedLicenseToolStripMenuItem = new ToolStripMenuItem();
            manageApplicationTypesToolStripMenuItem = new ToolStripMenuItem();
            managToolStripMenuItem = new ToolStripMenuItem();
            peopleToolStripMenuItem = new ToolStripMenuItem();
            driversToolStripMenuItem = new ToolStripMenuItem();
            usersToolStripMenuItem = new ToolStripMenuItem();
            accountStToolStripMenuItem = new ToolStripMenuItem();
            currentUserInfoToolStripMenuItem = new ToolStripMenuItem();
            changePasswordToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            signOutToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            menuStrip1.SuspendLayout();
            ((ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menuStrip1.Items.AddRange(new ToolStripItem[] { applicationsToolStripMenuItem, peopleToolStripMenuItem, driversToolStripMenuItem, usersToolStripMenuItem, accountStToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1284, 72);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // applicationsToolStripMenuItem
            // 
            applicationsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { drivingLicensesServicesToolStripMenuItem, toolStripSeparator2, manageApplicationsToolStripMenuItem, toolStripSeparator3, detainLicensesToolStripMenuItem, manageApplicationTypesToolStripMenuItem, managToolStripMenuItem });
            applicationsToolStripMenuItem.Image = Properties.Resources.Applications_64;
            applicationsToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            applicationsToolStripMenuItem.Name = "applicationsToolStripMenuItem";
            applicationsToolStripMenuItem.Size = new Size(201, 68);
            applicationsToolStripMenuItem.Text = "&Applications";
            // 
            // drivingLicensesServicesToolStripMenuItem
            // 
            drivingLicensesServicesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newDrivingLIixenseToolStripMenuItem, renewDrivingLicenseToolStripMenuItem, toolStripSeparator4, replacementForLostOrDamagedLicenseToolStripMenuItem, toolStripSeparator5, releaseDetianedDrivingLicenseToolStripMenuItem, retakeTestToolStripMenuItem });
            drivingLicensesServicesToolStripMenuItem.Font = new Font("Arial", 12F, FontStyle.Bold);
            drivingLicensesServicesToolStripMenuItem.Image = Properties.Resources.Driver_License_48;
            drivingLicensesServicesToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            drivingLicensesServicesToolStripMenuItem.Name = "drivingLicensesServicesToolStripMenuItem";
            drivingLicensesServicesToolStripMenuItem.Size = new Size(327, 70);
            drivingLicensesServicesToolStripMenuItem.Text = "&Driving Licenses Services";
            // 
            // newDrivingLIixenseToolStripMenuItem
            // 
            newDrivingLIixenseToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { localLicenseToolStripMenuItem, internationalLicenseToolStripMenuItem });
            newDrivingLIixenseToolStripMenuItem.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            newDrivingLIixenseToolStripMenuItem.Image = Properties.Resources.New_Driving_License_32;
            newDrivingLIixenseToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            newDrivingLIixenseToolStripMenuItem.Name = "newDrivingLIixenseToolStripMenuItem";
            newDrivingLIixenseToolStripMenuItem.Size = new Size(406, 38);
            newDrivingLIixenseToolStripMenuItem.Text = "&New Driving License0";
            // 
            // localLicenseToolStripMenuItem
            // 
            localLicenseToolStripMenuItem.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            localLicenseToolStripMenuItem.Image = Properties.Resources.Local_32;
            localLicenseToolStripMenuItem.Name = "localLicenseToolStripMenuItem";
            localLicenseToolStripMenuItem.Size = new Size(216, 22);
            localLicenseToolStripMenuItem.Text = "&Local License0";
            localLicenseToolStripMenuItem.Click += localLicenseToolStripMenuItem_Click;
            // 
            // internationalLicenseToolStripMenuItem
            // 
            internationalLicenseToolStripMenuItem.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            internationalLicenseToolStripMenuItem.Image = Properties.Resources.International_32;
            internationalLicenseToolStripMenuItem.Name = "internationalLicenseToolStripMenuItem";
            internationalLicenseToolStripMenuItem.Size = new Size(216, 22);
            internationalLicenseToolStripMenuItem.Text = "&International License0";
            internationalLicenseToolStripMenuItem.Click += internationalLicenseToolStripMenuItem_Click;
            // 
            // renewDrivingLicenseToolStripMenuItem
            // 
            renewDrivingLicenseToolStripMenuItem.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            renewDrivingLicenseToolStripMenuItem.Image = Properties.Resources.Renew_Driving_License_32;
            renewDrivingLicenseToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            renewDrivingLicenseToolStripMenuItem.Name = "renewDrivingLicenseToolStripMenuItem";
            renewDrivingLicenseToolStripMenuItem.Size = new Size(406, 38);
            renewDrivingLicenseToolStripMenuItem.Text = "&Renew Driving License0";
            renewDrivingLicenseToolStripMenuItem.Click += renewDrivingLicenseToolStripMenuItem_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(403, 6);
            // 
            // replacementForLostOrDamagedLicenseToolStripMenuItem
            // 
            replacementForLostOrDamagedLicenseToolStripMenuItem.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            replacementForLostOrDamagedLicenseToolStripMenuItem.Image = Properties.Resources.Damaged_Driving_License_32;
            replacementForLostOrDamagedLicenseToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            replacementForLostOrDamagedLicenseToolStripMenuItem.Name = "replacementForLostOrDamagedLicenseToolStripMenuItem";
            replacementForLostOrDamagedLicenseToolStripMenuItem.Size = new Size(406, 38);
            replacementForLostOrDamagedLicenseToolStripMenuItem.Text = "Replacement For Lost or &Damaged License0";
            replacementForLostOrDamagedLicenseToolStripMenuItem.Click += replacementForLostOrDamagedLicenseToolStripMenuItem_Click;
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(403, 6);
            // 
            // releaseDetianedDrivingLicenseToolStripMenuItem
            // 
            releaseDetianedDrivingLicenseToolStripMenuItem.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            releaseDetianedDrivingLicenseToolStripMenuItem.Image = Properties.Resources.Detained_Driving_License_32;
            releaseDetianedDrivingLicenseToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            releaseDetianedDrivingLicenseToolStripMenuItem.Name = "releaseDetianedDrivingLicenseToolStripMenuItem";
            releaseDetianedDrivingLicenseToolStripMenuItem.Size = new Size(406, 38);
            releaseDetianedDrivingLicenseToolStripMenuItem.Text = "Release Detianed Driving License0";
            releaseDetianedDrivingLicenseToolStripMenuItem.Click += releaseDetianedDrivingLicenseToolStripMenuItem_Click;
            // 
            // retakeTestToolStripMenuItem
            // 
            retakeTestToolStripMenuItem.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            retakeTestToolStripMenuItem.Image = Properties.Resources.Retake_Test_32;
            retakeTestToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            retakeTestToolStripMenuItem.Name = "retakeTestToolStripMenuItem";
            retakeTestToolStripMenuItem.Size = new Size(406, 38);
            retakeTestToolStripMenuItem.Text = "Retake Test";
            retakeTestToolStripMenuItem.Click += retakeTestToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(324, 6);
            // 
            // manageApplicationsToolStripMenuItem
            // 
            manageApplicationsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { localDrivingLicenseApplicationToolStripMenuItem, internationalDrivingLicenseApplicationsToolStripMenuItem });
            manageApplicationsToolStripMenuItem.Font = new Font("Arial", 12F, FontStyle.Bold);
            manageApplicationsToolStripMenuItem.Image = Properties.Resources.Manage_Applications_64;
            manageApplicationsToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            manageApplicationsToolStripMenuItem.Name = "manageApplicationsToolStripMenuItem";
            manageApplicationsToolStripMenuItem.Size = new Size(327, 70);
            manageApplicationsToolStripMenuItem.Text = "Manage Applications";
            // 
            // localDrivingLicenseApplicationToolStripMenuItem
            // 
            localDrivingLicenseApplicationToolStripMenuItem.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            localDrivingLicenseApplicationToolStripMenuItem.Image = Properties.Resources.LocalDriving_License;
            localDrivingLicenseApplicationToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            localDrivingLicenseApplicationToolStripMenuItem.Name = "localDrivingLicenseApplicationToolStripMenuItem";
            localDrivingLicenseApplicationToolStripMenuItem.Size = new Size(395, 38);
            localDrivingLicenseApplicationToolStripMenuItem.Text = "Local Driving License0 Applications";
            localDrivingLicenseApplicationToolStripMenuItem.Click += localDrivingLicenseApplicationToolStripMenuItem_Click;
            // 
            // internationalDrivingLicenseApplicationsToolStripMenuItem
            // 
            internationalDrivingLicenseApplicationsToolStripMenuItem.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            internationalDrivingLicenseApplicationsToolStripMenuItem.Image = Properties.Resources.International_321;
            internationalDrivingLicenseApplicationsToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            internationalDrivingLicenseApplicationsToolStripMenuItem.Name = "internationalDrivingLicenseApplicationsToolStripMenuItem";
            internationalDrivingLicenseApplicationsToolStripMenuItem.Size = new Size(395, 38);
            internationalDrivingLicenseApplicationsToolStripMenuItem.Text = "International Driving License0 Applications";
            internationalDrivingLicenseApplicationsToolStripMenuItem.Click += internationalDrivingLicenseApplicationsToolStripMenuItem_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(324, 6);
            // 
            // detainLicensesToolStripMenuItem
            // 
            detainLicensesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { manageToolStripMenuItem, detainLicenseToolStripMenuItem, releaseDetainedLicenseToolStripMenuItem });
            detainLicensesToolStripMenuItem.Font = new Font("Arial", 12F, FontStyle.Bold);
            detainLicensesToolStripMenuItem.Image = Properties.Resources.Detain_64;
            detainLicensesToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            detainLicensesToolStripMenuItem.Name = "detainLicensesToolStripMenuItem";
            detainLicensesToolStripMenuItem.Size = new Size(327, 70);
            detainLicensesToolStripMenuItem.Text = "Detain Licenses";
            // 
            // manageToolStripMenuItem
            // 
            manageToolStripMenuItem.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            manageToolStripMenuItem.Image = Properties.Resources.Detain_32;
            manageToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            manageToolStripMenuItem.Name = "manageToolStripMenuItem";
            manageToolStripMenuItem.Size = new Size(288, 38);
            manageToolStripMenuItem.Text = "Manage Detained Licenses";
            manageToolStripMenuItem.Click += manageToolStripMenuItem_Click;
            // 
            // detainLicenseToolStripMenuItem
            // 
            detainLicenseToolStripMenuItem.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            detainLicenseToolStripMenuItem.Image = Properties.Resources.Detain_32;
            detainLicenseToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            detainLicenseToolStripMenuItem.Name = "detainLicenseToolStripMenuItem";
            detainLicenseToolStripMenuItem.Size = new Size(288, 38);
            detainLicenseToolStripMenuItem.Text = "Detain License0";
            detainLicenseToolStripMenuItem.Click += detainLicenseToolStripMenuItem_Click;
            // 
            // releaseDetainedLicenseToolStripMenuItem
            // 
            releaseDetainedLicenseToolStripMenuItem.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            releaseDetainedLicenseToolStripMenuItem.Image = Properties.Resources.Release_Detained_License_32;
            releaseDetainedLicenseToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            releaseDetainedLicenseToolStripMenuItem.Name = "releaseDetainedLicenseToolStripMenuItem";
            releaseDetainedLicenseToolStripMenuItem.Size = new Size(288, 38);
            releaseDetainedLicenseToolStripMenuItem.Text = "Release Detained License0";
            releaseDetainedLicenseToolStripMenuItem.Click += releaseDetainedLicenseToolStripMenuItem_Click;
            // 
            // manageApplicationTypesToolStripMenuItem
            // 
            manageApplicationTypesToolStripMenuItem.Font = new Font("Arial", 12F, FontStyle.Bold);
            manageApplicationTypesToolStripMenuItem.Image = Properties.Resources.Application_Types_64;
            manageApplicationTypesToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            manageApplicationTypesToolStripMenuItem.Name = "manageApplicationTypesToolStripMenuItem";
            manageApplicationTypesToolStripMenuItem.Size = new Size(327, 70);
            manageApplicationTypesToolStripMenuItem.Text = "Manage Application Types";
            manageApplicationTypesToolStripMenuItem.Click += manageApplicationTypesToolStripMenuItem_Click;
            // 
            // managToolStripMenuItem
            // 
            managToolStripMenuItem.Font = new Font("Arial", 12F, FontStyle.Bold);
            managToolStripMenuItem.Image = Properties.Resources.Test_Type_64;
            managToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            managToolStripMenuItem.Name = "managToolStripMenuItem";
            managToolStripMenuItem.Size = new Size(327, 70);
            managToolStripMenuItem.Text = "Manage Test Types";
            managToolStripMenuItem.Click += managToolStripMenuItem_Click;
            // 
            // peopleToolStripMenuItem
            // 
            peopleToolStripMenuItem.Image = Properties.Resources.People_64;
            peopleToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            peopleToolStripMenuItem.Name = "peopleToolStripMenuItem";
            peopleToolStripMenuItem.Size = new Size(150, 68);
            peopleToolStripMenuItem.Text = "People";
            peopleToolStripMenuItem.Click += peopleToolStripMenuItem_Click;
            // 
            // driversToolStripMenuItem
            // 
            driversToolStripMenuItem.Image = Properties.Resources.Drivers_64;
            driversToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            driversToolStripMenuItem.Name = "driversToolStripMenuItem";
            driversToolStripMenuItem.Size = new Size(154, 68);
            driversToolStripMenuItem.Text = "Drivers";
            driversToolStripMenuItem.Click += driversToolStripMenuItem_Click;
            // 
            // usersToolStripMenuItem
            // 
            usersToolStripMenuItem.Image = Properties.Resources.Users_2_64;
            usersToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            usersToolStripMenuItem.Size = new Size(140, 68);
            usersToolStripMenuItem.Text = "Users";
            usersToolStripMenuItem.Click += usersToolStripMenuItem_Click;
            // 
            // accountStToolStripMenuItem
            // 
            accountStToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { currentUserInfoToolStripMenuItem, changePasswordToolStripMenuItem, toolStripSeparator1, signOutToolStripMenuItem });
            accountStToolStripMenuItem.Image = Properties.Resources.account_settings_64;
            accountStToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            accountStToolStripMenuItem.Name = "accountStToolStripMenuItem";
            accountStToolStripMenuItem.Size = new Size(244, 68);
            accountStToolStripMenuItem.Text = "Account Settings";
            // 
            // currentUserInfoToolStripMenuItem
            // 
            currentUserInfoToolStripMenuItem.Font = new Font("Arial", 12F, FontStyle.Bold);
            currentUserInfoToolStripMenuItem.Image = Properties.Resources.PersonDetails_32;
            currentUserInfoToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            currentUserInfoToolStripMenuItem.Name = "currentUserInfoToolStripMenuItem";
            currentUserInfoToolStripMenuItem.Size = new Size(236, 38);
            currentUserInfoToolStripMenuItem.Text = "&Current user Info";
            currentUserInfoToolStripMenuItem.Click += currentUserInfoToolStripMenuItem_Click;
            // 
            // changePasswordToolStripMenuItem
            // 
            changePasswordToolStripMenuItem.Font = new Font("Arial", 12F, FontStyle.Bold);
            changePasswordToolStripMenuItem.Image = Properties.Resources.Password_32;
            changePasswordToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            changePasswordToolStripMenuItem.Size = new Size(236, 38);
            changePasswordToolStripMenuItem.Text = "Change Password";
            changePasswordToolStripMenuItem.Click += changePasswordToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(233, 6);
            // 
            // signOutToolStripMenuItem
            // 
            signOutToolStripMenuItem.Font = new Font("Arial", 12F, FontStyle.Bold);
            signOutToolStripMenuItem.Image = Properties.Resources.sign_out_32__2;
            signOutToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            signOutToolStripMenuItem.Name = "signOutToolStripMenuItem";
            signOutToolStripMenuItem.Size = new Size(236, 38);
            signOutToolStripMenuItem.Text = "Sign &Out";
            signOutToolStripMenuItem.Click += signOutToolStripMenuItem_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Black;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.DVLD_Logo;
            pictureBox1.Location = new Point(0, 72);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1284, 648);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(13F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1284, 720);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(6, 5, 6, 5);
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main";
            WindowState = FormWindowState.Maximized;
            FormClosing += frmMain_FormClosing;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem applicationsToolStripMenuItem;
        private ToolStripMenuItem peopleToolStripMenuItem;
        private ToolStripMenuItem driversToolStripMenuItem;
        private ToolStripMenuItem usersToolStripMenuItem;
        private ToolStripMenuItem accountStToolStripMenuItem;
        private PictureBox pictureBox1;
        private ToolStripMenuItem currentUserInfoToolStripMenuItem;
        private ToolStripMenuItem changePasswordToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem signOutToolStripMenuItem;
        private ToolStripMenuItem drivingLicensesServicesToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem manageApplicationsToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem detainLicensesToolStripMenuItem;
        private ToolStripMenuItem manageApplicationTypesToolStripMenuItem;
        private ToolStripMenuItem managToolStripMenuItem;
        private ToolStripMenuItem newDrivingLIixenseToolStripMenuItem;
        private ToolStripMenuItem renewDrivingLicenseToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem replacementForLostOrDamagedLicenseToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripMenuItem releaseDetianedDrivingLicenseToolStripMenuItem;
        private ToolStripMenuItem localLicenseToolStripMenuItem;
        private ToolStripMenuItem internationalLicenseToolStripMenuItem;
        private ToolStripMenuItem retakeTestToolStripMenuItem;
        private ToolStripMenuItem localDrivingLicenseApplicationToolStripMenuItem;
        private ToolStripMenuItem internationalDrivingLicenseApplicationsToolStripMenuItem;
        private ToolStripMenuItem manageToolStripMenuItem;
        private ToolStripMenuItem detainLicenseToolStripMenuItem;
        private ToolStripMenuItem releaseDetainedLicenseToolStripMenuItem;
    }
}
