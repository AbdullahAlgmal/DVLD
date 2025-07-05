namespace DVLD_DataAccess.Queries
{
    public class LicenseQuery
    {
        public static DataTable GetAll()
        {
            DataTable dt = new();
            try
            {
                using SqlCommandBuilder builder = SqlCommandBuilder.Instance().WithSqlQuery("SELECT * FROM Licenses");
                using SqlDataReader reader = builder.ExecuteReader();

                if (reader.HasRows) dt.Load(reader);
            }
            catch (Exception)
            {

            }
            return dt;
        }
        public static DataTable GetDriverLicenses(int DriverId)
        {
            DataTable dt = new();
            try
            {
                using SqlCommandBuilder builder = SqlCommandBuilder.Instance()
                                                                   .WithStoredProcedure("GetDriverLicenses")
                                                                   .WithParameter("@DriverID", DriverId);
                using SqlDataReader reader = builder.ExecuteReader();

                if (reader.HasRows) dt.Load(reader);
            }
            catch (Exception)
            {

            }
            return dt;
        }
        public static LicenseModel? Get(int Id)
        {
            LicenseModel? Model = null!;
            try
            {
                using SqlCommandBuilder builder = SqlCommandBuilder.Instance()
                                                                   .WithSqlQuery("SELECT * FROM Licenses WHERE Licens_Id = @LicenseID")
                                                                   .WithParameter("@LicenseID", Id);
                using SqlDataReader reader = builder.ExecuteReader();

                if (reader.Read())
                    Model = DataReaderMapper.MapToModel<LicenseModel>(reader);
            }
            catch (Exception)
            {
                Model = null!;
            }
            return Model;
        }
        public static bool Add(LicenseModel Model)
        {
            try
            {
                using SqlCommandBuilder builder = SqlCommandBuilder.Instance()
                                                                   .WithStoredProcedure("[AddNewLicense]")
                                                                   .AddStoredProcedureParametersDynamically(Model, nameof(Model.LicenseId), nameof(Model.IssueReasonText), nameof(Model.IsLicenseExpired))
                                                                   .WithOutputParameter("@NewLicensId", SqlDbType.Int);

                builder.ExecuteNonQuery();
                Model.LicenseId = Convert.ToInt32(builder.GetOutputParameterValue("@NewLicensId"));
            }
            catch (Exception)
            {

            }
            return Model.LicenseId != default;
        }
        public static bool Update(LicenseModel Model)
        {
            int RowsAffected = default;
            try
            {
                using SqlCommandBuilder builder = SqlCommandBuilder.Instance()
                                                                   .WithStoredProcedure("UpdateLicense")
                                                                   .AddStoredProcedureParametersDynamically(Model, nameof(Model.IssueReasonText), nameof(Model.IsLicenseExpired));
                RowsAffected = builder.ExecuteNonQuery();
            }
            catch (Exception)
            {

            }
            return RowsAffected > 0;
        }
        public static int GetActiveLicenseIDByPersonId(int PersonId, int LicenseClassId)
        {
            int LicenseId;

            try
            {
                using SqlCommandBuilder builder = SqlCommandBuilder.Instance()
                                                                   .WithStoredProcedure("GetActiveLicenseIDByPersonID")
                                                                   .AddStoredProcedureParametersDynamically(PersonId, LicenseClassId);
                LicenseId = Convert.ToInt32(builder.ExecuteScalar());
            }
            catch (Exception)
            {
                LicenseId = default;
            }

            return LicenseId;
        }
        public static bool DeactivateLicense(int LicenseId)
        {
            int RowsAffected = default;
            try
            {
                using SqlCommandBuilder builder = SqlCommandBuilder.Instance()
                                                                   .WithSqlQuery("UPDATE Licenses SET IsActive = 0 WHERE Licens_Id=@LicenseID")
                                                                   .WithParameter("@LicenseID", LicenseId);
                RowsAffected = builder.ExecuteNonQuery();
            }
            catch (Exception)
            {

            }
            return RowsAffected > 0;
        }
    }
}
