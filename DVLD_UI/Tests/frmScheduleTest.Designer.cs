namespace DVLD.Tests
{
    partial class frmScheduleTest
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
            ctrlScheduleTest1 = new ctrlScheduleTest();
            SuspendLayout();
            // 
            // ctrlScheduleTest1
            // 
            ctrlScheduleTest1.BackColor = Color.White;
            ctrlScheduleTest1.Dock = DockStyle.Fill;
            ctrlScheduleTest1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ctrlScheduleTest1.Location = new Point(0, 0);
            ctrlScheduleTest1.Margin = new Padding(4, 5, 4, 5);
            ctrlScheduleTest1.Name = "ctrlScheduleTest1";
            ctrlScheduleTest1.Size = new Size(545, 735);
            ctrlScheduleTest1.TabIndex = 0;
            ctrlScheduleTest1.TestTypeID = TestType.enTestType.VisionTest;
            // 
            // frmScheduleTest
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(545, 735);
            Controls.Add(ctrlScheduleTest1);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmScheduleTest";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Schedule Test";
            Load += frmScheduleTest_Load;
            ResumeLayout(false);
        }

        #endregion

        private ctrlScheduleTest ctrlScheduleTest1;
    }
}