using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lagerverwaltung_Bauhaus.Lagerhaltung.Produkte.Getränke.alkoholisch
{
    public class Bier : Alkoholisch
    {
        public override Getraenk erstelleGetraenk(double fuellmenge, bool alkohol, int anzahl, string getraenkeName, ENUMgetraenkeArt.getraenkeArt enumGetraenk)
        {
            return new Getraenk(fuellmenge, true, anzahl, getraenkeName, getraenkeArt.Bier);
        }
    }
}
