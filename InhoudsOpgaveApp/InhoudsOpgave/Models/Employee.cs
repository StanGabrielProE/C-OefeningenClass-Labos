using System.Drawing;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

namespace InhoudsOpgave.Models;

public class Employee
{

  


    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime DateOfBirth { get; set; }
    public decimal Salaris { get; set; }

    public int? Age => DateOfBirth.ConvertToAge();

    public Employee() : this("", "")
    {
             
    }
    public Employee(string firstName,string lastName)
    {
        FirstName = firstName.ConvertToNameFormat();
        LastName = lastName.ConvertToNameFormat();
    }

    public override string ToString()
    {
        return $"Samenvating : {FirstName} {LastName} -({Age})  Salaris: {Salaris}";
    }
    public void IncreaseSalary(int input , ref decimal initialSalary) 
    {

        
            initialSalary += initialSalary * input / 100;
        
    }

}

        
    



