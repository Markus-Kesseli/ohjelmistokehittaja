internal class Program
{
    private static string VaihdaEkaVika(string str)
    {
       
        Console.Write("Anna nimi/sana: ");
        string eka = Console.ReadLine();

        return str.Length > 1 ? str.Substring(str.Length - 1) + str.Substring(1, str.Length - 2)
        + str.Substring(0, 1) : str;
    }

    public static void Main(string[] args)
    {
        Console.WriteLine(VaihdaEkaVika("Markus"));

        Console.ReadKey();

    }

}