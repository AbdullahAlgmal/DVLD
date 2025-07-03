namespace DVLD_UI.Tests.Test_Types
{
    partial class frmListTestTypes
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
            lblTitle = new Label();
            pictureBox1 = new PictureBox();
            lblRecordsCount = new Label();
            label1 = new Label();
            dgvTestTypes = new DataGridView();
            cms = new ContextMenuStrip(components);
            toolStripSeparator1 = new ToolStripSeparator();
            editToolStripMenuItem = new ToolStripMenuItem();
            ((ISupportInitialize)pictureBox1).BeginInit();
            ((ISupportInitialize)dgvTestTypes).BeginInit();
            cms.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.Top;
            lblTitle.ForeColor = Color.IndianRed;
            lblTitle.Location = new Point(178, 129);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(217, 30);
            lblTitle.TabIndex = 21;
            lblTitle.Text = "Manage Test Types";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top;
            pictureBox1.Image = Properties.Resources.TestType_512;
            pictureBox1.Location = new Point(198, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(180, 114);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // lblRecordsCount
            // 
            lblRecordsCount.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblRecordsCount.Location = new Point(117, 449);
            lblRecordsCount.Name = "lblRecordsCount";
            lblRecordsCount.Size = new Size(87, 34);
            lblRecordsCount.TabIndex = 19;
            lblRecordsCount.Text = "??";
            lblRecordsCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.Location = new Point(11, 449);
            label1.Name = "label1";
            label1.Size = new Size(100, 34);
            label1.TabIndex = 18;
            label1.Text = "# Records:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvTestTypes
            // 
            dgvTestTypes.AllowUserToAddRows = false;
            dgvTestTypes.AllowUserToDeleteRows = false;
            dgvTestTypes.AllowUserToResizeRows = false;
            dgvTestTypes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvTestTypes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvTestTypes.BackgroundColor = Color.White;
            dgvTestTypes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTestTypes.ContextMenuStrip = cms;
            dgvTestTypes.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvTestTypes.GridColor = SystemColors.ControlDark;
            dgvTestTypes.Location = new Point(11, 161);
            dgvTestTypes.Margin = new Padding(2);
            dgvTestTypes.MultiSelect = false;
            dgvTestTypes.Name = "dgvTestTypes";
            dgvTestTypes.ReadOnly = true;
            dgvTestTypes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTestTypes.Size = new Size(550, 286);
            dgvTestTypes.TabIndex = 17;
            // 
            // cms
            // 
            cms.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cms.Items.AddRange(new ToolStripItem[] { toolStripSeparator1, editToolStripMenuItem });
            cms.Name = "cms";
            cms.Size = new Size(114, 48);
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(110, 6);
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Image = Properties.Resources.edit_32;
            editToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(113, 38);
            editToolStripMenuItem.Text = "&Edit";
            editToolStripMenuItem.Click += editToolStripMenuItem_Click;
            // 
            // frmListTestTypes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(572, 492);
            Controls.Add(lblTitle);
            Controls.Add(pictureBox1);
            Controls.Add(lblRecordsCount);
            Controls.Add(label1);
            Controls.Add(dgvTestTypes);
            Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmListTestTypes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "List Test Types";
            Load += frmListTestTypes_Load;
            ((ISupportInitialize)pictureBox1).EndInit();
            ((ISupportInitialize)dgvTestTypes).EndInit();
            cms.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitle;
        private PictureBox pictureBox1;
        private Label lblRecordsCount;
        private Label label1;
        private DataGridView dgvTestTypes;
        private ContextMenuStrip cms;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem editToolStripMenuItem;
    }
}