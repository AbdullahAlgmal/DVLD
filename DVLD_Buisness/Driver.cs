namespace DVLD_Buisness
{
    public class Driver
    {
        static public DataTable GetAll() => DriverQuery.GetAll();
        static public DriverModel? Find(int DriverId) => DriverQuery.Get(DriverId);
        static public DriverModel? FindForPersonId(int PersonId) => DriverQuery.GetForPersonId(PersonId);
        static public bool Add(DriverModel Model) => DriverQuery.Add(Model);
        static public bool Update(DriverModel Model) => DriverQuery.Update(Model);
        public static DataTable GetLicenses(int DriverID) => LicenseQuery.GetDriverLicenses(DriverID);
        public static DataTable GetInternationalLicenses(int DriverID) => InternationalLicenseQuery.GetDriverInternationalLicenses(DriverID);
    }
}
