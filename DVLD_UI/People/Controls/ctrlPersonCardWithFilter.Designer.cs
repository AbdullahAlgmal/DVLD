namespace DVLD_UI.People.Controls
{
    partial class ctrlPersonCardWithFilter
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
            components = new System.ComponentModel.Container();
            ctrlPersonCard1 = new ctrlPersonCard();
            gbFilter = new GroupBox();
            txtFilterValue = new TextBox();
            btAddNewPerson = new Button();
            btFind = new Button();
            cbFilterBy = new ComboBox();
            label2 = new Label();
            errorProvider1 = new ErrorProvider(components);
            gbFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // ctrlPersonCard1
            // 
            ctrlPersonCard1.BackColor = Color.White;
            ctrlPersonCard1.Dock = DockStyle.Bottom;
            ctrlPersonCard1.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ctrlPersonCard1.Location = new Point(0, 63);
            ctrlPersonCard1.Name = "ctrlPersonCard1";
            ctrlPersonCard1.Size = new Size(770, 337);
            ctrlPersonCard1.TabIndex = 0;
            // 
            // gbFilter
            // 
            gbFilter.Controls.Add(txtFilterValue);
            gbFilter.Controls.Add(btAddNewPerson);
            gbFilter.Controls.Add(btFind);
            gbFilter.Controls.Add(cbFilterBy);
            gbFilter.Controls.Add(label2);
            gbFilter.Dock = DockStyle.Top;
            gbFilter.Location = new Point(0, 0);
            gbFilter.Name = "gbFilter";
            gbFilter.Size = new Size(770, 57);
            gbFilter.TabIndex = 1;
            gbFilter.TabStop = false;
            gbFilter.Text = "Filter";
            // 
            // txtFilterValue
            // 
            txtFilterValue.Location = new Point(339, 20);
            txtFilterValue.Name = "txtFilterValue";
            txtFilterValue.Size = new Size(194, 22);
            txtFilterValue.TabIndex = 9;
            txtFilterValue.KeyPress += txtFilterValue_KeyPress;
            txtFilterValue.Validating += txtFilterValue_Validating;
            // 
            // btAddNewPerson
            // 
            btAddNewPerson.FlatStyle = FlatStyle.Flat;
            btAddNewPerson.Image = Properties.Resources.AddPerson_32;
            btAddNewPerson.Location = new Point(607, 11);
            btAddNewPerson.Name = "btAddNewPerson";
            btAddNewPerson.Size = new Size(51, 40);
            btAddNewPerson.TabIndex = 8;
            btAddNewPerson.UseVisualStyleBackColor = true;
            btAddNewPerson.Click += btnAddNewPerson_Click;
            // 
            // btFind
            // 
            btFind.FlatStyle = FlatStyle.Flat;
            btFind.Image = Properties.Resources.SearchPerson;
            btFind.Location = new Point(550, 12);
            btFind.Name = "btFind";
            btFind.Size = new Size(51, 40);
            btFind.TabIndex = 7;
            btFind.UseVisualStyleBackColor = true;
            btFind.Click += btnFind_Click;
            // 
            // cbFilterBy
            // 
            cbFilterBy.FormattingEnabled = true;
            cbFilterBy.Items.AddRange(new object[] { "National No.", "Person ID" });
            cbFilterBy.Location = new Point(112, 21);
            cbFilterBy.Name = "cbFilterBy";
            cbFilterBy.Size = new Size(221, 24);
            cbFilterBy.TabIndex = 6;
            cbFilterBy.SelectedIndexChanged += cbFilterBy_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(16, 21);
            label2.Name = "label2";
            label2.Size = new Size(90, 26);
            label2.TabIndex = 5;
            label2.Text = "Find By:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // ctrlPersonCardWithFilter
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(gbFilter);
            Controls.Add(ctrlPersonCard1);
            Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "ctrlPersonCardWithFilter";
            Size = new Size(770, 400);
            Load += ctrlPersonCardWithFilter_Load;
            gbFilter.ResumeLayout(false);
            gbFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ctrlPersonCard ctrlPersonCard1;
        private GroupBox gbFilter;
        private ComboBox cbFilterBy;
        private Label label2;
        private Button btAddNewPerson;
        private Button btFind;
        private TextBox txtFilterValue;
        private ErrorProvider errorProvider1;
    }
}
