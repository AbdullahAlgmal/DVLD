namespace DVLD_DataAccess.Queries
{
    public class PersonQuery
    {
        public static DataTable GetAll()
        {
            DataTable dt = new();
            try
            {
                using SqlCommandBuilder builder = SqlCommandBuilder.Instance().WithStoredProcedure("GetAllPeople");
                using SqlDataReader reader = builder.ExecuteReader();

                if (reader.HasRows) dt.Load(reader);
            }
            catch (Exception) 
            {

            }
            return dt;
        }
        public static PersonModel Get(int Id)
        {
            PersonModel Model = null!;
            try
            {
                using SqlCommandBuilder builder = SqlCommandBuilder.Instance().WithStoredProcedure("GetPersonById").WithParameter("@PersonId", Id);
                using SqlDataReader reader = builder.ExecuteReader();

                if (reader.Read())
                    Model = DataReaderMapper.MapToModel<PersonModel>(reader);
            }
            catch (Exception)
            {
                Model = null!;
            }
            return Model;
        }
        public static PersonModel Get(string NationalNumber)
        {
            PersonModel Model = null!;
            try
            {
                using SqlCommandBuilder builder = SqlCommandBuilder.Instance().WithStoredProcedure("GetPersonByNationalNumber").WithParameter("@NationalNumber", NationalNumber);
                using SqlDataReader reader = builder.ExecuteReader();

                if (reader.Read())
                    Model = DataReaderMapper.MapToModel<PersonModel>(reader);
            }
            catch (Exception)
            {
                Model = null!;
            }
            return Model;
        }
        public static bool Add(PersonModel Model)
        {
            try
            {
                using SqlCommandBuilder builder = SqlCommandBuilder.Instance()
                                                                   .WithStoredProcedure("AddNewPerson")
                                                                   .AddStoredProcedureParametersDynamically(Model, nameof(Model.PersonId), nameof(Model.FullName))
                                                                   .WithOutputParameter("@NewPersonId", SqlDbType.Int);

                builder.ExecuteNonQuery();
                Model.PersonId = Convert.ToInt32(builder.GetOutputParameterValue("@NewPersonId"));
            }
            catch (Exception)
            {

            }
            return Model.PersonId != default;
        }
        public static bool Update(PersonModel Model)
        {
            int RowsAffected = default;
            try
            {
                using SqlCommandBuilder builder = SqlCommandBuilder.Instance()
                                                                   .WithStoredProcedure("UpdatePerson")
                                                                   .AddStoredProcedureParametersDynamically(Model, nameof(Model.FullName));
                RowsAffected = builder.ExecuteNonQuery();
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
                using SqlCommandBuilder builder = SqlCommandBuilder.Instance().WithStoredProcedure("DeletePersonById").WithParameter("@PersonId", Id);
                RowsAffected = builder.ExecuteNonQuery();
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
                using SqlCommandBuilder builder = SqlCommandBuilder.Instance()
                                                                   .WithSqlQuery("SELECT Found=1 FROM Persons WHERE Person_ID = @PersonID")
                                                                   .WithParameter("@PersonId", Id);
                isFound = Convert.ToBoolean(builder.ExecuteScalar());
            }
            catch (Exception ex)
            {
                isFound = false;
            }

            return isFound;
        }
        public static bool Exist(string NationalNumber)
        {
            bool isFound = false;
            try
            {
                using SqlCommandBuilder builder = SqlCommandBuilder.Instance()
                                                                   .WithSqlQuery("SELECT Found=1 FROM Persons WHERE National_Number = @NationalNumber")
                                                                   .WithParameter("@NationalNumber", NationalNumber);
                isFound = Convert.ToBoolean(builder.ExecuteScalar());
            }
            catch (Exception ex)
            {
                isFound = false;
            }

            return isFound;
        }
    }
}
