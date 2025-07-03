namespace DVLD_UI.user.Controls
{
    partial class ctrlUserCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ctrlPersonCard1 = new People.Controls.ctrlPersonCard();
            groupBox1 = new GroupBox();
            lblUserId = new Label();
            label6 = new Label();
            lblUserName = new Label();
            label2 = new Label();
            lblIsActive = new Label();
            label4 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // ctrlPersonCard1
            // 
            ctrlPersonCard1.BackColor = Color.White;
            ctrlPersonCard1.Dock = DockStyle.Top;
            ctrlPersonCard1.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ctrlPersonCard1.Location = new Point(0, 0);
            ctrlPersonCard1.Name = "ctrlPersonCard1";
            ctrlPersonCard1.Size = new Size(773, 337);
            ctrlPersonCard1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblIsActive);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(lblUserName);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(lblUserId);
            groupBox1.Controls.Add(label6);
            groupBox1.Dock = DockStyle.Bottom;
            groupBox1.Location = new Point(0, 342);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(773, 100);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Login Information";
            // 
            // lblUserId
            // 
            lblUserId.AutoSize = true;
            lblUserId.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUserId.Location = new Point(224, 37);
            lblUserId.Name = "lblUserId";
            lblUserId.Size = new Size(63, 18);
            lblUserId.TabIndex = 20;
            lblUserId.Text = "{?????}";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(145, 35);
            label6.Name = "label6";
            label6.Size = new Size(73, 19);
            label6.TabIndex = 18;
            label6.Text = "user Id :";
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUserName.Location = new Point(406, 37);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(63, 18);
            lblUserName.TabIndex = 23;
            lblUserName.Text = "{?????}";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(299, 35);
            label2.Name = "label2";
            label2.Size = new Size(101, 19);
            label2.TabIndex = 21;
            label2.Text = "Use Name  :";
            // 
            // lblIsActive
            // 
            lblIsActive.AutoSize = true;
            lblIsActive.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblIsActive.Location = new Point(565, 36);
            lblIsActive.Name = "lblIsActive";
            lblIsActive.Size = new Size(63, 18);
            lblIsActive.TabIndex = 26;
            lblIsActive.Text = "{?????}";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(476, 36);
            label4.Name = "label4";
            label4.Size = new Size(83, 19);
            label4.TabIndex = 24;
            label4.Text = "IsActive  :";
            // 
            // ctrlUserCard
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(groupBox1);
            Controls.Add(ctrlPersonCard1);
            Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "ctrlUserCard";
            Size = new Size(773, 442);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private People.Controls.ctrlPersonCard ctrlPersonCard1;
        private GroupBox groupBox1;
        private Label lblIsActive;
        private Label label4;
        private Label lblUserName;
        private Label label2;
        private Label lblUserId;
        private Label label6;
    }
}
