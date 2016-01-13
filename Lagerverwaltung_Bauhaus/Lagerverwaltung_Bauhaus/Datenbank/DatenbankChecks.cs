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

        public Getraenk welchesGetraenk(string fuellmenge, string alkohol, string aktAnzahl, string getraenkeName, string getraenkeArt, string lagerort)
        {
            switch (getraenkeArt)
            {
                case "Bier":
                    return new Bier()
                    {
                        Fuellmenge = stringToFuellmenge(fuellmenge),
                        Alkohol = stringToBool(alkohol),
                        Anzahl = stringToAnzahl(aktAnzahl.ToString()),
                        GetraenkeName = getraenkeName,
                        GetraenkeArt = getraenkeArt,
                        Lagerort = lagerort
                    };
                case "Wein":
                    return new Wein()
                    {
                        Fuellmenge = stringToFuellmenge(fuellmenge),
                        Alkohol = stringToBool(alkohol),
                        Anzahl = stringToAnzahl(aktAnzahl.ToString()),
                        GetraenkeName = getraenkeName,
                        GetraenkeArt = getraenkeArt,
                        Lagerort = lagerort
                    };
                case"Schnaps":
                    return new Schnaps()
                    {
                        Fuellmenge = stringToFuellmenge(fuellmenge),
                        Alkohol = stringToBool(alkohol),
                        Anzahl = stringToAnzahl(aktAnzahl.ToString()),
                        GetraenkeName = getraenkeName,
                        GetraenkeArt = getraenkeArt,
                        Lagerort = lagerort
                    };
                case "Kaffee":
                    return new Kaffee()
                    {
                        Fuellmenge = stringToFuellmenge(fuellmenge),
                        Alkohol = stringToBool(alkohol),
                        Anzahl = stringToAnzahl(aktAnzahl.ToString()),
                        GetraenkeName = getraenkeName,
                        GetraenkeArt = getraenkeArt,
                        Lagerort = lagerort
                    };
                case "Saft":
                    return new Saft()
                    {
                        Fuellmenge = stringToFuellmenge(fuellmenge),
                        Alkohol = stringToBool(alkohol),
                        Anzahl = stringToAnzahl(aktAnzahl.ToString()),
                        GetraenkeName = getraenkeName,
                        GetraenkeArt = getraenkeArt,
                        Lagerort = lagerort
                    };
                case "Softdrink":
                    return new Softdrink()
                    {
                        Fuellmenge = stringToFuellmenge(fuellmenge),
                        Alkohol = stringToBool(alkohol),
                        Anzahl = stringToAnzahl(aktAnzahl.ToString()),
                        GetraenkeName = getraenkeName,
                        GetraenkeArt = getraenkeArt,
                        Lagerort = lagerort
                    };
                case "Wasser":
                    return new Wasser()
                    {
                        Fuellmenge = stringToFuellmenge(fuellmenge),
                        Alkohol = stringToBool(alkohol),
                        Anzahl = stringToAnzahl(aktAnzahl.ToString()),
                        GetraenkeName = getraenkeName,
                        GetraenkeArt = getraenkeArt,
                        Lagerort = lagerort
                    };
                default:
                    return null;

            }
        }
        public Snacks welcherSnack(string aktAnzahl,string snackName,string istSalzig,string snackArt,string lagerort)
        {
            switch (snackArt) {
                case "Chips":
                    return new Chips()
                    {
                        Anzahl = stringToAnzahl(aktAnzahl),
                        SnackName = snackName,
                        IstSalzig = stringToBool(istSalzig),
                        SnackArt = snackArt,
                        Lagerort = lagerort
                    }; 
                case "Erdnüsse":
                    return new Erdnuesse()
                    {
                        Anzahl = stringToAnzahl(aktAnzahl),
                        SnackName = snackName,
                        IstSalzig = stringToBool(istSalzig),
                        SnackArt = snackArt,
                        Lagerort = lagerort
                    };
                case "Erdnussflips":
                    return new ErdnussFlips()
                    {
                        Anzahl = stringToAnzahl(aktAnzahl),
                        SnackName = snackName,
                        IstSalzig = stringToBool(istSalzig),
                        SnackArt = snackArt,
                        Lagerort = lagerort
                    };
                case "Salzstangen":
                    return new Salzstangen()
                    {
                        Anzahl = stringToAnzahl(aktAnzahl),
                        SnackName = snackName,
                        IstSalzig = stringToBool(istSalzig),
                        SnackArt = snackArt,
                        Lagerort = lagerort
                    };
                case "Gummibären":
                    return new Gummibaeren()
                    {
                        Anzahl = stringToAnzahl(aktAnzahl),
                        SnackName = snackName,
                        IstSalzig = stringToBool(istSalzig),
                        SnackArt = snackArt,
                        Lagerort = lagerort
                    };
                default:
                    return null;
            }
        }
    }
}
