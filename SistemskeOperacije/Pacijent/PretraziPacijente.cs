using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Biblioteka;
using Sesija;

namespace SistemskeOperacije.Pacijent
{
    public class PretraziPacijente : OpstaSO
    {
        public override object Izvrsi(OpstiDomenskiObjekat odo)
        {
            return Broker.dajSesiju().dajSveZaUslovVise(odo).OfType<Biblioteka.Pacijent>().ToList<Biblioteka.Pacijent>();
        }
    }
}
