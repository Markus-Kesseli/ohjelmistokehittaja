
class Program
{
    //täällä otamme kiinteät stringit käyttöön sekä määrittelemme ne
    static string[] ykköset = { "nolla", "yksi", "kaksi", "kolme", "neljä", "viisi", "kuusi", "seitsemän", "kahdeksan", "yhdeksän" };
    static string[] kymmenet = { "", "kymmenen", "kaksikymmentä", "kolmekymmentä", "neljäkymmentä", "viisikymmentä", "kuusikymmentä", "seitsemänkymmentä", "kahdeksankymmentä", "yhdeksänkymmentä" };
    static string[] sadat = { "", "sata", "kaksisataa", "kolmesataa", "neljäsataa", "viisisataa", "kuusisataa", "seitsemänsataa", "kahdeksansataa", "yhdeksänsataa" };

    static void Main(string[] args)
    {
        Console.Write("Anna numero 0 ja 999 väliltä: "); //pyydämme käyttäjää syöttämään arvon
        int numero = int.Parse(Console.ReadLine()); //otamme muuttujan käyttöön sekä muutamme sen stringistä intiksi ja tallennamme käyttäjän antaman arvon.

        if (numero == 0) // tässä vertaamme onko numero 0
        {
            Console.WriteLine("Nolla");
            return;
        }
        //tässä otamme uusia muuttujia käyttöön sekä määrittelemme ne.
        int h = numero / 100; 
        int t = (numero / 10) % 10;
        int o = numero % 10;

        //tässä käymme läpi onko numerot nollia, kymmeniä vai satoja.
        if (h > 0)
        {
            Console.Write(sadat[h]);
        }
        if (t > 0)
        {
            Console.Write(kymmenet[t]);
        }
        if (o > 0)
        {
            Console.Write(ykköset[o]);
        }
    }
}