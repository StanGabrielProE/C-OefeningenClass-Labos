namespace SnelsteAtleet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "";
            int time = 0;
            string fastestName = "";
            int fastestTime = int.MaxValue;
            int hours;
            int minutes;
            int seconds;

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Snelste atleet");
            Console.ForegroundColor = ConsoleColor.White;
            do
            {
                Console.WriteLine();
                Console.Write("Naam atleet: ");
                name = Console.ReadLine();
                if (name != "STOP")
                {
                    do
                    {
                        Console.Write("Looptijd: ");
                    } while (!int.TryParse(Console.ReadLine(), out time));
                    if (time < fastestTime)
                    {
                        fastestTime = time;
                        fastestName = name;
                    }
                }
            } while (name != "STOP");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.WriteLine($"De snelste atleet is {fastestName} met {fastestTime} seconden");

            //Gehele deling en uren, minuten worden uit de tijd gehaald
            hours = fastestTime / 3600; // tijd staat in seconden en er zijn 3600 seconden in een uur
            fastestTime -= (hours * 3600); // trek nu de uren van de tijd af (terug omzetten naar seconden omdat tijd in seconden staat)
            minutes = fastestTime / 60; // tijd staat in seconden en er zijn 60 seconden in een minuut
            fastestTime -= (minutes * 60); // trek nu de minuten van de tijd af (terug omzetten naar seconden omdat tijd in seconden staat)
            seconds = fastestTime; // het aantal seconden is de tijd die overblijft

            Console.WriteLine($"{hours} uren");
            Console.WriteLine($"{minutes} minuten");
            Console.WriteLine($"{seconds} seconden");
        }
    }
}
