using PankkiTestaus;
using Pankki;
namespace PankkiTestaus
{
    [TestClass]
    public class PankkitiliTestaus
    {
        [TestMethod]
        public void Otto_OikeallaSummalla_PaivitaSaldo()
        {
            double alkusaldo = 11.99;
            double ottosumma = 4.55;
            double oletettu = 7.44;
            Pankkitili tili = new Pankkitili("Jaakko Tarvainen", alkusaldo);

            tili.Otto(ottosumma);

            double todellinen = tili.Saldo;
            Assert.AreEqual(oletettu, todellinen, 0.001, "Tililtä otto ei ole mahdollista!");
        }
    }
}