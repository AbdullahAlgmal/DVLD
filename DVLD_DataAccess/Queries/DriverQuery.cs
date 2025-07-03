namespace DVLD_DataAccess.Queries
{
    public class DriverQuery
    {
        public static DataTable GetAll()
        {
            DataTable dt = new();
            try
            {
                using SqlConnection conn = new(ConnectionString.connectionString);
                using SqlCommand cmd = new("GetAllDrivers", conn);

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
        public static DriverModel? Get(int DriverId)
        {
            DriverModel? Model = null;
            try
            {
                using SqlConnection conn = new(ConnectionString.connectionString);
                using SqlCommand cmd = new("GetDriverById", conn);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@DriverID", DriverId);

                conn.Open();

                using SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    Model = new(DriverId,
                                reader.GetInt32(reader.GetOrdinal("Person_Id")),
                                reader.GetInt32(reader.GetOrdinal("Created_By_User_Id")),
                                reader.GetDateTime(reader.GetOrdinal("CreatedDate")));
                }
            }
            catch (Exception)
            {
                Model = null;
            }
            return Model;
        }
        public static DriverModel? GetForPersonId(int PersonId)
        {
            DriverModel? Model = null;
            try
            {
                using SqlConnection conn = new(ConnectionString.connectionString);
                using SqlCommand cmd = new("GetDriverByPersonId", conn);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PersonID", PersonId);

                conn.Open();

                using SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    Model = new(reader.GetInt32(reader.GetOrdinal("Driver_Id")),
                                PersonId,
                                reader.GetInt32(reader.GetOrdinal("Created_By_User_Id")),
                                reader.GetDateTime(reader.GetOrdinal("CreatedDate")));
                }
            }
            catch (Exception)
            {
                Model = null;
            }
            return Model;
        }
        public static bool Add(DriverModel Model)
        {
            try
            {
                using SqlConnection conn = new(ConnectionString.connectionString);
                using SqlCommand cmd = new("AddNewDriver", conn);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@PersonId", Model.PersonId);
                cmd.Parameters.AddWithValue("@UserId", Model.CreatedByUserID);
                cmd.Parameters.AddWithValue("@CreatedDate", Model.CreatedDate);

                var outputIdParam = new SqlParameter("@NewDriverId", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output
                };

                cmd.Parameters.Add(outputIdParam);

                conn.Open();

                cmd.ExecuteNonQuery();
                Model.DriverId = Convert.ToInt32(outputIdParam.Value);
            }
            catch (Exception)
            {

            }
            return Model.DriverId != default;
        }
        public static bool Update(DriverModel Model)
        {
            int RowsAffected = default;
            try
            {
                using SqlConnection conn = new(ConnectionString.connectionString);
                using SqlCommand cmd = new("UpdateDriver", conn);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@DriverId", Model.DriverId);
                cmd.Parameters.AddWithValue("@PersonId", Model.PersonId);
                cmd.Parameters.AddWithValue("@UserId", Model.CreatedByUserID);

                conn.Open();

                RowsAffected = cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

            }
            return RowsAffected > 0;
        }
    }
}
