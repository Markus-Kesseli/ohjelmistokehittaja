internal class Program
{
    private static void Main(string[] args)
    {
        int x, y;       //Tässä otamme muuttujat x ja y käyttöön
        var i = 1.8;    //tässä otamme muuttujan i käyttöön sekä määritämme sille arvon
        var j = 32;     //tässä otamme muuttujan i käyttöön sekä määritämme sille arvon


        Console.Write("Muunna celcius Fahrenheiteiksi: "); //Tässä pyydämme käyttäjää syöttämään jonkin arvon.
        x = Convert.ToInt32(Console.ReadLine());   //Tässä muutamme stringin integeriksi

        var k = x * i + j; //tässä otamme muuttuja k käyttöön sekä määritämme arvon
        

        Console.WriteLine(x + " Celciusta " + " on " + k + " Fahrenheitiä."); //Tässä tulostamme käyttäjän antaman arvon

    }
}