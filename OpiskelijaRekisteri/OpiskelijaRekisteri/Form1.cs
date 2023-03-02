using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.Data;

namespace OpiskelijaRekisteri
{
    public partial class Form1 : Form
    {
        OPISKELIJA opiskelija = new OPISKELIJA();
        public Form1()
        {
            InitializeComponent();
        }

        private void tietotauluDG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            idLB.Text = tietotauluDG.CurrentRow.Cells[0].Value.ToString();
            enimiLB.Text = tietotauluDG.CurrentRow.Cells[1].Value.ToString();
            snimiLB.Text = tietotauluDG.CurrentRow.Cells[2].Value.ToString();
            puhLB.Text = tietotauluDG.CurrentRow.Cells[3].Value.ToString();
            emailLB.Text = tietotauluDG.CurrentRow.Cells[4].Value.ToString();
            onroLB.Text = tietotauluDG.CurrentRow.Cells[5].Value.ToString();
        }

        private void tyhjennaBT_Click(object sender, EventArgs e)
        {
            idLB.Text = "";
            enimiLB.Text = "";
            snimiLB.Text = "";
            puhLB.Text = "";
            emailLB.Text = "";
            onroLB.Text = "";
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tietotauluDG.DataSource = opiskelija.haeOpiskelijat();
            tietotauluDG.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            var datagridview = new DataGridView();
            datagridview.RowTemplate.MinimumHeight = 125;

        }

        private void tallennaBT_Click(object sender, EventArgs e)
        {
            String enimi = enimiLB.Text;
            String snimi = snimiLB.Text;
            String puh = puhLB.Text;
            String email = emailLB.Text;
            int oNro = Int32.Parse(onroLB.Text);

            if (enimi.Trim().Equals("") || snimi.Trim().Equals("") || puh.Trim().Equals("") || email.Trim().Equals("") || oNro.Equals(""))
            {
                MessageBox.Show("VIRHE - Vaaditut kentät - Etu ja sukunimi, Puhelin, Sähköposti ja opiskelijanumero", "Tyhjä kenttä", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Boolean lisaaOpiskelija = opiskelija.lisaaOpiskelija(enimi, snimi, puh, email, oNro);
                if (lisaaOpiskelija) 
                {
                    MessageBox.Show("Uusi opiskelija lisätty onnistuneesti", "opiskelijan lisäys", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Uutta opiskelijaa ei pystytty lisäämään", "Opiskelijan lisäys", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            tietotauluDG.DataSource = opiskelija.haeOpiskelijat();
        }

        private void poistaBT_Click(object sender, EventArgs e)
        {
            int ktunnus = Int32.Parse(idLB.Text);
            if (opiskelija.poistaOpiskelija(ktunnus))
            {
                tietotauluDG.DataSource = opiskelija.haeOpiskelijat();
                MessageBox.Show("Opiskelija poistettu onnistuneesti", "opiskelijan poisto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Opiskelijaa ei pystytty poistamaan", "opiskelijan poisto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            tyhjennaBT.PerformClick();
        }

        private void paivitaBT_Click(object sender, EventArgs e)
        {
            String enimi = enimiLB.Text;
            String snimi = snimiLB.Text;
            String puh = puhLB.Text;
            String email = emailLB.Text;
            int onro = Int32.Parse(onroLB.Text);
            int oid = Int32.Parse(idLB.Text);

            if (oid.Equals("") || enimi.Trim().Equals("") || snimi.Trim().Equals("") || puh.Trim().Equals("") || email.Trim().Equals("") || onro.Equals(""))
            {
                MessageBox.Show("VIRHE - Vaaditut kentät - Etu ja sukunimi, Puhelin, Sähköposti ja opiskelijanumero", "Tyhjä kenttä", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Boolean muokkaaOpiskelija = opiskelija.muokkaaOpiskelijaa(oid, enimi, snimi, puh, email, onro);
                if (muokkaaOpiskelija)
                {
                    MessageBox.Show("Opiskelija muokattu onistuneesti", "Opiskelijan muokkaus", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Opiskelijaa ei pystytty muokkaamaan", "Opiskelijan muokkaus", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            tietotauluDG.DataSource = opiskelija.haeOpiskelijat();
        }
    }
}
