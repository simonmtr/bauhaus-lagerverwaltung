using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lagerverwaltung_Bauhaus.Lagerhaltung.Orte;

namespace Lagerverwaltung_Bauhaus.Lagerhaltung.Produkte.Getränke.alkoholisch
{
    public class Alkoholisch : Getraenk
    {

        public override Getraenk erstelleGetraenk(double fuellmenge, bool alkohol, int anzahl, string getraenkeName, ENUMgetraenkeArt.getraenkeArt enumGetraenk, ENUMLagerort.Lagerort enumLagerort)
        {
            return new Getraenk(fuellmenge, true, anzahl, getraenkeName, enumGetraenk, enumLagerort);
        }
    }
}
