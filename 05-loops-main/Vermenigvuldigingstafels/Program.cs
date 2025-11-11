namespace Vermenigvuldigingstafels
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input;

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Vermenigvuldigingstafels");
            Console.ForegroundColor = ConsoleColor.White;
            do
            {
                Console.Write("Geef een getal: ");
            } while(!int.TryParse(Console.ReadLine(), out input) || input > 10);
            for (int col = 1; col <= input; col++)
            {
                Console.Write($"\t{col}");
            }
            Console.WriteLine();
            for (int row = 1; row <= input; row++)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"{row}\t");
                Console.ForegroundColor = ConsoleColor.Yellow;
                for (int col = 1;col<=input;col++)
                {
                    Console.Write($"{row*col}\t");
                }
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
