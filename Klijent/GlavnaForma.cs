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
    public partial class GlavnaForma : Form
    {
        public GlavnaForma()
        {
            InitializeComponent();
        }

        private void GlavnaForma_FormClosed(object sender, FormClosedEventArgs e)
        {
            KontrolerKorisnickogInterfejsa.KontrolerKI.kraj();
        }

        private void unosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new UnosPacijenta().ShowDialog();
        }

        private void pretragaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new PretragaPacijenata().ShowDialog();
        }

        private void unosTerminaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new UnosTermina().ShowDialog();
        }

        private void pretragaTerminaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new PretragaTermina().ShowDialog();
            this.Show();
        }

        private void unosIntervencijeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new UnosIntervencije().ShowDialog();
            this.Show();
        }
    }
}
