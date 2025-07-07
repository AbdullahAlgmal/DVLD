using DVLD_DataAccess.Queries;
namespace DVLD_DataAccess.Models
{
    public class TestAppointmentModel
    {
        [Column("Test_Appointment_Id")]
        public int TestAppointmentId { get; set; }
        [Column("Appointment_Date")]
        public DateTime AppointmentDate { get; set; }
        public bool IsLocked { get; set; }
        [Column("Paid_Fees")]
        public float PaidFees { get; set; }
        [Column("Created_By_User_Id")]
        public int UserId { get; set; }
        private UserModel? _User;
        public UserModel? User
        {
            get
            {
                if (_User is null) _User = UserQuery.Get(UserId);
                return _User;
            }
            set
            {
                _User = value;
            }
        }
        [Column("Test_Type_Id")]
        public byte TestTypeId { get; set; }
        private TestTypeModel? _TestType;
        public TestTypeModel? TestType
        {
            get
            {
                if (_TestType is null) _TestType = TestTypeQuery.Get(TestTypeId);
                return _TestType;
            }
            set
            {
                _TestType = value;
            }
        }
        [Column("Local_Driving_Licens_Application_Id")]
        public int LocalDrivingLicensApplicationId { get; set; }
        [Column("Retake_Test_ApplicationI_Id")]
        public int RetakeTestApplicationId { get; set; }
        private ApplicationModel? _RetakeApplication;
        public ApplicationModel? RetakeApplication
        {
            get
            {
                if (_LocalDrivingLicensApplication is null) _RetakeApplication = ApplicationQuery.Get(RetakeTestApplicationId);
                return _RetakeApplication;
            }
            set
            {
                _RetakeApplication = value;
            }
        }
        private LocalDrivingLicensApplicationModel? _LocalDrivingLicensApplication;
        public LocalDrivingLicensApplicationModel? LocalDrivingLicensApplication
        {
            get
            {
                if (_LocalDrivingLicensApplication is null) _LocalDrivingLicensApplication = LocalDrivingLicensApplicationQuery.Get(LocalDrivingLicensApplicationId);
                return _LocalDrivingLicensApplication;
            }
            set
            {
                _LocalDrivingLicensApplication = value;
            }
        }
        public TestAppointmentModel()
        {
        }
        public TestAppointmentModel(int testAppointmentId,
                                    DateTime appointmentDate,
                                    bool isLocked,
                                    float paidFees,
                                    int userId,
                                    byte testTypeId,
                                    int localDrivingLicensApplicationId,
                                    int retakeTestApplicationId)
        {
            TestAppointmentId = testAppointmentId;
            AppointmentDate = appointmentDate;
            IsLocked = isLocked;
            PaidFees = paidFees;
            UserId = userId;
            TestTypeId = testTypeId;
            LocalDrivingLicensApplicationId = localDrivingLicensApplicationId;
            RetakeTestApplicationId = retakeTestApplicationId;
        }
    }
}
