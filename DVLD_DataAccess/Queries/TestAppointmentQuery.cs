namespace DVLD_DataAccess.Queries
{
    public class TestAppointmentQuery
    {
        public static DataTable GetAll()
        {
            DataTable dt = new();
            try
            {
                using SqlCommandBuilder builder = SqlCommandBuilder.Instance().WithStoredProcedure("GetAllTestAppointments");
                using SqlDataReader reader = builder.ExecuteReader();

                if (reader.HasRows) dt.Load(reader);
            }
            catch (Exception)
            {

            }
            return dt;
        }
        public static DataTable GetApplicationTestAppointmentsPerTestType(byte TestTypeId, int LocalDrivingLicenseApplicationId)
        {
            DataTable dt = new();
            try
            {
                using SqlCommandBuilder builder = SqlCommandBuilder.Instance()
                                                                   .WithStoredProcedure("GetApplicationTestAppointmentsPerTestType")
                                                                   .AddStoredProcedureParametersDynamically(TestTypeId, LocalDrivingLicenseApplicationId);
                using SqlDataReader reader = builder.ExecuteReader();

                if (reader.HasRows) dt.Load(reader);
            }
            catch (Exception)
            {

            }
            return dt;
        }
        public static TestAppointmentModel? Get(int Id)
        {
            TestAppointmentModel? Model = null;
            try
            {
                using SqlCommandBuilder builder = SqlCommandBuilder.Instance()
                                                                   .WithSqlQuery("SELECT * FROM Test_Appointments WHERE Test_Appointment_Id = @TestAppointmentID")
                                                                   .WithParameter("@TestAppointmentID", Id);
                using SqlDataReader reader = builder.ExecuteReader();

                if (reader.Read())
                    Model = DataReaderMapper.MapToModel<TestAppointmentModel>(reader);
            }
            catch (Exception)
            {
                Model = null;
            }
            return Model;
        }
        public static TestAppointmentModel? Get(byte TestTypeId, int LocalDrivingLicenseApplicationId)
        {
            TestAppointmentModel? Model = null;
            try
            {
                using SqlCommandBuilder builder = SqlCommandBuilder.Instance()
                                                                   .WithStoredProcedure("GetLastTestAppointment")
                                                                   .AddStoredProcedureParametersDynamically(TestTypeId, LocalDrivingLicenseApplicationId);
                using SqlDataReader reader = builder.ExecuteReader();

                if (reader.Read())
                    Model = DataReaderMapper.MapToModel<TestAppointmentModel>(reader);
            }
            catch (Exception)
            {
                Model = null;
            }
            return Model;
        }
        public static bool Add(TestAppointmentModel Model)
        {
            try
            {
                using SqlCommandBuilder builder = SqlCommandBuilder.Instance()
                                                                   .WithStoredProcedure("AddNewTestAppointment")
                                                                   .AddStoredProcedureParametersDynamically(Model, nameof(Model.TestAppointmentId))
                                                                   .WithOutputParameter("@NewTestAppointmentId", SqlDbType.Int);
                builder.ExecuteNonQuery();
                Model.TestAppointmentId = Convert.ToInt32(builder.GetOutputParameterValue("@NewTestAppointmentId"));
            }
            catch (Exception)
            {

            }
            return Model.TestAppointmentId != default;
        }
        public static bool Update(TestAppointmentModel Model)
        {
            int RowsAffected = default;
            try
            {
                using SqlCommandBuilder builder = SqlCommandBuilder.Instance()
                                                                   .WithStoredProcedure("UpdateTestAppointment")
                                                                   .AddStoredProcedureParametersDynamically(Model);
                RowsAffected = builder.ExecuteNonQuery();
            }
            catch (Exception)
            {

            }
            return RowsAffected > 0;
        }
        public static int GetTestId(int Id)
        {
            int TestId;
            try
            {
                using SqlCommandBuilder builder = SqlCommandBuilder.Instance()
                                                                   .WithSqlQuery("select Test_Id from Tests where Test_Appointment_Id=@TestAppointmentID;")
                                                                   .WithParameter("@TestAppointmentID", Id);
                TestId = Convert.ToInt32(builder.ExecuteScalar());
            }
            catch (Exception)
            {
                TestId = default;
            }
            return TestId;
        }
    }
}
