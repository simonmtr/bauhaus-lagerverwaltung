using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lagerverwaltung_Bauhaus.Lagerhaltung.Orte;

namespace Lagerverwaltung_Bauhaus.Lagerhaltung.Produkte.Getränke.unalkoholisch
{
    public class Kaffee : Unalkoholisch
    {

        public override Getraenk erstelleGetraenk(double fuellmenge, bool alkohol, int anzahl, string getraenkeName, string getrankeArt, string lagerort)
        {
            return new Getraenk(fuellmenge, false, anzahl, getraenkeName, "Kaffee", lagerort);

        }
    }
}
