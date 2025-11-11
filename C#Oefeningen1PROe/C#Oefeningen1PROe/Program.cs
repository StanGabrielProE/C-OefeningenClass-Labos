using System.Runtime.CompilerServices;

namespace C_Oefeningen1PROe;



internal class Program 
{


    public static void Main(string[] args) 
    {
      Oefening1 oefening = new Oefening1();
        Speltje(oefening);
              
    }

    public static void Speltje(IOefening1 oefening) 
    {
        
        int random = oefening.Randomizer();
        int number;
        int keeren = 0;
        do
        {
            oefening.VraagUserInput(out number);
            if (random > number)
            {
                Console.WriteLine("++ hoger");
                ++keeren;
            }
            if (random < number)
            {
                Console.WriteLine("-- lager");
                ++keeren;
            };


        } while (random != number);
        Console.WriteLine("Heel goed Gedaan");
        Console.WriteLine("{0}",keeren);
    }
    


    public static void Factorial(string input) 
    {
     
        string x = input;
        if (!int.TryParse(x, out var result))
        
            while (!int.TryParse(x, out result)||x == "Exit")
            {
               
                x = Console.ReadLine();
            }

        
   


        int n = Calculation(result);
        Console.WriteLine(n);




            int Calculation(int x)
            {
                if (x < 1)
                {
                    return 1;
                }
                else
                {

                    return x * Calculation(x - 1);
                }
            }

    }
}