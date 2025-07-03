using System.Reflection;
using System.Text.RegularExpressions;

namespace DVLD_DataAccess.Queries
{
    public class SqlCommandBuilder : IDisposable
    {
        private static readonly Lazy<SqlCommandBuilder> _instance = new(() => new SqlCommandBuilder());
        private SqlConnection _connection;
        private SqlCommand _command;
        private readonly string _connectionString = ConnectionString.connectionString;
        private string _procedureName;
        private string _query;
        public static SqlCommandBuilder Instance() => _instance.Value; 

        private SqlCommandBuilder()
        {
        }
        private List<string> GetStoredProcedureParameterNames()
        {
            List<string> paramNames = new();
            try
            {
                using SqlConnection conn = new(_connectionString);
                using SqlCommand cmd = new("SELECT PARAMETER_NAME FROM INFORMATION_SCHEMA.PARAMETERS WHERE SPECIFIC_NAME = @ProcedureName AND PARAMETER_MODE IN ('IN')", conn);
                cmd.Parameters.AddWithValue("@ProcedureName", _procedureName);
                conn.Open();
                using SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string paramName = reader.GetString(0);
                    paramNames.Add(paramName);
                }
            }
            catch (Exception)
            {
                throw;
            }
            return paramNames;
        }
        private List<string> GetQueryParameterNames()
        {
            List<string> paramNames = new();
            var matches = Regex.Matches(_query, @"@\w+");

            foreach (Match match in matches)
            {
                string paramName = match.Value;
                if (!paramNames.Contains(paramName))
                    paramNames.Add(paramName);
            }
            return paramNames;
        }
        private bool IsNavigationProperty(PropertyInfo property)
        {
            Type type = property.PropertyType;

            if (type == typeof(string) || type.IsValueType)
                return false;

            return true;
        }
        private void ResetCommand()
        {
            _procedureName = null!;
            _query = null!;
            _command?.Dispose();
            _connection?.Dispose();
            _connection = new SqlConnection(_connectionString);
            _command = new SqlCommand { Connection = _connection };
        }

        public SqlCommandBuilder WithStoredProcedure(string procedureName)
        {
            ResetCommand();
            _command.CommandType = CommandType.StoredProcedure;
            _command.CommandText = procedureName;
            _procedureName = procedureName;
            return this;
        }
        public SqlCommandBuilder WithSqlQuery(string query)
        {
            ResetCommand();
            _command.CommandType = CommandType.Text;
            _command.CommandText = query;
            _query = query;
            return this;
        }

        public SqlCommandBuilder WithParameter(string name, object value)
        {
            _command.Parameters.AddWithValue(name, value);
            return this;
        }
        public SqlCommandBuilder WithOutputParameter(string name, SqlDbType dbType)
        {
            var param = new SqlParameter(name, dbType) { Direction = ParameterDirection.Output };
            _command.Parameters.Add(param);
            return this;
        }
        public SqlCommandBuilder AddStoredProcedureParametersDynamically(params object[] Params)
        {
            List<string> paramNames = GetStoredProcedureParameterNames();
            for (int i = 0; i < Params.Length && i < paramNames.Count; i++)
            {
                _command.Parameters.AddWithValue(paramNames[i], Params[i] ?? DBNull.Value);
            }
            return this;
        }
        public SqlCommandBuilder AddStoredProcedureParametersDynamically<T>(T Model,params string[] excludedProperties)
        {
            if(Model is null) return this;
            List<string> paramNames = GetStoredProcedureParameterNames();
            PropertyInfo[] properties = Model
                                       .GetType()
                                       .GetProperties(BindingFlags.Public | BindingFlags.Instance)
                                       .Where(p => !excludedProperties.Contains(p.Name) && !IsNavigationProperty(p))
                                       .ToArray();
            int paramIndex = 0;
            foreach (PropertyInfo property in properties)
            {
                if (paramIndex < paramNames.Count)
                {
                    _command.Parameters.AddWithValue(paramNames[paramIndex], property.GetValue(Model) ?? DBNull.Value);
                    paramIndex++;
                }
            }
            return this;
        }
        public SqlCommandBuilder AddQueryParametersDynamically(params object[] Params)
        {
            List<string> paramNames = GetQueryParameterNames();
            for (int i = 0; i < Params.Length && i < paramNames.Count; i++)
            {
                _command.Parameters.AddWithValue(paramNames[i], Params[i] ?? DBNull.Value);
            }
            return this;
        }
        public SqlCommandBuilder AddQueryParametersDynamically<T>(T Model, string[] excludedProperties = null)
        {
            if (Model is null) return this;
            List<string> paramNames = GetQueryParameterNames();
            PropertyInfo[] properties = Model
                                       .GetType()
                                       .GetProperties(BindingFlags.Public | BindingFlags.Instance)
                                       .Where(p => !excludedProperties.Contains(p.Name) && !IsNavigationProperty(p))
                                       .ToArray();
            int paramIndex = 0;
            foreach (PropertyInfo property in properties)
            {
                if (paramIndex < paramNames.Count)
                {
                    _command.Parameters.AddWithValue(paramNames[paramIndex], property.GetValue(Model) ?? DBNull.Value);
                    paramIndex++;
                }
            }
            return this;
        }

        public SqlCommand Build()
        {
            return _command;
        }
        public SqlConnection GetConnection()
        {
            return _connection;
        }
        public SqlCommandBuilder OpenConnection()
        {
            if (_connection.State != ConnectionState.Open)
                _connection.Open();
            return this;
        }
        public object GetOutputParameterValue(string name)
        {
            return _command.Parameters[name].Value;
        }

        public object ExecuteScalar()
        {
            OpenConnection();
            return _command.ExecuteScalar();
        }
        public int ExecuteNonQuery()
        {
            OpenConnection();
            return _command.ExecuteNonQuery();
        }
        public SqlDataReader ExecuteReader()
        {
            OpenConnection();
            return _command.ExecuteReader(CommandBehavior.CloseConnection);
        }
        
        public void Dispose()
        {
            _command?.Dispose();
            _connection?.Dispose();
        }
    }
}
