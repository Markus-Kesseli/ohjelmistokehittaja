using System.IO;
using System.Windows.Forms;

namespace Kahvio
{
    public partial class ruokalistaForm : Form
    {
        public ruokalistaForm()
        {
            InitializeComponent();
            meistaPL.Visible = true;
        }

        private void ruokalistaForm_Load(object sender, EventArgs e)
        {
            meistaLB.Text = "Keudan oppilaskunnan kahvila palvelee luokassa 320 välituntisin \n";
            meistaLB.Text += "9:00 - 14:30 joka päivä maanantaista torstaisin ja perjantaisin \n";
            meistaLB.Text += "9:00 - 12:30. \n\n Keuda oppilaskunnan kahvilasta saa lämpimien \n";
            meistaLB.Text += "juomien lisäksi virvokkeita sekä pientä purtavaa sekä makeisia \n";
            meistaLB.Text += "Tervetuloa tutustumaan!";
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void meistaBT_Click(object sender, EventArgs e)
        {
            meistaPL.Visible = true;
            ruoatPL.Visible = false;
            juomatPL.Visible = false;
            herkutPL.Visible = false;
            koriPL.Visible = false;
        }

        private void ruoatBT_Click(object sender, EventArgs e)
        {
            meistaPL.Visible = false;
            ruoatPL.Visible = true;
            juomatPL.Visible = false;
            herkutPL.Visible = false;
            koriPL.Visible = false;
        }

        private void juomatBT_Click(object sender, EventArgs e)
        {
            meistaPL.Visible = false;
            ruoatPL.Visible = false;
            juomatPL.Visible = true;
            herkutPL.Visible = false;
            koriPL.Visible = false;
        }

        private void herkutBT_Click(object sender, EventArgs e)
        {
            meistaPL.Visible = false;
            ruoatPL.Visible = false;
            juomatPL.Visible = false;
            herkutPL.Visible = true;
            koriPL.Visible = false;
        }

        private void koriBT_Click(object sender, EventArgs e)
        {
            meistaPL.Visible = false;
            ruoatPL.Visible = false;
            juomatPL.Visible = false;
            herkutPL.Visible = false;
            koriPL.Visible = true;
        }

        private void suljeBT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}