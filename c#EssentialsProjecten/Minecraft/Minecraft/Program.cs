using System.Numerics;

namespace Minecraft;

internal class Program
{
    static void Main(string[] args)
    {

        Console.Beep();
        
        int blokken;

        int stonePickAxe = 131;
        int ironPickAxe = 250;
        int diamondPickAxe = 1561;
        int netheritePickAxe = 2031;

        

        Console.WriteLine("Hoeveel Blokken Wil Je Mijnen met een stone pickaxe");

        if (int.TryParse(Console.ReadLine(), out blokken))
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(@$"
                                 Stone :{stonePickAxe - blokken}  durability over
                                 Iron :{ironPickAxe - blokken}  durability over
                                 Diamond :{diamondPickAxe - blokken}  durability over
                                 Netherite :{netheritePickAxe - blokken}  durability over
                              ");
            Console.WriteLine("Druk en toets om verder te gaan");
            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.White;
            
        }
        else 
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Niet geldig");
        }





        Console.ForegroundColor= ConsoleColor.Yellow;
        Console.WriteLine("Maak jouw Eigen Tool - geef en naam");


       
        string tool = Console.ReadLine();


        Console.WriteLine("Geef de maximale  durability (geheel getal)");
        bool isDurability = int.TryParse(Console.ReadLine(), out int durability);


        if (isDurability) 
        {
            Console.WriteLine($"Hoeveel Blokken Wil Je Mijnen met een {tool} pickaxe");
            bool isGetal = int.TryParse(Console.ReadLine(), out int getal);
            if (durability >= getal) 
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Je tool {tool} heeft nog {durability - getal} over na {getal}");
                Console.ReadKey();
            }
            else 
            {
                Console.ForegroundColor = ConsoleColor.Red;


                Console.WriteLine("Je kunt niet zoveel blokken minen");
            }
        }          
      
    }





}


