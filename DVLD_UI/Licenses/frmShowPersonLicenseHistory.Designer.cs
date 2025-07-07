using DVLD_UI.People.Controls;

namespace DVLD.Licenses.International_License
{
    partial class frmShowPersonLicenseHistory
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
            pbPersonImage = new PictureBox();
            ctrlPersonCardWithFilter1 = new ctrlPersonCardWithFilter();
            ctrlDriverLicenses1 = new Local_Licenses.Controls.ctrlDriverLicenses();
            ((ISupportInitialize)pbPersonImage).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(192, 0, 0);
            lblTitle.Location = new Point(12, 12);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(1062, 39);
            lblTitle.TabIndex = 129;
            lblTitle.Text = "License History";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pbPersonImage
            // 
            pbPersonImage.BackgroundImageLayout = ImageLayout.Zoom;
            pbPersonImage.Image = DVLD_UI.Properties.Resources.PersonLicenseHistory_512;
            pbPersonImage.InitialImage = null;
            pbPersonImage.Location = new Point(8, 188);
            pbPersonImage.Margin = new Padding(4, 5, 4, 5);
            pbPersonImage.Name = "pbPersonImage";
            pbPersonImage.Size = new Size(220, 189);
            pbPersonImage.SizeMode = PictureBoxSizeMode.Zoom;
            pbPersonImage.TabIndex = 130;
            pbPersonImage.TabStop = false;
            // 
            // ctrlPersonCardWithFilter1
            // 
            ctrlPersonCardWithFilter1.AutoValidate = AutoValidate.EnableAllowFocusChange;
            ctrlPersonCardWithFilter1.BackColor = Color.White;
            ctrlPersonCardWithFilter1.FilterEnabled = true;
            ctrlPersonCardWithFilter1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ctrlPersonCardWithFilter1.Location = new Point(241, 46);
            ctrlPersonCardWithFilter1.Margin = new Padding(4, 5, 4, 5);
            ctrlPersonCardWithFilter1.Name = "ctrlPersonCardWithFilter1";
            ctrlPersonCardWithFilter1.ShowAddPerson = true;
            ctrlPersonCardWithFilter1.Size = new Size(837, 399);
            ctrlPersonCardWithFilter1.TabIndex = 132;
            // 
            // ctrlDriverLicenses1
            // 
            ctrlDriverLicenses1.BackColor = Color.White;
            ctrlDriverLicenses1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ctrlDriverLicenses1.Location = new Point(17, 455);
            ctrlDriverLicenses1.Margin = new Padding(4, 5, 4, 5);
            ctrlDriverLicenses1.Name = "ctrlDriverLicenses1";
            ctrlDriverLicenses1.Size = new Size(1061, 342);
            ctrlDriverLicenses1.TabIndex = 133;
            // 
            // frmShowPersonLicenseHistory
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1086, 821);
            Controls.Add(ctrlDriverLicenses1);
            Controls.Add(ctrlPersonCardWithFilter1);
            Controls.Add(pbPersonImage);
            Controls.Add(lblTitle);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmShowPersonLicenseHistory";
            StartPosition = FormStartPosition.CenterParent;
            Text = "License History";
            Load += frmShowPersonLicenseHistory_Load;
            ((ISupportInitialize)pbPersonImage).EndInit();
            ResumeLayout(false);
        }

        #endregion


        private System.Windows.Forms.PictureBox pbPersonImage;
        private System.Windows.Forms.Label lblTitle;
        private ctrlPersonCardWithFilter ctrlPersonCardWithFilter1;
        private Local_Licenses.Controls.ctrlDriverLicenses ctrlDriverLicenses1;
    }
}