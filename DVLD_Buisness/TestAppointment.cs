namespace DVLD_Buisness
{
    public class TestAppointment
    {
        static public DataTable GetAll() => TestAppointmentQuery.GetAll();
        static public DataTable GetApplicationTestAppointmentsPerTestType(byte TestTypeId, int LocalDrivingLicenseApplicationId) => TestAppointmentQuery.GetApplicationTestAppointmentsPerTestType(TestTypeId, LocalDrivingLicenseApplicationId);
        static public TestAppointmentModel? Find(int Id) => TestAppointmentQuery.Get(Id);
        static public TestAppointmentModel? FindLastTestAppointment(byte TestTypeId, int LocalDrivingLicenseApplicationId) => TestAppointmentQuery.Get(TestTypeId, LocalDrivingLicenseApplicationId);
        static public bool Add(TestAppointmentModel Model) => TestAppointmentQuery.Add(Model);
        static public bool Update(TestAppointmentModel Model) => TestAppointmentQuery.Update(Model);
        static public int GetTestId(int Id) => TestAppointmentQuery.GetTestId(Id);
    }
}
