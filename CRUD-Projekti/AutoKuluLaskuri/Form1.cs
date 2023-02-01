namespace AutoKuluLaskuri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void kilometritCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            double laina, nesteet, vakuutus, pesut, huollot, renkaat, muut, kilometrit, polttoaine, kustannukset, kuukaudet;
            laina = Convert.ToDouble(lainaTB.Text);
            nesteet = Convert.ToDouble(nesteetTB.Text);
            vakuutus = Convert.ToDouble(vakuutusTB.Text);
            pesut = Convert.ToDouble(pesutTB.Text);
            huollot = Convert.ToDouble(huoltoTB.Text);
            renkaat = Convert.ToDouble(renkaatTB.Text);
            muut = Convert.ToDouble(muutTB.Text);
            kilometrit = Convert.ToDouble(kilometritCB.Text);
            polttoaine = Convert.ToDouble(polttoaineTB.Text);
            kuukaudet = 12;
            kustannukset = (laina + nesteet + vakuutus + pesut + huollot + renkaat + muut) / (kilometrit / kuukaudet);
            vastausLB.Text = "Kustannukset kilometriä kohden ovat: " + kustannukset + "€";
            vastausLB.Visible = true;
        }
    }
}