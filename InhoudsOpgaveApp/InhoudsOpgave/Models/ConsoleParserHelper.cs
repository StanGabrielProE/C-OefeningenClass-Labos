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
}

        
    



