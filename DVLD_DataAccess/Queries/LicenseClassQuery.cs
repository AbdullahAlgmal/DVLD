namespace DVLD_DataAccess.Queries
{
    public class LicenseClassQuery
    {
        public static DataTable GetAll()
        {
            DataTable dt = new();
            try
            {
                using SqlConnection conn = new(ConnectionString.connectionString);
                using SqlCommand cmd = new("GetAllLicenseClasses", conn);

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
        public static LicenseClassModel? Get(int Id)
        {
            LicenseClassModel? Model = null;
            try
            {
                using SqlConnection conn = new(ConnectionString.connectionString);
                using SqlCommand cmd = new("GetLicenseClassById", conn);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@LicenseClassId", Id);

                conn.Open();

                using SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    Model = new(Id,
                                reader.GetString(reader.GetOrdinal("Class_Name")),
                                reader.GetString(reader.GetOrdinal("Class_Description")),
                                reader.GetByte(reader.GetOrdinal("Minimum_Allowed_Age")),
                                reader.GetByte(reader.GetOrdinal("Validity_Length")),
                                reader.GetFloat(reader.GetOrdinal("Class_Fees")));
                }
            }
            catch (Exception)
            {
                Model = null;
            }
            return Model;
        }
        public static LicenseClassModel? Get(string ClassName)
        {
            LicenseClassModel? Model = null;
            try
            {
                using SqlConnection conn = new(ConnectionString.connectionString);
                using SqlCommand cmd = new("GetLicenseClassByClassName", conn);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@LicenseClassClassName", ClassName);

                conn.Open();

                using SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    Model = new(reader.GetInt32(reader.GetOrdinal("License_Class_ID")),
                                ClassName,
                                reader.GetString(reader.GetOrdinal("Class_Description")),
                                reader.GetByte(reader.GetOrdinal("Minimum_Allowed_Age")),
                                reader.GetByte(reader.GetOrdinal("Validity_Length")),
                                reader.GetFloat(reader.GetOrdinal("Class_Fees")));
                }
            }
            catch (Exception)
            {
                Model = null;
            }
            return Model;
        }
        public static bool Add(LicenseClassModel Model)
        {
            try
            {
                using SqlConnection conn = new(ConnectionString.connectionString);
                using SqlCommand cmd = new("AddNewLicenseClass", conn);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ClassName", Model.ClassName);
                cmd.Parameters.AddWithValue("@ClassDescription", Model.ClassDescription);
                cmd.Parameters.AddWithValue("@MinimumAllowedAge", Model.MinimumAllowedAge);
                cmd.Parameters.AddWithValue("@DefaultValidityLength", Model.ValidityLength);
                cmd.Parameters.AddWithValue("@ClassFees", Model.ClassFees);

                var outputIdParam = new SqlParameter("@NewLicenseClassId", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output
                };

                cmd.Parameters.Add(outputIdParam);

                conn.Open();

                cmd.ExecuteNonQuery();
                Model.LicenseClassId = Convert.ToInt32(outputIdParam.Value);
            }
            catch (Exception)
            {

            }
            return Model.LicenseClassId != default;
        }
        public static bool Update(LicenseClassModel Model)
        {
            int RowsAffected = default;
            try
            {
                using SqlConnection conn = new(ConnectionString.connectionString);
                using SqlCommand cmd = new("UpdateLicenseClass", conn);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@LicenseClassID", Model.LicenseClassId);
                cmd.Parameters.AddWithValue("@ClassName", Model.ClassName);
                cmd.Parameters.AddWithValue("@ClassDescription", Model.ClassDescription);
                cmd.Parameters.AddWithValue("@MinimumAllowedAge", Model.MinimumAllowedAge);
                cmd.Parameters.AddWithValue("@DefaultValidityLength", Model.ValidityLength);
                cmd.Parameters.AddWithValue("@ClassFees", Model.ClassFees);

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
