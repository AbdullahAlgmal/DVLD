using DVLD_Buisness;

namespace DVLD.Tests
{
    partial class frmTakeTest
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
            label10 = new Label();
            label8 = new Label();
            rbPass = new RadioButton();
            rbFail = new RadioButton();
            txtNotes = new TextBox();
            btnSave = new Button();
            pictureBox7 = new PictureBox();
            pictureBox4 = new PictureBox();
            lblUserMessage = new Label();
            ctrlSecheduledTest1 = new ctrlSecheduledTest();
            ((ISupportInitialize)pictureBox7).BeginInit();
            ((ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(65, 633);
            label10.Margin = new Padding(9, 0, 9, 0);
            label10.Name = "label10";
            label10.Size = new Size(61, 20);
            label10.TabIndex = 191;
            label10.Text = "Notes:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(60, 597);
            label8.Margin = new Padding(9, 0, 9, 0);
            label8.Name = "label8";
            label8.Size = new Size(66, 20);
            label8.TabIndex = 188;
            label8.Text = "Result:";
            // 
            // rbPass
            // 
            rbPass.AutoSize = true;
            rbPass.Checked = true;
            rbPass.Location = new Point(179, 599);
            rbPass.Name = "rbPass";
            rbPass.Size = new Size(62, 24);
            rbPass.TabIndex = 194;
            rbPass.TabStop = true;
            rbPass.Text = "Pass";
            rbPass.UseVisualStyleBackColor = true;
            // 
            // rbFail
            // 
            rbFail.AutoSize = true;
            rbFail.Location = new Point(247, 599);
            rbFail.Name = "rbFail";
            rbFail.Size = new Size(52, 24);
            rbFail.TabIndex = 195;
            rbFail.Text = "Fail";
            rbFail.UseVisualStyleBackColor = true;
            // 
            // txtNotes
            // 
            txtNotes.Location = new Point(179, 633);
            txtNotes.Multiline = true;
            txtNotes.Name = "txtNotes";
            txtNotes.Size = new Size(408, 91);
            txtNotes.TabIndex = 196;
            // 
            // btnSave
            // 
            btnSave.DialogResult = DialogResult.Cancel;
            btnSave.FlatStyle = FlatStyle.Popup;
            btnSave.Image = DVLD_UI.Properties.Resources.Save_32;
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(450, 737);
            btnSave.Margin = new Padding(6, 8, 6, 8);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(137, 36);
            btnSave.TabIndex = 197;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = DVLD_UI.Properties.Resources.Notes_32;
            pictureBox7.Location = new Point(131, 633);
            pictureBox7.Margin = new Padding(4, 5, 4, 5);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(31, 26);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 193;
            pictureBox7.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = DVLD_UI.Properties.Resources.Number_32;
            pictureBox4.Location = new Point(131, 597);
            pictureBox4.Margin = new Padding(4, 5, 4, 5);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(31, 26);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 190;
            pictureBox4.TabStop = false;
            // 
            // lblUserMessage
            // 
            lblUserMessage.AutoSize = true;
            lblUserMessage.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUserMessage.ForeColor = Color.Red;
            lblUserMessage.Location = new Point(308, 601);
            lblUserMessage.Margin = new Padding(6, 0, 6, 0);
            lblUserMessage.Name = "lblUserMessage";
            lblUserMessage.Size = new Size(255, 20);
            lblUserMessage.TabIndex = 199;
            lblUserMessage.Text = "You cannot change the results";
            lblUserMessage.TextAlign = ContentAlignment.MiddleCenter;
            lblUserMessage.Visible = false;
            // 
            // ctrlSecheduledTest1
            // 
            ctrlSecheduledTest1.BackColor = Color.White;
            ctrlSecheduledTest1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ctrlSecheduledTest1.Location = new Point(13, 14);
            ctrlSecheduledTest1.Margin = new Padding(4, 5, 4, 5);
            ctrlSecheduledTest1.Name = "ctrlSecheduledTest1";
            ctrlSecheduledTest1.Size = new Size(588, 582);
            ctrlSecheduledTest1.TabIndex = 0;
            ctrlSecheduledTest1.TestTypeID = TestType.enTestType.VisionTest;
            // 
            // frmTakeTest
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            BackColor = Color.White;
            ClientSize = new Size(603, 784);
            Controls.Add(lblUserMessage);
            Controls.Add(btnSave);
            Controls.Add(txtNotes);
            Controls.Add(rbFail);
            Controls.Add(rbPass);
            Controls.Add(pictureBox7);
            Controls.Add(label10);
            Controls.Add(pictureBox4);
            Controls.Add(label8);
            Controls.Add(ctrlSecheduledTest1);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmTakeTest";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Take Test";
            Load += frmTakeTest_Load;
            ((ISupportInitialize)pictureBox7).EndInit();
            ((ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ctrlSecheduledTest ctrlSecheduledTest1;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton rbPass;
        private System.Windows.Forms.RadioButton rbFail;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblUserMessage;
    }
}