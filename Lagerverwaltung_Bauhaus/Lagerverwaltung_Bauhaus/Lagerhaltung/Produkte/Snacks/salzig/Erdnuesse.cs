using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lagerverwaltung_Bauhaus.Lagerhaltung.Produkte.Snacks.salzig
{
    public class Erdnuesse : Salzsnacks
    {
        public override void erstelleSnack(string snackName, bool istSalzig, ENUMsnackArt.snackArt enumSnack)
        {
            this.snackName = base.snackName;
            this.istSalzig = base.istSalzig;
            this.enumSnack = snackArt.Erdnuesse;

        }
    }
}
