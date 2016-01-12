using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lagerverwaltung_Bauhaus.Lagerhaltung.Orte;

namespace Lagerverwaltung_Bauhaus.Lagerhaltung.Produkte.Getränke.unalkoholisch
{
    public class Softdrink : Unalkoholisch
    {

        public override Getraenk erstelleGetraenk(double fuellmenge, bool alkohol, int anzahl, string getraenkeName, ENUMgetraenkeArt.getraenkeArt enumGetraenk, ENUMLagerort.Lagerort enumLagerort)
        {
            return new Getraenk(fuellmenge, false, anzahl, getraenkeName, getraenkeArt.Softdrink, enumLagerort);

        }
    }
}
