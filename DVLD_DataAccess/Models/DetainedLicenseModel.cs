using DVLD_DataAccess.Queries;

namespace DVLD_DataAccess.Models
{
    public class DetainedLicenseModel
    {
        [Column("Detained_Lincens_Id")]
        public int DetainedLicenseId { get; set; }
        [Column("Detain_Date")]
        public DateTime DetainDate { get; set; }
        [Column("Release_Date")]
        public DateTime? ReleaseDate { get; set; }
        public float FineFees { get; set; }
        public bool IsReleased { get; set; }
        [Column("Licens_Id")]
        public int LicenseId { get; set; }
        [Column("Created_By_User_Id")]
        public int CreatedByUserId { get; set; }
        [Column("Released_By_User_Id")]
        public int? ReleasedByUserId { get; set; }
        [Column("RELEASE_Application_Id")]
        public int? ReleaseApplicationId { get; set; }

        private LicenseModel? _License;
        public LicenseModel? License
        {
            get
            {
                if (_License is null)
                    _License = LicenseQuery.Get(LicenseId);
                return _License;
            }
            set => _License = value;
        }

        private UserModel? _CreatedByUser;
        public UserModel? CreatedByUser
        {
            get
            {
                if (_CreatedByUser is null)
                    _CreatedByUser = UserQuery.Get(CreatedByUserId);
                return _CreatedByUser;
            }
            set => _CreatedByUser = value;
        }

        private UserModel? _ReleasedByUser;
        public UserModel? ReleasedByUser
        {
            get
            {
                if (_ReleasedByUser is null)
                    _ReleasedByUser = UserQuery.Get(ReleasedByUserId ?? 0);
                return _ReleasedByUser;
            }
            set => _ReleasedByUser = value;
        }

        private ApplicationModel? _ReleaseApplication;
        public ApplicationModel? ReleaseApplication
        {
            get
            {
                if (_ReleaseApplication is null)
                    _ReleaseApplication = ApplicationQuery.Get(ReleaseApplicationId ?? 0);
                return _ReleaseApplication;
            }
            set => _ReleaseApplication = value;
        }
    }
}
