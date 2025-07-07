namespace DVLD_UI.People
{
    partial class frmListPeople
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
            components = new Container();
            dgvPeople = new DataGridView();
            cms = new ContextMenuStrip(components);
            showToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            addNewToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            sendEmailToolStripMenuItem = new ToolStripMenuItem();
            phoneCallToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            label2 = new Label();
            lblRecordsCount = new Label();
            cbFilterBy = new ComboBox();
            txtFilterValue = new TextBox();
            pictureBox1 = new PictureBox();
            lblTitle = new Label();
            ((ISupportInitialize)dgvPeople).BeginInit();
            cms.SuspendLayout();
            ((ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgvPeople
            // 
            dgvPeople.AllowUserToAddRows = false;
            dgvPeople.AllowUserToDeleteRows = false;
            dgvPeople.AllowUserToResizeRows = false;
            dgvPeople.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvPeople.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvPeople.BackgroundColor = Color.White;
            dgvPeople.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPeople.ContextMenuStrip = cms;
            dgvPeople.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvPeople.GridColor = SystemColors.ControlDark;
            dgvPeople.Location = new Point(11, 274);
            dgvPeople.Margin = new Padding(2);
            dgvPeople.MultiSelect = false;
            dgvPeople.Name = "dgvPeople";
            dgvPeople.ReadOnly = true;
            dgvPeople.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPeople.Size = new Size(966, 342);
            dgvPeople.TabIndex = 0;
            // 
            // cms
            // 
            cms.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cms.Items.AddRange(new ToolStripItem[] { showToolStripMenuItem, toolStripSeparator1, addNewToolStripMenuItem, editToolStripMenuItem, toolStripMenuItem2, toolStripSeparator2, sendEmailToolStripMenuItem, phoneCallToolStripMenuItem });
            cms.Name = "cms";
            cms.Size = new Size(167, 244);
            // 
            // showToolStripMenuItem
            // 
            showToolStripMenuItem.Image = Properties.Resources.PersonDetails_321;
            showToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            showToolStripMenuItem.Name = "showToolStripMenuItem";
            showToolStripMenuItem.Size = new Size(166, 38);
            showToolStripMenuItem.Text = "&Show Details";
            showToolStripMenuItem.Click += showToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(163, 6);
            // 
            // addNewToolStripMenuItem
            // 
            addNewToolStripMenuItem.Image = Properties.Resources.AddPerson_32;
            addNewToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            addNewToolStripMenuItem.Name = "addNewToolStripMenuItem";
            addNewToolStripMenuItem.Size = new Size(166, 38);
            addNewToolStripMenuItem.Text = "Add &New";
            addNewToolStripMenuItem.Click += addNewToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Image = Properties.Resources.edit_32;
            editToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(166, 38);
            editToolStripMenuItem.Text = "&Edit";
            editToolStripMenuItem.Click += editToolStripMenuItem_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Image = Properties.Resources.Delete_32;
            toolStripMenuItem2.ImageScaling = ToolStripItemImageScaling.None;
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(166, 38);
            toolStripMenuItem2.Text = "&Delete";
            toolStripMenuItem2.Click += toolStripMenuItem2_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(163, 6);
            // 
            // sendEmailToolStripMenuItem
            // 
            sendEmailToolStripMenuItem.Image = Properties.Resources.send_email_32;
            sendEmailToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            sendEmailToolStripMenuItem.Name = "sendEmailToolStripMenuItem";
            sendEmailToolStripMenuItem.Size = new Size(166, 38);
            sendEmailToolStripMenuItem.Text = "Send E&mail";
            // 
            // phoneCallToolStripMenuItem
            // 
            phoneCallToolStripMenuItem.Image = Properties.Resources.call_32;
            phoneCallToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            phoneCallToolStripMenuItem.Name = "phoneCallToolStripMenuItem";
            phoneCallToolStripMenuItem.Size = new Size(166, 38);
            phoneCallToolStripMenuItem.Text = "Phone &Call";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.Location = new Point(11, 618);
            label1.Name = "label1";
            label1.Size = new Size(100, 39);
            label1.TabIndex = 1;
            label1.Text = "# Records:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Location = new Point(12, 221);
            label2.Name = "label2";
            label2.Size = new Size(100, 39);
            label2.TabIndex = 2;
            label2.Text = "Filter By:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRecordsCount
            // 
            lblRecordsCount.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblRecordsCount.Location = new Point(117, 618);
            lblRecordsCount.Name = "lblRecordsCount";
            lblRecordsCount.Size = new Size(100, 39);
            lblRecordsCount.TabIndex = 3;
            lblRecordsCount.Text = "??";
            lblRecordsCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cbFilterBy
            // 
            cbFilterBy.FormattingEnabled = true;
            cbFilterBy.Items.AddRange(new object[] { "None", "Person ID", "National No.", "First Name", "Second Name", "Third Name", "Last Name", "Nationality", "Gendor", "Phone", "Email" });
            cbFilterBy.Location = new Point(117, 228);
            cbFilterBy.Name = "cbFilterBy";
            cbFilterBy.Size = new Size(144, 27);
            cbFilterBy.TabIndex = 4;
            cbFilterBy.SelectedIndexChanged += cbFilterBy_SelectedIndexChanged;
            // 
            // txtFilterValue
            // 
            txtFilterValue.Location = new Point(267, 228);
            txtFilterValue.Name = "txtFilterValue";
            txtFilterValue.Size = new Size(143, 26);
            txtFilterValue.TabIndex = 5;
            txtFilterValue.TextChanged += txtFilterValue_TextChanged;
            txtFilterValue.KeyPress += txtFilterValue_KeyPress;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top;
            pictureBox1.Image = Properties.Resources.People_400;
            pictureBox1.Location = new Point(381, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(265, 141);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.Top;
            lblTitle.ForeColor = Color.IndianRed;
            lblTitle.Location = new Point(381, 168);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(265, 48);
            lblTitle.TabIndex = 7;
            lblTitle.Text = "Manage People";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmListPeople
            // 
            AutoScaleDimensions = new SizeF(10F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(988, 676);
            Controls.Add(lblTitle);
            Controls.Add(pictureBox1);
            Controls.Add(txtFilterValue);
            Controls.Add(cbFilterBy);
            Controls.Add(lblRecordsCount);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvPeople);
            Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(5, 4, 5, 4);
            Name = "frmListPeople";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Manage People";
            Load += frmListPeople_Load;
            ((ISupportInitialize)dgvPeople).EndInit();
            cms.ResumeLayout(false);
            ((ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvPeople;
        private Label label1;
        private Label label2;
        private Label lblRecordsCount;
        private ComboBox cbFilterBy;
        private TextBox txtFilterValue;
        private PictureBox pictureBox1;
        private Label lblTitle;
        private ContextMenuStrip cms;
        private ToolStripMenuItem showToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem addNewToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem sendEmailToolStripMenuItem;
        private ToolStripMenuItem phoneCallToolStripMenuItem;
    }
}