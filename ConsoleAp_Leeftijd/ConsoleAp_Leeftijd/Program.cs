using System.Globalization;

namespace LeeftijdBerekening;

internal class Program
{
    static void Main(string[] args)
    {

        int age;
        int year;
        double salary = 2000.53721;
        bool isValid;
        //------------

        Console.OutputEncoding= System.Text.Encoding.UTF8;
        Console.WriteLine($"Het huidige jaartal is {DateTime.Today :yyyy}."); // MMMM full mand ... formating

        Console.WriteLine("Enter jouw geboortejaar(format yyyy)");
       
         isValid = int.TryParse( Console.ReadLine(), out  year );
         age= DateTime.Today.Year - year;
        if (isValid)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
           //  Console.WriteLine($" Je leeftijd is {age} en je verdient {salary :C}");
                
            Console.WriteLine("Jouw leeftijd is {0} en je verdient {1:C}" ,age, salary);
            Console.ReadKey();
        }
        else
        {
            Console.WriteLine("Je moet en valid getal schrijven 1234");


        }
     
       
    }
}
