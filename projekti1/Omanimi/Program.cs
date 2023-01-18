internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Anna etunimesi: "); //Tässä voimme tehdä kohdan johon käyttäjä voi kirjoittaa
        string enimi = Console.ReadLine(); // tässä määritämme Enimille käyttäjän kirjoittaman tekstin.

        Console.Write("Anna sukunimesi: ");
        string snimi = Console.ReadLine();

        Console.WriteLine("Heippa, " + enimi + " " + snimi);
        //*Console.WriteLine("Heippa {0} {1}", enimi, snimi);
    }
}