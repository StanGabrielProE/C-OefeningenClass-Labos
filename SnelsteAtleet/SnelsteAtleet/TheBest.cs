using System.Text;

namespace SnelsteAtleet;


public class TheBest
{
    private CompetitorsRepo _competitors { get; set; }

    public string Sneelste => Winner(_competitors);
    public string Competitors => AddCompetitors(_competitors);

        public TheBest(CompetitorsRepo deposit)
    {
        _competitors = deposit;
       
    }

    private string Winner(CompetitorsRepo depo)
    {
        if (depo[0] != null)
        {
            depo.SortAscending();
            return depo[0].ToString();
        }
        else
        {
            return "Null";
        }
    }

    private string AddCompetitors(CompetitorsRepo depo)
    {
        StringBuilder builder = new StringBuilder();
        for (int i = 0; i < depo.Length; i++)
        {
            builder.AppendLine(string.Format("Name : {0} Time : {1}s\n", depo[i].Name, depo[i].Time));
        }
        return builder.ToString();  
    }
}




