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
    public partial class UnosIntervencije : Form
    {
        public UnosIntervencije()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            KontrolerKorisnickogInterfejsa.KontrolerKI.KreirajIntervenciju(txtID,gbIntervencija,btnKreiraj);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (KontrolerKorisnickogInterfejsa.KontrolerKI.ZapamtiIntervenciju(txtNaziv)) this.Close();
        }
    }
}
