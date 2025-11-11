using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MonitoraatOefeningen;

public class MonitoraatOefeningen
{

    public static void DataVragen() 
    { // can split separated each one of those in an loop , when not null |Exit
        string? naam;
        int? age;
        string? email;
        string telefoonNummer;
        string? gender;
        int? postCode;



        Console.WriteLine("Enter your name ");
        VraagDeNaam(out naam);
        Console.WriteLine("Enter your Age ");
        vraagDeLeefTijd(out age);
        Console.WriteLine("Enter your Email ");
        VraagEmail(out email);
        Console.WriteLine("Enter your Telefoon number 04XXXXXXXX");
        VraagTelefoonNummer(out telefoonNummer);
        Console.WriteLine("Press 1 for Male");
        Console.WriteLine("Press 2 for Female");
         VraagGender(out gender);
        Console.WriteLine("Enter your postcode 4 cijfers");
        VraagPostCode(out postCode);
        Console.WriteLine("Write the city ");
        string city = Console.ReadLine();

        Console.WriteLine("Client : {0}, {1} {2} {3} {4}", gender,naam,age,email,telefoonNummer);
        Console.WriteLine("Location : {0}, {1}",postCode,city);



        void vraagDeLeefTijd(out int? age) 
        { string str;
            Regex regex = new Regex(@"\d{1,3}");
            if (RegexValidator(str = Console.ReadLine(), regex)) 
            {
                age = int.Parse(str) > 120 || int.Parse(str) <= 0 ? 0 : int.Parse(str);   
               
            }else 
            {
                age = null;
            }
        }

       void VraagDeNaam(out string? str) 
        {
            string str2;
            Regex regex = new Regex("[A-Z][a-z]+ [A-Z][a-z]+(?:[- ][A-Z][a-z]+)*");
            if (RegexValidator(str2 =Console.ReadLine(), regex)) 
            {
                str = str2;
            }
            else
            {
                str = null;
            }
          
        }

      void VraagEmail (out string? str) 
        {
            string email;
            Regex regex = new Regex(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$");
            if (RegexValidator(email = Console.ReadLine(), regex)) 
            {
                str = email;
            }else
            {
                str  = null;    
            }
        }

        void VraagTelefoonNummer (out string? str) 
        { string telefoonNr;
            Regex regex = new Regex(@"04\d{8}");
            if (RegexValidator(telefoonNr = Console.ReadLine(), regex))
            {
                str= telefoonNr;
            }else 
            {
                str = null;
            }
        }
         void VraagGender( out string? isMan)
        {
            string temporal;
            int number;

            Regex regex = new Regex(@"\d");
            if (RegexValidator(temporal = Console.ReadLine(), regex))
            {
                number = int.Parse(temporal);
                isMan = number switch
                {
                    1 => "MAN",
                    2 => "VROUW",
                    _ => null
                };

            }
            else
            {
                isMan = null;
            }
        }

        void VraagPostCode(out int? postcode)
        {
            string temporal;
            Regex regex = new Regex(@"\d{4}");
            if (RegexValidator(temporal = Console.ReadLine(), regex))
            {
                postcode = int.Parse(temporal);
            }
            else
            {
                postcode = null;
            }
        }
    }


    public static void KwadraatVanEenGetal() 
    {
        Console.WriteLine("Voer een getal in");
        string x = Console.ReadLine();
        if (float.TryParse(x, out float number)) 
        {
            Console.WriteLine($"Het kwadraat van uw nummer is {Math.Pow(number,2)}");
        }else 
        {
            Console.WriteLine("Jij moet een  getal invoeren ");
        }
    }


   



    private static bool RegexValidator(string str,Regex regex) 
    {
        return regex.IsMatch(str);
    }
}
