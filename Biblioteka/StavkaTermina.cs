using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;

namespace Biblioteka
{
    [Serializable]
    public class StavkaTermina:OpstiDomenskiObjekat
    {
        int terminID;
        int redniBroj;
        string beleskaTermina;
        Intervencija intervencija;

        [Browsable(false)]
        public int TerminID { get => terminID; set => terminID = value; }
        public int RedniBroj { get => redniBroj; set => redniBroj = value; }
        public Intervencija Intervencija { get => intervencija; set => intervencija = value; }
        public string BeleskaTermina { get => beleskaTermina; set => beleskaTermina = value; }
      


        
        [Browsable(false)]
        public string tabela => "StavkaTermina";
        [Browsable(false)]
        public string kljuc => "";
        [Browsable(false)]
        public string uslovJedan => "";
        [Browsable(false)]
        public string USLOV = "";
        [Browsable(false)]
        public string uslovVise => USLOV;
        [Browsable(false)]
        public string azuriranje => "";
        [Browsable(false)]
        public string upisivanje => " values (" + TerminID + ","+redniBroj+",'" + beleskaTermina + "'," + Intervencija.IntervencijaID + ")";


        public OpstiDomenskiObjekat napuni(DataRow red)
        {
            StavkaTermina s = new StavkaTermina();

            s.TerminID = Convert.ToInt32(red["TerminID"]);
            s.RedniBroj = Convert.ToInt32(red["RedniBroj"]);
            s.BeleskaTermina = red["BeleskaTermina"].ToString();            
            s.Intervencija = new Intervencija();
            s.Intervencija.IntervencijaID = Convert.ToInt32(red["IntervencijaID"]);

            return s;
        }
        
    }
}
