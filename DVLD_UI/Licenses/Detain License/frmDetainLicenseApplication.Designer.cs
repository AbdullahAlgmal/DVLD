namespace DVLD.Applications.Detain_License
{
    partial class frmDetainLicenseApplication
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
            llShowLicenseInfo = new LinkLabel();
            btnDetain = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            pictureBox3 = new PictureBox();
            lblDetainDate = new Label();
            pictureBox4 = new PictureBox();
            label5 = new Label();
            lblDetainID = new Label();
            label4 = new Label();
            llShowLicenseHistory = new LinkLabel();
            gpDetain = new GroupBox();
            txtFineFees = new TextBox();
            lblCreatedByUser = new Label();
            lblTitle = new Label();
            errorProvider1 = new ErrorProvider(components);
            ctrlDriverLicenseInfoWithFilter1 = new Licenses.Controls.ctrlDriverLicenseInfoWithFilter();
            ((ISupportInitialize)pictureBox8).BeginInit();
            ((ISupportInitialize)pictureBox2).BeginInit();
            ((ISupportInitialize)pictureBox1).BeginInit();
            ((ISupportInitialize)pictureBox3).BeginInit();
            ((ISupportInitialize)pictureBox4).BeginInit();
            gpDetain.SuspendLayout();
            ((ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox8
            // 
            pictureBox8.Image = DVLD_UI.Properties.Resources.LocalDriving_License;
            pictureBox8.Location = new Point(581, 40);
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
            lblLicenseID.Location = new Point(619, 40);
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
            label10.Location = new Point(410, 40);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(100, 20);
            label10.TabIndex = 190;
            label10.Text = "License ID:";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = DVLD_UI.Properties.Resources.Number_32;
            pictureBox2.Location = new Point(187, 40);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(31, 26);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 183;
            pictureBox2.TabStop = false;
            // 
            // llShowLicenseInfo
            // 
            llShowLicenseInfo.AutoSize = true;
            llShowLicenseInfo.Enabled = false;
            llShowLicenseInfo.Location = new Point(200, 679);
            llShowLicenseInfo.Name = "llShowLicenseInfo";
            llShowLicenseInfo.Size = new Size(148, 20);
            llShowLicenseInfo.TabIndex = 184;
            llShowLicenseInfo.TabStop = true;
            llShowLicenseInfo.Text = "Show Licenses Info";
            llShowLicenseInfo.LinkClicked += llShowLicenseInfo_LinkClicked;
            // 
            // btnDetain
            // 
            btnDetain.Enabled = false;
            btnDetain.FlatStyle = FlatStyle.Flat;
            btnDetain.Image = DVLD_UI.Properties.Resources.International_32;
            btnDetain.ImageAlign = ContentAlignment.MiddleLeft;
            btnDetain.Location = new Point(741, 677);
            btnDetain.Name = "btnDetain";
            btnDetain.Size = new Size(126, 37);
            btnDetain.TabIndex = 182;
            btnDetain.Text = "Detain";
            btnDetain.UseVisualStyleBackColor = true;
            btnDetain.Click += btnDetain_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = DVLD_UI.Properties.Resources.User_32__2;
            pictureBox1.Location = new Point(581, 72);
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
            label1.Location = new Point(410, 72);
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
            label2.Location = new Point(16, 104);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(94, 20);
            label2.TabIndex = 177;
            label2.Text = "Fine Fees:";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = DVLD_UI.Properties.Resources.money_32;
            pictureBox3.Location = new Point(187, 104);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(31, 26);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 178;
            pictureBox3.TabStop = false;
            // 
            // lblDetainDate
            // 
            lblDetainDate.AutoSize = true;
            lblDetainDate.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDetainDate.Location = new Point(225, 72);
            lblDetainDate.Margin = new Padding(4, 0, 4, 0);
            lblDetainDate.Name = "lblDetainDate";
            lblDetainDate.Size = new Size(109, 20);
            lblDetainDate.TabIndex = 176;
            lblDetainDate.Text = "[??/??/????]";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = DVLD_UI.Properties.Resources.Calendar_32;
            pictureBox4.Location = new Point(187, 72);
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
            label5.Location = new Point(16, 72);
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
            lblDetainID.Location = new Point(225, 40);
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
            label4.Location = new Point(16, 40);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(91, 20);
            label4.TabIndex = 172;
            label4.Text = "Detain ID:";
            // 
            // llShowLicenseHistory
            // 
            llShowLicenseHistory.AutoSize = true;
            llShowLicenseHistory.Enabled = false;
            llShowLicenseHistory.Location = new Point(17, 679);
            llShowLicenseHistory.Name = "llShowLicenseHistory";
            llShowLicenseHistory.Size = new Size(169, 20);
            llShowLicenseHistory.TabIndex = 183;
            llShowLicenseHistory.TabStop = true;
            llShowLicenseHistory.Text = "Show Licenses History";
            llShowLicenseHistory.LinkClicked += llShowLicenseHistory_LinkClicked;
            // 
            // gpDetain
            // 
            gpDetain.Controls.Add(txtFineFees);
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
            gpDetain.Location = new Point(17, 487);
            gpDetain.Name = "gpDetain";
            gpDetain.Size = new Size(850, 184);
            gpDetain.TabIndex = 180;
            gpDetain.TabStop = false;
            gpDetain.Text = "Detain Info";
            // 
            // txtFineFees
            // 
            txtFineFees.Location = new Point(229, 104);
            txtFineFees.Name = "txtFineFees";
            txtFineFees.Size = new Size(102, 26);
            txtFineFees.TabIndex = 196;
            txtFineFees.Validating += txtFineFees_Validating;
            // 
            // lblCreatedByUser
            // 
            lblCreatedByUser.AutoSize = true;
            lblCreatedByUser.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCreatedByUser.Location = new Point(619, 72);
            lblCreatedByUser.Margin = new Padding(4, 0, 4, 0);
            lblCreatedByUser.Name = "lblCreatedByUser";
            lblCreatedByUser.Size = new Size(59, 20);
            lblCreatedByUser.TabIndex = 180;
            lblCreatedByUser.Text = "[????]";
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(192, 0, 0);
            lblTitle.Location = new Point(50, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(817, 39);
            lblTitle.TabIndex = 178;
            lblTitle.Text = "Detain License";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // ctrlDriverLicenseInfoWithFilter1
            // 
            ctrlDriverLicenseInfoWithFilter1.BackColor = Color.White;
            ctrlDriverLicenseInfoWithFilter1.FilterEnabled = true;
            ctrlDriverLicenseInfoWithFilter1.Location = new Point(3, 51);
            ctrlDriverLicenseInfoWithFilter1.Margin = new Padding(4, 3, 4, 3);
            ctrlDriverLicenseInfoWithFilter1.Name = "ctrlDriverLicenseInfoWithFilter1";
            ctrlDriverLicenseInfoWithFilter1.Size = new Size(879, 425);
            ctrlDriverLicenseInfoWithFilter1.TabIndex = 185;
            // 
            // frmDetainLicenseApplication
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            BackColor = Color.White;
            ClientSize = new Size(884, 723);
            Controls.Add(ctrlDriverLicenseInfoWithFilter1);
            Controls.Add(lblTitle);
            Controls.Add(llShowLicenseInfo);
            Controls.Add(btnDetain);
            Controls.Add(llShowLicenseHistory);
            Controls.Add(gpDetain);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmDetainLicenseApplication";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Detain License";
            Activated += frmDetainLicenseApplication_Activated;
            Load += frmDetainLicenseApplication_Load;
            ((ISupportInitialize)pictureBox8).EndInit();
            ((ISupportInitialize)pictureBox2).EndInit();
            ((ISupportInitialize)pictureBox1).EndInit();
            ((ISupportInitialize)pictureBox3).EndInit();
            ((ISupportInitialize)pictureBox4).EndInit();
            gpDetain.ResumeLayout(false);
            gpDetain.PerformLayout();
            ((ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Label lblLicenseID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.LinkLabel llShowLicenseInfo;
        private System.Windows.Forms.Button btnDetain;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblDetainDate;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblDetainID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel llShowLicenseHistory;
        private System.Windows.Forms.GroupBox gpDetain;
        private System.Windows.Forms.Label lblCreatedByUser;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtFineFees;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Licenses.Controls.ctrlDriverLicenseInfoWithFilter ctrlDriverLicenseInfoWithFilter1;
    }
}