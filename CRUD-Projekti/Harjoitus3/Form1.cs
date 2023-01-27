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
                    MessageBox.Show("Virheelliset syötöt!");
                    break;
            }
            vastausLB.Text = vastaus.ToString();
            vastausLB.Visible = true;
        }

        private void lukuyksiTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void lukukaksiTB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}