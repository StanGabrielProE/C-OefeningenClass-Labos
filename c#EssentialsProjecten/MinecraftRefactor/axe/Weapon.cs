using System.Text.RegularExpressions;

namespace axe;

public class Weapon : IWeapon 
{






    private string _material;


    public  string Material 
    {
        get=> _material;
        set 
        {
            if (Regex.IsMatch(value, @"\w{4,}")) 
            {
                _material = value;
            }else 
            {
                throw new ArgumentException("The Material must be 4 char long minimum");
            }
                ; 
        }
    }

    private string _durability;


    public string Durability {
        get=> _durability;
        set 
        {
            if (Regex.IsMatch(value, @"\d+")) 
            {
                _durability = value;
            }
            else 
            {
                throw new ArgumentException($"Tou have to pass a valid full integer");
            }
                ;
        }
    }
    public Weapon ( string material , string durability )
    {
        Durability = durability;
        Material = material;
    }

   

    public void WeaponDetails() 
    {
        Console.WriteLine($"{_material} durability is {_durability}");
    }

     public void  DurabilityInt32(out int number) 
    {
        number = int.Parse(Durability);
    }

}

