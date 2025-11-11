namespace Rekenmachine;


class Program
{
    static void Main()
    {
        int result1;
        int result2;
        string calculation;


        do
        {
            Console.WriteLine("Number 1:");
        } while (!int.TryParse(Console.ReadLine(), out result1));


        do
        {
            Console.WriteLine("Number 2:");
        } while (!int.TryParse(Console.ReadLine(), out result2));


        do
        {
            Console.WriteLine("Calculation (+, -, *, /):");
            calculation = Console.ReadLine();
        } while (!(calculation == "+" || calculation == "-" || calculation == "*" || calculation == "/"));


        int result = calculation switch
        {
            "+" => result1 + result2,
            "-" => result1 - result2,
            "*" => result1 * result2,
            "/" => result1 / result2,
            _ => 0,
        };

        //Console.WriteLine($"Result: {result}");
        Console.WriteLine("Geef mij jouw nr");
        int val;
        string str = Console.ReadLine();
        bool good = int.TryParse(str, out val);
        while (!good) 
        {
            Console.WriteLine("Not good");
            str = Console.ReadLine();
            good = int.TryParse(str, out  val);
        }
    }
}





