using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Biblioteka;
using Sesija;

namespace SistemskeOperacije.TerminSO
{
    public class UcitajListuPacijenata : OpstaSO
    {
        public override object Izvrsi(OpstiDomenskiObjekat odo)
        {
            Biblioteka.Pacijent p = new Biblioteka.Pacijent();
            p.USLOV = "Ime is null";
            Broker.dajSesiju().obrisiZaUslovVise(p);
            return Broker.dajSesiju().dajSve(odo).OfType<Biblioteka.Pacijent>().ToList<Biblioteka.Pacijent>();
        }
    }
}
