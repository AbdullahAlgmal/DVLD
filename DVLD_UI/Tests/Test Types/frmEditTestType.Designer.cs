namespace DVLD_UI.Tests.Test_Types
{
    partial class frmEditTestType
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
            btSave = new Button();
            lblTestTypeId = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            txtFees = new TextBox();
            txtTitle = new TextBox();
            lblTitle = new Label();
            txtDescription = new TextBox();
            errorProvider1 = new ErrorProvider(components);
            ((ISupportInitialize)pictureBox1).BeginInit();
            ((ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // btSave
            // 
            btSave.FlatStyle = FlatStyle.Flat;
            btSave.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btSave.Image = Properties.Resources.Save_32;
            btSave.ImageAlign = ContentAlignment.MiddleLeft;
            btSave.Location = new Point(215, 289);
            btSave.Name = "btSave";
            btSave.Size = new Size(138, 46);
            btSave.TabIndex = 36;
            btSave.Text = "Save";
            btSave.UseVisualStyleBackColor = true;
            btSave.Click += btnSave_Click;
            // 
            // lblTestTypeId
            // 
            lblTestTypeId.AutoSize = true;
            lblTestTypeId.Location = new Point(307, 87);
            lblTestTypeId.Name = "lblTestTypeId";
            lblTestTypeId.Size = new Size(26, 15);
            lblTestTypeId.TabIndex = 35;
            lblTestTypeId.Text = "N/A";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Number_32;
            pictureBox1.Location = new Point(276, 81);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(25, 25);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 34;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(235, 87);
            label2.Name = "label2";
            label2.Size = new Size(24, 15);
            label2.TabIndex = 33;
            label2.Text = "ID :";
            // 
            // txtFees
            // 
            txtFees.Font = new Font("Arial", 9.75F);
            txtFees.Location = new Point(119, 255);
            txtFees.MaxLength = 50;
            txtFees.Name = "txtFees";
            txtFees.PlaceholderText = "Fees";
            txtFees.Size = new Size(331, 22);
            txtFees.TabIndex = 32;
            txtFees.Validating += txtFees_Validating;
            // 
            // txtTitle
            // 
            txtTitle.Font = new Font("Arial", 9.75F);
            txtTitle.Location = new Point(120, 124);
            txtTitle.MaxLength = 50;
            txtTitle.Name = "txtTitle";
            txtTitle.PlaceholderText = "Title";
            txtTitle.Size = new Size(330, 22);
            txtTitle.TabIndex = 31;
            txtTitle.Validating += txtTitle_Validating;
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Top;
            lblTitle.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Red;
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(569, 55);
            lblTitle.TabIndex = 30;
            lblTitle.Text = "Update Application Type";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtDescription
            // 
            txtDescription.Font = new Font("Arial", 9.75F);
            txtDescription.Location = new Point(120, 152);
            txtDescription.MaxLength = 500;
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.PlaceholderText = "Description";
            txtDescription.Size = new Size(330, 97);
            txtDescription.TabIndex = 37;
            txtDescription.Validating += txtDescription_Validating;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmEditTestType
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(569, 369);
            Controls.Add(txtDescription);
            Controls.Add(btSave);
            Controls.Add(lblTestTypeId);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(txtFees);
            Controls.Add(txtTitle);
            Controls.Add(lblTitle);
            Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmEditTestType";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Edit Test Type";
            Load += frmEditTestType_Load;
            ((ISupportInitialize)pictureBox1).EndInit();
            ((ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btSave;
        private Label lblTestTypeId;
        private PictureBox pictureBox1;
        private Label label2;
        private TextBox txtFees;
        private TextBox txtTitle;
        private Label lblTitle;
        private TextBox txtDescription;
        private ErrorProvider errorProvider1;
    }
}