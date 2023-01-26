using System.Data;

namespace Pankki
{
    public class Pankkitili
    {
        private readonly string m_asiakkaanNimi;
        private double m_saldo;

        private Pankkitili() { }

        public Pankkitili(string asNimi, double saldo)
        {
            m_asiakkaanNimi = asNimi;
            m_saldo = saldo;
        }

        public String AsiakkaanNimi { get { return m_asiakkaanNimi; } }

        public double Saldo { get { return m_saldo; } }

        public void Otto(double summa)
        {
            if (summa > m_saldo || summa < 0)
                throw new ArgumentOutOfRangeException("summa");          
            m_saldo -= summa;
        }

        public void Pano(double summa)
        {
            if (summa < 0)
                throw new ArgumentOutOfRangeException("summa");
            m_saldo -= summa;
        }
        public static void Main()
        {
            Pankkitili pt = new Pankkitili("Markus Kesseli", 1205.53);
            pt.Pano(300);
            pt.Otto(55.44);
            Console.WriteLine("Nykyinen saldo on {0} euroa", pt.Saldo);

        }
    }
}