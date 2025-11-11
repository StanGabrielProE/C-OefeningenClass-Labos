using System;

namespace Lotto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int minLottoNumber = 1;
            const int maxLottoNumber = 45;
            Random random = new Random();
            string answer;

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("LOTTO");
            Console.ForegroundColor = ConsoleColor.White;

            do
            {
                Console.WriteLine();
                for (int i = 1; i <= 6; i++)
                {
                    int lottoNumber = random.Next(minLottoNumber, maxLottoNumber + 1);
                    Console.WriteLine($"Getal {i}: {lottoNumber}\r\n");
                }
                do
                {
                    Console.Write("Wilt u andere getallen (J/N)? ");
                    answer = Console.ReadLine();
                } while (answer != "J" && answer != "N");
            } while (answer == "J");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
