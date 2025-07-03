using DVLD_UI.People.Controls;

namespace DVLD_UI.People
{
    public partial class frmShowPersonInfo : Form
    {
        public frmShowPersonInfo(int Id)
        {
            InitializeComponent();
            ctrlPersonCard1.LoadPersonInfo(Id);
        }

        public frmShowPersonInfo(string NationalNumber)
        {
            InitializeComponent();
            ctrlPersonCard1.LoadPersonInfo(NationalNumber);
        }
    }
}
