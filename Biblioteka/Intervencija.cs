using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;

namespace Biblioteka
{
    [Serializable]
    public class Intervencija:OpstiDomenskiObjekat
    {
        public override string ToString()
        {
            return naziv;
        }

        int intervencijaID;
        string naziv;

        public int IntervencijaID { get => intervencijaID; set => intervencijaID = value; }
        public string Naziv { get => naziv; set => naziv = value; }

        #region ODO
        [Browsable(false)]
        public string tabela => "Intervencija";
        [Browsable(false)]
        public string kljuc => "IntervencijaID";
        [Browsable(false)]
        public string uslovJedan => "IntervencijaID=" + IntervencijaID;
        [Browsable(false)]
        public string USLOV = "";
        [Browsable(false)]
        public string uslovVise => USLOV;
        [Browsable(false)]
        public string azuriranje => "Naziv='" + Naziv + "'";
        [Browsable(false)]
        public string upisivanje => "(IntervencijaID) values (" + IntervencijaID + ")";
        public OpstiDomenskiObjekat napuni(DataRow red)
        {
            Intervencija i = new Intervencija();

            i.IntervencijaID = Convert.ToInt32(red["IntervencijaID"]);
            i.Naziv = red["Naziv"].ToString();
           

            return i;
        }
        #endregion
    }
}
