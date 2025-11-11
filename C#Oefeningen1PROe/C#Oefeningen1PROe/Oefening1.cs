using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Oefeningen1PROe;


public class Oefening1 : IOefening1
{

    public Oefening1()
    {
        SpelRegels();
    }

    private void SpelRegels()
    {
        Console.WriteLine(@"n deze toepassing wordt door de gebruiker een willekeurig getal (tussen 1 en 100) gezocht. Na elke gok krijgt de gebruiker een aanwijzing totdat hij/zij het gezochte getal heeft gevonden. Tenslotte wordt het aantal getoond wat nodig was om het getal te raden.

De meldingen zijn:

Raad hoger!

Raad lager!

U hebt het getal geraden in x beurten.

Maak een void methode StartCheck die een geheel getal als parameter verwacht. Voorzie hierin een loop die GiveAnswer en CheckAnswer oproept totdat het getal geraden is.

Maak een methode GiveAnswer die een geheel getal teruggeeft en geen parameter verwacht. Deze methode zorgt voor een correct invoer.

Als laatste voorzie je de methode CheckAnswer die 2 gehele getallen verwacht en niets teruggeeft. In deze methode toon je de berichtvensters.");
    }

    public int Randomizer()
    {
        return Random.Shared.Next(1, 101);
    }

    public void VraagUserInput(out int number)
    {
        string input;
        Console.WriteLine("Enter een hele getaal");
        do
           
        {
            input = Console.ReadLine();
            if (!int.TryParse(input, out number))
            {
                Console.WriteLine("Jij moet een gehelee nummer schrijven");
                input= Console.ReadLine();
            }
        } while (!int.TryParse(input, out number));
    }

}


