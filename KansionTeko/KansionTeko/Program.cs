using System;
using System.IO;

class Kansio
{
    static void Main(string[] args)
    {
        // Kansion sijainti
        string sijainti = @"C:\TestiKansio";

        // kansion olemassaolon tarkastass
        if (!Directory.Exists(sijainti))
        {
            // Luo kansio
            Directory.CreateDirectory(sijainti);

            Console.WriteLine("Kansion luonti onnistui: " + sijainti);
        }
        else
        {
            Console.WriteLine("Kansio on olemassa jo: " + sijainti);
        }
    }
}
