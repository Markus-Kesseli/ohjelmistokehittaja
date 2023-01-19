internal class Program
{
    private static void Main(string[] args)
    {
        int x, y;
        var i = 1.8;
        var j = 32;
        

        Console.Write("Muunna celcius Fahrenheiteiksi: ");
        x = Convert.ToInt32(Console.ReadLine());

        var k = x * i + j;
        

        Console.WriteLine(x + " Celciusta " + " on " + k + " Fahrenheitiä.");

    }
}