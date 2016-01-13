using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lagerverwaltung_Bauhaus.Datenbank
{
    public class DatenbankChecks
    {
        public DatenbankChecks(){}

        public bool stringToBool(string boolString)
        {
            if (boolString.Equals("Ja"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double stringToFuellmenge(string fuellmengeString)
        {
            return double.Parse(fuellmengeString, System.Globalization.CultureInfo.InvariantCulture);
        }
        public int stringToAnzahl(string anzahlString)
        {
            return Int32.Parse(anzahlString);
        }

    }
}
