namespace Driehoek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Lengte van zijde a: ");
            int a = int.Parse(Console.ReadLine()!);

            Console.Write("Lengte van zijde b: ");
            int b = int.Parse(Console.ReadLine()!);

            Console.Write("Lengte van zijde c: ");
            int c = int.Parse(Console.ReadLine()!);

            if (a + b > c && a + c > b && b + c > a)
            {
                double s = (a + b + c) / 2.0;
                double o = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"De oppervlakte van de driehoek is: {o:N2}cm²");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("De driehoek is ongeldig.");
            }

            Console.ResetColor();
        }
    }
}
