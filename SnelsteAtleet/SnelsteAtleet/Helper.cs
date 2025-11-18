namespace SnelsteAtleet;

public static class Helper
{
    public static void AskDetail(this Func<string> input, Func<string, bool> del, string message, out string value)
    {
        string str;

        do
        {
            Console.WriteLine(message);
            str = input();
            value = str;
        } while (!del(str));

    }

}
