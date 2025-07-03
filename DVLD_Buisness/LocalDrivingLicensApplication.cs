namespace DVLD_Buisness
{
    public class LocalDrivingLicensApplication
    {
        static public DataTable GetAll() => LocalDrivingLicensApplicationQuery.GetAll();
        static public LocalDrivingLicensApplicationModel? Find(int Id) => LocalDrivingLicensApplicationQuery.Get(Id);
        static public LocalDrivingLicensApplicationModel? FindByApplicationId(int ApplicationId) => LocalDrivingLicensApplicationQuery.GetByApplicationId(ApplicationId);
        static public bool Add(LocalDrivingLicensApplicationModel Model) => LocalDrivingLicensApplicationQuery.Add(Model);
        static public bool Update(LocalDrivingLicensApplicationModel Model) => LocalDrivingLicensApplicationQuery.Update(Model);
        static public byte GetPassedTestCount() => 0;
        static public int GetActiveLicenseId() => 0;
    }
}
