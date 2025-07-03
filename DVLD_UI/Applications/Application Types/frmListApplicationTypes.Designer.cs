namespace DVLD_UI.Application_Types
{
    partial class frmListApplicationTypes
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
            dgvApplicationTypes = new DataGridView();
            cms = new ContextMenuStrip(components);
            toolStripSeparator1 = new ToolStripSeparator();
            editToolStripMenuItem = new ToolStripMenuItem();
            ((ISupportInitialize)pictureBox1).BeginInit();
            ((ISupportInitialize)dgvApplicationTypes).BeginInit();
            cms.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.Top;
            lblTitle.ForeColor = Color.IndianRed;
            lblTitle.Location = new Point(157, 129);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(217, 30);
            lblTitle.TabIndex = 16;
            lblTitle.Text = "Manage Application0 Types";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top;
            pictureBox1.Image = Properties.Resources.Application_Types_512;
            pictureBox1.Location = new Point(177, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(180, 114);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // lblRecordsCount
            // 
            lblRecordsCount.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblRecordsCount.Location = new Point(116, 490);
            lblRecordsCount.Name = "lblRecordsCount";
            lblRecordsCount.Size = new Size(87, 34);
            lblRecordsCount.TabIndex = 14;
            lblRecordsCount.Text = "??";
            lblRecordsCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.Location = new Point(10, 490);
            label1.Name = "label1";
            label1.Size = new Size(100, 34);
            label1.TabIndex = 13;
            label1.Text = "# Records:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvApplicationTypes
            // 
            dgvApplicationTypes.AllowUserToAddRows = false;
            dgvApplicationTypes.AllowUserToDeleteRows = false;
            dgvApplicationTypes.AllowUserToResizeRows = false;
            dgvApplicationTypes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvApplicationTypes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvApplicationTypes.BackgroundColor = Color.White;
            dgvApplicationTypes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvApplicationTypes.ContextMenuStrip = cms;
            dgvApplicationTypes.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvApplicationTypes.GridColor = SystemColors.ControlDark;
            dgvApplicationTypes.Location = new Point(10, 172);
            dgvApplicationTypes.Margin = new Padding(2);
            dgvApplicationTypes.MultiSelect = false;
            dgvApplicationTypes.Name = "dgvApplicationTypes";
            dgvApplicationTypes.ReadOnly = true;
            dgvApplicationTypes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvApplicationTypes.Size = new Size(550, 316);
            dgvApplicationTypes.TabIndex = 12;
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
            // frmListApplicationTypes
            // 
            AutoScaleDimensions = new SizeF(10F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(571, 533);
            Controls.Add(lblTitle);
            Controls.Add(pictureBox1);
            Controls.Add(lblRecordsCount);
            Controls.Add(label1);
            Controls.Add(dgvApplicationTypes);
            Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4);
            Name = "frmListApplicationTypes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "List Application Types";
            Load += frmManageApplicationTypes_Load;
            ((ISupportInitialize)pictureBox1).EndInit();
            ((ISupportInitialize)dgvApplicationTypes).EndInit();
            cms.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitle;
        private PictureBox pictureBox1;
        private Label lblRecordsCount;
        private Label label1;
        private DataGridView dgvApplicationTypes;
        private ContextMenuStrip cms;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem editToolStripMenuItem;
    }
}