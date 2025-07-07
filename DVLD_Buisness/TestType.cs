namespace DVLD_Buisness
{
    public class TestType
    {
        public enum enTestType { VisionTest = 1, WrittenTest = 2, StreetTest = 3 };
        static public DataTable GetAll() => TestTypeQuery.GetAll();
        static public TestTypeModel? Find(int Id) => TestTypeQuery.Get(Id);
        static public bool Update(TestTypeModel Model) => TestTypeQuery.Update(Model);
    }
}
