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
    public partial class DetaljiPacijenta : Form
    {
        public DetaljiPacijenta()
        {
            InitializeComponent();
        }

        private void DetaljiPacijenta_Load(object sender, EventArgs e)
        {
            KontrolerKorisnickogInterfejsa.KontrolerKI.PopuniPoljaPacijent(txtAdresa, txtDatum, txtIme, txtMesto, txtPrezime, txtTelefon);
        }
    }
}
