using DVLD_DataAccess.Queries;

namespace DVLD_DataAccess.Models
{
    public class InternationalLicenseModel
    {
        [Column("International_License_Id")]
        public int InternationalLicenseId { get; set; }
        [Column("Issue_Date")]
        public DateTime IssueDate { get; set; }
        [Column("Expiration_Date")]
        public DateTime ExpirationDate { get; set; }
        public bool IsActive { get; set; }
        [Column("Application_Id")]
        public int ApplicationId { get; set; }
        [Column("User_Id")]
        public int UserId { get; set; }
        [Column("Issued_Using_Licens_Id")]
        public int IssuedUsingLicenseId { get; set; }

        private ApplicationModel? _Application;
        public ApplicationModel? Application
        {
            get
            {
                if (_Application is null)
                    _Application = ApplicationQuery.Get(ApplicationId);
                return _Application;
            }
            set => _Application = value;
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

        private LicenseModel? _IssuedUsingLicense;
        public LicenseModel? IssuedUsingLicense
        {
            get
            {
                if (_IssuedUsingLicense is null)
                    _IssuedUsingLicense = LicenseQuery.Get(IssuedUsingLicenseId);
                return _IssuedUsingLicense;
            }
            set => _IssuedUsingLicense = value;
        }
    }
}
