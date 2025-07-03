namespace DVLD_UI.user
{
    partial class frmAddUpdateUser
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
            txtConfirmPassword = new TextBox();
            lblTitle = new Label();
            tcUserInfo = new TabControl();
            tpPersonInfo = new TabPage();
            btNext = new Button();
            ctrlPersonCardWithFilter1 = new People.Controls.ctrlPersonCardWithFilter();
            tpLoginInfo = new TabPage();
            chkIsActive = new CheckBox();
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            lblUserId = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            btSave = new Button();
            errorProvider1 = new ErrorProvider(components);
            tcUserInfo.SuspendLayout();
            tpPersonInfo.SuspendLayout();
            tpLoginInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Font = new Font("Arial", 9.75F);
            txtConfirmPassword.Location = new Point(335, 222);
            txtConfirmPassword.MaxLength = 50;
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PlaceholderText = "Confirm Password";
            txtConfirmPassword.Size = new Size(140, 22);
            txtConfirmPassword.TabIndex = 22;
            txtConfirmPassword.Validating += txtConfirmPassword_Validating;
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Top;
            lblTitle.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Red;
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(790, 55);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Add New User";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tcUserInfo
            // 
            tcUserInfo.Controls.Add(tpPersonInfo);
            tcUserInfo.Controls.Add(tpLoginInfo);
            tcUserInfo.Dock = DockStyle.Bottom;
            tcUserInfo.Location = new Point(0, 78);
            tcUserInfo.Name = "tcUserInfo";
            tcUserInfo.SelectedIndex = 0;
            tcUserInfo.Size = new Size(790, 520);
            tcUserInfo.TabIndex = 2;
            // 
            // tpPersonInfo
            // 
            tpPersonInfo.Controls.Add(btNext);
            tpPersonInfo.Controls.Add(ctrlPersonCardWithFilter1);
            tpPersonInfo.Location = new Point(4, 28);
            tpPersonInfo.Name = "tpPersonInfo";
            tpPersonInfo.Padding = new Padding(3);
            tpPersonInfo.Size = new Size(782, 488);
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
            btNext.Location = new Point(638, 434);
            btNext.Name = "btNext";
            btNext.Size = new Size(138, 46);
            btNext.TabIndex = 5;
            btNext.Text = "Next";
            btNext.UseVisualStyleBackColor = true;
            btNext.Click += btnPersonInfoNext_Click;
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
            ctrlPersonCardWithFilter1.Size = new Size(776, 425);
            ctrlPersonCardWithFilter1.TabIndex = 0;
            // 
            // tpLoginInfo
            // 
            tpLoginInfo.Controls.Add(chkIsActive);
            tpLoginInfo.Controls.Add(txtConfirmPassword);
            tpLoginInfo.Controls.Add(txtUserName);
            tpLoginInfo.Controls.Add(txtPassword);
            tpLoginInfo.Controls.Add(lblUserId);
            tpLoginInfo.Controls.Add(pictureBox1);
            tpLoginInfo.Controls.Add(label2);
            tpLoginInfo.Controls.Add(btSave);
            tpLoginInfo.Location = new Point(4, 28);
            tpLoginInfo.Name = "tpLoginInfo";
            tpLoginInfo.Padding = new Padding(3);
            tpLoginInfo.Size = new Size(782, 488);
            tpLoginInfo.TabIndex = 1;
            tpLoginInfo.Text = "Login Info";
            tpLoginInfo.UseVisualStyleBackColor = true;
            // 
            // chkIsActive
            // 
            chkIsActive.AutoSize = true;
            chkIsActive.Checked = true;
            chkIsActive.CheckState = CheckState.Checked;
            chkIsActive.Location = new Point(334, 270);
            chkIsActive.Name = "chkIsActive";
            chkIsActive.Size = new Size(91, 23);
            chkIsActive.TabIndex = 24;
            chkIsActive.Text = "Is Active";
            chkIsActive.UseVisualStyleBackColor = true;
            // 
            // txtUserName
            // 
            txtUserName.Font = new Font("Arial", 9.75F);
            txtUserName.Location = new Point(335, 123);
            txtUserName.MaxLength = 50;
            txtUserName.Name = "txtUserName";
            txtUserName.PlaceholderText = "User Name";
            txtUserName.Size = new Size(140, 22);
            txtUserName.TabIndex = 21;
            txtUserName.Validating += txtUserName_Validating;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Arial", 9.75F);
            txtPassword.Location = new Point(335, 172);
            txtPassword.MaxLength = 50;
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new Size(140, 22);
            txtPassword.TabIndex = 20;
            txtPassword.Validating += txtPassword_Validating;
            // 
            // lblUserId
            // 
            lblUserId.AutoSize = true;
            lblUserId.Location = new Point(439, 78);
            lblUserId.Name = "lblUserId";
            lblUserId.Size = new Size(36, 19);
            lblUserId.TabIndex = 8;
            lblUserId.Text = "N/A";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Number_32;
            pictureBox1.Location = new Point(408, 72);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(25, 25);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(308, 78);
            label2.Name = "label2";
            label2.Size = new Size(75, 19);
            label2.TabIndex = 6;
            label2.Text = "User ID :";
            // 
            // btSave
            // 
            btSave.FlatStyle = FlatStyle.Flat;
            btSave.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btSave.Image = Properties.Resources.Save_32;
            btSave.ImageAlign = ContentAlignment.MiddleLeft;
            btSave.Location = new Point(636, 434);
            btSave.Name = "btSave";
            btSave.Size = new Size(138, 46);
            btSave.TabIndex = 5;
            btSave.Text = "Save";
            btSave.UseVisualStyleBackColor = true;
            btSave.Click += btnSave_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmAddUpdateUser
            // 
            AutoScaleDimensions = new SizeF(10F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(790, 598);
            Controls.Add(tcUserInfo);
            Controls.Add(lblTitle);
            Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4);
            Name = "frmAddUpdateUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add / Edit User Info.";
            Activated += frmAddUpdateUser_Activated;
            Load += frmAddUpdateUser_Load;
            tcUserInfo.ResumeLayout(false);
            tpPersonInfo.ResumeLayout(false);
            tpLoginInfo.ResumeLayout(false);
            tpLoginInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitle;
        private TabControl tcUserInfo;
        private TabPage tpPersonInfo;
        private People.Controls.ctrlPersonCardWithFilter ctrlPersonCardWithFilter1;
        private TabPage tpLoginInfo;
        private Button btNext;
        private Button btSave;
        private Label lblUserId;
        private PictureBox pictureBox1;
        private Label label2;
        private CheckBox chkIsActive;
        private TextBox txtUserName;
        private TextBox txtPassword;
        private TextBox txtConfirmPassword;
        private ErrorProvider errorProvider1;
    }
}