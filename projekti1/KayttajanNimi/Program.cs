internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Anna käyttäjänimi: "); //Tässä voimme tehdä kohdan johon käyttäjä voi kirjoittaa
        string enimi = Console.ReadLine(); // tässä määritämme Enimille käyttäjän kirjoittaman tekstin.


        Console.WriteLine("Hei " + enimi + " (" + enimi + " tässä annettu käyttäjä)");
        //*Console.WriteLine("Heippa {0} {1}", enimi, snimi);
    }
}