namespace DVLD_DataAccess.Models
{
    using DVLD_DataAccess.Queries;
    using System.Diagnostics.CodeAnalysis;
    public class UserModel
    {
        private PersonModel? _Person;

        [Column("User_Id")]
        public int UserId { get; set; }
        [Column("User_Name")]
        required public string UserName { get; set; }
        [Column("User_Password")]
        required public string Password { get; set; }
        [Column("Is_Active")]
        public bool IsActive { get; set; }
        [Column("Person_Id")]
        public int PersonId { get; set; }       
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

        [SetsRequiredMembers]
        public UserModel()
        {
        }

        [SetsRequiredMembers]
        public UserModel(int UserId, string UserName, string Password, bool IsActive, int PersonId)
        {
            this.UserId = UserId;
            this.UserName = UserName;
            this.Password = Password;
            this.IsActive = IsActive;
            this.PersonId = PersonId;
        }
    }
}
