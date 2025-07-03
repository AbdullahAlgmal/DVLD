namespace DVLD_DataAccess.Modles
{
    public class CountryModel
    {
        public CountryModel(byte Id, string Name) 
        {
            this.Id = Id;
            this.Name = Name;
        }
        public byte Id { get; set; }
        public string Name { get; set; }
    }
}
