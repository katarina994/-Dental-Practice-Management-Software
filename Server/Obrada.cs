using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using Biblioteka;
using Sesija;
using System.Threading;
using SistemskeOperacije.Zaposleni;
using SistemskeOperacije.Pacijent;
using SistemskeOperacije.TerminSO;
using SistemskeOperacije.IntervencijaSO;

namespace Server
{
    public class Obrada
    {
        BinaryFormatter formater;
        NetworkStream tok;
        Zaposleni zaposleni;

        public Obrada(NetworkStream tok)
        {
            this.tok = tok;
            formater = new BinaryFormatter();

            ThreadStart ts = obradiKlijenta;
            Thread nit = new Thread(ts);
            nit.Start();
        }

        public void obradiKlijenta() 
        {
            int operacija = 0;
            try
            {
                while (operacija != (int)Operacije.Kraj)
                {
                    TransferKlasa transfer = formater.Deserialize(tok) as TransferKlasa;
                    switch (transfer.Operacija)
                    {
                        case Operacije.NadjiZaposlenog:
                            NadjiZaposlenog nz = new NadjiZaposlenog();
                            transfer.Rezultat = nz.izvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            zaposleni = transfer.Rezultat as Zaposleni;
                            if (zaposleni != null) Server.ulogovaniKorisnici.Add(zaposleni);
                            formater.Serialize(tok, transfer);
                            break;

                        case Operacije.VratiListuMesta:
                            UcitajListuMesta ulm = new UcitajListuMesta();
                            transfer.Rezultat = ulm.izvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        case Operacije.ZapamtiPacijenta:
                            ZapamtiPacijenta zp = new ZapamtiPacijenta();
                            transfer.Rezultat = zp.izvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        case Operacije.PretraziPacijente:
                            PretraziPacijente ppe = new PretraziPacijente();
                            transfer.Rezultat = ppe.izvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        case Operacije.UcitajPacijenta:
                            UcitajPacijenta up = new UcitajPacijenta();
                            transfer.Rezultat = up.izvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        case Operacije.UcitajListuPacijenata:
                            UcitajListuPacijenata ulp = new UcitajListuPacijenata();
                            transfer.Rezultat = ulp.izvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        case Operacije.UcitajListuIntervencija:
                            UcitajListuIntervencija uli = new UcitajListuIntervencija();
                            transfer.Rezultat = uli.izvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        case Operacije.KreirajTermin:
                            KreirajTermin kte = new KreirajTermin();
                            transfer.Rezultat = kte.izvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        case Operacije.ZapamtiTermin:
                            ZapamtiTermin zte = new ZapamtiTermin();
                            transfer.Rezultat = zte.izvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        case Operacije.PretraziTermine:
                            PretraziTermine pte = new PretraziTermine();
                            transfer.Rezultat = pte.izvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        case Operacije.UcitajTermin:
                            UcitajTermin ute = new UcitajTermin();
                            transfer.Rezultat = ute.izvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        case Operacije.KreirajIntervenciju:
                            KreirajIntervenciju kri = new KreirajIntervenciju();
                            transfer.Rezultat = kri.izvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        case Operacije.ZapamtiIntervenciju:
                            ZapamtiIntervenciju zti = new ZapamtiIntervenciju();
                            transfer.Rezultat = zti.izvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        case Operacije.OznaciDaJeSlobodan:
                            OznaciDaJeSlobodan osl = new OznaciDaJeSlobodan();
                            transfer.Rezultat = osl.izvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;



                        case Operacije.Kraj:
                            operacija = 1;
                            Server.ulogovaniKorisnici.Remove(zaposleni);
                            break;
                        default:
                            break;
                    }
                }
            }
            catch (Exception)
            {

                try
                {
                    Server.ulogovaniKorisnici.Remove(zaposleni);
                }
                catch (Exception)
                {

                    
                }

            }
        }
    }
}
