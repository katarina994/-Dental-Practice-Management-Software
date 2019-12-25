using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Biblioteka;
using Sesija;

namespace SistemskeOperacije.Pacijent
{
    public class UcitajPacijenta : OpstaSO
    {
        public override object Izvrsi(OpstiDomenskiObjekat odo)
        {
            Biblioteka.Pacijent p = odo as Biblioteka.Pacijent;
            p.Mesto = Broker.dajSesiju().dajZaUslovJedan(p.Mesto) as Mesto;
            return p;
        }
    }
}
