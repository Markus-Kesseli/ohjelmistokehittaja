internal class Program
{
    private static void Main(string[] args)
    {
        int x, y;

        Console.Write("Anna ensimmäinen luku: ");
        x = Convert.ToInt32(Console.ReadLine());

        Console.Write("Anna toinen luku: ");
        y = Convert.ToInt32(Console.ReadLine());


        if (x > y)
            {
                Console.Write(x + "" + y);
            }
            else
            {
                Console.Write(y + "" + x);
            }
        
    }
}