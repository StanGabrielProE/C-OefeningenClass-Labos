namespace Machtevereffening
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = 0;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Machtsvereffening");
            Console.ForegroundColor = ConsoleColor.White;
            do
            {
                Console.Write("Geef een getal: ");
            } while (!int.TryParse(Console.ReadLine(), out input));
            Console.WriteLine();
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{input} tot de {i}{(i == 1 ? "ste" : "de")} = {Math.Pow(input, i)}");
            }
        }
    }
}
