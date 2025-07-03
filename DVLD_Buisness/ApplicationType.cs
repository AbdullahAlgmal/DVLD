namespace DVLD_Buisness
{
    public class ApplicationType
    {
        static public DataTable GetAll() => ApplicationTypeQuery.GetAll();
        static public ApplicationTypeModel? Find(int Id) => ApplicationTypeQuery.Get(Id);
        static public bool Add(ApplicationTypeModel Model) => ApplicationTypeQuery.Add(Model);
        static public bool Update(ApplicationTypeModel Model) => ApplicationTypeQuery.Update(Model);
    }
}
