using System.Globalization;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace InhoudsOpgave.Helpers;

public static class ConsoleUiHelper<T> where T:INumber<T>
{



    public  static T ConvertToNumber(Func<string> userInput ,Predicate<string>condition,string? errorMsg = null)
    {
        string input = userInput();
        T result = T.Zero;


        while (!condition(input)) 
        {

            errorMsg.PrintToConsole();
             input = userInput();
        
        } 

        result = T.Parse(input,CultureInfo.InvariantCulture);
        return result;
    }


}
public static class ConsoleUiHelper
{
    public static DateTime ConvertToDateTime(this Func<string> userInput, string? errorMsg = null)
    {
        Console.WriteLine(errorMsg);
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
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(str);
        Console.ResetColor();
    }

    public static string NameValidator(this Func<string> input, string? errorMsg=null)
    {
        string name = input();

        while (string.IsNullOrEmpty(name))
        {
            errorMsg.PrintToConsole();
            name = input();
        }
        return name;
    }
}