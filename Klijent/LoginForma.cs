using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using KontrolerKorisnickogInterfejsa;

namespace Klijent
{
    public partial class LoginForma : Form
    {
        KontrolerKI kki = new KontrolerKI();
        public LoginForma()
        {
            
            InitializeComponent();
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (KontrolerKI.poveziSeNaServer())
            {
                if (KontrolerKI.NadjiZaposlenog(txtUser, txtPass))
                {
                    this.Hide();
                    new GlavnaForma().ShowDialog();
                    this.Show();
                }
            }
            else MessageBox.Show("Niste povazani na server!");
        }
    }
}
