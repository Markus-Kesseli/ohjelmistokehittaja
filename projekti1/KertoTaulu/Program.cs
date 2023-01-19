using System;


internal class Program
{
    private static void Main(string[] args)
    {
        int i, x;
        Console.Write("Anna jokin numero 1-10 välillä: "); //tässä pyydämme käyttäjää syöttämään luku.
        x = Convert.ToInt32(Console.ReadLine());

        for (i = 1; i <= 10; i++) //tässä käymme loopilla 10 kertaa annettu luku läpi
        {
                       
            Console.Write("{0} X {1} = {2} \n", x, i, x * i); //tässä tulostamme ja tulostamme loopin läpi käyneet luvut
        }
        
    }
}