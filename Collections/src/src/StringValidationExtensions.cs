
using System.Text.RegularExpressions;

namespace src;

public static class StringValidationExtensions
{
    public static bool IsValidEgyptianPhone(this string value)
    {
        if(value is null || string.IsNullOrWhiteSpace(value)) return false;
        return Regex.IsMatch(value, @"^(01[0125]\d{8}|\+201\d{9})$"); 
    }

    public static bool IsValidEgyptianNationalId(this string id)
    {
        if (id is null || string.IsNullOrWhiteSpace(id)) return false;
        return Regex.IsMatch(id, @"^[23]\d{13}$");
    }
}
