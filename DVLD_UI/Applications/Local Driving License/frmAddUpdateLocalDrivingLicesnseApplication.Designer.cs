namespace DVLD_UI.Applications.Local_Driving_License
{
    partial class frmAddUpdateLocalDrivingLicesnseApplication
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
            tcApplicationInfo = new TabControl();
            tpPersonInfo = new TabPage();
            btNext = new Button();
            ctrlPersonCardWithFilter1 = new People.Controls.ctrlPersonCardWithFilter();
            tpApplicationInfo = new TabPage();
            cbLicenseClass = new ComboBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            lblApplicationDate = new Label();
            lblCreatedBy = new Label();
            pictureBox6 = new PictureBox();
            pictureBox8 = new PictureBox();
            label11 = new Label();
            label15 = new Label();
            lblApplicationFees = new Label();
            lblDLAppId = new Label();
            pictureBox3 = new PictureBox();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            btSave = new Button();
            lblTitle = new Label();
            tcApplicationInfo.SuspendLayout();
            tpPersonInfo.SuspendLayout();
            tpApplicationInfo.SuspendLayout();
            ((ISupportInitialize)pictureBox2).BeginInit();
            ((ISupportInitialize)pictureBox6).BeginInit();
            ((ISupportInitialize)pictureBox8).BeginInit();
            ((ISupportInitialize)pictureBox3).BeginInit();
            ((ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tcApplicationInfo
            // 
            tcApplicationInfo.Controls.Add(tpPersonInfo);
            tcApplicationInfo.Controls.Add(tpApplicationInfo);
            tcApplicationInfo.Dock = DockStyle.Bottom;
            tcApplicationInfo.Location = new Point(0, 58);
            tcApplicationInfo.Name = "tcApplicationInfo";
            tcApplicationInfo.SelectedIndex = 0;
            tcApplicationInfo.Size = new Size(800, 554);
            tcApplicationInfo.TabIndex = 4;
            // 
            // tpPersonInfo
            // 
            tpPersonInfo.Controls.Add(btNext);
            tpPersonInfo.Controls.Add(ctrlPersonCardWithFilter1);
            tpPersonInfo.Location = new Point(4, 24);
            tpPersonInfo.Name = "tpPersonInfo";
            tpPersonInfo.Padding = new Padding(3);
            tpPersonInfo.Size = new Size(792, 526);
            tpPersonInfo.TabIndex = 0;
            tpPersonInfo.Text = "Person Info";
            tpPersonInfo.UseVisualStyleBackColor = true;
            // 
            // btNext
            // 
            btNext.Anchor = AnchorStyles.Right;
            btNext.FlatStyle = FlatStyle.Flat;
            btNext.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btNext.Image = Properties.Resources.Next_32;
            btNext.ImageAlign = ContentAlignment.MiddleRight;
            btNext.Location = new Point(646, 472);
            btNext.Name = "btNext";
            btNext.Size = new Size(138, 46);
            btNext.TabIndex = 6;
            btNext.Text = "Next";
            btNext.UseVisualStyleBackColor = true;
            btNext.Click += btnApplicationInfoNext_Click;
            // 
            // ctrlPersonCardWithFilter1
            // 
            ctrlPersonCardWithFilter1.BackColor = Color.White;
            ctrlPersonCardWithFilter1.Dock = DockStyle.Top;
            ctrlPersonCardWithFilter1.FilterEnabled = true;
            ctrlPersonCardWithFilter1.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ctrlPersonCardWithFilter1.Location = new Point(3, 3);
            ctrlPersonCardWithFilter1.Name = "ctrlPersonCardWithFilter1";
            ctrlPersonCardWithFilter1.ShowAddPerson = true;
            ctrlPersonCardWithFilter1.Size = new Size(786, 463);
            ctrlPersonCardWithFilter1.TabIndex = 0;
            ctrlPersonCardWithFilter1.OnPersonSelected += ctrlPersonCardWithFilter1_OnPersonSelected;
            // 
            // tpApplicationInfo
            // 
            tpApplicationInfo.Controls.Add(cbLicenseClass);
            tpApplicationInfo.Controls.Add(pictureBox2);
            tpApplicationInfo.Controls.Add(label1);
            tpApplicationInfo.Controls.Add(lblApplicationDate);
            tpApplicationInfo.Controls.Add(lblCreatedBy);
            tpApplicationInfo.Controls.Add(pictureBox6);
            tpApplicationInfo.Controls.Add(pictureBox8);
            tpApplicationInfo.Controls.Add(label11);
            tpApplicationInfo.Controls.Add(label15);
            tpApplicationInfo.Controls.Add(lblApplicationFees);
            tpApplicationInfo.Controls.Add(lblDLAppId);
            tpApplicationInfo.Controls.Add(pictureBox3);
            tpApplicationInfo.Controls.Add(label5);
            tpApplicationInfo.Controls.Add(pictureBox1);
            tpApplicationInfo.Controls.Add(label2);
            tpApplicationInfo.Controls.Add(btSave);
            tpApplicationInfo.Location = new Point(4, 24);
            tpApplicationInfo.Name = "tpApplicationInfo";
            tpApplicationInfo.Padding = new Padding(3);
            tpApplicationInfo.Size = new Size(792, 526);
            tpApplicationInfo.TabIndex = 1;
            tpApplicationInfo.Text = "Application Info";
            tpApplicationInfo.UseVisualStyleBackColor = true;
            // 
            // cbLicenseClass
            // 
            cbLicenseClass.FormattingEnabled = true;
            cbLicenseClass.Location = new Point(423, 254);
            cbLicenseClass.Name = "cbLicenseClass";
            cbLicenseClass.Size = new Size(135, 23);
            cbLicenseClass.TabIndex = 48;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Renew_Driving_License_32;
            pictureBox2.Location = new Point(392, 249);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(25, 25);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 47;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(236, 256);
            label1.Name = "label1";
            label1.Size = new Size(122, 19);
            label1.TabIndex = 46;
            label1.Text = "License Class:";
            // 
            // lblApplicationDate
            // 
            lblApplicationDate.AutoSize = true;
            lblApplicationDate.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblApplicationDate.ForeColor = Color.Red;
            lblApplicationDate.Location = new Point(422, 209);
            lblApplicationDate.Name = "lblApplicationDate";
            lblApplicationDate.Size = new Size(98, 18);
            lblApplicationDate.TabIndex = 42;
            lblApplicationDate.Text = "[??/??/????]";
            // 
            // lblCreatedBy
            // 
            lblCreatedBy.AutoSize = true;
            lblCreatedBy.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCreatedBy.ForeColor = Color.Red;
            lblCreatedBy.Location = new Point(422, 349);
            lblCreatedBy.Name = "lblCreatedBy";
            lblCreatedBy.Size = new Size(45, 18);
            lblCreatedBy.TabIndex = 45;
            lblCreatedBy.Text = "[???]";
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.Calendar_32;
            pictureBox6.Location = new Point(391, 203);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(25, 25);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 41;
            pictureBox6.TabStop = false;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = Properties.Resources.User_32__2;
            pictureBox8.Location = new Point(391, 341);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(25, 25);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 44;
            pictureBox8.TabStop = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(236, 210);
            label11.Name = "label11";
            label11.Size = new Size(140, 19);
            label11.TabIndex = 40;
            label11.Text = "Application Date:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(236, 348);
            label15.Name = "label15";
            label15.Size = new Size(95, 19);
            label15.TabIndex = 43;
            label15.Text = "Created BY";
            // 
            // lblApplicationFees
            // 
            lblApplicationFees.AutoSize = true;
            lblApplicationFees.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblApplicationFees.ForeColor = Color.Red;
            lblApplicationFees.Location = new Point(422, 304);
            lblApplicationFees.Name = "lblApplicationFees";
            lblApplicationFees.Size = new Size(42, 18);
            lblApplicationFees.TabIndex = 39;
            lblApplicationFees.Text = "[$$$]";
            // 
            // lblDLAppId
            // 
            lblDLAppId.AutoSize = true;
            lblDLAppId.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDLAppId.ForeColor = Color.Red;
            lblDLAppId.Location = new Point(422, 164);
            lblDLAppId.Name = "lblDLAppId";
            lblDLAppId.Size = new Size(45, 18);
            lblDLAppId.TabIndex = 24;
            lblDLAppId.Text = "[???]";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.money_32;
            pictureBox3.Location = new Point(391, 295);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(25, 25);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 38;
            pictureBox3.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(235, 302);
            label5.Name = "label5";
            label5.Size = new Size(138, 19);
            label5.TabIndex = 37;
            label5.Text = "Appication Fees:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Number_32;
            pictureBox1.Location = new Point(391, 157);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(25, 25);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(235, 164);
            label2.Name = "label2";
            label2.Size = new Size(95, 19);
            label2.TabIndex = 22;
            label2.Text = "D.L App ID:";
            // 
            // btSave
            // 
            btSave.FlatStyle = FlatStyle.Flat;
            btSave.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btSave.Image = Properties.Resources.Save_32;
            btSave.ImageAlign = ContentAlignment.MiddleLeft;
            btSave.Location = new Point(646, 472);
            btSave.Name = "btSave";
            btSave.Size = new Size(138, 46);
            btSave.TabIndex = 5;
            btSave.Text = "Save";
            btSave.UseVisualStyleBackColor = true;
            btSave.Click += btnSave_Click;
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Top;
            lblTitle.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Red;
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(800, 55);
            lblTitle.TabIndex = 3;
            lblTitle.Text = "Local Driving License Application";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmAddUpdateLocalDrivingLicesnseApplication
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 612);
            Controls.Add(tcApplicationInfo);
            Controls.Add(lblTitle);
            Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmAddUpdateLocalDrivingLicesnseApplication";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add/Update Loca lDriving Licesnse Application";
            Activated += frmAddUpdateLocalDrivingLicesnseApplication_Activated;
            Load += frmAddUpdateLocalDrivingLicesnseApplication_Load;
            tcApplicationInfo.ResumeLayout(false);
            tpPersonInfo.ResumeLayout(false);
            tpApplicationInfo.ResumeLayout(false);
            tpApplicationInfo.PerformLayout();
            ((ISupportInitialize)pictureBox2).EndInit();
            ((ISupportInitialize)pictureBox6).EndInit();
            ((ISupportInitialize)pictureBox8).EndInit();
            ((ISupportInitialize)pictureBox3).EndInit();
            ((ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TabControl tcApplicationInfo;
        private TabPage tpPersonInfo;
        private People.Controls.ctrlPersonCardWithFilter ctrlPersonCardWithFilter1;
        private TabPage tpApplicationInfo;
        private Button btSave;
        private Label lblTitle;
        private Button btNext;
        private Label lblDLAppId;
        private PictureBox pictureBox1;
        private Label label2;
        private Label lblCreatedBy;
        private PictureBox pictureBox8;
        private Label label15;
        private Label lblApplicationDate;
        private PictureBox pictureBox6;
        private Label label11;
        private Label lblApplicationFees;
        private PictureBox pictureBox3;
        private Label label5;
        private ComboBox cbLicenseClass;
        private PictureBox pictureBox2;
        private Label label1;
    }
}