namespace Leveringskosten
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.Write("Prijs van het product: ");
            decimal price = decimal.Parse(Console.ReadLine());

            Console.Write("Aantal producten: ");
            int quantity = int.Parse(Console.ReadLine());

            Console.Write("Btw-percentage: ");
            int vatPercentage = int.Parse(Console.ReadLine());

            decimal subtotalExcl = price * quantity;

            if (quantity >= 10)
            {
                subtotalExcl *= 0.95m; // 5% korting
            }

            decimal delivery = 0;

            if (subtotalExcl < 50)
            {
                delivery = 15m;
            }
            else if (subtotalExcl < 70)
            {
                delivery = 12m;
            }
            else
            {
                delivery = 10m;
            }

            decimal productVat = (subtotalExcl * (vatPercentage / 100m));
            decimal subtotalIncl = subtotalExcl + productVat;
            decimal total = subtotalIncl + delivery;

            decimal deliveryVat = delivery - (delivery / (1 + (6m / 100)));
            decimal totalVat = productVat + deliveryVat;

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"Het totaalbedrag voor deze bestelling (inclusief btw) is {total:c}");
            Console.WriteLine($"In totaal betaalde u {totalVat:c} btw.");
            Console.ResetColor();
        }
    }
}
