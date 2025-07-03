namespace DVLD_DataAccess.Queries
{
    public class UserQuery
    {
        public static DataTable GetAll()
        {
            DataTable dt = new();
            try
            {
                using SqlCommandBuilder builder = SqlCommandBuilder.Instance().WithStoredProcedure("GetAllUsers");
                using SqlDataReader reader = builder.ExecuteReader();

                if (reader.HasRows) dt.Load(reader);
            }
            catch (Exception)
            {

            }
            return dt;
        }
        public static UserModel? Get(int UserId)
        {
            UserModel? Model = null;
            try
            {
                using SqlConnection conn = new(ConnectionString.connectionString);
                using SqlCommand cmd = new("GetUserById", conn);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@UserId", UserId);

                conn.Open();

                using SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                    Model = DataReaderMapper.MapToModel<UserModel>(reader);
            }
            catch (Exception)
            {
                Model = null;
            }
            return Model;
        }
        public static UserModel? Get(string UserName, string Password)
        {
            UserModel? Model = null;
            try
            {
                using SqlConnection conn = new(ConnectionString.connectionString);
                using SqlCommand cmd = new("GetUserByUserNameAndPassword", conn);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@UserName", UserName);
                cmd.Parameters.AddWithValue("@Password", Password);

                conn.Open();

                using SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    Model = new(reader.GetInt32(reader.GetOrdinal("User_Id")),
                                UserName,
                                Password,
                                reader.GetBoolean(reader.GetOrdinal("IsActive")),
                                reader.GetInt32(reader.GetOrdinal("Person_Id")));
                }
            }
            catch (Exception)
            {
                Model = null;
            }
            return Model;
        }
        public static UserModel? GetForPersonId(int PersonId)
        {
            UserModel? Model = null;
            try
            {
                using SqlConnection conn = new(ConnectionString.connectionString);
                using SqlCommand cmd = new("GetUserByPersonId", conn);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PersonId", PersonId);

                conn.Open();

                using SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    Model = new(reader.GetInt32(reader.GetOrdinal("User_Id")),
                                reader.GetString(reader.GetOrdinal("User_Name")),
                                reader.GetString(reader.GetOrdinal("Password")),
                                reader.GetBoolean(reader.GetOrdinal("IsActive")),
                                PersonId
                                );
                }
            }
            catch (Exception)
            {
                Model = null;
            }
            return Model;
        }
        public static bool Add(UserModel Model)
        {
            try
            {
                using SqlConnection conn = new(ConnectionString.connectionString);
                using SqlCommand cmd = new("AddNewUser", conn);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@UserName", Model.UserName);
                cmd.Parameters.AddWithValue("@Password", Model.Password);
                cmd.Parameters.AddWithValue("@PersonId", Model.PersonId);
                cmd.Parameters.AddWithValue("@IsActive", Model.IsActive);

                var outputIdParam = new SqlParameter("@NewUserId", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output
                };

                cmd.Parameters.Add(outputIdParam);

                conn.Open();

                cmd.ExecuteNonQuery();
                Model.UserId = Convert.ToInt32(outputIdParam.Value);
            }
            catch (Exception)
            {

            }
            return Model.UserId != default;
        }
        public static bool Update(UserModel Model)
        {
            int RowsAffected = default;
            try
            {
                using SqlConnection conn = new(ConnectionString.connectionString);
                using SqlCommand cmd = new("UpdateUser", conn);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@UserId", Model.UserId);
                cmd.Parameters.AddWithValue("@UserName", Model.UserName);
                cmd.Parameters.AddWithValue("@Password", Model.Password);
                cmd.Parameters.AddWithValue("@PersonId", Model.PersonId);
                cmd.Parameters.AddWithValue("@IsActive", Model.IsActive);

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
                using SqlCommand cmd = new("DeleteUserById", conn);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@UserId", Id);

                conn.Open();

                RowsAffected = cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

            }
            return RowsAffected > 0;
        }
        public static bool Exist(int UserId)
        {
            bool isFound = false;

            try
            {
                using SqlConnection connection = new SqlConnection(ConnectionString.connectionString);
                using SqlCommand command = new SqlCommand("SELECT Found=1 FROM Users WHERE User_Id = @UserId", connection);

                command.Parameters.AddWithValue("@UserId", UserId);

                connection.Open();

                isFound = Convert.ToBoolean(command.ExecuteScalar());
            }
            catch (Exception )
            {
                isFound = false;
            }

            return isFound;
        }
        public static bool Exist(string UserName)
        {
            bool isFound = false;
            try
            {
                using SqlConnection connection = new SqlConnection(ConnectionString.connectionString);
                using SqlCommand command = new SqlCommand("SELECT Found=1 FROM Users WHERE User_Name = @UserName", connection);

                command.Parameters.AddWithValue("@UserName", UserName);

                connection.Open();

                isFound = Convert.ToBoolean(command.ExecuteScalar());
            }
            catch (Exception )
            {
                isFound = false;
            }

            return isFound;
        }
        public static bool ExistForPersonId(int PersonId)
        {
            bool isFound = false;
            try
            {
                using SqlConnection connection = new SqlConnection(ConnectionString.connectionString);
                using SqlCommand command = new SqlCommand("SELECT Found=1 FROM Users WHERE Person_Id = @PersonId", connection);

                command.Parameters.AddWithValue("@PersonId", PersonId);

                connection.Open();

                isFound = Convert.ToBoolean(command.ExecuteScalar());
            }
            catch (Exception )
            {
                isFound = false;
            }

            return isFound;
        }
        public static bool ChangePassword(int UserId, string NewPassword)
        {
            int RowsAffected = default;
            try
            {
                using SqlConnection conn = new(ConnectionString.connectionString);
                using SqlCommand cmd = new("Update Users set Password = @Password where User_Id = @UserId", conn);

                cmd.Parameters.AddWithValue("@Password", NewPassword);
                cmd.Parameters.AddWithValue("@UserId", UserId);

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
