using System.Globalization;
using System.Text;

namespace Test2;

internal class Program
{


    static void Main(string[] args)
    {
        bool session1 = false;
        bool session2 = false;
        StartApp(ref session1, ref session2);
        Console.ReadKey();

    }

    private static DateTime DateTimeParser(string input)
    {
        string tijd = input.Trim();
        DateTime date;
        bool isValid = DateTime.TryParseExact(tijd, "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out date);


        while (!isValid)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Enter Your Date in this format : dd/MM/yyyy HH:mm");
            Console.ForegroundColor = ConsoleColor.White;
            tijd = Console.ReadLine();
            isValid = DateTime.TryParseExact(tijd, "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out date);
         
        }
      
        return date;
    }


    internal static DateTime Session(string message, ConsoleColor color, Predicate<DateTime> condition , ref bool session) // Met de predicate verdwijnen wij de duplicaat daaroom
    {
        string input = string.Empty;
        DateTime date;
        Console.ForegroundColor = color;
        do
        {
            Console.WriteLine(message);
            input = Console.ReadLine();
            date = DateTimeParser(input);

        } while (!condition(date));

        Console.ForegroundColor = ConsoleColor.White;
        return date;
    }


internal static void Header()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine(string.Format("{0,30}", "+-------------+"));
        sb.AppendLine(string.Format("{0,30}", "| P(arking)XL |"));
        sb.AppendLine(string.Format("{0,30}", "+-------------+"));

        Console.WriteLine(sb.ToString());
    }

    


    internal static void ErrorMessage(string message, ConsoleColor color)
    {
        Console.ForegroundColor = color;
        Console.WriteLine(message);
        Thread.Sleep(2000);
        Console.ForegroundColor = ConsoleColor.White;
        Console.Clear();
    }


    internal static int IntParser(string input)
    {
        bool isValid = int.TryParse(input, out int result);
        if (isValid)
        {
            return result;
        }

        return int.MinValue;
    }
    internal static void ShowMenu() 
    {
        Console.WriteLine("1- Start");
        Console.WriteLine("2- Stop");
        Console.WriteLine("3- Ticket");
        Console.WriteLine("4- sluit");
    }

    internal static void StartApp(ref bool session1, ref bool session2)
    {
        DateTime startDate = DateTime.MinValue;
        DateTime endDate = DateTime.MaxValue;

        string userInput;

        do
        {
            ShowMenu(); 

            userInput = Console.ReadLine();
            switch (userInput.Trim())
            {
               
                case "1":

                    startDate = Session(
                        "Enter a date and a time  must be the date of today and the time in the past",
                        ConsoleColor.Green,
                        d => d.Date == DateTime.Now.Date && d.TimeOfDay < DateTime.Now.TimeOfDay,
                        ref session1
                );
                    Console.Clear();

                    session1 = true; break;

                case "2" when !session1:

                    ErrorMessage(
                        "jij moet eerst een startdatum toevoegen",
                        ConsoleColor.Red
                        );

                    break;

                case "2" when session1:  

                    endDate = Session(
                        "Enter a date and a time  must be the date of today and the time in the Future",
                        ConsoleColor.DarkYellow,
                        d => d.Date == DateTime.Now.Date && d.TimeOfDay > DateTime.Now.TimeOfDay,
                        ref session2
                        );
                    Console.Clear();
                    session2 = true; break;

                case "3" when session1 && session2:

                    PrintTicket(startDate,endDate,BasicPriceCalculator); break;


                case "3" when !(session1 && session2):

                    ErrorMessage(
                        "Sorry mate no ticket to print yet  complete first and second step)",
                        ConsoleColor.Red
                        ); break;


                case "4":

                    Console.WriteLine("See Ya"); break;


                default:

                    ErrorMessage("Enter a valid input", ConsoleColor.Red); break;

            }

        } while (!userInput.Equals("4"));

    }





    internal static void PrintTicket(DateTime startDate, DateTime endDate, Func<TimeSpan, string> PriceCalculator)
    {
        Console.WriteLine();
        Header();
        Console.WriteLine();
    
        Console.WriteLine();

        TimeSpan span = endDate - startDate;
        string start = startDate.ToString("dd/MM/yyyy HH:mm");
        string end = endDate.ToString("dd/MM/yyyy HH:mm");
        string duration = $"{(int)span.TotalHours}h {span.Minutes}m";
        string price = PriceCalculator(span);

        StringBuilder sb = new StringBuilder();
        sb.AppendLine(string.Format("{0,30}", "----------------"));
        sb.AppendLine(string.Format("{0,30}", $"Starttijd: {start}"));
        sb.AppendLine(string.Format("{0,30}", $"Eindtijd:  {end}"));
        sb.AppendLine(string.Format("{0,30}", $"Duur:      {duration}"));
        sb.AppendLine(string.Format("{0,30}", price));

        Console.WriteLine(sb.ToString());
    }

    // omdat in de toekomst misschien kan uitbreden in andere tarieven
    public static  Func<TimeSpan, string> BasicPriceCalculator = (span) =>
    {
        Console.WriteLine();
        Console.OutputEncoding = Encoding.UTF8;



        int time = (int)(span.TotalMinutes - 15) / 30;


        double price;
        if (time <= 0)
        {
            return $"Total minutes: {span.TotalMinutes}\n Cost :{0:C}";
        }
        else
        {
            price = time * 0.6D;
            if (price >= 8)
            {

                return $"Total minutes {span.TotalMinutes}\n Cost :{8:C}";
            }
            else
            {
                return $"Total minutes {span.TotalMinutes}\n Cost :{price:C}";

            }
        }
    };         

}