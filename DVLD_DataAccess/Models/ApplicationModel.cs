using DVLD_DataAccess.Queries;

namespace DVLD_DataAccess.Models
{
    public class ApplicationModel
    {
        public int ApplicationId { set; get; }
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
        public string ApplicantFullName
        {
            get
            {
                return Person.FullName;
            }
        }
        public DateTime ApplicationDate { set; get; }
        public int ApplicationTypeId { set; get; }

        ApplicationTypeModel? _ApplicationType;
        public ApplicationTypeModel? ApplicationType
        {
            get
            {
                if (_ApplicationType is null) _ApplicationType = ApplicationTypeQuery.Get(ApplicationTypeId);
                return _ApplicationType;
            }
            set
            {
                _ApplicationType = value;
            }
        }
        public byte ApplicationStatus { set; get; }
        public string StatusText
        {
            get
            {
                switch (ApplicationStatus)
                {
                    case 1:
                        return "New";
                    case 2:
                        return "Cancelled";
                    case 3:
                        return "Completed";
                    default:
                        return "Unknown";
                }
            }
        }
        public DateTime LastStatusDate { set; get; }
        public float PaidFees { set; get; }
        public int CreatedByUserId { set; get; }

        UserModel? _User;
        public UserModel? User
        {
            get
            {
                if (_User is null) _User = UserQuery.Get(CreatedByUserId);
                return _User;
            }
            set
            {
                _User = value;
            }
        }

        public ApplicationModel(int applicationId,
                                int personId,
                                DateTime applicationDate,
                                int applicationTypeId,
                                byte applicationStatus,
                                DateTime lastStatusDate,
                                float paidFees,
                                int createdByUserId)
        {
            ApplicationId = applicationId;
            PersonId = personId;
            ApplicationDate = applicationDate;
            ApplicationTypeId = applicationTypeId;
            ApplicationStatus = applicationStatus;
            LastStatusDate = lastStatusDate;
            PaidFees = paidFees;
            CreatedByUserId = createdByUserId;
        }
    }
}
