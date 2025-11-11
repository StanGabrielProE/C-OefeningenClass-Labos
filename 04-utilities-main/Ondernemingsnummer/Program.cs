namespace Ondernemingsnummer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int CheckNumber = 97;
            int vatNumber = 0;
            string input;
            bool correctInput;

            do
            {
                Console.Write("Ondernemingsnummer: ");
                input = Console.ReadLine();
                if(input.Length != 10)
                {
                    Console.WriteLine("Ondernemingsnummer moet uit exact 10 cijfers bestaan!");
                    correctInput = false;
                }
                else if(!int.TryParse(input, out vatNumber))
                {
                    Console.WriteLine("Ondernemingsnummer kan enkel uit cijfers bestaan!");
                    correctInput = false;
                }
                else
                {
                    correctInput = true;
                }
            } while (!correctInput);

            //Enkel eerste 8 cijfers overhouden
            vatNumber = int.Parse(input.Substring(0, 8));

            //Berekend controlegetal
            int result = CheckNumber - (vatNumber % CheckNumber);

            //Ingegeven controlegetal
            if (input.Substring(input.Length - 2) == result.ToString())
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Het ondernemingsnummer is correct!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Het ondernemingsnummer is NIET correct! Het controlegetal zou {result} moeten zijn.");
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
