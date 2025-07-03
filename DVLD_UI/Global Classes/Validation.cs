using System.Text.RegularExpressions;

namespace DVLD_UI.Global_Classes
{
    public class Validation
    {
        public static bool ValidateEmail(string Email) => Regex.IsMatch(Email,@"^[a-zA-Z0-9._-]+@\w+(?:\.[a-zA-Z0-9-]+)*$");

        public static bool ValidateInteger(string Number) => Regex.IsMatch(@"^[0-9]*$", Number);

        public static bool ValidateFloat(string Number) => Regex.IsMatch(@"^[0-9]*(?:\.[0-9]*)?$", Number);

        public static bool IsNumber(string Number) => (ValidateInteger(Number) || ValidateFloat(Number));
    }
}
