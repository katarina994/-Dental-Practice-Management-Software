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
    public partial class UnosPacijenta : Form
    {
        public UnosPacijenta()
        {
            InitializeComponent();
        }

        private void UnosPacijenta_Load(object sender, EventArgs e)
        {
            KontrolerKorisnickogInterfejsa.KontrolerKI.VratiSvaMesta(cmbMesto);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (KontrolerKorisnickogInterfejsa.KontrolerKI.ZapamtiPacijenta(txtAdresa, txtDatum, txtIme, txtPrezime, txtTelefon, cmbMesto)) this.Close();
        }
    }
}
