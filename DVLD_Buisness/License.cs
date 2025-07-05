namespace DVLD_Buisness
{
    public class License
    {
        public enum enIssueReason { FirstTime = 1, Renew = 2, DamagedReplacement = 3, LostReplacement = 4 };
        static public DataTable GetAll() => LicenseQuery.GetAll();
        static public DataTable GetDriverLicenses(int DriverId) => LicenseQuery.GetDriverLicenses(DriverId);
        static public LicenseModel? Find(int Id) => LicenseQuery.Get(Id);
        static public int GetActiveLicenseIDByPersonId(int PersonId, int LicenseClassId) => LicenseQuery.GetActiveLicenseIDByPersonId(PersonId, LicenseClassId);
        static public bool IsLicenseExistByPersonID(int PersonId, int LicenseClassId) => LicenseQuery.GetActiveLicenseIDByPersonId(PersonId, LicenseClassId) != default;
        static public bool Add(LicenseModel Model) => LicenseQuery.Add(Model);
        static public bool Update(LicenseModel Model) => LicenseQuery.Update(Model);
        static public bool DeactivateLicense(int Id) => LicenseQuery.DeactivateLicense(Id);
        public LicenseModel? RenewLicense(string Notes, int CreatedByUserId, LicenseModel Model)
        {
            ApplicationModel Application = new (default,
                                                Model?.Driver?.PersonId
                                                ?? 0, 
                                                DateTime.Now,
                                                (byte)Application0.enApplicationType.RenewDrivingLicense,
                                                (byte)Application0.enApplicationStatus.Completed,
                                                DateTime.Now,
                                                ApplicationTypeQuery.Get((byte)Application0.enApplicationType.RenewDrivingLicense)?.Fees ?? 0,
                                                CreatedByUserId);
            if (!Application0.Add(Application))
                return null;

            LocalDrivingLicensApplicationModel localDrivingLicensApplication = new(default,
                                                Application.ApplicationId,
                                                Model?.LocalDrivingLicenseApplication?.LicenseClassId ?? 0);
            if (!LocalDrivingLicensApplicationQuery.Add(localDrivingLicensApplication))
                return null;

            LicenseModel NewLicense = new()
            {
                IssueDate = DateTime.Now,
                ExpirationDate = DateTime.Now.AddYears(Model?.LocalDrivingLicenseApplication?.LicenseClass?.ValidityLength ?? 5),
                Notes = Notes,
                IsActive = true,
                PaidFees = Model?.LocalDrivingLicenseApplication?.LicenseClass?.ClassFees ?? 0,
                IssueReason = (byte)License.enIssueReason.Renew,
                UserId = CreatedByUserId,
                DriverId = Model?.DriverId ?? 0,
                LocalDrivingLicenseApplicationId = localDrivingLicensApplication.Id
            };

            if (!LicenseQuery.Add(NewLicense))
                return null;

            LicenseQuery.DeactivateLicense(Model?.LicenseId ?? 0);

            return NewLicense;
        }
        public LicenseModel? Replace(enIssueReason IssueReason, int CreatedByUserId, LicenseModel Model)
        {
            ApplicationModel Application = new(default,
                                                Model?.Driver?.PersonId
                                                ?? 0,
                                                DateTime.Now,
                                                (IssueReason == enIssueReason.DamagedReplacement) ?
                                                (int)Application0.enApplicationType.ReplaceDamagedDrivingLicense :
                                                (int)Application0.enApplicationType.ReplaceLostDrivingLicense,
                                                (byte)Application0.enApplicationStatus.Completed,
                                                DateTime.Now,
                                                ApplicationTypeQuery.Get((byte)Application0.enApplicationType.RenewDrivingLicense)?.Fees ?? 0,
                                                CreatedByUserId);
            if (!Application0.Add(Application))
                return null;

            LocalDrivingLicensApplicationModel localDrivingLicensApplication = new(default,
                                                Application.ApplicationId,
                                                Model?.LocalDrivingLicenseApplication?.LicenseClassId ?? 0);
            if (!LocalDrivingLicensApplicationQuery.Add(localDrivingLicensApplication))
                return null;

            LicenseModel NewLicense = new()
            {
                IssueDate = DateTime.Now,
                ExpirationDate = Model!.ExpirationDate,
                Notes = Model?.Notes,
                IsActive = true,
                PaidFees = 0,
                IssueReason = (byte)License.enIssueReason.Renew,
                UserId = CreatedByUserId,
                DriverId = Model?.DriverId ?? 0,
                LocalDrivingLicenseApplicationId = localDrivingLicensApplication.Id
            };

            if (!LicenseQuery.Add(NewLicense))
                return null;

            LicenseQuery.DeactivateLicense(Model?.LicenseId ?? 0);

            return NewLicense;
        }
    }
}
