using System;
using System.Diagnostics;
using System.Threading;

namespace SekuntiKello
{
    public partial class Form1 : Form
    {
        private Stopwatch stopWatch;
        public Form1()
        {
            InitializeComponent();
        }

        private void startBT_Click(object sender, EventArgs e)
        {
            stopWatch.Start();
        }

        private void stopBT_Click(object sender, EventArgs e)
        {
            stopWatch.Stop();
        }

        private void resetBT_Click(object sender, EventArgs e)
        {
            stopWatch.Reset();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            stopWatch = new Stopwatch();
        }

        private void ajastinTM_Tick(object sender, EventArgs e)
        {
            aikaLB.Text = stopWatch.Elapsed.ToString();
        }
    }
}