using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;

namespace Biblioteka
{
    [Serializable]
    public class Pacijent:OpstiDomenskiObjekat
    {
       

        public override string ToString()
        {
            return ime+" "+prezime;
        }

        int pacijentID;
        string ime;
        string prezime;
        string adresa;
        DateTime datumRodjenja;
        string telefon;
        Mesto mesto;

        [Browsable(false)]
        public int PacijentID { get => pacijentID; set => pacijentID = value; }
        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public string Adresa { get => adresa; set => adresa = value; }
        public DateTime DatumRodjenja { get => datumRodjenja; set => datumRodjenja = value; }
        public string Telefon { get => telefon; set => telefon = value; }
        [Browsable(false)]
        public Mesto Mesto { get => mesto; set => mesto = value; }
        

        
        [Browsable(false)]
        public string tabela => "Pacijent";
        [Browsable(false)]
        public string kljuc => "PacijentID";
        [Browsable(false)]
        public string uslovJedan => "PacijentID=" + pacijentID;
        [Browsable(false)]
        public string USLOV = "";
        [Browsable(false)]
        public string uslovVise => USLOV;
        [Browsable(false)]
        public string azuriranje => "Ime='" + Ime + "', Prezime='" + Prezime + "', Adresa='" + Adresa + "', DatumRodjenja='" + datumRodjenja.ToString("yyyy-MM-dd")+"', Telefon='"+Telefon+"',MestoID="+mesto.MestoID+" ";
        [Browsable(false)]
        public string upisivanje => " values ("+pacijentID+",'"+ime+"','"+prezime+"','"+adresa+"','"+datumRodjenja.ToString("yyyy-MM-dd")+"','"+telefon+"',"+mesto.MestoID+")";
        public OpstiDomenskiObjekat napuni(DataRow red)
        {
            Pacijent p = new Pacijent();

            p.PacijentID = Convert.ToInt32(red["PacijentID"]);
            p.Ime = red["Ime"].ToString();
            p.Prezime = red["Prezime"].ToString();
            p.Adresa = red["Adresa"].ToString();
            p.DatumRodjenja = Convert.ToDateTime(red["DatumRodjenja"]);
            p.Telefon = red["Telefon"].ToString();
            p.Mesto = new Mesto();
            p.Mesto.MestoID =Convert.ToInt32( red["MestoID"]);

            return p;
        }
       
    }
}
