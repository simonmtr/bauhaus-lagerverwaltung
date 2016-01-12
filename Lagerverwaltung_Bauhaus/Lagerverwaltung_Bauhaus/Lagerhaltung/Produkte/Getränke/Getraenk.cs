using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lagerverwaltung_Bauhaus.Interfaces;
using Lagerverwaltung_Bauhaus.Lagerhaltung.Orte;

namespace Lagerverwaltung_Bauhaus.Lagerhaltung.Produkte.Getränke
{
    public class Getraenk : ENUMgetraenkeArt, IGetraenk
    {
        //variablen
        public double fuellmenge;
        public bool alkohol;
        public int anzahl;
        public string getraenkeName;
        public ENUMgetraenkeArt.getraenkeArt enumGetraenk;
        public ENUMLagerort.Lagerort enumLagerort;

        //konstruktor
        public Getraenk()
        {
        }
        public Getraenk(double fuellmenge, bool alkohol, int anzahl, string getraenkeName,ENUMgetraenkeArt.getraenkeArt enumGetraenk, ENUMLagerort.Lagerort enumLagerort)
        {
            this.fuellmenge = fuellmenge;
            this.alkohol = alkohol;
            this.anzahl = anzahl;
            this.getraenkeName = getraenkeName;
            this.enumGetraenk=enumGetraenk;
            this.enumLagerort = enumLagerort;

        }
        public virtual Getraenk erstelleGetraenk(double fuellmenge, bool alkohol, int anzahl, string getraenkeName, ENUMgetraenkeArt.getraenkeArt enumGetraenk, ENUMLagerort.Lagerort enumLagerort)
        {
            return new Getraenk(fuellmenge, alkohol, anzahl, getraenkeName, enumGetraenk, enumLagerort);
        }

        // datenbank

        public int GetraenkId { get; set; }
        

        //getter und setter
        public double Fuellmenge
        {
            get;
            set;
        }
        public bool Alkohol
        {
            get;
            set;
        }
        public int Anzahl
        {
            get;
            set;
        }
        public string GetraenkeName
        {
            get;
            set;
        }
    }
}
