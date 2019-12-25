using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Biblioteka;
using Sesija;

namespace SistemskeOperacije.TerminSO
{
    public class KreirajTermin : OpstaSO
    {
        public override object Izvrsi(OpstiDomenskiObjekat odo)
        {
            Termin t = odo as Termin;
            t.TerminID = Broker.dajSesiju().dajSifru(t);
            Broker.dajSesiju().sacuvaj(t);
            return t;
        }
    }
}
