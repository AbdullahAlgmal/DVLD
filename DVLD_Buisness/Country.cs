using DVLD_DataAccess.Modles;

namespace DVLD_Buisness
{
    public class Country
    {
        static public DataTable GetAll() => CountryQuery.GetAll();
        static public CountryModel Find(byte Id) => CountryQuery.Get(Id);
        static public CountryModel Find(string Name) => CountryQuery.Get(Name);
    }
}
