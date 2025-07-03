namespace DVLD_Buisness
{
    public class Application0
    {
        public enum enApplicationStatus { New = 1, Cancelled = 2, Completed = 3 };
        public enum enApplicationType
        {
            NewDrivingLicense = 1, RenewDrivingLicense = 2, ReplaceLostDrivingLicense = 3,
            ReplaceDamagedDrivingLicense = 4, ReleaseDetainedDrivingLicsense = 5, NewInternationalLicense = 6, RetakeTest = 7
        };
        static public DataTable GetAll() => ApplicationQuery.GetAll();
        static public ApplicationModel? Find(int Id) => ApplicationQuery.Get(Id);
        static public int FindActiveApplicationId(int PersonId, int ApplicationTypeId) => ApplicationQuery.Get(PersonId, ApplicationTypeId);
        static public int FindActiveApplicationIdForLicenseClass(int PersonId, int ApplicationTypeId, int LicenseClassId) => ApplicationQuery.Get(PersonId, ApplicationTypeId, LicenseClassId);
        static public bool Add(ApplicationModel Model) => ApplicationQuery.Add(Model);
        static public bool Update(ApplicationModel Model) => ApplicationQuery.Update(Model);
        static public bool Cancel(int Id) => ApplicationQuery.Update(Id, 2);
        static public bool Complete(int Id) => ApplicationQuery.Update(Id, 3);
        static public bool Delete(int Id) => ApplicationQuery.Delete(Id);
        public static bool Exist(int Id) => ApplicationQuery.Exist(Id);
        public static bool DoesPersonHaveActiveApplication(int PersonId, int ApplicationTypeId) => ApplicationQuery.DoesPersonHaveActiveApplication(PersonId, ApplicationTypeId);
    }
}
