internal class Program
{
    private static void Main(string[] args)
    {
        int x, y, z;

        Console.Write("Anna ensimmäinen luku: ");
        x = Convert.ToInt32(Console.ReadLine());

        Console.Write("Anna toinen luku: ");
        y = Convert.ToInt32(Console.ReadLine());

        Console.Write("Anna kolmas luku: ");
        z = Convert.ToInt32(Console.ReadLine());

        if (x > y)
        {
            if (x > z)
            {
                Console.Write(x + " on suurin.");
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