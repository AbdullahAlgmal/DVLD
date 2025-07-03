namespace DVLD_DataAccess.Models
{
    public class DriverModel
    {
        public int DriverId { set; get; }
        public int PersonId { set; get; }
        public int CreatedByUserID { set; get; }
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
