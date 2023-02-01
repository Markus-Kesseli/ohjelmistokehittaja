namespace Salasanantarkastus
{
    public partial class salasanaForm : Form
    {
        public salasanaForm()
        {
            InitializeComponent();
        }

        private void tarkistaBT_Click(object sender, EventArgs e)
        {
            salasanaTB.PasswordChar = '*';
            if(kayttajaTB.Text == "Markus" && salasanaTB.Text == "Kesseli")
            {
                salasanaPanel.Visible = false;
                SalasanaOikeinPanel.Visible = true;
            }
            else
            {
                virheviestiLB.Text = "Käyttäjätunnus tai salasana virheellinen!";
                virheviestiLB.Visible = true;
            }

        }

        private void salasanaTB_TextChanged(object sender, EventArgs e)
        {
            salasanaTB.PasswordChar = '*';
        }
    }
}