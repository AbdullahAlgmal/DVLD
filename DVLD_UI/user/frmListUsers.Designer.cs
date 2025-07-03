namespace DVLD_UI.user
{
    partial class frmListUsers
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
            lblRecordsCount = new Label();
            label2 = new Label();
            label1 = new Label();
            dgvUsers = new DataGridView();
            cms = new ContextMenuStrip(components);
            showToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            addNewToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            sendEmailToolStripMenuItem = new ToolStripMenuItem();
            phoneCallToolStripMenuItem = new ToolStripMenuItem();
            lblTitle = new Label();
            pictureBox1 = new PictureBox();
            txtFilterValue = new TextBox();
            cbFilterBy = new ComboBox();
            cbIsActive = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            cms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblRecordsCount
            // 
            lblRecordsCount.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblRecordsCount.Location = new Point(108, 521);
            lblRecordsCount.Name = "lblRecordsCount";
            lblRecordsCount.Size = new Size(100, 39);
            lblRecordsCount.TabIndex = 7;
            lblRecordsCount.Text = "??";
            lblRecordsCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Location = new Point(2, 233);
            label2.Name = "label2";
            label2.Size = new Size(100, 39);
            label2.TabIndex = 6;
            label2.Text = "Filter By:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.Location = new Point(2, 521);
            label1.Name = "label1";
            label1.Size = new Size(100, 39);
            label1.TabIndex = 5;
            label1.Text = "# Records:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvUsers
            // 
            dgvUsers.AllowUserToAddRows = false;
            dgvUsers.AllowUserToDeleteRows = false;
            dgvUsers.AllowUserToResizeRows = false;
            dgvUsers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvUsers.BackgroundColor = Color.White;
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.ContextMenuStrip = cms;
            dgvUsers.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvUsers.GridColor = SystemColors.ControlDark;
            dgvUsers.Location = new Point(2, 282);
            dgvUsers.Margin = new Padding(2);
            dgvUsers.MultiSelect = false;
            dgvUsers.Name = "dgvUsers";
            dgvUsers.ReadOnly = true;
            dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsers.Size = new Size(913, 237);
            dgvUsers.TabIndex = 4;
            dgvUsers.CellContentDoubleClick += dgvUsers_CellContentDoubleClick;
            // 
            // cms
            // 
            cms.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cms.Items.AddRange(new ToolStripItem[] { showToolStripMenuItem, toolStripSeparator1, addNewToolStripMenuItem, editToolStripMenuItem, toolStripMenuItem2, toolStripMenuItem1, toolStripSeparator2, sendEmailToolStripMenuItem, phoneCallToolStripMenuItem });
            cms.Name = "cms";
            cms.Size = new Size(196, 282);
            // 
            // showToolStripMenuItem
            // 
            showToolStripMenuItem.Image = Properties.Resources.PersonDetails_321;
            showToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            showToolStripMenuItem.Name = "showToolStripMenuItem";
            showToolStripMenuItem.Size = new Size(195, 38);
            showToolStripMenuItem.Text = "&Show Details";
            showToolStripMenuItem.Click += showDetailsToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(192, 6);
            // 
            // addNewToolStripMenuItem
            // 
            addNewToolStripMenuItem.Image = Properties.Resources.AddPerson_32;
            addNewToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            addNewToolStripMenuItem.Name = "addNewToolStripMenuItem";
            addNewToolStripMenuItem.Size = new Size(195, 38);
            addNewToolStripMenuItem.Text = "Add &New";
            addNewToolStripMenuItem.Click += toolStripMenuItem1_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Image = Properties.Resources.edit_32;
            editToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(195, 38);
            editToolStripMenuItem.Text = "&Edit";
            editToolStripMenuItem.Click += editToolStripMenuItem_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Image = Properties.Resources.Delete_32;
            toolStripMenuItem2.ImageScaling = ToolStripItemImageScaling.None;
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(195, 38);
            toolStripMenuItem2.Text = "&Delete";
            toolStripMenuItem2.Click += deleteToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Image = Properties.Resources.Password_32;
            toolStripMenuItem1.ImageScaling = ToolStripItemImageScaling.None;
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(195, 38);
            toolStripMenuItem1.Text = "Change Password";
            toolStripMenuItem1.Click += ChangePasswordtoolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(192, 6);
            // 
            // sendEmailToolStripMenuItem
            // 
            sendEmailToolStripMenuItem.Image = Properties.Resources.send_email_32;
            sendEmailToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            sendEmailToolStripMenuItem.Name = "sendEmailToolStripMenuItem";
            sendEmailToolStripMenuItem.Size = new Size(195, 38);
            sendEmailToolStripMenuItem.Text = "Send E&mail";
            // 
            // phoneCallToolStripMenuItem
            // 
            phoneCallToolStripMenuItem.Image = Properties.Resources.call_32;
            phoneCallToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            phoneCallToolStripMenuItem.Name = "phoneCallToolStripMenuItem";
            phoneCallToolStripMenuItem.Size = new Size(195, 38);
            phoneCallToolStripMenuItem.Text = "Phone &Call";
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.Top;
            lblTitle.ForeColor = Color.IndianRed;
            lblTitle.Location = new Point(331, 156);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(265, 48);
            lblTitle.TabIndex = 11;
            lblTitle.Text = "Manage Users";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top;
            pictureBox1.Image = Properties.Resources.Users_2_400;
            pictureBox1.Location = new Point(331, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(265, 141);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // txtFilterValue
            // 
            txtFilterValue.Location = new Point(258, 240);
            txtFilterValue.Name = "txtFilterValue";
            txtFilterValue.Size = new Size(143, 26);
            txtFilterValue.TabIndex = 9;
            txtFilterValue.Visible = false;
            txtFilterValue.TextChanged += txtFilterValue_TextChanged;
            txtFilterValue.KeyPress += txtFilterValue_KeyPress;
            // 
            // cbFilterBy
            // 
            cbFilterBy.FormattingEnabled = true;
            cbFilterBy.Items.AddRange(new object[] { "None", "User ID", "UserName", "Person ID", "Full Name", "Is Active" });
            cbFilterBy.Location = new Point(108, 240);
            cbFilterBy.Name = "cbFilterBy";
            cbFilterBy.Size = new Size(144, 27);
            cbFilterBy.TabIndex = 8;
            cbFilterBy.SelectedIndexChanged += cbFilterBy_SelectedIndexChanged;
            // 
            // cbIsActive
            // 
            cbIsActive.FormattingEnabled = true;
            cbIsActive.Items.AddRange(new object[] { "All", "Yes", "No" });
            cbIsActive.Location = new Point(258, 239);
            cbIsActive.Name = "cbIsActive";
            cbIsActive.Size = new Size(106, 27);
            cbIsActive.TabIndex = 12;
            cbIsActive.Visible = false;
            cbIsActive.SelectedIndexChanged += cbIsActive_SelectedIndexChanged;
            // 
            // frmListUsers
            // 
            AutoScaleDimensions = new SizeF(10F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(926, 569);
            Controls.Add(cbIsActive);
            Controls.Add(lblTitle);
            Controls.Add(pictureBox1);
            Controls.Add(txtFilterValue);
            Controls.Add(cbFilterBy);
            Controls.Add(lblRecordsCount);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvUsers);
            Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4);
            Name = "frmListUsers";
            Text = "List Users";
            Load += frmListUsers_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            cms.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRecordsCount;
        private Label label2;
        private Label label1;
        private DataGridView dgvUsers;
        private Label lblTitle;
        private PictureBox pictureBox1;
        private TextBox txtFilterValue;
        private ComboBox cbFilterBy;
        private ComboBox cbIsActive;
        private ContextMenuStrip cms;
        private ToolStripMenuItem showToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem addNewToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem sendEmailToolStripMenuItem;
        private ToolStripMenuItem phoneCallToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
    }
}