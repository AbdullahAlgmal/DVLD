using System.ComponentModel;

namespace DVLD_DataAccess.Queries
{
    public class DetainedLicenseQuery
    {
        public static DataTable GetAll()
        {
            DataTable dt = new();
            try
            {
                using SqlCommandBuilder builder = SqlCommandBuilder.Instance()
                                                                   .WithSqlQuery("select * from DetaineLicenses_View order by IsReleased ,Detained_Lincens_Id;");
                using SqlDataReader reader = builder.ExecuteReader();

                if (reader.HasRows) dt.Load(reader);
            }
            catch (Exception)
            {

            }
            return dt;
        }
        public static DetainedLicenseModel? Get(int Id)
        {
            DetainedLicenseModel Model = null!;
            try
            {
                using SqlCommandBuilder builder = SqlCommandBuilder.Instance()
                                                                   .WithSqlQuery("SELECT * FROM Detained_Licenses WHERE Detained_Lincens_Id = @DetainID")
                                                                   .WithParameter("@DetainID", Id);
                using SqlDataReader reader = builder.ExecuteReader();

                if (reader.Read())
                    Model = DataReaderMapper.MapToModel<DetainedLicenseModel>(reader);
            }
            catch (Exception)
            {
                Model = null!;
            }
            return Model;
        }
        public static DetainedLicenseModel? GetByLicenseId(int LicenseId)
        {
            DetainedLicenseModel Model = null!;
            try
            {
                using SqlCommandBuilder builder = SqlCommandBuilder.Instance()
                                                                   .WithSqlQuery("SELECT top 1 * FROM Detained_Licenses WHERE Licens_Id = @LicenseID order by Detained_Lincens_Id desc")
                                                                   .WithParameter("@LicenseID", LicenseId);
                using SqlDataReader reader = builder.ExecuteReader();

                if (reader.Read())
                    Model = DataReaderMapper.MapToModel<DetainedLicenseModel>(reader);
            }
            catch (Exception)
            {
                Model = null!;
            }
            return Model;
        }
        public static bool Add(DetainedLicenseModel Model)
        {
            try
            {
                using SqlCommandBuilder builder = SqlCommandBuilder.Instance()
                                                                   .WithStoredProcedure("AddNewDetainedLicense")
                                                                   .AddStoredProcedureParametersDynamically(Model, nameof(Model.DetainedLicenseId))
                                                                   .WithOutputParameter("@NewDetainedLicensId", SqlDbType.Int);

                builder.ExecuteNonQuery();
                Model.DetainedLicenseId = Convert.ToInt32(builder.GetOutputParameterValue("@NewDetainedLicensId"));
            }
            catch (Exception)
            {

            }
            return Model.DetainedLicenseId != default;
        }
        public static bool Update(DetainedLicenseModel Model)
        {
            int RowsAffected = default;
            try
            {
                using SqlCommandBuilder builder = SqlCommandBuilder.Instance()
                                                                   .WithStoredProcedure("UpdateDetainedLicense")
                                                                   .AddStoredProcedureParametersDynamically(Model);
                RowsAffected = builder.ExecuteNonQuery();
            }
            catch (Exception)
            {

            }
            return RowsAffected > 0;
        }
        public static bool ReleaseDetainedLicense(int DetainId, int ReleasedByUserId, int ReleaseApplicationId)
        {
            int RowsAffected = default;
            try
            {
                using SqlCommandBuilder builder = SqlCommandBuilder.Instance()
                                                                   .WithStoredProcedure("ReleaseDetainedLicense")
                                                                   .AddStoredProcedureParametersDynamically(DetainId, DateTime.Now, ReleasedByUserId, ReleaseApplicationId);
                RowsAffected = builder.ExecuteNonQuery();
            }
            catch (Exception)
            {

            }
            return RowsAffected > 0;
        }
        public static bool IsLicenseDetained(int LicenseId)
        {
            bool isFound = false;

            try
            {
                using SqlCommandBuilder builder = SqlCommandBuilder.Instance()
                                                                   .WithSqlQuery("select IsDetained=1 from Detained_Licenses  where Licens_Id=@LicenseID and IsReleased=0;")
                                                                   .WithParameter("@LicenseID", LicenseId);
                isFound = Convert.ToBoolean(builder.ExecuteScalar());
            }
            catch (Exception)
            {
                isFound = false;
            }

            return isFound;
        }
    }
}
