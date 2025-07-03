namespace DVLD_UI
{
    partial class frmLogin
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
            txtPassword = new TextBox();
            txtUserName = new TextBox();
            lblTitle = new Label();
            chkRememberMe = new CheckBox();
            btLogin = new Button();
            SuspendLayout();
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Arial", 9.75F);
            txtPassword.Location = new Point(119, 105);
            txtPassword.MaxLength = 50;
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new Size(140, 22);
            txtPassword.TabIndex = 22;
            // 
            // txtUserName
            // 
            txtUserName.Font = new Font("Arial", 9.75F);
            txtUserName.Location = new Point(119, 65);
            txtUserName.MaxLength = 50;
            txtUserName.Name = "txtUserName";
            txtUserName.PlaceholderText = "User Name";
            txtUserName.Size = new Size(140, 22);
            txtUserName.TabIndex = 21;
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Top;
            lblTitle.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Red;
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(379, 55);
            lblTitle.TabIndex = 20;
            lblTitle.Text = "Login to your account";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // chkRememberMe
            // 
            chkRememberMe.AutoSize = true;
            chkRememberMe.Checked = true;
            chkRememberMe.CheckState = CheckState.Checked;
            chkRememberMe.Location = new Point(119, 143);
            chkRememberMe.Name = "chkRememberMe";
            chkRememberMe.Size = new Size(141, 23);
            chkRememberMe.TabIndex = 25;
            chkRememberMe.Text = "Remember Me.";
            chkRememberMe.UseVisualStyleBackColor = true;
            // 
            // btLogin
            // 
            btLogin.FlatStyle = FlatStyle.Flat;
            btLogin.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btLogin.Image = Properties.Resources.sign_in_32;
            btLogin.ImageAlign = ContentAlignment.MiddleLeft;
            btLogin.Location = new Point(119, 172);
            btLogin.Name = "btLogin";
            btLogin.Size = new Size(138, 46);
            btLogin.TabIndex = 26;
            btLogin.Text = "Login";
            btLogin.UseVisualStyleBackColor = true;
            btLogin.Click += btLogin_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(379, 236);
            Controls.Add(btLogin);
            Controls.Add(chkRememberMe);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Controls.Add(lblTitle);
            Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4);
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += frmLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUserName;
        private Label lblTitle;
        private CheckBox chkRememberMe;
        private Button btLogin;
        private TextBox txtPassword;
    }
}