using System.Globalization;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace InhoudsOpgave.Models;

public static class ConsoleUiHelper<T> where T:INumber<T>
{
    public  static DateTime ConvertToDateTime( Func<string> userInput)
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


    public  static T ConvertToNumber(string userInput)
    {
        T result;
        while (!T.TryParse(userInput.Trim(),CultureInfo.InvariantCulture, out result))
        {
            Console.WriteLine($"Voer een geldig number in. Input: {userInput} past voor deze situatie niet toe");
            userInput = Console.ReadLine();
        }
    
        return result;
    }
}
