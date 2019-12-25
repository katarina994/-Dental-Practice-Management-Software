using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Biblioteka;
using Sesija;

namespace SistemskeOperacije.Pacijent
{
    public class UcitajListuMesta:OpstaSO
    {
        public override object Izvrsi(OpstiDomenskiObjekat odo)
        {
            return Broker.dajSesiju().dajSve(odo).OfType<Mesto>().ToList<Mesto>();
        }

        
    }
}
