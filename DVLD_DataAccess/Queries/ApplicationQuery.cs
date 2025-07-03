namespace DVLD_DataAccess.Queries
{
    public class ApplicationQuery
    {
        public static DataTable GetAll()
        {
            DataTable dt = new();
            try
            {
                using SqlConnection conn = new(ConnectionString.connectionString);
                using SqlCommand cmd = new("GetAllApplications", conn);

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
        public static ApplicationModel Get(int Id)
        {
            ApplicationModel Model = null!;
            try
            {
                using SqlConnection conn = new(ConnectionString.connectionString);
                using SqlCommand cmd = new("GetApplicationById", conn);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ApplicationID", Id);

                conn.Open();

                using SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    Model = new ApplicationModel(Id,
                                                 reader.GetInt32(reader.GetOrdinal("Person_Id")),
                                                 reader.GetDateTime(reader.GetOrdinal("Application_Date")),
                                                 reader.GetInt32(reader.GetOrdinal("Application_Type_Id")),
                                                 reader.GetByte(reader.GetOrdinal("Application_Status")),
                                                 reader.GetDateTime(reader.GetOrdinal("Last_Status_Date")),
                                                 reader.GetFloat(reader.GetOrdinal("Paid_Fees")),
                                                 reader.GetInt32(reader.GetOrdinal("User_Id"))
                                                 );
                }
            }
            catch (Exception)
            {
                Model = null!;
            }
            return Model;
        }
        public static int Get(int PersonId, int ApplicationTypeId)
        {
            int ActiveApplicationId = default;
            try
            {
                using SqlConnection conn = new(ConnectionString.connectionString);
                using SqlCommand cmd = new("GetActiveApplicationId", conn);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PersonID", PersonId);
                cmd.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeId);

                conn.Open();

                ActiveApplicationId = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception)
            {
            }
            return ActiveApplicationId;
        }
        public static int Get(int PersonId, int ApplicationTypeId, int LicenseClassId)
        {
            int ActiveApplicationId = default;
            try
            {
                using SqlConnection conn = new(ConnectionString.connectionString);
                using SqlCommand cmd = new("GetActiveApplicationIDForLicenseClass", conn);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PersonID", PersonId);
                cmd.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeId);
                cmd.Parameters.AddWithValue("@LicenseClassID", LicenseClassId);

                conn.Open();

                ActiveApplicationId = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception)
            {
            }
            return ActiveApplicationId;
        }
        public static bool Delete(int Id)
        {
            int RowsAffected = default;
            try
            {
                using SqlConnection conn = new(ConnectionString.connectionString);
                using SqlCommand cmd = new("DeleteApplicationById", conn);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ApplicationId", Id);

                conn.Open();

                RowsAffected = cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

            }
            return RowsAffected > 0;
        }
        public static bool Add(ApplicationModel Model)
        {
            try
            {
                using SqlConnection conn = new(ConnectionString.connectionString);
                using SqlCommand cmd = new("AddNewApplication", conn);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@PersonID", Model.PersonId);
                cmd.Parameters.AddWithValue("@CreatedByUserID", Model.CreatedByUserId);
                cmd.Parameters.AddWithValue("@ApplicationTypeID", Model.ApplicationTypeId);
                cmd.Parameters.AddWithValue("@PaidFees", Model.PaidFees);
                cmd.Parameters.AddWithValue("@ApplicationStatus", Model.ApplicationStatus);
                cmd.Parameters.AddWithValue("@ApplicationDate", Model.ApplicationDate);
                cmd.Parameters.AddWithValue("@LastStatusDate", Model.LastStatusDate);

                var outputIdParam = new SqlParameter("@NewApplicationId", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output
                };

                cmd.Parameters.Add(outputIdParam);

                conn.Open();

                cmd.ExecuteNonQuery();
                Model.ApplicationId = Convert.ToInt32(outputIdParam.Value);
            }
            catch (Exception)
            {

            }
            return Model.ApplicationId != default;
        }
        public static bool Update(ApplicationModel Model)
        {
            int RowsAffected = default;
            try
            {
                using SqlConnection conn = new(ConnectionString.connectionString);
                using SqlCommand cmd = new("UpdateApplication", conn);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ApplicationID", Model.ApplicationId);
                cmd.Parameters.AddWithValue("@PersonID", Model.PersonId);
                cmd.Parameters.AddWithValue("@CreatedByUserID", Model.CreatedByUserId);
                cmd.Parameters.AddWithValue("@ApplicationTypeID", Model.ApplicationTypeId);
                cmd.Parameters.AddWithValue("@PaidFees", Model.PaidFees);
                cmd.Parameters.AddWithValue("@ApplicationStatus", Model.ApplicationStatus);
                cmd.Parameters.AddWithValue("@ApplicationDate", Model.ApplicationDate);
                cmd.Parameters.AddWithValue("@LastStatusDate", Model.LastStatusDate);

                conn.Open();

                RowsAffected = cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

            }
            return RowsAffected > 0;
        }
        public static bool Update(int ApplicationId, short NewStatus)
        {
            int RowsAffected = default;
            try
            {
                using SqlConnection conn = new(ConnectionString.connectionString);
                using SqlCommand cmd = new("UpdateApplicationStatus", conn);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ApplicationID", ApplicationId);
                cmd.Parameters.AddWithValue("@ApplicationStatus", NewStatus);
                cmd.Parameters.AddWithValue("@LastStatusDate", DateTime.Now);

                conn.Open();

                RowsAffected = cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

            }
            return RowsAffected > 0;
        }
        public static bool Exist(int Id)
        {
            bool isFound = false;

            try
            {
                using SqlConnection connection = new SqlConnection(ConnectionString.connectionString);
                using SqlCommand command = new SqlCommand("SELECT Found=1 FROM Applications WHERE Application_Id = @ApplicationID", connection);

                command.Parameters.AddWithValue("@ApplicationID", Id);

                connection.Open();

                isFound = Convert.ToBoolean(command.ExecuteScalar());
            }
            catch (Exception )
            {
                isFound = false;
            }

            return isFound;
        }
        public static bool DoesPersonHaveActiveApplication(int PersonID, int ApplicationTypeID)
        {
            return (Get(PersonID, ApplicationTypeID) != default);
        }
    }
}
