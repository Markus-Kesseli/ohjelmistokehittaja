internal class Program
{
    private static void Main(string[] args)
    {
        int x; 
        for (x = 1; x <= 99; x++)
        {
            if (x % 2 != 0)
            {
                Console.Write(x + ", ");
            }
        }
    }
}