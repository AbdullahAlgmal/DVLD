using DVLD_DataAccess.Queries;

namespace DVLD_DataAccess.Models
{
    public class TestModel
    {
        [Column("Test_Id")]
        public int TestId { get; set; }
        public bool Result { get; set; }
        public string? Notes { get; set; }
        [Column("Test_Appointment_Id")]
        public int TestAppointmentId { get; set; }
        [Column("Created_By_User_Id")]
        public int CreatedByUserId { get; set; }

        private TestAppointmentModel? _TestAppointment;
        public TestAppointmentModel? TestAppointment
        {
            get
            {
                if (_TestAppointment is null)
                    _TestAppointment = TestAppointmentQuery.Get(TestAppointmentId);
                return _TestAppointment;
            }
            set => _TestAppointment = value;
        }

        private UserModel? _CreatedByUser;
        public UserModel? CreatedByUser
        {
            get
            {
                if (_CreatedByUser is null)
                    _CreatedByUser = UserQuery.Get(CreatedByUserId);
                return _CreatedByUser;
            }
            set => _CreatedByUser = value;
        }
    }
}
