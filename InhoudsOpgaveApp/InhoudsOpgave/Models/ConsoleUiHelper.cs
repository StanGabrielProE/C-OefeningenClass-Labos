using System.Globalization;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace InhoudsOpgave.Models;

public static class ConsoleUiHelper<T> where T:INumber<T>
{



    public  static T ConvertToNumber(Func<string> userInput)
    {
        T result;
        string input = userInput();
        while (!T.TryParse(input.Trim(),CultureInfo.InvariantCulture, out result))
        {
            Console.WriteLine($"Voer een geldig number in. Input: {userInput} past voor deze situatie niet toe");
            input = userInput();
        }
    
        return result;
    }


}
public static class ConsoleUiHelper
{
    public static DateTime ConvertToDateTime(Func<string> userInput)
    {

        DateTime dateOfBirth;
        string input = userInput();
        while (!DateTime.TryParseExact(input.Trim(), "dd MM yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dateOfBirth))
        {
            Console.WriteLine("Invalid Date format dd MM yyyy");
            input = userInput();
        }
        return dateOfBirth;
    }
    public static string NameValidator(Func<string> input)
    {
        string name = input();

        while (string.IsNullOrEmpty(name))
        {
            Console.WriteLine("Wrong format");
            name = input();
        }
        return name;


    }
}