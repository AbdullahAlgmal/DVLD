namespace DVLD_Buisness
{
    public class Test
    {
        static public DataTable GetAll() => TestQuery.GetAll();
        static public TestModel? Find(int Id) => TestQuery.Get(Id);
        static public TestModel? FindLastTestByPersonAndTestTypeAndLicenseClass(int LocalDrivingLicenseApplicationId, byte LicenseClassId, int PersonId, byte TestTypeId) => TestQuery.GetLastTestByPersonAndTestTypeAndLicenseClass(LocalDrivingLicenseApplicationId, LicenseClassId, PersonId, TestTypeId);
        static public bool Add(TestModel Model) => TestQuery.Add(Model);
        static public bool Update(TestModel Model) => TestQuery.Update(Model);
        public static byte GetPassedTestCount(int LocalDrivingLicenseApplicationID) => TestQuery.GetPassedTestCount(LocalDrivingLicenseApplicationID);
        public static bool PassedAllTests(int LocalDrivingLicenseApplicationID) => GetPassedTestCount(LocalDrivingLicenseApplicationID) == 3;
    }
}
