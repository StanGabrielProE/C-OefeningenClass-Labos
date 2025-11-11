global using System.Text;
using InhoudsOpgave.Helpers;
using InhoudsOpgave.Models;
using static  System.Console;
using static InhoudsOpgave.Helpers.ConsoleUiHelper;





namespace InhoudsOpgave;

internal class Program
{
    static void Main(string[] args)
    {
        WriteLine("Enter Your FirstName");
        string name = NameValidator(() => ReadLine());
        WriteLine("Enter Your LastName");
        string lastName = NameValidator(() => ReadLine());
        Employee employee = new Employee(name, lastName);
        WriteLine("Date of Birth :");

        employee.DateOfBirth = ConvertToDateTime(() => ReadLine());
        Console.WriteLine("Enter your Salaris");
        decimal salaris = ConsoleUiHelper<decimal>.ConvertToNumber(() => ReadLine());
        employee.Salaris = salaris;

        employee.ShowDetails();
        Console.WriteLine("Increase Salary ");
        int salarisProcentage = ConsoleUiHelper<int>.ConvertToNumber(() => ReadLine());
   
        employee.IncreaseSalary(salarisProcentage, ref salaris);
        employee.Salaris = salaris;
        employee.ShowDetails(salarisProcentage);
    }




}
