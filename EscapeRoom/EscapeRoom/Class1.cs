using System.Security.Cryptography.X509Certificates;

namespace EscapeRoom;



public class EscapeRoom 
{
   public void Title() 
    {
        Console.Clear();
        Console.WriteLine(@"
 ___                         ___
| __|___ __ __ _ _ __  ___  | _ \___  ___ _ __
| _|(_-</ _/ _` | '_ \/ -_) |   / _ \/ _ \ '  \
|___/__/\__\__,_| .__/\___| |_|_\___/\___/_|_|_|
                |_|
================================================
");
    }

    public void intro() 
    {
        Console.WriteLine("Solve the puzzles before time runs out!");
        Console.WriteLine("Press enter to start your adventure...");
        Console.ReadLine();
    }
    private void Menu() 
    {
        TimeSpan span = new TimeSpan(+15);
    }
}