namespace DVLD_UI.user
{
    partial class frmChangePassword
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
            txtNewPassword = new TextBox();
            ctrlUserCard1 = new Controls.ctrlUserCard();
            groupBox1 = new GroupBox();
            txtConfirmPassword = new TextBox();
            txtCurrentPassword = new TextBox();
            errorProvider1 = new ErrorProvider(components);
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // txtNewPassword
            // 
            txtNewPassword.Font = new Font("Arial", 9.75F);
            txtNewPassword.Location = new Point(326, 39);
            txtNewPassword.MaxLength = 50;
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.PlaceholderText = "New Password";
            txtNewPassword.Size = new Size(140, 22);
            txtNewPassword.TabIndex = 22;
            txtNewPassword.Validating += txtNewPassword_Validating;
            // 
            // ctrlUserCard1
            // 
            ctrlUserCard1.BackColor = Color.White;
            ctrlUserCard1.Dock = DockStyle.Top;
            ctrlUserCard1.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ctrlUserCard1.Location = new Point(0, 0);
            ctrlUserCard1.Name = "ctrlUserCard1";
            ctrlUserCard1.Size = new Size(795, 442);
            ctrlUserCard1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtNewPassword);
            groupBox1.Controls.Add(txtConfirmPassword);
            groupBox1.Controls.Add(txtCurrentPassword);
            groupBox1.Dock = DockStyle.Bottom;
            groupBox1.Location = new Point(0, 454);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(795, 100);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Change Password";
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Font = new Font("Arial", 9.75F);
            txtConfirmPassword.Location = new Point(506, 39);
            txtConfirmPassword.MaxLength = 50;
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PlaceholderText = "Confirm Password";
            txtConfirmPassword.Size = new Size(140, 22);
            txtConfirmPassword.TabIndex = 21;
            txtConfirmPassword.Validating += txtConfirmPassword_Validating;
            // 
            // txtCurrentPassword
            // 
            txtCurrentPassword.Font = new Font("Arial", 9.75F);
            txtCurrentPassword.Location = new Point(148, 39);
            txtCurrentPassword.MaxLength = 50;
            txtCurrentPassword.Name = "txtCurrentPassword";
            txtCurrentPassword.PlaceholderText = "Current Password";
            txtCurrentPassword.Size = new Size(140, 22);
            txtCurrentPassword.TabIndex = 20;
            txtCurrentPassword.Validating += txtCurrentPassword_Validating;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmChangePassword
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(795, 554);
            Controls.Add(groupBox1);
            Controls.Add(ctrlUserCard1);
            Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmChangePassword";
            Text = "Change Password";
            FormClosing += frmChangePassword_FormClosing;
            Load += frmChangePassword_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Controls.ctrlUserCard ctrlUserCard1;
        private GroupBox groupBox1;
        private TextBox txtConfirmPassword;
        private TextBox txtCurrentPassword;
        private TextBox txtNewPassword;
        private ErrorProvider errorProvider1;
    }
}