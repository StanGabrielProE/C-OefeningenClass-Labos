using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOefeningen
{
    public class Oefeningen

    {


        public static void Gemiddelde()
        {
            int[] numbers = new int[4];
            int i = 0;
            Console.WriteLine("Enter the four numbers : ");
            while (i != 4)
            {
                if (int.TryParse(Console.ReadLine(), out int number))
                {

                    numbers[i] = number;
                    i++;
                }
                else
                {
                    Console.WriteLine("Wrong");
                }
            }

            Console.WriteLine("Het gemmidelde is: ");
            for (int j = 0; j < numbers.Length; j++)
            {
                Console.Write(" " + numbers[j] / 2D);


            }
        }

        public static void Fahrenheit()
        {
            double celsius = 0D;
            Console.WriteLine("Enter the temperature in Fahrenheit");
            if (double.TryParse(Console.ReadLine(), out double fahrenheit))
            {
                celsius = Math.Round((fahrenheit - 32) * 5 / 9, 2);
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("your result is {0} Celsius Degrees", celsius);

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Wrong input");
            }
            Console.ReadKey();
        }

        public static void PxlCassa()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Pxl Cattering Cassa");

            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("Geef de prijs van het product");
            double prijs = prijsVanHetProduct(Console.ReadLine());
            double aantal = VraagAantal(Console.ReadLine());
            if (prijs is not 0 && aantal is not 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine($"Het Totaal Bedraag is: {prijs * (double)aantal}");
            }


            double prijsVanHetProduct(string productPrijs)
            {
                if (double.TryParse(productPrijs, out double prijs))
                {
                    return prijs;
                }
                else
                {
                    return 0;
                }
            }


            double VraagAantal(string producten)
            {
                if (int.TryParse(producten, out int products))
                {
                    return products;
                }
                else
                {
                    return 0;
                }
            }
        }

        public static void Seconden()
        {
            int seconden;
            int hours = 0;
            int minuten = 0;
            Console.WriteLine("Geef Een Aantal Seconden");
            if (int.TryParse(Console.ReadLine(), out seconden))
            {

                hours = ConvertToHours(ref seconden);
                minuten = ConvertToMinutes(ref seconden);
                


                Console.WriteLine(" H: {0} M : {1}  S: {2}", hours, minuten, seconden);
            }
            else
            {
                Console.WriteLine("Niet goed ");
            }
            ;
            //
            int ConvertToHours(ref int input)

            {
                int hours = 0;
                while (input >= 3600)
                {
                    input -= 3600;
                    hours++;

                }
                return hours;
            }
            int ConvertToMinutes(ref int input)
            {
                int minutes = 0;
                while (input >= 60)
                {
                    input -= 60;
                    minutes++;

                }
                return minutes;
            }
        }

        public static void FrisDrank()
        {
            Console.OutputEncoding = Encoding.UTF8;

            decimal gedrag = 2.00m;
            Console.WriteLine("Ingeworpen Gedrag: €{0:F2}", gedrag);
            Console.WriteLine();
            Console.Write("Prijs van uw gekozen drank: €");

            if (decimal.TryParse(Console.ReadLine(), out decimal prijs) && prijs <= gedrag)
            {
                decimal result = gedrag - prijs;
                Console.WriteLine("Prijs van uw gekozen drank: €{0:F2}", prijs);
                Console.WriteLine("Wisselgeld: €{0:F2}", result);
                WisselGeld(ref result);
            }
            else
            {
                Console.WriteLine("Jij moet een gedrag die <= 2,00 invoeren");
            }


            void WisselGeld(ref decimal input)
            {
                int muntVan1 = 0, muntVan05 = 0, muntVan02 = 0, muntVan01 = 0;
                int muntVan5Cent = 0, muntVan2Cent = 0, muntVan1Cent = 0;

                while (input >= 0.01m)
                {
                    if (input >= 1.00m) { input -= 1.00m; muntVan1++; }
                    else if (input >= 0.50m)
                    {
                        input -= 0.50m;
                        muntVan05++;
                    }
                    else if (input >= 0.20m)
                    {
                        input -= 0.20m;
                        muntVan02++;
                    }
                    else if (input >= 0.10m) {
                        input -= 0.10m;
                        muntVan01++;
                    }
                    else if (input >= 0.05m) {
                        input -= 0.05m;
                        muntVan5Cent++;
                    }
                    else if (input >= 0.02m) 
                    {
                        input -= 0.02m;
                        muntVan2Cent++;
                    }
                    else if (input >= 0.01m) 
                    {
                        input -= 0.01m;
                        muntVan1Cent++;
                    }
                    else 
                    {
                        break;
                    }
                }

                Console.WriteLine("Munten 1 € {0}", muntVan1);
                Console.WriteLine("Munten 0.50 € {0}", muntVan05);
                Console.WriteLine("Munten 0.20 € {0}", muntVan02);
                Console.WriteLine("Munten 0.10 € {0}", muntVan01);
                Console.WriteLine("Munten 0.05 € {0}", muntVan5Cent);
                Console.WriteLine("Munten 0.02 € {0}", muntVan2Cent);
                Console.WriteLine("Munten 0.01 € {0}", muntVan1Cent);
            }
        }

        public static void Afstand()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Voer een afstand in centimeter in: ");
            if (double.TryParse(Console.ReadLine(), out double cm))
            {
                double totalInches = cm / 2.54;
                int feet = (int)(totalInches / 12);
                double remainingInches = totalInches - (feet * 12);

                Console.WriteLine();
                Console.WriteLine("Afstand: {0} cm", cm);
                Console.WriteLine(" {0} voet en {1:F2} inch", feet, remainingInches);
            }else 
            {
                Console.WriteLine("Jij moet een  geheel invoeren");
            }


        }


    }
}
     
    

