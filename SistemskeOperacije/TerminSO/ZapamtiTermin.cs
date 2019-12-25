using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Biblioteka;
using Sesija;

namespace SistemskeOperacije.TerminSO
{
    public class ZapamtiTermin : OpstaSO
    {
        public override object Izvrsi(OpstiDomenskiObjekat odo)
        {
            Termin t = odo as Termin;
            Broker.dajSesiju().izmeni(t);

            //StavkaTermina s = new StavkaTermina();
            //s.USLOV = " TerminID =" + t.TerminID;
            //Broker.dajSesiju().obrisiZaUslovVise(s);

            foreach (StavkaTermina st in t.ListaStavki)
            {
                st.TerminID = t.TerminID;
                Broker.dajSesiju().sacuvaj(st);
            }

            return true;
        }
    }
}
