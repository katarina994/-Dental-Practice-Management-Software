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
    public partial class PretragaPacijenata : Form
    {
        public PretragaPacijenata()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            KontrolerKorisnickogInterfejsa.KontrolerKI.PretraziPacijente(txtFilter, dataGridView1);
        }

        private void PretragaPacijenata_Load(object sender, EventArgs e)
        {
            KontrolerKorisnickogInterfejsa.KontrolerKI.PretraziPacijente(txtFilter, dataGridView1);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (KontrolerKorisnickogInterfejsa.KontrolerKI.UcitajPacijenta(dataGridView1)) new DetaljiPacijenta().ShowDialog();
        }
    }
}
