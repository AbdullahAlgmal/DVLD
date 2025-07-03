namespace DVLD_Buisness
{
    public class TestType
    {
        static public DataTable GetAll() => TestTypeQuery.GetAll();
        static public TestTypeModel? Find(int Id) => TestTypeQuery.Get(Id);
        static public bool Update(TestTypeModel Model) => TestTypeQuery.Update(Model);
    }
}
