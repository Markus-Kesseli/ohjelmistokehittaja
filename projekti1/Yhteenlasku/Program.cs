internal class Program
{
    private static void Main(string[] args)
    {
        int x, y; //tässä otamme muuttujia käyttöön


        Console.Write("Anna ensimmäinen numero: "); //tässä pyydämme käyttäjää syöttämään arvon.
        x = Convert.ToInt32(Console.ReadLine()); //tässä muutamme stringin integeriksi.

        Console.Write("Anna toinen numero: ");
        y = Convert.ToInt32(Console.ReadLine());

        int i = x + y; //tässä otamme muuttujan käyttöön sekä määritämme sille arvon

        Console.WriteLine(x + " + " + y + " = " + i); //tässä tulostamme konsoliin käyttäjän syöttämät arvot sekä niiden summan.
    }
}