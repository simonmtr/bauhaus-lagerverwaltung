using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lagerverwaltung_Bauhaus.Lagerhaltung;
using Lagerverwaltung_Bauhaus.Lagerhaltung.Produkte.Snacks;
using Lagerverwaltung_Bauhaus.Lagerhaltung.Produkte.Snacks.salzig;
using Lagerverwaltung_Bauhaus.Datenbank;
using Lagerverwaltung_Bauhaus.Lagerhaltung.Produkte.Snacks.süß;
using Lagerverwaltung_Bauhaus.Lagerhaltung.Produkte.Getränke;
using Lagerverwaltung_Bauhaus.Lagerhaltung.Produkte.Getränke.alkoholisch;
using Lagerverwaltung_Bauhaus.Lagerhaltung.Produkte.Getränke.unalkoholisch;

namespace Lagerverwaltung_Bauhaus.Factory
{
    public class ObjektverwaltungFactory
    {

        public ObjektverwaltungFactory(){}

        public Getraenk welchesGetraenk(string fuellmenge, string alkohol, string aktAnzahl, string getraenkeName, string getraenkeArt, string lagerort)
        {
            DatenbankChecks dbCheck = new DatenbankChecks();

            switch (getraenkeArt)
            {
                case "Bier":
                    return new Bier()
                    {
                        Fuellmenge = dbCheck.stringToFuellmenge(fuellmenge),
                        Alkohol = dbCheck.stringToBool(alkohol),
                        Anzahl = dbCheck.stringToAnzahl(aktAnzahl.ToString()),
                        GetraenkeName = getraenkeName,
                        GetraenkeArt = getraenkeArt,
                        Lagerort = lagerort
                    };
                case "Wein":
                    return new Wein()
                    {
                        Fuellmenge = dbCheck.stringToFuellmenge(fuellmenge),
                        Alkohol = dbCheck.stringToBool(alkohol),
                        Anzahl = dbCheck.stringToAnzahl(aktAnzahl.ToString()),
                        GetraenkeName = getraenkeName,
                        GetraenkeArt = getraenkeArt,
                        Lagerort = lagerort
                    };
                case "Spirituosen":
                    return new Schnaps()
                    {
                        Fuellmenge = dbCheck.stringToFuellmenge(fuellmenge),
                        Alkohol = dbCheck.stringToBool(alkohol),
                        Anzahl = dbCheck.stringToAnzahl(aktAnzahl.ToString()),
                        GetraenkeName = getraenkeName,
                        GetraenkeArt = getraenkeArt,
                        Lagerort = lagerort
                    };
                case "Kaffee":
                    return new Kaffee()
                    {
                        Fuellmenge = dbCheck.stringToFuellmenge(fuellmenge),
                        Alkohol = dbCheck.stringToBool(alkohol),
                        Anzahl = dbCheck.stringToAnzahl(aktAnzahl.ToString()),
                        GetraenkeName = getraenkeName,
                        GetraenkeArt = getraenkeArt,
                        Lagerort = lagerort
                    };
                case "Saft":
                    return new Saft()
                    {
                        Fuellmenge = dbCheck.stringToFuellmenge(fuellmenge),
                        Alkohol = dbCheck.stringToBool(alkohol),
                        Anzahl = dbCheck.stringToAnzahl(aktAnzahl.ToString()),
                        GetraenkeName = getraenkeName,
                        GetraenkeArt = getraenkeArt,
                        Lagerort = lagerort
                    };
                case "Softdrink":
                    return new Softdrink()
                    {
                        Fuellmenge = dbCheck.stringToFuellmenge(fuellmenge),
                        Alkohol = dbCheck.stringToBool(alkohol),
                        Anzahl = dbCheck.stringToAnzahl(aktAnzahl.ToString()),
                        GetraenkeName = getraenkeName,
                        GetraenkeArt = getraenkeArt,
                        Lagerort = lagerort
                    };
                case "Wasser":
                    return new Wasser()
                    {
                        Fuellmenge = dbCheck.stringToFuellmenge(fuellmenge),
                        Alkohol = dbCheck.stringToBool(alkohol),
                        Anzahl = dbCheck.stringToAnzahl(aktAnzahl.ToString()),
                        GetraenkeName = getraenkeName,
                        GetraenkeArt = getraenkeArt,
                        Lagerort = lagerort
                    };
                default:
                    return null;

            }
        }
        public Snacks welcherSnack(string aktAnzahl, string snackName, string istSalzig, string snackArt, string lagerort)
        {
            DatenbankChecks dbCheck = new DatenbankChecks();
            switch (snackArt)
            {
                case "Chips":
                    return new Chips()
                    {
                        Anzahl = dbCheck.stringToAnzahl(aktAnzahl),
                        SnackName = snackName,
                        IstSalzig = dbCheck.stringToBool(istSalzig),
                        SnackArt = snackArt,
                        Lagerort = lagerort
                    };
                case "Erdnüsse":
                    return new Erdnuesse()
                    {
                        Anzahl = dbCheck.stringToAnzahl(aktAnzahl),
                        SnackName = snackName,
                        IstSalzig = dbCheck.stringToBool(istSalzig),
                        SnackArt = snackArt,
                        Lagerort = lagerort
                    };
                case "Erdnussflips":
                    return new ErdnussFlips()
                    {
                        Anzahl = dbCheck.stringToAnzahl(aktAnzahl),
                        SnackName = snackName,
                        IstSalzig = dbCheck.stringToBool(istSalzig),
                        SnackArt = snackArt,
                        Lagerort = lagerort
                    };
                case "Salzstangen":
                    return new Salzstangen()
                    {
                        Anzahl = dbCheck.stringToAnzahl(aktAnzahl),
                        SnackName = snackName,
                        IstSalzig = dbCheck.stringToBool(istSalzig),
                        SnackArt = snackArt,
                        Lagerort = lagerort
                    };
                case "Gummibären":
                    return new Gummibaeren()
                    {
                        Anzahl = dbCheck.stringToAnzahl(aktAnzahl),
                        SnackName = snackName,
                        IstSalzig = dbCheck.stringToBool(istSalzig),
                        SnackArt = snackArt,
                        Lagerort = lagerort
                    };
                default:
                    return null;
            }
        }


    }
}
