using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Runtime.Serialization.Formatters.Binary;
using System.Net.Sockets;
using Biblioteka;

namespace Komunikacija
{
    public class Komunikacija
    {
        TcpClient klijent;
        BinaryFormatter formater;
        NetworkStream tok;

        public bool poveziSeNaServer()
        {
            try
            {
                klijent = new TcpClient("127.0.0.1", 20000);
                tok = klijent.GetStream();
                formater = new BinaryFormatter();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }


        public void kraj() 
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.Kraj;
            formater.Serialize(tok, transfer);
        }

        public Object NadjiZaposlenog(Zaposleni z)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.NadjiZaposlenog;
            transfer.TransferObjekat = z;
            formater.Serialize(tok, transfer);

            return (formater.Deserialize(tok) as TransferKlasa).Rezultat;
        }

        public Object ZapamtiPacijenta(Pacijent p)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.ZapamtiPacijenta;
            transfer.TransferObjekat = p;
            formater.Serialize(tok, transfer);

            return (formater.Deserialize(tok) as TransferKlasa).Rezultat;
        }

        public Object UcitajListuMesta()
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.VratiListuMesta;
            transfer.TransferObjekat = new Mesto();
            formater.Serialize(tok, transfer);

            return (formater.Deserialize(tok) as TransferKlasa).Rezultat;
        }

        public Object PretraziPacijente(Pacijent p)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.PretraziPacijente;
            transfer.TransferObjekat = p;
            formater.Serialize(tok, transfer);

            return (formater.Deserialize(tok) as TransferKlasa).Rezultat;
        }

        public Object UcitajPacijenta(Pacijent p)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.UcitajPacijenta;
            transfer.TransferObjekat = p;
            formater.Serialize(tok, transfer);

            return (formater.Deserialize(tok) as TransferKlasa).Rezultat;
        }

        public Object UcitajListuPacijenata()
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.UcitajListuPacijenata;
            transfer.TransferObjekat = new Pacijent();
            formater.Serialize(tok, transfer);

            return (formater.Deserialize(tok) as TransferKlasa).Rezultat;
        }

        public Object UcitajListIntervencija()
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.UcitajListuIntervencija;
            transfer.TransferObjekat = new Intervencija();
            formater.Serialize(tok, transfer);

            return (formater.Deserialize(tok) as TransferKlasa).Rezultat;
        }

        public Object KreirajTermin()
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.KreirajTermin;
            transfer.TransferObjekat = new Termin();
            formater.Serialize(tok, transfer);

            return (formater.Deserialize(tok) as TransferKlasa).Rezultat;
        }

        public Object ZapamtiTermin(Termin p)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.ZapamtiTermin;
            transfer.TransferObjekat = p;
            formater.Serialize(tok, transfer);

            return (formater.Deserialize(tok) as TransferKlasa).Rezultat;
        }

        public Object PretraziTermine(Termin p)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.PretraziTermine;
            transfer.TransferObjekat = p;
            formater.Serialize(tok, transfer);

            return (formater.Deserialize(tok) as TransferKlasa).Rezultat;
        }

        public Object UcitajTermin(Termin p)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.UcitajTermin;
            transfer.TransferObjekat = p;
            formater.Serialize(tok, transfer);

            return (formater.Deserialize(tok) as TransferKlasa).Rezultat;
        }

        public Object OznaciDaJeSlobodan(Termin p)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.OznaciDaJeSlobodan;
            transfer.TransferObjekat = p;
            formater.Serialize(tok, transfer);

            return (formater.Deserialize(tok) as TransferKlasa).Rezultat;
        }

        public Object KreirajIntervenciju()
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.KreirajIntervenciju;
            transfer.TransferObjekat = new Intervencija();
            formater.Serialize(tok, transfer);

            return (formater.Deserialize(tok) as TransferKlasa).Rezultat;
        }

        public Object ZapamtiIntervenciju(Intervencija i)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.ZapamtiIntervenciju;
            transfer.TransferObjekat = i;
            formater.Serialize(tok, transfer);

            return (formater.Deserialize(tok) as TransferKlasa).Rezultat;
        }

    }
}
