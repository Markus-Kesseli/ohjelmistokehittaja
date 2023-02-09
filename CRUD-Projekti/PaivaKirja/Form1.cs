using System.IO;

namespace PaivaKirja
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string teksti = File.ReadAllText("C:/temp/paivakirja.txt");
            tekstiTB.Text = teksti;
        }

        private void tallennaBT_Click(object sender, EventArgs e)
        {
            string teksti = "";
            teksti += tekstiTB.Text;
            teksti += " " + DateTime.Now.ToString("dd.MM.yyyy HH:mm") + "\n";
            TextWriter text = new StreamWriter("C:/temp/paivakirja.txt");
            text.Write(teksti);
            text.Close();
            Application.Exit();
        }
    }
}