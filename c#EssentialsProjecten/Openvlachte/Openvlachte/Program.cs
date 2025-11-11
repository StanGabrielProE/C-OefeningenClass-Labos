using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace Openvlachte
{


class Program
        {
            static void Main()
            {
                Console.WriteLine("Bereken de oppervlakte van een driehoek");

               
                Console.Write("Voer zijde a in: ");
                double a = LeesPositiefGetal();

                Console.Write("Voer zijde b in: ");
                double b = LeesPositiefGetal();

                Console.Write("Voer zijde c in: ");
                double c = LeesPositiefGetal();

            
                if (!IsGeldigeDriehoek(a, b, c))
                {
                Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("De opgegeven zijden vormen geen geldige driehoek.");
                    return;
                }

               
                double s = (a + b + c) / 2;

                
                double oppervlakte = Math.Sqrt(s * (s - a) * (s - b) * (s - c));

                Console.WriteLine($"De oppervlakte van de driehoek is: {oppervlakte:F2}");
            }

            static double LeesPositiefGetal()
            {
                while (true)
                {
                    if (double.TryParse(Console.ReadLine(), out double waarde) && waarde > 0)
                        return waarde;
                    Console.Write("Ongeldige invoer. Voer een positief getal in: ");
                }
            }

            static bool IsGeldigeDriehoek(double a, double b, double c)
            {
                return a + b > c && a + c > b && b + c > a;
            }
        }
    }






    