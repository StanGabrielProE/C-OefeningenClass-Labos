using System.Drawing;
using System.Text.RegularExpressions;

namespace axe;



public interface IWeapon 
{
    string Material {  get; set; }
     string Durability {  get; set; }

    public void WeaponDetails();
}

public interface IMine 
{

    string BloksToMine { get; set; }
    int WeaponDurability { get; set; }


     void StartMining(Weapon weapon);

}



public class Mine :IMine
{
    private string _blocksToMine;
    public string BloksToMine
    {  get=>_blocksToMine ;
        set
        {
         if (Regex.IsMatch(value, @"\d+")) 
            {
                _blocksToMine = value;
            }
         else 
            {
                throw new ArgumentException("you have to enter a value as a full integer");
            }
        } }

    public int WeaponDurability { get; set; }


    

   private void InitTheWeaponDurability(Weapon weapon) 
    
    {
        weapon.DurabilityInt32(out int number);
       WeaponDurability = number;

    }
    
    private int durabilityRemaining() 
    {
        if (WeaponDurability > int.Parse(_blocksToMine)) 
        {
            return WeaponDurability - int.Parse(_blocksToMine);
        }
        else 
        {
            return -1;
        }
    }

    public void StartMining (Weapon weapon) 
    {
        InitTheWeaponDurability(weapon);
        int durability = durabilityRemaining();

        if (durability >= 0)
        {
            
            Console.WriteLine("{0}: {1} durability over mining {2}", weapon.Material, WeaponDurability-int.Parse(_blocksToMine), _blocksToMine);
        }
    }
}