using DVLD_DataAccess.Modles;

namespace DVLD_DataAccess.Queries
{
    public class CountryQuery
    {
        public static DataTable GetAll()
        {
            DataTable dt = new();
            try
            {
                using SqlConnection conn = new(ConnectionString.connectionString);
                using SqlCommand cmd = new("GetAllCountries", conn);

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
        public static CountryModel Get(byte Id)
        {
            CountryModel Model = null!;
            try
            {
                using SqlConnection conn = new(ConnectionString.connectionString);
                using SqlCommand cmd = new("GetCountryById", conn);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CountryID", Id);

                conn.Open();

                using SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read()) 
                    Model = new(Id, reader.GetString(reader.GetOrdinal("Name")));
            }
            catch (Exception)
            {
                Model = null!;
            }
            return Model;
        }
        public static CountryModel Get(string Name)
        {
            CountryModel Model = null!;
            try
            {
                using SqlConnection conn = new(ConnectionString.connectionString);
                using SqlCommand cmd = new("GetCountryByName", conn);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CountryName", Name);

                conn.Open();

                using SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                    Model = new(Convert.ToByte(reader.GetInt32(reader.GetOrdinal("Country_Id"))), reader.GetString(reader.GetOrdinal("Name")));
            }
            catch (Exception)
            {
                Model = null!;
            }
            return Model;
        }
    }
}
