using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lagerverwaltung_Bauhaus.Lagerhaltung.Produkte.Getränke.unalkoholisch
{
    public class Saft : Unalkoholisch
    {

        public override Getraenk erstelleGetraenk(double fuellmenge, bool alkohol, int anzahl, string getraenkeName, string getraenkeArt, string lagerort)
        {
            return new Getraenk(fuellmenge, false, anzahl, getraenkeName, "Saft", lagerort);

        }
    }
}
