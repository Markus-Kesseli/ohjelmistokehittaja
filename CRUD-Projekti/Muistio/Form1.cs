using System;
using System.IO;
using System.Drawing.Printing;
using System.Windows.Forms;
using Muistio;

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
            avaa.Filter = "Rich Text Format (*.rtf)|*.rtf|Text File (*.txt)|*.txt";
            if (avaa.ShowDialog() == DialogResult.OK) 
            {
                string fileExtension = Path.GetExtension(avaa.FileName);
                if (fileExtension == ".rtf")
                {
                    tekstiRTB.LoadFile(avaa.FileName, RichTextBoxStreamType.RichText);
                }
                else
                {
                    tekstiRTB.LoadFile(avaa.FileName, RichTextBoxStreamType.PlainText);
                }
                this.Text = avaa.FileName;
            }
        }

        private void tallennaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog tallenna = new SaveFileDialog();
            tallenna.Filter = "Rich Text Format (*.rtf)|*.rtf";
            if(tallenna.ShowDialog() == DialogResult.OK)
            {
                tekstiRTB.SaveFile(tallenna.FileName, RichTextBoxStreamType.RichText);
                this.Text = tallenna.FileName;
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            if(tekstiRTB.Text.Length > 0) 
            {
                kopioiToolStripMenuItem.Enabled = true;
                leikkaaToolStripMenuItem.Enabled = true;
            }
            else
            {
                kopioiToolStripMenuItem.Enabled = false;
                leikkaaToolStripMenuItem.Enabled = false;
            }
        }

        private void tallennaNimell‰ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog tallennus = new SaveFileDialog()
            { Filter = "Rich Text Format (*.rtf)|*.rtf|Tekstitiedosto (*.txt)|*.txt", ValidateNames = true })
            {
                if (tallennus.ShowDialog() == DialogResult.OK)
                {
                    if (tallennus.FilterIndex == 1)
                    {
                        tekstiRTB.SaveFile(tallennus.FileName, RichTextBoxStreamType.RichText);
                    }
                    else
                    {
                        tekstiRTB.SaveFile(tallennus.FileName, RichTextBoxStreamType.PlainText);
                    }
                    this.Text = tallennus.FileName;
                }
            }
            
        }

        private void tulostuksenEsikatseluToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void tulostaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            if(printDialog1.ShowDialog() == DialogResult.OK) 
            {
                printDocument1.Print();
            }
        }

        private void poistuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tekstiRTB.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tekstiRTB.Redo();
        }

        private void kopioiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tekstiRTB.Copy();
        }

        private void leikkaaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tekstiRTB.Cut();
        }

        private void liit‰ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tekstiRTB.Paste();
        }

        private void poistaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tekstiRTB.SelectedText = "";
        }

        private void valitseKaikkiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tekstiRTB.SelectAll();
        }

        private void kirjasinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            tekstiRTB.SelectionFont = new Font(fontDialog1.Font.FontFamily, fontDialog1.Font.Size, fontDialog1.Font.Style);
        }


        private void tekstinRivitysToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(tekstinRivitysToolStripMenuItem.Checked == true)
            {
                tekstinRivitysToolStripMenuItem.Checked = false;
                tekstiRTB.WordWrap = false;
            }
            else
            {
                tekstinRivitysToolStripMenuItem.Checked = true;
                tekstiRTB.WordWrap = true;
            }
        }

        private void tietoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tietoa tietoa = new tietoa();
            tietoa.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(tekstiRTB.Text, tekstiRTB.Font, Brushes.Black, 12, 10);
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void tekstinKorostusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tekstiRTB.SelectionBackColor = Color.Red;
        }
    }
}