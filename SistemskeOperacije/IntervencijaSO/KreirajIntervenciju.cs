using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Biblioteka;
using Sesija;

namespace SistemskeOperacije.IntervencijaSO
{
    public class KreirajIntervenciju : OpstaSO
    {
        public override object Izvrsi(OpstiDomenskiObjekat odo)
        {
            Intervencija i = new Intervencija();
            i.IntervencijaID = Broker.dajSesiju().dajSifru(i);
            Broker.dajSesiju().sacuvaj(i);
            return i;
        }
    }
}
