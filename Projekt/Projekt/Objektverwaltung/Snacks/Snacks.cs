using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.Objektverwaltung.Snacks
{
    public class Snacks:ENUMsnackArt,ISnack
    {
//variablen
        public string snackName;
        public bool istSalzig;
        public ENUMsnackArt.snackArt enumSnack;

//konstruktor
        public virtual void erstelleSnack(string snackName, bool istSalzig, ENUMsnackArt.snackArt enumSnack)
        {
            this.snackName = snackName;
            this.istSalzig = istSalzig;
            this.enumSnack = enumSnack;
        }


//geter und setter
        public string SnackName
        {
            get;
            set;
        }
        public bool IstSalzig
        {
            get;
            set;
        }

    }

}
