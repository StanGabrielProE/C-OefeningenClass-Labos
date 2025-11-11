namespace GrootsteGetal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Eerste getal: ");
            bool isFirstNumberCorrect = int.TryParse(Console.ReadLine(), out int firstNumber);
            Console.Write("Tweede getal: ");
            bool isSecondNumberCorrect = int.TryParse(Console.ReadLine(), out int secondNumber);
            if (isFirstNumberCorrect == false)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Eerste getal is foutief ingegeven!");
            }
            else if (isSecondNumberCorrect == false)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Tweede getal is foutief ingegeven!");
            }
            else
            {
                Console.ResetColor();
                //if (firstNumber > secondNumber)
                //{
                //    Console.WriteLine($"Het grootste getal is {firstNumber}.");
                //}
                //else
                //{
                //    Console.WriteLine($"Het grootste getal is {secondNumber}.");
                //}
                Console.WriteLine($"Het grootste getal is {(firstNumber > secondNumber ? firstNumber : secondNumber)}");
            }
            Console.ReadLine();
        }
    }
}
