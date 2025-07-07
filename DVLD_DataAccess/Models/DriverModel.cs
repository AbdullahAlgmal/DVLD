using DVLD_DataAccess.Queries;

namespace DVLD_DataAccess.Models
{
    public class DriverModel
    {
        public int DriverId { set; get; }
        public int PersonId { set; get; }
        PersonModel? _Person;
        public PersonModel Person
        {
            get
            {
                if (_Person is null) _Person = PersonQuery.Get(PersonId);
                return _Person;
            }
            set
            {
                _Person = value;
            }
        }
        public int CreatedByUserID { set; get; }
        UserModel? _User;
        public UserModel? User
        {
            get
            {
                if (_User is null) _User = UserQuery.Get(CreatedByUserID);
                return _User;
            }
            set
            {
                _User = value;
            }
        }
        public DateTime CreatedDate { get; }

        public DriverModel(int driverId, int personId, int createdByUserID, DateTime createdDate)
        {
            DriverId = driverId;
            PersonId = personId;
            CreatedByUserID = createdByUserID;
            CreatedDate = createdDate;
        }
    }
}
