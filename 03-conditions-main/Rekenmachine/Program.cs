namespace Rekenmachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float firstNumber;
            float secondNumber = 0;
            string calculation;
            float result = 0;
            bool isInputCorrect = true;

            Console.Write("Getal 1: ");
            isInputCorrect = float.TryParse(Console.ReadLine(), out firstNumber);

            if (isInputCorrect)
            {
                Console.Write("Getal 2: ");
                isInputCorrect = float.TryParse(Console.ReadLine(), out secondNumber);

                if (isInputCorrect)
                {
                    Console.Write("Bewerking: ");
                    calculation = Console.ReadLine();

                    switch (calculation)
                    {
                        case "+":
                            result = firstNumber + secondNumber;
                            break;
                        case "-":
                            result = firstNumber - secondNumber;
                            break;
                        case "*":
                            result = firstNumber * secondNumber;
                            break;
                        case "/":
                            result = firstNumber / secondNumber;
                            break;
                        default:
                            result = 0;
                            isInputCorrect = false;
                            break;
                    }
                }
            }

            if (isInputCorrect)
            {
                Console.WriteLine($"Het resultaat is {result}");
            }
            else
            {
                Console.WriteLine("Foutieve ingave, kan niet berekenen...!");
            }
            Console.ReadLine();
        }
    }
}
