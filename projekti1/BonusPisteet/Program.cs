internal class Program
{
    private static void Main(string[] args)
    {
        int x;
        int y = 0; //Tässä otamme muuttujat käyttöön sekä annamme niille arvot


        Console.Write("Anna numero 1-9 väliltä: "); //Tässä pyydämme käyttäjää syöttämään jonkin arvon
        x = Convert.ToInt32(Console.ReadLine());

        if (x >= 1 && x <= 3) //tässä kerromme kymmenellä 1-3 välillä olevat numerot  
        {
            y = x * 10;
        }
        else if (x >= 4 && x <= 6) //tässä kerromme sadalla 4-6 välillä olevat numerot  
        {
            y = x * 100;
        }
        else if (x >= 7 && x <= 9) //tässä kerromme tuhannella 7-9 välillä olevat numerot  
        {
            y = x * 1000;
        }
        else //tässä tulostamme konsoliin käyttäjälle virheen jos annettu arvo ei ole 1 ja 9 välillä
        {
            Console.WriteLine("Et antanut luku 1-9 väliltä!");
        }
        Console.WriteLine("luvun " + x + " pisteet ovat: " + y); //tässä tulostamme konsoliin käyttäjälle luvun ja sen pisteet
    }
}