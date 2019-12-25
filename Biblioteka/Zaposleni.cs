using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;

namespace Biblioteka
{
    [Serializable]
    public class Zaposleni:OpstiDomenskiObjekat
    {
       
        public override string ToString()
        {
            return ImePrezime;
        }

       

        int zaposleniID;
        string imePrezime;
        string sifra;
        string korisnickoIme;

        public int ZaposleniID { get => zaposleniID; set => zaposleniID = value; }
        public string ImePrezime { get => imePrezime; set => imePrezime = value; }
        public string Sifra { get => sifra; set => sifra = value; }
        public string KorisnickoIme { get => korisnickoIme; set => korisnickoIme = value; }

        
       
        [Browsable(false)]
        public string tabela => "Zaposleni";
        [Browsable(false)]
        public string kljuc => "ZaposleniID";
        [Browsable(false)]
        public string uslovJedan => "ZaposleniID="+zaposleniID;
        [Browsable(false)]
        public string USLOV = "";
        [Browsable(false)]
        public string uslovVise => USLOV;
        [Browsable(false)]
        public string azuriranje => null;
        [Browsable(false)]
        public string upisivanje => null;
        public OpstiDomenskiObjekat napuni(DataRow red)
        {
            Zaposleni z = new Zaposleni();

            z.ZaposleniID = Convert.ToInt32(red["ZaposleniID"]);
            z.ImePrezime = red["ImePrezime"].ToString();
            z.Sifra = red["Sifra"].ToString();
            z.KorisnickoIme = red["KorisnickoIme"].ToString();

            return z;
        }
        
    }
}
