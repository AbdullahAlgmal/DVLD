namespace DVLD.Licenses
{
    partial class frmRenewLocalDrivingLicenseApplication
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
            btnRenewLicense = new Button();
            gpApplicationInfo = new GroupBox();
            pictureBox11 = new PictureBox();
            label3 = new Label();
            txtNotes = new TextBox();
            lblTotalFees = new Label();
            label9 = new Label();
            pictureBox10 = new PictureBox();
            lblLicenseFees = new Label();
            label7 = new Label();
            pictureBox9 = new PictureBox();
            pictureBox8 = new PictureBox();
            lblOldLicenseID = new Label();
            label12 = new Label();
            pictureBox7 = new PictureBox();
            lblRenewedLicenseID = new Label();
            label10 = new Label();
            lblExpirationDate = new Label();
            pictureBox6 = new PictureBox();
            label8 = new Label();
            lblIssueDate = new Label();
            pictureBox5 = new PictureBox();
            label6 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            lblCreatedByUser = new Label();
            lblApplicationFees = new Label();
            label2 = new Label();
            pictureBox3 = new PictureBox();
            lblApplicationDate = new Label();
            pictureBox4 = new PictureBox();
            label5 = new Label();
            lblApplicationID = new Label();
            label4 = new Label();
            lblTitle = new Label();
            llShowLicenseInfo = new LinkLabel();
            llShowLicenseHistory = new LinkLabel();
            ctrlDriverLicenseInfoWithFilter1 = new Controls.ctrlDriverLicenseInfoWithFilter();
            gpApplicationInfo.SuspendLayout();
            ((ISupportInitialize)pictureBox11).BeginInit();
            ((ISupportInitialize)pictureBox10).BeginInit();
            ((ISupportInitialize)pictureBox9).BeginInit();
            ((ISupportInitialize)pictureBox8).BeginInit();
            ((ISupportInitialize)pictureBox7).BeginInit();
            ((ISupportInitialize)pictureBox6).BeginInit();
            ((ISupportInitialize)pictureBox5).BeginInit();
            ((ISupportInitialize)pictureBox2).BeginInit();
            ((ISupportInitialize)pictureBox1).BeginInit();
            ((ISupportInitialize)pictureBox3).BeginInit();
            ((ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // btnRenewLicense
            // 
            btnRenewLicense.Enabled = false;
            btnRenewLicense.FlatStyle = FlatStyle.Flat;
            btnRenewLicense.Image = DVLD_UI.Properties.Resources.Renew_Driving_License_32;
            btnRenewLicense.ImageAlign = ContentAlignment.MiddleLeft;
            btnRenewLicense.Location = new Point(749, 783);
            btnRenewLicense.Name = "btnRenewLicense";
            btnRenewLicense.Size = new Size(126, 37);
            btnRenewLicense.TabIndex = 180;
            btnRenewLicense.Text = " Renew";
            btnRenewLicense.UseVisualStyleBackColor = true;
            btnRenewLicense.Click += btnRenewLicense_Click;
            // 
            // gpApplicationInfo
            // 
            gpApplicationInfo.Controls.Add(pictureBox11);
            gpApplicationInfo.Controls.Add(label3);
            gpApplicationInfo.Controls.Add(txtNotes);
            gpApplicationInfo.Controls.Add(lblTotalFees);
            gpApplicationInfo.Controls.Add(label9);
            gpApplicationInfo.Controls.Add(pictureBox10);
            gpApplicationInfo.Controls.Add(lblLicenseFees);
            gpApplicationInfo.Controls.Add(label7);
            gpApplicationInfo.Controls.Add(pictureBox9);
            gpApplicationInfo.Controls.Add(pictureBox8);
            gpApplicationInfo.Controls.Add(lblOldLicenseID);
            gpApplicationInfo.Controls.Add(label12);
            gpApplicationInfo.Controls.Add(pictureBox7);
            gpApplicationInfo.Controls.Add(lblRenewedLicenseID);
            gpApplicationInfo.Controls.Add(label10);
            gpApplicationInfo.Controls.Add(lblExpirationDate);
            gpApplicationInfo.Controls.Add(pictureBox6);
            gpApplicationInfo.Controls.Add(label8);
            gpApplicationInfo.Controls.Add(lblIssueDate);
            gpApplicationInfo.Controls.Add(pictureBox5);
            gpApplicationInfo.Controls.Add(label6);
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
            gpApplicationInfo.Location = new Point(33, 493);
            gpApplicationInfo.Name = "gpApplicationInfo";
            gpApplicationInfo.Size = new Size(845, 284);
            gpApplicationInfo.TabIndex = 178;
            gpApplicationInfo.TabStop = false;
            gpApplicationInfo.Text = "Application New License Info";
            // 
            // pictureBox11
            // 
            pictureBox11.Image = DVLD_UI.Properties.Resources.Notes_32;
            pictureBox11.Location = new Point(182, 199);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(31, 26);
            pictureBox11.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox11.TabIndex = 204;
            pictureBox11.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 199);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(61, 20);
            label3.TabIndex = 203;
            label3.Text = "Notes:";
            // 
            // txtNotes
            // 
            txtNotes.Location = new Point(225, 199);
            txtNotes.MaxLength = 500;
            txtNotes.Multiline = true;
            txtNotes.Name = "txtNotes";
            txtNotes.Size = new Size(513, 64);
            txtNotes.TabIndex = 202;
            // 
            // lblTotalFees
            // 
            lblTotalFees.AutoSize = true;
            lblTotalFees.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalFees.Location = new Point(627, 167);
            lblTotalFees.Margin = new Padding(4, 0, 4, 0);
            lblTotalFees.Name = "lblTotalFees";
            lblTotalFees.Size = new Size(49, 20);
            lblTotalFees.TabIndex = 201;
            lblTotalFees.Text = "[$$$]";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(406, 167);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(104, 20);
            label9.TabIndex = 199;
            label9.Text = "Total  Fees:";
            // 
            // pictureBox10
            // 
            pictureBox10.Image = DVLD_UI.Properties.Resources.money_32;
            pictureBox10.Location = new Point(591, 167);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(31, 26);
            pictureBox10.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox10.TabIndex = 200;
            pictureBox10.TabStop = false;
            // 
            // lblLicenseFees
            // 
            lblLicenseFees.AutoSize = true;
            lblLicenseFees.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLicenseFees.Location = new Point(221, 167);
            lblLicenseFees.Margin = new Padding(4, 0, 4, 0);
            lblLicenseFees.Name = "lblLicenseFees";
            lblLicenseFees.Size = new Size(49, 20);
            lblLicenseFees.TabIndex = 198;
            lblLicenseFees.Text = "[$$$]";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(12, 167);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(126, 20);
            label7.TabIndex = 196;
            label7.Text = "License  Fees:";
            // 
            // pictureBox9
            // 
            pictureBox9.Image = DVLD_UI.Properties.Resources.money_32;
            pictureBox9.Location = new Point(183, 167);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(31, 26);
            pictureBox9.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox9.TabIndex = 197;
            pictureBox9.TabStop = false;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = DVLD_UI.Properties.Resources.LocalDriving_License;
            pictureBox8.Location = new Point(591, 70);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(31, 26);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 195;
            pictureBox8.TabStop = false;
            // 
            // lblOldLicenseID
            // 
            lblOldLicenseID.AutoSize = true;
            lblOldLicenseID.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOldLicenseID.Location = new Point(629, 70);
            lblOldLicenseID.Margin = new Padding(4, 0, 4, 0);
            lblOldLicenseID.Name = "lblOldLicenseID";
            lblOldLicenseID.Size = new Size(49, 20);
            lblOldLicenseID.TabIndex = 194;
            lblOldLicenseID.Text = "[???]";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(406, 70);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(132, 20);
            label12.TabIndex = 193;
            label12.Text = "Old License ID:";
            // 
            // pictureBox7
            // 
            pictureBox7.Image = DVLD_UI.Properties.Resources.Renew_Driving_License_32;
            pictureBox7.Location = new Point(591, 38);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(31, 26);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 192;
            pictureBox7.TabStop = false;
            // 
            // lblRenewedLicenseID
            // 
            lblRenewedLicenseID.AutoSize = true;
            lblRenewedLicenseID.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRenewedLicenseID.Location = new Point(629, 38);
            lblRenewedLicenseID.Margin = new Padding(4, 0, 4, 0);
            lblRenewedLicenseID.Name = "lblRenewedLicenseID";
            lblRenewedLicenseID.Size = new Size(49, 20);
            lblRenewedLicenseID.TabIndex = 191;
            lblRenewedLicenseID.Text = "[???]";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(406, 38);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(180, 20);
            label10.TabIndex = 190;
            label10.Text = "Renewed License ID:";
            // 
            // lblExpirationDate
            // 
            lblExpirationDate.AutoSize = true;
            lblExpirationDate.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblExpirationDate.Location = new Point(629, 102);
            lblExpirationDate.Margin = new Padding(4, 0, 4, 0);
            lblExpirationDate.Name = "lblExpirationDate";
            lblExpirationDate.Size = new Size(109, 20);
            lblExpirationDate.TabIndex = 189;
            lblExpirationDate.Text = "[??/??/????]";
            // 
            // pictureBox6
            // 
            pictureBox6.Image = DVLD_UI.Properties.Resources.Calendar_32;
            pictureBox6.Location = new Point(591, 102);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(31, 26);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 188;
            pictureBox6.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(406, 102);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(138, 20);
            label8.TabIndex = 187;
            label8.Text = "Expiration Date:";
            // 
            // lblIssueDate
            // 
            lblIssueDate.AutoSize = true;
            lblIssueDate.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIssueDate.Location = new Point(221, 102);
            lblIssueDate.Margin = new Padding(4, 0, 4, 0);
            lblIssueDate.Name = "lblIssueDate";
            lblIssueDate.Size = new Size(109, 20);
            lblIssueDate.TabIndex = 186;
            lblIssueDate.Text = "[??/??/????]";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = DVLD_UI.Properties.Resources.Calendar_32;
            pictureBox5.Location = new Point(182, 102);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(31, 26);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 185;
            pictureBox5.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(12, 102);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(102, 20);
            label6.TabIndex = 184;
            label6.Text = "Issue Date:";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = DVLD_UI.Properties.Resources.Number_32;
            pictureBox2.Location = new Point(183, 38);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(31, 26);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 183;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = DVLD_UI.Properties.Resources.User_32__2;
            pictureBox1.Location = new Point(591, 134);
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
            label1.Location = new Point(406, 134);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(103, 20);
            label1.TabIndex = 181;
            label1.Text = "Created By:";
            // 
            // lblCreatedByUser
            // 
            lblCreatedByUser.AutoSize = true;
            lblCreatedByUser.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCreatedByUser.Location = new Point(629, 134);
            lblCreatedByUser.Margin = new Padding(4, 0, 4, 0);
            lblCreatedByUser.Name = "lblCreatedByUser";
            lblCreatedByUser.Size = new Size(59, 20);
            lblCreatedByUser.TabIndex = 180;
            lblCreatedByUser.Text = "[????]";
            // 
            // lblApplicationFees
            // 
            lblApplicationFees.AutoSize = true;
            lblApplicationFees.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblApplicationFees.Location = new Point(221, 134);
            lblApplicationFees.Margin = new Padding(4, 0, 4, 0);
            lblApplicationFees.Name = "lblApplicationFees";
            lblApplicationFees.Size = new Size(49, 20);
            lblApplicationFees.TabIndex = 179;
            lblApplicationFees.Text = "[$$$]";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 134);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(148, 20);
            label2.TabIndex = 177;
            label2.Text = "Application Fees:";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = DVLD_UI.Properties.Resources.money_32;
            pictureBox3.Location = new Point(183, 134);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(31, 26);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 178;
            pictureBox3.TabStop = false;
            // 
            // lblApplicationDate
            // 
            lblApplicationDate.AutoSize = true;
            lblApplicationDate.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblApplicationDate.Location = new Point(221, 70);
            lblApplicationDate.Margin = new Padding(4, 0, 4, 0);
            lblApplicationDate.Name = "lblApplicationDate";
            lblApplicationDate.Size = new Size(109, 20);
            lblApplicationDate.TabIndex = 176;
            lblApplicationDate.Text = "[??/??/????]";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = DVLD_UI.Properties.Resources.Calendar_32;
            pictureBox4.Location = new Point(183, 70);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(31, 26);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 175;
            pictureBox4.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 70);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(147, 20);
            label5.TabIndex = 174;
            label5.Text = "Application Date:";
            // 
            // lblApplicationID
            // 
            lblApplicationID.AutoSize = true;
            lblApplicationID.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblApplicationID.Location = new Point(221, 38);
            lblApplicationID.Margin = new Padding(4, 0, 4, 0);
            lblApplicationID.Name = "lblApplicationID";
            lblApplicationID.Size = new Size(49, 20);
            lblApplicationID.TabIndex = 173;
            lblApplicationID.Text = "[???]";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 38);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(160, 20);
            label4.TabIndex = 172;
            label4.Text = "R.L.Application ID:";
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(192, 0, 0);
            lblTitle.Location = new Point(10, 6);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(875, 39);
            lblTitle.TabIndex = 176;
            lblTitle.Text = "Renew License Application";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // llShowLicenseInfo
            // 
            llShowLicenseInfo.AutoSize = true;
            llShowLicenseInfo.Enabled = false;
            llShowLicenseInfo.Location = new Point(213, 788);
            llShowLicenseInfo.Name = "llShowLicenseInfo";
            llShowLicenseInfo.Size = new Size(183, 20);
            llShowLicenseInfo.TabIndex = 182;
            llShowLicenseInfo.TabStop = true;
            llShowLicenseInfo.Text = "Show New Licenses Info";
            llShowLicenseInfo.LinkClicked += llShowLicenseInfo_LinkClicked;
            // 
            // llShowLicenseHistory
            // 
            llShowLicenseHistory.AutoSize = true;
            llShowLicenseHistory.Enabled = false;
            llShowLicenseHistory.Location = new Point(30, 788);
            llShowLicenseHistory.Name = "llShowLicenseHistory";
            llShowLicenseHistory.Size = new Size(169, 20);
            llShowLicenseHistory.TabIndex = 181;
            llShowLicenseHistory.TabStop = true;
            llShowLicenseHistory.Text = "Show Licenses History";
            llShowLicenseHistory.LinkClicked += llShowLicenseHistory_LinkClicked;
            // 
            // ctrlDriverLicenseInfoWithFilter1
            // 
            ctrlDriverLicenseInfoWithFilter1.BackColor = Color.White;
            ctrlDriverLicenseInfoWithFilter1.FilterEnabled = true;
            ctrlDriverLicenseInfoWithFilter1.Location = new Point(19, 32);
            ctrlDriverLicenseInfoWithFilter1.Margin = new Padding(6, 8, 6, 8);
            ctrlDriverLicenseInfoWithFilter1.Name = "ctrlDriverLicenseInfoWithFilter1";
            ctrlDriverLicenseInfoWithFilter1.Size = new Size(878, 450);
            ctrlDriverLicenseInfoWithFilter1.TabIndex = 177;
            ctrlDriverLicenseInfoWithFilter1.OnLicenseSelected += ctrlDriverLicenseInfoWithFilter1_OnLicenseSelected;
            // 
            // frmRenewLocalDrivingLicenseApplication
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(894, 832);
            Controls.Add(llShowLicenseInfo);
            Controls.Add(llShowLicenseHistory);
            Controls.Add(btnRenewLicense);
            Controls.Add(gpApplicationInfo);
            Controls.Add(lblTitle);
            Controls.Add(ctrlDriverLicenseInfoWithFilter1);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmRenewLocalDrivingLicenseApplication";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Renew Local Driving License";
            Activated += frmRenewLocalDrivingLicenseApplication_Activated;
            Load += frmRenewLocalDrivingLicenseApplication_Load;
            gpApplicationInfo.ResumeLayout(false);
            gpApplicationInfo.PerformLayout();
            ((ISupportInitialize)pictureBox11).EndInit();
            ((ISupportInitialize)pictureBox10).EndInit();
            ((ISupportInitialize)pictureBox9).EndInit();
            ((ISupportInitialize)pictureBox8).EndInit();
            ((ISupportInitialize)pictureBox7).EndInit();
            ((ISupportInitialize)pictureBox6).EndInit();
            ((ISupportInitialize)pictureBox5).EndInit();
            ((ISupportInitialize)pictureBox2).EndInit();
            ((ISupportInitialize)pictureBox1).EndInit();
            ((ISupportInitialize)pictureBox3).EndInit();
            ((ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnRenewLicense;
        private System.Windows.Forms.GroupBox gpApplicationInfo;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Label lblOldLicenseID;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label lblRenewedLicenseID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblExpirationDate;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCreatedByUser;
        private System.Windows.Forms.Label lblApplicationFees;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblApplicationDate;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblApplicationID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTitle;
        private Controls.ctrlDriverLicenseInfoWithFilter ctrlDriverLicenseInfoWithFilter1;
        private System.Windows.Forms.LinkLabel llShowLicenseInfo;
        private System.Windows.Forms.LinkLabel llShowLicenseHistory;
        private System.Windows.Forms.Label lblIssueDate;
        private System.Windows.Forms.Label lblTotalFees;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.Label lblLicenseFees;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNotes;
    }
}