namespace DVLD.DriverLicense
{
    partial class frmShowLicenseInfo
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
            ctrlDriverLicenseInfo1 = new ctrlDriverLicenseInfo();
            ((ISupportInitialize)pbTestTypeImage).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(192, 0, 0);
            lblTitle.Location = new Point(239, 111);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(441, 39);
            lblTitle.TabIndex = 135;
            lblTitle.Text = "Driver License Info";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pbTestTypeImage
            // 
            pbTestTypeImage.BackgroundImageLayout = ImageLayout.Zoom;
            pbTestTypeImage.Image = DVLD_UI.Properties.Resources.LicenseView_400;
            pbTestTypeImage.InitialImage = null;
            pbTestTypeImage.Location = new Point(398, 1);
            pbTestTypeImage.Margin = new Padding(4, 5, 4, 5);
            pbTestTypeImage.Name = "pbTestTypeImage";
            pbTestTypeImage.Size = new Size(113, 104);
            pbTestTypeImage.SizeMode = PictureBoxSizeMode.Zoom;
            pbTestTypeImage.TabIndex = 134;
            pbTestTypeImage.TabStop = false;
            // 
            // ctrlDriverLicenseInfo1
            // 
            ctrlDriverLicenseInfo1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ctrlDriverLicenseInfo1.Location = new Point(1, 173);
            ctrlDriverLicenseInfo1.Margin = new Padding(4, 5, 4, 5);
            ctrlDriverLicenseInfo1.Name = "ctrlDriverLicenseInfo1";
            ctrlDriverLicenseInfo1.Size = new Size(867, 339);
            ctrlDriverLicenseInfo1.TabIndex = 136;
            // 
            // frmShowLicenseInfo
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(869, 526);
            Controls.Add(ctrlDriverLicenseInfo1);
            Controls.Add(lblTitle);
            Controls.Add(pbTestTypeImage);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmShowLicenseInfo";
            StartPosition = FormStartPosition.CenterParent;
            Text = "License Info";
            Load += frmShowLicenseInfo_Load;
            ((ISupportInitialize)pbTestTypeImage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pbTestTypeImage;
        private ctrlDriverLicenseInfo ctrlDriverLicenseInfo1;
    }
}