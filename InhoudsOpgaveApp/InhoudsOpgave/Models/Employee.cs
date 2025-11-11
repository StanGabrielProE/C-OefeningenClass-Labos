using System.Drawing;
using System.Globalization;
using System.Text;

namespace InhoudsOpgave.Models;

public class Employee
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime DateOfBirth { get; set; }
    public int? Age => DateOfBirth.ConvertToAge();
    public decimal Salaris { get; set; }
    public Employee() : this("", "")
    {
             
    }
    public Employee(string firstName,string lastName)
    {
        FirstName = firstName;
        LastName = lastName; 
    }

    public override string ToString()
    {
        return $"Samenvating : {FirstName} {LastName} -({Age})  Salaris: {Salaris}";
    }


}

        
    



