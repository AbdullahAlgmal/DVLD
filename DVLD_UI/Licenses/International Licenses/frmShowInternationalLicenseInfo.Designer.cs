namespace DVLD.Licenses.International_Licenses
{
    partial class frmShowInternationalLicenseInfo
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
            lblTitle = new Label();
            pbTestTypeImage = new PictureBox();
            pictureBox9 = new PictureBox();
            ctrlDriverInternationalLicenseInfo1 = new Controls.ctrlDriverInternationalLicenseInfo();
            ((ISupportInitialize)pbTestTypeImage).BeginInit();
            ((ISupportInitialize)pictureBox9).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(192, 0, 0);
            lblTitle.Location = new Point(176, 119);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(520, 39);
            lblTitle.TabIndex = 138;
            lblTitle.Text = "Driver International License Info";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pbTestTypeImage
            // 
            pbTestTypeImage.BackgroundImageLayout = ImageLayout.Zoom;
            pbTestTypeImage.Image = DVLD_UI.Properties.Resources.LicenseView_400;
            pbTestTypeImage.InitialImage = null;
            pbTestTypeImage.Location = new Point(393, 9);
            pbTestTypeImage.Margin = new Padding(4, 5, 4, 5);
            pbTestTypeImage.Name = "pbTestTypeImage";
            pbTestTypeImage.Size = new Size(113, 104);
            pbTestTypeImage.SizeMode = PictureBoxSizeMode.Zoom;
            pbTestTypeImage.TabIndex = 137;
            pbTestTypeImage.TabStop = false;
            // 
            // pictureBox9
            // 
            pictureBox9.Image = DVLD_UI.Properties.Resources.International_32;
            pictureBox9.Location = new Point(393, 9);
            pictureBox9.Margin = new Padding(4, 5, 4, 5);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(31, 26);
            pictureBox9.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox9.TabIndex = 190;
            pictureBox9.TabStop = false;
            // 
            // ctrlDriverInternationalLicenseInfo1
            // 
            ctrlDriverInternationalLicenseInfo1.BackColor = Color.White;
            ctrlDriverInternationalLicenseInfo1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ctrlDriverInternationalLicenseInfo1.Location = new Point(7, 163);
            ctrlDriverInternationalLicenseInfo1.Margin = new Padding(4, 5, 4, 5);
            ctrlDriverInternationalLicenseInfo1.Name = "ctrlDriverInternationalLicenseInfo1";
            ctrlDriverInternationalLicenseInfo1.Size = new Size(869, 273);
            ctrlDriverInternationalLicenseInfo1.TabIndex = 191;
            // 
            // frmShowInternationalLicenseInfo
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(883, 435);
            Controls.Add(ctrlDriverInternationalLicenseInfo1);
            Controls.Add(pictureBox9);
            Controls.Add(lblTitle);
            Controls.Add(pbTestTypeImage);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmShowInternationalLicenseInfo";
            StartPosition = FormStartPosition.CenterParent;
            Text = "International Driver Info";
            Load += frmShowInternationalLicenseInfo_Load;
            ((ISupportInitialize)pbTestTypeImage).EndInit();
            ((ISupportInitialize)pictureBox9).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pbTestTypeImage;
        private System.Windows.Forms.PictureBox pictureBox9;
        private Controls.ctrlDriverInternationalLicenseInfo ctrlDriverInternationalLicenseInfo1;
    }
}