internal class Program
{
    private static void Main(string[] args)
    {
        int x; //tässä otamme muuttu x käyttöön

        Console.Write("Anna ikäsi: ");// tässä pyydämme käyttäjää syöttämään arvo
        x = Convert.ToInt32(Console.ReadLine()); //tässä muutamme stringin integeriksi.

        if (x > 17) //Tässä ohjelma kertoo yli 18 annetuilla luvuilla käyttäjän olevan täysi-ikäinen
                   
        {
            Console.WriteLine(x + " olet täysi-ikäinen.");
        }
        else  //Tässä määritämme että jos käyttäjä syöttää alle 18 niin ohjelma kertoo käyttäjän olevan alaikäinen 
        {
            Console.WriteLine(x + " olet alaikäinen.");
        }
    }
}