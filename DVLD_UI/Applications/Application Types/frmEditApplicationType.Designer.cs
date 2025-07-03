namespace DVLD_UI.Application_Types
{
    partial class frmEditApplicationType
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
            txtFees = new TextBox();
            txtTitle = new TextBox();
            lblTitle = new Label();
            lblApplicationTypeId = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            btSave = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((ISupportInitialize)pictureBox1).BeginInit();
            ((ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // txtFees
            // 
            txtFees.Font = new Font("Arial", 9.75F);
            txtFees.Location = new Point(133, 176);
            txtFees.MaxLength = 50;
            txtFees.Name = "txtFees";
            txtFees.PlaceholderText = "Fees";
            txtFees.Size = new Size(140, 22);
            txtFees.TabIndex = 25;
            txtFees.Validating += txtFees_Validating;
            // 
            // txtTitle
            // 
            txtTitle.Font = new Font("Arial", 9.75F);
            txtTitle.Location = new Point(133, 136);
            txtTitle.MaxLength = 50;
            txtTitle.Name = "txtTitle";
            txtTitle.PlaceholderText = "Title";
            txtTitle.Size = new Size(140, 22);
            txtTitle.TabIndex = 24;
            txtTitle.Validating += txtTitle_Validating;
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Top;
            lblTitle.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Red;
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(407, 55);
            lblTitle.TabIndex = 23;
            lblTitle.Text = "Update Application Type";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblApplicationTypeId
            // 
            lblApplicationTypeId.AutoSize = true;
            lblApplicationTypeId.Location = new Point(221, 99);
            lblApplicationTypeId.Name = "lblApplicationTypeId";
            lblApplicationTypeId.Size = new Size(36, 19);
            lblApplicationTypeId.TabIndex = 28;
            lblApplicationTypeId.Text = "N/A";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Number_32;
            pictureBox1.Location = new Point(190, 93);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(25, 25);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 27;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(149, 99);
            label2.Name = "label2";
            label2.Size = new Size(35, 19);
            label2.TabIndex = 26;
            label2.Text = "ID :";
            // 
            // btSave
            // 
            btSave.FlatStyle = FlatStyle.Flat;
            btSave.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btSave.Image = Properties.Resources.Save_32;
            btSave.ImageAlign = ContentAlignment.MiddleLeft;
            btSave.Location = new Point(134, 210);
            btSave.Name = "btSave";
            btSave.Size = new Size(138, 46);
            btSave.TabIndex = 29;
            btSave.Text = "Save";
            btSave.UseVisualStyleBackColor = true;
            btSave.Click += btnSave_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmEditApplicationType
            // 
            AutoScaleDimensions = new SizeF(10F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(407, 268);
            Controls.Add(btSave);
            Controls.Add(lblApplicationTypeId);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(txtFees);
            Controls.Add(txtTitle);
            Controls.Add(lblTitle);
            Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4);
            Name = "frmEditApplicationType";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Update Application0 Type";
            Load += frmEditApplicationType_Load;
            ((ISupportInitialize)pictureBox1).EndInit();
            ((ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFees;
        private TextBox txtTitle;
        private Label lblTitle;
        private Label lblApplicationTypeId;
        private PictureBox pictureBox1;
        private Label label2;
        private Button btSave;
        private ErrorProvider errorProvider1;
    }
}