using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;

namespace Biblioteka
{
    [Serializable]
    public class Termin : OpstiDomenskiObjekat
    {
        int terminID;
        DateTime datumVreme;
        Pacijent pacijent;
        Zaposleni zaposleni;
        BindingList<StavkaTermina> listaStavki;

        public int TerminID { get => terminID; set => terminID = value; }
        public DateTime DatumVreme { get => datumVreme; set => datumVreme = value; }
        [Browsable(false)]
        public Pacijent Pacijent { get => pacijent; set => pacijent = value; }
        [Browsable(false)]
        public Zaposleni Zaposleni { get => zaposleni; set => zaposleni = value; }
        public BindingList<StavkaTermina> ListaStavki { get => listaStavki; set => listaStavki = value; }

        public Termin()
        {
            listaStavki = new BindingList<StavkaTermina>();
        }


        
        [Browsable(false)]
        public string tabela => "Termin";
        [Browsable(false)]
        public string kljuc => "TerminID";
        [Browsable(false)]
        public string uslovJedan => "TerminID=" + TerminID;
        [Browsable(false)]
        public string USLOV = "";
        [Browsable(false)]
        public string uslovVise => USLOV;
        [Browsable(false)]
        public string azuriranje => "DatumIVreme='" + datumVreme.ToString("yyyy-MM-dd HH:mm:ss") + "', PacijentID="+pacijent.PacijentID+", ZaposleniID="+zaposleni.ZaposleniID+"";
        [Browsable(false)]
        public string upisivanje => "(TerminID) values (" + TerminID + ")";
        public OpstiDomenskiObjekat napuni(DataRow red)
        {
            Termin t = new Termin();

            t.terminID = Convert.ToInt32(red["TerminID"]);
            t.datumVreme = Convert.ToDateTime(red["DatumIVreme"]);
            t.Pacijent = new Pacijent();
            t.pacijent.PacijentID = Convert.ToInt32(red["PacijentID"]);
            t.Zaposleni = new Zaposleni();
            t.zaposleni.ZaposleniID = Convert.ToInt32(red["ZaposleniID"]);


            return t;
        }
        

    }
}
