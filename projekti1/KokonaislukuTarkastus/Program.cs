internal class Program
{
    private static void Main(string[] args)
    {
        
        int x, y;

        Console.Write("Anna ensimmäinen numero: "); //tässä pyydemmä käyttäjää antamaan jonkin arvon
        x = Convert.ToInt32(Console.ReadLine());

        Console.Write("Anna ensimmäinen numero: "); //tässä pyydemmä käyttäjää antamaan jonkin arvon
        y = Convert.ToInt32(Console.ReadLine());


        if (x > 0 && y > 0)
        {
            Console.WriteLine("Luvut ovat positiivia");
        }
        else if (x < 0 && y < 0)
        {
            Console.WriteLine("Luvut ovat negatiivisia.");
        }
        else
        {
            Console.WriteLine("Toinen luvuista on positiivinen ja toinen ei.");
        }
    }
}