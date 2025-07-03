using DVLD_DataAccess.Queries;

namespace DVLD_DataAccess.Models
{
    public class LocalDrivingLicensApplicationModel
    {
        public int Id { set; get; }
        public int ApplicationId { set; get; }
        private ApplicationModel? _Application;
        public ApplicationModel? Application
        {
            get
            {
                if (_Application is null) _Application = ApplicationQuery.Get(ApplicationId);
                return _Application;
            }
            set
            {
                _Application = value;
            }
        }
        public int LicenseClassId { set; get; }
        private LicenseClassModel? _LicenseClass;
        public LicenseClassModel? LicenseClass
        {
            get
            {
                if (_LicenseClass is null) _LicenseClass = LicenseClassQuery.Get(LicenseClassId);
                return _LicenseClass;
            }
            set
            {
                _LicenseClass = value;
            }
        }
        public LocalDrivingLicensApplicationModel(int id, int applicationId, int licenseClassId)
        {
            Id = id;
            ApplicationId = applicationId;
            LicenseClassId = licenseClassId;
        }
    }
}
