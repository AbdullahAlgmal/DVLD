namespace DVLD_DataAccess.Queries
{
    public class ApplicationTypeQuery
    {
        public static DataTable GetAll()
        {
            DataTable dt = new();
            try
            {
                using SqlConnection conn = new(ConnectionString.connectionString);
                using SqlCommand cmd = new("GetAllApplicationTypes", conn);

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
        public static ApplicationTypeModel? Get(int Id)
        {
            ApplicationTypeModel? Model = null;
            try
            {
                using SqlConnection conn = new(ConnectionString.connectionString);
                using SqlCommand cmd = new("GetApplicationTypeById", conn);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ApplicationTypeID", Id);

                conn.Open();

                using SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    Model = new(Id,
                                reader.GetString(reader.GetOrdinal("Application_Type_Title")),
                                Convert.ToSingle(reader.GetFloat(reader.GetOrdinal("Application_Fees"))));
                }
            }
            catch (Exception)
            {
                Model = null;
            }
            return Model;
        }
        public static bool Add(ApplicationTypeModel Model)
        {
            try
            {
                using SqlConnection conn = new(ConnectionString.connectionString);
                using SqlCommand cmd = new("AddNewApplicationType", conn);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Title", Model.Title);
                cmd.Parameters.AddWithValue("@Fees", Model.Fees);

                var outputIdParam = new SqlParameter("@NewApplicationTypeID", SqlDbType.Int)
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
        public static bool Update(ApplicationTypeModel Model)
        {
            int RowsAffected = default;
            try
            {
                using SqlConnection conn = new(ConnectionString.connectionString);
                using SqlCommand cmd = new("UpdateApplicationType", conn);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ApplicationTypeID", Model.Id);
                cmd.Parameters.AddWithValue("@Title", Model.Title);
                cmd.Parameters.AddWithValue("@Fees", Model.Fees);

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
