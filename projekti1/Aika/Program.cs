internal class Program
{
    
    private static void Main(string[] args)
    {
        DateTime now = DateTime.Now; //tässä määritämme tämän hetkisen kellonajan sekä päivän.
        string aika = now.ToString("dd/MM/yyyy HH:mm:ss"); //tässä muokkaamme määritettyä kelloa, päivää, kuukautta sekä vuotta
        Console.WriteLine(aika); //tässä tulostamme konsoliin määritetyn ajan.
    }
}