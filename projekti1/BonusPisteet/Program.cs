internal class Program
{
    private static void Main(string[] args)
    {
        int x;
        int y = 0;


        Console.Write("Anna numero 1-9 väliltä: ");
        x = Convert.ToInt32(Console.ReadLine());

        if (x >= 1 && x <= 3)
        {
            y = x * 10;
        }
        else if (x >= 4 && x <= 6)
        {
            y = x * 100;
        }
        else if (x >= 7 && x <= 9)
        {
            y = x * 1000;
        }
        else
        {
            Console.WriteLine("Et antanut luku 1-9 väliltä!");
        }
        Console.WriteLine("luvun " + x + " pisteet ovat: " + y);
    }
}