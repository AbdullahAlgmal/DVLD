namespace DVLD_UI.Drivers
{
    partial class frmListDrivers
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
            lblTitle = new Label();
            pictureBox1 = new PictureBox();
            txtFilterValue = new TextBox();
            cbFilterBy = new ComboBox();
            lblRecordsCount = new Label();
            label2 = new Label();
            label1 = new Label();
            dgvDrivers = new DataGridView();
            ((ISupportInitialize)pictureBox1).BeginInit();
            ((ISupportInitialize)dgvDrivers).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.Top;
            lblTitle.ForeColor = Color.IndianRed;
            lblTitle.Location = new Point(309, 156);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(265, 48);
            lblTitle.TabIndex = 19;
            lblTitle.Text = "Manage Drivers";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top;
            pictureBox1.Image = Properties.Resources.Driver_Main;
            pictureBox1.Location = new Point(309, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(265, 141);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // txtFilterValue
            // 
            txtFilterValue.Location = new Point(261, 222);
            txtFilterValue.Name = "txtFilterValue";
            txtFilterValue.Size = new Size(143, 26);
            txtFilterValue.TabIndex = 17;
            txtFilterValue.Visible = false;
            txtFilterValue.TextChanged += txtFilterValue_TextChanged;
            // 
            // cbFilterBy
            // 
            cbFilterBy.FormattingEnabled = true;
            cbFilterBy.Items.AddRange(new object[] { "None", "Driver ID", "Person ID", "National No.", "Full Name" });
            cbFilterBy.Location = new Point(111, 222);
            cbFilterBy.Name = "cbFilterBy";
            cbFilterBy.Size = new Size(144, 27);
            cbFilterBy.TabIndex = 16;
            cbFilterBy.SelectedIndexChanged += cbFilterBy_SelectedIndexChanged;
            // 
            // lblRecordsCount
            // 
            lblRecordsCount.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblRecordsCount.Location = new Point(108, 594);
            lblRecordsCount.Name = "lblRecordsCount";
            lblRecordsCount.Size = new Size(100, 39);
            lblRecordsCount.TabIndex = 15;
            lblRecordsCount.Text = "??";
            lblRecordsCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Location = new Point(5, 215);
            label2.Name = "label2";
            label2.Size = new Size(100, 39);
            label2.TabIndex = 14;
            label2.Text = "Filter By:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.Location = new Point(2, 594);
            label1.Name = "label1";
            label1.Size = new Size(100, 39);
            label1.TabIndex = 13;
            label1.Text = "# Records:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvDrivers
            // 
            dgvDrivers.AllowUserToAddRows = false;
            dgvDrivers.AllowUserToDeleteRows = false;
            dgvDrivers.AllowUserToResizeRows = false;
            dgvDrivers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvDrivers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvDrivers.BackgroundColor = Color.White;
            dgvDrivers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDrivers.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvDrivers.GridColor = SystemColors.ControlDark;
            dgvDrivers.Location = new Point(2, 265);
            dgvDrivers.Margin = new Padding(2);
            dgvDrivers.MultiSelect = false;
            dgvDrivers.Name = "dgvDrivers";
            dgvDrivers.ReadOnly = true;
            dgvDrivers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDrivers.Size = new Size(878, 327);
            dgvDrivers.TabIndex = 12;
            // 
            // frmListDrivers
            // 
            AutoScaleDimensions = new SizeF(10F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(882, 642);
            Controls.Add(lblTitle);
            Controls.Add(pictureBox1);
            Controls.Add(txtFilterValue);
            Controls.Add(cbFilterBy);
            Controls.Add(lblRecordsCount);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvDrivers);
            Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4);
            Name = "frmListDrivers";
            Text = "List Drivers";
            Load += frmListDrivers_Load;
            ((ISupportInitialize)pictureBox1).EndInit();
            ((ISupportInitialize)dgvDrivers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private PictureBox pictureBox1;
        private TextBox txtFilterValue;
        private ComboBox cbFilterBy;
        private Label lblRecordsCount;
        private Label label2;
        private Label label1;
        private DataGridView dgvDrivers;
    }
}