using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Komunikacija;
using Biblioteka;
using System.Windows.Forms;


namespace KontrolerKorisnickogInterfejsa
{
    public class KontrolerKI
    {
        public static Komunikacija.Komunikacija komunikacija;
        public static Zaposleni zaposleni;
        public static Pacijent pacijent;
        public static Intervencija intervencija;
        public static Termin termin;

        public static bool poveziSeNaServer()
        {
            komunikacija = new Komunikacija.Komunikacija();
            return komunikacija.poveziSeNaServer();
        }

        public static void PopuniPoljaTermin( MaskedTextBox txtVreme, DateTimePicker dtpDatum, ComboBox cmbIntervencija, DataGridView dgvGrid, ComboBox cmbPacijent)
        {
            popuniComboIntervencija(cmbIntervencija);
            popuniComboPacijent(cmbPacijent);

            dtpDatum.Value = termin.DatumVreme;
            txtVreme.Text = termin.DatumVreme.ToString("HH:mm");
            cmbPacijent.Text = termin.Pacijent.ToString();
            dgvGrid.DataSource = termin.ListaStavki;
        }

        public static bool UcitajTermin(DataGridView dataGridView1)
        {
            try
            {
                termin = dataGridView1.CurrentRow.DataBoundItem as Termin;
                termin = komunikacija.UcitajTermin(termin) as Termin;

                if (termin == null)
                {
                    MessageBox.Show("Sistem ne moze da ucita termin!");
                    return false;
                }
                else
                {
                    MessageBox.Show("Sistem je ucitao termin!");
                    return true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Sistem ne moze da ucita termin!");
                return false;
            }
        }

        public static void PretraziTermine(ComboBox cmbPacijent, DataGridView dataGridView1)
        {
            termin = new Termin();
            termin.Pacijent = cmbPacijent.SelectedItem as Pacijent;
            termin.USLOV = "PacijentID=" + termin.Pacijent.PacijentID + " order by DatumIVreme desc"; 
            List<Termin> lista = komunikacija.PretraziTermine(termin) as List<Termin>;

            if (lista == null)
            {
                MessageBox.Show("Sistem ne moze da pronadje termine!");

            }
            else
            {
                dataGridView1.DataSource = lista;
                MessageBox.Show("Sistem je pronasao termine!");
            }
        }

        public static void KreirajIntervenciju(TextBox txtID, GroupBox gbIntervencija, Button btnKreiraj)
        {
            intervencija = komunikacija.KreirajIntervenciju() as Intervencija;
            gbIntervencija.Enabled = false;
            btnKreiraj.Enabled = true;

            if (intervencija == null)
            {
                MessageBox.Show("Sistem ne moze da kreira intervenciju!");
            }
            else
            {
                txtID.Text = intervencija.IntervencijaID.ToString();
                gbIntervencija.Enabled = true;
                btnKreiraj.Enabled = false;
                MessageBox.Show("Sistem je kreirao interveciju!");
            }
        }

        public static bool OtkaziTermin()
        {
            object rez = komunikacija.OznaciDaJeSlobodan(termin);

            if (rez == null)
            {
                MessageBox.Show("Sistem ne moze da obrise termin!");
                return false;
            }
            else
            {
                MessageBox.Show("Sistem je obrisao termin!");
                return true;
            }

        }

        public static bool ZapamtiIntervenciju(TextBox txtNaziv)
        {
            intervencija.Naziv = txtNaziv.Text;
            if (string.IsNullOrEmpty(intervencija.Naziv))
            {
                MessageBox.Show("Niste uneli naziv intervencije!");
                return false;
            }

            object rez = komunikacija.ZapamtiIntervenciju(intervencija);
            if (rez == null)
            {
                MessageBox.Show("Sistem ne moze da zapamti intervenciju!");
                return false;
            }
            else
            {
                MessageBox.Show("Sistem je zapamtio intervenciju!");
                return true;
            }
        }

        public static void PopuniPoljaPacijent(TextBox txtAdresa, TextBox txtDatum, TextBox txtIme, TextBox txtMesto, TextBox txtPrezime, TextBox txtTelefon)
        {
            txtAdresa.Text = pacijent.Adresa;
            txtDatum.Text = pacijent.DatumRodjenja.ToShortDateString();
            txtIme.Text = pacijent.Ime;
            txtMesto.Text = pacijent.Mesto.ToString();
            txtPrezime.Text = pacijent.Prezime;
            txtTelefon.Text = pacijent.Telefon;
        }

        public static void PretraziPacijente(TextBox txtFilter, DataGridView dataGridView1)
        {
            pacijent = new Pacijent();

            pacijent.USLOV = "Ime like '"+txtFilter.Text+ "%' or Prezime like '" + txtFilter.Text + "%' or Adresa like '" + txtFilter.Text + "%' or Telefon like '" + txtFilter.Text + "%'";

            dataGridView1.DataSource = komunikacija.PretraziPacijente(pacijent);
        }

        public static bool UcitajPacijenta(DataGridView dataGridView1)
        {
            try
            {
                pacijent = dataGridView1.CurrentRow.DataBoundItem as Pacijent;

                pacijent = komunikacija.UcitajPacijenta(pacijent) as Pacijent;

                if (pacijent == null)
                {
                    MessageBox.Show("Sistem ne moze da ucita pacijenta!");
                    return false;
                }
                else
                {
                    MessageBox.Show("Sistem je ucitao pacijenta!");
                    return true;
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Niste odabrali pacijenta!");
                return false;
            }
        }

        public static void KreirajTermin(TextBox txtID, Button btnKreiraj, GroupBox gbTermin, ComboBox cmbIntervencija, ComboBox cmbPacijent, DataGridView dgvGrid)
        {
            termin = komunikacija.KreirajTermin() as Termin;
            if (termin == null)
            {
                MessageBox.Show("Sistem ne moze da kreira termin!");
            }
            else
            {
                txtID.Text = termin.TerminID.ToString();
                gbTermin.Enabled = true;
                btnKreiraj.Enabled = false;
                dgvGrid.DataSource = termin.ListaStavki;
                popuniComboPacijent(cmbPacijent);
                popuniComboIntervencija(cmbIntervencija);
                termin.Zaposleni = zaposleni;
                MessageBox.Show("Sistem je kreirao termin!");
            }
        }

        public static bool SacuvajTermin(DateTimePicker dtpDatum, MaskedTextBox txtVreme, ComboBox cmbPacijent)
        {
            try
            {
                termin.DatumVreme = DateTime.ParseExact(dtpDatum.Value.ToString("dd.MM.yyyy")+" "+txtVreme.Text+":00","dd.MM.yyyy HH:mm:ss",null);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Datum ili vreme nisu ispravno uneti!");
                return false;
            }

            if (termin.DatumVreme < DateTime.Now)
            {
                MessageBox.Show("Termin mora biti u buducnosti!");
                return false;
            }

            termin.Pacijent = cmbPacijent.SelectedItem as Pacijent;
            if (termin.Pacijent == null)
            {
                MessageBox.Show("Niste odabrali pacijenta!");
                return false;
            }


            object rez = komunikacija.ZapamtiTermin(termin);

            if (rez == null)
            {
                MessageBox.Show("Sistem ne moze da zapamti termin!");
                return false;
            }
            else
            {
                MessageBox.Show("Sistemje zapamtio termin!");
                return true;
            }
        }

        public static void ObrisiStavku(DataGridView dgvGrid)
        {
            try
            {
                StavkaTermina s = dgvGrid.CurrentRow.DataBoundItem as StavkaTermina;
                termin.ListaStavki.Remove(s);

                int i = 1;
                foreach (StavkaTermina st in termin.ListaStavki)
                {
                    st.RedniBroj = i;
                    i++;
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Niste odabrali stavku za brisanje!");
            }
        }

        public static void DodajStavku(ComboBox cmbIntervencija, TextBox txtBelska)
        {
            StavkaTermina st = new StavkaTermina();
            st.TerminID = termin.TerminID;
            st.RedniBroj = termin.ListaStavki.Count + 1;
            st.Intervencija = cmbIntervencija.SelectedItem as Intervencija;
            if (st.Intervencija == null)
            {
                MessageBox.Show("Niste odabrali intervenciju!");
                return;
            }

            st.BeleskaTermina = txtBelska.Text;

            termin.ListaStavki.Add(st);
        }

        public static void popuniComboPacijent(ComboBox combo)
        {
            combo.Items.Clear();
            foreach (Pacijent p in komunikacija.UcitajListuPacijenata() as List<Pacijent>)
            {
                combo.Items.Add(p);
            }
            combo.Text = "Izaberi pacijenta!";
        }

        public static void popuniComboIntervencija(ComboBox combo)
        {
            combo.DataSource = komunikacija.UcitajListIntervencija() as List<Intervencija>;
            combo.Text = "Izaberi intervenciju!";
        }

        public static void VratiSvaMesta(ComboBox cmbMesto)
        {
            cmbMesto.DataSource = komunikacija.UcitajListuMesta();
            cmbMesto.Text = "Izaberite mesto!";            
        }

        public static bool ZapamtiPacijenta(TextBox txtAdresa, TextBox txtDatum, TextBox txtIme, TextBox txtPrezime, TextBox txtTelefon, ComboBox cmbMesto)
        {
            pacijent = new Pacijent();
            pacijent.Ime = txtIme.Text;
            pacijent.Prezime = txtPrezime.Text;
            pacijent.Adresa = txtAdresa.Text;
            pacijent.Telefon = txtTelefon.Text;
            try
            {
                pacijent.DatumRodjenja = Convert.ToDateTime(txtDatum.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("Niste ispravno uneli datum rodjenja!");
                return false;
            }

            if (pacijent.DatumRodjenja >= DateTime.Now)
            {
                MessageBox.Show("Niste ispravno uneli datum rodjenja!");
                return false;
            }

            pacijent.Mesto = cmbMesto.SelectedItem as Mesto;

            if (pacijent.Mesto == null)
            {
                MessageBox.Show("Niste odabrali mesto!");
                return false;
            }


            Object rez = komunikacija.ZapamtiPacijenta(pacijent);

            if (rez == null)
            {
                MessageBox.Show("Sistem ne moze da zapamti pacijenta!");
                return false;
            }
            else
            {
                MessageBox.Show("Sistem je uspesno zapamtio pacijenta!");
                return true;
            }
        }

        public static void kraj()
        {
            komunikacija.kraj();
        }

        public static bool NadjiZaposlenog(TextBox txtUser, TextBox txtPass)
        {
            zaposleni = new Zaposleni();
            zaposleni.USLOV = "Sifra='"+txtPass.Text+"' and KorisnickoIme='"+txtUser.Text+"'";

            zaposleni = komunikacija.NadjiZaposlenog(zaposleni) as Zaposleni;

            if (zaposleni == null)
            {
                MessageBox.Show("Sistem ne moze da pronadje zaposlenog!");
                return false;
            }
            else
            {
                MessageBox.Show("Sistem je pronasao zaposlenog!");
                return true;
            }
        }
    }
}
