namespace Diploma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string studentName;
            int scoreWeb;
            int scoreData;
            int scoreCS;
            int scoreCommSkills;
            int scoreWpl;
            int scoreItOrg;

            int sum = 0;
            double credits = 30;
            int deficitPoints = 0; //Tekortpunten

            Console.ResetColor();
            Console.WriteLine("--------- PXL Digtal ---------");
            Console.Write("Naam student: ");
            studentName = Console.ReadLine();
            Console.WriteLine("------------------------------");

            Console.ForegroundColor = ConsoleColor.Magenta;            
            Console.Write("Score Web Essentials: ");
            if(!int.TryParse(Console.ReadLine(), out scoreWeb) || scoreWeb < 0 || scoreWeb > 20)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ongeldige score!");
                Console.ResetColor();
                credits -= 6;
            }
            else
            {
                sum += 6 * scoreWeb;
                if(scoreWeb < 10)
                {
                    deficitPoints += (10 - scoreWeb) * 6;
                }
            }

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("Score Data Essentials: ");
            if (!int.TryParse(Console.ReadLine(), out scoreData) || scoreData < 0 || scoreData > 20)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ongeldige score!");
                Console.ResetColor();
                credits -= 4;
            }
            else
            {
                sum += 4 * scoreData;
                if (scoreData < 10)
                {
                    deficitPoints += (10 - scoreData) * 4;
                }
            }

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("Score C# Essentials: ");
            if (!int.TryParse(Console.ReadLine(), out scoreCS) || scoreCS < 0 || scoreCS > 20)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ongeldige score!");
                Console.ResetColor();
                credits -= 7;
            }
            else
            {
                sum += 7 * scoreCS;
                if (scoreCS < 10)
                {
                    deficitPoints += (10 - scoreCS) * 7;
                }
            }

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("Score Communication Skills: ");
            if (!int.TryParse(Console.ReadLine(), out scoreCommSkills) || scoreCommSkills < 0 || scoreCommSkills > 20)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ongeldige score!");
                Console.ResetColor();
                credits -= 3;
            }
            else
            {
                sum += 3 * scoreCommSkills;
                if (scoreCommSkills < 10)
                {
                    deficitPoints += (10 - scoreCommSkills) * 3;
                }
            }

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("Score Werkplekleren 1: ");
            if (!int.TryParse(Console.ReadLine(), out scoreWpl) || scoreWpl < 0 || scoreWpl > 20)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ongeldige score!");
                Console.ResetColor();
                credits -= 6;
            }
            else
            {
                sum += 6 * scoreWpl;
                if (scoreWpl < 10)
                {
                    deficitPoints += (10 - scoreWpl) * 6;
                }
            }

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("Score IT-organisation: ");
            if (!int.TryParse(Console.ReadLine(), out scoreItOrg) || scoreItOrg < 0 || scoreItOrg > 20)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ongeldige score!");
                Console.ResetColor();
                credits -= 4;
            }
            else
            {
                sum += 4 * scoreItOrg;
                if (scoreItOrg < 10)
                {
                    deficitPoints += (10 - scoreItOrg) * 4;
                }
            }

            double average = sum / credits;
            double percent = Math.Round(average / 20,2); //Afronden op 2 cijfers na de komma

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"{studentName} behaalde een gewogen gemiddelde van {average:N2} met {deficitPoints} tekortpunten.");
            
            if (deficitPoints > 10)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Niet geslaagd.");
            }
            else if(deficitPoints > 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine($"Gedelibereerd.");
            }
            else
            {
                if (percent >= 0.85)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Geslaagd met de grootste onderscheiding!");
                }
                else if (percent >= 0.77)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Geslaagd met grote onderscheiding!");
                }
                else if (percent >= 0.68)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Geslaagd met onderscheiding!");
                }
                else if (percent >= 0.5)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Geslaagd met voldoening.");
                }
            }

            Console.ResetColor();
        }
    }
}
