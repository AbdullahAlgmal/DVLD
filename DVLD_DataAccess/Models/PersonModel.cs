using DVLD_DataAccess.Modles;
using DVLD_DataAccess.Queries;

namespace DVLD_DataAccess.Models
{
    public class PersonModel
    {
        [Column("Person_Id")]
        public int PersonId { get; set; }
        [Column("First_Name")]
        public string FirstName { get; set; }
        [Column("Second_Name")]
        public string? SecondName { get; set; }
        [Column("Third_Name")]
        public string? ThirdName { get; set; }
        [Column("Last_Name")]
        public string LastName { get; set; }
        public string FullName
        {
            get => $"{FirstName} {SecondName} {ThirdName} {LastName}"; 
        }
        [Column("Birth_Date")]
        public DateTime BirthDate { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string? Email { get; set; }
        [Column("National_Number")]
        public string NationalNumber { get; set; }
        [Column("Image_Path")]
        public string? ImagePath { get; set; }
        public byte Gender { get; set; }
        [Column("Country_Id")]
        public byte CountryId { get; set; }
        private CountryModel? _Country;
        public CountryModel Country
        {
            get
            {
                if (_Country is null) _Country = CountryQuery.Get(CountryId);
                return _Country;
            }
            set
            {
                _Country = value;
            }
        }
    }
}
