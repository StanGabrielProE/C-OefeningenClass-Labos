using InhoudsOpgave.Models;
using static System.Console;

namespace InhoudsOpgave.Helpers;

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
    public static void ShowDetails(this Employee employee, decimal percentage = 0m)
    {

        Clear();
        OutputEncoding = Encoding.UTF8;
        if (percentage != 0)
        {
            WriteLine($"Opslag percentage: {percentage}");
        }
        WriteLine("----------------------------------------------");
        WriteLine($"Werknemer: {employee.FirstName} {employee.LastName}");

        WriteLine($"Geboortedatum: {employee.DateOfBirth.ToString("dddd dd MMMM yyyy")} ({employee.Age})");
        WriteLine($"Salaris: {Math.Round(employee.Salaris, 2):C}");
        WriteLine("----------------------------------------------");
        WriteLine(employee.ToString());
    }
}

        
    



