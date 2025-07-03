namespace DVLD_Buisness
{
    public class Person
    {
        static public DataTable GetAll() => PersonQuery.GetAll();
        static public PersonModel Find(int Id) => PersonQuery.Get(Id);
        static public PersonModel Find(string NationalNumber) => PersonQuery.Get(NationalNumber);
        static public bool Add(PersonModel Model) => PersonQuery.Add(Model);
        static public bool Update(PersonModel Model) => PersonQuery.Update(Model);
        static public bool Delete(int Id) => PersonQuery.Delete(Id);
        public static bool Exist(int Id) => PersonQuery.Exist(Id);
        public static bool Exist(string NationalNumber) => PersonQuery.Exist(NationalNumber);
    }
}
