namespace DVLD_Buisness
{
    public class DetainedLicense
    {
        static public DataTable GetAll() => DetainedLicenseQuery.GetAll();
        static public DetainedLicenseModel? Find(int Id) => DetainedLicenseQuery.Get(Id);
        static public DetainedLicenseModel? FindByLicenseId(int LicenseId) => DetainedLicenseQuery.GetByLicenseId(LicenseId);
        static public bool Add(DetainedLicenseModel Model) => DetainedLicenseQuery.Add(Model);
        static public bool Update(DetainedLicenseModel Model) => DetainedLicenseQuery.Update(Model);
        public static bool ReleaseDetainedLicense(int DetainId, int ReleasedByUserId, int ReleaseApplicationId) => DetainedLicenseQuery.ReleaseDetainedLicense(DetainId, ReleasedByUserId, ReleaseApplicationId);
        public static bool IsLicenseDetained(int LicenseId) => DetainedLicenseQuery.IsLicenseDetained(LicenseId);
    }
}
