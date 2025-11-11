using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Faculteit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = 0;
            long faculty;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Faculteitsberekening");
            Console.ForegroundColor = ConsoleColor.White;
            do
            {
                Console.Write("Geef een getal: ");
            } while (!int.TryParse(Console.ReadLine(), out input));
            Console.WriteLine();
            Console.ForegroundColor= ConsoleColor.Magenta;
            Console.Write($"{input} faculteit = ");
            faculty = 1;
            for (int i = input; i >= 1; i--)
            {
                Console.Write(i);
                if(i>1)
                {
                    Console.Write("*");
                }
                faculty *= i;
            }
            Console.Write($" = {faculty}");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
