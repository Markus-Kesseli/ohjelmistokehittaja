using System.Diagnostics;

namespace SekuntiKello
{
    public partial class Form1 : Form
    {
        private Stopwatch sekkari = new Stopwatch();
        public Form1()
        {
            InitializeComponent();
        }

        private void aikaLB_Click(object sender, EventArgs e)
        {

        }

        private void startBT_Click(object sender, EventArgs e)
        {
            sekkari.Start();
        }

        private void stopBT_Click(object sender, EventArgs e)
        {
            sekkari.Stop();
        }

        private void resetBT_Click(object sender, EventArgs e)
        {
            sekkari.Reset();
        }

        private void aikaTM_Tick(object sender, EventArgs e)
        {
            aikaLB.Text = String.Format("{0:hh\\:mm\\:ss\\:fff}", sekkari.Elapsed);
        }
    }
}