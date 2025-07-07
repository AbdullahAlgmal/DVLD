namespace DVLD.Applications.Rlease_Detained_License
{
    partial class frmListDetainedLicenses
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            btnDetainLicense = new Button();
            cbFilterBy = new ComboBox();
            txtFilterValue = new TextBox();
            label1 = new Label();
            showPersonLicenseHistoryToolStripMenuItem = new ToolStripMenuItem();
            pbPersonImage = new PictureBox();
            PesonDetailsToolStripMenuItem = new ToolStripMenuItem();
            showDetailsToolStripMenuItem = new ToolStripMenuItem();
            cmsApplications = new ContextMenuStrip(components);
            toolStripMenuItem1 = new ToolStripSeparator();
            releaseDetainedLicenseToolStripMenuItem = new ToolStripMenuItem();
            lblTotalRecords = new Label();
            label5 = new Label();
            dgvDetainedLicenses = new DataGridView();
            lblTitle = new Label();
            cbIsReleased = new ComboBox();
            btnReleaseDetainedLicense = new Button();
            ((ISupportInitialize)pbPersonImage).BeginInit();
            cmsApplications.SuspendLayout();
            ((ISupportInitialize)dgvDetainedLicenses).BeginInit();
            SuspendLayout();
            // 
            // btnDetainLicense
            // 
            btnDetainLicense.FlatStyle = FlatStyle.Flat;
            btnDetainLicense.Image = DVLD_UI.Properties.Resources.Detain_64;
            btnDetainLicense.Location = new Point(1285, 253);
            btnDetainLicense.Name = "btnDetainLicense";
            btnDetainLicense.Size = new Size(88, 75);
            btnDetainLicense.TabIndex = 154;
            btnDetainLicense.UseVisualStyleBackColor = true;
            btnDetainLicense.Click += btnDetainLicense_Click;
            // 
            // cbFilterBy
            // 
            cbFilterBy.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFilterBy.FormattingEnabled = true;
            cbFilterBy.Items.AddRange(new object[] { "None", "Detain ID", "Is Released", "National No.", "Full Name", "Release Application ID" });
            cbFilterBy.Location = new Point(85, 300);
            cbFilterBy.Name = "cbFilterBy";
            cbFilterBy.Size = new Size(150, 28);
            cbFilterBy.TabIndex = 152;
            cbFilterBy.SelectedIndexChanged += cbFilterBy_SelectedIndexChanged;
            // 
            // txtFilterValue
            // 
            txtFilterValue.BorderStyle = BorderStyle.FixedSingle;
            txtFilterValue.Location = new Point(242, 299);
            txtFilterValue.Margin = new Padding(4, 5, 4, 5);
            txtFilterValue.Name = "txtFilterValue";
            txtFilterValue.Size = new Size(198, 26);
            txtFilterValue.TabIndex = 151;
            txtFilterValue.TextChanged += txtFilterValue_TextChanged;
            txtFilterValue.KeyPress += txtFilterValue_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(9, 303);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 150;
            label1.Text = "Filter By:";
            // 
            // showPersonLicenseHistoryToolStripMenuItem
            // 
            showPersonLicenseHistoryToolStripMenuItem.Image = DVLD_UI.Properties.Resources.PersonLicenseHistory_32;
            showPersonLicenseHistoryToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            showPersonLicenseHistoryToolStripMenuItem.Name = "showPersonLicenseHistoryToolStripMenuItem";
            showPersonLicenseHistoryToolStripMenuItem.Size = new Size(241, 38);
            showPersonLicenseHistoryToolStripMenuItem.Text = "Show Person License History";
            showPersonLicenseHistoryToolStripMenuItem.Click += showPersonLicenseHistoryToolStripMenuItem_Click;
            // 
            // pbPersonImage
            // 
            pbPersonImage.BackgroundImageLayout = ImageLayout.Zoom;
            pbPersonImage.Image = DVLD_UI.Properties.Resources.Detain_512;
            pbPersonImage.InitialImage = null;
            pbPersonImage.Location = new Point(397, 14);
            pbPersonImage.Margin = new Padding(4, 5, 4, 5);
            pbPersonImage.Name = "pbPersonImage";
            pbPersonImage.Size = new Size(220, 189);
            pbPersonImage.SizeMode = PictureBoxSizeMode.Zoom;
            pbPersonImage.TabIndex = 153;
            pbPersonImage.TabStop = false;
            // 
            // PesonDetailsToolStripMenuItem
            // 
            PesonDetailsToolStripMenuItem.Image = DVLD_UI.Properties.Resources.PersonDetails_32;
            PesonDetailsToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            PesonDetailsToolStripMenuItem.Name = "PesonDetailsToolStripMenuItem";
            PesonDetailsToolStripMenuItem.Size = new Size(241, 38);
            PesonDetailsToolStripMenuItem.Text = "Show Person Details";
            PesonDetailsToolStripMenuItem.Click += PesonDetailsToolStripMenuItem_Click;
            // 
            // showDetailsToolStripMenuItem
            // 
            showDetailsToolStripMenuItem.Image = DVLD_UI.Properties.Resources.License_View_32;
            showDetailsToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
            showDetailsToolStripMenuItem.Size = new Size(241, 38);
            showDetailsToolStripMenuItem.Text = "&Show License Details";
            showDetailsToolStripMenuItem.Click += showDetailsToolStripMenuItem_Click;
            // 
            // cmsApplications
            // 
            cmsApplications.Items.AddRange(new ToolStripItem[] { PesonDetailsToolStripMenuItem, showDetailsToolStripMenuItem, showPersonLicenseHistoryToolStripMenuItem, toolStripMenuItem1, releaseDetainedLicenseToolStripMenuItem });
            cmsApplications.Name = "contextMenuStrip1";
            cmsApplications.Size = new Size(242, 162);
            cmsApplications.Opening += cmsApplications_Opening;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(238, 6);
            // 
            // releaseDetainedLicenseToolStripMenuItem
            // 
            releaseDetainedLicenseToolStripMenuItem.Image = DVLD_UI.Properties.Resources.Release_Detained_License_32;
            releaseDetainedLicenseToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            releaseDetainedLicenseToolStripMenuItem.Name = "releaseDetainedLicenseToolStripMenuItem";
            releaseDetainedLicenseToolStripMenuItem.Size = new Size(241, 38);
            releaseDetainedLicenseToolStripMenuItem.Text = "Release Detained License";
            releaseDetainedLicenseToolStripMenuItem.Click += releaseDetainedLicenseToolStripMenuItem_Click;
            // 
            // lblTotalRecords
            // 
            lblTotalRecords.AutoSize = true;
            lblTotalRecords.Location = new Point(107, 685);
            lblTotalRecords.Name = "lblTotalRecords";
            lblTotalRecords.Size = new Size(27, 20);
            lblTotalRecords.TabIndex = 158;
            lblTotalRecords.Text = "??";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(13, 685);
            label5.Name = "label5";
            label5.Size = new Size(96, 20);
            label5.TabIndex = 157;
            label5.Text = "# Records:";
            // 
            // dgvDetainedLicenses
            // 
            dgvDetainedLicenses.AllowUserToAddRows = false;
            dgvDetainedLicenses.AllowUserToDeleteRows = false;
            dgvDetainedLicenses.AllowUserToResizeRows = false;
            dgvDetainedLicenses.BackgroundColor = Color.White;
            dgvDetainedLicenses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetainedLicenses.ContextMenuStrip = cmsApplications;
            dgvDetainedLicenses.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvDetainedLicenses.Location = new Point(9, 336);
            dgvDetainedLicenses.Margin = new Padding(4, 5, 4, 5);
            dgvDetainedLicenses.MultiSelect = false;
            dgvDetainedLicenses.Name = "dgvDetainedLicenses";
            dgvDetainedLicenses.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvDetainedLicenses.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvDetainedLicenses.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDetainedLicenses.Size = new Size(997, 340);
            dgvDetainedLicenses.TabIndex = 156;
            dgvDetainedLicenses.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(192, 0, 0);
            lblTitle.Location = new Point(397, 208);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(220, 39);
            lblTitle.TabIndex = 149;
            lblTitle.Text = "List Detained Licenses";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cbIsReleased
            // 
            cbIsReleased.DropDownStyle = ComboBoxStyle.DropDownList;
            cbIsReleased.FormattingEnabled = true;
            cbIsReleased.Items.AddRange(new object[] { "All", "Yes", "No" });
            cbIsReleased.Location = new Point(241, 299);
            cbIsReleased.Name = "cbIsReleased";
            cbIsReleased.Size = new Size(121, 28);
            cbIsReleased.TabIndex = 159;
            cbIsReleased.Visible = false;
            cbIsReleased.SelectedIndexChanged += cbIsReleased_SelectedIndexChanged;
            // 
            // btnReleaseDetainedLicense
            // 
            btnReleaseDetainedLicense.FlatStyle = FlatStyle.Flat;
            btnReleaseDetainedLicense.Image = DVLD_UI.Properties.Resources.Release_Detained_License_64;
            btnReleaseDetainedLicense.Location = new Point(918, 252);
            btnReleaseDetainedLicense.Name = "btnReleaseDetainedLicense";
            btnReleaseDetainedLicense.Size = new Size(88, 75);
            btnReleaseDetainedLicense.TabIndex = 160;
            btnReleaseDetainedLicense.UseVisualStyleBackColor = true;
            btnReleaseDetainedLicense.Click += btnReleaseDetainedLicense_Click;
            // 
            // frmListDetainedLicenses
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1014, 719);
            Controls.Add(btnReleaseDetainedLicense);
            Controls.Add(cbIsReleased);
            Controls.Add(btnDetainLicense);
            Controls.Add(cbFilterBy);
            Controls.Add(txtFilterValue);
            Controls.Add(label1);
            Controls.Add(pbPersonImage);
            Controls.Add(lblTotalRecords);
            Controls.Add(label5);
            Controls.Add(dgvDetainedLicenses);
            Controls.Add(lblTitle);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmListDetainedLicenses";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "List Detained Licenses";
            Load += frmListDetainedLicenses_Load;
            ((ISupportInitialize)pbPersonImage).EndInit();
            cmsApplications.ResumeLayout(false);
            ((ISupportInitialize)dgvDetainedLicenses).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button btnDetainLicense;
        private System.Windows.Forms.ComboBox cbFilterBy;
        private System.Windows.Forms.TextBox txtFilterValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem showPersonLicenseHistoryToolStripMenuItem;
        private System.Windows.Forms.PictureBox pbPersonImage;
        private System.Windows.Forms.ToolStripMenuItem PesonDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showDetailsToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmsApplications;
        private System.Windows.Forms.Label lblTotalRecords;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvDetainedLicenses;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ComboBox cbIsReleased;
        private System.Windows.Forms.Button btnReleaseDetainedLicense;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem releaseDetainedLicenseToolStripMenuItem;
    }
}