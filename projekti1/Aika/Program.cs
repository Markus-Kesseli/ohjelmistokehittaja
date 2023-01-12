internal class Program
{
    
    private static void Main(string[] args)
    {
        DateTime now = DateTime.Now;
        string aika = now.ToString("dd/MM/yyyy HH:mm:ss");
        Console.WriteLine(aika);
    }
}