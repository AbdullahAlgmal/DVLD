namespace DVLD_UI.Applications.Local_Driving_License
{
    partial class ctrlDrivingLicenseApplicationInfo
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ctrlApplicationBasicInfo1 = new Controls.ctrlApplicationBasicInfo();
            groupBox1 = new GroupBox();
            pictureBox2 = new PictureBox();
            llShowLicensInfo = new LinkLabel();
            lblPassedTests = new Label();
            pictureBox7 = new PictureBox();
            label13 = new Label();
            lblAppliedForLicense = new Label();
            pictureBox6 = new PictureBox();
            label11 = new Label();
            lblDLAppId = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            groupBox1.SuspendLayout();
            ((ISupportInitialize)pictureBox2).BeginInit();
            ((ISupportInitialize)pictureBox7).BeginInit();
            ((ISupportInitialize)pictureBox6).BeginInit();
            ((ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // ctrlApplicationBasicInfo1
            // 
            ctrlApplicationBasicInfo1.BackColor = Color.White;
            ctrlApplicationBasicInfo1.Dock = DockStyle.Bottom;
            ctrlApplicationBasicInfo1.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ctrlApplicationBasicInfo1.Location = new Point(0, 131);
            ctrlApplicationBasicInfo1.Name = "ctrlApplicationBasicInfo1";
            ctrlApplicationBasicInfo1.Size = new Size(596, 259);
            ctrlApplicationBasicInfo1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(llShowLicensInfo);
            groupBox1.Controls.Add(lblPassedTests);
            groupBox1.Controls.Add(pictureBox7);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(lblAppliedForLicense);
            groupBox1.Controls.Add(pictureBox6);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(lblDLAppId);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(596, 119);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Driving Licens Application Info";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.License_View_32;
            pictureBox2.Location = new Point(17, 77);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(25, 25);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 44;
            pictureBox2.TabStop = false;
            // 
            // llShowLicensInfo
            // 
            llShowLicensInfo.AutoSize = true;
            llShowLicensInfo.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            llShowLicensInfo.Location = new Point(48, 83);
            llShowLicensInfo.Name = "llShowLicensInfo";
            llShowLicensInfo.Size = new Size(145, 19);
            llShowLicensInfo.TabIndex = 43;
            llShowLicensInfo.TabStop = true;
            llShowLicensInfo.Text = "Show Licens Info.";
            llShowLicensInfo.TextAlign = ContentAlignment.MiddleCenter;
            llShowLicensInfo.LinkClicked += llShowLicenceInfo_LinkClicked;
            // 
            // lblPassedTests
            // 
            lblPassedTests.AutoSize = true;
            lblPassedTests.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPassedTests.ForeColor = Color.Red;
            lblPassedTests.Location = new Point(437, 84);
            lblPassedTests.Name = "lblPassedTests";
            lblPassedTests.Size = new Size(98, 18);
            lblPassedTests.TabIndex = 39;
            lblPassedTests.Text = "[??/??/????]";
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources.PassedTests_32;
            pictureBox7.Location = new Point(406, 77);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(25, 25);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 38;
            pictureBox7.TabStop = false;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(237, 84);
            label13.Name = "label13";
            label13.Size = new Size(117, 19);
            label13.TabIndex = 37;
            label13.Text = "Passed Tests:";
            // 
            // lblAppliedForLicense
            // 
            lblAppliedForLicense.AutoSize = true;
            lblAppliedForLicense.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAppliedForLicense.ForeColor = Color.Red;
            lblAppliedForLicense.Location = new Point(437, 41);
            lblAppliedForLicense.Name = "lblAppliedForLicense";
            lblAppliedForLicense.Size = new Size(98, 18);
            lblAppliedForLicense.TabIndex = 36;
            lblAppliedForLicense.Text = "[??/??/????]";
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.License_View_32;
            pictureBox6.Location = new Point(406, 34);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(25, 25);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 35;
            pictureBox6.TabStop = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(237, 41);
            label11.Name = "label11";
            label11.Size = new Size(167, 19);
            label11.TabIndex = 34;
            label11.Text = "Applied For License0:";
            // 
            // lblDLAppId
            // 
            lblDLAppId.AutoSize = true;
            lblDLAppId.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDLAppId.ForeColor = Color.Red;
            lblDLAppId.Location = new Point(148, 43);
            lblDLAppId.Name = "lblDLAppId";
            lblDLAppId.Size = new Size(45, 18);
            lblDLAppId.TabIndex = 21;
            lblDLAppId.Text = "[???]";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Number_32;
            pictureBox1.Location = new Point(117, 36);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(25, 25);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(17, 42);
            label2.Name = "label2";
            label2.Size = new Size(95, 19);
            label2.TabIndex = 19;
            label2.Text = "D.L App ID:";
            // 
            // ctrlDrivingLicenseApplicationInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(groupBox1);
            Controls.Add(ctrlApplicationBasicInfo1);
            Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "ctrlDrivingLicenseApplicationInfo";
            Size = new Size(596, 390);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((ISupportInitialize)pictureBox2).EndInit();
            ((ISupportInitialize)pictureBox7).EndInit();
            ((ISupportInitialize)pictureBox6).EndInit();
            ((ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Controls.ctrlApplicationBasicInfo ctrlApplicationBasicInfo1;
        private GroupBox groupBox1;
        private LinkLabel llShowLicensInfo;
        private Label lblPassedTests;
        private PictureBox pictureBox7;
        private Label label13;
        private Label lblAppliedForLicense;
        private PictureBox pictureBox6;
        private Label label11;
        private Label lblDLAppId;
        private PictureBox pictureBox1;
        private Label label2;
        private PictureBox pictureBox2;
    }
}
