namespace PaivaKirja
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void uusiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Text = "teksti.txt";
            tekstiRTB.Clear();
        }

        private void avaaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog avaa = new OpenFileDialog();
            avaa.Filter = "Tekstitiedosto(*.txt)|*.txt";
            if(avaa.ShowDialog() == DialogResult.OK) 
            {
                tekstiRTB.LoadFile(avaa.FileName, RichTextBoxStreamType.PlainText);
                this.Text = avaa.FileName;
            }
        }

        private void tallennaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog tallenna = new SaveFileDialog();
            tallenna.Filter = "Tekstitiedosto(*.txt)|*.txt";
            if(tallenna.ShowDialog() == DialogResult.OK)
            {
                tekstiRTB.SaveFile(tallenna.FileName, RichTextBoxStreamType.PlainText);
                this.Text = tallenna.FileName;
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}