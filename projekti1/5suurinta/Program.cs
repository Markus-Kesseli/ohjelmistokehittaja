internal class Program
{
    private static void Main(string[] args)
    {
        int x, y, z, i, j; //tässä otamme käyttöön muuttujat

        Console.Write("Anna ensimmäinen numero: "); //tässä pyydemmä käyttäjää antamaan jonkin arvon
        x = Convert.ToInt32(Console.ReadLine());

        Console.Write("Anna toinen numero: ");
        y = Convert.ToInt32(Console.ReadLine());

        Console.Write("Anna kolmas numero: ");
        z = Convert.ToInt32(Console.ReadLine());

        Console.Write("Anna neljäs numero: ");
        i = Convert.ToInt32(Console.ReadLine());

        Console.Write("Anna viides numero: ");
        j = Convert.ToInt32(Console.ReadLine());

        int isoin = Math.Max(x, Math.Max(y, Math.Max(z, Math.Max(i, j)))); //tässä otamme käyttöön sekä määritämme muuttujan
        Console.WriteLine("Isoin luku on: " + isoin); //tässä tulostamme konsoliin käyttäjälle lasketun arvon

       

    }
}