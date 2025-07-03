using System.Diagnostics.CodeAnalysis;

namespace DVLD_DataAccess.Models
{
    public class LicenseClassModel
    {
        public int LicenseClassId { set; get; }
        public required string ClassName { set; get; }
        public required string ClassDescription { set; get; }
        public byte MinimumAllowedAge { set; get; }
        public byte ValidityLength { set; get; }
        public float ClassFees { set; get; }

        [SetsRequiredMembers]
        public LicenseClassModel(
            int licenseClassId,
            string className,
            string classDescription,
            byte minimumAllowedAge,
            byte validityLength,
            float classFees)
        {
            LicenseClassId = licenseClassId;
            ClassName = className;
            ClassDescription = classDescription;
            MinimumAllowedAge = minimumAllowedAge;
            ValidityLength = validityLength;
            ClassFees = classFees;
        }
    }
}
