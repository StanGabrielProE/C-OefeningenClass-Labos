using InhoudsOpgave.Models;
using System.Globalization;
using System.Numerics;
using static System.Console;

namespace InhoudsOpgave.Helpers;

public static class ConsoleUiHelper<T> where T : INumber<T>
{



    public static T ConvertToNumber(Func<string> userInput, Predicate<string> condition, string? errorMsg = null)
    {
        string input = userInput();
        T result = T.Zero;


        while (!condition(input))
        {

            errorMsg.PrintToConsole();
            input = userInput();

        }

        result = T.Parse(input, CultureInfo.InvariantCulture);
        return result;
    }


}
public static class ConsoleUiHelper
{
    public static DateTime ConvertToDateTime(this Func<string> userInput, string? errorMsg = null)
    {

        DateTime dateOfBirth;
        string input = userInput();
        while (!DateTime.TryParseExact(input.Trim(), "dd MM yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dateOfBirth))
        {
            errorMsg.PrintToConsole();
            input = userInput();
        }
        return dateOfBirth;
    }

    public static void PrintToConsole(this string? str)
    {
        ForegroundColor = ConsoleColor.Red;
        WriteLine(str);
        ResetColor();
    }

    public static string NameValidator(this Func<string> input, string? errorMsg = null)
    {
        string name = input();

        while (string.IsNullOrEmpty(name))
        {
            errorMsg.PrintToConsole();
            name = input();
        }
        return name;
    }
    public static void ShowDetails(this Employee employee, decimal percentage = 0m)
    {

        Clear();
        ForegroundColor = ConsoleColor.DarkYellow;
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
        ResetColor();
    }
}