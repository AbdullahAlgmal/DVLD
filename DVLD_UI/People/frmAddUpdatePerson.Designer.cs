namespace DVLD_UI.People
{
    partial class frmAddUpdatePerson
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
            components = new System.ComponentModel.Container();
            txtSecondName = new TextBox();
            lblTitle = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            lblPersonId = new Label();
            groupBox1 = new GroupBox();
            dtpBirthDate = new DateTimePicker();
            cbCountry = new ComboBox();
            txtPhone = new TextBox();
            pictureBox7 = new PictureBox();
            pictureBox8 = new PictureBox();
            pictureBox9 = new PictureBox();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            txtAddress = new TextBox();
            txtEmail = new TextBox();
            txtNationalNum = new TextBox();
            pictureBox6 = new PictureBox();
            label7 = new Label();
            pictureBox5 = new PictureBox();
            label6 = new Label();
            txtThirdName = new TextBox();
            txtLastName = new TextBox();
            rbFemale = new RadioButton();
            pictureBox4 = new PictureBox();
            rbMale = new RadioButton();
            pbGender = new PictureBox();
            label5 = new Label();
            pictureBox3 = new PictureBox();
            label4 = new Label();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            txtFirstName = new TextBox();
            button1 = new Button();
            llRemoveImage = new LinkLabel();
            llSetImage = new LinkLabel();
            pbPersonImage = new PictureBox();
            errorProvider1 = new ErrorProvider(components);
            openFileDialog1 = new OpenFileDialog();
            txtSecondName = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbGender).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbPersonImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // txtSecondName
            // 
            txtSecondName.Font = new Font("Arial", 9.75F);
            txtSecondName.Location = new Point(333, 17);
            txtSecondName.MaxLength = 50;
            txtSecondName.Name = "txtSecondName";
            txtSecondName.PlaceholderText = "Second";
            txtSecondName.Size = new Size(140, 22);
            txtSecondName.TabIndex = 19;
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Top;
            lblTitle.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Red;
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(826, 55);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Add New Person";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 67);
            label2.Name = "label2";
            label2.Size = new Size(94, 19);
            label2.TabIndex = 1;
            label2.Text = "Person ID :";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Number_32;
            pictureBox1.Location = new Point(112, 61);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(25, 25);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // lblPersonId
            // 
            lblPersonId.AutoSize = true;
            lblPersonId.Location = new Point(143, 67);
            lblPersonId.Name = "lblPersonId";
            lblPersonId.Size = new Size(36, 19);
            lblPersonId.TabIndex = 3;
            lblPersonId.Text = "N/A";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtpBirthDate);
            groupBox1.Controls.Add(cbCountry);
            groupBox1.Controls.Add(txtPhone);
            groupBox1.Controls.Add(pictureBox7);
            groupBox1.Controls.Add(pictureBox8);
            groupBox1.Controls.Add(pictureBox9);
            groupBox1.Controls.Add(label15);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(txtAddress);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(txtNationalNum);
            groupBox1.Controls.Add(pictureBox6);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(pictureBox5);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtSecondName);
            groupBox1.Controls.Add(txtThirdName);
            groupBox1.Controls.Add(txtLastName);
            groupBox1.Controls.Add(rbFemale);
            groupBox1.Controls.Add(pictureBox4);
            groupBox1.Controls.Add(rbMale);
            groupBox1.Controls.Add(pbGender);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(pictureBox3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtFirstName);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(llRemoveImage);
            groupBox1.Controls.Add(llSetImage);
            groupBox1.Controls.Add(pbPersonImage);
            groupBox1.Dock = DockStyle.Bottom;
            groupBox1.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(0, 92);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(826, 374);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.CustomFormat = "dd/MM/yyyy";
            dtpBirthDate.Font = new Font("Arial", 9.75F);
            dtpBirthDate.Format = DateTimePickerFormat.Custom;
            dtpBirthDate.Location = new Point(497, 53);
            dtpBirthDate.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new Size(140, 22);
            dtpBirthDate.TabIndex = 35;
            dtpBirthDate.Value = new DateTime(2025, 3, 27, 0, 0, 0, 0);
            // 
            // cbCountry
            // 
            cbCountry.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCountry.Font = new Font("Arial", 9.75F);
            cbCountry.FormattingEnabled = true;
            cbCountry.Location = new Point(497, 117);
            cbCountry.Name = "cbCountry";
            cbCountry.Size = new Size(140, 24);
            cbCountry.TabIndex = 34;
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Arial", 9.75F);
            txtPhone.Location = new Point(497, 85);
            txtPhone.MaxLength = 50;
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(140, 22);
            txtPhone.TabIndex = 33;
            txtPhone.Validating += ValidateEmptyTextBox;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources.Country_32;
            pictureBox7.Location = new Point(463, 118);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(25, 25);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 32;
            pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = Properties.Resources.Phone_32;
            pictureBox8.Location = new Point(463, 83);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(25, 25);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 31;
            pictureBox8.TabStop = false;
            // 
            // pictureBox9
            // 
            pictureBox9.Image = Properties.Resources.Calendar_32;
            pictureBox9.Location = new Point(463, 48);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(25, 25);
            pictureBox9.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox9.TabIndex = 30;
            pictureBox9.TabStop = false;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(333, 120);
            label15.Name = "label15";
            label15.Size = new Size(81, 19);
            label15.TabIndex = 29;
            label15.Text = "Country :";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(333, 88);
            label14.Name = "label14";
            label14.Size = new Size(69, 19);
            label14.TabIndex = 28;
            label14.Text = "Phone :";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(333, 56);
            label13.Name = "label13";
            label13.Size = new Size(114, 19);
            label13.TabIndex = 27;
            label13.Text = "Date of Birth :";
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Arial", 9.75F);
            txtAddress.Location = new Point(171, 165);
            txtAddress.MaxLength = 50;
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(466, 90);
            txtAddress.TabIndex = 26;
            txtAddress.Validating += ValidateEmptyTextBox;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Arial", 9.75F);
            txtEmail.Location = new Point(171, 126);
            txtEmail.MaxLength = 50;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(140, 22);
            txtEmail.TabIndex = 25;
            txtEmail.Validating += txtEmail_Validating;
            // 
            // txtNationalNum
            // 
            txtNationalNum.Font = new Font("Arial", 9.75F);
            txtNationalNum.Location = new Point(171, 52);
            txtNationalNum.MaxLength = 50;
            txtNationalNum.Name = "txtNationalNum";
            txtNationalNum.Size = new Size(140, 22);
            txtNationalNum.TabIndex = 24;
            txtNationalNum.Validating += txtNationalNum_Validating;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.Address_32;
            pictureBox6.Location = new Point(126, 160);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(25, 25);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 23;
            pictureBox6.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(12, 166);
            label7.Name = "label7";
            label7.Size = new Size(83, 19);
            label7.TabIndex = 22;
            label7.Text = "Address :";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.Email_32;
            pictureBox5.Location = new Point(126, 123);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(25, 25);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 21;
            pictureBox5.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(14, 129);
            label6.Name = "label6";
            label6.Size = new Size(61, 19);
            label6.TabIndex = 20;
            label6.Text = "Email :";
            // 
            // txtThirdName
            // 
            txtThirdName.Font = new Font("Arial", 9.75F);
            txtThirdName.Location = new Point(497, 17);
            txtThirdName.MaxLength = 50;
            txtThirdName.Name = "txtThirdName";
            txtThirdName.PlaceholderText = "Third";
            txtThirdName.Size = new Size(140, 22);
            txtThirdName.TabIndex = 18;
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Arial", 9.75F);
            txtLastName.Location = new Point(664, 15);
            txtLastName.MaxLength = 50;
            txtLastName.Name = "txtLastName";
            txtLastName.PlaceholderText = "Last";
            txtLastName.Size = new Size(140, 22);
            txtLastName.TabIndex = 17;
            txtLastName.Validating += ValidateEmptyTextBox;
            // 
            // rbFemale
            // 
            rbFemale.AutoSize = true;
            rbFemale.Location = new Point(250, 91);
            rbFemale.Name = "rbFemale";
            rbFemale.Size = new Size(73, 20);
            rbFemale.TabIndex = 16;
            rbFemale.Text = "Female";
            rbFemale.UseVisualStyleBackColor = true;
            rbFemale.Click += rbFemale_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.Woman_32;
            pictureBox4.Location = new Point(219, 88);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(25, 25);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 15;
            pictureBox4.TabStop = false;
            // 
            // rbMale
            // 
            rbMale.AutoSize = true;
            rbMale.Checked = true;
            rbMale.Location = new Point(157, 91);
            rbMale.Name = "rbMale";
            rbMale.Size = new Size(56, 20);
            rbMale.TabIndex = 14;
            rbMale.TabStop = true;
            rbMale.Text = "Male";
            rbMale.UseVisualStyleBackColor = true;
            rbMale.Click += rbMale_Click;
            // 
            // pbGender
            // 
            pbGender.Image = Properties.Resources.Man_32;
            pbGender.Location = new Point(126, 86);
            pbGender.Name = "pbGender";
            pbGender.Size = new Size(25, 25);
            pbGender.SizeMode = PictureBoxSizeMode.Zoom;
            pbGender.TabIndex = 13;
            pbGender.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 92);
            label5.Name = "label5";
            label5.Size = new Size(75, 19);
            label5.TabIndex = 12;
            label5.Text = "Gender :";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Number_32;
            pictureBox3.Location = new Point(126, 49);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(25, 25);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 11;
            pictureBox3.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 55);
            label4.Name = "label4";
            label4.Size = new Size(108, 19);
            label4.TabIndex = 10;
            label4.Text = "National No :";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Person_32;
            pictureBox2.Location = new Point(126, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(25, 25);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 18);
            label3.Name = "label3";
            label3.Size = new Size(63, 19);
            label3.TabIndex = 6;
            label3.Text = "Name :";
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Arial", 9.75F);
            txtFirstName.Location = new Point(171, 17);
            txtFirstName.MaxLength = 50;
            txtFirstName.Name = "txtFirstName";
            txtFirstName.PlaceholderText = "First";
            txtFirstName.Size = new Size(140, 22);
            txtFirstName.TabIndex = 5;
            txtFirstName.Validating += ValidateEmptyTextBox;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Image = Properties.Resources.Save_32;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(676, 316);
            button1.Name = "button1";
            button1.Size = new Size(138, 46);
            button1.TabIndex = 4;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnSave_Click;
            // 
            // llRemoveImage
            // 
            llRemoveImage.AutoSize = true;
            llRemoveImage.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            llRemoveImage.Location = new Point(699, 267);
            llRemoveImage.Name = "llRemoveImage";
            llRemoveImage.Size = new Size(72, 19);
            llRemoveImage.TabIndex = 3;
            llRemoveImage.TabStop = true;
            llRemoveImage.Text = "Remove";
            llRemoveImage.TextAlign = ContentAlignment.MiddleCenter;
            llRemoveImage.LinkClicked += llRemoveImage_LinkClicked;
            // 
            // llSetImage
            // 
            llSetImage.AutoSize = true;
            llSetImage.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            llSetImage.Location = new Point(699, 236);
            llSetImage.Name = "llSetImage";
            llSetImage.Size = new Size(84, 19);
            llSetImage.TabIndex = 2;
            llSetImage.TabStop = true;
            llSetImage.Text = "Set Image";
            llSetImage.TextAlign = ContentAlignment.MiddleCenter;
            llSetImage.LinkClicked += llSetImage_LinkClicked;
            // 
            // pbPersonImage
            // 
            pbPersonImage.Image = Properties.Resources.Male_512;
            pbPersonImage.Location = new Point(664, 83);
            pbPersonImage.Name = "pbPersonImage";
            pbPersonImage.Size = new Size(150, 150);
            pbPersonImage.SizeMode = PictureBoxSizeMode.Zoom;
            pbPersonImage.TabIndex = 1;
            pbPersonImage.TabStop = false;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmAddUpdatePerson
            // 
            AutoScaleDimensions = new SizeF(10F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(826, 466);
            Controls.Add(groupBox1);
            Controls.Add(lblPersonId);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(lblTitle);
            Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4);
            Name = "frmAddUpdatePerson";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add / Edit Person Info.";
            Load += frmAddUpdatePerson_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbGender).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbPersonImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label label2;
        private PictureBox pictureBox1;
        private Label lblPersonId;
        private GroupBox groupBox1;
        private PictureBox pbPersonImage;
        private LinkLabel llRemoveImage;
        private LinkLabel llSetImage;
        private Button button1;
        private TextBox txtFirstName;
        private Label label3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label4;
        private Label label5;
        private RadioButton rbMale;
        private PictureBox pbGender;
        private TextBox txtSecondName;
        private TextBox txtThirdName;
        private TextBox txtLastName;
        private RadioButton rbFemale;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private Label label6;
        private TextBox txtAddress;
        private TextBox txtEmail;
        private TextBox txtNationalNum;
        private PictureBox pictureBox6;
        private Label label7;
        private ComboBox cbCountry;
        private TextBox txtPhone;
        private PictureBox pictureBox7;
        private PictureBox pictureBox8;
        private PictureBox pictureBox9;
        private Label label15;
        private Label label14;
        private Label label13;
        private DateTimePicker dtpBirthDate;
        private ErrorProvider errorProvider1;
        private OpenFileDialog openFileDialog1;
    }
}