using axe;

namespace MinecraftRefactor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Weapon stoneWeap = new("Stone", "131");
            Weapon ironWeap = new("Iron", "250");
            Weapon diamondWeap = new("Diamond", "1561");
            Weapon NetheriteWeap = new("Netherite", "2031");

            Mine mine = new();
            Console.WriteLine("How many blocks would u like to mine?");
            mine.BloksToMine = Console.ReadLine();
            mine.StartMining(stoneWeap);
            mine.StartMining(ironWeap);
            mine.StartMining(diamondWeap);
            mine.StartMining(NetheriteWeap);
            Console.ReadKey();


            CreateYourOwnWeapon();
      
        }
      public  static void CreateYourOwnWeapon() 
        {
            Console.WriteLine("Enter a weaponName");
            string weaponName = Console.ReadLine();
            Console.WriteLine("Enter Weapon Durability");
            if (int.TryParse(Console.ReadLine() ,out int durability)) 
            {
                Weapon weapon = new Weapon(weaponName, durability.ToString());
                Console.WriteLine("Weapon was created");
                Mine mine = new Mine();
                Console.WriteLine("How many blocks would u like to mine?");
                mine.BloksToMine = Console.ReadLine();
                mine.StartMining(weapon);
            }else 
            {
                Console.WriteLine("Sorry");
            }
            
        }
    }
}
