using System.Globalization;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace InhoudsOpgave.Models;

public class ConsoleUiHelper < T > where T :INumber<T>
{
    public  DateTime ConvertToDateTime( string userInput)
    {
        DateTime dateOfToday = DateTime.Now;
        DateTime dateOfBirth;
        while (!DateTime.TryParseExact(userInput.Trim(), "dd MM yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dateOfBirth))
        {
            Console.WriteLine("Invalid Date format dd MM yyyy");
            userInput = Console.ReadLine();
        }


        dateOfBirth = dateOfToday <= dateOfBirth ? DateTime.MinValue : dateOfBirth;


        return dateOfBirth;
    }


    public  T ConvertToNumber( string userInput)
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
