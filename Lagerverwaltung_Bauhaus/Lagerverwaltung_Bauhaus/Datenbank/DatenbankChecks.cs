using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lagerverwaltung_Bauhaus.Lagerhaltung.Produkte.Getränke.alkoholisch;
using Lagerverwaltung_Bauhaus.Lagerhaltung.Produkte.Getränke.unalkoholisch;
using Lagerverwaltung_Bauhaus.Lagerhaltung.Produkte.Getränke;
using Lagerverwaltung_Bauhaus.Lagerhaltung.Produkte.Snacks;
using Lagerverwaltung_Bauhaus.Lagerhaltung.Produkte.Snacks.salzig;
using Lagerverwaltung_Bauhaus.Lagerhaltung.Produkte.Snacks.süß;

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

        public Getraenk welchesGetraenk(string getraenkeArt)
        {
            switch (getraenkeArt)
            {
                case "Bier":
                    return new Bier();
                case "Wein":
                    return new Wein();
                case"Schnaps":
                    return new Schnaps();
                case "Kaffee":
                    return new Kaffee();
                case "Saft":
                    return new Saft();
                case "Softdrink":
                    return new Softdrink();
                case "Wasser":
                    return new Wasser();
                default:
                    return null;

            }
        }
        public Snacks welcherSnack(string snackArt)
        {
            switch (snackArt) {
                case "Chips":
                    return new Chips();
                case "Erdnüsse":
                    return new Erdnuesse();
                case "Erdnussflips":
                    return new ErdnussFlips();
                case "Salzstangen":
                    return new Salzstangen();
                case "Gummibären":
                    return new Gummibaeren();
                default:
                    return null;
            }
        }
    }
}
