using System.Text.RegularExpressions;

namespace ConsoleApp1;

internal class Program
{
    static void Main(string[] args)
    {
        int jaarBerekening;
        ParseJaar(new(@"\d{4}"), Console.ReadLine(), out int jaar);
        if (jaar > 0)
        {
            jaarBerekening = DateTime.Today.Year - jaar;
            Console.WriteLine($"{jaarBerekening}");
        }
        else if (jaar == 0)
        {

            Console.WriteLine("You Lie");
        }
        else
        {
            Console.WriteLine("Enter  an valid integer [1234]");
        }
    }





    public static void ParseJaar(Regex regex, string nummer, out int asNummer)
    {
        asNummer = regex.IsMatch(nummer) ?
                int.Parse(nummer) > 1900 ? int.Parse(nummer) : 0 // tweede conditie
                : -1;
    }
}
