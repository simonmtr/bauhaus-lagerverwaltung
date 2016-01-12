using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lagerverwaltung_Bauhaus.Lagerhaltung.Orte;


namespace Lagerverwaltung_Bauhaus.Lagerhaltung.Produkte.Snacks.süß
{
    public class Gummibaeren : Suesssnacks
    {

        public override Snacks erstelleSnack(int anzahl,string snackName, bool istSalzig, ENUMsnackArt.snackArt enumSnack, ENUMLagerort.Lagerort enumLagerort)
        {
            return new Snacks(anzahl,snackName, false, snackArt.Gummibaer, enumLagerort);
        }
    }
}
