global using System.Text;
using System.Text.RegularExpressions;
using InhoudsOpgave.Helpers;
using InhoudsOpgave.Models;
using static  System.Console;
using static InhoudsOpgave.Helpers.ConsoleUiHelper;





namespace InhoudsOpgave;

internal class Program
{
    static void Main(string[] args)
    {
        Func<string> userInput = Console.ReadLine;



        Console.WriteLine("First Name:");
        string name = userInput.NameValidator("Voeg jouw naam in ");
        Console.WriteLine("Last Name:");
        string lastName =userInput.NameValidator("Voeg jouw Familie Naam in ");

        Employee employee = new Employee(name, lastName);
        WriteLine("Date of Birth :");

        employee.DateOfBirth = userInput.ConvertToDateTime("Voer jouw geboorte datum in");
        WriteLine("Salaris;");
        decimal salaris = 
            ConsoleUiHelper<decimal>.ConvertToNumber(
            userInput,(x)=>Regex.IsMatch(x,@"\d{4,}"),
            "Salaris:");


        employee.Salaris = salaris;

        employee.ShowDetails();
        WriteLine("Increase Salary ");
        int salarisProcentage = 
            ConsoleUiHelper<int>.ConvertToNumber(
            userInput, (x) => Regex.IsMatch(x, @"^(?:[1-9]|10)$"),
            "Enter jouw maand salaris");

        employee.IncreaseSalary(salarisProcentage, ref salaris);
        employee.Salaris = salaris;
        employee.ShowDetails(salarisProcentage);
    }




}
