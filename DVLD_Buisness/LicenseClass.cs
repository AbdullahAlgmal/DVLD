namespace DVLD_Buisness
{
    public class LicenseClass
    {
        static public DataTable GetAll() => LicenseClassQuery.GetAll();
        static public LicenseClassModel? Find(int Id) => LicenseClassQuery.Get(Id);
        static public LicenseClassModel? Find(string ClassName) => LicenseClassQuery.Get(ClassName);
        static public bool Add(LicenseClassModel Model) => LicenseClassQuery.Add(Model);
        static public bool Update(LicenseClassModel Model) => LicenseClassQuery.Update(Model);
    }
}
