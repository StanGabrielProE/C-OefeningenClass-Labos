namespace Sparen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int weekAmount;
            decimal weeklyIncrease;
            int target;
            decimal savings = 0.0M;
            decimal extraWeeklyAmount = 0.0M;
            decimal totalSavings = 0.0M;
            int numberOfWeeks = 0;

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Sparen");
            Console.ForegroundColor = ConsoleColor.White;
            do
            {
                Console.Write("Zakgeld (per week): ");
            } while (!int.TryParse(Console.ReadLine(), out weekAmount));
            do
            {
                Console.Write("Wekelijkse verhoging: ");
            } while (!decimal.TryParse(Console.ReadLine(), out weeklyIncrease));
            do
            {
                Console.Write("Gewenst bedrag (doel): ");
            } while (!int.TryParse(Console.ReadLine(), out target));
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine();

            do
            {
                savings += weekAmount;
                extraWeeklyAmount += weeklyIncrease;
                totalSavings = savings + extraWeeklyAmount;
                numberOfWeeks++;
                Console.WriteLine($"Week {numberOfWeeks}: {savings} + {extraWeeklyAmount} = {totalSavings}");
            } while (totalSavings < target);

            Console.ForegroundColor = ConsoleColor.White;

        }
    }
}
