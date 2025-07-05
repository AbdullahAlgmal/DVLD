using DVLD_DataAccess.Queries;

namespace DVLD_DataAccess.Models
{
    public class LicenseModel
    {
        [Column("Licens_Id")]
        public int LicenseId { get; set; }
        [Column("Issue_Date")]
        public DateTime IssueDate { get; set; }
        [Column("Expiration_Date")]
        public DateTime ExpirationDate { get; set; }
        public string? Notes { get; set; }
        public bool IsActive { get; set; }
        [Column("Paid_Fees")]
        public float PaidFees { get; set; }
        public byte IssueReason { get; set; }
        [Column("User_Id")]
        public int UserId { get; set; }
        [Column("Driver_Id")]
        public int DriverId { get; set; }
        [Column("Local_Driving_Licens_Application_Id")]
        public int LocalDrivingLicenseApplicationId { get; set; }
        public string IssueReasonText
        {
            get
            {
                string[] arr = ["First Time", "Renew", "Replacement for Damaged", "Replacement for Lost"];
                return arr[IssueReason];
            }
        }
        public Boolean IsLicenseExpired
        {
            get => ExpirationDate < DateTime.Now;
        }
        private UserModel? _User;
        public UserModel? User
        {
            get
            {
                if (_User is null)
                    _User = UserQuery.Get(UserId);
                return _User;
            }
            set => _User = value;
        }
        private DriverModel? _Driver;
        public DriverModel? Driver
        {
            get
            {
                if (_Driver is null)
                    _Driver = DriverQuery.Get(DriverId);
                return _Driver;
            }
            set => _Driver = value;
        }
        private LocalDrivingLicensApplicationModel? _LocalDrivingLicenseApplication;
        public LocalDrivingLicensApplicationModel? LocalDrivingLicenseApplication
        {
            get
            {
                if (_LocalDrivingLicenseApplication is null)
                    _LocalDrivingLicenseApplication = LocalDrivingLicensApplicationQuery.Get(LocalDrivingLicenseApplicationId);
                return _LocalDrivingLicenseApplication;
            }
            set => _LocalDrivingLicenseApplication = value;
        }
    }
}
