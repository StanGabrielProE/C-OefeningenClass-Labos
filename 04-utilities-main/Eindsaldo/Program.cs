namespace Eindsaldo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.Write("Beginsaldo: ");
            decimal saldo = decimal.Parse(Console.ReadLine());

            Console.Write("Aantal jaren: ");
            int years = int.Parse(Console.ReadLine());

            Console.Write("Rente per jaar (%): ");
            int interest = int.Parse(Console.ReadLine());


            decimal result = saldo * (decimal)Math.Pow(1 + (interest / 100.0), years);

            Console.WriteLine($"Eindsaldo na {years} jaar: {result:C}");
        }
    }
}
