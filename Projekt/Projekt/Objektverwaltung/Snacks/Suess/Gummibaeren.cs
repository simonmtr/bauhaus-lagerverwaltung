using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.Objektverwaltung.Snacks.Suess
{
    public class Gummibaeren:Suesssnacks
    {

        public override void erstelleSnack(string snackName, bool istSalzig, ENUMsnackArt.snackArt enumSnack)
        {
            this.snackName = base.snackName;
            this.istSalzig = base.istSalzig;
            this.enumSnack = snackArt.Gummibaer;
        }
    }
}
