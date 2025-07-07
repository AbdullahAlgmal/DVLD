namespace DVLD.Applications.ReplaceLostOrDamagedLicense
{
    partial class frmReplaceLostOrDamagedLicenseApplication
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
            llShowLicenseInfo = new LinkLabel();
            lblTitle = new Label();
            llShowLicenseHistory = new LinkLabel();
            btnIssueReplacement = new Button();
            label4 = new Label();
            lblApplicationID = new Label();
            label5 = new Label();
            pictureBox4 = new PictureBox();
            lblApplicationDate = new Label();
            pictureBox3 = new PictureBox();
            label2 = new Label();
            lblApplicationFees = new Label();
            lblCreatedByUser = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label10 = new Label();
            lblRreplacedLicenseID = new Label();
            pictureBox7 = new PictureBox();
            label12 = new Label();
            lblOldLicenseID = new Label();
            pictureBox8 = new PictureBox();
            gpApplicationInfo = new GroupBox();
            gbReplacementFor = new GroupBox();
            rbLostLicense = new RadioButton();
            rbDamagedLicense = new RadioButton();
            ctrlDriverLicenseInfoWithFilter1 = new Licenses.Controls.ctrlDriverLicenseInfoWithFilter();
            ((ISupportInitialize)pictureBox4).BeginInit();
            ((ISupportInitialize)pictureBox3).BeginInit();
            ((ISupportInitialize)pictureBox1).BeginInit();
            ((ISupportInitialize)pictureBox2).BeginInit();
            ((ISupportInitialize)pictureBox7).BeginInit();
            ((ISupportInitialize)pictureBox8).BeginInit();
            gpApplicationInfo.SuspendLayout();
            gbReplacementFor.SuspendLayout();
            SuspendLayout();
            // 
            // llShowLicenseInfo
            // 
            llShowLicenseInfo.AutoSize = true;
            llShowLicenseInfo.Enabled = false;
            llShowLicenseInfo.Location = new Point(281, 648);
            llShowLicenseInfo.Name = "llShowLicenseInfo";
            llShowLicenseInfo.Size = new Size(183, 20);
            llShowLicenseInfo.TabIndex = 189;
            llShowLicenseInfo.TabStop = true;
            llShowLicenseInfo.Text = "Show New Licenses Info";
            llShowLicenseInfo.LinkClicked += llShowLicenseInfo_LinkClicked;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(192, 0, 0);
            lblTitle.Location = new Point(5, 16);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(875, 39);
            lblTitle.TabIndex = 183;
            lblTitle.Text = "License Replacement";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // llShowLicenseHistory
            // 
            llShowLicenseHistory.AutoSize = true;
            llShowLicenseHistory.Enabled = false;
            llShowLicenseHistory.Location = new Point(98, 648);
            llShowLicenseHistory.Name = "llShowLicenseHistory";
            llShowLicenseHistory.Size = new Size(169, 20);
            llShowLicenseHistory.TabIndex = 188;
            llShowLicenseHistory.TabStop = true;
            llShowLicenseHistory.Text = "Show Licenses History";
            llShowLicenseHistory.LinkClicked += llShowLicenseHistory_LinkClicked;
            // 
            // btnIssueReplacement
            // 
            btnIssueReplacement.Enabled = false;
            btnIssueReplacement.FlatStyle = FlatStyle.Flat;
            btnIssueReplacement.Image = DVLD_UI.Properties.Resources.Renew_Driving_License_32;
            btnIssueReplacement.ImageAlign = ContentAlignment.MiddleLeft;
            btnIssueReplacement.Location = new Point(679, 640);
            btnIssueReplacement.Name = "btnIssueReplacement";
            btnIssueReplacement.Size = new Size(193, 37);
            btnIssueReplacement.TabIndex = 187;
            btnIssueReplacement.Text = "Issue Replacement";
            btnIssueReplacement.TextAlign = ContentAlignment.MiddleRight;
            btnIssueReplacement.UseVisualStyleBackColor = true;
            btnIssueReplacement.Click += btnIssueReplacement_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(5, 38);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(160, 20);
            label4.TabIndex = 172;
            label4.Text = "L.R.Application ID:";
            // 
            // lblApplicationID
            // 
            lblApplicationID.AutoSize = true;
            lblApplicationID.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblApplicationID.Location = new Point(214, 38);
            lblApplicationID.Margin = new Padding(4, 0, 4, 0);
            lblApplicationID.Name = "lblApplicationID";
            lblApplicationID.Size = new Size(49, 20);
            lblApplicationID.TabIndex = 173;
            lblApplicationID.Text = "[???]";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(5, 70);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(147, 20);
            label5.TabIndex = 174;
            label5.Text = "Application Date:";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = DVLD_UI.Properties.Resources.Calendar_32;
            pictureBox4.Location = new Point(176, 70);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(31, 26);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 175;
            pictureBox4.TabStop = false;
            // 
            // lblApplicationDate
            // 
            lblApplicationDate.AutoSize = true;
            lblApplicationDate.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblApplicationDate.Location = new Point(214, 70);
            lblApplicationDate.Margin = new Padding(4, 0, 4, 0);
            lblApplicationDate.Name = "lblApplicationDate";
            lblApplicationDate.Size = new Size(109, 20);
            lblApplicationDate.TabIndex = 176;
            lblApplicationDate.Text = "[??/??/????]";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = DVLD_UI.Properties.Resources.money_32;
            pictureBox3.Location = new Point(176, 102);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(31, 26);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 178;
            pictureBox3.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(5, 102);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(148, 20);
            label2.TabIndex = 177;
            label2.Text = "Application Fees:";
            // 
            // lblApplicationFees
            // 
            lblApplicationFees.AutoSize = true;
            lblApplicationFees.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblApplicationFees.Location = new Point(214, 102);
            lblApplicationFees.Margin = new Padding(4, 0, 4, 0);
            lblApplicationFees.Name = "lblApplicationFees";
            lblApplicationFees.Size = new Size(49, 20);
            lblApplicationFees.TabIndex = 179;
            lblApplicationFees.Text = "[$$$]";
            // 
            // lblCreatedByUser
            // 
            lblCreatedByUser.AutoSize = true;
            lblCreatedByUser.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCreatedByUser.Location = new Point(622, 102);
            lblCreatedByUser.Margin = new Padding(4, 0, 4, 0);
            lblCreatedByUser.Name = "lblCreatedByUser";
            lblCreatedByUser.Size = new Size(59, 20);
            lblCreatedByUser.TabIndex = 180;
            lblCreatedByUser.Text = "[????]";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(399, 102);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(103, 20);
            label1.TabIndex = 181;
            label1.Text = "Created By:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = DVLD_UI.Properties.Resources.User_32__2;
            pictureBox1.Location = new Point(584, 102);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(31, 26);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 182;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = DVLD_UI.Properties.Resources.Number_32;
            pictureBox2.Location = new Point(176, 38);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(31, 26);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 183;
            pictureBox2.TabStop = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(399, 38);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(181, 20);
            label10.TabIndex = 190;
            label10.Text = "Replaced License ID:";
            // 
            // lblRreplacedLicenseID
            // 
            lblRreplacedLicenseID.AutoSize = true;
            lblRreplacedLicenseID.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRreplacedLicenseID.Location = new Point(622, 38);
            lblRreplacedLicenseID.Margin = new Padding(4, 0, 4, 0);
            lblRreplacedLicenseID.Name = "lblRreplacedLicenseID";
            lblRreplacedLicenseID.Size = new Size(49, 20);
            lblRreplacedLicenseID.TabIndex = 191;
            lblRreplacedLicenseID.Text = "[???]";
            // 
            // pictureBox7
            // 
            pictureBox7.Image = DVLD_UI.Properties.Resources.Renew_Driving_License_32;
            pictureBox7.Location = new Point(584, 38);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(31, 26);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 192;
            pictureBox7.TabStop = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(399, 70);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(132, 20);
            label12.TabIndex = 193;
            label12.Text = "Old License ID:";
            // 
            // lblOldLicenseID
            // 
            lblOldLicenseID.AutoSize = true;
            lblOldLicenseID.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOldLicenseID.Location = new Point(622, 70);
            lblOldLicenseID.Margin = new Padding(4, 0, 4, 0);
            lblOldLicenseID.Name = "lblOldLicenseID";
            lblOldLicenseID.Size = new Size(49, 20);
            lblOldLicenseID.TabIndex = 194;
            lblOldLicenseID.Text = "[???]";
            // 
            // pictureBox8
            // 
            pictureBox8.Image = DVLD_UI.Properties.Resources.LocalDriving_License;
            pictureBox8.Location = new Point(584, 70);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(31, 26);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 195;
            pictureBox8.TabStop = false;
            // 
            // gpApplicationInfo
            // 
            gpApplicationInfo.Controls.Add(pictureBox8);
            gpApplicationInfo.Controls.Add(lblOldLicenseID);
            gpApplicationInfo.Controls.Add(label12);
            gpApplicationInfo.Controls.Add(pictureBox7);
            gpApplicationInfo.Controls.Add(lblRreplacedLicenseID);
            gpApplicationInfo.Controls.Add(label10);
            gpApplicationInfo.Controls.Add(pictureBox2);
            gpApplicationInfo.Controls.Add(pictureBox1);
            gpApplicationInfo.Controls.Add(label1);
            gpApplicationInfo.Controls.Add(lblCreatedByUser);
            gpApplicationInfo.Controls.Add(lblApplicationFees);
            gpApplicationInfo.Controls.Add(label2);
            gpApplicationInfo.Controls.Add(pictureBox3);
            gpApplicationInfo.Controls.Add(lblApplicationDate);
            gpApplicationInfo.Controls.Add(pictureBox4);
            gpApplicationInfo.Controls.Add(label5);
            gpApplicationInfo.Controls.Add(lblApplicationID);
            gpApplicationInfo.Controls.Add(label4);
            gpApplicationInfo.Location = new Point(22, 492);
            gpApplicationInfo.Name = "gpApplicationInfo";
            gpApplicationInfo.Size = new Size(850, 142);
            gpApplicationInfo.TabIndex = 185;
            gpApplicationInfo.TabStop = false;
            gpApplicationInfo.Text = "Application Info for License Replacement";
            // 
            // gbReplacementFor
            // 
            gbReplacementFor.Controls.Add(rbLostLicense);
            gbReplacementFor.Controls.Add(rbDamagedLicense);
            gbReplacementFor.Location = new Point(635, 58);
            gbReplacementFor.Name = "gbReplacementFor";
            gbReplacementFor.Size = new Size(237, 94);
            gbReplacementFor.TabIndex = 191;
            gbReplacementFor.TabStop = false;
            gbReplacementFor.Text = "Repalcement For:";
            // 
            // rbLostLicense
            // 
            rbLostLicense.AutoSize = true;
            rbLostLicense.Location = new Point(9, 55);
            rbLostLicense.Name = "rbLostLicense";
            rbLostLicense.Size = new Size(117, 24);
            rbLostLicense.TabIndex = 1;
            rbLostLicense.Text = "Lost License";
            rbLostLicense.UseVisualStyleBackColor = true;
            rbLostLicense.CheckedChanged += rbLostLicense_CheckedChanged;
            // 
            // rbDamagedLicense
            // 
            rbDamagedLicense.AutoSize = true;
            rbDamagedLicense.Location = new Point(8, 27);
            rbDamagedLicense.Name = "rbDamagedLicense";
            rbDamagedLicense.Size = new Size(156, 24);
            rbDamagedLicense.TabIndex = 0;
            rbDamagedLicense.Text = "Damaged License";
            rbDamagedLicense.UseVisualStyleBackColor = true;
            rbDamagedLicense.CheckedChanged += rbDamagedLicense_CheckedChanged;
            // 
            // ctrlDriverLicenseInfoWithFilter1
            // 
            ctrlDriverLicenseInfoWithFilter1.BackColor = Color.White;
            ctrlDriverLicenseInfoWithFilter1.FilterEnabled = true;
            ctrlDriverLicenseInfoWithFilter1.Location = new Point(7, 38);
            ctrlDriverLicenseInfoWithFilter1.Margin = new Padding(4, 5, 4, 5);
            ctrlDriverLicenseInfoWithFilter1.Name = "ctrlDriverLicenseInfoWithFilter1";
            ctrlDriverLicenseInfoWithFilter1.Size = new Size(874, 455);
            ctrlDriverLicenseInfoWithFilter1.TabIndex = 190;
            ctrlDriverLicenseInfoWithFilter1.OnLicenseSelected += ctrlDriverLicenseInfoWithFilter1_OnLicenseSelected;
            // 
            // frmReplaceLostOrDamagedLicenseApplication
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(885, 695);
            Controls.Add(gbReplacementFor);
            Controls.Add(lblTitle);
            Controls.Add(ctrlDriverLicenseInfoWithFilter1);
            Controls.Add(llShowLicenseInfo);
            Controls.Add(llShowLicenseHistory);
            Controls.Add(btnIssueReplacement);
            Controls.Add(gpApplicationInfo);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmReplaceLostOrDamagedLicenseApplication";
            StartPosition = FormStartPosition.CenterParent;
            Text = "License Replacement";
            Activated += frmReplaceLostOrDamagedLicenseApplication_Activated;
            Load += frmReplaceLostOrDamagedLicenseApplication_Load;
            ((ISupportInitialize)pictureBox4).EndInit();
            ((ISupportInitialize)pictureBox3).EndInit();
            ((ISupportInitialize)pictureBox1).EndInit();
            ((ISupportInitialize)pictureBox2).EndInit();
            ((ISupportInitialize)pictureBox7).EndInit();
            ((ISupportInitialize)pictureBox8).EndInit();
            gpApplicationInfo.ResumeLayout(false);
            gpApplicationInfo.PerformLayout();
            gbReplacementFor.ResumeLayout(false);
            gbReplacementFor.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.LinkLabel llShowLicenseInfo;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.LinkLabel llShowLicenseHistory;
        private System.Windows.Forms.Button btnIssueReplacement;
        private Licenses.Controls.ctrlDriverLicenseInfoWithFilter ctrlDriverLicenseInfoWithFilter1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblApplicationID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lblApplicationDate;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblApplicationFees;
        private System.Windows.Forms.Label lblCreatedByUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblRreplacedLicenseID;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblOldLicenseID;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.GroupBox gpApplicationInfo;
        private System.Windows.Forms.GroupBox gbReplacementFor;
        private System.Windows.Forms.RadioButton rbLostLicense;
        private System.Windows.Forms.RadioButton rbDamagedLicense;
    }
}