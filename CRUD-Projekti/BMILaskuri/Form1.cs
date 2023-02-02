namespace BMILaskuri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void laskeBT_Click(object sender, EventArgs e)
        {
            double paino = 0, pituus = 0;
            paino = Convert.ToDouble(painoTB.Text);
            pituus = Convert.ToDouble(pituusTB.Text);
            double bmi = Math.Round(paino / (pituus * pituus), 2);
            
            if(bmi < 18.5)
            {
                tulosLB.Text = "Painoindeksisi on: " + bmi;
                tulosLB.ForeColor= Color.Aqua;
                tulosLB.Visible = true;
                painoLB.Text = "Alipaino";
                painoLB.ForeColor = Color.Aqua;
                painoLB.Visible = true;
            }
            else if(bmi < 25)
            {
                tulosLB.Text = "Painoindeksisi on: " + bmi;
                tulosLB.ForeColor = Color.Green;
                tulosLB.Visible = true;
                painoLB.Text = "Normaalipaino";
                painoLB.ForeColor = Color.Green;
                painoLB.Visible = true;
            }
            else if(bmi < 40)
            {
                tulosLB.Text = "Painoindeksisi on: " + bmi;
                tulosLB.ForeColor = Color.Gold;
                tulosLB.Visible = true;
                painoLB.Text = "ylipaino";
                painoLB.ForeColor = Color.Gold;
                painoLB.Visible = true;
            }

            else
            {
                tulosLB.Text = "Painoindeksisi on: " + bmi;
                tulosLB.ForeColor = Color.Red;
                tulosLB.Visible = true;
                painoLB.Text = "Huomattava ylipaino!";
                painoLB.ForeColor = Color.Red;
                painoLB.Visible = true;
            }

        }
    }
}