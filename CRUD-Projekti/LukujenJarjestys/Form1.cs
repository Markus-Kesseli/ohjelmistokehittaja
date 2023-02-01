namespace LukujenJarjestys
{
    public partial class Form1 : Form
    {
        List<int> jono = new List<int>();
        public Form1()
        {
            InitializeComponent();
        }

        private void uusilukuTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter) 
            {
                if (uusilukuTB.Text == "-999")
                {
                    vastausLB.Text = "";
                    int[] taulukko = jono.ToArray();
                    Array.Sort(taulukko);
                    foreach (var jasen in taulukko)
                    {
                        vastausLB.Text += jasen + " ";
                    }
                    vastausLB.Visible = true;
                }
                else
                {
                    jono.Add(Int32.Parse(uusilukuTB.Text));
                    uusilukuTB.Text = "";
                }
            }
            if(e.KeyChar == (char)Keys.Escape)
            {
                tyhjaalomake();
            }
            
        }
        private void tyhjaalomake()
        {
            uusilukuTB.Text = "";
        }
    }
}