internal class Program
{
    private static void Main(string[] args)
    {
        int luku = 50; //tässä määritämme haluttu luku.
        float neliojuuri = (float)Math.Sqrt(luku); //tässä laskemme määritetyn luvun.
        
        //var laske = Math.Sqrt(50); (lyhyin tapa laskea)
        
        Console.WriteLine(neliojuuri); //tulostamme consoliin laskettu luku.
    }
}