internal class Program
{
    private static void Main(string[] args)
    {

        int x, y;
        

        Console.Write("Anna ensimmäinen numero: ");
        x = Convert.ToInt32(Console.ReadLine());

        Console.Write("Anna toinen numero: ");
        y = Convert.ToInt32(Console.ReadLine());

        int a = x + y;
        int b = x / y;
        int c = x * y;
        int d = x - y;

        Console.WriteLine(x + " + " + y + " = " + a);
        Console.WriteLine(x + " / " + y + " = " + b);
        Console.WriteLine(x + " * " + y + " = " + c);
        Console.WriteLine(x + " - " + y + " = " + d);

       

        /*
         
         //Tässä tehtävä 3

        int q = 5;
        int w = 8;
        int e = q + w;
        int r = q / w;
        int t = q * w;
        int u = q - w;

        Console.WriteLine(e);
        Console.WriteLine(r);
        Console.WriteLine(t);
        Console.WriteLine(u);
        */
    }
}