using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Klijent
{
    public partial class DetaljiTermina : Form
    {
        public DetaljiTermina()
        {
            InitializeComponent();
        }

        private void DetaljiTermina_Load(object sender, EventArgs e)
        {
            KontrolerKorisnickogInterfejsa.KontrolerKI.PopuniPoljaTermin( txtVreme, dtpDatum, cmbIntervencija, dgvGrid,cmbPacijent);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KontrolerKorisnickogInterfejsa.KontrolerKI.DodajStavku(cmbIntervencija, txtBelska);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            KontrolerKorisnickogInterfejsa.KontrolerKI.ObrisiStavku(dgvGrid);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (KontrolerKorisnickogInterfejsa.KontrolerKI.SacuvajTermin(dtpDatum, txtVreme, cmbPacijent)) this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (KontrolerKorisnickogInterfejsa.KontrolerKI.OtkaziTermin()) this.Close();
        }
    }
}
