using System.Text.RegularExpressions;

namespace Weddeberekening
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double hourlyWage = 0;
            int workedHours = 0;
            double tax = 0;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Weddeberekening");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            Console.Write("Geef uw naam: ");
            string name = Console.ReadLine();
            do
            {
                Console.Write("Geef uw uurloon: ");
            } while (!double.TryParse(Console.ReadLine(), out hourlyWage));
            do
            {
                Console.Write("Geef het aantal gewerkte uren: ");
            } while (!int.TryParse(Console.ReadLine(), out workedHours));
            double grossIncome = hourlyWage * workedHours;

            // Belastingsschijven If-structuur     
            if (grossIncome <= 10000)
            {
                // Als je bruto niet meer dan 10000 euro verdient, 0 euro belasting.
                tax = 0;
            }
            else if (grossIncome <= 15000)
            {
                tax = (grossIncome - 10000) * 0.2f;
            }
            else if (grossIncome <= 25000)
            {
                tax = ((grossIncome - 15000) * 0.3f) + 1000;
            }
            else if (grossIncome <= 50000)
            {
                tax = ((grossIncome - 25000) * 0.4f) + 4000;
            }
            else
            {
                tax = ((grossIncome - 50000) * 0.5f) + 14000;
            }

            Console.WriteLine();
            Console.ForegroundColor= ConsoleColor.Cyan;
            Console.WriteLine($"LOONFICHE van {name}");
            Console.WriteLine();
            Console.WriteLine($"Aantal gewerkte uren:\t{workedHours}");
            Console.WriteLine($"Uurloon:\t\t{hourlyWage:f2}");
            Console.WriteLine($"Bruto jaarwedde:\t{grossIncome:f2}");
            Console.WriteLine($"Belasting:\t\t{tax:f2}");
            Console.WriteLine($"Netto jaarwedde:\t{grossIncome-tax:f2}");
        }
    }
}
