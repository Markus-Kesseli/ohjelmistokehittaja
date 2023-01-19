internal class Program
{
    private static void Main(string[] args)
    {
        int x, y;


        Console.Write("Anna ensimmäinen numero: ");
        x = Convert.ToInt32(Console.ReadLine());

        Console.Write("Anna toinen numero: ");
        y = Convert.ToInt32(Console.ReadLine());

        int i = x + y;

        Console.WriteLine(x + " + " + y + " = " + i);
    }
}