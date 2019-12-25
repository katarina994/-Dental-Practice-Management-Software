using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Biblioteka;
using Sesija;

namespace SistemskeOperacije.TerminSO
{
    public class UcitajTermin : OpstaSO
    {
        public override object Izvrsi(OpstiDomenskiObjekat odo)
        {
            Termin t = odo as Termin;
            t.Pacijent = Broker.dajSesiju().dajZaUslovJedan(t.Pacijent) as Biblioteka.Pacijent;
            t.Zaposleni = Broker.dajSesiju().dajZaUslovJedan(t.Zaposleni) as Biblioteka.Zaposleni;

            StavkaTermina s = new StavkaTermina();
            s.USLOV = " TerminID =" + t.TerminID;

            List<StavkaTermina> lista = Broker.dajSesiju().dajSveZaUslovVise(s).OfType<StavkaTermina>().ToList<StavkaTermina>();

            foreach (StavkaTermina st in lista)
            {
                st.Intervencija = Broker.dajSesiju().dajZaUslovJedan(st.Intervencija) as Intervencija;
                t.ListaStavki.Add(st);
            }

            return t;
        }
    }
}
