using System.Globalization;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace InhoudsOpgave.Helpers;

public static class ConsoleUiHelper<T> where T:INumber<T>
{



    public  static T ConvertToNumber(Func<string> userInput ,Predicate<string>condition,string? prompt = null)
    {
        string input = userInput();
        T result = T.Zero;


        while (!condition(input)) 
        {
         
            Console.WriteLine(prompt);
             input = userInput();
        
        } 

        result = T.Parse(input,CultureInfo.InvariantCulture);
        return result;
    }


}
public static class ConsoleUiHelper
{
    public static DateTime ConvertToDateTime(this Func<string> userInput, string? prompt=null)
    {
        Console.WriteLine(prompt);
        DateTime dateOfBirth;
        string input = userInput();
        while (!DateTime.TryParseExact(input.Trim(), "dd MM yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dateOfBirth))
        {
            Console.WriteLine("Invalid Date format dd MM yyyy");
            input = userInput();
        }
        return dateOfBirth;
    }

    public static string NameValidator(this Func<string> input, string? prompt=null)
    {
        string name = input();

        while (string.IsNullOrEmpty(name))
        {
            Console.WriteLine(prompt);
            name = input();
        }
        return name;


    }
}