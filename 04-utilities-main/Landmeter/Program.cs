namespace Landmeter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double distanceAC; 
            double degreesC; 
            double degreesA; 
    
            Console.Write("Afstand AC (in meter): "); 
            distanceAC = double.Parse(Console.ReadLine());

            if (distanceAC <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ERROR: De afstand AC moet groter zijn dan 0m.");
            }
            else
            {
                Console.Write("Hoek A (in graden): "); 
                degreesA = double.Parse(Console.ReadLine());
            
                Console.Write("Hoek C (in graden): "); 
                degreesC = double.Parse(Console.ReadLine());

                if(degreesA <= 0 || degreesA >= 180 || degreesC <= 0 || degreesC >= 180)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("ERROR: De hoeken van een driehoek moeten groter dan 0° en kleiner dan 180° zijn.");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;

                    double radiansX = degreesA * Math.PI / 180;
                    double radiansY = degreesC * Math.PI / 180;

                    double distanceAB = distanceAC * (Math.Sin(radiansY) / Math.Sin(radiansX + radiansY));

                    Console.WriteLine($"Afstand AB is {distanceAB}m.");
                }
            }

            Console.ResetColor();
            Console.WriteLine("Druk op ENTER om af te sluiten..."); 
            Console.ReadLine();
        }
    }
}
