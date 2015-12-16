using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.Objektverwaltung.Snacks
{
    class Snacks
    {
        public string snackName;
        public bool istSalzig;
        public ENUMsnackArt.snackArt enumSnack;


        public virtual void erstelleSnack(string snackName, bool istSalzig, ENUMsnackArt.snackArt enumSnack)
        {
            this.snackName = snackName;
            this.istSalzig = istSalzig;
            this.enumSnack = enumSnack;


        }
    }
}
