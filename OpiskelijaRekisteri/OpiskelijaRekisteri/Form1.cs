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
using System.Data;

namespace OpiskelijaRekisteri
{
    public partial class Form1 : Form
    {
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
            tietotauluDG.DataSource = OPISKELIJA.haeOpiskelijat();
        }
    }
}
