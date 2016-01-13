using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lagerverwaltung_Bauhaus.Lagerhaltung.Produkte.Getränke.alkoholisch
{
    public class Alkoholisch : Getraenk
    {

        public override Getraenk erstelleGetraenk(double fuellmenge, bool alkohol, int anzahl, string getraenkeName, string getraenkeArt, string lagerort)
        {
            return new Getraenk(fuellmenge, true, anzahl, getraenkeName, getraenkeArt, lagerort);
        }
    }
}
