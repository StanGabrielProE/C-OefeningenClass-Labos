using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp1GrootseGetal;

public static class Utilities
{
    public static void GroterDan<T>(T x, T y) where T : INumber<T>
    {
        string result = x > y ? string.Format("{0} is groter ", x, y) : string.Format("{1} is groter ", x, y);
        Console.WriteLine(result);
    }



    public static void IsValid(Regex regex, string input, out string output)
    {
        if (regex.IsMatch(input))
        {
            output = input;
        }
        else
        {
            output = string.Empty;
        }
    }




public static void  LeftOrRightParser(int leftOrWrite, string input , out int output )
    {

        string[] toMatch = { "+", "-", "/", "*" };
        int index = 0;

        foreach (string s in toMatch) 
        {
            if (input.Contains(s))
            {
                index = input.IndexOf(s);
            }
        }

        if (leftOrWrite == 1) 
        {
            output = int.Parse(input.Substring(0, index));
        }else if (leftOrWrite == 2) 
        {
            output = int.Parse (input.Substring(index + 1));
        }
        else 
        {
            throw new ArgumentException( "No match ");
        }
    }

    public static void LeftOrRightParser(int leftOrWrite, string input, out int output ,out int index )
    {

        string[] toMatch = { "+", "-", "/", "*" };
        index = -1;

        foreach (string s in toMatch)
        {
            if (input.Contains(s))
            {
                index = input.IndexOf(s);
            }
        }

        if (leftOrWrite == 1)
        {
            output = int.Parse(input.Substring(0, index));
        }
        else if (leftOrWrite == 2)
        {
            output = int.Parse(input.Substring(index + 1));
        }
        else
        {
            throw new ArgumentException("No match ");
        }
    }



}
