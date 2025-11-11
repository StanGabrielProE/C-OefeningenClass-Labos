namespace KmToMiles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Print header
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("+-----------------------------------------+");
            Console.WriteLine("|           Km-2-Miles converter          |");
            Console.WriteLine("+-----------------------------------------+");
            Console.WriteLine();
            Console.ResetColor();


            const double Ratio = 1.60934;

            Console.WriteLine("In welke eenheid wilt u de afstand ingeven?");
            Console.WriteLine("\t1. Kilometer");
            Console.WriteLine("\t2. Mijl");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Uw keuze: ");

            string unit = Console.ReadLine();
            
            switch (unit)
            {
                case "1":
                    Console.Write("Afstand in kilometer: ");
                    break;
                case "2":
                    Console.Write("Afstand in mijl: ");
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Deze eenheid wordt niet ondersteund!");
                    Console.ResetColor();
                    return; // => Stopt de main-methode, hierdoor wordt de applicatie dus beëindigd
            }

            if (double.TryParse(Console.ReadLine(), out double distance))
            {
                Console.ForegroundColor = ConsoleColor.Green;

                switch (unit)
                {
                    case "1":
                        Console.WriteLine($"Afstand in mijl: {distance / Ratio}");
                        break;
                    case "2":
                        Console.WriteLine($"Afstand in kilometer: {distance * Ratio}");
                        break;
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Dit is geen geldige afstand!");
            }

            Console.ResetColor();
        }
    }
}
