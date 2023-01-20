using System.Xml;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Anna Kokonaisluku: ");
        for (int i = 1; i <= 10; i++) 
        {
            int num = Convert.ToInt32(Console.ReadLine());
            for (int j = 1; j <= num; j++)
               
            {
                Console.Write(num + " ");
                
            }

            Console.WriteLine();

            for (int j = 1; j <= num; j++)

            {
                
                Console.Write(num);

            }
        }
    }
}