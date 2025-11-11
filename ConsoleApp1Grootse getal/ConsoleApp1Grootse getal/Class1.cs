using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp1GrootseGetal;
public static class Oefeningen
{
    public static void GroterDan() 
    {
        Console.WriteLine("Enter the first number");
        if (int.TryParse(Console.ReadLine(), out int result))
        {
            Console.WriteLine("Enter the second number");
            if (int.TryParse(Console.ReadLine(), out int result2))
            {
         Utilities.GroterDan<int>(result, result2);
            }
            else
            {
                throw new ArgumentException($"{nameof(result2)} is not supported.");
            }

        }
        else
        {
            throw new ArgumentException($"{nameof(result)} is not supported.");
        }

    }


    public static void RekenMachine() 
    {
        Console.WriteLine("Enter your math sentence ");
        string sentence = Console.ReadLine();
        Utilities.IsValid(new(@"\d{1,}[\+\-\/\*]\d{1,}"), sentence, out string calculation);
        Utilities.LeftOrRightParser(1, calculation, out int x, out int  index);
        Utilities.LeftOrRightParser(2, calculation, out int y);
        int result;
     char temporal = calculation[index]; 
        switch (temporal.ToString())
        {
            case "+":
                result = x + y;
                break;
                case "-": result = x - y;
                break;
                case "*": result = x * y;
                break;
                case "/": result = x / y;
                break;
            default: result = -1;
                break;
        }
        Console.WriteLine(result);
            

    }
}

