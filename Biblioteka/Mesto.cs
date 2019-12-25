using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;

namespace Biblioteka
{
    [Serializable]
    public class Mesto:OpstiDomenskiObjekat
    {
        
        public override string ToString()
        {
            return Naziv;
        }
        int mestoID;
        string PTT;
        string naziv;

        public int MestoID { get => mestoID; set => mestoID = value; }
        public string PTT1 { get => PTT; set => PTT = value; }
        public string Naziv { get => naziv; set => naziv = value; }
        

       
        [Browsable(false)]
        public string tabela => "Mesto";
        [Browsable(false)]
        public string kljuc => "MestoID";
        [Browsable(false)]
        public string uslovJedan => "MestoID=" + mestoID;
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
            Mesto m = new Mesto();

            m.MestoID= Convert.ToInt32(red["MestoID"]);
            m.Naziv= red["Naziv"].ToString();
            m.PTT = red["PTT"].ToString();
          
            return m;
        }
       
    }
}
