namespace InhoudsOpgave.Helpers;

public static class ConsoleParserHelper
{
    /// <summary>
    /// Calculates the age and returns it as Int32
    /// </summary>
    /// <param name="birthDate">Represents the date of birth in DateTime Format</param>
    /// <returns></returns>
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






