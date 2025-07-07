namespace DVLD.Applications.Rlease_Detained_License
{
    partial class frmReleaseDetainedLicenseApplication
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new Container();
            pictureBox8 = new PictureBox();
            lblLicenseID = new Label();
            label10 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            lblDetainDate = new Label();
            btnRelease = new Button();
            lblCreatedByUser = new Label();
            pictureBox3 = new PictureBox();
            errorProvider1 = new ErrorProvider(components);
            pictureBox4 = new PictureBox();
            lblTitle = new Label();
            label5 = new Label();
            lblDetainID = new Label();
            label4 = new Label();
            ctrlDriverLicenseInfoWithFilter1 = new Licenses.Controls.ctrlDriverLicenseInfoWithFilter();
            llShowLicenseInfo = new LinkLabel();
            gpDetain = new GroupBox();
            pictureBox7 = new PictureBox();
            lblApplicationID = new Label();
            lblTotalFees = new Label();
            label8 = new Label();
            label7 = new Label();
            pictureBox6 = new PictureBox();
            lblApplicationFees = new Label();
            label6 = new Label();
            pictureBox5 = new PictureBox();
            lblFineFees = new Label();
            llShowLicenseHistory = new LinkLabel();
            ((ISupportInitialize)pictureBox8).BeginInit();
            ((ISupportInitialize)pictureBox2).BeginInit();
            ((ISupportInitialize)pictureBox1).BeginInit();
            ((ISupportInitialize)pictureBox3).BeginInit();
            ((ISupportInitialize)errorProvider1).BeginInit();
            ((ISupportInitialize)pictureBox4).BeginInit();
            gpDetain.SuspendLayout();
            ((ISupportInitialize)pictureBox7).BeginInit();
            ((ISupportInitialize)pictureBox6).BeginInit();
            ((ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // pictureBox8
            // 
            pictureBox8.Image = DVLD_UI.Properties.Resources.LocalDriving_License;
            pictureBox8.Location = new Point(581, 24);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(31, 26);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 195;
            pictureBox8.TabStop = false;
            // 
            // lblLicenseID
            // 
            lblLicenseID.AutoSize = true;
            lblLicenseID.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLicenseID.Location = new Point(619, 24);
            lblLicenseID.Margin = new Padding(4, 0, 4, 0);
            lblLicenseID.Name = "lblLicenseID";
            lblLicenseID.Size = new Size(49, 20);
            lblLicenseID.TabIndex = 191;
            lblLicenseID.Text = "[???]";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(410, 24);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(100, 20);
            label10.TabIndex = 190;
            label10.Text = "License ID:";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = DVLD_UI.Properties.Resources.Number_32;
            pictureBox2.Location = new Point(187, 24);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(31, 26);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 183;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = DVLD_UI.Properties.Resources.User_32__2;
            pictureBox1.Location = new Point(581, 56);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(31, 26);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 182;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(410, 56);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(103, 20);
            label1.TabIndex = 181;
            label1.Text = "Created By:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(410, 94);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(94, 20);
            label2.TabIndex = 177;
            label2.Text = "Fine Fees:";
            // 
            // lblDetainDate
            // 
            lblDetainDate.AutoSize = true;
            lblDetainDate.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDetainDate.Location = new Point(225, 56);
            lblDetainDate.Margin = new Padding(4, 0, 4, 0);
            lblDetainDate.Name = "lblDetainDate";
            lblDetainDate.Size = new Size(109, 20);
            lblDetainDate.TabIndex = 176;
            lblDetainDate.Text = "[??/??/????]";
            // 
            // btnRelease
            // 
            btnRelease.Enabled = false;
            btnRelease.FlatStyle = FlatStyle.Flat;
            btnRelease.Image = DVLD_UI.Properties.Resources.Release_Detained_License_32;
            btnRelease.ImageAlign = ContentAlignment.MiddleLeft;
            btnRelease.Location = new Point(756, 702);
            btnRelease.Name = "btnRelease";
            btnRelease.Size = new Size(126, 37);
            btnRelease.TabIndex = 189;
            btnRelease.Text = "Release";
            btnRelease.UseVisualStyleBackColor = true;
            btnRelease.Click += btnRelease_Click;
            // 
            // lblCreatedByUser
            // 
            lblCreatedByUser.AutoSize = true;
            lblCreatedByUser.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCreatedByUser.Location = new Point(619, 56);
            lblCreatedByUser.Margin = new Padding(4, 0, 4, 0);
            lblCreatedByUser.Name = "lblCreatedByUser";
            lblCreatedByUser.Size = new Size(59, 20);
            lblCreatedByUser.TabIndex = 180;
            lblCreatedByUser.Text = "[????]";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = DVLD_UI.Properties.Resources.money_32;
            pictureBox3.Location = new Point(581, 94);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(31, 26);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 178;
            pictureBox3.TabStop = false;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = DVLD_UI.Properties.Resources.Calendar_32;
            pictureBox4.Location = new Point(187, 56);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(31, 26);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 175;
            pictureBox4.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(192, 0, 0);
            lblTitle.Location = new Point(12, 6);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(870, 39);
            lblTitle.TabIndex = 186;
            lblTitle.Text = "Release Detained License";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(16, 56);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(111, 20);
            label5.TabIndex = 174;
            label5.Text = "Detain Date:";
            // 
            // lblDetainID
            // 
            lblDetainID.AutoSize = true;
            lblDetainID.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDetainID.Location = new Point(225, 24);
            lblDetainID.Margin = new Padding(4, 0, 4, 0);
            lblDetainID.Name = "lblDetainID";
            lblDetainID.Size = new Size(49, 20);
            lblDetainID.TabIndex = 173;
            lblDetainID.Text = "[???]";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(16, 24);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(91, 20);
            label4.TabIndex = 172;
            label4.Text = "Detain ID:";
            // 
            // ctrlDriverLicenseInfoWithFilter1
            // 
            ctrlDriverLicenseInfoWithFilter1.BackColor = Color.White;
            ctrlDriverLicenseInfoWithFilter1.FilterEnabled = true;
            ctrlDriverLicenseInfoWithFilter1.Location = new Point(15, 46);
            ctrlDriverLicenseInfoWithFilter1.Margin = new Padding(6, 8, 6, 8);
            ctrlDriverLicenseInfoWithFilter1.Name = "ctrlDriverLicenseInfoWithFilter1";
            ctrlDriverLicenseInfoWithFilter1.Size = new Size(876, 455);
            ctrlDriverLicenseInfoWithFilter1.TabIndex = 192;
            ctrlDriverLicenseInfoWithFilter1.OnLicenseSelected += ctrlDriverLicenseInfoWithFilter1_OnLicenseSelected;
            // 
            // llShowLicenseInfo
            // 
            llShowLicenseInfo.AutoSize = true;
            llShowLicenseInfo.Enabled = false;
            llShowLicenseInfo.Location = new Point(215, 704);
            llShowLicenseInfo.Name = "llShowLicenseInfo";
            llShowLicenseInfo.Size = new Size(148, 20);
            llShowLicenseInfo.TabIndex = 191;
            llShowLicenseInfo.TabStop = true;
            llShowLicenseInfo.Text = "Show Licenses Info";
            llShowLicenseInfo.LinkClicked += llShowLicenseInfo_LinkClicked;
            // 
            // gpDetain
            // 
            gpDetain.Controls.Add(pictureBox7);
            gpDetain.Controls.Add(lblApplicationID);
            gpDetain.Controls.Add(lblTotalFees);
            gpDetain.Controls.Add(label8);
            gpDetain.Controls.Add(label7);
            gpDetain.Controls.Add(pictureBox6);
            gpDetain.Controls.Add(lblApplicationFees);
            gpDetain.Controls.Add(label6);
            gpDetain.Controls.Add(pictureBox5);
            gpDetain.Controls.Add(lblFineFees);
            gpDetain.Controls.Add(pictureBox8);
            gpDetain.Controls.Add(lblLicenseID);
            gpDetain.Controls.Add(label10);
            gpDetain.Controls.Add(pictureBox2);
            gpDetain.Controls.Add(pictureBox1);
            gpDetain.Controls.Add(label1);
            gpDetain.Controls.Add(lblCreatedByUser);
            gpDetain.Controls.Add(label2);
            gpDetain.Controls.Add(pictureBox3);
            gpDetain.Controls.Add(lblDetainDate);
            gpDetain.Controls.Add(pictureBox4);
            gpDetain.Controls.Add(label5);
            gpDetain.Controls.Add(lblDetainID);
            gpDetain.Controls.Add(label4);
            gpDetain.Location = new Point(32, 512);
            gpDetain.Name = "gpDetain";
            gpDetain.Size = new Size(850, 184);
            gpDetain.TabIndex = 187;
            gpDetain.TabStop = false;
            gpDetain.Text = "Detain Info";
            // 
            // pictureBox7
            // 
            pictureBox7.Image = DVLD_UI.Properties.Resources.Number_32;
            pictureBox7.Location = new Point(581, 129);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(31, 26);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 203;
            pictureBox7.TabStop = false;
            // 
            // lblApplicationID
            // 
            lblApplicationID.AutoSize = true;
            lblApplicationID.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblApplicationID.Location = new Point(619, 129);
            lblApplicationID.Margin = new Padding(4, 0, 4, 0);
            lblApplicationID.Name = "lblApplicationID";
            lblApplicationID.Size = new Size(59, 20);
            lblApplicationID.TabIndex = 202;
            lblApplicationID.Text = "[????]";
            // 
            // lblTotalFees
            // 
            lblTotalFees.AutoSize = true;
            lblTotalFees.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalFees.Location = new Point(225, 129);
            lblTotalFees.Margin = new Padding(4, 0, 4, 0);
            lblTotalFees.Name = "lblTotalFees";
            lblTotalFees.Size = new Size(59, 20);
            lblTotalFees.TabIndex = 202;
            lblTotalFees.Text = "[$$$$]";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(410, 129);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(127, 20);
            label8.TabIndex = 200;
            label8.Text = "Application ID:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(16, 129);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(99, 20);
            label7.TabIndex = 200;
            label7.Text = "Total Fees:";
            // 
            // pictureBox6
            // 
            pictureBox6.Image = DVLD_UI.Properties.Resources.money_32;
            pictureBox6.Location = new Point(187, 129);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(31, 26);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 201;
            pictureBox6.TabStop = false;
            // 
            // lblApplicationFees
            // 
            lblApplicationFees.AutoSize = true;
            lblApplicationFees.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblApplicationFees.Location = new Point(225, 94);
            lblApplicationFees.Margin = new Padding(4, 0, 4, 0);
            lblApplicationFees.Name = "lblApplicationFees";
            lblApplicationFees.Size = new Size(59, 20);
            lblApplicationFees.TabIndex = 199;
            lblApplicationFees.Text = "[$$$$]";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(16, 94);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(148, 20);
            label6.TabIndex = 197;
            label6.Text = "Application Fees:";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = DVLD_UI.Properties.Resources.money_32;
            pictureBox5.Location = new Point(187, 94);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(31, 26);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 198;
            pictureBox5.TabStop = false;
            // 
            // lblFineFees
            // 
            lblFineFees.AutoSize = true;
            lblFineFees.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFineFees.Location = new Point(619, 94);
            lblFineFees.Margin = new Padding(4, 0, 4, 0);
            lblFineFees.Name = "lblFineFees";
            lblFineFees.Size = new Size(59, 20);
            lblFineFees.TabIndex = 196;
            lblFineFees.Text = "[$$$$]";
            // 
            // llShowLicenseHistory
            // 
            llShowLicenseHistory.AutoSize = true;
            llShowLicenseHistory.Enabled = false;
            llShowLicenseHistory.Location = new Point(32, 704);
            llShowLicenseHistory.Name = "llShowLicenseHistory";
            llShowLicenseHistory.Size = new Size(169, 20);
            llShowLicenseHistory.TabIndex = 190;
            llShowLicenseHistory.TabStop = true;
            llShowLicenseHistory.Text = "Show Licenses History";
            llShowLicenseHistory.LinkClicked += llShowLicenseHistory_LinkClicked;
            // 
            // frmReleaseDetainedLicenseApplication
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            BackColor = Color.White;
            ClientSize = new Size(891, 751);
            Controls.Add(btnRelease);
            Controls.Add(lblTitle);
            Controls.Add(llShowLicenseHistory);
            Controls.Add(ctrlDriverLicenseInfoWithFilter1);
            Controls.Add(llShowLicenseInfo);
            Controls.Add(gpDetain);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmReleaseDetainedLicenseApplication";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Release Detained License";
            Activated += frmReleaseDetainedLicenseApplication_Activated;
            ((ISupportInitialize)pictureBox8).EndInit();
            ((ISupportInitialize)pictureBox2).EndInit();
            ((ISupportInitialize)pictureBox1).EndInit();
            ((ISupportInitialize)pictureBox3).EndInit();
            ((ISupportInitialize)errorProvider1).EndInit();
            ((ISupportInitialize)pictureBox4).EndInit();
            gpDetain.ResumeLayout(false);
            gpDetain.PerformLayout();
            ((ISupportInitialize)pictureBox7).EndInit();
            ((ISupportInitialize)pictureBox6).EndInit();
            ((ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Label lblLicenseID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDetainDate;
        private System.Windows.Forms.Button btnRelease;
        private System.Windows.Forms.Label lblCreatedByUser;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.LinkLabel llShowLicenseHistory;
        private Licenses.Controls.ctrlDriverLicenseInfoWithFilter ctrlDriverLicenseInfoWithFilter1;
        private System.Windows.Forms.LinkLabel llShowLicenseInfo;
        private System.Windows.Forms.GroupBox gpDetain;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblDetainID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblFineFees;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label lblApplicationID;
        private System.Windows.Forms.Label lblTotalFees;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label lblApplicationFees;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}