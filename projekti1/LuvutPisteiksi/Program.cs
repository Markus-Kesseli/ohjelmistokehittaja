internal class Program
{
    private static void Main(string[] args)
    {
        int x, a, b, c;

        Console.Write("Choose your input data:\n 1 --> int:\n 2 --> double:\n 3 --> string:\n ...and press ENTER");
        x = Convert.ToInt32(Console.ReadLine());

        switch(x) 
        {
            case 1:
                Console.WriteLine("Enter your INT number: ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Result is {0}", (a + 1));
                break;

            case 2:
                Console.WriteLine("Enter your DOUBLE number: ");
                b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Result is {0}", (b + 1));
                break;

            case 3:
                Console.WriteLine("Enter your INT number: ");
                c = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Result is {0}", (c + "*"));
                break;

            default:
                Console.WriteLine("invalid");
                break;





        }
    }
}