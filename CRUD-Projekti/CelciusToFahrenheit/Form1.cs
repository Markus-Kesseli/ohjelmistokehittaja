namespace CelciusToFahrenheit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void muunnaBT_Click(object sender, EventArgs e)
        {
            double vastaus;
            double asteet = Convert.ToDouble(lukuTB.Text);
            if(celsiusRB.Checked)  
            {
                vastaus = asteet * 1.8 + 32;
                vastausLB.Text = asteet + " Celsiusta on " + vastaus + " fahrenheit astetta";
                vastausLB.Visible = true;
            }
            else if(fahrenheitRB.Checked) 
            {
                vastaus = (asteet - 32) / 1.8;
                vastausLB.Text = asteet + " Fahrenheitia on " + vastaus + " Celsius astetta";
                vastausLB.Visible = true;
            }
            else
            {
                vastausLB.Text = "Et valinnut muunnettavaa astetta tai antanut oikeaa lukua";
                vastausLB.Visible = true;
            }
        }
    }
}