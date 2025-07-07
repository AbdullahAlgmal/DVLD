using System.ComponentModel;

namespace DVLD_Buisness
{
    public class LocalDrivingLicensApplication
    {
        static public DataTable GetAll() => LocalDrivingLicensApplicationQuery.GetAll();
        static public LocalDrivingLicensApplicationModel? Find(int Id) => LocalDrivingLicensApplicationQuery.Get(Id);
        static public LocalDrivingLicensApplicationModel? FindByApplicationId(int ApplicationId) => LocalDrivingLicensApplicationQuery.GetByApplicationId(ApplicationId);
        static public TestModel? GetLastTestPerTestType(int LocalDrivingLicenseApplicationId, byte LicenseClassId, int PersonId, byte TestTypeId) => TestQuery.GetLastTestByPersonAndTestTypeAndLicenseClass(LocalDrivingLicenseApplicationId, LicenseClassId, PersonId, TestTypeId);
        static public bool Add(LocalDrivingLicensApplicationModel Model) => LocalDrivingLicensApplicationQuery.Add(Model);
        static public bool Update(LocalDrivingLicensApplicationModel Model) => LocalDrivingLicensApplicationQuery.Update(Model);
        static public byte GetPassedTestCount(int LocalDrivingLicensApplicationId) => TestQuery.GetPassedTestCount(LocalDrivingLicensApplicationId);
        static public int GetActiveLicenseId(int PersonId, int LicenseClassId) => LicenseQuery.GetActiveLicenseIDByPersonId(PersonId, LicenseClassId);
        static public bool DoesAttendTestType(int LocalDrivingLicenseApplicationId, byte TestTypeId) => LocalDrivingLicensApplicationQuery.DoesAttendTestType(LocalDrivingLicenseApplicationId, TestTypeId);
        static public bool DoesPassTestType(int LocalDrivingLicenseApplicationId, byte TestTypeId) => LocalDrivingLicensApplicationQuery.DoesPassTestType(LocalDrivingLicenseApplicationId, TestTypeId);
        static public bool IsThereAnActiveScheduledTest(int LocalDrivingLicenseApplicationId, byte TestTypeId) => LocalDrivingLicensApplicationQuery.IsThereAnActiveScheduledTest(LocalDrivingLicenseApplicationId, TestTypeId);
        static public bool PassedAllTests(int LocalDrivingLicenseApplicationId) => Test.PassedAllTests(LocalDrivingLicenseApplicationId);
        static public byte TotalTrialsPerTest(int LocalDrivingLicenseApplicationId, byte TestTypeId) => LocalDrivingLicensApplicationQuery.TotalTrialsPerTest(LocalDrivingLicenseApplicationId, TestTypeId);
        static public int IssueLicenseForTheFirtTime(string Notes, int CreatedByUserID, LocalDrivingLicensApplicationModel Model)
        {
            int DriverID;

            DriverModel? driver = Driver.FindForPersonId(Model.ApplicationId);

            if (driver is null)
            {
                driver = new(default, Model.Application?.PersonId ?? 0, CreatedByUserID, DateTime.Now);

                if (Driver.Add(driver))
                    DriverID = driver.DriverId;
                else
                    return default;
            }
            else
                DriverID = driver.DriverId;

            LicenseModel License = new()
            {
                LocalDrivingLicenseApplicationId = Model.Id,
                DriverId = DriverID,
                IssueDate = DateTime.Now,
                ExpirationDate = DateTime.Now.AddYears(Model.LicenseClass?.ValidityLength ?? 0),
                Notes = Notes,
                IsActive = true,
                PaidFees = Model.LicenseClass?.ClassFees ?? 0,
                IssueReason = (byte)License0.enIssueReason.FirstTime,
                UserId = CreatedByUserID
            };

            if (License0.Add(License))
            {
                Application0.Complete(Model.ApplicationId);
                return License.LicenseId;
            }
            else
                return default;
        }
    }
}
