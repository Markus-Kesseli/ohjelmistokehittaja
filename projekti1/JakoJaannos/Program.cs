internal class Program
{
    private static void Main(string[] args)
    {
        int x, y; //tässä otamme muuttujia käyttöön

        Console.Write("Anna ensimmäinen numero: "); //Tässä pyydetään käyttäjää syöttämään jokin arvo. 
        x = Convert.ToInt32(Console.ReadLine());

        Console.Write("Anna toinen numero: ");  //Tässä pyydetään käyttäjää syöttämään jokin arvo.
        y = Convert.ToInt32(Console.ReadLine());


        var laske = x % y; //tässä otamme muuttujan käyttöön sekä määrittelemme sille arvot
        
        

        Console.WriteLine(laske); //tulostamme consoliin laskettu luku.
    }
}