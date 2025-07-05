namespace DVLD_DataAccess.Queries
{
    public class TestQuery
    {
        public static bool Add(TestModel model)
        {
            try
            {
                using SqlCommandBuilder builder = SqlCommandBuilder.Instance()
                                                                   .WithStoredProcedure("AddNewTest")
                                                                   .AddStoredProcedureParametersDynamically(model, nameof(model.TestId))
                                                                   .WithOutputParameter("@NewTestId", SqlDbType.Int);

                builder.ExecuteNonQuery();
                model.TestId = Convert.ToInt32(builder.GetOutputParameterValue("@NewTestId"));
            }
            catch (Exception)
            {
                
            }
            return model.TestId != default;
        }
        public static bool Update(TestModel model)
        {
            int rowsAffected = default;
            try
            {
                using SqlCommandBuilder builder = SqlCommandBuilder.Instance()
                                                                   .WithStoredProcedure("UpdateTest")
                                                                   .AddStoredProcedureParametersDynamically(model);
                rowsAffected = builder.ExecuteNonQuery();
            }
            catch (Exception)
            {
            }
            return rowsAffected > 0;
        }
        public static byte GetPassedTestCount(int LocalDrivingLicenseApplicationId)
        {
            byte result;
            try
            {
                using SqlCommandBuilder builder = SqlCommandBuilder.Instance()
                                                                   .WithStoredProcedure("GetPassedTestCount")
                                                                   .WithParameter("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationId);
                result = (byte)builder.ExecuteScalar();
            }
            catch (Exception)
            {
                result = default;
            }
            return result;
        }
        public static TestModel? GetLastTestByPersonAndTestTypeAndLicenseClass(int LocalDrivingLicenseApplicationId, byte LicenseClassId, int PersonId, byte TestTypeId)
        {
            TestModel? model = null;
            try
            {
                using SqlCommandBuilder builder = SqlCommandBuilder.Instance()
                                                                   .WithStoredProcedure("GetLastTestByPersonAndTestTypeAndLicenseClass")
                                                                   .AddStoredProcedureParametersDynamically(LocalDrivingLicenseApplicationId, LicenseClassId, PersonId, TestTypeId);
                using SqlDataReader reader = builder.ExecuteReader();

                if (reader.Read())
                    model = DataReaderMapper.MapToModel<TestModel>(reader);
            }
            catch (Exception)
            {
            }
            return model;
        }
        public static TestModel? Get(int testId)
        {
            TestModel? model = null;
            try
            {
                using SqlCommandBuilder builder = SqlCommandBuilder.Instance()
                                                                   .WithSqlQuery("SELECT * FROM Tests WHERE Test_Id = @TestId")
                                                                   .WithParameter("@TestId", testId);
                using SqlDataReader reader = builder.ExecuteReader();

                if (reader.Read())
                    model = DataReaderMapper.MapToModel<TestModel>(reader);
            }
            catch (Exception)
            {
            }
            return model;
        }
        public static DataTable GetAll()
        {
            DataTable tests = new();
            try
            {
                using SqlCommandBuilder builder = SqlCommandBuilder.Instance()
                                                                   .WithSqlQuery("SELECT * FROM Tests order by Test_Id");
                using SqlDataReader reader = builder.ExecuteReader();

                if (reader.HasRows) tests.Load(reader);
            }
            catch (Exception)
            {
            }
            return tests;
        }
    }
}
