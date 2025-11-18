using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;


namespace SnelsteAtleet;

internal partial class Program
{
    static void Main(string[] args)
    {
        CompetitorsRepo atletes = new CompetitorsRepo();
        Func<string> readLine = Console.ReadLine;




        string input;
        for (int i = 0; i >-1; i++)
        {



            do
            {
                Console.Clear();
                Console.WriteLine("Add Atleet (y/n)- to q");
                input = Console.ReadLine();
            } while (!(input.Equals("n") || input.Equals("y")));




            if (input.Equals("n"))
            {
                if (atletes[0] != null)
                {
                  

                    TheBest atleet = new TheBest(atletes);

                    Console.WriteLine("Competitors :\n {0}", atleet.Competitors);

                    Console.WriteLine("winner : {0}",atleet.Sneelste);
                 
                }
                break;
            }
            if (input.Equals("y"))
            {
                readLine.AskDetail((x) => Regex.IsMatch(x, @"\w+"), "Enter Your Name", out string name);
                readLine.AskDetail((x) => Regex.IsMatch(x, @"\d+"), "Enter Your Time", out string time);

                byte timer = byte.Parse(time);

                atletes.Add(new Atleet { Name = name, Time = timer >=(byte)255 ? (byte)254 : timer });
                
            }
       

        }
      
    }

 
}
    



