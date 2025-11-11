namespace InhoudsOpgave.Models;

public static class ConsoleParserHelper
{
    public static int? ConvertToAge(this DateTime birthDate)
    {
        DateTime dateOfToday = DateTime.Now;
        int age;

        age = dateOfToday.Year - birthDate.Year;

        if (birthDate < dateOfToday.AddYears(age)) age--;
        return age;



    }
    public static string ConvertToNameFormat(this string input) 
    {
        if (string.IsNullOrWhiteSpace(input))
            return string.Empty;

        ReadOnlySpan<char> chars = input.Trim().ToLower();
        

        return string.Concat(chars[0].ToString().ToUpper(),
            chars.Slice(1));
    }
}

        
    



