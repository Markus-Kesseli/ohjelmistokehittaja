internal class Program
{
    private static void Main(string[] args)
    {
        int x, y, z; //otamme muuttujat käyttöön

        Console.Write("Anna ensimmäinen luku: "); //tässä pyydämme käyttäjää syöttämään arvot
        x = Convert.ToInt32(Console.ReadLine()); //tässä muutamme stringin integeriksi

        Console.Write("Anna toinen luku: ");
        y = Convert.ToInt32(Console.ReadLine());

        Console.Write("Anna kolmas luku: ");
        z = Convert.ToInt32(Console.ReadLine());

        if (x > y) //tässä vertaamme kumpi muuttuja on isompi
        {
            if (x > z)
            {
                Console.Write(x + " on suurin."); //tässä tulostamme isomman muuttujan konsoliin
            }
            else
            {
                Console.Write(z + " onsuurin.");
            }
        }
        else if (y > z)
            Console.Write(y + " on suurin");
        else
            Console.Write(z + " on suurin");


    }
}