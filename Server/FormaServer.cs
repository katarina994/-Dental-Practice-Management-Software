using Biblioteka;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Server
{
    public partial class FormaServer : Form
    {
        Server s;
        Timer t;
        public FormaServer()
        {
           
            InitializeComponent();
        
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            t = new Timer();
            t.Interval = 1000;
            t.Tick += osvezi;
        }

        private void btnPokreni_Click(object sender, EventArgs e)
        {
            s = new Server();
            if (s.pokreniServer())
            {
                lblStatus.Text = "Server je pokrenut!";
                
                btnPokreni.Enabled = false;
                btnZaustavi.Enabled = true;
                               
                t.Start();
            }
        }

        private void osvezi(object sender, EventArgs e)
        {
            List<Zaposleni> lista = new List<Zaposleni>();
            foreach (Zaposleni z in Server.ulogovaniKorisnici) lista.Add(z);
            dataGridView1.DataSource = lista;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[2].Visible = false;
        }

        private void btnZaustavi_Click(object sender, EventArgs e)
        {
            if (Server.ulogovaniKorisnici.Count > 0)
            {
                MessageBox.Show("Ima jos ulogovanih korinsika!");
                return;
            }
            if (s.ZaustaviServer())
            {
                lblStatus.Text = "Server nije pokrenut!";
                
                btnPokreni.Enabled = true;
                btnZaustavi.Enabled = false;

                t.Stop();
            }
        }
    }
}
