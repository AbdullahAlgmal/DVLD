namespace DVLD_UI.Applications.Local_Driving_License
{
    partial class frmListLocalDrivingLicesnseApplications
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
            pictureBox1 = new PictureBox();
            txtFilterValue = new TextBox();
            cbFilterBy = new ComboBox();
            lblRecordsCount = new Label();
            label2 = new Label();
            label1 = new Label();
            dgvLocalDrivingLicenseApplications = new DataGridView();
            pictureBox2 = new PictureBox();
            ((ISupportInitialize)pictureBox1).BeginInit();
            ((ISupportInitialize)dgvLocalDrivingLicenseApplications).BeginInit();
            ((ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.Top;
            lblTitle.ForeColor = Color.IndianRed;
            lblTitle.Location = new Point(307, 156);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(265, 29);
            lblTitle.TabIndex = 27;
            lblTitle.Text = "Local Driving License Applications";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top;
            pictureBox1.Image = Properties.Resources.Applications;
            pictureBox1.Location = new Point(307, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(265, 141);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
            // 
            // txtFilterValue
            // 
            txtFilterValue.Location = new Point(276, 193);
            txtFilterValue.Name = "txtFilterValue";
            txtFilterValue.Size = new Size(143, 21);
            txtFilterValue.TabIndex = 25;
            txtFilterValue.Visible = false;
            // 
            // cbFilterBy
            // 
            cbFilterBy.FormattingEnabled = true;
            cbFilterBy.Items.AddRange(new object[] { "None", "L.D.L.AppID", "National No.", "Full Name", "Status" });
            cbFilterBy.Location = new Point(126, 193);
            cbFilterBy.Name = "cbFilterBy";
            cbFilterBy.Size = new Size(144, 23);
            cbFilterBy.TabIndex = 24;
            // 
            // lblRecordsCount
            // 
            lblRecordsCount.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblRecordsCount.Location = new Point(126, 581);
            lblRecordsCount.Name = "lblRecordsCount";
            lblRecordsCount.Size = new Size(100, 39);
            lblRecordsCount.TabIndex = 23;
            lblRecordsCount.Text = "??";
            lblRecordsCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Location = new Point(20, 186);
            label2.Name = "label2";
            label2.Size = new Size(100, 39);
            label2.TabIndex = 22;
            label2.Text = "Filter By:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.Location = new Point(20, 581);
            label1.Name = "label1";
            label1.Size = new Size(100, 39);
            label1.TabIndex = 21;
            label1.Text = "# Records:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvLocalDrivingLicenseApplications
            // 
            dgvLocalDrivingLicenseApplications.AllowUserToAddRows = false;
            dgvLocalDrivingLicenseApplications.AllowUserToDeleteRows = false;
            dgvLocalDrivingLicenseApplications.AllowUserToResizeRows = false;
            dgvLocalDrivingLicenseApplications.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvLocalDrivingLicenseApplications.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvLocalDrivingLicenseApplications.BackgroundColor = Color.White;
            dgvLocalDrivingLicenseApplications.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLocalDrivingLicenseApplications.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvLocalDrivingLicenseApplications.GridColor = SystemColors.ControlDark;
            dgvLocalDrivingLicenseApplications.Location = new Point(3, 236);
            dgvLocalDrivingLicenseApplications.Margin = new Padding(2);
            dgvLocalDrivingLicenseApplications.MultiSelect = false;
            dgvLocalDrivingLicenseApplications.Name = "dgvLocalDrivingLicenseApplications";
            dgvLocalDrivingLicenseApplications.ReadOnly = true;
            dgvLocalDrivingLicenseApplications.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLocalDrivingLicenseApplications.Size = new Size(873, 343);
            dgvLocalDrivingLicenseApplications.TabIndex = 20;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top;
            pictureBox2.Image = Properties.Resources.Local_32;
            pictureBox2.Location = new Point(546, 61);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(50, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 28;
            pictureBox2.TabStop = false;
            // 
            // frmListLocalDrivingLicesnseApplications
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(878, 622);
            Controls.Add(pictureBox2);
            Controls.Add(lblTitle);
            Controls.Add(pictureBox1);
            Controls.Add(txtFilterValue);
            Controls.Add(cbFilterBy);
            Controls.Add(lblRecordsCount);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvLocalDrivingLicenseApplications);
            Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmListLocalDrivingLicesnseApplications";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "List Local Driving Licesnse Applications";
            ((ISupportInitialize)pictureBox1).EndInit();
            ((ISupportInitialize)dgvLocalDrivingLicenseApplications).EndInit();
            ((ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private PictureBox pictureBox1;
        private TextBox txtFilterValue;
        private ComboBox cbFilterBy;
        private Label lblRecordsCount;
        private Label label2;
        private Label label1;
        private DataGridView dgvLocalDrivingLicenseApplications;
        private PictureBox pictureBox2;
    }
}