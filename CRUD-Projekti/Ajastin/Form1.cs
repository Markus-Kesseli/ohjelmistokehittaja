using System.IO;

namespace Ajastin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int kokonaisaika;

        private void aloitaBT_Click(object sender, EventArgs e)
        {
            aloitaBT.Enabled = false;
            lopetaBT.Enabled = true;

            int minuutit = int.Parse(minuutitCB.SelectedIndex.ToString());
            int sekunnit = int.Parse(sekunnitCB.SelectedIndex.ToString());
            kokonaisaika = (minuutit * 60) + sekunnit;
            aikaTM.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lopetaBT.Enabled= false;
            for(int i=0; i < 60; i++) 
            {
                minuutitCB.Items.Add(i.ToString());
                sekunnitCB.Items.Add(i.ToString());
            }
            minuutitCB.SelectedIndex = 30;
            sekunnitCB.SelectedIndex = 0;
        }

        private void lopetaBT_Click(object sender, EventArgs e)
        {
            aloitaBT.Enabled = true;
            lopetaBT.Enabled = false;
            kokonaisaika = 0;
            aikaTM.Enabled = false;
            aikaLB.Text = "00:00";
        }

        private void aikaTM_Tick(object sender, EventArgs e)
        {
            if(kokonaisaika > 0)
            {
                kokonaisaika--;
                int minuutit = kokonaisaika / 60;
                int sekunnit = kokonaisaika - (minuutit * 60);
                aikaLB.Text = minuutit.ToString() + ":" + sekunnit.ToString();
            }
            else
            {
                aikaTM.Stop();
                MessageBox.Show("Aikasi loppui!");
            }
        }
    }
}