using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lagerverwaltung_Bauhaus.Interfaces;

namespace Lagerverwaltung_Bauhaus.Lagerhaltung.Produkte.Getränke
{
    public class Getraenk : IGetraenk
    {
        //variablen
        public double fuellmenge;
        public bool alkohol;
        public int anzahl;
        public string getraenkeName;
        public string getraenkeArt;
        public string lagerort;

        //konstruktor
        public Getraenk()
        {
        }
        public Getraenk(double fuellmenge, bool alkohol, int anzahl, string getraenkeName,string getraenkeArt, string lagerort)
        {
            this.fuellmenge = fuellmenge;
            this.alkohol = alkohol;
            this.anzahl = anzahl;
            this.getraenkeName = getraenkeName;
            this.getraenkeArt=getraenkeArt;
            this.lagerort = lagerort;

        }
        public virtual Getraenk erstelleGetraenk(double fuellmenge, bool alkohol, int anzahl, string getraenkeName, string getraenkeArt, string lagerort)
        {
            return new Getraenk(fuellmenge, alkohol, anzahl, getraenkeName, getraenkeArt, lagerort);
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
        public string GetraenkeArt
        {
            get;
            set;
        }
        public string Lagerort
        {
            get;
            set;
        }
    }
}
