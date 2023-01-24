internal class Program
{
    private static void Main(string[] args)
    {
        
        Console.Write("Kirjoita jokin teksti: ");
        string sana = Console.ReadLine();

        string pisin = "";

        foreach (string word in sana.Split(' '))
        {
            if (word.Length > pisin.Length)
            {
                pisin = word;
            }
        }
        Console.WriteLine(pisin);

    }
}