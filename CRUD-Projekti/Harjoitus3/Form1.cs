namespace Harjoitus3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void laskeBT_Click(object sender, EventArgs e)
        {
            double luku1 = double.Parse(lukuyksiTB.Text);

            double luku2 = double.Parse(lukukaksiTB.Text);

            string merkki = laskutoimitusCB.Text;

            double vastaus = 0;

            switch (merkki)
            {
                case "+":
		vastaus = luku1 + luku2;
                    break;

                case "-":
		vastaus = luku1 - luku2;
                    break;

                case "*":
		vastaus = luku1 * luku2;
                    break;

                case "/":
		vastaus = luku1 / luku2;
                    break;

                default:
                    vastausLB.Text = "Virheelliset syötöt!";
                    break;
            }
            vastausLB.Text = vastaus.ToString();
            vastausLB.Visible = true;
        }
    }
}