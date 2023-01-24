using System.Xml;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Anna Kokonaisluku: "); //pyydämme käyttäjää antamaan arvon.
        for (int i = 1; i <= 10; i++) //Otamme käyttöön muuttujan johon tallennamme käyttäjän arvon.

        {   //otamme muuttujan käyttöö,
            int num = Convert.ToInt32(Console.ReadLine());
            for (int j = 1; j <= num; j++) //käymme muuttujan tallenttua arvoa 10 kertaa läpi.
               
            {
                Console.Write(num + " "); //tulostamme arvon.
                
            }

            Console.WriteLine();

            for (int j = 1; j <= num; j++) //käymme tallennettua arvoa 10 kertaa läpi.

            {
                
                Console.Write(num); //tulostamme arvon.

            }
        }
    }
}