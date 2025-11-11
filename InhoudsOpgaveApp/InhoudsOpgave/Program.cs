using InhoudsOpgave.Models;

namespace InhoudsOpgave
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            decimal age = Console.ReadLine().DecimalConverter();
            Console.WriteLine("Age is {0}", age);
        }
    }
}
