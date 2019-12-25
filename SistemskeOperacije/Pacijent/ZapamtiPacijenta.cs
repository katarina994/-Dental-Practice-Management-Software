using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Biblioteka;
using Sesija;

namespace SistemskeOperacije.Pacijent
{
    public class ZapamtiPacijenta : OpstaSO
    {
        public override object Izvrsi(OpstiDomenskiObjekat odo)
        {
            Biblioteka.Pacijent p = odo as Biblioteka.Pacijent;
            p.PacijentID = Broker.dajSesiju().dajSifru(p);
            return Broker.dajSesiju().sacuvaj(p);
        }
    }
}
