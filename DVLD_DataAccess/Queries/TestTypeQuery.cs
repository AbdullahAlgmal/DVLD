namespace DVLD_DataAccess.Queries
{
    public class TestTypeQuery
    {
        public static DataTable GetAll()
        {
            DataTable dt = new();
            try
            {
                using SqlConnection conn = new(ConnectionString.connectionString);
                using SqlCommand cmd = new("GetAllTestTypes", conn);

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
        public static TestTypeModel? Get(int Id)
        {
            TestTypeModel? Model = null;
            try
            {
                using SqlConnection conn = new(ConnectionString.connectionString);
                using SqlCommand cmd = new("GetTestTypeById", conn);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@TestTypeId", Id);

                conn.Open();

                using SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    Model = new(Id,
                                reader.GetString(reader.GetOrdinal("Test_Type_Title")),
                                reader.GetString(reader.GetOrdinal("Test_Type_Description")),
                                Convert.ToSingle(reader.GetDecimal(reader.GetOrdinal("Test_Type_Fees"))));
                }
            }
            catch (Exception)
            {
                Model = null;
            }
            return Model;
        }
        public static bool Update(TestTypeModel Model)
        {
            int RowsAffected = default;
            try
            {
                using SqlConnection conn = new(ConnectionString.connectionString);
                using SqlCommand cmd = new("UpdateTestType", conn);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@TestTypeID", Model.Id);
                cmd.Parameters.AddWithValue("@TestTypeTitle", Model.Title);
                cmd.Parameters.AddWithValue("@TestTypeDescription", Model.Description);
                cmd.Parameters.AddWithValue("@TestTypeFees", Model.Fees);

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
