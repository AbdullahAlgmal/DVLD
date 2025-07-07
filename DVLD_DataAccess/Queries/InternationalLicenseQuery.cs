namespace DVLD_DataAccess.Queries
{
    public class InternationalLicenseQuery
    {
        public static DataTable GetAll()
        {
            DataTable dt = new();
            try
            {
                using SqlCommandBuilder builder = SqlCommandBuilder.Instance()
                                                                   .WithStoredProcedure("GetAllInternationalLicenses");
                using SqlDataReader reader = builder.ExecuteReader();

                if (reader.HasRows) dt.Load(reader);
            }
            catch (Exception)
            {

            }
            return dt;
        }
        public static DataTable GetDriverInternationalLicenses(int DriverId)
        {
            DataTable dt = new();
            try
            {
                using SqlCommandBuilder builder = SqlCommandBuilder.Instance()
                                                                   .WithStoredProcedure("GetDriverInternationalLicenses")
                                                                   .AddStoredProcedureParametersDynamically(DriverId);
                using SqlDataReader reader = builder.ExecuteReader();

                if (reader.HasRows) dt.Load(reader);
            }
            catch (Exception)
            {

            }
            return dt;
        }
        public static InternationalLicenseModel? Get(int Id)
        {
            InternationalLicenseModel Model = null!;
            try
            {
                using SqlCommandBuilder builder = SqlCommandBuilder.Instance()
                                                                   .WithSqlQuery("SELECT * FROM International_Licenses WHERE International_License_Id =@InternationalLicenseID")
                                                                   .WithParameter("@InternationalLicenseID", Id);
                using SqlDataReader reader = builder.ExecuteReader();

                if (reader.Read())
                    Model = DataReaderMapper.MapToModel<InternationalLicenseModel>(reader);
            }
            catch (Exception)
            {
                Model = null!;
            }
            return Model;
        }
        public static bool Add(InternationalLicenseModel Model)
        {
            try
            {
                using SqlCommandBuilder builder = SqlCommandBuilder.Instance()
                                                                   .WithStoredProcedure("AddNewInternationalLicense")
                                                                   .AddStoredProcedureParametersDynamically(Model, nameof(Model.InternationalLicenseId))
                                                                   .WithOutputParameter("@NewInternationalLicenseId", SqlDbType.Int);

                builder.ExecuteNonQuery();
                Model.InternationalLicenseId = Convert.ToInt32(builder.GetOutputParameterValue("@NewInternationalLicenseId"));
            }
            catch (Exception)
            {

            }
            return Model.InternationalLicenseId != default;
        }
        public static bool Update(InternationalLicenseModel Model)
        {
            int RowsAffected = default;
            try
            {
                using SqlCommandBuilder builder = SqlCommandBuilder.Instance()
                                                                   .WithStoredProcedure("UpdateInternationalLicense")
                                                                   .AddStoredProcedureParametersDynamically(Model);
                RowsAffected = builder.ExecuteNonQuery();
            }
            catch (Exception)
            {

            }
            return RowsAffected > 0;
        }
        public static int GetActiveInternationalLicenseIDByDriverID(int DriverID)
        {
            int LicenseId;

            try
            {
                using SqlCommandBuilder builder = SqlCommandBuilder.Instance()
                                                                   .WithStoredProcedure("GetAllInternationalLicenses")
                                                                   .AddStoredProcedureParametersDynamically(DriverID);
                LicenseId = Convert.ToInt32(builder.ExecuteScalar());
            }
            catch (Exception)
            {
                LicenseId = default;
            }

            return LicenseId;
        }
    }
}
