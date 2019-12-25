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
    public partial class PretragaTermina : Form
    {
        public PretragaTermina()
        {
            InitializeComponent();
        }

        private void PretragaTermina_Load(object sender, EventArgs e)
        {
            KontrolerKorisnickogInterfejsa.KontrolerKI.popuniComboPacijent(cmbPacijent);
        }

        private void cmbPacijent_SelectedIndexChanged(object sender, EventArgs e)
        {
            KontrolerKorisnickogInterfejsa.KontrolerKI.PretraziTermine(cmbPacijent, dataGridView1);
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (KontrolerKorisnickogInterfejsa.KontrolerKI.UcitajTermin(dataGridView1)) new DetaljiTermina().ShowDialog();
        }
    }
}
