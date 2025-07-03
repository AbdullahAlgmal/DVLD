namespace DVLD_DataAccess.Queries
{
    public class LocalDrivingLicensApplicationQuery
    {
        public static DataTable GetAll()
        {
            DataTable dt = new();
            try
            {
                using SqlConnection conn = new(ConnectionString.connectionString);
                using SqlCommand cmd = new("GetAllLocalDrivingLicensApplications", conn);

                cmd.CommandType = CommandType.StoredProcedure;

                conn.Open();

                using SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows) dt.Load(reader);
            }
            catch (Exception)
            {

            }
            return dt;
        }
        public static LocalDrivingLicensApplicationModel? Get(int Id)
        {
            LocalDrivingLicensApplicationModel? Model = null;
            try
            {
                using SqlConnection conn = new(ConnectionString.connectionString);
                using SqlCommand cmd = new("GetLocalDrivingLicensApplicationById", conn);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", Id);

                conn.Open();

                using SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    Model = new(reader.GetInt32(reader.GetOrdinal("Local_Driving_Licens_Application_Id")),
                                reader.GetInt32(reader.GetOrdinal("Application_Id")),
                                reader.GetInt32(reader.GetOrdinal("License_Class_ID")));
                }
            }
            catch (Exception)
            {
                Model = null;
            }
            return Model;
        }
        public static LocalDrivingLicensApplicationModel? GetByApplicationId(int ApplicationId)
        {
            LocalDrivingLicensApplicationModel? Model = null;
            try
            {
                using SqlConnection conn = new(ConnectionString.connectionString);
                using SqlCommand cmd = new("GetLocalDrivingLicensApplicationByApplicationId", conn);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ApplicationID", ApplicationId);

                conn.Open();

                using SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    Model = new(reader.GetInt32(reader.GetOrdinal("Local_Driving_Licens_Application_Id")),
                                reader.GetInt32(reader.GetOrdinal("Application_Id")),
                                reader.GetInt32(reader.GetOrdinal("License_Class_ID")));
                }
            }
            catch (Exception)
            {
                Model = null;
            }
            return Model;
        }
        public static bool Add(LocalDrivingLicensApplicationModel Model)
        {
            try
            {
                using SqlConnection conn = new(ConnectionString.connectionString);
                using SqlCommand cmd = new("AddNewLocalDrivingLicenseApplication", conn);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ApplicationID", Model.ApplicationId);
                cmd.Parameters.AddWithValue("@LicenseClassID", Model.LicenseClassId);


                var outputIdParam = new SqlParameter("@NewLocalDrivingLicenseApplicationId", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output
                };

                cmd.Parameters.Add(outputIdParam);

                conn.Open();

                cmd.ExecuteNonQuery();
                Model.Id = Convert.ToInt32(outputIdParam.Value);
            }
            catch (Exception)
            {

            }
            return Model.Id != default;
        }
        public static bool Update(LocalDrivingLicensApplicationModel Model)
        {
            int RowsAffected = default;
            try
            {
                using SqlConnection conn = new(ConnectionString.connectionString);
                using SqlCommand cmd = new("UpdateLocalDrivingLicenseApplication", conn);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@LocalDrivingLicenseApplicationId", Model.Id);
                cmd.Parameters.AddWithValue("@ApplicationID", Model.ApplicationId);
                cmd.Parameters.AddWithValue("@LicenseClassID", Model.LicenseClassId);

                conn.Open();

                RowsAffected = cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

            }
            return RowsAffected > 0;
        }
        public static bool Delete(int Id)
        {
            int RowsAffected = default;
            try
            {
                using SqlConnection conn = new(ConnectionString.connectionString);
                using SqlCommand cmd = new SqlCommand("Delete Local_Driving_Licens_Applications where Local_Driving_Licens_Application_Id = @LocalDrivingLicenseApplicationID", conn);
                cmd.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", Id);

                conn.Open();

                RowsAffected = cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

            }
            return RowsAffected > 0;
        }
        public static bool DoesPassTestType(int LocalDrivingLicenseApplicationId, int TestTypeId)
        {
            bool Result = false;

            try
            {
                using SqlConnection connection = new SqlConnection(ConnectionString.connectionString);
                using SqlCommand command = new SqlCommand("DoesPassTestType", connection);

                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationId);
                command.Parameters.AddWithValue("@TestTypeID", TestTypeId);

                connection.Open();

                Result = Convert.ToBoolean(command.ExecuteScalar() ?? false);
            }
            catch (Exception)
            {
                Result = false;
            }

            return Result;
        }
        public static bool DoesAttendTestType(int LocalDrivingLicenseApplicationId, int TestTypeId)
        {
            bool Result = false;

            try
            {
                using SqlConnection connection = new SqlConnection(ConnectionString.connectionString);
                using SqlCommand command = new SqlCommand("DoesAttendTestType", connection);

                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationId);
                command.Parameters.AddWithValue("@TestTypeID", TestTypeId);

                connection.Open();

                Result = Convert.ToBoolean(command.ExecuteScalar() ?? false);
            }
            catch (Exception)
            {
                Result = false;
            }

            return Result;
        }
        public static byte TotalTrialsPerTest(int LocalDrivingLicenseApplicationId, int TestTypeId)
        {
            byte Result;

            try
            {
                using SqlConnection connection = new SqlConnection(ConnectionString.connectionString);
                using SqlCommand command = new SqlCommand("TotalTrialsPerTest", connection);

                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationId);
                command.Parameters.AddWithValue("@TestTypeID", TestTypeId);

                connection.Open();

                Result = byte.Parse(command.ExecuteScalar() as string ?? "0");
            }
            catch (Exception)
            {
                Result = default;
            }

            return Result;
        }
        public static bool IsThereAnActiveScheduledTest(int LocalDrivingLicenseApplicationId, int TestTypeId)
        {
            bool Result = false;

            try
            {
                using SqlConnection connection = new SqlConnection(ConnectionString.connectionString);
                using SqlCommand command = new SqlCommand("IsThereAnActiveScheduledTest", connection);

                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationId);
                command.Parameters.AddWithValue("@TestTypeID", TestTypeId);

                connection.Open();

                Result = Boolean.Parse(command.ExecuteScalar() as string ?? "0");
            }
            catch (Exception)
            {
                Result = false;
            }

            return Result;
        }
    }
}
