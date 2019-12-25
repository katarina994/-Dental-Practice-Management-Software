using Biblioteka;
using Sesija;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SistemskeOperacije.TerminSO
{
    public class UcitajListuIntervencija:OpstaSO
    {
        public override object Izvrsi(OpstiDomenskiObjekat odo)
        {
            Intervencija i = new Intervencija();
            i.USLOV = "Naziv is null";
            Broker.dajSesiju().obrisiZaUslovVise(i);
            return Broker.dajSesiju().dajSve(odo).OfType<Biblioteka.Intervencija>().ToList<Biblioteka.Intervencija>();
        }
    }
}
