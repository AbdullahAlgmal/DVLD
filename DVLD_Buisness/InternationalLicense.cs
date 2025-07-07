namespace DVLD_Buisness
{
    public class InternationalLicense
    {
        static public DataTable GetAll() => InternationalLicenseQuery.GetAll();
        static public DataTable GetDriverInternationalLicenses(int DriverId) => InternationalLicenseQuery.GetDriverInternationalLicenses(DriverId);
        static public InternationalLicenseModel? Find(int Id) => InternationalLicenseQuery.Get(Id);
        static public bool Add(InternationalLicenseModel Model) => InternationalLicenseQuery.Add(Model);
        static public bool Update(InternationalLicenseModel Model) => InternationalLicenseQuery.Update(Model);
        static public int GetActiveInternationalLicenseIDByDriverID(int DriverId) => InternationalLicenseQuery.GetActiveInternationalLicenseIDByDriverID(DriverId);
    }
}
