global using System.Text;
using System.Text.RegularExpressions;
using InhoudsOpgave.Helpers;
using InhoudsOpgave.Models;

using static InhoudsOpgave.Helpers.ConsoleUiHelper;





namespace InhoudsOpgave;

internal class Program
{
    static void Main(string[] args)
    {
        Func<string> userInput = Console.ReadLine;



        Console.WriteLine("First Name:");
        string name = userInput.NameValidator("ERROR: try to enter your First Name again ");
        Console.WriteLine("Last Name:");
        string lastName =userInput.NameValidator("ERROR: try to enter your First Name again");

        Employee employee = new Employee(name, lastName);
        Console.WriteLine("Date of Birth :");

        employee.DateOfBirth = userInput.ConvertToDateTime("ERROR : Date of Birth format dd MM yyyy");
       Console.WriteLine("Salaris (dddd || dddd .... n x d)");
        decimal salaris = 
            ConsoleUiHelper<decimal>.ConvertToNumber(
            userInput,(x)=>Regex.IsMatch(x,@"\d{4,}"),
            "ERROR: Salaris  must be in this format(dddd || dddd .... n x d)");


        employee.Salaris = salaris;

        employee.ShowDetails();

       Console.WriteLine("Increase Salary (1-10): ");

        int salarisProcentage =
            ConsoleUiHelper<int>.ConvertToNumber(
            userInput, (x) => Regex.IsMatch(x, @"^(?:[1-9]|10)$"),
            "ERROR :Reduction (1-10))");

        employee.IncreaseSalary(salarisProcentage, ref salaris);
        employee.Salaris = salaris;
        employee.ShowDetails(salarisProcentage);
    }




}
