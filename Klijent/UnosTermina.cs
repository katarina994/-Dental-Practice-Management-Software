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
    public partial class UnosTermina : Form
    {
        public UnosTermina()
        {
            InitializeComponent();
        }

        private void btnKreiraj_Click(object sender, EventArgs e)
        {
            KontrolerKorisnickogInterfejsa.KontrolerKI.KreirajTermin(txtID, btnKreiraj, gbTermin, cmbIntervencija, cmbPacijent,dgvGrid);
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
    }
}
